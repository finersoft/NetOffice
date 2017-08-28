﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSComctlLibApi
{
	/// <summary>
	/// DispatchInterface IColumnHeaders 
	/// SupportByVersion MSComctlLib, 6
	/// </summary>
	[SupportByVersion("MSComctlLib", 6)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Method), HasIndexProperty(IndexInvoke.Property, "Item")]
	public class IColumnHeaders : COMObject , IEnumerable<NetOffice.MSComctlLibApi.IColumnHeader>
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
                    _type = typeof(IColumnHeaders);
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IColumnHeaders(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSComctlLib", 6)]
		public Int32 Count
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Count");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Count", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.MSComctlLibApi.IColumnHeader get_ControlDefault(object index)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "ControlDefault", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Alias for get_ControlDefault
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6), Redirect("get_ControlDefault")]
		public NetOffice.MSComctlLibApi.IColumnHeader ControlDefault(object index)
		{
			return get_ControlDefault(index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public NetOffice.MSComctlLibApi.IColumnHeader this[object index]
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Item", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="width">optional object width</param>
		/// <param name="alignment">optional object alignment</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add_PreVB98(object index, object key, object text, object width, object alignment)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add_PreVB98", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, new object[]{ index, key, text, width, alignment });
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add_PreVB98()
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add_PreVB98", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add_PreVB98(object index)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add_PreVB98", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add_PreVB98(object index, object key)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add_PreVB98", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index, key);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add_PreVB98(object index, object key, object text)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add_PreVB98", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index, key, text);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="width">optional object width</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add_PreVB98(object index, object key, object text, object width)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add_PreVB98", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index, key, text, width);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		[SupportByVersion("MSComctlLib", 6)]
		public void Clear()
		{
			 Factory.ExecuteMethod(this, "Clear");
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		public void Remove(object index)
		{
			 Factory.ExecuteMethod(this, "Remove", index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="width">optional object width</param>
		/// <param name="alignment">optional object alignment</param>
		/// <param name="icon">optional object icon</param>
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add(object index, object key, object text, object width, object alignment, object icon)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, new object[]{ index, key, text, width, alignment, icon });
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add()
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add(object index)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add(object index, object key)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index, key);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add(object index, object key, object text)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index, key, text);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="width">optional object width</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add(object index, object key, object text, object width)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, index, key, text, width);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="width">optional object width</param>
		/// <param name="alignment">optional object alignment</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IColumnHeader Add(object index, object key, object text, object width, object alignment)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IColumnHeader>(this, "Add", NetOffice.MSComctlLibApi.IColumnHeader.LateBindingApiWrapperType, new object[]{ index, key, text, width, alignment });
		}

		#endregion

       #region IEnumerable<NetOffice.MSComctlLibApi.IColumnHeader> Member
        
        /// <summary>
		/// SupportByVersion MSComctlLib, 6
		/// </summary>
		[SupportByVersion("MSComctlLib", 6)]
       public IEnumerator<NetOffice.MSComctlLibApi.IColumnHeader> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.MSComctlLibApi.IColumnHeader item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersion MSComctlLib, 6
		/// </summary>
		[SupportByVersion("MSComctlLib", 6)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion

		#pragma warning restore
	}
}



