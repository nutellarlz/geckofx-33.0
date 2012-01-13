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
// Generated by IDLImporter from file inICSSValueSearch.idl
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
	
	
	/// <summary>inICSSValueSearch </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0d39e48-1dd1-11b2-81bd-9a0c117f0736")]
	public interface inICSSValueSearch : inISearchProcess
	{
		
		/// <summary>
        /// indicates if an asynchronous search is in progress
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsActiveAttribute();
		
		/// <summary>
        /// the number of results returned
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetResultCountAttribute();
		
		/// <summary>
        /// other than the most recent one, and getResults will return null always.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetHoldResultsAttribute();
		
		/// <summary>
        /// other than the most recent one, and getResults will return null always.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHoldResultsAttribute([MarshalAs(UnmanagedType.Bool)] bool aHoldResults);
		
		/// <summary>
        /// start a synchronous search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SearchSync();
		
		/// <summary>
        /// start an asynchronous search
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SearchAsync(inISearchObserver aObserver);
		
		/// <summary>
        /// command an async process to stop immediately
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SearchStop();
		
		/// <summary>
        /// and is not for use by those who just wish to call searchAsync
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool SearchStep();
		
		/// <summary>
        /// methods for getting results of specific types
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetStringResultAt(int aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>Member GetIntResultAt </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetIntResultAt(int aIndex);
		
		/// <summary>Member GetUIntResultAt </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetUIntResultAt(int aIndex);
		
		/// <summary>Member GetDocumentAttribute </summary>
		/// <returns>A nsIDOMDocument</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDocumentAttribute();
		
		/// <summary>Member SetDocumentAttribute </summary>
		/// <param name='aDocument'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument);
		
		/// <summary>
        /// the base url for all returned URL results, if returnRelativeURLs is true
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetBaseURLAttribute();
		
		/// <summary>
        /// the base url for all returned URL results, if returnRelativeURLs is true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aBaseURL);
		
		/// <summary>
        /// strip off the baseURL for all URL results if true
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReturnRelativeURLsAttribute();
		
		/// <summary>
        /// strip off the baseURL for all URL results if true
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReturnRelativeURLsAttribute([MarshalAs(UnmanagedType.Bool)] bool aReturnRelativeURLs);
		
		/// <summary>
        /// correct the paths on a chrome url, such as turning global/skin/blah into global/blah
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetNormalizeChromeURLsAttribute();
		
		/// <summary>
        /// correct the paths on a chrome url, such as turning global/skin/blah into global/blah
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNormalizeChromeURLsAttribute([MarshalAs(UnmanagedType.Bool)] bool aNormalizeChromeURLs);
		
		/// <summary>
        /// add a css property to search for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddPropertyCriteria([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPropName);
		
		/// <summary>
        /// set the text value to search for in the properties specified (optional)
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTextCriteriaAttribute();
		
		/// <summary>
        /// set the text value to search for in the properties specified (optional)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextCriteriaAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTextCriteria);
	}
}
