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
// Generated by IDLImporter from file nsIXULTemplateResult.idl
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
    /// A single result generated from a template query. Each result is identified
    /// by an id, which must be unique within the set of results produced from a
    /// query. The result may optionally be identified by an RDF resource.
    ///
    /// Generally, the result and its id will be able to uniquely identify a node
    /// in the source data, such as an RDF or XML node. In other contexts, such as
    /// a database query, a result would represent a particular record.
    ///
    /// A result is expected to only be created by a query processor.
    ///
    /// Each result also contains a set of variable bindings. The value for a
    /// particular variable may be retrieved using the getBindingFor and
    /// getBindingObjectFor methods.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ebea0230-36fa-41b7-8e31-760806057965")]
	public interface nsIXULTemplateResult
	{
		
		/// <summary>
        /// True if the result represents a container.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsContainerAttribute();
		
		/// <summary>
        /// True if the result represents an empty container.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsEmptyAttribute();
		
		/// <summary>
        /// True if the template builder may use this result as the reference point
        /// for additional recursive processing of the template. The template builder
        /// will reprocess the template using this result as the reference point and
        /// generate output content that is expected to be inserted as children of the
        /// output generated for this result. If false, child content is not
        /// processed. This property identifies only the default handling and may be
        /// overriden by syntax used in the template.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMayProcessChildrenAttribute();
		
		/// <summary>
        /// ID of the result. The DOM element created for this result, if any, will
        /// have its id attribute set to this value. The id must be unique for a
        /// query.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		/// <summary>
        /// Resource for the result, which may be null. If set, the resource uri
        /// must be the same as the ID property.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRDFResource GetResourceAttribute();
		
		/// <summary>
        /// The type of the object. The predefined value 'separator' may be used
        /// for separators. Other values may be used for application specific
        /// purposes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>
        /// Get the string representation of the value of a variable for this
        /// result. This string will be used in the action body from a template as
        /// the replacement text. For instance, if the text ?name appears in an
        /// attribute within the action body, it will be replaced with the result
        /// of this method. The question mark is considered part of the variable
        /// name, thus aVar should be ?name and not simply name.
        ///
        /// @param aVar the variable to look up
        ///
        /// @return the value for the variable or a null string if it has no value
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetBindingFor([MarshalAs(UnmanagedType.Interface)] nsIAtom aVar);
		
		/// <summary>
        /// Get an object value for a variable such as ?name for this result.
        ///
        /// This method may return null for a variable, even if getBindingFor returns
        /// a non-null value for the same variable. This method is provided as a
        /// convenience when sorting results.
        ///
        /// @param aVar the variable to look up
        ///
        /// @return the value for the variable or null if it has no value
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetBindingObjectFor([MarshalAs(UnmanagedType.Interface)] nsIAtom aVar);
		
		/// <summary>
        /// Indicate that a particular rule of a query has matched and that output
        /// will be generated for it. Both the query as compiled by the query
        /// processor's compileQuery method and the XUL <rule> element are supplied.
        /// The query must always be one that was compiled by the query processor
        /// that created this result. The <rule> element must always be a child of
        /// the <query> element that was used to compile the query.
        ///
        /// @param aQuery the query that matched
        /// @param aRuleNode the rule node that matched
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RuleMatched([MarshalAs(UnmanagedType.Interface)] nsISupports aQuery, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRuleNode);
		
		/// <summary>
        /// Indicate that the output for a result has beeen removed and that the
        /// result is no longer being used by the builder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HasBeenRemoved();
	}
}
