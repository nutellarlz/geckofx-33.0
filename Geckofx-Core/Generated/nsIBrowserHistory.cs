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
// Generated by IDLImporter from file nsIBrowserHistory.idl
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
    /// browser-specific interface to global history
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d092f5a5-33a8-456c-ac89-6ae6f880bd04")]
	public interface nsIBrowserHistory : nsIGlobalHistory2
	{
		
		/// <summary>
        /// Add a URI to global history
        ///
        /// @param aURI      the URI of the page
        /// @param aRedirect whether the URI was redirected to another location;
        /// this is 'true' for the original URI which is
        /// redirected.
        /// @param aToplevel whether the URI is loaded in a top-level window
        /// @param aReferrer the URI of the referring page
        ///
        /// @note  Docshell will not filter out URI schemes like chrome: data:
        /// about: and view-source:.  Embedders should consider filtering out
        /// these schemes and others, e.g. mailbox: for the main URI and the
        /// referrer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.U1)] bool aRedirect, [MarshalAs(UnmanagedType.U1)] bool aToplevel, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);
		
		/// <summary>
        /// Checks to see whether the given URI is in history.
        ///
        /// @param aURI the uri to the page
        /// @return true if a URI has been visited
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsVisited([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Set the page title for the given uri. URIs that are not already in
        /// global history will not be added.
        ///
        /// @param aURI    the URI for which to set to the title
        /// @param aTitle  the page title
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPageTitle([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// Used by the History migrator to add a page to global history, with a
        /// specific title and last visit time.
        ///
        /// @param aURI
        /// URI of the page to be added.
        /// @param aTitle
        /// Title of the page.
        /// @param aLastvisited
        /// Microseconds from epoch representing the last visit time.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddPageWithDetails([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTitle, long aLastVisited);
		
		/// <summary>
        /// Indicates if there are entries in global history.
        ///
        /// @note For performance reasons this is not the real number of entries.
        /// It will instead evaluate to 0 for no entries, 1 otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCountAttribute();
		
		/// <summary>
        /// Removes a page from global history.
        ///
        /// @note It is preferrable to use this one rather then RemovePages when
        /// removing less than 10 pages, since it won't start a full batch
        /// operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Removes a list of pages from global history.
        ///
        /// @param aURIs
        /// Array of URIs to be removed.
        /// @param aLength
        /// Length of the array.
        ///
        /// @note the removal happens in a batch.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePages([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] nsIURI[] aURIs, uint aLength);
		
		/// <summary>
        /// Removes all global history information about pages for a given host.
        ///
        /// @param aHost
        /// Hostname to be removed.
        /// An empty host name means local files and anything else with no
        /// hostname.  You can also pass in the localized "(local files)"
        /// title given to you from a history query to remove all
        /// history information from local files.
        /// @param aEntireDomain
        /// If true, will also delete pages from sub hosts (so if
        /// passed in "microsoft.com" will delete "www.microsoft.com",
        /// "msdn.microsoft.com", etc.).
        ///
        /// @note The removal happens in a batch.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePagesFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, [MarshalAs(UnmanagedType.U1)] bool aEntireDomain);
		
		/// <summary>
        /// Removes all pages for a given timeframe.
        /// Limits are included: aBeginTime <= timeframe <= aEndTime
        ///
        /// @param aBeginTime
        /// Microseconds from epoch, representing the initial time.
        /// @param aEndTime
        /// Microseconds from epoch, representing the final time.
        ///
        /// @note The removal happens in a batch.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePagesByTimeframe(long aBeginTime, long aEndTime);
		
		/// <summary>
        /// Removes all visits in a given timeframe.
        /// Limits are included: aBeginTime <= timeframe <= aEndTime.
        /// Any pages that becomes unvisited as a result will also be deleted.
        ///
        /// @param aBeginTime
        /// Microseconds from epoch, representing the initial time.
        /// @param aEndTime
        /// Microseconds from epoch, representing the final time.
        ///
        /// @note The removal happens in a batch.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveVisitsByTimeframe(long aBeginTime, long aEndTime);
		
		/// <summary>
        /// Removes all existing pages from global history.
        /// Visits are removed synchronously, but pages are expired asynchronously
        /// off the main-thread.
        ///
        /// @note The removal happens in a batch. Single removals are not notified,
        /// instead an onClearHistory notification is sent to
        /// nsINavHistoryObserver implementers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllPages();
		
		/// <summary>
        /// Hides the specified URL from being enumerated (and thus displayed in
        /// the UI).
        ///
        /// @param aURI
        /// URI of the page to be marked.
        ///
        /// @note If the page hasn't been visited yet, then it will be added
        /// as if it was visited, and then marked as hidden
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HidePage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Designates the url as having been explicitly typed in by the user.
        ///
        /// @param aURI
        /// URI of the page to be marked.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkPageAsTyped([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Designates the url as coming from a link explicitly followed by
        /// the user (for example by clicking on it).
        ///
        /// @param aURI
        /// URI of the page to be marked.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkPageAsFollowedLink([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
	}
}