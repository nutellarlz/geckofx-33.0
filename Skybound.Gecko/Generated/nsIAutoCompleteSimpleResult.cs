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
// Generated by IDLImporter from file nsIAutoCompleteSimpleResult.idl
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
    /// This class implements nsIAutoCompleteResult and provides simple methods
    /// for setting the value and result items. It can be used whenever some basic
    /// auto complete results are needed that can be pre-generated and filled into
    /// an array.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f9841787-ad26-49e6-a2dd-ba9020ee1c64")]
	public interface nsIAutoCompleteSimpleResult : nsIAutoCompleteResult
	{
		
		/// <summary>
        /// The original search string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSearchStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearchString);
		
		/// <summary>
        /// The result of the search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetSearchResultAttribute();
		
		/// <summary>
        /// Index of the default item that should be entered if none is selected
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetDefaultIndexAttribute();
		
		/// <summary>
        /// A string describing the cause of a search failure
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetErrorDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aErrorDescription);
		
		/// <summary>
        /// The number of matches
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetMatchCountAttribute();
		
		/// <summary>
        /// Get the value of the result at the given index
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetValueAt(int index);
		
		/// <summary>
        /// This returns the string that is displayed in the dropdown
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetLabelAt(int index);
		
		/// <summary>
        /// Get the comment of the result at the given index
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetCommentAt(int index);
		
		/// <summary>
        /// Get the style hint for the result at the given index
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetStyleAt(int index);
		
		/// <summary>
        /// Get the image of the result at the given index
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetImageAt(int index);
		
		/// <summary>
        /// Remove the value at the given index from the autocomplete results.
        /// If removeFromDb is set to true, the value should be removed from
        /// persistent storage as well.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveValueAt(int rowIndex, [MarshalAs(UnmanagedType.Bool)] bool removeFromDb);
		
		/// <summary>
        /// A writer for the readonly attribute 'searchString' which should contain
        /// the string that the user typed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchString([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearchString);
		
		/// <summary>
        /// A writer for the readonly attribute 'errorDescription'.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetErrorDescription([MarshalAs(UnmanagedType.LPStruct)] nsAString aErrorDescription);
		
		/// <summary>
        /// A writer for the readonly attribute 'defaultIndex' which should contain
        /// the index of the list that will be selected by default (normally 0).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultIndex(int aDefaultIndex);
		
		/// <summary>
        /// A writer for the readonly attribute 'searchResult' which should contain
        /// one of the constants nsIAutoCompleteResult.RESULT_* indicating the success
        /// of the search.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchResult(ushort aSearchResult);
		
		/// <summary>
        /// Appends a result item consisting of the given value, comment, image and style.
        /// This is how you add results.  Note:  image and style are optional.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendMatch([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, [MarshalAs(UnmanagedType.LPStruct)] nsAString aComment, [MarshalAs(UnmanagedType.LPStruct)] nsAString aImage, [MarshalAs(UnmanagedType.LPStruct)] nsAString aStyle);
		
		/// <summary>
        /// Sets a listener for changes in the result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetListener([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteSimpleResultListener aListener);
	}
	
	/// <summary>nsIAutoCompleteSimpleResultListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("004efdc5-1989-4874-8a7a-345bf2fa33af")]
	public interface nsIAutoCompleteSimpleResultListener
	{
		
		/// <summary>
        /// Dispatched after a value is removed from the result.
        /// @param aResult
        /// The result from which aValue has been removed.
        /// @param aValue
        /// The removed value.
        /// @param aRemoveFromDb
        /// Whether the value should be removed from persistent storage as well.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnValueRemoved([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteSimpleResult aResult, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, [MarshalAs(UnmanagedType.Bool)] bool aRemoveFromDb);
	}
}
