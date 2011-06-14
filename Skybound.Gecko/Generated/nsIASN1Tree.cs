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
// Generated by IDLImporter from file nsIASN1Tree.idl
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
	
	
	/// <summary>nsIASN1Tree </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("de142307-7b88-4e0a-b232-250f310e25d8")]
	public interface nsIASN1Tree : nsITreeView
	{
		
		/// <summary>
        /// The total number of rows in the tree (including the offscreen rows).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetRowCountAttribute();
		
		/// <summary>
        /// The selection for this view.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsITreeSelection GetSelectionAttribute();
		
		/// <summary>
        /// The selection for this view.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSelectionAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeSelection aSelection);
		
		/// <summary>
        /// An atomized list of properties for a given row.  Each property, x, that
        /// the view gives back will cause the pseudoclass :moz-tree-row-x
        /// to be matched on the pseudoelement ::moz-tree-row.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetRowProperties(int index, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray properties);
		
		/// <summary>
        /// An atomized list of properties for a given cell.  Each property, x, that
        /// the view gives back will cause the pseudoclass :moz-tree-cell-x
        /// to be matched on the ::moz-tree-cell pseudoelement.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCellProperties(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray properties);
		
		/// <summary>
        /// Called to get properties to paint a column background.  For shading the sort
        /// column, etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetColumnProperties([MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray properties);
		
		/// <summary>
        /// Methods that can be used to test whether or not a twisty should be drawn,
        /// and if so, whether an open or closed twisty should be used.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsContainer(int index);
		
		/// <summary>Member IsContainerOpen </summary>
		/// <param name='index'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsContainerOpen(int index);
		
		/// <summary>Member IsContainerEmpty </summary>
		/// <param name='index'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsContainerEmpty(int index);
		
		/// <summary>
        /// isSeparator is used to determine if the row at index is a separator.
        /// A value of true will result in the tree drawing a horizontal separator.
        /// The tree uses the ::moz-tree-separator pseudoclass to draw the separator.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSeparator(int index);
		
		/// <summary>
        /// Specifies if there is currently a sort on any column. Used mostly by dragdrop
        /// to affect drop feedback.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSorted();
		
		/// <summary>
        /// Methods used by the drag feedback code to determine if a drag is allowable at
        /// the current location. To get the behavior where drops are only allowed on
        /// items, such as the mailNews folder pane, always return false when
        /// the orientation is not DROP_ON.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool CanDrop(int index, int orientation, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer dataTransfer);
		
		/// <summary>
        /// Called when the user drops something on this view. The |orientation| param
        /// specifies before/on/after the given |row|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Drop(int row, int orientation, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer dataTransfer);
		
		/// <summary>
        /// Methods used by the tree to draw thread lines in the tree.
        /// getParentIndex is used to obtain the index of a parent row.
        /// If there is no parent row, getParentIndex returns -1.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetParentIndex(int rowIndex);
		
		/// <summary>
        /// hasNextSibling is used to determine if the row at rowIndex has a nextSibling
        /// that occurs *after* the index specified by afterIndex.  Code that is forced
        /// to march down the view looking at levels can optimize the march by starting
        /// at afterIndex+1.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasNextSibling(int rowIndex, int afterIndex);
		
		/// <summary>
        /// The level is an integer value that represents
        /// the level of indentation.  It is multiplied by the width specified in the
        /// :moz-tree-indentation pseudoelement to compute the exact indendation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetLevel(int index);
		
		/// <summary>
        /// The image path for a given cell. For defining an icon for a cell.
        /// If the empty string is returned, the :moz-tree-image pseudoelement
        /// will be used.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetImageSrc(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>
        /// The progress mode for a given cell. This method is only called for
        /// columns of type |progressmeter|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetProgressMode(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>
        /// The value for a given cell. This method is only called for columns
        /// of type other than |text|.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetCellValue(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>
        /// The text for a given cell.  If a column consists only of an image, then
        /// the empty string is returned.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetCellText(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>
        /// Called during initialization to link the view to the front end box object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTree([MarshalAs(UnmanagedType.Interface)] nsITreeBoxObject tree);
		
		/// <summary>
        /// Called on the view when an item is opened or closed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ToggleOpenState(int index);
		
		/// <summary>
        /// Called on the view when a header is clicked.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CycleHeader([MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>
        /// Should be called from a XUL onselect handler whenever the selection changes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SelectionChanged();
		
		/// <summary>
        /// Called on the view when a cell in a non-selectable cycling column (e.g., unread/flag/etc.) is clicked.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CycleCell(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>
        /// isEditable is called to ask the view if the cell contents are editable.
        /// A value of true will result in the tree popping up a text field when
        /// the user tries to inline edit the cell.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsEditable(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>
        /// isSelectable is called to ask the view if the cell is selectable.
        /// This method is only called if the selection style is |cell| or |text|.
        /// XXXvarga shouldn't this be called isCellSelectable?
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSelectable(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>
        /// setCellValue is called when the value of the cell has been set by the user.
        /// This method is only called for columns of type other than |text|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCellValue(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>
        /// setCellText is called when the contents of the cell have been edited by the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCellText(int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>
        /// A command API that can be used to invoke commands on the selection.  The tree
        /// will automatically invoke this method when certain keys are pressed.  For example,
        /// when the DEL key is pressed, performAction will be called with the "delete" string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PerformAction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string action);
		
		/// <summary>
        /// A command API that can be used to invoke commands on a specific row.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PerformActionOnRow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string action, int row);
		
		/// <summary>
        /// A command API that can be used to invoke commands on a specific cell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PerformActionOnCell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string action, int row, [MarshalAs(UnmanagedType.Interface)] nsITreeColumn col);
		
		/// <summary>Member LoadASN1Structure </summary>
		/// <param name='asn1Object'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadASN1Structure([MarshalAs(UnmanagedType.Interface)] nsIASN1Object asn1Object);
		
		/// <summary>Member GetDisplayData </summary>
		/// <param name='index'> </param>
		/// <returns>A nsAString</returns>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetDisplayData(uint index);
	}
}
