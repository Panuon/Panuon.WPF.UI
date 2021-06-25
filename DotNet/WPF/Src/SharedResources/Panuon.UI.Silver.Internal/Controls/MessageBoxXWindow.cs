using Panuon.UI.Silver.Configurations;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Panuon.UI.Silver.Internal.Controls
{
    class MessageBoxXWindow : WindowX
    {
        #region Fields
        private const string OKButtonTemplateName = "PART_OKButton";

        private const string CancelButtonTemplateName = "PART_CancelButton";

        private const string YesButtonTemplateName = "PART_YesButton";

        private const string NoButtonTemplateName = "PART_NoButton";

        private const string StackPanelTemplateName = "PART_ButtonContainer";

        private Button _okButton;

        private Button _cancelButton;

        private Button _yesButton;

        private Button _noButton;

        private MessageBoxButton _messageBoxButton;

        private DefaultButton _defaultButton;

        private MessageBoxXSetting _setting;

        #endregion

        #region Ctor
        public MessageBoxXWindow(string message, string caption, MessageBoxButton button, MessageBoxIcon icon, DefaultButton defaultButton, Window owner, MessageBoxXSetting setting)
        {
            _setting = setting;
            _messageBoxButton = button;
            _defaultButton = defaultButton;

            Owner = owner;
            Title = caption ?? "";
            WindowStartupLocation = owner == null ? WindowStartupLocation.CenterScreen : WindowStartupLocation.CenterOwner;

            MessageBoxContent = new MessageBoxContent()
            {
                Message = message,
                Caption = caption,
                MessageBoxIcon = icon,
            };

            Style = setting.WindowXStyle;
            Content = MessageBoxContent;
            ContentTemplate = setting.ContentTemplate;
        }
        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                var stackPanel = FrameworkElementUtil.FindVisualChild<StackPanel>(this, StackPanelTemplateName);
                stackPanel.FlowDirection = _setting.InverseButtonsSequence ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;

                _okButton = FrameworkElementUtil.FindVisualChild<Button>(this, OKButtonTemplateName);
                if (_okButton == null)
                {
                    throw new Exception($"MessageBoxXSetting : Can not find Button named {OKButtonTemplateName} in ContentTemplate property.");
                }
                _cancelButton = FrameworkElementUtil.FindVisualChild<Button>(this, CancelButtonTemplateName);
                if (_cancelButton == null)
                {
                    throw new Exception($"MessageBoxXSetting : Can not find Button named {CancelButtonTemplateName} in ContentTemplate property.");
                }
                _yesButton = FrameworkElementUtil.FindVisualChild<Button>(this, YesButtonTemplateName);
                if (_yesButton == null)
                {
                    throw new Exception($"MessageBoxXSetting : Can not find Button named {YesButtonTemplateName} in ContentTemplate property.");
                }
                _noButton = FrameworkElementUtil.FindVisualChild<Button>(this, NoButtonTemplateName);
                if (_noButton == null)
                {
                    throw new Exception($"MessageBoxXSetting : Can not find Button named {NoButtonTemplateName} in ContentTemplate property.");
                }

                if (_setting.ButtonStyle != null)
                {
                    if (DependencyPropertyHelper.GetValueSource(_okButton, Button.StyleProperty).BaseValueSource == BaseValueSource.ImplicitStyleReference)
                    {
                        _okButton.Style = _setting.ButtonStyle;
                    }
                    if (DependencyPropertyHelper.GetValueSource(_cancelButton, Button.StyleProperty).BaseValueSource == BaseValueSource.ImplicitStyleReference)
                    {
                    _cancelButton.Style = _setting.ButtonStyle;
                    }
                    if (DependencyPropertyHelper.GetValueSource(_yesButton, Button.StyleProperty).BaseValueSource == BaseValueSource.ImplicitStyleReference)
                    {
                        _yesButton.Style = _setting.ButtonStyle;
                    }
                    if (DependencyPropertyHelper.GetValueSource(_noButton, Button.StyleProperty).BaseValueSource == BaseValueSource.ImplicitStyleReference)
                    {
                        _noButton.Style = _setting.ButtonStyle;
                    }
                }

                _okButton.Content = _setting.OKButtonContent;
                _cancelButton.Content = _setting.CancelButtonContent;
                _yesButton.Content = _setting.YesButtonContent;
                _noButton.Content = _setting.NoButtonContent;

                _okButton.Visibility = (_messageBoxButton == MessageBoxButton.OK || _messageBoxButton == MessageBoxButton.OKCancel) ? Visibility.Visible : Visibility.Collapsed;
                _cancelButton.Visibility = (_messageBoxButton == MessageBoxButton.OKCancel || _messageBoxButton == MessageBoxButton.YesNoCancel) ? Visibility.Visible : Visibility.Collapsed;
                _yesButton.Visibility = (_messageBoxButton == MessageBoxButton.YesNo || _messageBoxButton == MessageBoxButton.YesNoCancel) ? Visibility.Visible : Visibility.Collapsed;
                _noButton.Visibility = (_messageBoxButton == MessageBoxButton.YesNo || _messageBoxButton == MessageBoxButton.YesNoCancel) ? Visibility.Visible : Visibility.Collapsed;

                _okButton.IsDefault = (_defaultButton == DefaultButton.YesOK && _messageBoxButton == MessageBoxButton.OK);
                _cancelButton.IsDefault = (_defaultButton == DefaultButton.CancelNo) || (_defaultButton == DefaultButton.NoCancel && _messageBoxButton == MessageBoxButton.OKCancel);
                _yesButton.IsDefault = (_defaultButton == DefaultButton.YesOK);
                _noButton.IsDefault = (_defaultButton == DefaultButton.NoCancel) || (_defaultButton == DefaultButton.CancelNo && (_messageBoxButton == MessageBoxButton.YesNoCancel || _messageBoxButton == MessageBoxButton.OKCancel));

                _okButton.DataContext = "OK";
                _cancelButton.DataContext = "Cancel";
                _yesButton.DataContext = "Yes";
                _noButton.DataContext = "No";

                _okButton.Click += Button_Click;
                _cancelButton.Click += Button_Click;
                _yesButton.Click += Button_Click;
                _noButton.Click += Button_Click;

            }), DispatcherPriority.DataBind);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            switch (button.Name) 
            {
                case OKButtonTemplateName:
                    Result = MessageBoxResult.OK;
                    Close();
                    return;
                case CancelButtonTemplateName:
                    Result = MessageBoxResult.Cancel;
                    Close();
                    return;
                case YesButtonTemplateName:
                    Result = MessageBoxResult.Yes;
                    Close();
                    return;
                case NoButtonTemplateName:
                    Result = MessageBoxResult.No;
                    Close();
                    return;
            }

        }

        #endregion

        #region Properties

        #region MessageBoxContent
        public MessageBoxContent MessageBoxContent
        {
            get { return (MessageBoxContent)GetValue(MessageBoxContentProperty); }
            set { SetValue(MessageBoxContentProperty, value); }
        }

        public static readonly DependencyProperty MessageBoxContentProperty =
            DependencyProperty.Register("MessageBoxContent", typeof(MessageBoxContent), typeof(MessageBoxXWindow));
        #endregion

        #region Result
        public MessageBoxResult Result
        {
            get { return (MessageBoxResult)GetValue(ResultProperty); }
            set { SetValue(ResultProperty, value); }
        }

        public static readonly DependencyProperty ResultProperty =
            DependencyProperty.Register("Result", typeof(MessageBoxResult), typeof(MessageBoxXWindow));
        #endregion

        #endregion
    }

    class MessageBoxContent : DependencyObject
    {
        #region Message
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(MessageBoxContent));
        #endregion

        #region Caption
        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(MessageBoxContent));
        #endregion

        #region MessageBoxIcon
        public MessageBoxIcon MessageBoxIcon
        {
            get { return (MessageBoxIcon)GetValue(MessageBoxIconProperty); }
            set { SetValue(MessageBoxIconProperty, value); }
        }

        public static readonly DependencyProperty MessageBoxIconProperty =
            DependencyProperty.Register("MessageBoxIcon", typeof(MessageBoxIcon), typeof(MessageBoxXWindow));
        #endregion

    }
}
