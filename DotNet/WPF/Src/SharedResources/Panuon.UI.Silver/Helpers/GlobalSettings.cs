using Panuon.UI.Silver.Configurations;
using System;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class GlobalSettings
    {
        #region Static Properties
        public static GlobalSetting Setting { get; } = new GlobalSetting();
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

        #endregion
    }

}
