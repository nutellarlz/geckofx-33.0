// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIClipboard.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIClipboard.idl
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
	
	
	/// <summary>nsIClipboard </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("38984945-8674-4d04-b786-5c0ca9434457")]
	public interface nsIClipboard
	{
		
		/// <summary>Member SetData </summary>
		/// <param name='aTransferable'> </param>
		/// <param name='anOwner'> </param>
		/// <param name='aWhichClipboard'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetData([MarshalAs(UnmanagedType.Interface)] nsITransferable  aTransferable, [MarshalAs(UnmanagedType.Interface)] nsIClipboardOwner  anOwner, System.Int32  aWhichClipboard);
		
		/// <summary>Member GetData </summary>
		/// <param name='aTransferable'> </param>
		/// <param name='aWhichClipboard'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetData([MarshalAs(UnmanagedType.Interface)] nsITransferable  aTransferable, System.Int32  aWhichClipboard);
		
		/// <summary>Member EmptyClipboard </summary>
		/// <param name='aWhichClipboard'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EmptyClipboard(System.Int32  aWhichClipboard);
		
		/// <summary>Member HasDataMatchingFlavors </summary>
		/// <param name='aFlavorList'> </param>
		/// <param name='aLength'> </param>
		/// <param name='aWhichClipboard'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasDataMatchingFlavors([MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)] System.String  aFlavorList, System.UInt32  aLength, System.Int32  aWhichClipboard);
		
		/// <summary>Member SupportsSelectionClipboard </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SupportsSelectionClipboard();
	}
}