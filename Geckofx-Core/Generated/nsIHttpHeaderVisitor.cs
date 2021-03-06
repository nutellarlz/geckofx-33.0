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
// Generated by IDLImporter from file nsIHttpHeaderVisitor.idl
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
    /// Implement this interface to visit http headers.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("35412859-b9d9-423c-8866-2d4559fdd2be")]
	public interface nsIHttpHeaderVisitor
	{
		
		/// <summary>
        /// Called by the nsIHttpChannel implementation when visiting request and
        /// response headers.
        ///
        /// @param aHeader
        /// the header being visited.
        /// @param aValue
        /// the header value (possibly a comma delimited list).
        ///
        /// @throw any exception to terminate enumeration
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VisitHeader([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeader, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aValue);
	}
}
