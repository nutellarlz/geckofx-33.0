﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.DOM.Svg;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class XPConnectTests
	{
		nsIXPConnect m_instance;

		private GeckoWebBrowser _browser;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			// defined in nsIXPConent.idl
			// CB6593E0-F9B2-11d2-BDD6-000064657374
			var ptr = (IntPtr)Xpcom.GetService(new Guid("CB6593E0-F9B2-11d2-BDD6-000064657374"));
			Assert.IsNotNull(ptr);
			m_instance = (nsIXPConnect)Xpcom.GetObjectForIUnknown(ptr);
			Assert.IsNotNull(m_instance);

			_browser = new GeckoWebBrowser();
			var unused = _browser.Handle;
			Assert.IsNotNull(_browser);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			Marshal.ReleaseComObject(m_instance);
		}

		[Test]
		public void GetCurrentJSStackAttribute_ReturnsNull()
		{
			Assert.IsNull(m_instance.GetCurrentJSStackAttribute());
		}

		[Test]
		public void FindInterfaceWithMember_OnADocumentElementLookingForNodeNameMethod_ReturnsInterfaceThatContainsMethodNode()
		{
			_browser.TestLoadHtml("hello world");
			using (AutoJSContext context = new AutoJSContext(_browser.Window.JSContext))
			{
				Guid guid = typeof(nsISupports).GUID;
				IntPtr globalObject = SpiderMonkey.JS_GetGlobalForScopeChain(context.ContextPointer);
				var wrapper = Xpcom.XPConnect.Instance.WrapNative(context.ContextPointer, globalObject, (nsISupports)_browser.Document.DomObject, ref guid);
#if PORT
				var a = m_instance.GetWrappedNativeOfJSObject(context.ContextPointer, wrapper.GetJSObjectAttribute());
				var jsVal = SpiderMonkeyTests.CreateStringJsVal("nodeName");
				var i = a.FindInterfaceWithMember(jsVal.AsPtr);
				Assert.NotNull(i);
				Assert.IsTrue(i.IsScriptable());
				Assert.AreEqual("nsIDOMHTMLDocument", i.GetNameShared());
#else
				throw new NotImplementedException();
#endif
			}
		}

#if DELME
		[Test]
		public void __()
		{
			_browser.TestLoadSvg("<polygon fill='red' stroke='red' points='571,-828 517,-828 517,-792 571,-792 571,-828'/>");

			var a = ((_browser.DomDocument as SvgDocument).RootElement as GeckoNode).ChildNodes[0];
			Console.WriteLine(a);
			Assert.IsTrue(((_browser.DomDocument as SvgDocument).RootElement as GeckoNode).ChildNodes[0] is GeckoElement);
		}
#endif

		[Test]
		public void FindInterfaceWithName_OnADocumentElementLookingDOMHTMLDocumentInterface_ReturnsExpectedInterface()
		{
			_browser.TestLoadHtml("hello world");
			using (AutoJSContext context = new AutoJSContext(_browser.Window.JSContext))
			{
				Guid guid = typeof(nsISupports).GUID;
				IntPtr globalObject = SpiderMonkey.DefaultObjectForContextOrNull(context.ContextPointer);
				SpiderMonkey.JS_EnterCompartment(context.ContextPointer, globalObject);
				var jsVal = context.ConvertCOMObjectToJSVal(globalObject, (nsISupports)_browser.Document.DomObject);
				var type = SpiderMonkey.JS_TypeOfValue(context.ContextPointer, jsVal);
				Console.WriteLine("Type is {0}", type);
				var jsObject = SpiderMonkey.JS_ValueToObject(context.ContextPointer, jsVal);				
#if PORT
				var a = m_instance.GetWrappedNativeOfJSObject(context.ContextPointer, jsObject);
				var wrapper = Xpcom.XPConnect.Instance.WrapNative(context.ContextPointer, globalObject, (nsISupports)_browser.Document.DomObject, ref guid);
				
				var jsVal = SpiderMonkeyTests.CreateStringJsVal("nsIDOMHTMLDocument");
				var i = a.FindInterfaceWithName(jsVal.AsPtr);
				Assert.NotNull(i);
				Assert.IsTrue(i.IsScriptable());
				Assert.AreEqual("nsIDOMHTMLDocument", i.GetNameShared());
#else
				throw new NotImplementedException();
#endif
			}
		}

		#region test showing bug https://bitbucket.org/geckofx/geckofx-22.0/issue/35/invalid-interface

		[Ignore("https://bitbucket.org/geckofx/geckofx-22.0/issue/35/invalid-interface")]
		[Test]
		public void GetWrappedNativePrototype()
		{
			_browser.TestLoadHtml("<span id='a'>hello world</span>");
			var element = _browser.Document.GetHtmlElementById("a");

			using (AutoJSContext context = new AutoJSContext(_browser.Window.JSContext))
			{				
				IntPtr globalObject = SpiderMonkey.JS_GetGlobalForScopeChain(context.ContextPointer);
				var jsobjectholder = m_instance.GetWrappedNativePrototype(context.ContextPointer, globalObject, new MyClassInfo());
				
				string result;
				Console.WriteLine(context.EvaluateScript("this", (nsISupports)jsobjectholder, out result));
				Console.WriteLine(result);				
			}			
		}

		public class MyClassInfo : nsIClassInfo
		{
			public void GetInterfaces(ref uint count, ref Guid[] array)
			{
				count = 1;
				array = new Guid[1];
				array[0] = typeof(nsIDOMDocument).GUID;
			}
#if false
			public void GetInterfaces(ref uint count, ref IntPtr array)
			{
				count = 1;				
				array = Xpcom.Alloc(new IntPtr(IntPtr.Size * count));
				Guid guid = typeof (nsIDOMDocument).GUID;
				var bytearray = guid.ToByteArray();
				IntPtr guidPtr = Xpcom.Alloc(new IntPtr(16));
				for (int i = 0; i < 16; i++)
				{
					Marshal.WriteByte(guidPtr, i, bytearray[i]);
				}				
				Marshal.WriteIntPtr(array, guidPtr);		
			}
#endif

			public nsISupports GetHelperForLanguage(uint language)
			{
				return null;
			}

			public string GetContractIDAttribute()
			{
				throw new NotImplementedException();
			}

			public string GetClassDescriptionAttribute()
			{
				throw new NotImplementedException();
			}

			public IntPtr GetClassIDAttribute()
			{
				throw new NotImplementedException();
			}

			public uint GetImplementationLanguageAttribute()
			{
				throw new NotImplementedException();
			}

			public uint GetFlagsAttribute()
			{
				return 1 << 3;
			}

			public IntPtr GetClassIDNoAllocAttribute()
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		[Ignore("randomly crashes")]
		[Test]
		public void GarbageCollect_ShouldNotThrowException()
		{
			// nsGCType enum:
			// nsGCNormal,
			// nsGCShrinking,
			// nsGCIncremental			
			m_instance.GarbageCollect(0);
		}
	}
}
