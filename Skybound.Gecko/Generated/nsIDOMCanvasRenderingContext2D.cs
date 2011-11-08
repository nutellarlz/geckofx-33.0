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
// Generated by IDLImporter from file nsIDOMCanvasRenderingContext2D.idl
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
	
	
	/// <summary>nsIDOMCanvasGradient </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bbb20a59-524e-4662-981e-5e142814b20c")]
	public interface nsIDOMCanvasGradient
	{
		
		/// <summary>Member AddColorStop </summary>
		/// <param name='offset'> </param>
		/// <param name='color'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddColorStop(float offset, [MarshalAs(UnmanagedType.LPStruct)] nsAString color);
	}
	
	/// <summary>nsIDOMCanvasPattern </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("21dea65c-5c08-4eb1-ac82-81fe95be77b8")]
	public interface nsIDOMCanvasPattern
	{
	}
	
	/// <summary>nsIDOMTextMetrics </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2d01715c-ec7d-424a-ab85-e0fd70c8665c")]
	public interface nsIDOMTextMetrics
	{
		
		/// <summary>Member GetWidthAttribute </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetWidthAttribute();
	}
	
	/// <summary>nsIDOMCanvasRenderingContext2D </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("274213a8-df51-4b52-bfad-d306a1d5f642")]
	public interface nsIDOMCanvasRenderingContext2D
	{
		
		/// <summary>
        /// this context was created
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCanvasElement GetCanvasAttribute();
		
		/// <summary>
        /// state
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Save();
		
		/// <summary>Member Restore </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Restore();
		
		/// <summary>
        /// transformations
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Scale(float x, float y);
		
		/// <summary>Member Rotate </summary>
		/// <param name='angle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Rotate(float angle);
		
		/// <summary>Member Translate </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Translate(float x, float y);
		
		/// <summary>Member Transform </summary>
		/// <param name='m11'> </param>
		/// <param name='m12'> </param>
		/// <param name='m21'> </param>
		/// <param name='m22'> </param>
		/// <param name='dx'> </param>
		/// <param name='dy'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Transform(float m11, float m12, float m21, float m22, float dx, float dy);
		
		/// <summary>Member SetTransform </summary>
		/// <param name='m11'> </param>
		/// <param name='m12'> </param>
		/// <param name='m21'> </param>
		/// <param name='m22'> </param>
		/// <param name='dx'> </param>
		/// <param name='dy'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTransform(float m11, float m12, float m21, float m22, float dx, float dy);
		
		/// <summary>Member GetMozCurrentTransformAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetMozCurrentTransformAttribute();
		
		/// <summary>Member SetMozCurrentTransformAttribute </summary>
		/// <param name='aMozCurrentTransform'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozCurrentTransformAttribute(System.IntPtr aMozCurrentTransform);
		
		/// <summary>
        /// [ m11, m12, m21, m22, dx, dy ], i.e. row major
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetMozCurrentTransformInverseAttribute();
		
		/// <summary>
        /// [ m11, m12, m21, m22, dx, dy ], i.e. row major
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozCurrentTransformInverseAttribute(System.IntPtr aMozCurrentTransformInverse);
		
		/// <summary>
        /// compositing
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetGlobalAlphaAttribute();
		
		/// <summary>
        /// compositing
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGlobalAlphaAttribute(float aGlobalAlpha);
		
		/// <summary>
        ///default 1.0 -- opaque </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGlobalCompositeOperationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aGlobalCompositeOperation);
		
		/// <summary>
        ///default 1.0 -- opaque </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGlobalCompositeOperationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aGlobalCompositeOperation);
		
		/// <summary>
        /// code should use the _multi variants below.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetStrokeStyleAttribute();
		
		/// <summary>
        /// code should use the _multi variants below.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStrokeStyleAttribute([MarshalAs(UnmanagedType.Interface)] nsIVariant aStrokeStyle);
		
		/// <summary>Member GetFillStyleAttribute </summary>
		/// <returns>A nsIVariant</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetFillStyleAttribute();
		
		/// <summary>Member SetFillStyleAttribute </summary>
		/// <param name='aFillStyle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFillStyleAttribute([MarshalAs(UnmanagedType.Interface)] nsIVariant aFillStyle);
		
		/// <summary>
        /// ifaceType is 0 if it's a string, 1 if it's a pattern, or 2 if it's a gradient
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStrokeStyle_multi([MarshalAs(UnmanagedType.LPStruct)] nsAString str, [MarshalAs(UnmanagedType.Interface)] nsISupports iface);
		
		/// <summary>Member GetStrokeStyle_multi </summary>
		/// <param name='str'> </param>
		/// <param name='iface'> </param>
		/// <param name='type'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStrokeStyle_multi([MarshalAs(UnmanagedType.LPStruct)] nsAString str, [MarshalAs(UnmanagedType.Interface)] ref nsISupports iface, ref int type);
		
		/// <summary>Member SetFillStyle_multi </summary>
		/// <param name='str'> </param>
		/// <param name='iface'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFillStyle_multi([MarshalAs(UnmanagedType.LPStruct)] nsAString str, [MarshalAs(UnmanagedType.Interface)] nsISupports iface);
		
		/// <summary>Member GetFillStyle_multi </summary>
		/// <param name='str'> </param>
		/// <param name='iface'> </param>
		/// <param name='type'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFillStyle_multi([MarshalAs(UnmanagedType.LPStruct)] nsAString str, [MarshalAs(UnmanagedType.Interface)] ref nsISupports iface, ref int type);
		
		/// <summary>
        ///attribute DOMString fillRule;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMozFillRuleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMozFillRule);
		
		/// <summary>
        ///attribute DOMString fillRule;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozFillRuleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMozFillRule);
		
		/// <summary>
        ///"evenodd", "nonzero" (default) </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCanvasGradient CreateLinearGradient(float x0, float y0, float x1, float y1);
		
		/// <summary>Member CreateRadialGradient </summary>
		/// <param name='x0'> </param>
		/// <param name='y0'> </param>
		/// <param name='r0'> </param>
		/// <param name='x1'> </param>
		/// <param name='y1'> </param>
		/// <param name='r1'> </param>
		/// <returns>A nsIDOMCanvasGradient</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCanvasGradient CreateRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1);
		
		/// <summary>Member CreatePattern </summary>
		/// <param name='image'> </param>
		/// <param name='repetition'> </param>
		/// <returns>A nsIDOMCanvasPattern</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCanvasPattern CreatePattern([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLElement image, [MarshalAs(UnmanagedType.LPStruct)] nsAString repetition);
		
		/// <summary>Member GetLineWidthAttribute </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetLineWidthAttribute();
		
		/// <summary>Member SetLineWidthAttribute </summary>
		/// <param name='aLineWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLineWidthAttribute(float aLineWidth);
		
		/// <summary>
        ///default 1 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLineCapAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLineCap);
		
		/// <summary>
        ///default 1 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLineCapAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLineCap);
		
		/// <summary>
        ///"butt", "round", "square" (default) </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLineJoinAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLineJoin);
		
		/// <summary>
        ///"butt", "round", "square" (default) </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLineJoinAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLineJoin);
		
		/// <summary>
        ///"round", "bevel", "miter" (default) </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetMiterLimitAttribute();
		
		/// <summary>
        ///"round", "bevel", "miter" (default) </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMiterLimitAttribute(float aMiterLimit);
		
		/// <summary>
        ///default 10 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetMozDashAttribute();
		
		/// <summary>
        ///default 10 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozDashAttribute(System.IntPtr aMozDash);
		
		/// <summary>
        ///default |null| </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetMozDashOffsetAttribute();
		
		/// <summary>
        ///default |null| </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozDashOffsetAttribute(float aMozDashOffset);
		
		/// <summary>
        /// shadows
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetShadowOffsetXAttribute();
		
		/// <summary>
        /// shadows
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShadowOffsetXAttribute(float aShadowOffsetX);
		
		/// <summary>Member GetShadowOffsetYAttribute </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetShadowOffsetYAttribute();
		
		/// <summary>Member SetShadowOffsetYAttribute </summary>
		/// <param name='aShadowOffsetY'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShadowOffsetYAttribute(float aShadowOffsetY);
		
		/// <summary>Member GetShadowBlurAttribute </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetShadowBlurAttribute();
		
		/// <summary>Member SetShadowBlurAttribute </summary>
		/// <param name='aShadowBlur'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShadowBlurAttribute(float aShadowBlur);
		
		/// <summary>Member GetShadowColorAttribute </summary>
		/// <param name='aShadowColor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetShadowColorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aShadowColor);
		
		/// <summary>Member SetShadowColorAttribute </summary>
		/// <param name='aShadowColor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShadowColorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aShadowColor);
		
		/// <summary>
        /// rects
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearRect(float x, float y, float w, float h);
		
		/// <summary>Member FillRect </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='w'> </param>
		/// <param name='h'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FillRect(float x, float y, float w, float h);
		
		/// <summary>Member StrokeRect </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='w'> </param>
		/// <param name='h'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StrokeRect(float x, float y, float w, float h);
		
		/// <summary>
        /// path API
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginPath();
		
		/// <summary>Member ClosePath </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClosePath();
		
		/// <summary>Member MoveTo </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveTo(float x, float y);
		
		/// <summary>Member LineTo </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LineTo(float x, float y);
		
		/// <summary>Member QuadraticCurveTo </summary>
		/// <param name='cpx'> </param>
		/// <param name='cpy'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void QuadraticCurveTo(float cpx, float cpy, float x, float y);
		
		/// <summary>Member BezierCurveTo </summary>
		/// <param name='cp1x'> </param>
		/// <param name='cp1y'> </param>
		/// <param name='cp2x'> </param>
		/// <param name='cp2y'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y);
		
		/// <summary>Member ArcTo </summary>
		/// <param name='x1'> </param>
		/// <param name='y1'> </param>
		/// <param name='x2'> </param>
		/// <param name='y2'> </param>
		/// <param name='radius'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ArcTo(float x1, float y1, float x2, float y2, float radius);
		
		/// <summary>Member Arc </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='r'> </param>
		/// <param name='startAngle'> </param>
		/// <param name='endAngle'> </param>
		/// <param name='anticlockwise'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Arc(float x, float y, float r, float startAngle, float endAngle, [MarshalAs(UnmanagedType.Bool)] bool anticlockwise);
		
		/// <summary>Member Rect </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='w'> </param>
		/// <param name='h'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Rect(float x, float y, float w, float h);
		
		/// <summary>Member Fill </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Fill();
		
		/// <summary>Member Stroke </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stroke();
		
		/// <summary>Member Clip </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clip();
		
		/// <summary>
        /// text api
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFont);
		
		/// <summary>
        /// text api
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFontAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFont);
		
		/// <summary>
        ///default "10px sans-serif" </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextAlignAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextAlign);
		
		/// <summary>
        ///default "10px sans-serif" </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextAlignAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextAlign);
		
		/// <summary>
        ///"start" (default), "end", "left", "right",
        ///                                 "center" </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextBaselineAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextBaseline);
		
		/// <summary>
        ///"start" (default), "end", "left", "right",
        ///                                 "center" </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextBaselineAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextBaseline);
		
		/// <summary>
        ///"alphabetic" (default), "top", "hanging",
        ///                                    "middle", "ideographic", "bottom" </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FillText([MarshalAs(UnmanagedType.LPStruct)] nsAString text, float x, float y, float maxWidth);
		
		/// <summary>Member StrokeText </summary>
		/// <param name='text'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='maxWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StrokeText([MarshalAs(UnmanagedType.LPStruct)] nsAString text, float x, float y, float maxWidth);
		
		/// <summary>Member MeasureText </summary>
		/// <param name='text'> </param>
		/// <returns>A nsIDOMTextMetrics</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTextMetrics MeasureText([MarshalAs(UnmanagedType.LPStruct)] nsAString text);
		
		/// <summary>Member GetMozTextStyleAttribute </summary>
		/// <param name='aMozTextStyle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMozTextStyleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMozTextStyle);
		
		/// <summary>Member SetMozTextStyleAttribute </summary>
		/// <param name='aMozTextStyle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozTextStyleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMozTextStyle);
		
		/// <summary>
        /// image api
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DrawImage([MarshalAs(UnmanagedType.Interface)] nsIDOMElement image, float a1, float a2, float a3, float a4, float a5, float a6, float a7, float a8, int argc);
		
		/// <summary>
        /// point-membership test
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsPointInPath(float x, float y);
		
		/// <summary>
        /// methods directly.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImageData();
		
		/// <summary>Member PutImageData </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PutImageData();
		
		/// <summary>
        /// dataLen must be == width*height*4 in both of these calls
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImageData_explicit(int x, int y, uint width, uint height, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=5)] System.IntPtr[] dataPtr, uint dataLen);
		
		/// <summary>Member PutImageData_explicit </summary>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		/// <param name='dataPtr'> </param>
		/// <param name='dataLen'> </param>
		/// <param name='hasDirtyRect'> </param>
		/// <param name='dirtyX'> </param>
		/// <param name='dirtyY'> </param>
		/// <param name='dirtyWidth'> </param>
		/// <param name='dirtyHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PutImageData_explicit(int x, int y, uint width, uint height, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=5)] System.IntPtr[] dataPtr, uint dataLen, [MarshalAs(UnmanagedType.Bool)] bool hasDirtyRect, int dirtyX, int dirtyY, int dirtyWidth, int dirtyHeight);
		
		/// <summary>
        /// a separate ImageData object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateImageData();
		
		/// <summary>
        /// if scaled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMozImageSmoothingEnabledAttribute();
		
		/// <summary>
        /// if scaled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozImageSmoothingEnabledAttribute([MarshalAs(UnmanagedType.Bool)] bool aMozImageSmoothingEnabled);
		
		/// <summary>
        /// Renders a region of a window into the canvas.  The contents of
        /// the window's viewport are rendered, ignoring viewport clipping
        /// and scrolling.
        ///
        /// @param x
        /// @param y
        /// @param w
        /// @param h specify the area of the window to render, in CSS
        /// pixels.
        ///
        /// @param backgroundColor the canvas is filled with this color
        /// before we render the window into it. This color may be
        /// transparent/translucent. It is given as a CSS color string
        /// (e.g., rgb() or rgba()).
        ///
        /// @param flags Uused to better control the drawWindow call.
        /// Flags can be ORed together.
        ///
        /// Of course, the rendering obeys the current scale, transform and
        /// globalAlpha values.
        ///
        /// Hints:
        /// -- If 'rgba(0,0,0,0)' is used for the background color, the
        /// drawing will be transparent wherever the window is transparent.
        /// -- Top-level browsed documents are usually not transparent
        /// because the user's background-color preference is applied,
        /// but IFRAMEs are transparent if the page doesn't set a background.
        /// -- If an opaque color is used for the background color, rendering
        /// will be faster because we won't have to compute the window's
        /// transparency.
        ///
        /// This API cannot currently be used by Web content. It is chrome
        /// only.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DrawWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, float x, float y, float w, float h, [MarshalAs(UnmanagedType.LPStruct)] nsAString bgColor, uint flags);
		
		/// <summary>Member AsyncDrawXULElement </summary>
		/// <param name='elem'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='w'> </param>
		/// <param name='h'> </param>
		/// <param name='bgColor'> </param>
		/// <param name='flags'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncDrawXULElement([MarshalAs(UnmanagedType.Interface)] nsIDOMXULElement elem, float x, float y, float w, float h, [MarshalAs(UnmanagedType.LPStruct)] nsAString bgColor, uint flags);
	}
}
