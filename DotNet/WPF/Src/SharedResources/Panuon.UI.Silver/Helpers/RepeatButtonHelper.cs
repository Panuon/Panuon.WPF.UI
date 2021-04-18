using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class RepeatButtonHelper
    {
        #region Properties

        #region Icon
        public static object GetIcon(RepeatButton repeatButton)
        {
            return (object)repeatButton.GetValue(IconProperty);
        }

        public static void SetIcon(RepeatButton repeatButton, object value)
        {
            repeatButton.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(RepeatButtonHelper));
        #endregion

        #region IconPlacement
        public static IconPlacement GetIconPlacement(RepeatButton repeatButton)
        {
            return (IconPlacement)repeatButton.GetValue(IconPlacementProperty);
        }

        public static void SetIconPlacement(RepeatButton repeatButton, IconPlacement value)
        {
            repeatButton.SetValue(IconPlacementProperty, value);
        }

        public static readonly DependencyProperty IconPlacementProperty =
            DependencyProperty.RegisterAttached("IconPlacement", typeof(IconPlacement), typeof(RepeatButtonHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(RepeatButton repeatButton)
        {
            return (CornerRadius)repeatButton.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(RepeatButton repeatButton, CornerRadius value)
        {
            repeatButton.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(RepeatButtonHelper));
        #endregion

        #region IsPending
        public static bool GetIsPending(RepeatButton repeatButton)
        {
            return (bool)repeatButton.GetValue(IsPendingProperty);
        }

        public static void SetIsPending(RepeatButton repeatButton, bool value)
        {
            repeatButton.SetValue(IsPendingProperty, value);
        }

        public static readonly DependencyProperty IsPendingProperty =
            DependencyProperty.RegisterAttached("IsPending", typeof(bool), typeof(RepeatButtonHelper));
        #endregion

        #region PendingSpinnerStyle
        public static Style GetPendingSpinnerStyle(RepeatButton repeatButton)
        {
            return (Style)repeatButton.GetValue(PendingSpinnerStyleProperty);
        }

        public static void SetPendingSpinnerStyle(RepeatButton repeatButton, Style value)
        {
            repeatButton.SetValue(PendingSpinnerStyleProperty, value);
        }

        public static readonly DependencyProperty PendingSpinnerStyleProperty =
            DependencyProperty.RegisterAttached("PendingSpinnerStyle", typeof(Style), typeof(RepeatButtonHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(RepeatButton repeatButton)
        {
            return (Color?)repeatButton.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(RepeatButton repeatButton, Color? value)
        {
            repeatButton.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(RepeatButtonHelper));
        #endregion

        #region ClickEffect
        public static ClickEffect GetClickEffect(RepeatButton repeatButton)
        {
            return (ClickEffect)repeatButton.GetValue(ClickEffectProperty);
        }

        public static void SetClickEffect(RepeatButton repeatButton, ClickEffect value)
        {
            repeatButton.SetValue(ClickEffectProperty, value);
        }

        public static readonly DependencyProperty ClickEffectProperty =
            DependencyProperty.RegisterAttached("ClickEffect", typeof(ClickEffect), typeof(RepeatButtonHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(RepeatButton repeatButton)
        {
            return (Brush)repeatButton.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(RepeatButton repeatButton, Brush value)
        {
            repeatButton.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(RepeatButtonHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(RepeatButton repeatButton)
        {
            return (Brush)repeatButton.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(RepeatButton repeatButton, Brush value)
        {
            repeatButton.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(RepeatButtonHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(RepeatButton repeatButton)
        {
            return (Brush)repeatButton.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(RepeatButton repeatButton, Brush value)
        {
            repeatButton.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(RepeatButtonHelper));
        #endregion

        #region ClickBackground
        public static Brush GetClickBackground(RepeatButton repeatButton)
        {
            return (Brush)repeatButton.GetValue(ClickBackgroundProperty);
        }

        public static void SetClickBackground(RepeatButton repeatButton, Brush value)
        {
            repeatButton.SetValue(ClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty ClickBackgroundProperty =
            DependencyProperty.RegisterAttached("ClickBackground", typeof(Brush), typeof(RepeatButtonHelper));
        #endregion

        #region ClickForeground
        public static Brush GetClickForeground(RepeatButton repeatButton)
        {
            return (Brush)repeatButton.GetValue(ClickForegroundProperty);
        }

        public static void SetClickForeground(RepeatButton repeatButton, Brush value)
        {
            repeatButton.SetValue(ClickForegroundProperty, value);
        }

        public static readonly DependencyProperty ClickForegroundProperty =
            DependencyProperty.RegisterAttached("ClickForeground", typeof(Brush), typeof(RepeatButtonHelper));
        #endregion

        #region ClickBorderBrush
        public static Brush GetClickBorderBrush(RepeatButton repeatButton)
        {
            return (Brush)repeatButton.GetValue(ClickBorderBrushProperty);
        }

        public static void SetClickBorderBrush(RepeatButton repeatButton, Brush value)
        {
            repeatButton.SetValue(ClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("ClickBorderBrush", typeof(Brush), typeof(RepeatButtonHelper));
        #endregion

        #endregion
    }
}
