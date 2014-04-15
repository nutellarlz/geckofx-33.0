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
// Generated by IDLImporter from file nsIX509Cert.idl
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
    /// This represents a X.509 certificate.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("45b24b0a-6189-4b05-af0b-8d4d66d57c59")]
	public interface nsIX509Cert
	{
		
		/// <summary>
        /// A nickname for the certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNicknameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNickname);
		
		/// <summary>
        /// The primary email address of the certificate, if present.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEmailAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEmailAddress);
		
		/// <summary>
        /// Obtain a list of all email addresses
        /// contained in the certificate.
        ///
        /// @param length The number of strings in the returned array.
        /// @return An array of email addresses.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEmailAddresses(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] addresses);
		
		/// <summary>
        /// Check whether a given address is contained in the certificate.
        /// The comparison will convert the email address to lowercase.
        /// The behaviour for non ASCII characters is undefined.
        ///
        /// @param aEmailAddress The address to search for.
        ///
        /// @return True if the address is contained in the certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ContainsEmailAddress([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEmailAddress);
		
		/// <summary>
        /// The subject owning the certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSubjectNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSubjectName);
		
		/// <summary>
        /// The subject's common name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommonNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCommonName);
		
		/// <summary>
        /// The subject's organization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrganizationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aOrganization);
		
		/// <summary>
        /// The subject's organizational unit.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrganizationalUnitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aOrganizationalUnit);
		
		/// <summary>
        /// The fingerprint of the certificate's public key,
        /// calculated using the SHA1 algorithm.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSha1FingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSha1Fingerprint);
		
		/// <summary>
        /// The fingerprint of the certificate's public key,
        /// calculated using the MD5 algorithm.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMd5FingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMd5Fingerprint);
		
		/// <summary>
        /// A human readable name identifying the hardware or
        /// software token the certificate is stored on.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTokenNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTokenName);
		
		/// <summary>
        /// The subject identifying the issuer certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIssuerNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIssuerName);
		
		/// <summary>
        /// The serial number the issuer assigned to this certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSerialNumberAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSerialNumber);
		
		/// <summary>
        /// The issuer subject's common name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIssuerCommonNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIssuerCommonName);
		
		/// <summary>
        /// The issuer subject's organization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIssuerOrganizationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIssuerOrganization);
		
		/// <summary>
        /// The issuer subject's organizational unit.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIssuerOrganizationUnitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIssuerOrganizationUnit);
		
		/// <summary>
        /// The certificate used by the issuer to sign this certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509Cert GetIssuerAttribute();
		
		/// <summary>
        /// This certificate's validity period.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509CertValidity GetValidityAttribute();
		
		/// <summary>
        /// A unique identifier of this certificate within the local storage.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDbKeyAttribute();
		
		/// <summary>
        /// A human readable identifier to label this certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetWindowTitleAttribute();
		
		/// <summary>
        /// Obtain a list of certificates that contains this certificate
        /// and the issuing certificates of all involved issuers,
        /// up to the root issuer.
        ///
        /// @return The chain of certifficates including the issuers.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetChain();
		
		/// <summary>
        /// Obtain an array of human readable strings describing
        /// the certificate's certified usages.
        ///
        /// @param localOnly Do not hit the network, even if revocation information
        /// downloading is currently activated.
        /// @param verified The certificate verification result, see constants.
        /// @param count The number of human readable usages returned.
        /// @param usages The array of human readable usages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsagesArray([MarshalAs(UnmanagedType.U1)] bool localOnly, ref uint verified, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] ref System.IntPtr[] usages);
		
		/// <summary>
        /// Obtain a single comma separated human readable string describing
        /// the certificate's certified usages.
        ///
        /// @param localOnly Do not hit the network, even if revocation information
        /// downloading is currently activated.
        /// @param verified The certificate verification result, see constants.
        /// @param purposes The string listing the usages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsagesString([MarshalAs(UnmanagedType.U1)] bool localOnly, ref uint verified, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase usages);
		
		/// <summary>
        /// This is the attribute which describes the ASN1 layout
        /// of the certificate.  This can be used when doing a
        /// "pretty print" of the certificate's ASN1 structure.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIASN1Object GetASN1StructureAttribute();
		
		/// <summary>
        /// Obtain a raw binary encoding of this certificate
        /// in DER format.
        ///
        /// @param length The number of bytes in the binary encoding.
        /// @param data The bytes representing the DER encoded certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRawDER(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref byte[] data);
		
		/// <summary>
        /// Test whether two certificate instances represent the
        /// same certificate.
        ///
        /// @return Whether the certificates are equal
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIX509Cert other);
	}
	
	/// <summary>nsIX509CertConsts </summary>
	public class nsIX509CertConsts
	{
		
		// <summary>
        // Constants to classify the type of a certificate.
        // </summary>
		public const ulong UNKNOWN_CERT = 0;
		
		// 
		public const ulong CA_CERT = 1<<0;
		
		// 
		public const ulong USER_CERT = 1<<1;
		
		// 
		public const ulong EMAIL_CERT = 1<<2;
		
		// 
		public const ulong SERVER_CERT = 1<<3;
		
		// <summary>
        // Constants for certificate verification results.
        // </summary>
		public const ulong VERIFIED_OK = 0;
		
		// 
		public const ulong NOT_VERIFIED_UNKNOWN = 1<<0;
		
		// 
		public const ulong CERT_REVOKED = 1<<1;
		
		// 
		public const ulong CERT_EXPIRED = 1<<2;
		
		// 
		public const ulong CERT_NOT_TRUSTED = 1<<3;
		
		// 
		public const ulong ISSUER_NOT_TRUSTED = 1<<4;
		
		// 
		public const ulong ISSUER_UNKNOWN = 1<<5;
		
		// 
		public const ulong INVALID_CA = 1<<6;
		
		// 
		public const ulong USAGE_NOT_ALLOWED = 1<<7;
		
		// 
		public const ulong SIGNATURE_ALGORITHM_DISABLED = 1<<8;
		
		// <summary>
        // Constants that describe the certified usages of a certificate.
        //
        // Deprecated and unused
        // </summary>
		public const ulong CERT_USAGE_SSLClient = 0;
		
		// 
		public const ulong CERT_USAGE_SSLServer = 1;
		
		// 
		public const ulong CERT_USAGE_SSLServerWithStepUp = 2;
		
		// 
		public const ulong CERT_USAGE_SSLCA = 3;
		
		// 
		public const ulong CERT_USAGE_EmailSigner = 4;
		
		// 
		public const ulong CERT_USAGE_EmailRecipient = 5;
		
		// 
		public const ulong CERT_USAGE_ObjectSigner = 6;
		
		// 
		public const ulong CERT_USAGE_UserCertImport = 7;
		
		// 
		public const ulong CERT_USAGE_VerifyCA = 8;
		
		// 
		public const ulong CERT_USAGE_ProtectedObjectSigner = 9;
		
		// 
		public const ulong CERT_USAGE_StatusResponder = 10;
		
		// 
		public const ulong CERT_USAGE_AnyCA = 11;
	}
}
