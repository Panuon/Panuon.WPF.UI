using Panuon.UI.Core;
using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class TextBoxHelper
    {
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
        public static string GetWatermark(TextBox textBox)
        {
            return (string)textBox.GetValue(WatermarkProperty);
        }

        public static void SetWatermark(TextBox textBox, string value)
        {
            textBox.SetValue(WatermarkProperty, value);
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.RegisterAttached("Watermark", typeof(string), typeof(TextBoxHelper));
        #endregion

        #region WatermarkBrush
        public static Brush GetWatermarkBrush(TextBox textBox)
        {
            return (Brush)textBox.GetValue(WatermarkBrushProperty);
        }

        public static void SetWatermarkBrush(TextBox textBox, Brush value)
        {
            textBox.SetValue(WatermarkBrushProperty, value);
        }

        public static readonly DependencyProperty WatermarkBrushProperty =
            VisualStateHelper.WatermarkBrushProperty.AddOwner(typeof(TextBoxHelper));
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
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(TextBoxHelper));
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

        #region FocusedWatermarkBrush
        public static Brush GetFocusedWatermarkBrush(TextBox textBox)
        {
            return (Brush)textBox.GetValue(FocusedWatermarkBrushProperty);
        }

        public static void SetFocusedWatermarkBrush(TextBox textBox, Brush value)
        {
            textBox.SetValue(FocusedWatermarkBrushProperty, value);
        }

        public static readonly DependencyProperty FocusedWatermarkBrushProperty =
            VisualStateHelper.FocusedWatermarkBrushProperty.AddOwner(typeof(TextBoxHelper));
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
        #endregion

    }
}
