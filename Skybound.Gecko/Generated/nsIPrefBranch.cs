// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPrefBranch.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPrefBranch.idl
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
	
	
	/// <summary>nsIPrefBranch </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56c35506-f14b-11d3-99d3-ddbfac2ccf65")]
	public interface nsIPrefBranch
	{
		
		/// <summary>Member GetRootAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetRootAttribute();
		
		/// <summary>Member GetPrefType </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrefType([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member GetBoolPref </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBoolPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member SetBoolPref </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBoolPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, System.Int32  aValue);
		
		/// <summary>Member GetCharPref </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCharPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member SetCharPref </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, [MarshalAs(UnmanagedType.LPStr)] System.String  aValue);
		
		/// <summary>Member GetIntPref </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIntPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member SetIntPref </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIntPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, System.Int32  aValue);
		
		/// <summary>Member GetComplexValue </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aType'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  GetComplexValue([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, ref System.Guid aType);
		
		/// <summary>Member SetComplexValue </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aType'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetComplexValue([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, ref System.Guid aType, [MarshalAs(UnmanagedType.Interface)] nsISupports  aValue);
		
		/// <summary>Member ClearUserPref </summary>
		/// <param name='aPrefName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearUserPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member LockPref </summary>
		/// <param name='aPrefName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member PrefHasUserValue </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PrefHasUserValue([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member PrefIsLocked </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PrefIsLocked([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member UnlockPref </summary>
		/// <param name='aPrefName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlockPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member DeleteBranch </summary>
		/// <param name='aStartingAt'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteBranch([MarshalAs(UnmanagedType.LPStr)] System.String  aStartingAt);
		
		/// <summary>Member GetChildList </summary>
		/// <param name='aStartingAt'> </param>
		/// <param name='aCount'> </param>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetChildList([MarshalAs(UnmanagedType.LPStr)] System.String  aStartingAt, out System.UInt32  aCount);
		
		/// <summary>Member ResetBranch </summary>
		/// <param name='aStartingAt'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetBranch([MarshalAs(UnmanagedType.LPStr)] System.String  aStartingAt);
	}
}