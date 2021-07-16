using Panuon.UI.Core;
using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class PasswordBoxHelper
    {
        #region Properties

        #region Password
        public static string GetPassword(PasswordBox passwordBox)
        {
            return (string)passwordBox.GetValue(PasswordProperty);
        }

        public static void SetPassword(PasswordBox passwordBox, string value)
        {
            passwordBox.SetValue(PasswordProperty, value);
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordBoxHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnPasswordChanged));
        #endregion

        #region PasswordHook
        public static bool GetPasswordHook(PasswordBox passwordBox)
        {
            return (bool)passwordBox.GetValue(PasswordHookProperty);
        }

        public static void SetPasswordHook(PasswordBox passwordBox, bool value)
        {
            passwordBox.SetValue(PasswordHookProperty, value);
        }

        public static readonly DependencyProperty PasswordHookProperty =
            DependencyProperty.RegisterAttached("PasswordHook", typeof(bool), typeof(PasswordBoxHelper), new PropertyMetadata(OnPasswordHookChanged));
        #endregion

        #region Icon
        public static object GetIcon(PasswordBox passwordBox)
        {
            return (object)passwordBox.GetValue(IconProperty);
        }

        public static void SetIcon(PasswordBox passwordBox, object value)
        {
            passwordBox.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(PasswordBoxHelper));
        #endregion

        #region Watermark
        public static string GetWatermark(PasswordBox passwordBox)
        {
            return (string)passwordBox.GetValue(WatermarkProperty);
        }

        public static void SetWatermark(PasswordBox passwordBox, string value)
        {
            passwordBox.SetValue(WatermarkProperty, value);
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.RegisterAttached("Watermark", typeof(string), typeof(PasswordBoxHelper));
        #endregion

        #region WatermarkBrush
        public static Brush GetWatermarkBrush(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(WatermarkBrushProperty);
        }

        public static void SetWatermarkBrush(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(WatermarkBrushProperty, value);
        }

        public static readonly DependencyProperty WatermarkBrushProperty =
            VisualStateHelper.WatermarkBrushProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(PasswordBox passwordBox)
        {
            return (CornerRadius)passwordBox.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(PasswordBox passwordBox, CornerRadius value)
        {
            passwordBox.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(PasswordBoxHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(PasswordBox passwordBox)
        {
            return (Color?)passwordBox.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(PasswordBox passwordBox, Color? value)
        {
            passwordBox.SetValue(ShadowColorProperty, value);
        }
        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region FocusedShadowColor
        public static Color? GetFocusedShadowColor(PasswordBox passwordBox)
        {
            return (Color?)passwordBox.GetValue(FocusedShadowColorProperty);
        }

        public static void SetFocusedShadowColor(PasswordBox passwordBox, Color? value)
        {
            passwordBox.SetValue(FocusedShadowColorProperty, value);
        }
        public static readonly DependencyProperty FocusedShadowColorProperty =
            VisualStateHelper.FocusedShadowColorProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region FocusedBackground
        public static Brush GetFocusedBackground(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(FocusedBackgroundProperty);
        }

        public static void SetFocusedBackground(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(FocusedBackgroundProperty, value);
        }

        public static readonly DependencyProperty FocusedBackgroundProperty =
            VisualStateHelper.FocusedBackgroundProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region FocusedForeground
        public static Brush GetFocusedForeground(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(FocusedForegroundProperty);
        }

        public static void SetFocusedForeground(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(FocusedForegroundProperty, value);
        }

        public static readonly DependencyProperty FocusedForegroundProperty =
            VisualStateHelper.FocusedForegroundProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region FocusedBorderBrush
        public static Brush GetFocusedBorderBrush(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(FocusedBorderBrushProperty);
        }

        public static void SetFocusedBorderBrush(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(FocusedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            VisualStateHelper.FocusedBorderBrushProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region FocusedWatermarkBrush
        public static Brush GetFocusedWatermarkBrush(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(FocusedWatermarkBrushProperty);
        }

        public static void SetFocusedWatermarkBrush(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(FocusedWatermarkBrushProperty, value);
        }

        public static readonly DependencyProperty FocusedWatermarkBrushProperty =
            VisualStateHelper.FocusedWatermarkBrushProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region ClearButtonVisibility
        public static AuxiliaryButtonVisibility GetClearButtonVisibility(PasswordBox passwordBox)
        {
            return (AuxiliaryButtonVisibility)passwordBox.GetValue(ClearButtonVisibilityProperty);
        }

        public static void SetClearButtonVisibility(PasswordBox passwordBox, AuxiliaryButtonVisibility value)
        {
            passwordBox.SetValue(ClearButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("ClearButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(PasswordBoxHelper));
        #endregion

        #region ClearButtonStyle
        public static Style GetClearButtonStyle(PasswordBox passwordBox)
        {
            return (Style)passwordBox.GetValue(ClearButtonStyleProperty);
        }

        public static void SetClearButtonStyle(PasswordBox passwordBox, Style value)
        {
            passwordBox.SetValue(ClearButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ClearButtonStyleProperty =
            DependencyProperty.RegisterAttached("ClearButtonStyle", typeof(Style), typeof(PasswordBoxHelper));
        #endregion

        #endregion

        #region Commands

        #region ClearCommand
        public static ICommand GetClearCommand(UIElement element)
        {
            return (ICommand)element.GetValue(ClearCommandProperty);
        }

        public static readonly DependencyProperty ClearCommandProperty =
            DependencyProperty.RegisterAttached("ClearCommand", typeof(ICommand), typeof(PasswordBoxHelper), new PropertyMetadata(new RelayCommand<PasswordBox>(OnClearCommandExecute)));
        #endregion

        #endregion

        #region Event Handler
        private static void OnClearCommandExecute(PasswordBox passwordBox)
        {
            passwordBox.Password = null;
            passwordBox.Focus();
        }

        private static void OnPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var passwordBox = d as PasswordBox;
            if (GetPasswordHook(passwordBox))
            {
                var newPassword = (string)e.NewValue;
                if (newPassword != passwordBox.Password)
                {
                    passwordBox.Password = newPassword;
                }
            }
        }

        private static void OnPasswordHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var passwordBox = (PasswordBox)d;
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            if ((bool)e.NewValue)
            {
                var newPassword = GetPassword(passwordBox);
                if (newPassword != passwordBox.Password)
                {
                    passwordBox.Password = newPassword;
                }
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
                
            }
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;
            SetPassword(passwordBox, passwordBox.Password);
        }
        #endregion

    }
}
