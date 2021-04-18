using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class RadioButtonHelper
    {
        #region BoxRadius
        public static double GetBoxRadius(RadioButton radioButton)
        {
            return (double)radioButton.GetValue(BoxRadiusProperty);
        }

        public static void SetBoxRadius(RadioButton radioButton, double value)
        {
            radioButton.SetValue(BoxRadiusProperty, value);
        }

        public static readonly DependencyProperty BoxRadiusProperty =
            DependencyProperty.RegisterAttached("BoxRadius", typeof(double), typeof(RadioButtonHelper), new PropertyMetadata(8.0));
        #endregion

        #region ToggleBrush
        public static Brush GetToggleBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(ToggleBrushProperty);
        }

        public static void SetToggleBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(ToggleBrushProperty, value);
        }

        public static readonly DependencyProperty ToggleBrushProperty =
            DependencyProperty.RegisterAttached("ToggleBrush", typeof(Brush), typeof(RadioButtonHelper), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region ContentPlacement
        public static ContentPlacement GetContentPlacement(RadioButton radioButton)
        {
            return (ContentPlacement)radioButton.GetValue(ContentPlacementProperty);
        }

        public static void SetContentPlacement(RadioButton radioButton, ContentPlacement value)
        {
            radioButton.SetValue(ContentPlacementProperty, value);
        }

        public static readonly DependencyProperty ContentPlacementProperty =
            DependencyProperty.RegisterAttached("ContentPlacement", typeof(ContentPlacement), typeof(RadioButtonHelper), new PropertyMetadata(ContentPlacement.Right));
        #endregion

        #region ToggleRadius
        public static double GetToggleRadius(RadioButton radioButton)
        {
            return (double)radioButton.GetValue(ToggleRadiusProperty);
        }

        public static void SetToggleRadius(RadioButton radioButton, double value)
        {
            radioButton.SetValue(ToggleRadiusProperty, value);
        }

        public static readonly DependencyProperty ToggleRadiusProperty =
            DependencyProperty.RegisterAttached("ToggleRadius", typeof(double), typeof(RadioButtonHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(RadioButtonHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(RadioButtonHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(RadioButtonHelper));
        #endregion

        #region HoverToggleBrush
        public static Brush GetHoverToggleBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(HoverToggleBrushProperty);
        }

        public static void SetHoverToggleBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(HoverToggleBrushProperty, value);
        }

        public static readonly DependencyProperty HoverToggleBrushProperty =
            VisualStateHelper.HoverToggleBrushProperty.AddOwner(typeof(RadioButtonHelper));
        #endregion

        #region CheckedForeground
        public static Brush GetCheckedForeground(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(CheckedForegroundProperty);
        }

        public static void SetCheckedForeground(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(CheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.RegisterAttached("CheckedForeground", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region CheckedBackground
        public static Brush GetCheckedBackground(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(CheckedBackgroundProperty);
        }

        public static void SetCheckedBackground(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(CheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("CheckedBackground", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region CheckedBorderBrush
        public static Brush GetCheckedBorderBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(CheckedBorderBrushProperty);
        }

        public static void SetCheckedBorderBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(CheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("CheckedBorderBrush", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region CheckedBorderThickness
        public static Thickness? GetCheckedBorderThickness(RadioButton radioButton)
        {
            return (Thickness?)radioButton.GetValue(CheckedBorderThicknessProperty);
        }

        public static void SetCheckedBorderThickness(RadioButton radioButton, Thickness? value)
        {
            radioButton.SetValue(CheckedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("CheckedBorderThickness", typeof(Thickness?), typeof(RadioButtonHelper));
        #endregion

        #region CheckedToggleBrush
        public static Brush GetCheckedToggleBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(CheckedToggleBrushProperty);
        }

        public static void SetCheckedToggleBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(CheckedToggleBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedToggleBrushProperty =
            DependencyProperty.RegisterAttached("CheckedToggleBrush", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region CheckedContent
        public static object GetCheckedContent(RadioButton radioButton)
        {
            return (object)radioButton.GetValue(CheckedContentProperty);
        }

        public static void SetCheckedContent(RadioButton radioButton, object value)
        {
            radioButton.SetValue(CheckedContentProperty, value);
        }

        public static readonly DependencyProperty CheckedContentProperty =
            DependencyProperty.RegisterAttached("CheckedContent", typeof(object), typeof(RadioButtonHelper));
        #endregion

        #region NullableBackground
        public static Brush GetNullableBackground(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(NullableBackgroundProperty);
        }

        public static void SetNullableBackground(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(NullableBackgroundProperty, value);
        }

        public static readonly DependencyProperty NullableBackgroundProperty =
            DependencyProperty.RegisterAttached("NullableBackground", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region NullableForeround
        public static Brush GetNullableForeround(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(NullableForeroundProperty);
        }

        public static void SetNullableForeround(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(NullableForeroundProperty, value);
        }

        public static readonly DependencyProperty NullableForeroundProperty =
            DependencyProperty.RegisterAttached("NullableForeround", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region NullableBorderBrush
        public static Brush GetNullableBorderBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(NullableBorderBrushProperty);
        }

        public static void SetNullableBorderBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(NullableBorderBrushProperty, value);
        }

        public static readonly DependencyProperty NullableBorderBrushProperty =
            DependencyProperty.RegisterAttached("NullableBorderBrush", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region NullableBorderThickness
        public static Thickness GetNullableBorderThickness(RadioButton radioButton)
        {
            return (Thickness)radioButton.GetValue(NullableBorderThicknessProperty);
        }

        public static void SetNullableBorderThickness(RadioButton radioButton, Thickness value)
        {
            radioButton.SetValue(NullableBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty NullableBorderThicknessProperty =
            DependencyProperty.RegisterAttached("NullableBorderThickness", typeof(Thickness), typeof(RadioButtonHelper));
        #endregion

        #region NullableToggleBrush
        public static Brush GetNullableToggleBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(NullableToggleBrushProperty);
        }

        public static void SetNullableToggleBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(NullableToggleBrushProperty, value);
        }

        public static readonly DependencyProperty NullableToggleBrushProperty =
            DependencyProperty.RegisterAttached("NullableToggleBrush", typeof(Brush), typeof(RadioButtonHelper));
        #endregion
    }
}
