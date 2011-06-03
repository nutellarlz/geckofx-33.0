// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsICollection.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsICollection.idl
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
	
	
	/// <summary>nsICollection </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("83b6019c-cbc4-11d2-8cca-0060b0fc14a3")]
	public interface nsICollection : nsISerializable
	{
		
		/// <summary>Member Read </summary>
		/// <param name='aInputStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream  aInputStream);
		
		/// <summary>Member Write </summary>
		/// <param name='aOutputStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream  aOutputStream);
		
		/// <summary>Member Count </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Count();
		
		/// <summary>Member GetElementAt </summary>
		/// <param name='index'> </param>
		/// <returns>A nsISupports</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetElementAt(System.UInt32  index);
		
		/// <summary>Member QueryElementAt </summary>
		/// <param name='index'> </param>
		/// <param name='uuid'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  QueryElementAt(System.UInt32  index, ref System.Guid uuid);
		
		/// <summary>Member SetElementAt </summary>
		/// <param name='index'> </param>
		/// <param name='item'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetElementAt(System.UInt32  index, [MarshalAs(UnmanagedType.Interface)] nsISupports  item);
		
		/// <summary>Member AppendElement </summary>
		/// <param name='item'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendElement([MarshalAs(UnmanagedType.Interface)] nsISupports  item);
		
		/// <summary>Member RemoveElement </summary>
		/// <param name='item'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveElement([MarshalAs(UnmanagedType.Interface)] nsISupports  item);
		
		/// <summary>Member Enumerate </summary>
		/// <returns>A nsIEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIEnumerator Enumerate();
		
		/// <summary>Member Clear </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
	}
}