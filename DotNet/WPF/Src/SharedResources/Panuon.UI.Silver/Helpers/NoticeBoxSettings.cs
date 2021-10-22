using Panuon.UI.Silver;
using Panuon.UI.Silver.Configurations;
using System;
using System.Windows;

namespace Panuon.UI.Silver
{
    public class NoticeBoxSettings
    {
        #region Static Properties
        public static NoticeBoxSetting Setting { get; } = new NoticeBoxSetting();
        #endregion

        #region Properties

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

        #region AnimationEase
        public AnimationEase AnimationEase
        {
            get
            {
                return Setting.AnimationEase;
            }
            set
            {
                Setting.AnimationEase = value;
            }
        }
        #endregion

        #endregion
    }
}
