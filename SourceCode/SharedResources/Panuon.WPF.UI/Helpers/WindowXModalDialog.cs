using Panuon.WPF.UI.Internal.Utils;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI
{
    public static class WindowXModalDialog
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ButtonStyle { get; } =
            new ComponentResourceKey(typeof(WindowXModalDialog), nameof(ButtonStyle));
        #endregion

        #region Properties

        #region Buttons
        public static MessageBoxButton? GetButtons(WindowX windowX)
        {
            return (MessageBoxButton?)windowX.GetValue(ButtonsProperty);
        }

        public static void SetButtons(WindowX windowX, MessageBoxButton? value)
        {
            windowX.SetValue(ButtonsProperty, value);
        }

        public static readonly DependencyProperty ButtonsProperty =
            DependencyProperty.RegisterAttached("Buttons", typeof(MessageBoxButton?), typeof(WindowXModalDialog));
        #endregion

        #region ButtonStyle
        public static Style GetButtonStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(ButtonStyleProperty);
        }

        public static void SetButtonStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(ButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ButtonStyleProperty =
            DependencyProperty.RegisterAttached("ButtonStyle", typeof(Style), typeof(WindowXModalDialog));
        #endregion

        #region DefaultButton
        public static DefaultButton GetDefaultButton(WindowX windowX)
        {
            return (DefaultButton)windowX.GetValue(DefaultButtonProperty);
        }

        public static void SetDefaultButton(WindowX windowX, DefaultButton value)
        {
            windowX.SetValue(DefaultButtonProperty, value);
        }

        public static readonly DependencyProperty DefaultButtonProperty =
            DependencyProperty.RegisterAttached("DefaultButton", typeof(DefaultButton), typeof(WindowXModalDialog));
        #endregion

        #region InverseButtonsSequence
        public static bool GetInverseButtonsSequence(WindowX windowX)
        {
            return (bool)windowX.GetValue(InverseButtonsSequenceProperty);
        }

        public static void SetInverseButtonsSequence(WindowX windowX, bool value)
        {
            windowX.SetValue(InverseButtonsSequenceProperty, value);
        }

        public static readonly DependencyProperty InverseButtonsSequenceProperty =
            DependencyProperty.RegisterAttached("InverseButtonsSequence", typeof(bool), typeof(WindowXModalDialog));
        #endregion

        #region ButtonPanelMargin
        public static Thickness GetButtonPanelMargin(WindowX windowX)
        {
            return (Thickness)windowX.GetValue(ButtonPanelMarginProperty);
        }

        public static void SetButtonPanelMargin(WindowX windowX, Thickness value)
        {
            windowX.SetValue(ButtonPanelMarginProperty, value);
        }

        public static readonly DependencyProperty ButtonPanelMarginProperty =
            DependencyProperty.RegisterAttached("ButtonPanelMargin", typeof(Thickness), typeof(WindowXModalDialog));
        #endregion

        #region ButtonPanelHorizontalAlignment
        public static HorizontalAlignment GetButtonPanelHorizontalAlignment(WindowX windowX)
        {
            return (HorizontalAlignment)windowX.GetValue(ButtonPanelHorizontalAlignmentProperty);
        }

        public static void SetButtonPanelHorizontalAlignment(WindowX windowX, HorizontalAlignment value)
        {
            windowX.SetValue(ButtonPanelHorizontalAlignmentProperty, value);
        }

        public static readonly DependencyProperty ButtonPanelHorizontalAlignmentProperty =
            DependencyProperty.RegisterAttached("ButtonPanelHorizontalAlignment", typeof(HorizontalAlignment), typeof(WindowXModalDialog));
        #endregion

        #region OKButtonContent
        public static object GetOKButtonContent(WindowX windowX)
        {
            return (object)windowX.GetValue(OKButtonContentProperty);
        }

        public static void SetOKButtonContent(WindowX windowX, object value)
        {
            windowX.SetValue(OKButtonContentProperty, value);
        }

        public static readonly DependencyProperty OKButtonContentProperty =
            DependencyProperty.RegisterAttached("OKButtonContent", typeof(object), typeof(WindowXModalDialog), new PropertyMetadata(LocalizationUtil.OK));
        #endregion

        #region YesButtonContent
        public static object GetYesButtonContent(WindowX windowX)
        {
            return (object)windowX.GetValue(YesButtonContentProperty);
        }

        public static void SetYesButtonContent(WindowX windowX, object value)
        {
            windowX.SetValue(YesButtonContentProperty, value);
        }

        public static readonly DependencyProperty YesButtonContentProperty =
            DependencyProperty.RegisterAttached("YesButtonContent", typeof(object), typeof(WindowXModalDialog), new PropertyMetadata(LocalizationUtil.Yes));
        #endregion

        #region NoButtonContent
        public static object GetNoButtonContent(WindowX windowX)
        {
            return (object)windowX.GetValue(NoButtonContentProperty);
        }

        public static void SetNoButtonContent(WindowX windowX, object value)
        {
            windowX.SetValue(NoButtonContentProperty, value);
        }

        public static readonly DependencyProperty NoButtonContentProperty =
            DependencyProperty.RegisterAttached("NoButtonContent", typeof(object), typeof(WindowXModalDialog), new PropertyMetadata(LocalizationUtil.No));
        #endregion

        #region CancelButtonContent
        public static object GetCancelButtonContent(WindowX windowX)
        {
            return (object)windowX.GetValue(CancelButtonContentProperty);
        }

        public static void SetCancelButtonContent(WindowX windowX, object value)
        {
            windowX.SetValue(CancelButtonContentProperty, value);
        }

        public static readonly DependencyProperty CancelButtonContentProperty =
            DependencyProperty.RegisterAttached("CancelButtonContent", typeof(object), typeof(WindowXModalDialog), new PropertyMetadata(LocalizationUtil.Cancel));
        #endregion

        #region DialogResult
        public static MessageBoxResult GetDialogResult(WindowX windowX)
        {
            return (MessageBoxResult)windowX.GetValue(DialogResultProperty);
        }

        public static void SetDialogResult(WindowX windowX, MessageBoxResult value)
        {
            windowX.SetValue(DialogResultProperty, value);
        }

        public static readonly DependencyProperty DialogResultProperty =
            DependencyProperty.RegisterAttached("DialogResult", typeof(MessageBoxResult), typeof(WindowXModalDialog));
        #endregion

        #endregion

        #region Methods
        public static Button GetOKButton(WindowX windowX)
        {
            return windowX.ModalOKButton;
        }

        public static Button GetCancelButton(WindowX windowX)
        {
            return windowX.ModalCancelButton;
        }

        public static Button GetYesButton(WindowX windowX)
        {
            return windowX.ModalYesButton;
        }

        public static Button GetNoButton(WindowX windowX)
        {
            return windowX.ModalNoButton;
        }
        #endregion

    }
}
