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
// Generated by IDLImporter from file nsIFontEnumerator.idl
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
	
	
	/// <summary>nsIFontEnumerator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("924d98d9-3518-4cb4-8708-c74fe8e3ec3c")]
	public interface nsIFontEnumerator
	{
		
		/// <summary>
        /// Return a sorted array of the names of all installed fonts.
        ///
        /// @param  aCount     returns number of names returned
        /// @param  aResult    returns array of names
        /// @return void
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string EnumerateAllFonts(out uint aCount);
		
		/// <summary>
        /// Return a sorted array of names of fonts that support the given language
        /// group and are suitable for use as the given CSS generic font.
        ///
        /// @param  aLangGroup language group
        /// @param  aGeneric   CSS generic font
        /// @param  aCount     returns number of names returned
        /// @param  aResult    returns array of names
        /// @return void
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=2)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string EnumerateFonts([MarshalAs(UnmanagedType.LPStr)] string aLangGroup, [MarshalAs(UnmanagedType.LPStr)] string aGeneric, out uint aCount);
		
		/// <summary>
        ///@param  aLangGroup language group
        ///    @return bool do we have a font for this language group
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HaveFontFor([MarshalAs(UnmanagedType.LPStr)] string aLangGroup);
		
		/// <summary>
        /// @param  aLangGroup language group
        /// @param  aGeneric CSS generic font
        /// @return suggested default font for this language group and generic family
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDefaultFont([MarshalAs(UnmanagedType.LPStr)] string aLangGroup, [MarshalAs(UnmanagedType.LPStr)] string aGeneric);
		
		/// <summary>
        /// update the global font list
        /// return true if font list is changed
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool UpdateFontList();
		
		/// <summary>
        /// get the standard family name on the system from given family
        /// @param  aName family name which may be alias
        /// @return the standard family name on the system, if given name does not
        /// exist, returns empty string
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetStandardFamilyName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName);
	}
}
