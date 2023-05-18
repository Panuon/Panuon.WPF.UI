using Panuon.WPF.UI.Internal;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class TreeViewItemHelper
    {
        #region Property

        #region Icon
        public static object GetIcon(TreeViewItem treeViewItem)
        {
            return (object)treeViewItem.GetValue(IconProperty);
        }

        public static void SetIcon(TreeViewItem treeViewItem, object value)
        {
            treeViewItem.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(TreeViewItemHelper));
        #endregion

        #region Height
        public static double GetHeight(TreeViewItem treeViewItem)
        {
            return (double)treeViewItem.GetValue(HeightProperty);
        }

        public static void SetHeight(TreeViewItem treeViewItem, double value)
        {
            treeViewItem.SetValue(HeightProperty, value);
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.RegisterAttached("Height", typeof(double), typeof(TreeViewItemHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(TreeViewItem treeViewItem)
        {
            return (CornerRadius)treeViewItem.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(TreeViewItem treeViewItem, CornerRadius value)
        {
            treeViewItem.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(TreeViewItem treeViewItem)
        {
            return (Color?)treeViewItem.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(TreeViewItem treeViewItem, Color? value)
        {
            treeViewItem.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region ToggleBrush
        public static Brush GetToggleBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(ToggleBrushProperty);
        }

        public static void SetToggleBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(ToggleBrushProperty, value);
        }

        public static readonly DependencyProperty ToggleBrushProperty =
            VisualStateHelper.ToggleBrushProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region HoverBorderThickness
        public static Thickness? GetHoverBorderThickness(TreeViewItem treeViewItem)
        {
            return (Thickness?)treeViewItem.GetValue(HoverBorderThicknessProperty);
        }

        public static void SetHoverBorderThickness(TreeViewItem treeViewItem, Thickness? value)
        {
            treeViewItem.SetValue(HoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region HoverCornerRadius
        public static CornerRadius? GetHoverCornerRadius(TreeViewItem treeViewItem)
        {
            return (CornerRadius?)treeViewItem.GetValue(HoverCornerRadiusProperty);
        }

        public static void SetHoverCornerRadius(TreeViewItem treeViewItem, CornerRadius? value)
        {
            treeViewItem.SetValue(HoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region HoverShadowColor
        public static Color? GetHoverShadowColor(TreeViewItem treeViewItem)
        {
            return (Color?)treeViewItem.GetValue(HoverShadowColorProperty);
        }

        public static void SetHoverShadowColor(TreeViewItem treeViewItem, Color? value)
        {
            treeViewItem.SetValue(HoverShadowColorProperty, value);
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region HoverToggleBrush
        public static Brush GetHoverToggleBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(HoverToggleBrushProperty);
        }

        public static void SetHoverToggleBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(HoverToggleBrushProperty, value);
        }

        public static readonly DependencyProperty HoverToggleBrushProperty =
            VisualStateHelper.HoverToggleBrushProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region SelectedBackground
        public static Brush GetSelectedBackground(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(SelectedBackgroundProperty);
        }

        public static void SetSelectedBackground(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(SelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("SelectedBackground", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region SelectedForeground
        public static Brush GetSelectedForeground(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(SelectedForegroundProperty);
        }

        public static void SetSelectedForeground(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(SelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.RegisterAttached("SelectedForeground", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region SelectedBorderBrush
        public static Brush GetSelectedBorderBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(SelectedBorderBrushProperty);
        }

        public static void SetSelectedBorderBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(SelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("SelectedBorderBrush", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region SelectedBorderThickness
        public static Thickness? GetSelectedBorderThickness(TreeViewItem treeViewItem)
        {
            return (Thickness?)treeViewItem.GetValue(SelectedBorderThicknessProperty);
        }

        public static void SetSelectedBorderThickness(TreeViewItem treeViewItem, Thickness? value)
        {
            treeViewItem.SetValue(SelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SelectedBorderThickness", typeof(Thickness?), typeof(TreeViewItemHelper));
        #endregion

        #region SelectedCornerRadius
        public static CornerRadius? GetSelectedCornerRadius(TreeViewItem treeViewItem)
        {
            return (CornerRadius?)treeViewItem.GetValue(SelectedCornerRadiusProperty);
        }

        public static void SetSelectedCornerRadius(TreeViewItem treeViewItem, CornerRadius? value)
        {
            treeViewItem.SetValue(SelectedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SelectedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SelectedCornerRadius", typeof(CornerRadius?), typeof(TreeViewItemHelper));
        #endregion

        #region SelectedShadowColor
        public static Color? GetSelectedShadowColor(TreeViewItem treeViewItem)
        {
            return (Color?)treeViewItem.GetValue(SelectedShadowColorProperty);
        }

        public static void SetSelectedShadowColor(TreeViewItem treeViewItem, Color? value)
        {
            treeViewItem.SetValue(SelectedShadowColorProperty, value);
        }

        public static readonly DependencyProperty SelectedShadowColorProperty =
            VisualStateHelper.SelectedShadowColorProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region SelectedToggleBrush
        public static Brush GetSelectedToggleBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(SelectedToggleBrushProperty);
        }

        public static void SetSelectedToggleBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(SelectedToggleBrushProperty, value);
        }

        public static readonly DependencyProperty SelectedToggleBrushProperty =
            DependencyProperty.RegisterAttached("SelectedToggleBrush", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region ExpandedBackground
        public static Brush GetExpandedBackground(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(ExpandedBackgroundProperty);
        }

        public static void SetExpandedBackground(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(ExpandedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ExpandedBackgroundProperty =
            DependencyProperty.RegisterAttached("ExpandedBackground", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region ExpandedForeground
        public static Brush GetExpandedForeground(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(ExpandedForegroundProperty);
        }

        public static void SetExpandedForeground(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(ExpandedForegroundProperty, value);
        }

        public static readonly DependencyProperty ExpandedForegroundProperty =
            DependencyProperty.RegisterAttached("ExpandedForeground", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region ExpandedBorderBrush
        public static Brush GetExpandedBorderBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(ExpandedBorderBrushProperty);
        }

        public static void SetExpandedBorderBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(ExpandedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ExpandedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ExpandedBorderBrush", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region ExpandedBorderThickness
        public static Thickness? GetExpandedBorderThickness(TreeViewItem treeViewItem)
        {
            return (Thickness?)treeViewItem.GetValue(ExpandedBorderThicknessProperty);
        }

        public static void SetExpandedBorderThickness(TreeViewItem treeViewItem, Thickness? value)
        {
            treeViewItem.SetValue(ExpandedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ExpandedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ExpandedBorderThickness", typeof(Thickness?), typeof(TreeViewItemHelper));
        #endregion

        #region ExpandedCornerRadius
        public static CornerRadius? GetExpandedCornerRadius(TreeViewItem treeViewItem)
        {
            return (CornerRadius?)treeViewItem.GetValue(ExpandedCornerRadiusProperty);
        }

        public static void SetExpandedCornerRadius(TreeViewItem treeViewItem, CornerRadius? value)
        {
            treeViewItem.SetValue(ExpandedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ExpandedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ExpandedCornerRadius", typeof(CornerRadius?), typeof(TreeViewItemHelper));
        #endregion

        #region ExpandedShadowColor
        public static Color? GetExpandedShadowColor(TreeViewItem treeViewItem)
        {
            return (Color?)treeViewItem.GetValue(ExpandedShadowColorProperty);
        }

        public static void SetExpandedShadowColor(TreeViewItem treeViewItem, Color? value)
        {
            treeViewItem.SetValue(ExpandedShadowColorProperty, value);
        }

        public static readonly DependencyProperty ExpandedShadowColorProperty =
            VisualStateHelper.ExpandedShadowColorProperty.AddOwner(typeof(TreeViewItemHelper));
        #endregion

        #region ExpandedToggleBrush
        public static Brush GetExpandedToggleBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(ExpandedToggleBrushProperty);
        }

        public static void SetExpandedToggleBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(ExpandedToggleBrushProperty, value);
        }

        public static readonly DependencyProperty ExpandedToggleBrushProperty =
            DependencyProperty.RegisterAttached("ExpandedToggleBrush", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region SeparatorBrush
        public static Brush GetSeparatorBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(SeparatorBrushProperty);
        }

        public static void SetSeparatorBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(SeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.RegisterAttached("SeparatorBrush", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region SeparatorThickness
        public static double GetSeparatorThickness(TreeViewItem treeViewItem)
        {
            return (double)treeViewItem.GetValue(SeparatorThicknessProperty);
        }

        public static void SetSeparatorThickness(TreeViewItem treeViewItem, double value)
        {
            treeViewItem.SetValue(SeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("SeparatorThickness", typeof(double), typeof(TreeViewItemHelper));
        #endregion

        #region SeparatorMargin
        public static Thickness GetSeparatorMargin(TreeViewItem treeViewItem)
        {
            return (Thickness)treeViewItem.GetValue(SeparatorMarginProperty);
        }

        public static void SetSeparatorMargin(TreeViewItem treeViewItem, Thickness value)
        {
            treeViewItem.SetValue(SeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.RegisterAttached("SeparatorMargin", typeof(Thickness), typeof(TreeViewItemHelper));
        #endregion

        #region SeparatorVisibility
        public static Visibility GetSeparatorVisibility(TreeViewItem treeViewItem)
        {
            return (Visibility)treeViewItem.GetValue(SeparatorVisibilityProperty);
        }

        public static void SetSeparatorVisibility(TreeViewItem treeViewItem, Visibility value)
        {
            treeViewItem.SetValue(SeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("SeparatorVisibility", typeof(Visibility), typeof(TreeViewItemHelper));
        #endregion

        #region RulerLineBrush
        public static Brush GetRulerLineBrush(TreeViewItem treeViewItem)
        {
            return (Brush)treeViewItem.GetValue(RulerLineBrushProperty);
        }

        public static void SetRulerLineBrush(TreeViewItem treeViewItem, Brush value)
        {
            treeViewItem.SetValue(RulerLineBrushProperty, value);
        }

        public static readonly DependencyProperty RulerLineBrushProperty =
            DependencyProperty.RegisterAttached("RulerLineBrush", typeof(Brush), typeof(TreeViewItemHelper));
        #endregion

        #region RulerLineThickness
        public static double GetRulerLineThickness(TreeViewItem treeViewItem)
        {
            return (double)treeViewItem.GetValue(RulerLineThicknessProperty);
        }

        public static void SetRulerLineThickness(TreeViewItem treeViewItem, double value)
        {
            treeViewItem.SetValue(RulerLineThicknessProperty, value);
        }

        public static readonly DependencyProperty RulerLineThicknessProperty =
            DependencyProperty.RegisterAttached("RulerLineThickness", typeof(double), typeof(TreeViewItemHelper));
        #endregion

        #region RulerLineDashArray
        public static DoubleCollection GetRulerLineDashArray(TreeViewItem treeViewItem)
        {
            return (DoubleCollection)treeViewItem.GetValue(RulerLineDashArrayProperty);
        }

        public static void SetRulerLineDashArray(TreeViewItem treeViewItem, DoubleCollection value)
        {
            treeViewItem.SetValue(RulerLineDashArrayProperty, value);
        }

        public static readonly DependencyProperty RulerLineDashArrayProperty =
            DependencyProperty.RegisterAttached("RulerLineDashArray", typeof(DoubleCollection), typeof(TreeViewItemHelper));
        #endregion

        #region RulerLineVisiblity
        public static RulerLineVisiblity GetRulerLineVisiblity(TreeViewItem treeViewItem)
        {
            return (RulerLineVisiblity)treeViewItem.GetValue(RulerLineVisiblityProperty);
        }

        public static void SetRulerLineVisiblity(TreeViewItem treeViewItem, RulerLineVisiblity value)
        {
            treeViewItem.SetValue(RulerLineVisiblityProperty, value);
        }

        public static readonly DependencyProperty RulerLineVisiblityProperty =
            DependencyProperty.RegisterAttached("RulerLineVisiblity", typeof(RulerLineVisiblity), typeof(TreeViewItemHelper));
        #endregion

        #region IsMouseDirectlyOver
        public static bool GetIsMouseDirectlyOver(TreeViewItem treeViewItem)
        {
            return (bool)treeViewItem.GetValue(IsMouseDirectlyOverProperty);
        }

        public static void SetIsMouseDirectlyOver(TreeViewItem treeViewItem, bool value)
        {
            throw new Exception("TreeViewItemHelper.IsMouseDirectlyOver is a read-only property.");
        }

        public static readonly DependencyProperty IsMouseDirectlyOverProperty =
            DependencyProperty.RegisterAttached("IsMouseDirectlyOver", typeof(bool), typeof(TreeViewItemHelper));
        #endregion

        #region IsStyleless
        public static bool GetIsStyleless(TreeViewItem treeViewItem)
        {
            return (bool)treeViewItem.GetValue(IsStylelessProperty);
        }

        public static void SetIsStyleless(TreeViewItem treeViewItem, bool value)
        {
            treeViewItem.SetValue(IsStylelessProperty, value);
        }

        public static readonly DependencyProperty IsStylelessProperty =
            DependencyProperty.RegisterAttached("IsStyleless", typeof(bool), typeof(TreeViewItemHelper));
        #endregion
        

        #endregion

        #region Internal Property

        #region InternalPadding
        internal static Thickness GetInternalPadding(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(InternalPaddingProperty);
        }

        internal static void SetInternalPadding(DependencyObject obj, Thickness value)
        {
            obj.SetValue(InternalPaddingProperty, value);
        }

        internal static readonly DependencyProperty InternalPaddingProperty =
            DependencyProperty.RegisterAttached("InternalPadding", typeof(Thickness), typeof(TreeViewItemHelper), new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #endregion

    }
}
