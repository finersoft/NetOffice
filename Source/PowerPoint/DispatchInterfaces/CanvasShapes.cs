﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.PowerPointApi
{
	/// <summary>
	/// DispatchInterface CanvasShapes 
	/// SupportByVersion PowerPoint, 10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Method, "Item")]
	public class CanvasShapes : COMObject , IEnumerable<NetOffice.PowerPointApi.Shape>
	{
		#pragma warning disable

		#region Type Information

		/// <summary>
		/// Instance Type
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
		public override Type InstanceType
		{
			get
			{
				return LateBindingApiWrapperType;
			}
		}

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(CanvasShapes);
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public CanvasShapes(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16), ProxyResult]
		public object Application
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Application");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public Int32 Creator
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public Int32 Count
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape Background
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.Shape>(this, "Background", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public NetOffice.PowerPointApi.Shape this[object index]
		{
			get
			{
				return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "Item", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, index);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoCalloutType type</param>
		/// <param name="left">Single left</param>
		/// <param name="top">Single top</param>
		/// <param name="width">Single width</param>
		/// <param name="height">Single height</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddCallout(NetOffice.OfficeApi.Enums.MsoCalloutType type, Single left, Single top, Single width, Single height)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddCallout", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ type, left, top, width, height });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoConnectorType type</param>
		/// <param name="beginX">Single beginX</param>
		/// <param name="beginY">Single beginY</param>
		/// <param name="endX">Single endX</param>
		/// <param name="endY">Single endY</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddConnector(NetOffice.OfficeApi.Enums.MsoConnectorType type, Single beginX, Single beginY, Single endX, Single endY)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddConnector", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ type, beginX, beginY, endX, endY });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="safeArrayOfPoints">object safeArrayOfPoints</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddCurve(object safeArrayOfPoints)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddCurve", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, safeArrayOfPoints);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation orientation</param>
		/// <param name="left">Single left</param>
		/// <param name="top">Single top</param>
		/// <param name="width">Single width</param>
		/// <param name="height">Single height</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddLabel(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddLabel", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ orientation, left, top, width, height });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="beginX">Single beginX</param>
		/// <param name="beginY">Single beginY</param>
		/// <param name="endX">Single endX</param>
		/// <param name="endY">Single endY</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddLine(Single beginX, Single beginY, Single endX, Single endY)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddLine", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, beginX, beginY, endX, endY);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="fileName">string fileName</param>
		/// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
		/// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
		/// <param name="left">Single left</param>
		/// <param name="top">Single top</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, object width, object height)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddPicture", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ fileName, linkToFile, saveWithDocument, left, top, width, height });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="fileName">string fileName</param>
		/// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
		/// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
		/// <param name="left">Single left</param>
		/// <param name="top">Single top</param>
		[CustomMethod]
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddPicture", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ fileName, linkToFile, saveWithDocument, left, top });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="fileName">string fileName</param>
		/// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
		/// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
		/// <param name="left">Single left</param>
		/// <param name="top">Single top</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethod]
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, object width)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddPicture", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ fileName, linkToFile, saveWithDocument, left, top, width });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="safeArrayOfPoints">object safeArrayOfPoints</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddPolyline(object safeArrayOfPoints)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddPolyline", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, safeArrayOfPoints);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoAutoShapeType type</param>
		/// <param name="left">Single left</param>
		/// <param name="top">Single top</param>
		/// <param name="width">Single width</param>
		/// <param name="height">Single height</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddShape(NetOffice.OfficeApi.Enums.MsoAutoShapeType type, Single left, Single top, Single width, Single height)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddShape", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ type, left, top, width, height });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="presetTextEffect">NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect</param>
		/// <param name="text">string text</param>
		/// <param name="fontName">string fontName</param>
		/// <param name="fontSize">Single fontSize</param>
		/// <param name="fontBold">NetOffice.OfficeApi.Enums.MsoTriState fontBold</param>
		/// <param name="fontItalic">NetOffice.OfficeApi.Enums.MsoTriState fontItalic</param>
		/// <param name="left">Single left</param>
		/// <param name="top">Single top</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddTextEffect(NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect, string text, string fontName, Single fontSize, NetOffice.OfficeApi.Enums.MsoTriState fontBold, NetOffice.OfficeApi.Enums.MsoTriState fontItalic, Single left, Single top)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddTextEffect", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ presetTextEffect, text, fontName, fontSize, fontBold, fontItalic, left, top });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation orientation</param>
		/// <param name="left">Single left</param>
		/// <param name="top">Single top</param>
		/// <param name="width">Single width</param>
		/// <param name="height">Single height</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shape AddTextbox(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Shape>(this, "AddTextbox", NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType, new object[]{ orientation, left, top, width, height });
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
		/// <param name="x1">Single x1</param>
		/// <param name="y1">Single y1</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.FreeformBuilder BuildFreeform(NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.FreeformBuilder>(this, "BuildFreeform", NetOffice.PowerPointApi.FreeformBuilder.LateBindingApiWrapperType, editingType, x1, y1);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ShapeRange Range(object index)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.ShapeRange>(this, "Range", NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public void SelectAll()
		{
			 Factory.ExecuteMethod(this, "SelectAll");
		}

		#endregion

       #region IEnumerable<NetOffice.PowerPointApi.Shape> Member
        
        /// <summary>
		/// SupportByVersion PowerPoint, 10,11,12,14,15,16
		/// </summary>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
       public IEnumerator<NetOffice.PowerPointApi.Shape> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.PowerPointApi.Shape item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersion PowerPoint, 10,11,12,14,15,16
		/// </summary>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion

		#pragma warning restore
	}
}



