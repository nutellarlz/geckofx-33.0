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
// Generated by IDLImporter from file nsIPermissionManager.idl
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
    /// This file contains an interface to the Permission Manager,
    /// used to persistenly store permissions for different object types (cookies,
    /// images etc) on a site-by-site basis.
    ///
    /// This service broadcasts the following notification when the permission list
    /// is changed:
    ///
    /// topic  : "perm-changed" (PERM_CHANGE_NOTIFICATION)
    /// broadcast whenever the permission list changes in some way. there
    /// are four possible data strings for this notification; one
    /// notification will be broadcast for each change, and will involve
    /// a single permission.
    /// subject: an nsIPermission interface pointer representing the permission object
    /// that changed.
    /// data   : "deleted"
    /// a permission was deleted. the subject is the deleted permission.
    /// "added"
    /// a permission was added. the subject is the added permission.
    /// "changed"
    /// a permission was changed. the subject is the new permission.
    /// "cleared"
    /// the entire permission list was cleared. the subject is null.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0b83f9d5-3f96-41b6-91aa-ff3a7e4880d7")]
	public interface nsIPermissionManager
	{
		
		/// <summary>
        /// Add permission information for a given URI and permission type. This
        /// operation will cause the type string to be registered if it does not
        /// currently exist. If a permission already exists for a given type, it
        /// will be modified.
        ///
        /// @param uri         the uri to add the permission for
        /// @param type        a case-sensitive ASCII string, identifying the consumer.
        /// Consumers should choose this string to be unique, with
        /// respect to other consumers.
        /// @param permission  an integer representing the desired action (e.g. allow
        /// or deny). The interpretation of this number is up to the
        /// consumer, and may represent different actions for different
        /// types. Consumers may use one of the enumerated permission
        /// actions defined above, for convenience.
        /// NOTE: UNKNOWN_ACTION (0) is reserved to represent the
        /// default permission when no entry is found for a host, and
        /// should not be used by consumers to indicate otherwise.
        /// @param expiretype  a constant defining whether this permission should
        /// never expire (EXPIRE_NEVER), expire at the end of the
        /// session (EXPIRE_SESSION), or expire at a specified time
        /// (EXPIRE_TIME).
        /// @param expiretime  an integer representation of when this permission
        /// should be forgotten (milliseconds since Jan 1 1970 0:00:00).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Add([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type, uint permission, uint expireType, long expireTime);
		
		/// <summary>
        /// Remove permission information for a given host string and permission type.
        /// The host string represents the exact entry in the permission list (such as
        /// obtained from the enumerator), not a URI which that permission might apply
        /// to.
        ///
        /// @param host   the host to remove the permission for
        /// @param type   a case-sensitive ASCII string, identifying the consumer.
        /// The type must have been previously registered using the
        /// add() method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase host, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Clear permission information for all websites.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAll();
		
		/// <summary>
        /// Test whether a website has permission to perform the given action.
        /// @param uri     the uri to be tested
        /// @param type    a case-sensitive ASCII string, identifying the consumer
        /// @param return  see add(), param permission. returns UNKNOWN_ACTION when
        /// there is no stored permission for this uri and / or type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestPermission([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Test whether a website has permission to perform the given action.
        /// This requires an exact hostname match, subdomains are not a match.
        /// @param uri     the uri to be tested
        /// @param type    a case-sensitive ASCII string, identifying the consumer
        /// @param return  see add(), param permission. returns UNKNOWN_ACTION when
        /// there is no stored permission for this uri and / or type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestExactPermission([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type);
		
		/// <summary>
        /// Allows enumeration of all stored permissions
        /// @return an nsISimpleEnumerator interface that allows access to
        /// nsIPermission objects
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetEnumeratorAttribute();
	}
}
