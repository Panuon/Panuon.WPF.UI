using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
using System;
using System.Windows;

namespace Panuon.WPF.UI
{
    public class NoticeBoxSettings
    {
        #region Ctor
        static NoticeBoxSettings()
        {
            Setting = new NoticeBoxSetting();
        }
        #endregion

        #region Static Properties
        public static NoticeBoxSetting Setting { get; }
        #endregion

        #region Properties

        #region Position
        public NoticeBoxPosition Position
        {
            get
            {
                return Setting.Position;
            }
            set
            {
                Setting.Position = value;
            }
        }
        #endregion

        #region CreateOnNewThread
        public bool CreateOnNewThread
        {
            get
            {
                return Setting.CreateOnNewThread;
            }
            set
            {
                Setting.CreateOnNewThread = value;
            }
        }
        #endregion

        #region NoticeBoxItemStyle
        public Style NoticeBoxItemStyle
        {
            get
            {
                return Setting.NoticeBoxItemStyle;
            }
            set
            {
                Setting.NoticeBoxItemStyle = value;
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
