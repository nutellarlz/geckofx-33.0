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
// Generated by IDLImporter from file nsIUrlListManager.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// Interface for JS function callbacks
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fa4caf12-d057-4e7e-81e9-ce066ceee90b")]
	public interface nsIUrlListManagerCallback
	{
		
		/// <summary>
        /// Interface for JS function callbacks
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase value);
	}
	
	/// <summary>nsIUrlListManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5d5ed98f-72cd-46b6-a9fe-76418adfdfeb")]
	public interface nsIUrlListManager
	{
		
		/// <summary>
        /// Get the gethash url for this table
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGethashUrl([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// Add a table to the list of tables we are managing. The name is a
        /// string of the format provider_name-semantic_type-table_type.  For
        /// @param tableName A string of the format
        /// provider_name-semantic_type-table_type.  For example,
        /// goog-white-enchash or goog-black-url.
        /// @param updateUrl The URL from which to fetch updates.
        /// @param gethashUrl The URL from which to fetch hash completions.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool RegisterTable([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase updateUrl, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase gethashUrl);
		
		/// <summary>
        /// Turn on update checking for a table. I.e., during the next server
        /// check, download updates for this table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableUpdate([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName);
		
		/// <summary>
        /// Turn off update checking for a table.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableUpdate([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName);
		
		/// <summary>
        /// Toggle update checking, if necessary.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MaybeToggleUpdateChecking();
		
		/// <summary>
        /// Lookup a key.  Should not raise exceptions.  Calls the callback
        /// function with a comma-separated list of tables to which the key
        /// belongs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SafeLookup([MarshalAs(UnmanagedType.Interface)] nsIPrincipal key, [MarshalAs(UnmanagedType.Interface)] nsIUrlListManagerCallback cb);
	}
}
