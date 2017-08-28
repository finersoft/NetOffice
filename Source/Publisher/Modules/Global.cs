﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.PublisherApi.GlobalHelperModules
{
    ///<summary>
    /// Module GlobalModule
    /// SupportByVersion Publisher, 14,15,16
    ///</summary>
    [SupportByVersion("Publisher", 14,15,16)]
	[EntityType(EntityType.IsModule), ModuleBaseType(typeof(PublisherApi.Application))]
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
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Document ActiveDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveDocument", paramsArray);
				NetOffice.PublisherApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.Document.LateBindingApiWrapperType) as NetOffice.PublisherApi.Document;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Window ActiveWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveWindow", paramsArray);
				NetOffice.PublisherApi.Window newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.Window.LateBindingApiWrapperType) as NetOffice.PublisherApi.Window;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Application", paramsArray);
				NetOffice.PublisherApi.Application newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.Application.LateBindingApiWrapperType) as NetOffice.PublisherApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.OfficeApi.Assistant Assistant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Assistant", paramsArray);
				NetOffice.OfficeApi.Assistant newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.Assistant.LateBindingApiWrapperType) as NetOffice.OfficeApi.Assistant;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Int32 Build
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Build", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.ColorSchemes ColorSchemes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ColorSchemes", paramsArray);
				NetOffice.PublisherApi.ColorSchemes newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.ColorSchemes.LateBindingApiWrapperType) as NetOffice.PublisherApi.ColorSchemes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.OfficeApi.COMAddIns COMAddIns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "COMAddIns", paramsArray);
				NetOffice.OfficeApi.COMAddIns newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.COMAddIns.LateBindingApiWrapperType) as NetOffice.OfficeApi.COMAddIns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.OfficeApi.CommandBars CommandBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "CommandBars", paramsArray);
				NetOffice.OfficeApi.CommandBars newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.CommandBars.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoFileDialogType type</param>
		[SupportByVersion("Publisher", 14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.OfficeApi.FileDialog get_FileDialog(NetOffice.OfficeApi.Enums.MsoFileDialogType type)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.FileDialog>(_instance, "FileDialog", NetOffice.OfficeApi.FileDialog.LateBindingApiWrapperType, type);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Alias for get_FileDialog
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoFileDialogType type</param>
		[SupportByVersion("Publisher", 14,15,16), Redirect("get_FileDialog")]
		public static NetOffice.OfficeApi.FileDialog FileDialog(NetOffice.OfficeApi.Enums.MsoFileDialogType type)
		{
			return get_FileDialog(type);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.OfficeApi.FileSearch FileSearch
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "FileSearch", paramsArray);
				NetOffice.OfficeApi.FileSearch newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.FileSearch.LateBindingApiWrapperType) as NetOffice.OfficeApi.FileSearch;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Int32 Language
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Language", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Options Options
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Options", paramsArray);
				NetOffice.PublisherApi.Options newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.Options.LateBindingApiWrapperType) as NetOffice.PublisherApi.Options;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16), ProxyResult]
		public static object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Parent", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(_instance,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static string Path
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Path", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static string PathSeparator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "PathSeparator", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static string ProductCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ProductCode", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static bool PrintPreview
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "PrintPreview", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "PrintPreview", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static bool ScreenUpdating
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ScreenUpdating", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "ScreenUpdating", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Selection Selection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Selection", paramsArray);
				NetOffice.PublisherApi.Selection newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.Selection.LateBindingApiWrapperType) as NetOffice.PublisherApi.Selection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static bool SnapToGuides
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "SnapToGuides", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "SnapToGuides", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static bool SnapToObjects
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "SnapToObjects", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "SnapToObjects", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static string TemplateFolderPath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "TemplateFolderPath", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Version", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.OfficeApi.OfficeDataSourceObject OfficeDataSourceObject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "OfficeDataSourceObject", paramsArray);
				NetOffice.OfficeApi.OfficeDataSourceObject newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.OfficeDataSourceObject.LateBindingApiWrapperType) as NetOffice.OfficeApi.OfficeDataSourceObject;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static bool WizardCatalogVisible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "WizardCatalogVisible", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "WizardCatalogVisible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Documents Documents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Documents", paramsArray);
				NetOffice.PublisherApi.Documents newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.Documents.LateBindingApiWrapperType) as NetOffice.PublisherApi.Documents;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.WebOptions WebOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "WebOptions", paramsArray);
				NetOffice.PublisherApi.WebOptions newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.WebOptions.LateBindingApiWrapperType) as NetOffice.PublisherApi.WebOptions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.InstalledPrinters InstalledPrinters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "InstalledPrinters", paramsArray);
				NetOffice.PublisherApi.InstalledPrinters newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.InstalledPrinters.LateBindingApiWrapperType) as NetOffice.PublisherApi.InstalledPrinters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.OfficeApi.MsoDebugOptions MsoDebugOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "MsoDebugOptions", paramsArray);
				NetOffice.OfficeApi.MsoDebugOptions newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.MsoDebugOptions.LateBindingApiWrapperType) as NetOffice.OfficeApi.MsoDebugOptions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static bool ValidateAddressVisible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ValidateAddressVisible", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "ValidateAddressVisible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static bool InsertBarcodeVisible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "InsertBarcodeVisible", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "InsertBarcodeVisible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static string ShowFollowUpCustom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ShowFollowUpCustom", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "ShowFollowUpCustom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.OfficeApi.Enums.MsoAutomationSecurity AutomationSecurity
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AutomationSecurity", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoAutomationSecurity)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "AutomationSecurity", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.OfficeApi.IAssistance Assistance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Assistance", paramsArray);
				NetOffice.OfficeApi.IAssistance newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.IAssistance.LateBindingApiWrapperType) as NetOffice.OfficeApi.IAssistance;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.CaptionStyles CaptionStyles
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "CaptionStyles", paramsArray);
				NetOffice.PublisherApi.CaptionStyles newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PublisherApi.CaptionStyles.LateBindingApiWrapperType) as NetOffice.PublisherApi.CaptionStyles;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="dir">string dir</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static void ChangeFileOpenDirectory(string dir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dir);
			Invoker.Method(_instance, "ChangeFileOpenDirectory", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="helpType">NetOffice.PublisherApi.Enums.PbHelpType helpType</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static void Help(NetOffice.PublisherApi.Enums.PbHelpType helpType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpType);
			Invoker.Method(_instance, "Help", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="_object">object object</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static bool IsValidObject(object _object)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_object);
			object returnItem = Invoker.MethodReturn(_instance, "IsValidObject", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="wizard">optional NetOffice.PublisherApi.Enums.PbWizard Wizard = 0</param>
		/// <param name="design">optional Int32 Design = -1</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Document NewDocument(object wizard, object design)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wizard, design);
			object returnItem = Invoker.MethodReturn(_instance, "NewDocument", paramsArray);
			NetOffice.PublisherApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.PublisherApi.Document.LateBindingApiWrapperType) as NetOffice.PublisherApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Document NewDocument()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(_instance, "NewDocument", paramsArray);
			NetOffice.PublisherApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.PublisherApi.Document.LateBindingApiWrapperType) as NetOffice.PublisherApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="wizard">optional NetOffice.PublisherApi.Enums.PbWizard Wizard = 0</param>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Document NewDocument(object wizard)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wizard);
			object returnItem = Invoker.MethodReturn(_instance, "NewDocument", paramsArray);
			NetOffice.PublisherApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.PublisherApi.Document.LateBindingApiWrapperType) as NetOffice.PublisherApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="filename">string filename</param>
		/// <param name="readOnly">optional bool ReadOnly = false</param>
		/// <param name="addToRecentFiles">optional bool AddToRecentFiles = true</param>
		/// <param name="saveChanges">optional NetOffice.PublisherApi.Enums.PbSaveOptions SaveChanges = 1</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Document Open(string filename, object readOnly, object addToRecentFiles, object saveChanges)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, readOnly, addToRecentFiles, saveChanges);
			object returnItem = Invoker.MethodReturn(_instance, "Open", paramsArray);
			NetOffice.PublisherApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.PublisherApi.Document.LateBindingApiWrapperType) as NetOffice.PublisherApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="filename">string filename</param>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Document Open(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(_instance, "Open", paramsArray);
			NetOffice.PublisherApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.PublisherApi.Document.LateBindingApiWrapperType) as NetOffice.PublisherApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="filename">string filename</param>
		/// <param name="readOnly">optional bool ReadOnly = false</param>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Document Open(string filename, object readOnly)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, readOnly);
			object returnItem = Invoker.MethodReturn(_instance, "Open", paramsArray);
			NetOffice.PublisherApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.PublisherApi.Document.LateBindingApiWrapperType) as NetOffice.PublisherApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="filename">string filename</param>
		/// <param name="readOnly">optional bool ReadOnly = false</param>
		/// <param name="addToRecentFiles">optional bool AddToRecentFiles = true</param>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public static NetOffice.PublisherApi.Document Open(string filename, object readOnly, object addToRecentFiles)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, readOnly, addToRecentFiles);
			object returnItem = Invoker.MethodReturn(_instance, "Open", paramsArray);
			NetOffice.PublisherApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.PublisherApi.Document.LateBindingApiWrapperType) as NetOffice.PublisherApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		[SupportByVersion("Publisher", 14,15,16)]
		public static void Quit()
		{
			object[] paramsArray = null;
			Invoker.Method(_instance, "Quit", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersion("Publisher", 14,15,16)]
		public static void LaunchWebService()
		{
			object[] paramsArray = null;
			Invoker.Method(_instance, "LaunchWebService", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single CentimetersToPoints(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "CentimetersToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single EmusToPoints(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "EmusToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single InchesToPoints(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "InchesToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single LinesToPoints(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "LinesToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single MillimetersToPoints(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "MillimetersToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PicasToPoints(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PicasToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PixelsToPoints(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PixelsToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single TwipsToPoints(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "TwipsToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PointsToCentimeters(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToCentimeters", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PointsToEmus(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToEmus", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PointsToInches(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToInches", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PointsToLines(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToLines", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PointsToMillimeters(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToMillimeters", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PointsToPicas(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToPicas", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PointsToPixels(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToPixels", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="value">Single value</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static Single PointsToTwips(Single value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToTwips", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		/// <param name="wizard">optional NetOffice.PublisherApi.Enums.PbWizard Wizard = 0</param>
		[SupportByVersion("Publisher", 14,15,16)]
		public static void ShowWizardCatalog(object wizard)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wizard);
			Invoker.Method(_instance, "ShowWizardCatalog", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Publisher", 14,15,16)]
		public static void ShowWizardCatalog()
		{
			object[] paramsArray = null;
			Invoker.Method(_instance, "ShowWizardCatalog", paramsArray);
		}

		#endregion
	}
}


