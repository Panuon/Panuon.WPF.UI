using Panuon.UI.Silver.Configurations;
using Panuon.UI.Silver.Internal.Utils;
using System.Windows;

namespace Panuon.UI.Silver
{
    public class PendingBoxSettings
    {
        #region Static Properties
        public static PendingBoxSetting Setting { get; } = new PendingBoxSetting()
        {
            CancelButtonContent = LocalizationUtil.Cancel,
        };
        #endregion

        #region Properties

        #region InteropOwnersMask
        public bool InteropOwnersMask
        {
            get
            {
                return Setting.InteropOwnersMask;
            }
            set
            {
                Setting.InteropOwnersMask = value;
            }
        }
        #endregion

        #region CancelButtonContent
        public object CancelButtonContent
        {
            get
            {
                return Setting.CancelButtonContent;
            }
            set
            {
                Setting.CancelButtonContent = value;
            }
        }
        #endregion

        #region WindowStyle
        public Style WindowStyle
        {
            get
            {
                return Setting.WindowStyle;
            }
            set
            {
                Setting.WindowStyle = value;
            }
        }
        #endregion

        #region CancelButtonStyle
        public Style CancelButtonStyle
        {
            get
            {
                return Setting.CancelButtonStyle;
            }
            set
            {
                Setting.CancelButtonStyle = value;
            }
        }
        #endregion

        #region SpinnerStyle
        public Style SpinnerStyle
        {
            get
            {
                return Setting.SpinnerStyle;
            }
            set
            {
                Setting.SpinnerStyle = value;
            }
        }
        #endregion

        #region ContentTemplate
        public DataTemplate ContentTemplate
        {
            get
            {
                return Setting.ContentTemplate;
            }
            set
            {
                Setting.ContentTemplate = value;
            }
        }
        #endregion

        #endregion
    }
}
