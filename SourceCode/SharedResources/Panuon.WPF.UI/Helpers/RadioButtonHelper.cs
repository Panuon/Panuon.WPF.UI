using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
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

        #region NullBackground
        public static Brush GetNullBackground(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(NullBackgroundProperty);
        }

        public static void SetNullBackground(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(NullBackgroundProperty, value);
        }

        public static readonly DependencyProperty NullBackgroundProperty =
            DependencyProperty.RegisterAttached("NullBackground", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region NullForeground
        public static Brush GetNullForeground(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(NullForegroundProperty);
        }

        public static void SetNullForeground(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(NullForegroundProperty, value);
        }

        public static readonly DependencyProperty NullForegroundProperty =
            DependencyProperty.RegisterAttached("NullForeground", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region NullBorderBrush
        public static Brush GetNullBorderBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(NullBorderBrushProperty);
        }

        public static void SetNullBorderBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(NullBorderBrushProperty, value);
        }

        public static readonly DependencyProperty NullBorderBrushProperty =
            DependencyProperty.RegisterAttached("NullBorderBrush", typeof(Brush), typeof(RadioButtonHelper));
        #endregion

        #region NullBorderThickness
        public static Thickness? GetNullBorderThickness(RadioButton radioButton)
        {
            return (Thickness?)radioButton.GetValue(NullBorderThicknessProperty);
        }

        public static void SetNullBorderThickness(RadioButton radioButton, Thickness? value)
        {
            radioButton.SetValue(NullBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty NullBorderThicknessProperty =
            DependencyProperty.RegisterAttached("NullBorderThickness", typeof(Thickness?), typeof(RadioButtonHelper));
        #endregion

        #region NullToggleBrush
        public static Brush GetNullToggleBrush(RadioButton radioButton)
        {
            return (Brush)radioButton.GetValue(NullToggleBrushProperty);
        }

        public static void SetNullToggleBrush(RadioButton radioButton, Brush value)
        {
            radioButton.SetValue(NullToggleBrushProperty, value);
        }

        public static readonly DependencyProperty NullToggleBrushProperty =
            DependencyProperty.RegisterAttached("NullToggleBrush", typeof(Brush), typeof(RadioButtonHelper));
        #endregion
    }
}
