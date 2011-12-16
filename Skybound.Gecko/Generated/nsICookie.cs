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
// Generated by IDLImporter from file nsICookie.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// An optional interface for accessing the HTTP or
    /// javascript cookie object
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E9FCB9A4-D376-458f-B720-E65E7DF593BC")]
	public interface nsICookie
	{
		
		/// <summary>
        /// the name of the cookie
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aName);
		
		/// <summary>
        /// the cookie value
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aValue);
		
		/// <summary>
        /// true if the cookie is a domain cookie, false otherwise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsDomainAttribute();
		
		/// <summary>
        /// the host (possibly fully qualified) of the cookie
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aHost);
		
		/// <summary>
        /// the path pertaining to the cookie
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aPath);
		
		/// <summary>
        /// true if the cookie was transmitted over ssl, false otherwise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSecureAttribute();
		
		/// <summary>
        /// @DEPRECATED use nsICookie2.expiry and nsICookie2.isSession instead.
        ///
        /// expiration time in seconds since midnight (00:00:00), January 1, 1970 UTC.
        /// expires = 0 represents a session cookie.
        /// expires = 1 represents an expiration time earlier than Jan 1, 1970.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetExpiresAttribute();
		
		/// <summary>
        /// @DEPRECATED status implementation will return STATUS_UNKNOWN in all cases.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetStatusAttribute();
		
		/// <summary>
        /// @DEPRECATED policy implementation will return POLICY_UNKNOWN in all cases.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPolicyAttribute();
	}
}
