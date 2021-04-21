using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class ButtonHelper
    {
        #region Properties

        #region Icon
        public static object GetIcon(Button button)
        {
            return (object)button.GetValue(IconProperty);
        }

        public static void SetIcon(Button button, object value)
        {
            button.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ButtonHelper));
        #endregion

        #region IconPlacement
        public static IconPlacement GetIconPlacement(Button button)
        {
            return (IconPlacement)button.GetValue(IconPlacementProperty);
        }

        public static void SetIconPlacement(Button button, IconPlacement value)
        {
            button.SetValue(IconPlacementProperty, value);
        }

        public static readonly DependencyProperty IconPlacementProperty =
            DependencyProperty.RegisterAttached("IconPlacement", typeof(IconPlacement), typeof(ButtonHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(Button button)
        {
            return (CornerRadius)button.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(Button button, CornerRadius value)
        {
            button.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ButtonHelper));
        #endregion

        #region IsPending
        public static bool GetIsPending(Button button)
        {
            return (bool)button.GetValue(IsPendingProperty);
        }

        public static void SetIsPending(Button button, bool value)
        {
            button.SetValue(IsPendingProperty, value);
        }

        public static readonly DependencyProperty IsPendingProperty =
            DependencyProperty.RegisterAttached("IsPending", typeof(bool), typeof(ButtonHelper));
        #endregion

        #region PendingSpinnerStyle
        public static Style GetPendingSpinnerStyle(Button button)
        {
            return (Style)button.GetValue(PendingSpinnerStyleProperty);
        }

        public static void SetPendingSpinnerStyle(Button button, Style value)
        {
            button.SetValue(PendingSpinnerStyleProperty, value);
        }

        public static readonly DependencyProperty PendingSpinnerStyleProperty =
            DependencyProperty.RegisterAttached("PendingSpinnerStyle", typeof(Style), typeof(ButtonHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(Button button)
        {
            return (Color?)button.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(Button button, Color? value)
        {
            button.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ButtonHelper));
        #endregion

        #region ClickEffect
        public static ClickEffect GetClickEffect(Button button)
        {
            return (ClickEffect)button.GetValue(ClickEffectProperty);
        }

        public static void SetClickEffect(Button button, ClickEffect value)
        {
            button.SetValue(ClickEffectProperty, value);
        }

        public static readonly DependencyProperty ClickEffectProperty =
            DependencyProperty.RegisterAttached("ClickEffect", typeof(ClickEffect), typeof(ButtonHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(Button button)
        {
            return (Brush)button.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(Button button, Brush value)
        {
            button.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ButtonHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(Button button)
        {
            return (Brush)button.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(Button button, Brush value)
        {
            button.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ButtonHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(Button button)
        {
            return (Brush)button.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(Button button, Brush value)
        {
            button.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ButtonHelper));
        #endregion

        #region ClickBackground
        public static Brush GetClickBackground(Button button)
        {
            return (Brush)button.GetValue(ClickBackgroundProperty);
        }

        public static void SetClickBackground(Button button, Brush value)
        {
            button.SetValue(ClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty ClickBackgroundProperty =
            DependencyProperty.RegisterAttached("ClickBackground", typeof(Brush), typeof(ButtonHelper));
        #endregion

        #region ClickForeground
        public static Brush GetClickForeground(Button button)
        {
            return (Brush)button.GetValue(ClickForegroundProperty);
        }

        public static void SetClickForeground(Button button, Brush value)
        {
            button.SetValue(ClickForegroundProperty, value);
        }

        public static readonly DependencyProperty ClickForegroundProperty =
            DependencyProperty.RegisterAttached("ClickForeground", typeof(Brush), typeof(ButtonHelper));
        #endregion

        #region ClickBorderBrush
        public static Brush GetClickBorderBrush(Button button)
        {
            return (Brush)button.GetValue(ClickBorderBrushProperty);
        }

        public static void SetClickBorderBrush(Button button, Brush value)
        {
            button.SetValue(ClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("ClickBorderBrush", typeof(Brush), typeof(ButtonHelper));
        #endregion

        #endregion
    }
}
