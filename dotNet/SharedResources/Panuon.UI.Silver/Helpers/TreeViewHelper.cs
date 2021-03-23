using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class TreeViewHelper
    {
        #region Properties

        #region IconWidth
        public static double GetIconWidth(TreeView treeView)
        {
            return (double)treeView.GetValue(IconWidthProperty);
        }

        public static void SetIconWidth(TreeView treeView, double value)
        {
            treeView.SetValue(IconWidthProperty, value);
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.RegisterAttached("IconWidth", typeof(double), typeof(TreeViewHelper), new PropertyMetadata(double.NaN));
        #endregion 

        #region ToggleArrowToggleButtonStyle
        public static Style GetToggleArrowToggleButtonStyle(TreeView treeView)
        {
            return (Style)treeView.GetValue(ToggleArrowToggleButtonStyleProperty);
        }

        public static void SetToggleArrowToggleButtonStyle(TreeView treeView, Style value)
        {
            treeView.SetValue(ToggleArrowToggleButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ToggleArrowToggleButtonStyleProperty =
            DependencyProperty.RegisterAttached("ToggleArrowToggleButtonStyle", typeof(Style), typeof(TreeViewHelper));
        #endregion

        #region ToggleArrowPlacement
        public static ToggleArrowPlacement GetToggleArrowPlacement(TreeView treeView)
        {
            return (ToggleArrowPlacement)treeView.GetValue(ToggleArrowPlacementProperty);
        }

        public static void SetToggleArrowPlacement(TreeView treeView, ToggleArrowPlacement value)
        {
            treeView.SetValue(ToggleArrowPlacementProperty, value);
        }

        public static readonly DependencyProperty ToggleArrowPlacementProperty =
            DependencyProperty.RegisterAttached("ToggleArrowPlacement", typeof(ToggleArrowPlacement), typeof(TreeViewHelper));
        #endregion

        #region ItemsProperty

        #region ItemsIcon
        public static object GetItemsIcon(TreeView treeView)
        {
            return (object)treeView.GetValue(ItemsIconProperty);
        }

        public static void SetItemsIcon(TreeView treeView, object value)
        {
            treeView.SetValue(ItemsIconProperty, value);
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.RegisterAttached("ItemsIcon", typeof(object), typeof(TreeViewHelper));
        #endregion

        #region ItemsIconWidth
        public static double GetItemsIconWidth(TreeView treeView)
        {
            return (double)treeView.GetValue(ItemsIconWidthProperty);
        }

        public static void SetItemsIconWidth(TreeView treeView, double value)
        {
            treeView.SetValue(ItemsIconWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsIconWidthProperty =
            DependencyProperty.RegisterAttached("ItemsIconWidth", typeof(double), typeof(TreeViewHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsWidth
        public static double GetItemsWidth(TreeView treeView)
        {
            return (double)treeView.GetValue(ItemsWidthProperty);
        }

        public static void SetItemsWidth(TreeView treeView, double value)
        {
            treeView.SetValue(ItemsWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.RegisterAttached("ItemsWidth", typeof(double), typeof(TreeViewHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsHeight
        public static double GetItemsHeight(TreeView treeView)
        {
            return (double)treeView.GetValue(ItemsHeightProperty);
        }

        public static void SetItemsHeight(TreeView treeView, double value)
        {
            treeView.SetValue(ItemsHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.RegisterAttached("ItemsHeight", typeof(double), typeof(TreeViewHelper), new PropertyMetadata(30.0));
        #endregion

        #region ItemsMargin
        public static Thickness GetItemsMargin(TreeView treeView)
        {
            return (Thickness)treeView.GetValue(ItemsMarginProperty);
        }

        public static void SetItemsMargin(TreeView treeView, Thickness value)
        {
            treeView.SetValue(ItemsMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.RegisterAttached("ItemsMargin", typeof(Thickness), typeof(TreeViewHelper));
        #endregion

        #region ItemsPadding
        public static Thickness GetItemsPadding(TreeView treeView)
        {
            return (Thickness)treeView.GetValue(ItemsPaddingProperty);
        }

        public static void SetItemsPadding(TreeView treeView, Thickness value)
        {
            treeView.SetValue(ItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.RegisterAttached("ItemsPadding", typeof(Thickness), typeof(TreeViewHelper));
        #endregion

        #region ItemsCornerRadius
        public static CornerRadius GetItemsCornerRadius(TreeView treeView)
        {
            return (CornerRadius)treeView.GetValue(ItemsCornerRadiusProperty);
        }

        public static void SetItemsCornerRadius(TreeView treeView, CornerRadius value)
        {
            treeView.SetValue(ItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCornerRadius", typeof(CornerRadius), typeof(TreeViewHelper));
        #endregion

        #region ItemsBackground
        public static Brush GetItemsBackground(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsBackgroundProperty);
        }

        public static void SetItemsBackground(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(TreeViewHelper));

        #endregion

        #region ItemsBorderBrush
        public static Brush GetItemsBorderBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsBorderBrushProperty);
        }

        public static void SetItemsBorderBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsBorderBrush", typeof(Brush), typeof(TreeViewHelper));

        #endregion

        #region ItemsBorderThickness
        public static Thickness GetItemsBorderThickness(TreeView treeView)
        {
            return (Thickness)treeView.GetValue(ItemsBorderThicknessProperty);
        }

        public static void SetItemsBorderThickness(TreeView treeView, Thickness value)
        {
            treeView.SetValue(ItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsBorderThickness", typeof(Thickness), typeof(TreeViewHelper));
        #endregion

        #region ItemsToggleBrush
        public static Brush GetItemsToggleBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsToggleBrushProperty);
        }

        public static void SetItemsToggleBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsToggleBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsToggleBrushProperty =
            DependencyProperty.RegisterAttached("ItemsToggleBrush", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsHoverBackground
        public static Brush GetItemsHoverBackground(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsHoverBackgroundProperty);
        }

        public static void SetItemsHoverBackground(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBackground", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsHoverForeground
        public static Brush GetItemsHoverForeground(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsHoverForegroundProperty);
        }

        public static void SetItemsHoverForeground(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverForeground", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsHoverBorderBrush
        public static Brush GetItemsHoverBorderBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsHoverBorderBrushProperty);
        }

        public static void SetItemsHoverBorderBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderBrush", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsHoverToggleBrush
        public static Brush GetItemsHoverToggleBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsHoverToggleBrushProperty);
        }

        public static void SetItemsHoverToggleBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsHoverToggleBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverToggleBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverToggleBrush", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsSelectedBackground
        public static Brush GetItemsSelectedBackground(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsSelectedBackgroundProperty);
        }

        public static void SetItemsSelectedBackground(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsSelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBackground", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsSelectedForeground
        public static Brush GetItemsSelectedForeground(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsSelectedForegroundProperty);
        }

        public static void SetItemsSelectedForeground(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsSelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedForeground", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsSelectedBorderBrush
        public static Brush GetItemsSelectedBorderBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsSelectedBorderBrushProperty);
        }

        public static void SetItemsSelectedBorderBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsSelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderBrush", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsSelectedBorderThickness
        public static Thickness? GetItemsSelectedBorderThickness(TreeView treeView)
        {
            return (Thickness?)treeView.GetValue(ItemsSelectedBorderThicknessProperty);
        }

        public static void SetItemsSelectedBorderThickness(TreeView treeView, Thickness? value)
        {
            treeView.SetValue(ItemsSelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderThickness", typeof(Thickness?), typeof(TreeViewHelper));
        #endregion

        #region ItemsSelectedToggleBrush
        public static Brush GetItemsSelectedToggleBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsSelectedToggleBrushProperty);
        }

        public static void SetItemsSelectedToggleBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsSelectedToggleBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedToggleBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedToggleBrush", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsExpandedToggleBrush
        public static Brush GetItemsExpandedToggleBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsExpandedToggleBrushProperty);
        }

        public static void SetItemsExpandedToggleBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsExpandedToggleBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsExpandedToggleBrushProperty =
            DependencyProperty.RegisterAttached("ItemsExpandedToggleBrush", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsSeparatorBrush
        public static Brush GetItemsSeparatorBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsSeparatorBrushProperty);
        }

        public static void SetItemsSeparatorBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorBrush", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsSeparatorThickness
        public static double GetItemsSeparatorThickness(TreeView treeView)
        {
            return (double)treeView.GetValue(ItemsSeparatorThicknessProperty);
        }

        public static void SetItemsSeparatorThickness(TreeView treeView, double value)
        {
            treeView.SetValue(ItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorThickness", typeof(double), typeof(TreeViewHelper));
        #endregion

        #region ItemsSeparatorMargin
        public static Thickness GetItemsSeparatorMargin(TreeView treeView)
        {
            return (Thickness)treeView.GetValue(ItemsSeparatorMarginProperty);
        }

        public static void SetItemsSeparatorMargin(TreeView treeView, Thickness value)
        {
            treeView.SetValue(ItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorMargin", typeof(Thickness), typeof(TreeViewHelper));
        #endregion

        #region ItemsSeparatorVisibility
        public static Visibility GetItemsSeparatorVisibility(TreeView treeView)
        {
            return (Visibility)treeView.GetValue(ItemsSeparatorVisibilityProperty);
        }

        public static void SetItemsSeparatorVisibility(TreeView treeView, Visibility value)
        {
            treeView.SetValue(ItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorVisibility", typeof(Visibility), typeof(TreeViewHelper));
        #endregion

        #region ItemsRulerLineBrush
        public static Brush GetItemsRulerLineBrush(TreeView treeView)
        {
            return (Brush)treeView.GetValue(ItemsRulerLineBrushProperty);
        }

        public static void SetItemsRulerLineBrush(TreeView treeView, Brush value)
        {
            treeView.SetValue(ItemsRulerLineBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsRulerLineBrushProperty =
            DependencyProperty.RegisterAttached("ItemsRulerLineBrush", typeof(Brush), typeof(TreeViewHelper));
        #endregion

        #region ItemsRulerLineThickness
        public static double GetItemsRulerLineThickness(TreeView treeView)
        {
            return (double)treeView.GetValue(ItemsRulerLineThicknessProperty);
        }

        public static void SetItemsRulerLineThickness(TreeView treeView, double value)
        {
            treeView.SetValue(ItemsRulerLineThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsRulerLineThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsRulerLineThickness", typeof(double), typeof(TreeViewHelper));
        #endregion

        #region ItemsRulerLineDashArray
        public static DoubleCollection GetItemsRulerLineDashArray(TreeView treeView)
        {
            return (DoubleCollection)treeView.GetValue(ItemsRulerLineDashArrayProperty);
        }

        public static void SetItemsRulerLineDashArray(TreeView treeView, DoubleCollection value)
        {
            treeView.SetValue(ItemsRulerLineDashArrayProperty, value);
        }

        public static readonly DependencyProperty ItemsRulerLineDashArrayProperty =
            DependencyProperty.RegisterAttached("ItemsRulerLineDashArray", typeof(DoubleCollection), typeof(TreeViewHelper));
        #endregion

        #region ItemsRulerLineVisiblity
        public static RulerLineVisiblity GetItemsRulerLineVisiblity(TreeView treeView)
        {
            return (RulerLineVisiblity)treeView.GetValue(ItemsRulerLineVisiblityProperty);
        }

        public static void SetItemsRulerLineVisiblity(TreeView treeView, RulerLineVisiblity value)
        {
            treeView.SetValue(ItemsRulerLineVisiblityProperty, value);
        }

        public static readonly DependencyProperty ItemsRulerLineVisiblityProperty =
            DependencyProperty.RegisterAttached("ItemsRulerLineVisiblity", typeof(RulerLineVisiblity), typeof(TreeViewHelper));
        #endregion

        #endregion

        #endregion
    }
}
