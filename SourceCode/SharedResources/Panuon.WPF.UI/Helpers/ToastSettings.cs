using Panuon.WPF.UI.Configurations;
using System;
using System.Windows;

namespace Panuon.WPF.UI
{
    public class ToastSettings
    {
        #region Ctor
        static ToastSettings()
        {
            Setting = new ToastSetting();
        }
        #endregion

        #region Static Properties
        public static ToastSetting Setting { get; }
        #endregion

        #region Properties

        #region LabelStyle
        public Style LabelStyle
        {
            get
            {
                return Setting.LabelStyle;
            }
            set
            {
                Setting.LabelStyle = value;
            }
        }
        #endregion

        #region Spacing
        public double Spacing
        {
            get
            {
                return Setting.Spacing;
            }
            set
            {
                Setting.Spacing = value;
            }
        }
        #endregion

        #region ClearBeforeShow
        public bool ClearBeforeShow
        {
            get
            {
                return Setting.ClearBeforeShow;
            }
            set
            {
                Setting.ClearBeforeShow = value;
            }
        }
        #endregion

        #region DefaultPosition
        public ToastPosition DefaultPosition
        {
            get
            {
                return Setting.DefaultPosition;
            }
            set
            {
                Setting.DefaultPosition = value;
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

        #region AnimationEasing
        public AnimationEasing AnimationEasing
        {
            get
            {
                return Setting.AnimationEasing;
            }
            set
            {
                Setting.AnimationEasing = value;
            }
        }
        #endregion

        #endregion
    }
}
