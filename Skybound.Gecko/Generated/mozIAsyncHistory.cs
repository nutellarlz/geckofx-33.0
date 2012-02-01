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
// Generated by IDLImporter from file mozIAsyncHistory.idl
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
    /// @status EXPERIMENTAL
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1a3b1260-4bdb-45d0-a306-dc377dd9baa4")]
	public interface mozIVisitInfo
	{
		
		/// <summary>
        /// The machine-local (internal) id of the visit.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetVisitIdAttribute();
		
		/// <summary>
        /// The time the visit occurred.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetVisitDateAttribute();
		
		/// <summary>
        /// The transition type used to get to this visit.  One of the TRANSITION_TYPE
        /// constants on nsINavHistory.
        ///
        /// @see nsINavHistory.idl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTransitionTypeAttribute();
		
		/// <summary>
        /// The referring URI of this visit.  This may be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetReferrerURIAttribute();
		
		/// <summary>
        /// The sessionId of this visit.
        ///
        /// @see nsINavHistory.idl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetSessionIdAttribute();
	}
	
	/// <summary>
    /// @status EXPERIMENTAL
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ad83e137-c92a-4b7b-b67e-0a318811f91e")]
	public interface mozIPlaceInfo
	{
		
		/// <summary>
        /// The machine-local (internal) id of the place.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetPlaceIdAttribute();
		
		/// <summary>
        /// The globally unique id of the place.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aGuid);
		
		/// <summary>
        /// The URI of the place.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetUriAttribute();
		
		/// <summary>
        /// The title associated with the place.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		/// <summary>
        /// The frecency of the place.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetFrecencyAttribute();
		
		/// <summary>
        /// An array of mozIVisitInfo objects for the place.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetVisitsAttribute(System.IntPtr jsContext);
	}
	
	/// <summary>
    /// @status EXPERIMENTAL
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1f266877-2859-418b-a11b-ec3ae4f4f93d")]
	public interface mozIVisitInfoCallback
	{
		
		/// <summary>
        /// Called when the given mozIPlaceInfo object could not be processed.
        ///
        /// @param aResultCode
        /// nsresult indicating the failure reason.
        /// @param aPlaceInfo
        /// The information that was being entered into the database.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleError(int aResultCode, mozIPlaceInfo aPlaceInfo);
		
		/// <summary>
        /// Called for each visit added, title change, or guid change when passed to
        /// mozIAsyncHistory::updatePlaces.  If more than one operation is done for
        /// a given visit, only one callback will be given (i.e. title change and
        /// add visit).
        ///
        /// @param aPlaceInfo
        /// The information that was being entered into the database.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleResult(mozIPlaceInfo aPlaceInfo);
		
		/// <summary>
        /// Called when the mozIAsyncHistory::updatePlaces has finished processing
        /// all mozIPlaceInfo records.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleCompletion();
	}
	
	/// <summary>
    /// @status EXPERIMENTAL
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f79ca67c-7e57-4511-a400-ea31001c762f")]
	public interface mozIAsyncHistory
	{
		
		/// <summary>
        /// Adds a set of visits for one or more mozIPlaceInfo objects, and updates
        /// each mozIPlaceInfo's title or guid.
        ///
        /// @param aPlaceInfo
        /// The mozIPlaceInfo object[s] containing the information to store or
        /// update.  This can be a single object, or an array of objects.
        /// @param [optional] aCallback
        /// A mozIVisitInfoCallback object which consists of callbacks to be
        /// notified for successful and/or failed changes.
        ///
        /// @throws NS_ERROR_INVALID_ARG
        /// - Passing in NULL for aPlaceInfo.
        /// - Not providing at least one valid guid, or uri for all
        /// mozIPlaceInfo object[s].
        /// - Not providing an array or nothing for the visits property of
        /// mozIPlaceInfo.
        /// - Not providing a visitDate and transitionType for each
        /// mozIVisitInfo.
        /// - Providing an invalid transitionType for a mozIVisitInfo.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdatePlaces(System.IntPtr aPlaceInfo, mozIVisitInfoCallback aCallback, System.IntPtr jsContext);
	}
}
