using Panuon.UI.Silver.Configurations;
using System.Windows;

namespace Panuon.UI.Silver
{
    public class MessageBoxXSettings
    {
        #region Static Properties
        public static MessageBoxXSetting Setting { get; } = new MessageBoxXSetting();
        #endregion

        #region Properties

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
