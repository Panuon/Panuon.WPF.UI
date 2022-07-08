using Panuon.WPF.UI.Configurations;
using Panuon.WPF.UI.Internal.Utils;
using System.Windows;

namespace Panuon.WPF.UI
{
    public class MessageBoxXSettings
    {
        #region Static Properties
        public static MessageBoxXSetting Setting { get; } = new MessageBoxXSetting()
        {
            YesButtonContent = LocalizationUtil.Yes,
            NoButtonContent = LocalizationUtil.No,
            CancelButtonContent = LocalizationUtil.Cancel,
            OKButtonContent = LocalizationUtil.OK,
        };
        #endregion

        #region Properties

        #region InverseButtonsSequence
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

        #region InverseButtonsSequence
        public bool InverseButtonsSequence
        {
            get
            {
                return Setting.InverseButtonsSequence;
            }
            set
            {
                Setting.InverseButtonsSequence = value;
            }
        }
        #endregion

        #region ButtonStyle
        public Style ButtonStyle
        {
            get
            {
                return Setting.ButtonStyle;
            }
            set
            {
                Setting.ButtonStyle = value;
            }
        }
        #endregion

        #region WindowXStyle
        public Style WindowXStyle
        {
            get
            {
                return Setting.WindowXStyle;
            }
            set
            {
                Setting.WindowXStyle = value;
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

        #region OKButtonContent
        public object OKButtonContent
        {
            get
            {
                return Setting.OKButtonContent;
            }
            set
            {
                Setting.OKButtonContent = value;
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

        #region YesButtonContent
        public object YesButtonContent
        {
            get
            {
                return Setting.YesButtonContent;
            }
            set
            {
                Setting.YesButtonContent = value;
            }
        }
        #endregion

        #region NoButtonContent
        public object NoButtonContent
        {
            get
            {
                return Setting.NoButtonContent;
            }
            set
            {
                Setting.NoButtonContent = value;
            }
        }
        #endregion

        #endregion

    }

}
