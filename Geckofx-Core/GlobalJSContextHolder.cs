﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Gecko
{
	public static class GlobalJSContextHolder
	{
		private static bool _isInitialized = false;
		private static readonly SpiderMonkey.JSContextCallback _globalContextCallback = GlobalContextCallback;
		private static SpiderMonkey.JSContextCallback _originalContextCallback;
		private static readonly Dictionary<IntPtr, IntPtr> _windowContexts = new Dictionary<IntPtr, IntPtr>();
		private static IntPtr _backstageContext;
		private static IntPtr _safeContext;
		private static IntPtr _runtime;


		private static IntPtr Runtime
		{
			get
			{
				if (_runtime == IntPtr.Zero)
				{
					using (var runtimeService = new Gecko.Interop.ServiceWrapper<nsIJSRuntimeService>("@mozilla.org/js/xpc/RuntimeService;1"))
					{
						_runtime = runtimeService.Instance.GetRuntimeAttribute();
					}
				}
				return _runtime;
			}
		}

		public static IntPtr BackstageJSContext
		{
			get
			{
				if (_backstageContext == IntPtr.Zero)
				{
					_backstageContext = GetContextByName("BackstagePass");
				}
				return _backstageContext;
			}
		}

		public static IntPtr SafeJSContext
		{
			get
			{
				if (_safeContext == IntPtr.Zero)
				{
					_safeContext = GetContextByName("global_for_XPCJSContextStack_SafeJSContext");
				}
				return _safeContext;
			}
		}

		private static IntPtr GetContextByName(string contextName)
		{
			Xpcom.AssertCorrectThread();

			IntPtr rt = Runtime;
			IntPtr iterp = IntPtr.Zero;
			IntPtr cx;
			while ((cx = SpiderMonkey.JS_ContextIterator(rt, ref iterp)) != IntPtr.Zero)
			{
				IntPtr global = SpiderMonkey.JS_GetGlobalObject(cx);
				if (global != IntPtr.Zero)
				{
					IntPtr classp = SpiderMonkey.JS_GetClass(global);
					// get class name
					if (classp != IntPtr.Zero)
					{
						string className = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(classp));
						if (className == contextName)
						{
							return cx;
						}
					}
				}
			}
			return IntPtr.Zero;
		}

		/// <summary>
		/// Add hooks to listen for new JSContext creation and store the context for later use.
		/// </summary>
		internal static void Initialize()
		{
			Xpcom.AssertCorrectThread();

			if (!_isInitialized)
			{
				_isInitialized = true;

				using (var runtimeService = new Gecko.Interop.ServiceWrapper<nsIJSRuntimeService>("@mozilla.org/js/xpc/RuntimeService;1"))
				{
					_originalContextCallback = SpiderMonkey.JS_SetContextCallback(Runtime, _globalContextCallback);
				}
			}
		}

		private static JSBool GlobalContextCallback(IntPtr cx, uint contextOp)
		{
			JSBool result = (_originalContextCallback != null) ? _originalContextCallback(cx, contextOp) : JSBool.JS_TRUE;
			if (result == JSBool.JS_TRUE)
			{
				switch (contextOp)
				{
					//case 0: // JSCONTEXT_NEW
					//	break;
					case 1: // JSCONTEXT_DESTROY
						foreach (var kwp in _windowContexts)
						{
							if (kwp.Value == cx)
							{
								_windowContexts.Remove(kwp.Key);
								break;
							}
						}
						break;
				}
			}
			return result;
		}

		public static IntPtr GetJSContextForDomWindow(nsIDOMWindow window)
		{
			IntPtr context = window.GetWindowRootAttribute().GetJSContextForEventHandlers();
			if (context == IntPtr.Zero)
			{
				IntPtr pUnk = Marshal.GetIUnknownForObject(window);
				Marshal.Release(pUnk);


				if (!_windowContexts.TryGetValue(pUnk, out context))
				{
					context = IntPtr.Zero;

					IntPtr cx;
					IntPtr iterp = IntPtr.Zero;
					IntPtr rt = Runtime;
					while ((cx = SpiderMonkey.JS_ContextIterator(rt, ref iterp)) != IntPtr.Zero)
					{
						IntPtr pGlobal = SpiderMonkey.JS_GetGlobalObject(cx);
						if (pGlobal != IntPtr.Zero)
						{
							using (var auto = new AutoJSContext(cx))
							{
								nsISupports global = auto.GetGlobalNsObject();
								if (global != null)
								{
									var domWindow = Xpcom.QueryInterface<nsIDOMWindow>(global);
									if (domWindow != null)
									{
										try
										{
											IntPtr pUnkTest = Marshal.GetIUnknownForObject(domWindow.GetWindowAttribute());
											Marshal.Release(pUnkTest);

											if (pUnk == pUnkTest)
											{
												_windowContexts.Add(pUnk, cx);
												context = cx;
												break;
											}
										}
										finally
										{
											Marshal.ReleaseComObject(domWindow);
										}
									}
								}
							}
						}
					}
				}
			}
			return context;
		}

		public static void Dispose()
		{
			// Destroy the runtime which causes JS threads to exit to 
			// prevent hanging on exit. (TODO: implement on other platforms)
			if (_runtime != IntPtr.Zero && Xpcom.IsLinux && Xpcom.Is32Bit)
				SpiderMonkey.JS_DestroyRuntime(_runtime);
		}
	}
}
