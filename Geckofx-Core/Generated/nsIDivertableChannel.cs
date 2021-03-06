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
// Generated by IDLImporter from file nsIDivertableChannel.idl
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
    /// A channel implementing this interface allows diverting from an
    /// nsIStreamListener in the child process to one in the parent.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4430e0d0-ff70-45f5-99dc-b5fd06943fc1")]
	public interface nsIDivertableChannel
	{
		
		/// <summary>
        /// CHILD ONLY.
        /// Called by Necko client in child process during OnStartRequest to divert
        /// nsIStreamListener and nsIRequest callbacks to the parent process.
        ///
        /// The process should look like the following:
        ///
        /// 1) divertToParent is called in the child process.  It can only be called
        /// during OnStartRequest().
        ///
        /// 2) The ChannelDiverterChild that is returned is an IPDL object. It should
        /// be passed via some other IPDL method of the client's choosing to the
        /// parent.  On the parent the ChannelDiverterParent's divertTo() function
        /// should be called with an nsIStreamListener that will then receive the
        /// OnStartRequest/OnDataAvailable/OnStopRequest for the channel.  The
        /// ChannelDiverterParent can then be deleted (which will also destroy the
        /// ChannelDiverterChild in the child).
        ///
        /// After divertToParent() has been called, NO further function calls
        /// should be made on the channel.  It is a dead object for all purposes.
        /// The reference that the channel holds to the listener in the child is
        /// released is once OnStartRequest completes, and no other
        /// nsIStreamListener calls (OnDataAvailable, OnStopRequest) will be made
        /// to it.
        ///
        /// @return ChannelDiverterChild IPDL actor to be passed to parent process by
        /// client IPDL message, e.g. PClient.DivertUsing(PDiverterChild).
        ///
        /// @throws exception if the channel was canceled early. Throws status code of
        /// canceled channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ChannelDiverterChild DivertToParent();
	}
}
