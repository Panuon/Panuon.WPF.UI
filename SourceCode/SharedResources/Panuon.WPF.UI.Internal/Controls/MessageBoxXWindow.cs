using Panuon.WPF.UI.Configurations;
using Panuon.WPF.UI.Internal.Models;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal.Controls
{
    class MessageBoxXWindow 
        : WindowX
    {
        #region Fields
        private MessageBoxXSetting _setting;

        private Timer _timer;

        private bool _isStoped;

        private int _countdown;

        private Button _defaultButton;

        private object _defaultContent;
        #endregion

        #region Ctor
        public MessageBoxXWindow(string message,
            string caption,
            MessageBoxButton button,
            MessageBoxIcon icon,
            DefaultButton defaultButton,
            Window owner,
            MessageBoxXSetting setting,
            int? countdown)
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
            InteropOwnersMask = setting.InteropOwnersMask;
            if (owner == null)
            {
                Topmost = true;
            }
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

            if (countdown != null)
            {
                _countdown = (int)countdown;
                if (_countdown <= 0)
                {
                    _countdown = 0;
                }
                _countdown++;

                _timer = new Timer(OnTimerTicked, null, Timeout.Infinite, Timeout.Infinite);
            }
        }

        #endregion

        #region Overrides
        protected override void OnClosed(EventArgs e)
        {
            _isStoped = true;
            base.OnClosed(e);
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            if(_timer != null)
            {
                _timer.Change(0, Timeout.Infinite);
            }
        }
        #endregion

        #region Event Handlers
        private void OnTimerTicked(object state)
        {
            _countdown--;
            Dispatcher.Invoke(new Action(() =>
            {
                if (_countdown <= 0)
                {
                    TriggerDefaultButton();
                    _isStoped = true;
                }
                else
                {

                    if (_defaultButton == null)
                    {
                        _defaultButton = GetDefaultButton();
                        if (_defaultButton == null)
                        {
                            throw new Exception("When the countdown parameter is used in MessageBoxX, the defaultButton parameter must be set. ");
                        }
                        _defaultContent = _defaultButton.Content;
                    }
                    if (_defaultContent is string stringContent)
                    {
                        _defaultButton.Content = $"{stringContent} ({_countdown})";
                    }
                }
            }));
            if (!_isStoped)
            {
                _timer.Change(1000, Timeout.Infinite);
            }
        }

        private void TriggerDefaultButton()
        {
            try
            {
                if (ModalOKButton.IsDefault)
                {
                    DialogResult = true;
                }
                if (ModalCancelButton.IsDefault)
                {
                    DialogResult = null;
                }
                if (ModalYesButton.IsDefault)
                {
                    DialogResult = true;
                }
                if (ModalNoButton.IsDefault)
                {
                    DialogResult = false;
                }
            }
            catch { }
        }

        private Button GetDefaultButton()
        {
            if (ModalOKButton.IsDefault)
            {
                return ModalOKButton;
            }
            if (ModalCancelButton.IsDefault)
            {
                return ModalCancelButton;
            }
            if (ModalYesButton.IsDefault)
            {
                return ModalYesButton;
            }
            if (ModalNoButton.IsDefault)
            {
                return ModalNoButton;
            }
            return null;
        }
        #endregion
    }

}
