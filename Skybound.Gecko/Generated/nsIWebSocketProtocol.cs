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
// Generated by IDLImporter from file nsIWebSocketProtocol.idl
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
    /// nsIWebSocketListener
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b0c27050-31e9-42e5-bc59-499d54b52f99")]
	public interface nsIWebSocketListener
	{
		
		/// <summary>
        /// Called to signify the establishment of the message stream.
        /// Any listener that receives onStart will also receive OnStop.
        ///
        /// @param aContext user defined context
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStart([MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the completion of the message stream.
        /// OnStop is the final notification the listener will receive and it
        /// completes the WebSocket connection. This event can be received in error
        /// cases even if nsIWebSocketProtocol::Close() has not been called.
        ///
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStop([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called to deliver text message.
        ///
        /// @param aContext user defined context
        /// @param aMsg the message data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnMessageAvailable([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMsg);
		
		/// <summary>
        /// Called to deliver binary message.
        ///
        /// @param aContext user defined context
        /// @param aMsg the message data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnBinaryMessageAvailable([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACString aMsg);
		
		/// <summary>
        /// Called to acknowledge message sent via sendMsg() or sendBinaryMsg.
        ///
        /// @param aContext user defined context
        /// @param aSize number of bytes placed in OS send buffer
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAcknowledge([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, uint aSize);
		
		/// <summary>
        /// Called to inform receipt of WebSocket Close message from server.
        /// In the case of errors onStop() can be called without ever
        /// receiving server close.
        ///
        /// No additional messages through onMessageAvailable(),
        /// onBinaryMessageAvailable() or onAcknowledge() will be delievered
        /// to the listener after onServerClose(), though outgoing messages can still
        /// be sent through the nsIWebSocketProtocol connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnServerClose([MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
	}
	
	/// <summary>nsIWebSocketProtocol </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dc01db59-a513-4c90-824b-085cce06c0aa")]
	public interface nsIWebSocketProtocol
	{
		
		/// <summary>
        /// The original URI used to construct the protocol connection. This is used
        /// in the case of a redirect or URI "resolution" (e.g. resolving a
        /// resource: URI to a file: URI) so that the original pre-redirect
        /// URI can still be obtained.  This is never null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetOriginalURIAttribute();
		
		/// <summary>
        /// The readonly URI corresponding to the protocol connection after any
        /// redirections are completed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// The notification callbacks for authorization, etc..
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceRequestor GetNotificationCallbacksAttribute();
		
		/// <summary>
        /// The notification callbacks for authorization, etc..
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aNotificationCallbacks);
		
		/// <summary>
        /// Transport-level security information (if any)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetSecurityInfoAttribute();
		
		/// <summary>
        /// The load group of the websockets code.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadGroup GetLoadGroupAttribute();
		
		/// <summary>
        /// The load group of the websockets code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);
		
		/// <summary>
        /// Sec-Websocket-Protocol value
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aProtocol);
		
		/// <summary>
        /// Sec-Websocket-Protocol value
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aProtocol);
		
		/// <summary>
        /// Asynchronously open the websocket connection.  Received messages are fed
        /// to the socket listener as they arrive.  The socket listener's methods
        /// are called on the thread that calls asyncOpen and are not called until
        /// after asyncOpen returns.  If asyncOpen returns successfully, the
        /// protocol implementation promises to call at least onStart and onStop of
        /// the listener.
        ///
        /// NOTE: Implementations should throw NS_ERROR_ALREADY_OPENED if the
        /// websocket connection is reopened.
        ///
        /// @param aURI the uri of the websocket protocol - may be redirected
        /// @param aOrigin the uri of the originating resource
        /// @param aListener the nsIWebSocketListener implementation
        /// @param aContext an opaque parameter forwarded to aListener's methods
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACString aOrigin, [MarshalAs(UnmanagedType.Interface)] nsIWebSocketListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Close the websocket connection for writing - no more calls to sendMsg
        /// or sendBinaryMsg should be made after calling this. The listener object
        /// may receive more messages if a server close has not yet been received.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Use to send text message down the connection to WebSocket peer.
        ///
        /// @param aMsg the utf8 string to send
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendMsg([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMsg);
		
		/// <summary>
        /// Use to send binary message down the connection to WebSocket peer.
        ///
        /// @param aMsg the data to send
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendBinaryMsg([MarshalAs(UnmanagedType.LPStruct)] nsACString aMsg);
	}
}