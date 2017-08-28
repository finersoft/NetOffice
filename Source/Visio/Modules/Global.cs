﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VisioApi.GlobalHelperModules
{
    ///<summary>
    /// Module GlobalModule
    /// SupportByVersion Visio 11,12,14,15,16
    ///</summary>
    [SupportByVersion("Visio", 11,12,14,15,16)]
	[EntityType(EntityType.IsModule), ModuleBaseType(typeof(VisioApi.Application))]
	public static class GlobalModule
	{
		#region Fields

		private static ICOMObject _instance;

        #endregion

        #region Internal Properties

        internal static ICOMObject Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                if ((null == value) || (null == _instance))
                    _instance = value;
            }
        }

        internal static Core Factory
		{
			get
			{
				if(null != _instance)
					 return _instance.Factory;
			else
				return Core.Default;
			}
		}

		internal static Invoker Invoker
		{
			get
			{
				if(null != _instance)
					 return _instance.Invoker;
			else
				return Invoker.Default;
			}
		}

		#endregion

		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public static NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public static NetOffice.VisioApi.IVDocument ActiveDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveDocument", paramsArray);
				NetOffice.VisioApi.IVDocument newObject = Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVDocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public static NetOffice.VisioApi.IVPage ActivePage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActivePage", paramsArray);
				NetOffice.VisioApi.IVPage newObject = Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVPage;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public static NetOffice.VisioApi.IVWindow ActiveWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveWindow", paramsArray);
				NetOffice.VisioApi.IVWindow newObject = Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public static NetOffice.VisioApi.IVDocuments Documents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Documents", paramsArray);
				NetOffice.VisioApi.IVDocuments newObject = Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVDocuments;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public static NetOffice.VisioApi.IVWindows Windows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Windows", paramsArray);
				NetOffice.VisioApi.IVWindows newObject = Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public static NetOffice.VisioApi.IVAddons Addons
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Addons", paramsArray);
				NetOffice.VisioApi.IVAddons newObject = Factory.CreateObjectFromComProxy(_instance,returnItem) as NetOffice.VisioApi.IVAddons;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16), ProxyResult]
		public static object Vbe
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Vbe", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(_instance,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
	}
}

