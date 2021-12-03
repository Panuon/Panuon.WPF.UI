using Panuon.UI.Silver.Configurations;
using Panuon.UI.Silver.Internal.Models;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Controls
{
    class MessageBoxXWindow : WindowX
    {
        #region Fields
        private MessageBoxXSetting _setting;

        #endregion

        #region Ctor
        public MessageBoxXWindow(string message, string caption, MessageBoxButton button, MessageBoxIcon icon, DefaultButton defaultButton, Window owner, MessageBoxXSetting setting)
        {
            _setting = setting;

            WindowXModalDialog.SetButtons(this, button);
            WindowXModalDialog.SetDefaultButton(this, defaultButton);
            WindowXModalDialog.SetOKButtonContent(this, setting.OKButtonContent);
            WindowXModalDialog.SetCancelButtonContent(this, setting.CancelButtonContent);
            WindowXModalDialog.SetYesButtonContent(this, setting.YesButtonContent);
            WindowXModalDialog.SetNoButtonContent(this, setting.NoButtonContent);
            WindowXModalDialog.SetButtonStyle(this, setting.ButtonStyle);
            WindowXModalDialog.SetInverseButtonsSequence(this, setting.InverseButtonsSequence);

            Owner = owner;
            Title = caption ?? "";
            WindowStartupLocation = owner == null ? WindowStartupLocation.CenterScreen : WindowStartupLocation.CenterOwner;

            Style = setting.WindowXStyle;
            Content = new MessageBoxContent()
            {
                Message = message,
                Caption = caption,
                MessageBoxIcon = icon,
                ButtonStyle = setting.ButtonStyle,
            };
            ContentTemplate = setting.ContentTemplate;
        }
        #endregion
    }

}
