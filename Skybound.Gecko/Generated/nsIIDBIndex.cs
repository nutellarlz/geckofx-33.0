// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIIDBIndex.idl
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
	
	
	/// <summary>
    /// IDBIndex interface.  See
    /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-IDBIndex for more
    /// information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9df1ac24-06cf-47d1-9159-3b3d65975b80")]
	public interface nsIIDBIndex
	{
		
		/// <summary>
        /// IDBIndex interface.  See
        /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-IDBIndex for more
        /// information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStoreNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStoreName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeyPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aKeyPath);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUniqueAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBObjectStore GetObjectStoreAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Get([MarshalAs(UnmanagedType.Interface)] nsIVariant key);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetKey([MarshalAs(UnmanagedType.Interface)] nsIVariant key);
		
		/// <summary>
        ///unlimited </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetAll([MarshalAs(UnmanagedType.Interface)] nsIVariant key, uint limit);
		
		/// <summary>
        ///unlimited </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetAllKeys([MarshalAs(UnmanagedType.Interface)] nsIVariant key, uint limit);
		
		/// <summary>
        ///nsIIDBCursor::NEXT </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest OpenCursor([MarshalAs(UnmanagedType.Interface)] nsIIDBKeyRange range, ushort direction);
		
		/// <summary>
        ///nsIIDBCursor::NEXT </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest OpenKeyCursor([MarshalAs(UnmanagedType.Interface)] nsIIDBKeyRange range, ushort direction);
	}
}
