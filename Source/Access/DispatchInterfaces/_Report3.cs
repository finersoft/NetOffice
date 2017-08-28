﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.AccessApi
{
	/// <summary>
	/// DispatchInterface _Report3 
	/// SupportByVersion Access, 12,14,15,16
	/// </summary>
	[SupportByVersion("Access", 12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Method)]
	public class _Report3 : _Report2 , IEnumerable<object>
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
                    _type = typeof(_Report3);
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public _Report3(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Report3(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Report3(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Report3(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Report3(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Report3() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Report3(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string FormName
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "FormName");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FormName", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string RecordSource
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "RecordSource");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "RecordSource", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string Filter
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Filter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Filter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool FilterOn
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "FilterOn");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FilterOn", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string OrderBy
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OrderBy");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OrderBy", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool OrderByOn
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "OrderByOn");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OrderByOn", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string ServerFilter
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "ServerFilter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ServerFilter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string Caption
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Caption");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Caption", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte RecordLocks
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "RecordLocks");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "RecordLocks", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte PageHeader
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "PageHeader");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PageHeader", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte PageFooter
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "PageFooter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PageFooter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte DateGrouping
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "DateGrouping");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "DateGrouping", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte GrpKeepTogether
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "GrpKeepTogether");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "GrpKeepTogether", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public bool MinButton
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "MinButton");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "MinButton", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public bool MaxButton
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "MaxButton");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "MaxButton", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 Width
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "Width");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Width", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string Picture
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Picture");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Picture", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte PictureType
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "PictureType");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PictureType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte PictureSizeMode
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "PictureSizeMode");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PictureSizeMode", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte PictureAlignment
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "PictureAlignment");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PictureAlignment", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool PictureTiling
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "PictureTiling");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PictureTiling", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte PicturePages
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "PicturePages");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PicturePages", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string MenuBar
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "MenuBar");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "MenuBar", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string Toolbar
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Toolbar");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Toolbar", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string ShortcutMenuBar
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "ShortcutMenuBar");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ShortcutMenuBar", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 GridX
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "GridX");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "GridX", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 GridY
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "GridY");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "GridY", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool LayoutForPrint
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "LayoutForPrint");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "LayoutForPrint", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool FastLaserPrinting
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "FastLaserPrinting");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FastLaserPrinting", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string HelpFile
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "HelpFile");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "HelpFile", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 HelpContextId
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "HelpContextId");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "HelpContextId", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 Hwnd
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Hwnd");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Hwnd", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 Count
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "Count");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Count", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 Page
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Page");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Page", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 Pages
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "Pages");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Pages", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 LogicalPageWidth
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "LogicalPageWidth");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "LogicalPageWidth", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 LogicalPageHeight
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "LogicalPageHeight");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "LogicalPageHeight", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 ZoomControl
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "ZoomControl");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ZoomControl", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 HasData
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "HasData");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "HasData", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 Left
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Left");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Left", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 Top
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Top");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Top", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 Height
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Height");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Height", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool PrintSection
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "PrintSection");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PrintSection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool NextRecord
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "NextRecord");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "NextRecord", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool MoveLayout
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "MoveLayout");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "MoveLayout", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 FormatCount
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "FormatCount");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FormatCount", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 PrintCount
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "PrintCount");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PrintCount", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool Visible
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "Visible");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Visible", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool Painting
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "Painting");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Painting", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object PrtMip
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "PrtMip");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "PrtMip", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object PrtDevMode
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "PrtDevMode");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "PrtDevMode", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object PrtDevNames
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "PrtDevNames");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "PrtDevNames", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 ForeColor
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "ForeColor");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ForeColor", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Single CurrentX
		{
			get
			{
				return Factory.ExecuteSinglePropertyGet(this, "CurrentX");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "CurrentX", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Single CurrentY
		{
			get
			{
				return Factory.ExecuteSinglePropertyGet(this, "CurrentY");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "CurrentY", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Single ScaleHeight
		{
			get
			{
				return Factory.ExecuteSinglePropertyGet(this, "ScaleHeight");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ScaleHeight", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Single ScaleLeft
		{
			get
			{
				return Factory.ExecuteSinglePropertyGet(this, "ScaleLeft");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ScaleLeft", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 ScaleMode
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "ScaleMode");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ScaleMode", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Single ScaleTop
		{
			get
			{
				return Factory.ExecuteSinglePropertyGet(this, "ScaleTop");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ScaleTop", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Single ScaleWidth
		{
			get
			{
				return Factory.ExecuteSinglePropertyGet(this, "ScaleWidth");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ScaleWidth", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 FontBold
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "FontBold");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FontBold", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 FontItalic
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "FontItalic");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FontItalic", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string FontName
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "FontName");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FontName", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 FontSize
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "FontSize");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FontSize", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 FontUnderline
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "FontUnderline");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FontUnderline", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 DrawMode
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "DrawMode");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "DrawMode", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 DrawStyle
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "DrawStyle");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "DrawStyle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 DrawWidth
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "DrawWidth");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "DrawWidth", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 FillColor
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "FillColor");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FillColor", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int16 FillStyle
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "FillStyle");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FillStyle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string _Name
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "_Name");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "_Name", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string PaletteSource
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "PaletteSource");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PaletteSource", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string Tag
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Tag");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Tag", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object PaintPalette
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "PaintPalette");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "PaintPalette", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnMenu
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnMenu");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnMenu", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string OnOpen
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnOpen");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnOpen", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string OnClose
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnClose");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnClose", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string OnActivate
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnActivate");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnActivate", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string OnDeactivate
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnDeactivate");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnDeactivate", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string OnNoData
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnNoData");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnNoData", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string OnPage
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnPage");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnPage", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string OnError
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnError");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnError", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool Dirty
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "Dirty");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Dirty", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Int32 CurrentRecord
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "CurrentRecord");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "CurrentRecord", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object PictureData
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "PictureData");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "PictureData", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object PicturePalette
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "PicturePalette");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "PicturePalette", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public bool HasModule
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "HasModule");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "HasModule", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 acHiddenCurrentPage
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "acHiddenCurrentPage");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "acHiddenCurrentPage", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public byte Orientation
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "Orientation");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Orientation", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string InputParameters
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "InputParameters");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "InputParameters", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public NetOffice.AccessApi.Application Application
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Application>(this, "Application", NetOffice.AccessApi.Application.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public NetOffice.AccessApi.Control ActiveControl
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Control>(this, "ActiveControl", NetOffice.AccessApi.Control.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="controlType">Int32 controlType</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.AccessApi.Control get_DefaultControl(Int32 controlType)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Control>(this, "DefaultControl", NetOffice.AccessApi.Control.LateBindingApiWrapperType, controlType);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Alias for get_DefaultControl
		/// </summary>
		/// <param name="controlType">Int32 controlType</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16), Redirect("get_DefaultControl")]
		public NetOffice.AccessApi.Control DefaultControl(Int32 controlType)
		{
			return get_DefaultControl(controlType);
		}

		/// <summary>
		/// SupportByVersion Access 12
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Access", 12)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.AccessApi.Section get__SectionOld(object index)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Section>(this, "_SectionOld", NetOffice.AccessApi.Section.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion Access 12
		/// Alias for get__SectionOld
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Access", 12), Redirect("get__SectionOld")]
		public NetOffice.AccessApi.Section _SectionOld(object index)
		{
			return get__SectionOld(index);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.AccessApi.GroupLevel get_GroupLevel(Int32 index)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.GroupLevel>(this, "GroupLevel", NetOffice.AccessApi.GroupLevel.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Alias for get_GroupLevel
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16), Redirect("get_GroupLevel")]
		public NetOffice.AccessApi.GroupLevel GroupLevel(Int32 index)
		{
			return get_GroupLevel(index);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public NetOffice.AccessApi.Report Report
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Report>(this, "Report", NetOffice.AccessApi.Report.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public NetOffice.AccessApi.Module Module
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Module>(this, "Module", NetOffice.AccessApi.Module.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public NetOffice.AccessApi.Properties Properties
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Properties>(this, "Properties", NetOffice.AccessApi.Properties.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public NetOffice.AccessApi.Controls Controls
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Controls>(this, "Controls", NetOffice.AccessApi.Controls.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public string Name
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Name");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Name", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public bool AutoResize
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AutoResize");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "AutoResize", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public bool AutoCenter
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AutoCenter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "AutoCenter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public bool PopUp
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "PopUp");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PopUp", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public bool Modal
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "Modal");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Modal", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public byte BorderStyle
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "BorderStyle");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "BorderStyle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public bool ControlBox
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "ControlBox");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ControlBox", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public byte MinMaxButtons
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "MinMaxButtons");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "MinMaxButtons", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public bool CloseButton
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "CloseButton");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "CloseButton", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public Int16 WindowWidth
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "WindowWidth");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "WindowWidth", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public Int16 WindowHeight
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "WindowHeight");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "WindowHeight", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public Int16 WindowTop
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "WindowTop");
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public Int16 WindowLeft
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "WindowLeft");
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public object OpenArgs
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "OpenArgs");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "OpenArgs", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public NetOffice.AccessApi._Printer Printer
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi._Printer>(this, "Printer", NetOffice.AccessApi._Printer.LateBindingApiWrapperType);
			}
			set
			{
				Factory.ExecuteReferencePropertySet(this, "Printer", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public bool Moveable
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "Moveable");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Moveable", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public bool UseDefaultPrinter
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "UseDefaultPrinter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "UseDefaultPrinter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16), ProxyResult]
		public object Recordset
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Recordset");
			}
			set
			{
				Factory.ExecuteReferencePropertySet(this, "Recordset", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public string RecordSourceQualifier
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "RecordSourceQualifier");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "RecordSourceQualifier", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public string Shape
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Shape");
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public bool FilterOnLoad
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "FilterOnLoad");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FilterOnLoad", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public bool OrderByOnLoad
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "OrderByOnLoad");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OrderByOnLoad", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public byte DefaultView
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "DefaultView");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "DefaultView", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public bool AllowReportView
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowReportView");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "AllowReportView", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public byte ScrollBars
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "ScrollBars");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ScrollBars", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public byte Cycle
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "Cycle");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Cycle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public bool AllowDesignChanges
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowDesignChanges");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "AllowDesignChanges", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnCurrent
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnCurrent");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnCurrent", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public bool KeyPreview
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "KeyPreview");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "KeyPreview", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public Int32 TimerInterval
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "TimerInterval");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "TimerInterval", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public Int16 CurrentView
		{
			get
			{
				return Factory.ExecuteInt16PropertyGet(this, "CurrentView");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "CurrentView", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnOpenMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnOpenMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnOpenMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnCloseMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnCloseMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnCloseMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnActivateMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnActivateMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnActivateMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnDeactivateMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnDeactivateMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnDeactivateMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnNoDataMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnNoDataMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnNoDataMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnPageMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnPageMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnPageMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnErrorMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnErrorMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnErrorMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnCurrentMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnCurrentMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnCurrentMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnLoadMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnLoadMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnLoadMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnResizeMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnResizeMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnResizeMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnUnloadMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnUnloadMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnUnloadMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnGotFocusMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnGotFocusMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnGotFocusMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnLostFocusMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnLostFocusMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnLostFocusMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnClickMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnClickMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnClickMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnDblClickMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnDblClickMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnDblClickMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnMouseDownMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnMouseDownMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnMouseDownMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnMouseMoveMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnMouseMoveMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnMouseMoveMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnMouseUpMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnMouseUpMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnMouseUpMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnKeyDownMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnKeyDownMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnKeyDownMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnKeyUpMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnKeyUpMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnKeyUpMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnKeyPressMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnKeyPressMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnKeyPressMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnFilterMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnFilterMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnFilterMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnApplyFilterMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnApplyFilterMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnApplyFilterMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string OnTimerMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnTimerMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnTimerMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string MouseWheelMacro
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "MouseWheelMacro");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "MouseWheelMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public bool ShowPageMargins
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "ShowPageMargins");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ShowPageMargins", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public bool FitToPage
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "FitToPage");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "FitToPage", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public bool AllowLayoutView
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowLayoutView");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "AllowLayoutView", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnLoad
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnLoad");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnLoad", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnResize
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnResize");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnResize", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnUnload
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnUnload");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnUnload", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnGotFocus
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnGotFocus");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnGotFocus", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnLostFocus
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnLostFocus");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnLostFocus", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnClick
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnClick");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnClick", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnDblClick
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnDblClick");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnDblClick", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnMouseDown
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnMouseDown");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnMouseDown", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnMouseMove
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnMouseMove");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnMouseMove", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnMouseUp
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnMouseUp");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnMouseUp", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnKeyDown
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnKeyDown");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnKeyDown", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnKeyUp
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnKeyUp");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnKeyUp", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnKeyPress
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnKeyPress");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnKeyPress", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnFilter
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnFilter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnFilter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnApplyFilter
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnApplyFilter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnApplyFilter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string OnTimer
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "OnTimer");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "OnTimer", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string MouseWheel
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "MouseWheel");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "MouseWheel", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public byte DisplayOnSharePointSite
		{
			get
			{
				return Factory.ExecuteBytePropertyGet(this, "DisplayOnSharePointSite");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "DisplayOnSharePointSite", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.AccessApi._Section get_Section(object index)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi._Section>(this, "Section", NetOffice.AccessApi._Section.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Alias for get_Section
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16), Redirect("get_Section")]
		public NetOffice.AccessApi._Section Section(object index)
		{
			return get_Section(index);
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public string RibbonName
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "RibbonName");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "RibbonName", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Access", 14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.AccessApi.Section get_SectionOld(object index)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Section>(this, "SectionOld", NetOffice.AccessApi.Section.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion Access 14, 15, 16
		/// Alias for get_SectionOld
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Access", 14,15,16), Redirect("get_SectionOld")]
		public NetOffice.AccessApi.Section SectionOld(object index)
		{
			return get_SectionOld(index);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="flags">Int16 flags</param>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="radius">Single radius</param>
		/// <param name="color">Int32 color</param>
		/// <param name="start">Single start</param>
		/// <param name="end">Single end</param>
		/// <param name="aspect">Single aspect</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public void Circle(Int16 flags, Single x, Single y, Single radius, Int32 color, Single start, Single end, Single aspect)
		{
			 Factory.ExecuteMethod(this, "Circle", new object[]{ flags, x, y, radius, color, start, end, aspect });
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="flags">Int16 flags</param>
		/// <param name="x1">Single x1</param>
		/// <param name="y1">Single y1</param>
		/// <param name="x2">Single x2</param>
		/// <param name="y2">Single y2</param>
		/// <param name="color">Int32 color</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public void Line(Int16 flags, Single x1, Single y1, Single x2, Single y2, Int32 color)
		{
			 Factory.ExecuteMethod(this, "Line", new object[]{ flags, x1, y1, x2, y2, color });
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="flags">Int16 flags</param>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="color">Int32 color</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public void PSet(Int16 flags, Single x, Single y, Int32 color)
		{
			 Factory.ExecuteMethod(this, "PSet", flags, x, y, color);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="flags">Int16 flags</param>
		/// <param name="x1">Single x1</param>
		/// <param name="y1">Single y1</param>
		/// <param name="x2">Single x2</param>
		/// <param name="y2">Single y2</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public void Scale(Int16 flags, Single x1, Single y1, Single x2, Single y2)
		{
			 Factory.ExecuteMethod(this, "Scale", new object[]{ flags, x1, y1, x2, y2 });
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="expr">string expr</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Single TextWidth(string expr)
		{
			return Factory.ExecuteSingleMethodGet(this, "TextWidth", expr);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="expr">string expr</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public Single TextHeight(string expr)
		{
			return Factory.ExecuteSingleMethodGet(this, "TextHeight", expr);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="expr">string expr</param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public void Print(string expr)
		{
			 Factory.ExecuteMethod(this, "Print", expr);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="bstrExpr">string bstrExpr</param>
		/// <param name="ppsa">optional object[] ppsa</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public object _Evaluate(string bstrExpr, object[] ppsa)
		{
            object[] paramsArray = Invoker.ValidateParamsArray(bstrExpr, (object)ppsa);
            object returnItem = Invoker.MethodReturn(this, "_Evaluate", paramsArray);
            if ((null != returnItem) && (returnItem is MarshalByRefObject))
            {
                ICOMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
                return newObject;
            }
            else
            {
                return returnItem;
            }
        }

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="bstrExpr">string bstrExpr</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public object _Evaluate(string bstrExpr)
		{
			return Factory.ExecuteVariantMethodGet(this, "_Evaluate", bstrExpr);
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="left">object left</param>
		/// <param name="top">optional object top</param>
		/// <param name="width">optional object width</param>
		/// <param name="height">optional object height</param>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public void Move(object left, object top, object width, object height)
		{
			 Factory.ExecuteMethod(this, "Move", left, top, width, height);
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="left">object left</param>
		[CustomMethod]
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public void Move(object left)
		{
			 Factory.ExecuteMethod(this, "Move", left);
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="left">object left</param>
		/// <param name="top">optional object top</param>
		[CustomMethod]
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public void Move(object left, object top)
		{
			 Factory.ExecuteMethod(this, "Move", left, top);
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="left">object left</param>
		/// <param name="top">optional object top</param>
		/// <param name="width">optional object width</param>
		[CustomMethod]
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public void Move(object left, object top, object width)
		{
			 Factory.ExecuteMethod(this, "Move", left, top, width);
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public void Requery()
		{
			 Factory.ExecuteMethod(this, "Requery");
		}

        #endregion

        #region IEnumerable<object> Member

        /// <summary>
        /// SupportByVersion Access, 12,14,15,16
        /// </summary>
        [SupportByVersion("Access", 12, 14, 15, 16)]
        public IEnumerator<object> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (object item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable Members

        /// <summary>
        /// SupportByVersion Access, 12,14,15,16
        /// </summary>
        [SupportByVersion("Access", 12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion

		#pragma warning restore
	}
}



