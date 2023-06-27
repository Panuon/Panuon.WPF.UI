using Panuon.WPF;
using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class PasswordBoxHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ClearButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(PasswordBoxHelper), nameof(ClearButtonStyleKey));

        public static ComponentResourceKey PlainButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(PasswordBoxHelper), nameof(PlainButtonStyleKey));
        #endregion

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
            DependencyProperty.RegisterAttached(
                "Password",
                typeof(string),
                typeof(PasswordBoxHelper),
                new FrameworkPropertyMetadata(
                    null,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    OnPasswordChanged
                )
            );
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
            DependencyProperty.RegisterAttached(
                "PasswordHook",
                typeof(bool),
                typeof(PasswordBoxHelper),
                new PropertyMetadata(OnPasswordHookChanged)
            );
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
        public static object GetWatermark(PasswordBox passwordBox)
        {
            return (object)passwordBox.GetValue(WatermarkProperty);
        }

        public static void SetWatermark(PasswordBox passwordBox, object value)
        {
            passwordBox.SetValue(WatermarkProperty, value);
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.RegisterAttached(
                "Watermark",
                typeof(object),
                typeof(PasswordBoxHelper)
            );
        #endregion

        #region WatermarkForeground
        public static Brush GetWatermarkForeground(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(WatermarkForegroundProperty);
        }

        public static void SetWatermarkForeground(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(WatermarkForegroundProperty, value);
        }

        public static readonly DependencyProperty WatermarkForegroundProperty =
            VisualStateHelper.WatermarkForegroundProperty.AddOwner(typeof(PasswordBoxHelper));
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
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(PasswordBoxHelper));
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

        #region HoverBorderThickness
        public static Thickness? GetHoverBorderThickness(PasswordBox passwordBox)
        {
            return (Thickness)passwordBox.GetValue(HoverBorderThicknessProperty);
        }

        public static void SetHoverBorderThickness(PasswordBox passwordBox, Thickness? value)
        {
            passwordBox.SetValue(HoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region HoverCornerRadius
        public static CornerRadius? GetHoverCornerRadius(PasswordBox passwordBox)
        {
            return (CornerRadius)passwordBox.GetValue(HoverCornerRadiusProperty);
        }

        public static void SetHoverCornerRadius(PasswordBox passwordBox, CornerRadius? value)
        {
            passwordBox.SetValue(HoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region HoverShadowColor
        public static Color? GetHoverShadowColor(PasswordBox passwordBox)
        {
            return (Color?)passwordBox.GetValue(HoverShadowColorProperty);
        }

        public static void SetHoverShadowColor(PasswordBox passwordBox, Color? value)
        {
            passwordBox.SetValue(HoverShadowColorProperty, value);
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(PasswordBoxHelper));
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

        #region FocusedBorderThickness
        public static Thickness? GetFocusedBorderThickness(PasswordBox passwordBox)
        {
            return (Thickness?)passwordBox.GetValue(FocusedBorderThicknessProperty);
        }

        public static void SetFocusedBorderThickness(PasswordBox passwordBox, Thickness? value)
        {
            passwordBox.SetValue(FocusedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty FocusedBorderThicknessProperty =
            VisualStateHelper.FocusedBorderThicknessProperty.AddOwner(typeof(PasswordBoxHelper));
        #endregion

        #region FocusedCornerRadius
        public static CornerRadius? GetFocusedCornerRadius(PasswordBox passwordBox)
        {
            return (CornerRadius)passwordBox.GetValue(FocusedCornerRadiusProperty);
        }

        public static void SetFocusedCornerRadius(PasswordBox passwordBox, CornerRadius? value)
        {
            passwordBox.SetValue(FocusedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty FocusedCornerRadiusProperty =
            VisualStateHelper.FocusedCornerRadiusProperty.AddOwner(typeof(PasswordBoxHelper));
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

        #region FocusedWatermarkForeground
        public static Brush GetFocusedWatermarkForeground(PasswordBox passwordBox)
        {
            return (Brush)passwordBox.GetValue(FocusedWatermarkForegroundProperty);
        }

        public static void SetFocusedWatermarkForeground(PasswordBox passwordBox, Brush value)
        {
            passwordBox.SetValue(FocusedWatermarkForegroundProperty, value);
        }

        public static readonly DependencyProperty FocusedWatermarkForegroundProperty =
            VisualStateHelper.FocusedWatermarkForegroundProperty.AddOwner(
                typeof(PasswordBoxHelper)
            );
        #endregion

        #region ClearButtonVisibility
        public static AuxiliaryButtonVisibility GetClearButtonVisibility(PasswordBox passwordBox)
        {
            return (AuxiliaryButtonVisibility)passwordBox.GetValue(ClearButtonVisibilityProperty);
        }

        public static void SetClearButtonVisibility(
            PasswordBox passwordBox,
            AuxiliaryButtonVisibility value
        )
        {
            passwordBox.SetValue(ClearButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.RegisterAttached(
                "ClearButtonVisibility",
                typeof(AuxiliaryButtonVisibility),
                typeof(PasswordBoxHelper)
            );
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
            DependencyProperty.RegisterAttached(
                "ClearButtonStyle",
                typeof(Style),
                typeof(PasswordBoxHelper)
            );
        #endregion

        #region PlainButtonVisibility
        public static AuxiliaryButtonVisibility GetPlainButtonVisibility(PasswordBox passwordBox)
        {
            return (AuxiliaryButtonVisibility)passwordBox.GetValue(PlainButtonVisibilityProperty);
        }

        public static void SetPlainButtonVisibility(
            PasswordBox passwordBox,
            AuxiliaryButtonVisibility value
        )
        {
            passwordBox.SetValue(PlainButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty PlainButtonVisibilityProperty =
            DependencyProperty.RegisterAttached(
                "PlainButtonVisibility",
                typeof(AuxiliaryButtonVisibility),
                typeof(PasswordBoxHelper)
            );
        #endregion

        #region PlainButtonStyle
        public static Style GetPlainButtonStyle(PasswordBox passwordBox)
        {
            return (Style)passwordBox.GetValue(PlainButtonStyleProperty);
        }

        public static void SetPlainButtonStyle(PasswordBox passwordBox, Style value)
        {
            passwordBox.SetValue(PlainButtonStyleProperty, value);
        }

        public static readonly DependencyProperty PlainButtonStyleProperty =
            DependencyProperty.RegisterAttached(
                "PlainButtonStyle",
                typeof(Style),
                typeof(PasswordBoxHelper)
            );
        #endregion

        #region SelectAllOnFocus
        public static bool GetSelectAllOnFocus(PasswordBox PasswordBox)
        {
            return (bool)PasswordBox.GetValue(SelectAllOnFocusProperty);
        }

        public static void SetSelectAllOnFocus(PasswordBox PasswordBox, bool value)
        {
            PasswordBox.SetValue(SelectAllOnFocusProperty, value);
        }

        public static readonly DependencyProperty SelectAllOnFocusProperty =
            DependencyProperty.RegisterAttached(
                "SelectAllOnFocus",
                typeof(bool),
                typeof(PasswordBoxHelper),
                new PropertyMetadata(OnSelectAllOnFocusChanged)
            );
        #endregion

        #region IsToggle

        public static bool GetPlainButtonIsToggle(PasswordBox PasswordBox)
        {
            return (bool)PasswordBox.GetValue(PlainButtonIsToggleProperty);
        }

        public static void SetPlainButtonIsToggle(PasswordBox PasswordBox, bool value)
        {
            PasswordBox.SetValue(PlainButtonIsToggleProperty, value);
        }

        public static readonly DependencyProperty PlainButtonIsToggleProperty =
            DependencyProperty.RegisterAttached(
                "PlainButtonIsToggle",
                typeof(bool),
                typeof(PasswordBoxHelper)
            );
        #endregion
        #endregion

        #region Commands

        #region ClearCommand
        public static ICommand GetClearCommand(UIElement element)
        {
            return (ICommand)element.GetValue(ClearCommandProperty);
        }

        public static readonly DependencyProperty ClearCommandProperty =
            DependencyProperty.RegisterAttached(
                "ClearCommand",
                typeof(ICommand),
                typeof(PasswordBoxHelper),
                new PropertyMetadata(new RelayCommand<PasswordBox>(OnClearCommandExecute))
            );
        #endregion

        #endregion

        #region Event Handler
        private static void OnClearCommandExecute(PasswordBox passwordBox)
        {
            passwordBox.Password = null;
            passwordBox.Focus();
        }

        private static void OnPasswordChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e
        )
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

        private static void OnPasswordHookChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e
        )
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

        private static void OnSelectAllOnFocusChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e
        )
        {
            var passwordBox = (PasswordBox)d;
            passwordBox.PreviewMouseLeftButtonDown -= PasswordBox_PreviewMouseLeftButtonDown;
            passwordBox.GotKeyboardFocus -= PasswordBox_SelectAll;
            passwordBox.MouseDoubleClick -= PasswordBox_SelectAll;

            if ((bool)e.NewValue)
            {
                passwordBox.PreviewMouseLeftButtonDown += PasswordBox_PreviewMouseLeftButtonDown;
                passwordBox.GotKeyboardFocus += PasswordBox_SelectAll;
                passwordBox.MouseDoubleClick += PasswordBox_SelectAll;
            }
        }

        private static void PasswordBox_PreviewMouseLeftButtonDown(
            object sender,
            MouseButtonEventArgs e
        )
        {
            var parent = e.OriginalSource as DependencyObject;
            while (parent != null && !(parent is PasswordBox))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            if (parent != null)
            {
                var passwordBox = (PasswordBox)parent;
                if (!passwordBox.IsKeyboardFocusWithin)
                {
                    passwordBox.Focus();
                    e.Handled = true;
                }
            }
        }

        private static void PasswordBox_SelectAll(object sender, RoutedEventArgs e)
        {
            var passwordBox = e.OriginalSource as PasswordBox;
            if (passwordBox != null)
            {
                passwordBox.SelectAll();
            }
        }

        #endregion
    }
}
