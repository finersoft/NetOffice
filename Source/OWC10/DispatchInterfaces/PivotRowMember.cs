﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OWC10Api
{
	/// <summary>
	/// DispatchInterface PivotRowMember 
	/// SupportByVersion OWC10, 1
	/// </summary>
	[SupportByVersion("OWC10", 1)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class PivotRowMember : PivotAxisMember
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
                    _type = typeof(PivotRowMember);
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public PivotRowMember(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public NetOffice.OWC10Api.PivotView View
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotView>(this, "View", NetOffice.OWC10Api.PivotView.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public NetOffice.OWC10Api.PivotMembers ChildMembers
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotMembers>(this, "ChildMembers", NetOffice.OWC10Api.PivotMembers.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public NetOffice.OWC10Api.PivotMember ParentMember
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotMember>(this, "ParentMember", NetOffice.OWC10Api.PivotMember.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		/// <param name="path">string path</param>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format</param>
		[SupportByVersion("OWC10", 1)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.OWC10Api.PivotMember get_FindMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotMember>(this, "FindMember", NetOffice.OWC10Api.PivotMember.LateBindingApiWrapperType, path, format);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Alias for get_FindMember
		/// </summary>
		/// <param name="path">string path</param>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format</param>
		[SupportByVersion("OWC10", 1), Redirect("get_FindMember")]
		public NetOffice.OWC10Api.PivotMember FindMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			return get_FindMember(path, format);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public string Name
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Name");
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public string Caption
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Caption");
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public object Value
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "Value");
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public string UniqueName
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "UniqueName");
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public NetOffice.OWC10Api.PivotField Field
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotField>(this, "Field", NetOffice.OWC10Api.PivotField.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format</param>
		[SupportByVersion("OWC10", 1)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string get_Path(NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			return Factory.ExecuteStringPropertyGet(this, "Path", format);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Alias for get_Path
		/// </summary>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format</param>
		[SupportByVersion("OWC10", 1), Redirect("get_Path")]
		public string Path(NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			return get_Path(format);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public object TimeValue
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "TimeValue");
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public bool IsValid
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "IsValid");
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotMemberCustomGroupTypeEnum CustomGroupType
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.OWC10Api.Enums.PivotMemberCustomGroupTypeEnum>(this, "CustomGroupType");
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public NetOffice.OWC10Api.PivotRowMembers ChildRowMembers
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotRowMembers>(this, "ChildRowMembers", NetOffice.OWC10Api.PivotRowMembers.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public NetOffice.OWC10Api.PivotRowMember ParentRowMember
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotRowMember>(this, "ParentRowMember", NetOffice.OWC10Api.PivotRowMember.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		/// <param name="path">string path</param>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format</param>
		[SupportByVersion("OWC10", 1)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.OWC10Api.PivotRowMember get_FindRowMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotRowMember>(this, "FindRowMember", NetOffice.OWC10Api.PivotRowMember.LateBindingApiWrapperType, path, format);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Alias for get_FindRowMember
		/// </summary>
		/// <param name="path">string path</param>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format</param>
		[SupportByVersion("OWC10", 1), Redirect("get_FindRowMember")]
		public NetOffice.OWC10Api.PivotRowMember FindRowMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			return get_FindRowMember(path, format);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public NetOffice.OWC10Api.PivotRowMember TotalRowMember
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotRowMember>(this, "TotalRowMember", NetOffice.OWC10Api.PivotRowMember.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public Int32 TotalRowHeight
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "TotalRowHeight");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "TotalRowHeight", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}


