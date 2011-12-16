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
// Generated by IDLImporter from file nsIDOMGeoPositionAddress.idl
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
	
	
	/// <summary>nsIDOMGeoPositionAddress </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0DF49C5C-9845-42F9-A76C-62E09C110986")]
	public interface nsIDOMGeoPositionAddress
	{
		
		/// <summary>Member GetStreetNumberAttribute </summary>
		/// <param name='aStreetNumber'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStreetNumberAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStreetNumber);
		
		/// <summary>Member GetStreetAttribute </summary>
		/// <param name='aStreet'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStreetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStreet);
		
		/// <summary>Member GetPremisesAttribute </summary>
		/// <param name='aPremises'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPremisesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPremises);
		
		/// <summary>Member GetCityAttribute </summary>
		/// <param name='aCity'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCityAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCity);
		
		/// <summary>Member GetCountyAttribute </summary>
		/// <param name='aCounty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCountyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCounty);
		
		/// <summary>Member GetRegionAttribute </summary>
		/// <param name='aRegion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRegionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRegion);
		
		/// <summary>Member GetCountryAttribute </summary>
		/// <param name='aCountry'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCountryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCountry);
		
		/// <summary>Member GetCountryCodeAttribute </summary>
		/// <param name='aCountryCode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCountryCodeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCountryCode);
		
		/// <summary>Member GetPostalCodeAttribute </summary>
		/// <param name='aPostalCode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPostalCodeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPostalCode);
	}
}
