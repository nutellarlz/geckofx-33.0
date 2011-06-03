// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: xpctest_attributes.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file xpctest_attributes.idl
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
	
	
	/// <summary>nsIXPCTestObjectReadOnly </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1364941e-4462-11d3-82ee-0060b0eb596f")]
	public interface nsIXPCTestObjectReadOnly
	{
		
		/// <summary>Member GetStrReadOnlyAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetStrReadOnlyAttribute();
		
		/// <summary>Member GetBoolReadOnlyAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetBoolReadOnlyAttribute();
		
		/// <summary>Member GetShortReadOnlyAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetShortReadOnlyAttribute();
		
		/// <summary>Member GetLongReadOnlyAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetLongReadOnlyAttribute();
		
		/// <summary>Member GetFloatReadOnlyAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetFloatReadOnlyAttribute();
		
		/// <summary>Member GetCharReadOnlyAttribute </summary>
		/// <returns>A System.Char </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Char  GetCharReadOnlyAttribute();
		
		/// <summary>Member GetID </summary>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetID();
	}
	
	/// <summary>nsIXPCTestObjectReadWrite </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3b9b1d38-491a-11d3-82ef-0060b0eb596f")]
	public interface nsIXPCTestObjectReadWrite
	{
		
		/// <summary>Member GetStringPropertyAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetStringPropertyAttribute();
		
		/// <summary>Member SetStringPropertyAttribute </summary>
		/// <param name='aStringProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStringPropertyAttribute([MarshalAs(UnmanagedType.LPStr)] System.String  aStringProperty);
		
		/// <summary>Member GetBooleanPropertyAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetBooleanPropertyAttribute();
		
		/// <summary>Member SetBooleanPropertyAttribute </summary>
		/// <param name='aBooleanProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBooleanPropertyAttribute(System.Boolean  aBooleanProperty);
		
		/// <summary>Member GetShortPropertyAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetShortPropertyAttribute();
		
		/// <summary>Member SetShortPropertyAttribute </summary>
		/// <param name='aShortProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShortPropertyAttribute(short aShortProperty);
		
		/// <summary>Member GetLongPropertyAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetLongPropertyAttribute();
		
		/// <summary>Member SetLongPropertyAttribute </summary>
		/// <param name='aLongProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLongPropertyAttribute(System.Int32  aLongProperty);
		
		/// <summary>Member GetFloatPropertyAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetFloatPropertyAttribute();
		
		/// <summary>Member SetFloatPropertyAttribute </summary>
		/// <param name='aFloatProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFloatPropertyAttribute(double aFloatProperty);
		
		/// <summary>Member GetCharPropertyAttribute </summary>
		/// <returns>A System.Char </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Char  GetCharPropertyAttribute();
		
		/// <summary>Member SetCharPropertyAttribute </summary>
		/// <param name='aCharProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharPropertyAttribute(System.Char  aCharProperty);
	}
}