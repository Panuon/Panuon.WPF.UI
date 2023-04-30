using Panuon.WPF.UI.Configurations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class GlobalSettings
        : DependencyObject
    {
        #region Static Properties
        public static GlobalSetting Setting { get; } = new GlobalSetting();
        #endregion

        #region Ctor
        private void Current_Startup(object sender, StartupEventArgs e)
        {
            if (Themes != null
                && Themes.Any())
            {
                ChangeTheme(Themes.First().Key);
            }
        }

        public GlobalSettings()
        {

            Application.Current.Startup += Current_Startup;
        }
        #endregion

        #region Properties

        #region DisabledOpacity
        public double DisabledOpacity
        {
            get
            {
                return Setting.DisabledOpacity;
            }
            set
            {
                Setting.DisabledOpacity = value;
            }
        }
        #endregion

        #region FontFamily
        public FontFamily FontFamily
        {
            get
            {
                return Setting.FontFamily;
            }
            set
            {
                Setting.FontFamily = value;
            }
        }
        #endregion

        #region FontSize
        public double FontSize
        {
            get
            {
                return Setting.FontSize;
            }
            set
            {
                Setting.FontSize = value;
            }
        }
        #endregion

        #region IconFontFamily
        public FontFamily IconFontFamily
        {
            get
            {
                return Setting.IconFontFamily;
            }
            set
            {
                Setting.IconFontFamily = value;
            }
        }
        #endregion

        #region IconFontSize
        public double IconFontSize
        {
            get
            {
                return Setting.IconFontSize;
            }
            set
            {
                Setting.IconFontSize = value;
            }
        }
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get
            {
                return Setting.AnimationDuration;
            }
            set
            {
                Setting.AnimationDuration = value;
            }
        }
        #endregion

        #region AnimationDuration
        public Collection<ApplicationTheme> Themes
        {
            get
            {
                return Setting.Themes;
            }
            set
            {
                Setting.Themes = value;
            }
        }
        #endregion

        #endregion

        #region Methods
        public static void ChangeTheme(string key)
        {
            var targetTheme = Setting.Themes.First(x => x.Key == key);
            var themeResourceDictionaries = Setting.Themes.Select(x => x.ResourceDictionary).ToList();

            var index = 0;
            for (var i = 0; i < Application.Current.Resources.MergedDictionaries.Count; i++)
            {
                var dictionary = Application.Current.Resources.MergedDictionaries[i];
                if (string.IsNullOrEmpty(dictionary.Source?.OriginalString))
                {
                    continue;
                }
                if (themeResourceDictionaries.Contains(dictionary.Source.OriginalString))
                {
                    Application.Current.Resources.MergedDictionaries.Remove(dictionary);
                    index = i;
                }
            }

            var resourceDictionary = new ResourceDictionary()
            {
                Source = new Uri(targetTheme.ResourceDictionary, UriKind.RelativeOrAbsolute),
            };
            Application.Current.Resources.MergedDictionaries.Insert(index, resourceDictionary);
        }
        #endregion
    }

}
