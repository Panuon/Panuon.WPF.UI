using Panuon.WPF;
using Panuon.WPF.UI.Internal;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class TextBoxHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ClearButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(TextBoxHelper), nameof(ClearButtonStyleKey));
        #endregion

        #region Properties

        #region Icon
        public static object GetIcon(TextBox textBox)
        {
            return (object)textBox.GetValue(IconProperty);
        }

        public static void SetIcon(TextBox textBox, object value)
        {
            textBox.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(TextBoxHelper));
        #endregion

        #region Watermark
        public static object GetWatermark(TextBox textBox)
        {
            return (object)textBox.GetValue(WatermarkProperty);
        }

        public static void SetWatermark(TextBox textBox, object value)
        {
            textBox.SetValue(WatermarkProperty, value);
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.RegisterAttached("Watermark", typeof(object), typeof(TextBoxHelper));
        #endregion

        #region WatermarkForeground
        public static Brush GetWatermarkForeground(TextBox textBox)
        {
            return (Brush)textBox.GetValue(WatermarkForegroundProperty);
        }

        public static void SetWatermarkForeground(TextBox textBox, Brush value)
        {
            textBox.SetValue(WatermarkForegroundProperty, value);
        }

        public static readonly DependencyProperty WatermarkForegroundProperty =
            VisualStateHelper.WatermarkForegroundProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(TextBox textBox)
        {
            return (CornerRadius)textBox.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(TextBox textBox, CornerRadius value)
        {
            textBox.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(TextBox textBox)
        {
            return (Color?)textBox.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(TextBox textBox, Color? value)
        {
            textBox.SetValue(ShadowColorProperty, value);
        }
        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(TextBox textBox)
        {
            return (Brush)textBox.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(TextBox textBox, Brush value)
        {
            textBox.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(TextBox textBox)
        {
            return (Brush)textBox.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(TextBox textBox, Brush value)
        {
            textBox.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(TextBox textBox)
        {
            return (Brush)textBox.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(TextBox textBox, Brush value)
        {
            textBox.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region HoverBorderThickness
        public static Thickness? GetHoverBorderThickness(TextBox textBox)
        {
            return (Thickness)textBox.GetValue(HoverBorderThicknessProperty);
        }

        public static void SetHoverBorderThickness(TextBox textBox, Thickness? value)
        {
            textBox.SetValue(HoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region HoverCornerRadius
        public static CornerRadius? GetHoverCornerRadius(TextBox textBox)
        {
            return (CornerRadius)textBox.GetValue(HoverCornerRadiusProperty);
        }

        public static void SetHoverCornerRadius(TextBox textBox, CornerRadius? value)
        {
            textBox.SetValue(HoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region HoverShadowColor
        public static Color? GetHoverShadowColor(TextBox textBox)
        {
            return (Color?)textBox.GetValue(HoverShadowColorProperty);
        }

        public static void SetHoverShadowColor(TextBox textBox, Color? value)
        {
            textBox.SetValue(HoverShadowColorProperty, value);
        }
        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region FocusedBackground
        public static Brush GetFocusedBackground(TextBox textBox)
        {
            return (Brush)textBox.GetValue(FocusedBackgroundProperty);
        }

        public static void SetFocusedBackground(TextBox textBox, Brush value)
        {
            textBox.SetValue(FocusedBackgroundProperty, value);
        }

        public static readonly DependencyProperty FocusedBackgroundProperty =
            VisualStateHelper.FocusedBackgroundProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region FocusedForeground
        public static Brush GetFocusedForeground(TextBox textBox)
        {
            return (Brush)textBox.GetValue(FocusedForegroundProperty);
        }

        public static void SetFocusedForeground(TextBox textBox, Brush value)
        {
            textBox.SetValue(FocusedForegroundProperty, value);
        }

        public static readonly DependencyProperty FocusedForegroundProperty =
            VisualStateHelper.FocusedForegroundProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region FocusedBorderBrush
        public static Brush GetFocusedBorderBrush(TextBox textBox)
        {
            return (Brush)textBox.GetValue(FocusedBorderBrushProperty);
        }

        public static void SetFocusedBorderBrush(TextBox textBox, Brush value)
        {
            textBox.SetValue(FocusedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            VisualStateHelper.FocusedBorderBrushProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region FocusedBorderThickness
        public static Thickness? GetFocusedBorderThickness(TextBox textBox)
        {
            return (Thickness?)textBox.GetValue(FocusedBorderThicknessProperty);
        }

        public static void SetFocusedBorderThickness(TextBox textBox, Thickness? value)
        {
            textBox.SetValue(FocusedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty FocusedBorderThicknessProperty =
            VisualStateHelper.FocusedBorderThicknessProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region FocusedCornerRadius
        public static CornerRadius? GetFocusedCornerRadius(TextBox textBox)
        {
            return (CornerRadius)textBox.GetValue(FocusedCornerRadiusProperty);
        }

        public static void SetFocusedCornerRadius(TextBox textBox, CornerRadius? value)
        {
            textBox.SetValue(FocusedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty FocusedCornerRadiusProperty =
            VisualStateHelper.FocusedCornerRadiusProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region FocusedShadowColor
        public static Color? GetFocusedShadowColor(TextBox textBox)
        {
            return (Color?)textBox.GetValue(FocusedShadowColorProperty);
        }

        public static void SetFocusedShadowColor(TextBox textBox, Color? value)
        {
            textBox.SetValue(FocusedShadowColorProperty, value);
        }
        public static readonly DependencyProperty FocusedShadowColorProperty =
            VisualStateHelper.FocusedShadowColorProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region FocusedWatermarkForeground
        public static Brush GetFocusedWatermarkForeground(TextBox textBox)
        {
            return (Brush)textBox.GetValue(FocusedWatermarkForegroundProperty);
        }

        public static void SetFocusedWatermarkForeground(TextBox textBox, Brush value)
        {
            textBox.SetValue(FocusedWatermarkForegroundProperty, value);
        }

        public static readonly DependencyProperty FocusedWatermarkForegroundProperty =
            VisualStateHelper.FocusedWatermarkForegroundProperty.AddOwner(typeof(TextBoxHelper));
        #endregion

        #region ClearButtonVisibility
        public static AuxiliaryButtonVisibility GetClearButtonVisibility(TextBox textBox)
        {
            return (AuxiliaryButtonVisibility)textBox.GetValue(ClearButtonVisibilityProperty);
        }

        public static void SetClearButtonVisibility(TextBox textBox, AuxiliaryButtonVisibility value)
        {
            textBox.SetValue(ClearButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("ClearButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(TextBoxHelper));
        #endregion

        #region ClearButtonStyle
        public static Style GetClearButtonStyle(TextBox textBox)
        {
            return (Style)textBox.GetValue(ClearButtonStyleProperty);
        }

        public static void SetClearButtonStyle(TextBox textBox, Style value)
        {
            textBox.SetValue(ClearButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ClearButtonStyleProperty =
            DependencyProperty.RegisterAttached("ClearButtonStyle", typeof(Style), typeof(TextBoxHelper));
        #endregion
        
        #region SelectAllOnFocus
        public static bool GetSelectAllOnFocus(TextBox textBox)
        {
            return (bool)textBox.GetValue(SelectAllOnFocusProperty);
        }

        public static void SetSelectAllOnFocus(TextBox textBox, bool value)
        {
            textBox.SetValue(SelectAllOnFocusProperty, value);
        }

        public static readonly DependencyProperty SelectAllOnFocusProperty =
            DependencyProperty.RegisterAttached("SelectAllOnFocus", typeof(bool), typeof(TextBoxHelper));

        #endregion

        #region InputLimit
        public static InputLimits GetInputLimit(DependencyObject obj)
        {
            return (InputLimits)obj.GetValue(InputLimitProperty);
        }

        public static void SetInputLimit(DependencyObject obj, InputLimits value)
        {
            obj.SetValue(InputLimitProperty, value);
        }

        public static readonly DependencyProperty InputLimitProperty =
            DependencyProperty.RegisterAttached("InputLimit", typeof(InputLimits), typeof(TextBoxHelper), new PropertyMetadata(InputLimits.None));
        #endregion

        #endregion

        #region Internal Properties

        #region Hook
        public static bool GetHook(DependencyObject obj)
        {
            return (bool)obj.GetValue(HookProperty);
        }

        public static void SetHook(DependencyObject obj, bool value)
        {
            obj.SetValue(HookProperty, value);
        }

        public static readonly DependencyProperty HookProperty =
            DependencyProperty.RegisterAttached("Hook", typeof(bool), typeof(TextBoxHelper), new PropertyMetadata(OnHookChanged));
        #endregion

        #endregion

        #region Commands

        #region ClearCommand
        public static ICommand GetClearCommand(UIElement element)
        {
            return (ICommand)element.GetValue(ClearCommandProperty);
        }

        public static readonly DependencyProperty ClearCommandProperty =
            DependencyProperty.RegisterAttached("ClearCommand", typeof(ICommand), typeof(TextBoxHelper), new PropertyMetadata(new RelayCommand<TextBox>(OnClearCommandExecute)));
        #endregion

        #endregion

        #region Event Handler
        private static void OnClearCommandExecute(TextBox textBox)
        {
            textBox.Text = null;
            textBox.Focus();
        }

        private static void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null
                && GetSelectAllOnFocus(textBox))
            {
                var parent = e.OriginalSource as DependencyObject;
                while (parent != null
                    && !(parent is TextBox))
                {
                    parent = VisualTreeHelper.GetParent(parent);
                }

                if (parent != null)
                {
                    var parentTextBox = (TextBox)parent;
                    if (!parentTextBox.IsKeyboardFocusWithin)
                    {
                        parentTextBox.Focus();
                        e.Handled = true;
                    }
                }
            }
        }

        private static void TextBox_SelectAll(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null
                && GetSelectAllOnFocus(textBox))
            {
                textBox.SelectAll();
            }
        }

        private static void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            var inputLimit = GetInputLimit(textBox);
            if (inputLimit == InputLimits.None)
            {
                return;
            }
            var text = textBox.Text ?? "";

            foreach (var inputChar in e.Text)
            {
                if ((inputLimit.HasFlag(InputLimits.Digit)
                     && inputChar >= 48 && inputChar <= 57) ||
                   (inputLimit.HasFlag(InputLimits.Letters) || inputLimit.HasFlag(InputLimits.UpperCaseLetters)
                     && inputChar >= 97 && inputChar <= 122) ||
                   (inputLimit.HasFlag(InputLimits.Letters) || inputLimit.HasFlag(InputLimits.LowerCaseLetters)
                     && inputChar >= 65 && inputChar <= 90) ||
                   (inputLimit.HasFlag(InputLimits.Point)
                     && inputChar == '.' && !text.Contains(".")) ||
                   (inputLimit.HasFlag(InputLimits.MultiplePoints)
                     && inputChar == '.') ||
                   (inputLimit.HasFlag(InputLimits.At)
                     && inputChar == '@' && !text.Contains("@")) ||
                   (inputLimit.HasFlag(InputLimits.MultipleAts)
                     && inputChar == '@') ||
                    (inputLimit.HasFlag(InputLimits.Dash)
                     && inputChar == '-') ||
                    (inputLimit.HasFlag(InputLimits.Underline)
                     && inputChar == '_') ||
                    (inputLimit.HasFlag(InputLimits.Comma)
                     && inputChar == ',' && !text.Contains(",")) ||
                    (inputLimit.HasFlag(InputLimits.MultipleCommas)
                     && inputChar == ',') )
                {
                    text += inputChar;
                }
                else
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private static void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                var textBox = sender as TextBox;
                var inputLimit = GetInputLimit(textBox);
                if (inputLimit == InputLimits.None)
                {
                    return;
                }
                var text = textBox.Text ?? "";

                if (inputLimit.HasFlag(InputLimits.Space)
                       && !text.Contains(" "))
                {

                }
                else
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private static void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            var textBox = sender as TextBox;
            var inputLimit = GetInputLimit(textBox);
            if (inputLimit == InputLimits.None)
            {
                return;
            }

            if (!e.SourceDataObject.GetDataPresent(DataFormats.UnicodeText, true))
            {
                e.CancelCommand();
            }

            var pastingText = e.SourceDataObject.GetData(DataFormats.UnicodeText) as string;
            var text = textBox.Text ?? "";

            foreach (var inputChar in pastingText)
            {
                if ((inputLimit.HasFlag(InputLimits.Digit)
                     && inputChar >= 48 && inputChar <= 57) ||
                   (inputLimit.HasFlag(InputLimits.UpperCaseLetters)
                     && inputChar >= 97 && inputChar <= 122) ||
                   (inputLimit.HasFlag(InputLimits.LowerCaseLetters)
                     && inputChar >= 65 && inputChar <= 90) ||
                   (inputLimit.HasFlag(InputLimits.Point)
                     && inputChar == '.' && !text.Contains(".")) ||
                   (inputLimit.HasFlag(InputLimits.At)
                     && inputChar == '@' && !text.Contains("@")) ||
                   (inputLimit.HasFlag(InputLimits.MultiplePoints)
                     && inputChar == '.') ||
                   (inputLimit.HasFlag(InputLimits.MultipleAts)
                     && inputChar == '@'))
                {
                    text += inputChar;
                }
                else
                {
                    e.CancelCommand();
                    return;
                }
            }
        }

        private static void OnHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textBox = (TextBox)d;
            textBox.PreviewMouseLeftButtonDown -= TextBox_PreviewMouseLeftButtonDown;
            textBox.GotKeyboardFocus -= TextBox_SelectAll;
            textBox.MouseDoubleClick -= TextBox_SelectAll;
            textBox.PreviewTextInput -= TextBox_PreviewTextInput;
            textBox.PreviewKeyDown -= TextBox_PreviewKeyDown;
            DataObject.RemovePastingHandler(textBox, TextBox_Pasting);

            if ((bool)e.NewValue)
            {
                textBox.PreviewMouseLeftButtonDown += TextBox_PreviewMouseLeftButtonDown;
                textBox.GotKeyboardFocus += TextBox_SelectAll;
                textBox.MouseDoubleClick += TextBox_SelectAll;
                textBox.PreviewTextInput += TextBox_PreviewTextInput;
                textBox.PreviewKeyDown += TextBox_PreviewKeyDown;
                DataObject.AddPastingHandler(textBox, TextBox_Pasting);
            }
        }

        #endregion

    }
}
