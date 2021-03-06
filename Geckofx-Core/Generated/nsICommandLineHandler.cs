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
// Generated by IDLImporter from file nsICommandLineHandler.idl
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
    /// Handles arguments on the command line of an XUL application.
    ///
    /// Each handler is registered in the category "command-line-handler".
    /// The entries in this category are read in alphabetical order, and each
    /// category value is treated as a service contractid implementing this
    /// interface.
    ///
    /// By convention, handler with ordinary priority should begin with "m".
    ///
    /// Example:
    /// Category             Entry          Value
    /// command-line-handler c-extensions   @mozilla.org/extension-manager/clh;1
    /// command-line-handler m-edit         @mozilla.org/composer/clh;1
    /// command-line-handler m-irc          @mozilla.org/chatzilla/clh;1
    /// command-line-handler y-final        @mozilla.org/browser/clh-final;1
    ///
    /// @note What do we do about localizing helpInfo? Do we make each handler do it,
    /// or provide a generic solution of some sort? Don't freeze this interface
    /// without thinking about this!
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d4b123df-51ee-48b1-a663-002180e60d3b")]
	public interface nsICommandLineHandler
	{
		
		/// <summary>
        /// Process a command line. If this handler finds arguments that it
        /// understands, it should perform the appropriate actions (such as opening
        /// a window), and remove the arguments from the command-line array.
        ///
        /// @throw NS_ERROR_ABORT to immediately cease command-line handling
        /// (if this is STATE_INITIAL_LAUNCH, quits the app).
        /// All other exceptions are silently ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Handle([MarshalAs(UnmanagedType.Interface)] nsICommandLine aCommandLine);
		
		/// <summary>
        /// When the app is launched with the -help argument, this attribute
        /// is retrieved and displayed to the user (on stdout). The text should
        /// have embedded newlines which wrap at 76 columns, and should include
        /// a newline at the end. By convention, the right column which contains flag
        /// descriptions begins at the 24th character.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHelpInfoAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHelpInfo);
	}
}
