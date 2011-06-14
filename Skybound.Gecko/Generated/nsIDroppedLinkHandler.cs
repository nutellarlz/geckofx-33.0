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
// Generated by IDLImporter from file nsIDroppedLinkHandler.idl
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
	
	
	/// <summary>nsIDroppedLinkHandler </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F266B79B-7026-4D2D-B4BD-4F2C6B6C59B4")]
	public interface nsIDroppedLinkHandler
	{
		
		/// <summary>
        /// Determines if a link being dragged can be dropped and returns true if so.
        /// aEvent should be a dragenter or dragover event.
        ///
        /// If aAllowSameDocument is false, drops are only allowed if the document
        /// of the source of the drag is different from the destination. This check
        /// includes any parent, sibling and child frames in the same content tree.
        /// If true, the source is not checked.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanDropLink([MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent aEvent, [MarshalAs(UnmanagedType.Bool)] bool aAllowSameDocument);
		
		/// <summary>
        /// Given a drop event aEvent, determines the link being dragged and returns
        /// it. If a uri is returned the caller can, for instance, load it. If null
        /// is returned, there is no valid link to be dropped. A
        /// NS_ERROR_DOM_SECURITY_ERR error will be thrown and the event cancelled if
        /// the receiving target should not load the uri for security reasons. This
        /// will occur if the source of the drag initiated a link for dragging that
        /// it itself cannot access. This prevents a source document from tricking
        /// the user into a dragging a chrome url for example.
        ///
        /// aName is filled in with the link title if it exists, or an empty string
        /// otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString DropLink([MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent aEvent, [MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
	}
}
