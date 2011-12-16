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
// Generated by IDLImporter from file nsITransport.idl
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
    /// nsITransport
    ///
    /// This interface provides a common way of accessing i/o streams connected
    /// to some resource.  This interface does not in any way specify the resource.
    /// It provides methods to open blocking or non-blocking, buffered or unbuffered
    /// streams to the resource.  The name "transport" is meant to connote the
    /// inherent data transfer implied by this interface (i.e., data is being
    /// transfered in some fashion via the streams exposed by this interface).
    ///
    /// A transport can have an event sink associated with it.  The event sink
    /// receives transport-specific events as the transfer is occuring.  For a
    /// socket transport, these events can include status about the connection.
    /// See nsISocketTransport for more info about socket transport specifics.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d8786c64-eb49-4a0b-b42c-0936a745fbe8")]
	public interface nsITransport
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
		nsIInputStream OpenInputStream(uint aFlags, uint aSegmentSize, uint aSegmentCount);
		
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
		nsIOutputStream OpenOutputStream(uint aFlags, uint aSegmentSize, uint aSegmentCount);
		
		/// <summary>
        /// Close the transport and any open streams.
        ///
        /// @param aReason
        /// the reason for closing the stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close(int aReason);
		
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
		void SetEventSink([MarshalAs(UnmanagedType.Interface)] nsITransportEventSink aSink, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);
	}
	
	/// <summary>
    /// Generic nsITransportEventSink status codes.  nsITransport
    /// implementations may override these status codes with their own more
    /// specific status codes (e.g., see nsISocketTransport).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("EDA4F520-67F7-484b-A691-8C3226A5B0A6")]
	public interface nsITransportEventSink
	{
		
		/// <summary>
        /// Transport status notification.
        ///
        /// @param aTransport
        /// the transport sending this status notification.
        /// @param aStatus
        /// the transport status (resolvable to a string using
        /// nsIErrorService). See nsISocketTransport for socket specific
        /// status codes and more comments.
        /// @param aProgress
        /// the amount of data either read or written depending on the value
        /// of the status code.  this value is relative to aProgressMax.
        /// @param aProgressMax
        /// the maximum amount of data that will be read or written.  if
        /// unknown, 0xFFFFFFFF will be passed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnTransportStatus([MarshalAs(UnmanagedType.Interface)] nsITransport aTransport, int aStatus, uint aProgress, uint aProgressMax);
	}
}
