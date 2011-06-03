// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMSVGPoint.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMSVGPoint.idl
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
	
	
	/// <summary>nsIDOMSVGPoint </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("45f18f8f-1315-4447-a7d5-8aeca77bdcaf")]
	public interface nsIDOMSVGPoint
	{
		
		/// <summary>Member GetXAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetXAttribute();
		
		/// <summary>Member SetXAttribute </summary>
		/// <param name='aX'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(double aX);
		
		/// <summary>Member GetYAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetYAttribute();
		
		/// <summary>Member SetYAttribute </summary>
		/// <param name='aY'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(double aY);
		
		/// <summary>Member MatrixTransform </summary>
		/// <param name='matrix'> </param>
		/// <returns>A nsIDOMSVGPoint</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGPoint MatrixTransform([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGMatrix  matrix);
	}
}