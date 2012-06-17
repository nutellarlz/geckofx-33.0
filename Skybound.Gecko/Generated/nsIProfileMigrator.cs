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
// Generated by IDLImporter from file nsIProfileMigrator.idl
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
    /// Helper interface for nsIProfileMigrator.
    ///
    /// @provider Toolkit (Startup code)
    /// @client   Application (Profile-migration code)
    /// @obtainable nsIProfileMigrator.migrate
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("048e5ca1-0eb7-4bb1-a9a2-a36f7d4e0e3c")]
	public interface nsIProfileStartup
	{
		
		/// <summary>
        /// The root directory of the semi-current profile, during profile migration.
        /// After nsIProfileMigrator.migrate has returned, this object will not be
        /// useful.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetDirectoryAttribute();
		
		/// <summary>
        /// Do profile-startup by setting NS_APP_USER_PROFILE_50_DIR in the directory
        /// service and notifying the profile-startup observer topics.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoStartup();
	}
	
	/// <summary>
    /// Migrate application settings from an outside source.
    ///
    /// @provider Application (Profile-migration code)
    /// @client   Toolkit (Startup code)
    /// @obtainable service, contractid("@mozilla.org/toolkit/profile-migrator;1")
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3df284a5-2258-4d46-a664-761ecdc04c22")]
	public interface nsIProfileMigrator
	{
		
		/// <summary>
        /// Migrate data from an outside source, if possible.  Does nothing
        /// otherwise.
        ///
        /// When this method is called, a default profile has been created;
        /// XPCOM has been initialized such that compreg.dat is in the
        /// profile; the directory service does *not* return a key for
        /// NS_APP_USER_PROFILE_50_DIR or any of the keys depending on an active
        /// profile. To figure out the directory of the "current" profile, use
        /// aStartup.directory.
        ///
        /// If your migrator needs to access services that use the profile (to
        /// set profile prefs or bookmarks, for example), use aStartup.doStartup.
        ///
        /// @param  aStartup nsIProfileStartup object to use during migration.
        /// @param  aKey     optional key of a migrator to use to skip source selection.
        ///
        /// @note The startup code ignores COM exceptions thrown from this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Migrate([MarshalAs(UnmanagedType.Interface)] nsIProfileStartup aStartup, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);
	}
}
