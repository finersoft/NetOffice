﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.WordApi.GlobalHelperModules
{
    ///<summary>
    /// Module GlobalModule
    /// SupportByVersion Word, 9,10,11,12,14,15,16
    ///</summary>
    [SupportByVersion("Word", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsModule), ModuleBaseType(typeof(WordApi.Application))]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196288.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839176.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837536.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), ProxyResult]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834577.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836002.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Documents Documents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Documents", paramsArray);
				NetOffice.WordApi.Documents newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Documents.LateBindingApiWrapperType) as NetOffice.WordApi.Documents;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192377.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Windows Windows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Windows", paramsArray);
				NetOffice.WordApi.Windows newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Windows.LateBindingApiWrapperType) as NetOffice.WordApi.Windows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838345.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Document ActiveDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveDocument", paramsArray);
				NetOffice.WordApi.Document newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Document.LateBindingApiWrapperType) as NetOffice.WordApi.Document;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197244.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Window ActiveWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveWindow", paramsArray);
				NetOffice.WordApi.Window newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Window.LateBindingApiWrapperType) as NetOffice.WordApi.Window;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198352.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Selection Selection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Selection", paramsArray);
				NetOffice.WordApi.Selection newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Selection.LateBindingApiWrapperType) as NetOffice.WordApi.Selection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837529.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), ProxyResult]
		public static object WordBasic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "WordBasic", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(_instance,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840791.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839389.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.RecentFiles RecentFiles
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "RecentFiles", paramsArray);
				NetOffice.WordApi.RecentFiles newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.RecentFiles.LateBindingApiWrapperType) as NetOffice.WordApi.RecentFiles;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839307.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Template NormalTemplate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "NormalTemplate", paramsArray);
				NetOffice.WordApi.Template newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Template.LateBindingApiWrapperType) as NetOffice.WordApi.Template;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836650.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.System System
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "System", paramsArray);
				NetOffice.WordApi.System newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.System.LateBindingApiWrapperType) as NetOffice.WordApi.System;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193423.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.AutoCorrect AutoCorrect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AutoCorrect", paramsArray);
				NetOffice.WordApi.AutoCorrect newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.AutoCorrect.LateBindingApiWrapperType) as NetOffice.WordApi.AutoCorrect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836088.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.FontNames FontNames
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "FontNames", paramsArray);
				NetOffice.WordApi.FontNames newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.FontNames.LateBindingApiWrapperType) as NetOffice.WordApi.FontNames;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821549.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.FontNames LandscapeFontNames
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "LandscapeFontNames", paramsArray);
				NetOffice.WordApi.FontNames newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.FontNames.LateBindingApiWrapperType) as NetOffice.WordApi.FontNames;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845169.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.FontNames PortraitFontNames
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "PortraitFontNames", paramsArray);
				NetOffice.WordApi.FontNames newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.FontNames.LateBindingApiWrapperType) as NetOffice.WordApi.FontNames;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198149.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Languages Languages
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Languages", paramsArray);
				NetOffice.WordApi.Languages newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Languages.LateBindingApiWrapperType) as NetOffice.WordApi.Languages;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845645.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.FileConverters FileConverters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "FileConverters", paramsArray);
				NetOffice.WordApi.FileConverters newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.FileConverters.LateBindingApiWrapperType) as NetOffice.WordApi.FileConverters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821676.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Dialogs Dialogs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Dialogs", paramsArray);
				NetOffice.WordApi.Dialogs newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Dialogs.LateBindingApiWrapperType) as NetOffice.WordApi.Dialogs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197115.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.CaptionLabels CaptionLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "CaptionLabels", paramsArray);
				NetOffice.WordApi.CaptionLabels newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.CaptionLabels.LateBindingApiWrapperType) as NetOffice.WordApi.CaptionLabels;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822600.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.AutoCaptions AutoCaptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AutoCaptions", paramsArray);
				NetOffice.WordApi.AutoCaptions newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.AutoCaptions.LateBindingApiWrapperType) as NetOffice.WordApi.AutoCaptions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192197.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.AddIns AddIns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AddIns", paramsArray);
				NetOffice.WordApi.AddIns newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.AddIns.LateBindingApiWrapperType) as NetOffice.WordApi.AddIns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839709.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Tasks Tasks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Tasks", paramsArray);
				NetOffice.WordApi.Tasks newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Tasks.LateBindingApiWrapperType) as NetOffice.WordApi.Tasks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834604.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), ProxyResult]
		public static object MacroContainer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "MacroContainer", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(_instance,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836562.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821269.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="languageID">optional object languageID</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.WordApi.SynonymInfo get_SynonymInfo(string word, object languageID)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.SynonymInfo>(_instance, "SynonymInfo", NetOffice.WordApi.SynonymInfo.LateBindingApiWrapperType, word, languageID);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821269.aspx
		/// Alias for get_SynonymInfo
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="languageID">optional object languageID</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), Redirect("get_SynonymInfo")]
		public static NetOffice.WordApi.SynonymInfo SynonymInfo(string word, object languageID)
		{
			return get_SynonymInfo(word, languageID);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821269.aspx
		/// </summary>
		/// <param name="word">string word</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.WordApi.SynonymInfo get_SynonymInfo(string word)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.SynonymInfo>(_instance, "SynonymInfo", NetOffice.WordApi.SynonymInfo.LateBindingApiWrapperType, word);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821269.aspx
		/// Alias for get_SynonymInfo
		/// </summary>
		/// <param name="word">string word</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), Redirect("get_SynonymInfo")]
		public static NetOffice.WordApi.SynonymInfo SynonymInfo(string word)
		{
			return get_SynonymInfo(word);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192171.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.VBIDEApi.VBE VBE
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "VBE", paramsArray);
				NetOffice.VBIDEApi.VBE newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.VBIDEApi.VBE.LateBindingApiWrapperType) as NetOffice.VBIDEApi.VBE;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196201.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.ListGalleries ListGalleries
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ListGalleries", paramsArray);
				NetOffice.WordApi.ListGalleries newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.ListGalleries.LateBindingApiWrapperType) as NetOffice.WordApi.ListGalleries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838478.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static string ActivePrinter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActivePrinter", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "ActivePrinter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195188.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Templates Templates
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Templates", paramsArray);
				NetOffice.WordApi.Templates newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Templates.LateBindingApiWrapperType) as NetOffice.WordApi.Templates;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839619.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), ProxyResult]
		public static object CustomizationContext
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "CustomizationContext", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(_instance,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "CustomizationContext", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821105.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.KeyBindings KeyBindings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "KeyBindings", paramsArray);
				NetOffice.WordApi.KeyBindings newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.KeyBindings.LateBindingApiWrapperType) as NetOffice.WordApi.KeyBindings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197190.aspx
		/// </summary>
		/// <param name="keyCategory">NetOffice.WordApi.Enums.WdKeyCategory keyCategory</param>
		/// <param name="command">string command</param>
		/// <param name="commandParameter">optional object commandParameter</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.WordApi.KeysBoundTo get_KeysBoundTo(NetOffice.WordApi.Enums.WdKeyCategory keyCategory, string command, object commandParameter)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.KeysBoundTo>(_instance, "KeysBoundTo", NetOffice.WordApi.KeysBoundTo.LateBindingApiWrapperType, keyCategory, command, commandParameter);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197190.aspx
		/// Alias for get_KeysBoundTo
		/// </summary>
		/// <param name="keyCategory">NetOffice.WordApi.Enums.WdKeyCategory keyCategory</param>
		/// <param name="command">string command</param>
		/// <param name="commandParameter">optional object commandParameter</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), Redirect("get_KeysBoundTo")]
		public static NetOffice.WordApi.KeysBoundTo KeysBoundTo(NetOffice.WordApi.Enums.WdKeyCategory keyCategory, string command, object commandParameter)
		{
			return get_KeysBoundTo(keyCategory, command, commandParameter);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197190.aspx
		/// </summary>
		/// <param name="keyCategory">NetOffice.WordApi.Enums.WdKeyCategory keyCategory</param>
		/// <param name="command">string command</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.WordApi.KeysBoundTo get_KeysBoundTo(NetOffice.WordApi.Enums.WdKeyCategory keyCategory, string command)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.KeysBoundTo>(_instance, "KeysBoundTo", NetOffice.WordApi.KeysBoundTo.LateBindingApiWrapperType, keyCategory, command);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197190.aspx
		/// Alias for get_KeysBoundTo
		/// </summary>
		/// <param name="keyCategory">NetOffice.WordApi.Enums.WdKeyCategory keyCategory</param>
		/// <param name="command">string command</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), Redirect("get_KeysBoundTo")]
		public static NetOffice.WordApi.KeysBoundTo KeysBoundTo(NetOffice.WordApi.Enums.WdKeyCategory keyCategory, string command)
		{
			return get_KeysBoundTo(keyCategory, command);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821263.aspx
		/// </summary>
		/// <param name="keyCode">Int32 keyCode</param>
		/// <param name="keyCode2">optional object keyCode2</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.WordApi.KeyBinding get_FindKey(Int32 keyCode, object keyCode2)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.KeyBinding>(_instance, "FindKey", NetOffice.WordApi.KeyBinding.LateBindingApiWrapperType, keyCode, keyCode2);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821263.aspx
		/// Alias for get_FindKey
		/// </summary>
		/// <param name="keyCode">Int32 keyCode</param>
		/// <param name="keyCode2">optional object keyCode2</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), Redirect("get_FindKey")]
		public static NetOffice.WordApi.KeyBinding FindKey(Int32 keyCode, object keyCode2)
		{
			return get_FindKey(keyCode, keyCode2);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821263.aspx
		/// </summary>
		/// <param name="keyCode">Int32 keyCode</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.WordApi.KeyBinding get_FindKey(Int32 keyCode)
		{
			return Factory.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.KeyBinding>(_instance, "FindKey", NetOffice.WordApi.KeyBinding.LateBindingApiWrapperType, keyCode);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821263.aspx
		/// Alias for get_FindKey
		/// </summary>
		/// <param name="keyCode">Int32 keyCode</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), Redirect("get_FindKey")]
		public static NetOffice.WordApi.KeyBinding FindKey(Int32 keyCode)
		{
			return get_FindKey(keyCode);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff191993.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Options Options
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Options", paramsArray);
				NetOffice.WordApi.Options newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Options.LateBindingApiWrapperType) as NetOffice.WordApi.Options;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839350.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Dictionaries CustomDictionaries
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "CustomDictionaries", paramsArray);
				NetOffice.WordApi.Dictionaries newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.Dictionaries.LateBindingApiWrapperType) as NetOffice.WordApi.Dictionaries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197891.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static string StatusBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "StatusBar", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "StatusBar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822928.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool ShowVisualBasicEditor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ShowVisualBasicEditor", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(_instance, "ShowVisualBasicEditor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff820807.aspx
		/// </summary>
		/// <param name="_object">object object</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static bool get_IsObjectValid(object _object)
		{
			return Factory.ExecuteBoolPropertyGet(_instance, "IsObjectValid", _object);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff820807.aspx
		/// Alias for get_IsObjectValid
		/// </summary>
		/// <param name="_object">object object</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), Redirect("get_IsObjectValid")]
		public static bool IsObjectValid(object _object)
		{
			return get_IsObjectValid(_object);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194823.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.HangulHanjaConversionDictionaries HangulHanjaDictionaries
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "HangulHanjaDictionaries", paramsArray);
				NetOffice.WordApi.HangulHanjaConversionDictionaries newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.HangulHanjaConversionDictionaries.LateBindingApiWrapperType) as NetOffice.WordApi.HangulHanjaConversionDictionaries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837343.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.OfficeApi.LanguageSettings LanguageSettings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "LanguageSettings", paramsArray);
				NetOffice.OfficeApi.LanguageSettings newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.LanguageSettings.LateBindingApiWrapperType) as NetOffice.OfficeApi.LanguageSettings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.OfficeApi.AnswerWizard AnswerWizard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AnswerWizard", paramsArray);
				NetOffice.OfficeApi.AnswerWizard newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.AnswerWizard.LateBindingApiWrapperType) as NetOffice.OfficeApi.AnswerWizard;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 10, 11, 12, 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821154.aspx
		/// </summary>
		[SupportByVersion("Word", 10,11,12,14,15,16)]
		public static NetOffice.WordApi.AutoCorrect AutoCorrectEmail
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AutoCorrectEmail", paramsArray);
				NetOffice.WordApi.AutoCorrect newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.AutoCorrect.LateBindingApiWrapperType) as NetOffice.WordApi.AutoCorrect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838269.aspx
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public static NetOffice.WordApi.ProtectedViewWindows ProtectedViewWindows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ProtectedViewWindows", paramsArray);
				NetOffice.WordApi.ProtectedViewWindows newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.ProtectedViewWindows.LateBindingApiWrapperType) as NetOffice.WordApi.ProtectedViewWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194319.aspx
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public static NetOffice.WordApi.ProtectedViewWindow ActiveProtectedViewWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveProtectedViewWindow", paramsArray);
				NetOffice.WordApi.ProtectedViewWindow newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.WordApi.ProtectedViewWindow.LateBindingApiWrapperType) as NetOffice.WordApi.ProtectedViewWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845720.aspx
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public static bool IsSandboxed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "IsSandboxed", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192375.aspx
		/// </summary>
		/// <param name="times">optional object times</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool Repeat(object times)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(times);
			object returnItem = Invoker.MethodReturn(_instance, "Repeat", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192375.aspx
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool Repeat()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(_instance, "Repeat", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840368.aspx
		/// </summary>
		/// <param name="channel">Int32 channel</param>
		/// <param name="command">string command</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static void DDEExecute(Int32 channel, string command)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(channel, command);
			Invoker.Method(_instance, "DDEExecute", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195283.aspx
		/// </summary>
		/// <param name="app">string app</param>
		/// <param name="topic">string topic</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Int32 DDEInitiate(string app, string topic)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(app, topic);
			object returnItem = Invoker.MethodReturn(_instance, "DDEInitiate", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838981.aspx
		/// </summary>
		/// <param name="channel">Int32 channel</param>
		/// <param name="item">string item</param>
		/// <param name="data">string data</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static void DDEPoke(Int32 channel, string item, string data)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(channel, item, data);
			Invoker.Method(_instance, "DDEPoke", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837523.aspx
		/// </summary>
		/// <param name="channel">Int32 channel</param>
		/// <param name="item">string item</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static string DDERequest(Int32 channel, string item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(channel, item);
			object returnItem = Invoker.MethodReturn(_instance, "DDERequest", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192402.aspx
		/// </summary>
		/// <param name="channel">Int32 channel</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static void DDETerminate(Int32 channel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(channel);
			Invoker.Method(_instance, "DDETerminate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197534.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static void DDETerminateAll()
		{
			object[] paramsArray = null;
			Invoker.Method(_instance, "DDETerminateAll", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839185.aspx
		/// </summary>
		/// <param name="arg1">NetOffice.WordApi.Enums.WdKey arg1</param>
		/// <param name="arg2">optional object arg2</param>
		/// <param name="arg3">optional object arg3</param>
		/// <param name="arg4">optional object arg4</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Int32 BuildKeyCode(NetOffice.WordApi.Enums.WdKey arg1, object arg2, object arg3, object arg4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4);
			object returnItem = Invoker.MethodReturn(_instance, "BuildKeyCode", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839185.aspx
		/// </summary>
		/// <param name="arg1">NetOffice.WordApi.Enums.WdKey arg1</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Int32 BuildKeyCode(NetOffice.WordApi.Enums.WdKey arg1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1);
			object returnItem = Invoker.MethodReturn(_instance, "BuildKeyCode", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839185.aspx
		/// </summary>
		/// <param name="arg1">NetOffice.WordApi.Enums.WdKey arg1</param>
		/// <param name="arg2">optional object arg2</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Int32 BuildKeyCode(NetOffice.WordApi.Enums.WdKey arg1, object arg2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2);
			object returnItem = Invoker.MethodReturn(_instance, "BuildKeyCode", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839185.aspx
		/// </summary>
		/// <param name="arg1">NetOffice.WordApi.Enums.WdKey arg1</param>
		/// <param name="arg2">optional object arg2</param>
		/// <param name="arg3">optional object arg3</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Int32 BuildKeyCode(NetOffice.WordApi.Enums.WdKey arg1, object arg2, object arg3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3);
			object returnItem = Invoker.MethodReturn(_instance, "BuildKeyCode", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195198.aspx
		/// </summary>
		/// <param name="keyCode">Int32 keyCode</param>
		/// <param name="keyCode2">optional object keyCode2</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static string KeyString(Int32 keyCode, object keyCode2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(keyCode, keyCode2);
			object returnItem = Invoker.MethodReturn(_instance, "KeyString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195198.aspx
		/// </summary>
		/// <param name="keyCode">Int32 keyCode</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static string KeyString(Int32 keyCode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(keyCode);
			object returnItem = Invoker.MethodReturn(_instance, "KeyString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		/// <param name="customDictionary7">optional object customDictionary7</param>
		/// <param name="customDictionary8">optional object customDictionary8</param>
		/// <param name="customDictionary9">optional object customDictionary9</param>
		/// <param name="customDictionary10">optional object customDictionary10</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7, object customDictionary8, object customDictionary9, object customDictionary10)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6, customDictionary7, customDictionary8, customDictionary9, customDictionary10);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2, customDictionary3);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3, object customDictionary4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2, customDictionary3, customDictionary4);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2, customDictionary3, customDictionary4, customDictionary5);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		/// <param name="customDictionary7">optional object customDictionary7</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6, customDictionary7);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		/// <param name="customDictionary7">optional object customDictionary7</param>
		/// <param name="customDictionary8">optional object customDictionary8</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7, object customDictionary8)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6, customDictionary7, customDictionary8);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839930.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		/// <param name="customDictionary7">optional object customDictionary7</param>
		/// <param name="customDictionary8">optional object customDictionary8</param>
		/// <param name="customDictionary9">optional object customDictionary9</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static bool CheckSpelling(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7, object customDictionary8, object customDictionary9)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6, customDictionary7, customDictionary8, customDictionary9);
			object returnItem = Invoker.MethodReturn(_instance, "CheckSpelling", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		/// <param name="customDictionary7">optional object customDictionary7</param>
		/// <param name="customDictionary8">optional object customDictionary8</param>
		/// <param name="customDictionary9">optional object customDictionary9</param>
		/// <param name="customDictionary10">optional object customDictionary10</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7, object customDictionary8, object customDictionary9, object customDictionary10)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6, customDictionary7, customDictionary8, customDictionary9, customDictionary10);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2, customDictionary3);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3, object customDictionary4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2, customDictionary3, customDictionary4);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2, customDictionary3, customDictionary4, customDictionary5);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		/// <param name="customDictionary7">optional object customDictionary7</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6, customDictionary7);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		/// <param name="customDictionary7">optional object customDictionary7</param>
		/// <param name="customDictionary8">optional object customDictionary8</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7, object customDictionary8)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6, customDictionary7, customDictionary8);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845851.aspx
		/// </summary>
		/// <param name="word">string word</param>
		/// <param name="customDictionary">optional object customDictionary</param>
		/// <param name="ignoreUppercase">optional object ignoreUppercase</param>
		/// <param name="mainDictionary">optional object mainDictionary</param>
		/// <param name="suggestionMode">optional object suggestionMode</param>
		/// <param name="customDictionary2">optional object customDictionary2</param>
		/// <param name="customDictionary3">optional object customDictionary3</param>
		/// <param name="customDictionary4">optional object customDictionary4</param>
		/// <param name="customDictionary5">optional object customDictionary5</param>
		/// <param name="customDictionary6">optional object customDictionary6</param>
		/// <param name="customDictionary7">optional object customDictionary7</param>
		/// <param name="customDictionary8">optional object customDictionary8</param>
		/// <param name="customDictionary9">optional object customDictionary9</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.SpellingSuggestions GetSpellingSuggestions(string word, object customDictionary, object ignoreUppercase, object mainDictionary, object suggestionMode, object customDictionary2, object customDictionary3, object customDictionary4, object customDictionary5, object customDictionary6, object customDictionary7, object customDictionary8, object customDictionary9)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(word, customDictionary, ignoreUppercase, mainDictionary, suggestionMode, customDictionary2, customDictionary3, customDictionary4, customDictionary5, customDictionary6, customDictionary7, customDictionary8, customDictionary9);
			object returnItem = Invoker.MethodReturn(_instance, "GetSpellingSuggestions", paramsArray);
			NetOffice.WordApi.SpellingSuggestions newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.SpellingSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.SpellingSuggestions;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838492.aspx
		/// </summary>
		/// <param name="helpType">object helpType</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static void Help(object helpType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpType);
			Invoker.Method(_instance, "Help", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837665.aspx
		/// </summary>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static NetOffice.WordApi.Window NewWindow()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(_instance, "NewWindow", paramsArray);
			NetOffice.WordApi.Window newObject = Factory.CreateKnownObjectFromComProxy(_instance, returnItem,NetOffice.WordApi.Window.LateBindingApiWrapperType) as NetOffice.WordApi.Window;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821231.aspx
		/// </summary>
		/// <param name="_string">string string</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static string CleanString(string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string);
			object returnItem = Invoker.MethodReturn(_instance, "CleanString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff191703.aspx
		/// </summary>
		/// <param name="path">string path</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static void ChangeFileOpenDirectory(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			Invoker.Method(_instance, "ChangeFileOpenDirectory", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821651.aspx
		/// </summary>
		/// <param name="inches">Single inches</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single InchesToPoints(Single inches)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(inches);
			object returnItem = Invoker.MethodReturn(_instance, "InchesToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839169.aspx
		/// </summary>
		/// <param name="centimeters">Single centimeters</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single CentimetersToPoints(Single centimeters)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(centimeters);
			object returnItem = Invoker.MethodReturn(_instance, "CentimetersToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837741.aspx
		/// </summary>
		/// <param name="millimeters">Single millimeters</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single MillimetersToPoints(Single millimeters)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(millimeters);
			object returnItem = Invoker.MethodReturn(_instance, "MillimetersToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837735.aspx
		/// </summary>
		/// <param name="picas">Single picas</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PicasToPoints(Single picas)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(picas);
			object returnItem = Invoker.MethodReturn(_instance, "PicasToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193922.aspx
		/// </summary>
		/// <param name="lines">Single lines</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single LinesToPoints(Single lines)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lines);
			object returnItem = Invoker.MethodReturn(_instance, "LinesToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839542.aspx
		/// </summary>
		/// <param name="points">Single points</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PointsToInches(Single points)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(points);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToInches", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821989.aspx
		/// </summary>
		/// <param name="points">Single points</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PointsToCentimeters(Single points)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(points);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToCentimeters", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff845355.aspx
		/// </summary>
		/// <param name="points">Single points</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PointsToMillimeters(Single points)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(points);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToMillimeters", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821829.aspx
		/// </summary>
		/// <param name="points">Single points</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PointsToPicas(Single points)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(points);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToPicas", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194126.aspx
		/// </summary>
		/// <param name="points">Single points</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PointsToLines(Single points)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(points);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToLines", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839394.aspx
		/// </summary>
		/// <param name="points">Single points</param>
		/// <param name="fVertical">optional object fVertical</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PointsToPixels(Single points, object fVertical)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(points, fVertical);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToPixels", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839394.aspx
		/// </summary>
		/// <param name="points">Single points</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PointsToPixels(Single points)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(points);
			object returnItem = Invoker.MethodReturn(_instance, "PointsToPixels", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197519.aspx
		/// </summary>
		/// <param name="pixels">Single pixels</param>
		/// <param name="fVertical">optional object fVertical</param>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PixelsToPoints(Single pixels, object fVertical)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pixels, fVertical);
			object returnItem = Invoker.MethodReturn(_instance, "PixelsToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197519.aspx
		/// </summary>
		/// <param name="pixels">Single pixels</param>
		[CustomMethod]
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public static Single PixelsToPoints(Single pixels)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pixels);
			object returnItem = Invoker.MethodReturn(_instance, "PixelsToPoints", paramsArray);
			return NetRuntimeSystem.Convert.ToSingle(returnItem);
		}

		#endregion
	}
}


