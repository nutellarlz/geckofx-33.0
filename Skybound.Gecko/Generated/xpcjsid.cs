// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: xpcjsid.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file xpcjsid.idl
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
	
	
	/// <summary>nsIJSID </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("baedc96a-9cee-4b6b-9160-90d257b3c8ef")]
	public interface nsIJSID
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetNameAttribute();
		
		/// <summary>Member GetNumberAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetNumberAttribute();
		
		/// <summary>Member GetValidAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetValidAttribute();
		
		/// <summary>Member Equals </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIJSID  other);
		
		/// <summary>Member Initialize </summary>
		/// <param name='idString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Initialize([MarshalAs(UnmanagedType.LPStr)] System.String  idString);
		
		/// <summary>Member ToString </summary>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
		
		/// <summary>Member GetID </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetID();
	}
	
	/// <summary>nsIJSIID </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e76ec564-a080-4705-8609-384c755ec91e")]
	public interface nsIJSIID : nsIJSID
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetNameAttribute();
		
		/// <summary>Member GetNumberAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetNumberAttribute();
		
		/// <summary>Member GetValidAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetValidAttribute();
		
		/// <summary>Member Equals </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIJSID  other);
		
		/// <summary>Member Initialize </summary>
		/// <param name='idString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Initialize([MarshalAs(UnmanagedType.LPStr)] System.String  idString);
		
		/// <summary>Member ToString </summary>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string ToString();
		
		/// <summary>Member GetID </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetID();
	}
	
	/// <summary>nsIJSCID </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("26b2a374-6eaf-46d4-acaf-1c6be152d36b")]
	public interface nsIJSCID : nsIJSID
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetNameAttribute();
		
		/// <summary>Member GetNumberAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetNumberAttribute();
		
		/// <summary>Member GetValidAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetValidAttribute();
		
		/// <summary>Member Equals </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIJSID  other);
		
		/// <summary>Member Initialize </summary>
		/// <param name='idString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Initialize([MarshalAs(UnmanagedType.LPStr)] System.String  idString);
		
		/// <summary>Member ToString </summary>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string ToString();
		
		/// <summary>Member GetID </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetID();
		
		/// <summary>Member CreateInstance </summary>
		/// <returns>A nsISupports</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports CreateInstance();
		
		/// <summary>Member GetService </summary>
		/// <returns>A nsISupports</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetService();
	}
}