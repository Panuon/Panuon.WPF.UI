using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class ToggleButtonHelper
    {
        #region Properties

        #region Icon
        public static object GetIcon(ToggleButton toggleButton)
        {
            return (object)toggleButton.GetValue(IconProperty);
        }

        public static void SetIcon(ToggleButton toggleButton, object value)
        {
            toggleButton.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ToggleButtonHelper));
        #endregion

        #region IconPlacement
        public static IconPlacement GetIconPlacement(ToggleButton toggleButton)
        {
            return (IconPlacement)toggleButton.GetValue(IconPlacementProperty);
        }

        public static void SetIconPlacement(ToggleButton toggleButton, IconPlacement value)
        {
            toggleButton.SetValue(IconPlacementProperty, value);
        }

        public static readonly DependencyProperty IconPlacementProperty =
            DependencyProperty.RegisterAttached("IconPlacement", typeof(IconPlacement), typeof(ToggleButtonHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(ToggleButton toggleButton)
        {
            return (CornerRadius)toggleButton.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(ToggleButton toggleButton, CornerRadius value)
        {
            toggleButton.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ToggleButtonHelper));
        #endregion

        #region IsPending
        public static bool GetIsPending(ToggleButton toggleButton)
        {
            return (bool)toggleButton.GetValue(IsPendingProperty);
        }

        public static void SetIsPending(ToggleButton toggleButton, bool value)
        {
            toggleButton.SetValue(IsPendingProperty, value);
        }

        public static readonly DependencyProperty IsPendingProperty =
            DependencyProperty.RegisterAttached("IsPending", typeof(bool), typeof(ToggleButtonHelper));
        #endregion

        #region PendingSpinnerStyle
        public static Style GetPendingSpinnerStyle(ToggleButton toggleButton)
        {
            return (Style)toggleButton.GetValue(PendingSpinnerStyleProperty);
        }

        public static void SetPendingSpinnerStyle(ToggleButton toggleButton, Style value)
        {
            toggleButton.SetValue(PendingSpinnerStyleProperty, value);
        }

        public static readonly DependencyProperty PendingSpinnerStyleProperty =
            DependencyProperty.RegisterAttached("PendingSpinnerStyle", typeof(Style), typeof(ToggleButtonHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(ToggleButton toggleButton)
        {
            return (Color?)toggleButton.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(ToggleButton toggleButton, Color? value)
        {
            toggleButton.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ToggleButtonHelper));
        #endregion

        #region CheckedBackground
        public static Brush GetCheckedBackground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(CheckedBackgroundProperty);
        }

        public static void SetCheckedBackground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(CheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("CheckedBackground", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region CheckedForeground
        public static Brush GetCheckedForeground(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(CheckedForegroundProperty);
        }

        public static void SetCheckedForeground(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(CheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.RegisterAttached("CheckedForeground", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region CheckedBorderBrush
        public static Brush GetCheckedBorderBrush(ToggleButton toggleButton)
        {
            return (Brush)toggleButton.GetValue(CheckedBorderBrushProperty);
        }

        public static void SetCheckedBorderBrush(ToggleButton toggleButton, Brush value)
        {
            toggleButton.SetValue(CheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("CheckedBorderBrush", typeof(Brush), typeof(ToggleButtonHelper));
        #endregion

        #region CheckedContent
        public static object GetCheckedContent(ToggleButton toggleButton)
        {
            return (object)toggleButton.GetValue(CheckedContentProperty);
        }

        public static void SetCheckedContent(ToggleButton toggleButton, object value)
        {
            toggleButton.SetValue(CheckedContentProperty, value);
        }

        public static readonly DependencyProperty CheckedContentProperty =
            DependencyProperty.RegisterAttached("CheckedContent", typeof(object), typeof(ToggleButtonHelper));
        #endregion 

        #endregion
    }
}
