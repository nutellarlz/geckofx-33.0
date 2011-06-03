// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWindowMediatorListener.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWindowMediatorListener.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIWindowMediatorListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2F276982-0D60-4377-A595-D350BA516395")]
	public interface nsIWindowMediatorListener
	{
		
		/// <summary>Member OnWindowTitleChange </summary>
		/// <param name='window'> </param>
		/// <param name='newTitle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnWindowTitleChange([MarshalAs(UnmanagedType.Interface)] nsIXULWindow  window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string newTitle);
		
		/// <summary>Member OnOpenWindow </summary>
		/// <param name='window'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnOpenWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow  window);
		
		/// <summary>Member OnCloseWindow </summary>
		/// <param name='window'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnCloseWindow([MarshalAs(UnmanagedType.Interface)] nsIXULWindow  window);
	}
}