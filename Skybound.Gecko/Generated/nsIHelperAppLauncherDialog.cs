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
// Generated by IDLImporter from file nsIHelperAppLauncherDialog.idl
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
    /// This interface is used to display a confirmation dialog before
    /// launching a "helper app" to handle content not handled by
    /// Mozilla.
    ///
    /// Usage:  Clients (of which there is one: the nsIExternalHelperAppService
    /// implementation in mozilla/uriloader/exthandler) create an instance of
    /// this interface (using the contract ID) and then call the show() method.
    ///
    /// The dialog is shown non-modally.  The implementation of the dialog
    /// will access methods of the nsIHelperAppLauncher passed in to show()
    /// in order to cause a "save to disk" or "open using" action.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f3704fdc-8ae6-4eba-a3c3-f02958ac0649")]
	public interface nsIHelperAppLauncherDialog
	{
		
		/// <summary>
        /// Show confirmation dialog for launching application (or "save to
        /// disk") for content specified by aLauncher.
        ///
        /// @param aLauncher
        /// A nsIHelperAppLauncher to be invoked when a file is selected.
        /// @param aWindowContext
        /// Window associated with action.
        /// @param aReason
        /// One of the constants from above. It indicates why the dialog is
        /// shown. Implementors should treat unknown reasons like
        /// REASON_CANTHANDLE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Show([MarshalAs(UnmanagedType.Interface)] nsIHelperAppLauncher aLauncher, [MarshalAs(UnmanagedType.Interface)] nsISupports aWindowContext, uint aReason);
		
		/// <summary>
        /// Invoke a save-to-file dialog instead of the full fledged helper app dialog.
        /// Returns the a nsILocalFile for the file name/location selected.
        ///
        /// @param aLauncher
        /// A nsIHelperAppLauncher to be invoked when a file is selected.
        /// @param aWindowContext
        /// Window associated with action.
        /// @param aDefaultFileName
        /// Default file name to provide (can be null)
        /// @param aSuggestedFileExtension
        /// Sugested file extension
        /// @param aForcePrompt
        /// Set to true to force prompting the user for thet file
        /// name/location, otherwise perferences may control if the user is
        /// prompted.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile PromptForSaveToFile([MarshalAs(UnmanagedType.Interface)] nsIHelperAppLauncher aLauncher, [MarshalAs(UnmanagedType.Interface)] nsISupports aWindowContext, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDefaultFileName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aSuggestedFileExtension, [MarshalAs(UnmanagedType.Bool)] bool aForcePrompt);
	}
}
