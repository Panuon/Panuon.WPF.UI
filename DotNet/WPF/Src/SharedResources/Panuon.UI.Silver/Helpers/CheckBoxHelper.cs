using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class CheckBoxHelper
    {
        #region CornerRadius
        public static CornerRadius GetCornerRadius(CheckBox checkBox)
        {
            return (CornerRadius)checkBox.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(CheckBox checkBox, CornerRadius value)
        {
            checkBox.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(CheckBoxHelper));
        #endregion

        #region BoxHeight
        public static double GetBoxHeight(CheckBox checkBox)
        {
            return (double)checkBox.GetValue(BoxHeightProperty);
        }

        public static void SetBoxHeight(CheckBox checkBox, double value)
        {
            checkBox.SetValue(BoxHeightProperty, value);
        }

        public static readonly DependencyProperty BoxHeightProperty =
            DependencyProperty.RegisterAttached("BoxHeight", typeof(double), typeof(CheckBoxHelper), new PropertyMetadata(16.0));
        #endregion

        #region BoxWidth
        public static double GetBoxWidth(CheckBox checkBox)
        {
            return (double)checkBox.GetValue(BoxWidthProperty);
        }

        public static void SetBoxWidth(CheckBox checkBox, double value)
        {
            checkBox.SetValue(BoxWidthProperty, value);
        }

        public static readonly DependencyProperty BoxWidthProperty =
            DependencyProperty.RegisterAttached("BoxWidth", typeof(double), typeof(CheckBoxHelper), new PropertyMetadata(16.0));
        #endregion

        #region ContentPlacement
        public static ContentPlacement GetContentPlacement(CheckBox checkBox)
        {
            return (ContentPlacement)checkBox.GetValue(ContentPlacementProperty);
        }

        public static void SetContentPlacement(CheckBox checkBox, ContentPlacement value)
        {
            checkBox.SetValue(ContentPlacementProperty, value);
        }

        public static readonly DependencyProperty ContentPlacementProperty =
            DependencyProperty.RegisterAttached("ContentPlacement", typeof(ContentPlacement), typeof(CheckBoxHelper), new PropertyMetadata(ContentPlacement.Right));
        #endregion
        
        #region GlyphBrush
        public static Brush GetGlyphBrush(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(GlyphBrushProperty);
        }

        public static void SetGlyphBrush(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(GlyphBrushProperty, value);
        }

        public static readonly DependencyProperty GlyphBrushProperty =
            DependencyProperty.RegisterAttached("GlyphBrush", typeof(Brush), typeof(CheckBoxHelper), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region GlyphThickness
        public static double GetGlyphThickness(CheckBox checkBox)
        {
            return (double)checkBox.GetValue(GlyphThicknessProperty);
        }

        public static void SetGlyphThickness(CheckBox checkBox, double value)
        {
            checkBox.SetValue(GlyphThicknessProperty, value);
        }

        public static readonly DependencyProperty GlyphThicknessProperty =
            DependencyProperty.RegisterAttached("GlyphThickness", typeof(double), typeof(CheckBoxHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(CheckBoxHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(CheckBoxHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(CheckBoxHelper));
        #endregion

        #region HoverGlyphBrush
        public static Brush GetHoverGlyphBrush(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(HoverGlyphBrushProperty);
        }

        public static void SetHoverGlyphBrush(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(HoverGlyphBrushProperty, value);
        }

        public static readonly DependencyProperty HoverGlyphBrushProperty =
            VisualStateHelper.HoverGlyphBrushProperty.AddOwner(typeof(CheckBoxHelper));
        #endregion

        #region CheckedForeground
        public static Brush GetCheckedForeground(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(CheckedForegroundProperty);
        }

        public static void SetCheckedForeground(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(CheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.RegisterAttached("CheckedForeground", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region CheckedBackground
        public static Brush GetCheckedBackground(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(CheckedBackgroundProperty);
        }

        public static void SetCheckedBackground(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(CheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("CheckedBackground", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region CheckedBorderBrush
        public static Brush GetCheckedBorderBrush(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(CheckedBorderBrushProperty);
        }

        public static void SetCheckedBorderBrush(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(CheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("CheckedBorderBrush", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region CheckedBorderThickness
        public static Thickness? GetCheckedBorderThickness(CheckBox checkBox)
        {
            return (Thickness?)checkBox.GetValue(CheckedBorderThicknessProperty);
        }

        public static void SetCheckedBorderThickness(CheckBox checkBox, Thickness? value)
        {
            checkBox.SetValue(CheckedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("CheckedBorderThickness", typeof(Thickness?), typeof(CheckBoxHelper));
        #endregion
        
        #region CheckedGlyphBrush
        public static Brush GetCheckedGlyphBrush(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(CheckedGlyphBrushProperty);
        }

        public static void SetCheckedGlyphBrush(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(CheckedGlyphBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedGlyphBrushProperty =
            DependencyProperty.RegisterAttached("CheckedGlyphBrush", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region CheckedContent
        public static object GetCheckedContent(CheckBox checkBox)
        {
            return (object)checkBox.GetValue(CheckedContentProperty);
        }

        public static void SetCheckedContent(CheckBox checkBox, object value)
        {
            checkBox.SetValue(CheckedContentProperty, value);
        }

        public static readonly DependencyProperty CheckedContentProperty =
            DependencyProperty.RegisterAttached("CheckedContent", typeof(object), typeof(CheckBoxHelper));
        #endregion

        #region NullableBackground
        public static Brush GetNullableBackground(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(NullableBackgroundProperty);
        }

        public static void SetNullableBackground(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(NullableBackgroundProperty, value);
        }

        public static readonly DependencyProperty NullableBackgroundProperty =
            DependencyProperty.RegisterAttached("NullableBackground", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region NullableForeround
        public static Brush GetNullableForeround(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(NullableForeroundProperty);
        }

        public static void SetNullableForeround(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(NullableForeroundProperty, value);
        }

        public static readonly DependencyProperty NullableForeroundProperty =
            DependencyProperty.RegisterAttached("NullableForeround", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region NullableBorderBrush
        public static Brush GetNullableBorderBrush(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(NullableBorderBrushProperty);
        }

        public static void SetNullableBorderBrush(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(NullableBorderBrushProperty, value);
        }

        public static readonly DependencyProperty NullableBorderBrushProperty =
            DependencyProperty.RegisterAttached("NullableBorderBrush", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region NullableBorderThickness
        public static Thickness GetNullableBorderThickness(CheckBox checkBox)
        {
            return (Thickness)checkBox.GetValue(NullableBorderThicknessProperty);
        }

        public static void SetNullableBorderThickness(CheckBox checkBox, Thickness value)
        {
            checkBox.SetValue(NullableBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty NullableBorderThicknessProperty =
            DependencyProperty.RegisterAttached("NullableBorderThickness", typeof(Thickness), typeof(CheckBoxHelper));
        #endregion

        #region NullableGlyphBrush
        public static Brush GetNullableGlyphBrush(CheckBox checkBox)
        {
            return (Brush)checkBox.GetValue(NullableGlyphBrushProperty);
        }

        public static void SetNullableGlyphBrush(CheckBox checkBox, Brush value)
        {
            checkBox.SetValue(NullableGlyphBrushProperty, value);
        }

        public static readonly DependencyProperty NullableGlyphBrushProperty =
            DependencyProperty.RegisterAttached("NullableGlyphBrush", typeof(Brush), typeof(CheckBoxHelper));
        #endregion
    } 
}
