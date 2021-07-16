using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class TabItemHelper
    {
        #region Properties

        #region Icon
        public static object GetIcon(TabItem tabItem)
        {
            return (object)tabItem.GetValue(IconProperty);
        }

        public static void SetIcon(TabItem tabItem, object value)
        {
            tabItem.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(TabItemHelper));
        #endregion

        #region IconPlacement
        public static IconPlacement GetIconPlacement(TabItem tabItem)
        {
            return (IconPlacement)tabItem.GetValue(IconPlacementProperty);
        }

        public static void SetIconPlacement(TabItem tabItem, IconPlacement value)
        {
            tabItem.SetValue(IconPlacementProperty, value);
        }

        public static readonly DependencyProperty IconPlacementProperty =
            DependencyProperty.RegisterAttached("IconPlacement", typeof(IconPlacement), typeof(TabItemHelper), new PropertyMetadata(IconPlacement.Left));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(TabItem tabItem)
        {
            return (CornerRadius)tabItem.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(TabItem tabItem, CornerRadius value)
        {
            tabItem.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(TabItemHelper));
        #endregion

        #region Foreground
        public static Brush GetForeground(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(ForegroundProperty);
        }

        public static void SetForeground(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(ForegroundProperty, value);
        }

        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(TabItemHelper));

        #endregion

        #region Margin
        public static Thickness GetMargin(TabItem tabItem)
        {
            return (Thickness)tabItem.GetValue(MarginProperty);
        }

        public static void SetMargin(TabItem tabItem, Thickness value)
        {
            tabItem.SetValue(MarginProperty, value);
        }

        public static readonly DependencyProperty MarginProperty =
            DependencyProperty.RegisterAttached("Margin", typeof(Thickness), typeof(TabItemHelper));
        #endregion

        #region SelectedWidth
        public static double? GetSelectedWidth(TabItem tabItem)
        {
            return (double?)tabItem.GetValue(SelectedWidthProperty);
        }

        public static void SetSelectedWidth(TabItem tabItem, double? value)
        {
            tabItem.SetValue(SelectedWidthProperty, value);
        }

        public static readonly DependencyProperty SelectedWidthProperty =
            DependencyProperty.RegisterAttached("SelectedWidth", typeof(double?), typeof(TabItemHelper));
        #endregion

        #region SelectedHeight
        public static double? GetSelectedHeight(TabItem tabItem)
        {
            return (double?)tabItem.GetValue(SelectedHeightProperty);
        }

        public static void SetSelectedHeight(TabItem tabItem, double? value)
        {
            tabItem.SetValue(SelectedHeightProperty, value);
        }

        public static readonly DependencyProperty SelectedHeightProperty =
            DependencyProperty.RegisterAttached("SelectedHeight", typeof(double?), typeof(TabItemHelper));
        #endregion

        #region RibbonLineBrush
        public static Brush GetRibbonLineBrush(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(RibbonLineBrushProperty);
        }

        public static void SetRibbonLineBrush(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(RibbonLineBrushProperty, value);
        }

        public static readonly DependencyProperty RibbonLineBrushProperty =
            VisualStateHelper.RibbonLineBrushProperty.AddOwner(typeof(TabItemHelper));
        #endregion

        #region RibbonLineThickness
        public static double GetRibbonLineThickness(TabItem tabItem)
        {
            return (double)tabItem.GetValue(RibbonLineThicknessProperty);
        }

        public static void SetRibbonLineThickness(TabItem tabItem, double value)
        {
            tabItem.SetValue(RibbonLineThicknessProperty, value);
        }

        public static readonly DependencyProperty RibbonLineThicknessProperty =
            DependencyProperty.RegisterAttached("RibbonLineThickness", typeof(double), typeof(TabItemHelper));
        #endregion

        #region RibbonLinePlacement
        public static RibbonLinePlacement GetRibbonLinePlacement(TabItem tabItem)
        {
            return (RibbonLinePlacement)tabItem.GetValue(RibbonLinePlacementProperty);
        }

        public static void SetRibbonLinePlacement(TabItem tabItem, RibbonLinePlacement value)
        {
            tabItem.SetValue(RibbonLinePlacementProperty, value);
        }

        public static readonly DependencyProperty RibbonLinePlacementProperty =
            DependencyProperty.RegisterAttached("RibbonLinePlacement", typeof(RibbonLinePlacement), typeof(TabItemHelper));
        #endregion

        #region RibbonLineVisibility
        public static Visibility GetRibbonLineVisibility(TabItem tabItem)
        {
            return (Visibility)tabItem.GetValue(RibbonLineVisibilityProperty);
        }

        public static void SetRibbonLineVisibility(TabItem tabItem, Visibility value)
        {
            tabItem.SetValue(RibbonLineVisibilityProperty, value);
        }

        public static readonly DependencyProperty RibbonLineVisibilityProperty =
            DependencyProperty.RegisterAttached("RibbonLineVisibility", typeof(Visibility), typeof(TabItemHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(TabItemHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(TabItemHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(TabItemHelper));
        #endregion

        #region HoverRibbonLineBrush
        public static Brush GetHoverRibbonLineBrush(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(HoverRibbonLineBrushProperty);
        }

        public static void SetHoverRibbonLineBrush(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(HoverRibbonLineBrushProperty, value);
        }

        public static readonly DependencyProperty HoverRibbonLineBrushProperty =
            VisualStateHelper.HoverRibbonLineBrushProperty.AddOwner(typeof(TabItemHelper));
        #endregion

        #region SelectedBackground
        public static Brush GetSelectedBackground(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(SelectedBackgroundProperty);
        }

        public static void SetSelectedBackground(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(SelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("SelectedBackground", typeof(Brush), typeof(TabItemHelper));
        #endregion

        #region SelectedForeground
        public static Brush GetSelectedForeground(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(SelectedForegroundProperty);
        }

        public static void SetSelectedForeground(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(SelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.RegisterAttached("SelectedForeground", typeof(Brush), typeof(TabItemHelper));
        #endregion

        #region SelectedBorderBrush
        public static Brush GetSelectedBorderBrush(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(SelectedBorderBrushProperty);
        }

        public static void SetSelectedBorderBrush(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(SelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("SelectedBorderBrush", typeof(Brush), typeof(TabItemHelper));
        #endregion

        #region SelectedBorderThickness
        public static Thickness? GetSelectedBorderThickness(TabItem tabItem)
        {
            return (Thickness?)tabItem.GetValue(SelectedBorderThicknessProperty);
        }

        public static void SetSelectedBorderThickness(TabItem tabItem, Thickness? value)
        {
            tabItem.SetValue(SelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SelectedBorderThickness", typeof(Thickness?), typeof(TabItemHelper));
        #endregion

        #region SelectedCornerRadius
        public static CornerRadius? GetSelectedCornerRadius(TabItem tabItem)
        {
            return (CornerRadius?)tabItem.GetValue(SelectedCornerRadiusProperty);
        }

        public static void SetSelectedCornerRadius(TabItem tabItem, CornerRadius? value)
        {
            tabItem.SetValue(SelectedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SelectedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SelectedCornerRadius", typeof(CornerRadius?), typeof(TabItemHelper));
        #endregion

        #region SelectedRibbonLineBrush
        public static Brush GetSelectedRibbonLineBrush(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(SelectedRibbonLineBrushProperty);
        }

        public static void SetSelectedRibbonLineBrush(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(SelectedRibbonLineBrushProperty, value);
        }

        public static readonly DependencyProperty SelectedRibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("SelectedRibbonLineBrush", typeof(Brush), typeof(TabItemHelper));
        #endregion

        #region SelectedRibbonLineThickness
        public static double? GetSelectedRibbonLineThickness(TabItem tabItem)
        {
            return (double?)tabItem.GetValue(SelectedRibbonLineThicknessProperty);
        }

        public static void SetSelectedRibbonLineThickness(TabItem tabItem, double? value)
        {
            tabItem.SetValue(SelectedRibbonLineThicknessProperty, value);
        }

        public static readonly DependencyProperty SelectedRibbonLineThicknessProperty =
            DependencyProperty.RegisterAttached("SelectedRibbonLineThickness", typeof(double?), typeof(TabItemHelper));
        #endregion

        #region HeaderVerticalContentAlignment
        public static VerticalAlignment GetHeaderVerticalContentAlignment(TabItem tabItem)
        {
            return (VerticalAlignment)tabItem.GetValue(HeaderVerticalContentAlignmentProperty);
        }

        public static void SetHeaderVerticalContentAlignment(TabItem tabItem, VerticalAlignment value)
        {
            tabItem.SetValue(HeaderVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderVerticalContentAlignment", typeof(VerticalAlignment), typeof(TabItemHelper));
        #endregion

        #region HeaderHorizontalContentAlignment
        public static HorizontalAlignment GetHeaderHorizontalContentAlignment(TabItem tabItem)
        {
            return (HorizontalAlignment)tabItem.GetValue(HeaderHorizontalContentAlignmentProperty);
        }

        public static void SetHeaderHorizontalContentAlignment(TabItem tabItem, HorizontalAlignment value)
        {
            tabItem.SetValue(HeaderHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(TabItemHelper));
        #endregion

        #region RemoveButtonVisibility
        public static AuxiliaryButtonVisibility GetRemoveButtonVisibility(TabItem tabItem)
        {
            return (AuxiliaryButtonVisibility)tabItem.GetValue(RemoveButtonVisibilityProperty);
        }

        public static void SetRemoveButtonVisibility(TabItem tabItem, AuxiliaryButtonVisibility value)
        {
            tabItem.SetValue(RemoveButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty RemoveButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("RemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(TabItemHelper));
        #endregion

        #region SeparatorBrush
        public static Brush GetSeparatorBrush(TabItem tabItem)
        {
            return (Brush)tabItem.GetValue(SeparatorBrushProperty);
        }

        public static void SetSeparatorBrush(TabItem tabItem, Brush value)
        {
            tabItem.SetValue(SeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.RegisterAttached("SeparatorBrush", typeof(Brush), typeof(TabItemHelper));
        #endregion

        #region SeparatorThickness
        public static double GetSeparatorThickness(TabItem tabItem)
        {
            return (double)tabItem.GetValue(SeparatorThicknessProperty);
        }

        public static void SetSeparatorThickness(TabItem tabItem, double value)
        {
            tabItem.SetValue(SeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("SeparatorThickness", typeof(double), typeof(TabItemHelper));
        #endregion

        #region SeparatorMargin
        public static Thickness GetSeparatorMargin(TabItem tabItem)
        {
            return (Thickness)tabItem.GetValue(SeparatorMarginProperty);
        }

        public static void SetSeparatorMargin(TabItem tabItem, Thickness value)
        {
            tabItem.SetValue(SeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.RegisterAttached("SeparatorMargin", typeof(Thickness), typeof(TabItemHelper));
        #endregion

        #region SeparatorVisibility
        public static Visibility GetSeparatorVisibility(TabItem tabItem)
        {
            return (Visibility)tabItem.GetValue(SeparatorVisibilityProperty);
        }

        public static void SetSeparatorVisibility(TabItem tabItem, Visibility value)
        {
            tabItem.SetValue(SeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("SeparatorVisibility", typeof(Visibility), typeof(TabItemHelper));
        #endregion

        #region IsStyleless
        public static bool GetIsStyleless(TabItem tabItem)
        {
            return (bool)tabItem.GetValue(IsStylelessProperty);
        }

        public static void SetIsStyleless(TabItem tabItem, bool value)
        {
            tabItem.SetValue(IsStylelessProperty, value);
        }

        public static readonly DependencyProperty IsStylelessProperty =
            DependencyProperty.RegisterAttached("IsStyleless", typeof(bool), typeof(TabItemHelper));
        #endregion

        #endregion
    }
}
