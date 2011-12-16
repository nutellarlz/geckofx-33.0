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
// Generated by IDLImporter from file nsISocketTransport.idl
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
	
	
	/// <summary>
    /// nsISocketTransport
    ///
    /// NOTE: Connection setup is triggered by opening an input or output stream,
    /// it does not start on its own. Completion of the connection setup is
    /// indicated by a STATUS_CONNECTED_TO notification to the event sink (if set).
    ///
    /// NOTE: This is a free-threaded interface, meaning that the methods on
    /// this interface may be called from any thread.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("19c37caa-fb41-4c32-bbf1-c6b31b75d789")]
	public interface nsISocketTransport : nsITransport
	{
		
		/// <summary>
        /// Open an input stream on this transport.
        ///
        /// Flags have the following meaning:
        ///
        /// OPEN_BLOCKING
        /// If specified, then the resulting stream will have blocking stream
        /// semantics.  This means that if the stream has no data and is not
        /// closed, then reading from it will block the calling thread until
        /// at least one byte is available or until the stream is closed.
        /// If this flag is NOT specified, then the stream has non-blocking
        /// stream semantics.  This means that if the stream has no data and is
        /// not closed, then reading from it returns NS_BASE_STREAM_WOULD_BLOCK.
        /// In addition, in non-blocking mode, the stream is guaranteed to
        /// support nsIAsyncInputStream.  This interface allows the consumer of
        /// the stream to be notified when the stream can again be read.
        ///
        /// OPEN_UNBUFFERED
        /// If specified, the resulting stream may not support ReadSegments.
        /// ReadSegments is only gauranteed to be implemented when this flag is
        /// NOT specified.
        ///
        /// @param aFlags
        /// optional transport specific flags.
        /// @param aSegmentSize
        /// if OPEN_UNBUFFERED is not set, then this parameter specifies the
        /// size of each buffer segment (pass 0 to use default value).
        /// @param aSegmentCount
        /// if OPEN_UNBUFFERED is not set, then this parameter specifies the
        /// maximum number of buffer segments (pass 0 to use default value).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream OpenInputStream(uint aFlags, uint aSegmentSize, uint aSegmentCount);
		
		/// <summary>
        /// Open an output stream on this transport.
        ///
        /// Flags have the following meaning:
        ///
        /// OPEN_BLOCKING
        /// If specified, then the resulting stream will have blocking stream
        /// semantics.  This means that if the stream is full and is not closed,
        /// then writing to it will block the calling thread until ALL of the
        /// data can be written or until the stream is closed.  If this flag is
        /// NOT specified, then the stream has non-blocking stream semantics.
        /// This means that if the stream is full and is not closed, then writing
        /// to it returns NS_BASE_STREAM_WOULD_BLOCK.  In addition, in non-
        /// blocking mode, the stream is guaranteed to support
        /// nsIAsyncOutputStream.  This interface allows the consumer of the
        /// stream to be notified when the stream can again accept more data.
        ///
        /// OPEN_UNBUFFERED
        /// If specified, the resulting stream may not support WriteSegments and
        /// WriteFrom.  WriteSegments and WriteFrom are only gauranteed to be
        /// implemented when this flag is NOT specified.
        ///
        /// @param aFlags
        /// optional transport specific flags.
        /// @param aSegmentSize
        /// if OPEN_UNBUFFERED is not set, then this parameter specifies the
        /// size of each buffer segment (pass 0 to use default value).
        /// @param aSegmentCount
        /// if OPEN_UNBUFFERED is not set, then this parameter specifies the
        /// maximum number of buffer segments (pass 0 to use default value).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIOutputStream OpenOutputStream(uint aFlags, uint aSegmentSize, uint aSegmentCount);
		
		/// <summary>
        /// Close the transport and any open streams.
        ///
        /// @param aReason
        /// the reason for closing the stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close(int aReason);
		
		/// <summary>
        /// Set the transport event sink.
        ///
        /// @param aSink
        /// receives transport layer notifications
        /// @param aEventTarget
        /// indicates the event target to which the notifications should
        /// be delivered.  if NULL, then the notifications may occur on
        /// any thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetEventSink([MarshalAs(UnmanagedType.Interface)] nsITransportEventSink aSink, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);
		
		/// <summary>
        /// Get the host for the underlying socket connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aHost);
		
		/// <summary>
        /// Get the port for the underlying socket connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPortAttribute();
		
		/// <summary>
        /// Returns the IP address of the socket connection peer. This
        /// attribute is defined only once a connection has been established.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPeerAddr();
		
		/// <summary>
        /// Returns the IP address of the initiating end. This attribute
        /// is defined only once a connection has been established.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSelfAddr();
		
		/// <summary>
        /// Security info object returned from the secure socket provider.  This
        /// object supports nsISSLSocketControl, nsITransportSecurityInfo, and
        /// possibly other interfaces.
        ///
        /// This attribute is only available once the socket is connected.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetSecurityInfoAttribute();
		
		/// <summary>
        /// Security notification callbacks passed to the secure socket provider
        /// via nsISSLSocketControl at socket creation time.
        ///
        /// NOTE: this attribute cannot be changed once a stream has been opened.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceRequestor GetSecurityCallbacksAttribute();
		
		/// <summary>
        /// Security notification callbacks passed to the secure socket provider
        /// via nsISSLSocketControl at socket creation time.
        ///
        /// NOTE: this attribute cannot be changed once a stream has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecurityCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aSecurityCallbacks);
		
		/// <summary>
        /// Test if this socket transport is (still) connected.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsAlive();
		
		/// <summary>
        /// Socket timeouts in seconds.  To specify no timeout, pass PR_UINT32_MAX
        /// as aValue to setTimeout.  The implementation may truncate timeout values
        /// to a smaller range of values (e.g., 0 to 0xFFFF).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTimeout(uint aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimeout(uint aType, uint aValue);
		
		/// <summary>
        /// connectionFlags is a bitmask that can be used to modify underlying
        /// behavior of the socket connection. See the flags below.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetConnectionFlagsAttribute();
		
		/// <summary>
        /// connectionFlags is a bitmask that can be used to modify underlying
        /// behavior of the socket connection. See the flags below.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetConnectionFlagsAttribute(uint aConnectionFlags);
		
		/// <summary>
        /// Socket QoS/ToS markings. Valid values are IPTOS_DSCP_AFxx or
        /// IPTOS_CLASS_CSx (or IPTOS_DSCP_EF, but currently no supported
        /// services require expedited-forwarding).
        /// Not setting this value will leave the socket with the default
        /// ToS value, which on most systems if IPTOS_CLASS_CS0 (formerly
        /// IPTOS_PREC_ROUTINE).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetQoSBitsAttribute();
		
		/// <summary>
        /// Socket QoS/ToS markings. Valid values are IPTOS_DSCP_AFxx or
        /// IPTOS_CLASS_CSx (or IPTOS_DSCP_EF, but currently no supported
        /// services require expedited-forwarding).
        /// Not setting this value will leave the socket with the default
        /// ToS value, which on most systems if IPTOS_CLASS_CS0 (formerly
        /// IPTOS_PREC_ROUTINE).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetQoSBitsAttribute(System.IntPtr aQoSBits);
	}
}
