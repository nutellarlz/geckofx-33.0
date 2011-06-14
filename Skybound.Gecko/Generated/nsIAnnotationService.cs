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
// Generated by IDLImporter from file nsIAnnotationService.idl
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
	
	
	/// <summary>nsIAnnotationObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("63fe98e0-6889-4c2c-ac9f-703e4bc25027")]
	public interface nsIAnnotationObserver
	{
		
		/// <summary>
        /// Called when an annotation value is set. It could be a new annotation,
        /// or it could be a new value for an existing annotation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPageAnnotationSet([MarshalAs(UnmanagedType.Interface)] nsIURI aPage, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member OnItemAnnotationSet </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemAnnotationSet(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Called when an annotation is deleted. If aName is empty, then ALL
        /// annotations for the given URI have been deleted. This is not called when
        /// annotations are expired (normally happens when the app exits).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPageAnnotationRemoved([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member OnItemAnnotationRemoved </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemAnnotationRemoved(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
	}
	
	/// <summary>nsIAnnotationService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ba249b58-346f-42a9-a393-203ae34ec6c4")]
	public interface nsIAnnotationService
	{
		
		/// <summary>
        /// Sets an annotation, overwriting any previous annotation with the same
        /// URL/name. IT IS YOUR JOB TO NAMESPACE YOUR ANNOTATION NAMES.
        /// Use the form "namespace/value", so your name would be like
        /// "bills_extension/page_state" or "history/thumbnail".
        ///
        /// Do not use characters that are not valid in URLs such as spaces, ":",
        /// commas, or most other symbols. You should stick to ASCII letters and
        /// numbers plus "_", "-", and "/".
        ///
        /// aExpiration is one of EXPIRE_* above. aFlags should be 0 for now, some
        /// flags will be defined in the future.
        ///
        /// NOTE: ALL PAGE ANNOTATIONS WILL GET DELETED WHEN THE PAGE IS REMOVED FROM
        /// HISTORY IF THE PAGE IS NOT BOOKMARKED. This means that if you create an
        /// annotation on an unvisited URI, it will get deleted when the browser
        /// shuts down. Otherwise, URIs can exist in history as annotations but the
        /// user has no way of knowing it, potentially violating their privacy
        /// expectations about actions such as "Clear history".
        /// If there is an important annotation that the user or extension wants to
        /// keep, you should add a bookmark for the page and use an EXPIRE_NEVER
        /// annotation.  This will ensure the annotation exists until the item is
        /// removed by the user.
        /// See EXPIRE_* constants above for further information.
        ///
        /// The annotation "favicon" is special. Favicons are stored in the favicon
        /// service, but are special cased in the protocol handler so they look like
        /// annotations. Do not set favicons using this service, it will not work.
        ///
        /// Binary annotations should be set using
        /// setItemAnnotationBinary/setPageAnnotationBinary. For other types, only
        /// C++ consumers may use the type-specific methods.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotation(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationString </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationString(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Sets an annotation just like setAnnotationString, but takes an Int32 as
        /// input.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationInt32([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, int aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationInt32 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationInt32(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, int aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Sets an annotation just like setAnnotationString, but takes an Int64 as
        /// input.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationInt64([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, int aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationInt64 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationInt64(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, int aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Sets an annotation just like setAnnotationString, but takes a double as
        /// input.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationDouble([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, double aValue, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationDouble </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationDouble(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, double aValue, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Sets an annotation just like setAnnotationString, but takes binary data
        /// as input. You MUST supply a valid MIME type.
        ///
        /// @throws NS_ERROR_ILLEGAL_VALUE if the page or the bookmark doesn't exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationBinary([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, System.IntPtr aData, uint aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType, int aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationBinary </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aData'> </param>
		/// <param name='aDataLen'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationBinary(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, System.IntPtr aData, uint aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType, int aFlags, ushort aExpiration);
		
		/// <summary>
        /// Retrieves the value of a given annotation. Throws an error if the
        /// annotation does not exist. Throws for binary annotations, for which
        /// getPageAnnotationBinary/getItemAnnotationBinary should be used. C++
        /// consumers may use the type-specific methods.
        ///
        /// The type-specific methods throw if the given annotation is set in
        /// a different type.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetPageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member GetItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A nsIVariant</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetItemAnnotation(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// @see getPageAnnotation
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetPageAnnotationString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member GetItemAnnotationString </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A nsAString</returns>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetItemAnnotationString(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// @see getPageAnnotation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPageAnnotationInt32([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member GetItemAnnotationInt32 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemAnnotationInt32(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// @see getPageAnnotation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPageAnnotationInt64([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member GetItemAnnotationInt64 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemAnnotationInt64(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// @see getPageAnnotation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPageAnnotationDouble([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member GetItemAnnotationDouble </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetItemAnnotationDouble(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// @see getPageAnnotation. This also returns the
        /// MIME type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageAnnotationBinary([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, out System.IntPtr aData, out uint aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType);
		
		/// <summary>Member GetItemAnnotationBinary </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aData'> </param>
		/// <param name='aDataLen'> </param>
		/// <param name='aMimeType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemAnnotationBinary(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, out System.IntPtr aData, out uint aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType);
		
		/// <summary>
        /// Retrieves info about an existing annotation. aMimeType will be empty
        /// if the value was not binary data.
        ///
        /// aType will be one of TYPE_* constansts above
        ///
        /// example JS:
        /// var flags = {}, exp = {}, mimeType = {};
        /// annotator.getAnnotationInfo(myURI, "foo", flags, exp, mimeType);
        /// // now you can use 'exp.value' and 'flags.value'
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageAnnotationInfo([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, out int aFlags, out ushort aExpiration, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType, out ushort aType);
		
		/// <summary>Member GetItemAnnotationInfo </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemAnnotationInfo(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName, out int aFlags, out ushort aExpiration, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType, out ushort aType);
		
		/// <summary>
        /// Retrieves the type of an existing annotation
        /// Use getAnnotationInfo if you need this along with the mime-type etc.
        ///
        /// @param aURI
        /// the uri on which the annotation is set
        /// @param aName
        /// the annotation name
        /// @return one of the TYPE_* constants above
        /// @throws if the annotation is not set
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPageAnnotationType([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member GetItemAnnotationType </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetItemAnnotationType(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Returns a list of all URIs having a given annotation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetPagesWithAnnotation([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String name, out uint resultCount);
		
		/// <summary>Member GetItemsWithAnnotation </summary>
		/// <param name='name'> </param>
		/// <param name='resultCount'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemsWithAnnotation([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String name, out uint resultCount);
		
		/// <summary>
        /// Get the names of all annotations for this URI.
        ///
        /// example JS:
        /// var annotations = annotator.getPageAnnotations(myURI, {});
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetPageAnnotationNames([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, out uint count);
		
		/// <summary>Member GetItemAnnotationNames </summary>
		/// <param name='aItemId'> </param>
		/// <param name='count'> </param>
		/// <returns>A nsIVariant</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetItemAnnotationNames(int aItemId, out uint count);
		
		/// <summary>
        /// Test for annotation existence.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PageHasAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member ItemHasAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ItemHasAnnotation(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Removes a specific annotation. Succeeds even if the annotation is
        /// not found.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member RemoveItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItemAnnotation(int aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Removes all annotations for the given page/item.
        /// We may want some other similar functions to get annotations with given
        /// flags (once we have flags defined).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePageAnnotations([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>Member RemoveItemAnnotations </summary>
		/// <param name='aItemId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItemAnnotations(int aItemId);
		
		/// <summary>
        /// Copies all annotations from the source to the destination URI/item. If
        /// the destination already has an annotation with the same name as one on
        /// the source, it will be overwritten if aOverwriteDest is set. Otherwise,
        /// the original annotation will be preferred.
        ///
        /// All the source annotations will stay as-is. If you don't want them
        /// any more, use removePageAnnotations on that URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyPageAnnotations([MarshalAs(UnmanagedType.Interface)] nsIURI aSourceURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aDestURI, [MarshalAs(UnmanagedType.Bool)] bool aOverwriteDest);
		
		/// <summary>Member CopyItemAnnotations </summary>
		/// <param name='aSourceItemId'> </param>
		/// <param name='aDestItemId'> </param>
		/// <param name='aOverwriteDest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyItemAnnotations(int aSourceItemId, int aDestItemId, [MarshalAs(UnmanagedType.Bool)] bool aOverwriteDest);
		
		/// <summary>
        /// Adds an annotation observer. The annotation service will keep an owning
        /// reference to the observer object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIAnnotationObserver aObserver);
		
		/// <summary>
        /// Removes an annotaton observer previously registered by addObserver.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIAnnotationObserver aObserver);
		
		/// <summary>
        /// Returns a URI that can be used to access the given binary annotation.
        /// This function does NOT check that the annotation exists. Also, note that
        /// you can only load URIs for annotations that have have a valid MIME type
        /// set by setAnnotationBinary. No non-URI valid chars in name, especially
        /// colon, which will mess up parsing.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetAnnotationURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
	}
}
