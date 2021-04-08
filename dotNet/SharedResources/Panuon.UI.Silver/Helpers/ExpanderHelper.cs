using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class ExpanderHelper
    {
        #region Properties

        #region Icon
        public static object GetIcon(Expander expander)
        {
            return (object)expander.GetValue(IconProperty);
        }

        public static void SetIcon(Expander expander, object value)
        {
            expander.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ExpanderHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(Expander expander)
        {
            return (CornerRadius)expander.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(Expander expander, CornerRadius value)
        {
            expander.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ExpanderHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(Expander expander)
        {
            return (Color?)expander.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(Expander expander, Color? value)
        {
            expander.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ExpanderHelper));
        #endregion

        #region ToggleArrowPlacement
        public static ToggleArrowPlacement GetToggleArrowPlacement(Expander expander)
        {
            return (ToggleArrowPlacement)expander.GetValue(ToggleArrowPlacementProperty);
        }

        public static void SetToggleArrowPlacement(Expander expander, ToggleArrowPlacement value)
        {
            expander.SetValue(ToggleArrowPlacementProperty, value);
        }

        public static readonly DependencyProperty ToggleArrowPlacementProperty =
            DependencyProperty.RegisterAttached("ToggleArrowPlacement", typeof(ToggleArrowPlacement), typeof(ExpanderHelper));
        #endregion

        #region ToggleArrowTransformControlStyle
        public static Style GetToggleArrowTransformControlStyle(Expander expander)
        {
            return (Style)expander.GetValue(ToggleArrowTransformControlStyleProperty);
        }

        public static void SetToggleArrowTransformControlStyle(Expander expander, Style value)
        {
            expander.SetValue(ToggleArrowTransformControlStyleProperty, value);
        }

        public static readonly DependencyProperty ToggleArrowTransformControlStyleProperty =
            DependencyProperty.RegisterAttached("ToggleArrowTransformControlStyle", typeof(Style), typeof(ExpanderHelper));
        #endregion

        #region HeaderPadding
        public static Thickness GetHeaderPadding(Expander expander)
        {
            return (Thickness)expander.GetValue(HeaderPaddingProperty);
        }

        public static void SetHeaderPadding(Expander expander, Thickness value)
        {
            expander.SetValue(HeaderPaddingProperty, value);
        }

        public static readonly DependencyProperty HeaderPaddingProperty =
            DependencyProperty.RegisterAttached("HeaderPadding", typeof(Thickness), typeof(ExpanderHelper));
        #endregion

        #region HeaderForeground
        public static Brush GetHeaderForeground(Expander expander)
        {
            return (Brush)expander.GetValue(HeaderForegroundProperty);
        }

        public static void SetHeaderForeground(Expander expander, Brush value)
        {
            expander.SetValue(HeaderForegroundProperty, value);
        }

        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.RegisterAttached("HeaderForeground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region HeaderBackground
        public static Brush GetHeaderBackground(Expander expander)
        {
            return (Brush)expander.GetValue(HeaderBackgroundProperty);
        }

        public static void SetHeaderBackground(Expander expander, Brush value)
        {
            expander.SetValue(HeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.RegisterAttached("HeaderBackground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region HeaderHeight
        public static double GetHeaderHeight(Expander expander)
        {
            return (double)expander.GetValue(HeaderHeightProperty);
        }

        public static void SetHeaderHeight(Expander expander, double value)
        {
            expander.SetValue(HeaderHeightProperty, value);
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.RegisterAttached("HeaderHeight", typeof(double), typeof(ExpanderHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region HeaderHorizontalContentAlignment
        public static HorizontalAlignment GetHeaderHorizontalContentAlignment(Expander expander)
        {
            return (HorizontalAlignment)expander.GetValue(HeaderHorizontalContentAlignmentProperty);
        }

        public static void SetHeaderHorizontalContentAlignment(Expander expander, HorizontalAlignment value)
        {
            expander.SetValue(HeaderHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(ExpanderHelper));
        #endregion

        #region HeaderVerticalContentAlignment
        public static VerticalAlignment GetHeaderVerticalContentAlignment(Expander expander)
        {
            return (VerticalAlignment)expander.GetValue(HeaderVerticalContentAlignmentProperty);
        }

        public static void SetHeaderVerticalContentAlignment(Expander expander, VerticalAlignment value)
        {
            expander.SetValue(HeaderVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderVerticalContentAlignment", typeof(VerticalAlignment), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeaderForeground
        public static Brush GetExpandedHeaderForeground(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedHeaderForegroundProperty);
        }

        public static void SetExpandedHeaderForeground(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedHeaderForegroundProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderForegroundProperty =
            DependencyProperty.RegisterAttached("ExpandedHeaderForeground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeaderBackground
        public static Brush GetExpandedHeaderBackground(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedHeaderBackgroundProperty);
        }

        public static void SetExpandedHeaderBackground(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedHeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderBackgroundProperty =
            DependencyProperty.RegisterAttached("ExpandedHeaderBackground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region ExpandedBackground
        public static Brush GetExpandedBackground(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedBackgroundProperty);
        }

        public static void SetExpandedBackground(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ExpandedBackgroundProperty =
            DependencyProperty.RegisterAttached("ExpandedBackground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region ExpandedBorderBrush
        public static Brush GetExpandedBorderBrush(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedBorderBrushProperty);
        }

        public static void SetExpandedBorderBrush(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ExpandedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ExpandedBorderBrush", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region HeaderSeparatorVisibility
        public static Visibility GetHeaderSeparatorVisibility(Expander expander)
        {
            return (Visibility)expander.GetValue(HeaderSeparatorVisibilityProperty);
        }

        public static void SetHeaderSeparatorVisibility(Expander expander, Visibility value)
        {
            expander.SetValue(HeaderSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorVisibility", typeof(Visibility), typeof(ExpanderHelper));
        #endregion

        #region HeaderSeparatorBrush
        public static Brush GetHeaderSeparatorBrush(Expander expander)
        {
            return (Brush)expander.GetValue(HeaderSeparatorBrushProperty);
        }

        public static void SetHeaderSeparatorBrush(Expander expander, Brush value)
        {
            expander.SetValue(HeaderSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorBrush", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region HeaderSeparatorThickness
        public static double GetHeaderSeparatorThickness(Expander expander)
        {
            return (double)expander.GetValue(HeaderSeparatorThicknessProperty);
        }

        public static void SetHeaderSeparatorThickness(Expander expander, double value)
        {
            expander.SetValue(HeaderSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorThickness", typeof(double), typeof(ExpanderHelper));
        #endregion

        #region HeaderSeparatorMargin
        public static Thickness GetHeaderSeparatorMargin(Expander expander)
        {
            return (Thickness)expander.GetValue(HeaderSeparatorMarginProperty);
        }

        public static void SetHeaderSeparatorMargin(Expander expander, Thickness value)
        {
            expander.SetValue(HeaderSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorMargin", typeof(Thickness), typeof(ExpanderHelper));
        #endregion

        #region AnimationDuration
        public static TimeSpan? GetAnimationDuration(Expander expander)
        {
            return (TimeSpan?)expander.GetValue(AnimationDurationProperty);
        }

        public static void SetAnimationDuration(Expander expander, TimeSpan? value)
        {
            expander.SetValue(AnimationDurationProperty, value);
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.RegisterAttached("AnimationDuration", typeof(TimeSpan?), typeof(ExpanderHelper));
        #endregion

        #region AnimationEase
        public static AnimationEase GetAnimationEase(Expander expander)
        {
            return (AnimationEase)expander.GetValue(AnimationEaseProperty);
        }

        public static void SetAnimationEase(Expander expander, AnimationEase value)
        {
            expander.SetValue(AnimationEaseProperty, value);
        }

        public static readonly DependencyProperty AnimationEaseProperty =
            DependencyProperty.RegisterAttached("AnimationEase", typeof(AnimationEase), typeof(ExpanderHelper));
        #endregion

        #region ExtendControl
        public static object GetExtendControl(Expander expander)
        {
            return (object)expander.GetValue(ExtendControlProperty);
        }

        public static void SetExtendControl(Expander expander, object value)
        {
            expander.SetValue(ExtendControlProperty, value);
        }

        public static readonly DependencyProperty ExtendControlProperty =
            DependencyProperty.RegisterAttached("ExtendControl", typeof(object), typeof(ExpanderHelper));
        #endregion

        #endregion
    }
}
