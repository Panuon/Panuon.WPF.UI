using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class GroupBoxHelper
    {
        #region Icon
        public static object GetIcon(GroupBox groupBox)
        {
            return (object)groupBox.GetValue(IconProperty);
        }

        public static void SetIcon(GroupBox groupBox, object value)
        {
            groupBox.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(GroupBoxHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(GroupBox groupBox)
        {
            return (CornerRadius)groupBox.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(GroupBox groupBox, CornerRadius value)
        {
            groupBox.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(GroupBoxHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(GroupBox groupBox)
        {
            return (Color?)groupBox.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(GroupBox groupBox, Color? value)
        {
            groupBox.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(GroupBoxHelper));
        #endregion

        #region HeaderPadding
        public static Thickness GetHeaderPadding(GroupBox groupBox)
        {
            return (Thickness)groupBox.GetValue(HeaderPaddingProperty);
        }

        public static void SetHeaderPadding(GroupBox groupBox, Thickness value)
        {
            groupBox.SetValue(HeaderPaddingProperty, value);
        }

        public static readonly DependencyProperty HeaderPaddingProperty =
            DependencyProperty.RegisterAttached("HeaderPadding", typeof(Thickness), typeof(GroupBoxHelper));
        #endregion

        #region HeaderFontSize
        public static double GetHeaderFontSize(GroupBox groupBox)
        {
            return (double)groupBox.GetValue(HeaderFontSizeProperty);
        }

        public static void SetHeaderFontSize(GroupBox groupBox, double value)
        {
            groupBox.SetValue(HeaderFontSizeProperty, value);
        }

        public static readonly DependencyProperty HeaderFontSizeProperty =
            DependencyProperty.RegisterAttached("HeaderFontSize", typeof(double), typeof(GroupBoxHelper));
        #endregion

        #region HeaderForeground
        public static Brush GetHeaderForeground(GroupBox groupBox)
        {
            return (Brush)groupBox.GetValue(HeaderForegroundProperty);
        }

        public static void SetHeaderForeground(GroupBox groupBox, Brush value)
        {
            groupBox.SetValue(HeaderForegroundProperty, value);
        }

        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.RegisterAttached("HeaderForeground", typeof(Brush), typeof(GroupBoxHelper));
        #endregion

        #region HeaderBackground
        public static Brush GetHeaderBackground(GroupBox groupBox)
        {
            return (Brush)groupBox.GetValue(HeaderBackgroundProperty);
        }

        public static void SetHeaderBackground(GroupBox groupBox, Brush value)
        {
            groupBox.SetValue(HeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.RegisterAttached("HeaderBackground", typeof(Brush), typeof(GroupBoxHelper));
        #endregion

        #region HeaderHeight
        public static double GetHeaderHeight(GroupBox groupBox)
        {
            return (double)groupBox.GetValue(HeaderHeightProperty);
        }

        public static void SetHeaderHeight(GroupBox groupBox, double value)
        {
            groupBox.SetValue(HeaderHeightProperty, value);
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.RegisterAttached("HeaderHeight", typeof(double), typeof(GroupBoxHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region HeaderVerticalAlignment
        public static GroupBoxHeaderVerticalAlignment GetHeaderVerticalAlignment(GroupBox groupBox)
        {
            return (GroupBoxHeaderVerticalAlignment)groupBox.GetValue(HeaderVerticalAlignmentProperty);
        }

        public static void SetHeaderVerticalAlignment(GroupBox groupBox, GroupBoxHeaderVerticalAlignment value)
        {
            groupBox.SetValue(HeaderVerticalAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderVerticalAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderVerticalAlignment", typeof(GroupBoxHeaderVerticalAlignment), typeof(GroupBoxHelper));
        #endregion

        #region HeaderHorizontalContentAlignment
        public static HorizontalAlignment GetHeaderHorizontalContentAlignment(GroupBox groupBox)
        {
            return (HorizontalAlignment)groupBox.GetValue(HeaderHorizontalContentAlignmentProperty);
        }

        public static void SetHeaderHorizontalContentAlignment(GroupBox groupBox, HorizontalAlignment value)
        {
            groupBox.SetValue(HeaderHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(GroupBoxHelper));
        #endregion

        #region HeaderVerticalContentAlignment
        public static VerticalAlignment GetHeaderVerticalContentAlignment(GroupBox groupBox)
        {
            return (VerticalAlignment)groupBox.GetValue(HeaderVerticalContentAlignmentProperty);
        }

        public static void SetHeaderVerticalContentAlignment(GroupBox groupBox, VerticalAlignment value)
        {
            groupBox.SetValue(HeaderVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderVerticalContentAlignment", typeof(VerticalAlignment), typeof(GroupBoxHelper));
        #endregion

        #region HeaderSeparatorVisibility
        public static Visibility GetHeaderSeparatorVisibility(GroupBox groupBox)
        {
            return (Visibility)groupBox.GetValue(HeaderSeparatorVisibilityProperty);
        }

        public static void SetHeaderSeparatorVisibility(GroupBox groupBox, Visibility value)
        {
            groupBox.SetValue(HeaderSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorVisibility", typeof(Visibility), typeof(GroupBoxHelper));
        #endregion

        #region HeaderSeparatorBrush
        public static Brush GetHeaderSeparatorBrush(GroupBox groupBox)
        {
            return (Brush)groupBox.GetValue(HeaderSeparatorBrushProperty);
        }

        public static void SetHeaderSeparatorBrush(GroupBox groupBox, Brush value)
        {
            groupBox.SetValue(HeaderSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorBrush", typeof(Brush), typeof(GroupBoxHelper));
        #endregion

        #region HeaderSeparatorThickness
        public static double GetHeaderSeparatorThickness(GroupBox groupBox)
        {
            return (double)groupBox.GetValue(HeaderSeparatorThicknessProperty);
        }

        public static void SetHeaderSeparatorThickness(GroupBox groupBox, double value)
        {
            groupBox.SetValue(HeaderSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorThickness", typeof(double), typeof(GroupBoxHelper));
        #endregion

        #region HeaderSeparatorMargin
        public static Thickness GetHeaderSeparatorMargin(GroupBox groupBox)
        {
            return (Thickness)groupBox.GetValue(HeaderSeparatorMarginProperty);
        }

        public static void SetHeaderSeparatorMargin(GroupBox groupBox, Thickness value)
        {
            groupBox.SetValue(HeaderSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorMargin", typeof(Thickness), typeof(GroupBoxHelper));
        #endregion

        #region ExtendControl
        public static object GetExtendControl(GroupBox groupBox)
        {
            return (object)groupBox.GetValue(ExtendControlProperty);
        }

        public static void SetExtendControl(GroupBox groupBox, object value)
        {
            groupBox.SetValue(ExtendControlProperty, value);
        }

        public static readonly DependencyProperty ExtendControlProperty =
            DependencyProperty.RegisterAttached("ExtendControl", typeof(object), typeof(GroupBoxHelper));
        #endregion

    }
}
