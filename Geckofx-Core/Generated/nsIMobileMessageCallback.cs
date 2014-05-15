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
// Generated by IDLImporter from file nsIMobileMessageCallback.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0ee2ada1-fa98-40f1-adb3-0d7fd6df3f48")]
	public interface nsIMobileMessageCallback
	{
		
		/// <summary>
        /// |message| can be nsIDOMMoz{Mms,Sms}Message.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageSent([MarshalAs(UnmanagedType.Interface)] nsISupports message);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySendMessageFailed(int error);
		
		/// <summary>
        /// |message| can be nsIDOMMoz{Mms,Sms}Message.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageGot([MarshalAs(UnmanagedType.Interface)] nsISupports message);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetMessageFailed(int error);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageDeleted([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] bool[] deleted, uint count);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyDeleteMessageFailed(int error);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageMarkedRead([MarshalAs(UnmanagedType.U1)] bool read);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMarkMessageReadFailed(int error);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySegmentInfoForTextGot([MarshalAs(UnmanagedType.Interface)] nsIDOMMozSmsSegmentInfo info);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetSegmentInfoForTextFailed(int error);
		
		/// <summary>
        /// SMSC Address get/set result
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetSmscAddress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSmscAddress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyGetSmscAddressFailed(int error);
	}
	
	/// <summary>nsIMobileMessageCallbackConsts </summary>
	public class nsIMobileMessageCallbackConsts
	{
		
		// <summary>
        // All SMS related errors.
        // Make sure to keep this list in sync with the list in:
        // embedding/android/GeckoSmsManager.java
        // </summary>
		public const ulong SUCCESS_NO_ERROR = 0;
		
		// 
		public const ulong NO_SIGNAL_ERROR = 1;
		
		// 
		public const ulong NOT_FOUND_ERROR = 2;
		
		// 
		public const ulong UNKNOWN_ERROR = 3;
		
		// 
		public const ulong INTERNAL_ERROR = 4;
		
		// 
		public const ulong NO_SIM_CARD_ERROR = 5;
		
		// 
		public const ulong RADIO_DISABLED_ERROR = 6;
		
		// 
		public const ulong INVALID_ADDRESS_ERROR = 7;
		
		// 
		public const ulong FDN_CHECK_ERROR = 8;
		
		// 
		public const ulong NON_ACTIVE_SIM_CARD_ERROR = 9;
	}
}
