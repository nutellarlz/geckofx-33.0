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
// Generated by IDLImporter from file amIAddonPathService.idl
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
    /// This service maps file system paths where add-ons reside to the ID
    /// of the add-on. Paths are added by the add-on manager. They can
    /// looked up by anyone.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fcd9e270-dfb1-11e3-8b68-0800200c9a66")]
	public interface amIAddonPathService
	{
		
		/// <summary>
        /// Given a path to a file, return the ID of the add-on that the file belongs
        /// to. Returns an empty string if there is no add-on there. Note that if an
        /// add-on is located at /a/b/c, then looking up the path /a/b/c/d will return
        /// that add-on.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FindAddonId([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Call this function to inform the service that the given file system path is
        /// associated with the given add-on ID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertPath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase addonId);
	}
}
