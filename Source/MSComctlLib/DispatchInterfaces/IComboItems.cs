﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSComctlLibApi
{
	/// <summary>
	/// DispatchInterface IComboItems 
	/// SupportByVersion MSComctlLib, 6
	/// </summary>
	[SupportByVersion("MSComctlLib", 6)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Method), HasIndexProperty(IndexInvoke.Property, "Item")]
	public class IComboItems : COMObject , IEnumerable<NetOffice.MSComctlLibApi.IComboItem>
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
                    _type = typeof(IComboItems);
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IComboItems(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get/Set
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.MSComctlLibApi.IComboItem get__CollectionDefault(object index)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.MSComctlLibApi.IComboItem>(this, "_CollectionDefault", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get/Set
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void set__CollectionDefault(object index, NetOffice.MSComctlLibApi.IComboItem value)
		{
			Factory.ExecutePropertySet(this, "_CollectionDefault", index, value);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Alias for get__CollectionDefault
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6), Redirect("get__CollectionDefault")]
		public NetOffice.MSComctlLibApi.IComboItem _CollectionDefault(object index)
		{
			return get__CollectionDefault(index);
		}

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
		/// Get/Set
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public NetOffice.MSComctlLibApi.IComboItem this[object index]
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.MSComctlLibApi.IComboItem>(this, "Item", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType, index);
			}
			set
			{
				Factory.ExecuteReferencePropertySet(this, "Item", value, index);
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
		/// <param name="image">optional object image</param>
		/// <param name="selImage">optional object selImage</param>
		/// <param name="indentation">optional object indentation</param>
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key, object text, object image, object selImage, object indentation)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IComboItem>(this, "Add", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType, new object[]{ index, key, text, image, selImage, indentation });
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add()
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IComboItem>(this, "Add", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IComboItem>(this, "Add", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType, index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IComboItem>(this, "Add", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType, index, key);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key, object text)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IComboItem>(this, "Add", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType, index, key, text);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="image">optional object image</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key, object text, object image)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IComboItem>(this, "Add", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType, index, key, text, image);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">optional object index</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="image">optional object image</param>
		/// <param name="selImage">optional object selImage</param>
		[CustomMethod]
		[SupportByVersion("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key, object text, object image, object selImage)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.MSComctlLibApi.IComboItem>(this, "Add", NetOffice.MSComctlLibApi.IComboItem.LateBindingApiWrapperType, new object[]{ index, key, text, image, selImage });
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

		#endregion

       #region IEnumerable<NetOffice.MSComctlLibApi.IComboItem> Member
        
        /// <summary>
		/// SupportByVersion MSComctlLib, 6
		/// </summary>
		[SupportByVersion("MSComctlLib", 6)]
       public IEnumerator<NetOffice.MSComctlLibApi.IComboItem> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.MSComctlLibApi.IComboItem item in innerEnumerator)
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



