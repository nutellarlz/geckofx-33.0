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
// Generated by IDLImporter from file nsIProperties.idl
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
    /// Simple mapping service interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("78650582-4e93-4b60-8e85-26ebd3eb14ca")]
	public interface nsIProperties
	{
		
		/// <summary>
        /// Gets a property with a given name.
        ///
        /// @return NS_ERROR_FAILURE if a property with that name doesn't exist.
        /// @return NS_ERROR_NO_INTERFACE if the found property fails to QI to the
        /// given iid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Get([MarshalAs(UnmanagedType.LPStr)] string prop, ref System.Guid iid);
		
		/// <summary>
        /// Sets a property with a given name to a given value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Set([MarshalAs(UnmanagedType.LPStr)] string prop, [MarshalAs(UnmanagedType.Interface)] nsISupports value);
		
		/// <summary>
        /// Returns true if the property with the given name exists.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Has([MarshalAs(UnmanagedType.LPStr)] string prop);
		
		/// <summary>
        /// Undefines a property.
        /// @return NS_ERROR_FAILURE if a property with that name doesn't
        /// already exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Undefine([MarshalAs(UnmanagedType.LPStr)] string prop);
		
		/// <summary>
        /// Returns an array of the keys.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr, SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetKeys(out uint count);
	}
}
