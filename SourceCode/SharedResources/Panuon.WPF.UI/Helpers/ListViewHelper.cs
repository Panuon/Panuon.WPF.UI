using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ListViewHelper
    {
        #region Properties

        #region ResizeThumbThickness
        public static double GetResizeThumbThickness(ListView listView)
        {
            return (double)listView.GetValue(ResizeThumbThicknessProperty);
        }

        public static void SetResizeThumbThickness(ListView listView, double value)
        {
            listView.SetValue(ResizeThumbThicknessProperty, value);
        }

        public static readonly DependencyProperty ResizeThumbThicknessProperty =
            DependencyProperty.RegisterAttached("ResizeThumbThickness", typeof(double), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderHeight
        public static double GetColumnHeaderHeight(ListView listView)
        {
            return (double)listView.GetValue(ColumnHeaderHeightProperty);
        }

        public static void SetColumnHeaderHeight(ListView listView, double value)
        {
            listView.SetValue(ColumnHeaderHeightProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHeightProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHeight", typeof(double), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderPadding
        public static Thickness GetColumnHeaderPadding(ListView listView)
        {
            return (Thickness)listView.GetValue(ColumnHeaderPaddingProperty);
        }

        public static void SetColumnHeaderPadding(ListView listView, Thickness value)
        {
            listView.SetValue(ColumnHeaderPaddingProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPaddingProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPadding", typeof(Thickness), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderFontSize
        public static double GetColumnHeaderFontSize(ListView listView)
        {
            return (double)listView.GetValue(ColumnHeaderFontSizeProperty);
        }

        public static void SetColumnHeaderFontSize(ListView listView, double value)
        {
            listView.SetValue(ColumnHeaderFontSizeProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderFontSizeProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderFontSize", typeof(double), typeof(ListViewHelper), new PropertyMetadata(SystemFonts.MessageFontSize));
        #endregion

        #region ColumnHeaderFontWeight
        public static FontWeight GetColumnHeaderFontWeight(ListView listView)
        {
            return (FontWeight)listView.GetValue(ColumnHeaderFontWeightProperty);
        }

        public static void SetColumnHeaderFontWeight(ListView listView, FontWeight value)
        {
            listView.SetValue(ColumnHeaderFontWeightProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderFontWeightProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderFontWeight", typeof(FontWeight), typeof(ListViewHelper), new PropertyMetadata(SystemFonts.MessageFontWeight));
        #endregion

        #region ColumnHeaderForeground
        public static Brush GetColumnHeaderForeground(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderForegroundProperty);
        }

        public static void SetColumnHeaderForeground(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderForegroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderForegroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderForeground", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderBackground
        public static Brush GetColumnHeaderBackground(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderBackgroundProperty);
        }

        public static void SetColumnHeaderBackground(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderBackgroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderBackground", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderSeparatorBrush
        public static Brush GetColumnHeaderSeparatorBrush(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderSeparatorBrushProperty);
        }

        public static void SetColumnHeaderSeparatorBrush(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderSeparatorBrush", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderSeparatorVisibility
        public static Visibility GetColumnHeaderSeparatorVisibility(ListView listView)
        {
            return (Visibility)listView.GetValue(ColumnHeaderSeparatorVisibilityProperty);
        }

        public static void SetColumnHeaderSeparatorVisibility(ListView listView, Visibility value)
        {
            listView.SetValue(ColumnHeaderSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderSeparatorVisibility", typeof(Visibility), typeof(ListViewHelper), new PropertyMetadata(Visibility.Visible));
        #endregion

        #region ColumnHeaderHoverBackground
        public static Brush GetColumnHeaderHoverBackground(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderHoverBackgroundProperty);
        }

        public static void SetColumnHeaderHoverBackground(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHoverBackground", typeof(Brush), typeof(ListViewHelper));


        #endregion

        #region ColumnHeaderHoverForeground
        public static Brush GetColumnHeaderHoverForeground(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderHoverForegroundProperty);
        }

        public static void SetColumnHeaderHoverForeground(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHoverForeground", typeof(Brush), typeof(ListViewHelper));


        #endregion

        #region ColumnHeaderHoverBorderBrush
        public static Brush GetColumnHeaderHoverBorderBrush(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderHoverBorderBrushProperty);
        }

        public static void SetColumnHeaderHoverBorderBrush(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHoverBorderBrush", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderHoverBorderThickness
        public static Thickness? GetColumnHeaderHoverBorderThickness(ListView listView)
        {
            return (Thickness?)listView.GetValue(ColumnHeaderHoverBorderThicknessProperty);
        }

        public static void SetColumnHeaderHoverBorderThickness(ListView listView, Thickness? value)
        {
            listView.SetValue(ColumnHeaderHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHoverBorderThickness", typeof(Thickness?), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderClickBackground
        public static Brush GetColumnHeaderClickBackground(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderClickBackgroundProperty);
        }

        public static void SetColumnHeaderClickBackground(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderClickBackgroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderClickBackground", typeof(Brush), typeof(ListViewHelper));


        #endregion

        #region ColumnHeaderClickForeground
        public static Brush GetColumnHeaderClickForeground(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderClickForegroundProperty);
        }

        public static void SetColumnHeaderClickForeground(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderClickForegroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderClickForegroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderClickForeground", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderClickBorderBrush
        public static Brush GetColumnHeaderClickBorderBrush(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderClickBorderBrushProperty);
        }

        public static void SetColumnHeaderClickBorderBrush(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderClickBorderBrush", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderClickBorderThickness
        public static Thickness? GetColumnHeaderClickBorderThickness(ListView listView)
        {
            return (Thickness?)listView.GetValue(ColumnHeaderClickBorderThicknessProperty);
        }

        public static void SetColumnHeaderClickBorderThickness(ListView listView, Thickness? value)
        {
            listView.SetValue(ColumnHeaderClickBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderClickBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderClickBorderThickness", typeof(Thickness?), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderPanelSeparatorBrush
        public static Brush GetColumnHeaderPanelSeparatorBrush(ListView listView)
        {
            return (Brush)listView.GetValue(ColumnHeaderPanelSeparatorBrushProperty);
        }

        public static void SetColumnHeaderPanelSeparatorBrush(ListView listView, Brush value)
        {
            listView.SetValue(ColumnHeaderPanelSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelSeparatorBrush", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderPanelSeparatorVisibility
        public static Visibility GetColumnHeaderPanelSeparatorVisibility(ListView listView)
        {
            return (Visibility)listView.GetValue(ColumnHeaderPanelSeparatorVisibilityProperty);
        }

        public static void SetColumnHeaderPanelSeparatorVisibility(ListView listView, Visibility value)
        {
            listView.SetValue(ColumnHeaderPanelSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelSeparatorVisibility", typeof(Visibility), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderHorizontalContentAlignment
        public static HorizontalAlignment GetColumnHeaderHorizontalContentAlignment(ListView listView)
        {
            return (HorizontalAlignment)listView.GetValue(ColumnHeaderHorizontalContentAlignmentProperty);
        }

        public static void SetColumnHeaderHorizontalContentAlignment(ListView listView, HorizontalAlignment value)
        {
            listView.SetValue(ColumnHeaderHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(ListViewHelper));
        #endregion

        #region ColumnHeaderVerticalContentAlignment
        public static VerticalAlignment GetColumnHeaderVerticalContentAlignment(ListView listView)
        {
            return (VerticalAlignment)listView.GetValue(ColumnHeaderVerticalContentAlignmentProperty);
        }

        public static void SetColumnHeaderVerticalContentAlignment(ListView listView, VerticalAlignment value)
        {
            listView.SetValue(ColumnHeaderVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderVerticalContentAlignment", typeof(VerticalAlignment), typeof(ListViewHelper));
        #endregion

        #region SelectedItems
        public static IList GetSelectedItems(ListView listView)
        {
            return listView.SelectedItems;
        }

        public static void SetSelectedItems(ListView listView, IList value)
        {
            throw new Exception("ListViewHelper.SelectedItems is a read-only property.");
        }

        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.RegisterAttached("SelectedItems", typeof(IList), typeof(ListViewHelper));
        #endregion

        #region Items Properties

        #region ItemsHeight
        public static double GetItemsHeight(ListView listView)
        {
            return (double)listView.GetValue(ItemsHeightProperty);
        }

        public static void SetItemsHeight(ListView listView, double value)
        {
            listView.SetValue(ItemsHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.RegisterAttached("ItemsHeight", typeof(double), typeof(ListViewHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsPadding
        public static Thickness GetItemsPadding(ListView listView)
        {
            return (Thickness)listView.GetValue(ItemsPaddingProperty);
        }

        public static void SetItemsPadding(ListView listView, Thickness value)
        {
            listView.SetValue(ItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.RegisterAttached("ItemsPadding", typeof(Thickness), typeof(ListViewHelper));
        #endregion

        #region ItemsMargin
        public static Thickness GetItemsMargin(ListView listView)
        {
            return (Thickness)listView.GetValue(ItemsMarginProperty);
        }

        public static void SetItemsMargin(ListView listView, Thickness value)
        {
            listView.SetValue(ItemsMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.RegisterAttached("ItemsMargin", typeof(Thickness), typeof(ListViewHelper));
        #endregion

        #region ItemsMinHeight
        public static double GetItemsMinHeight(ListView listView)
        {
            return (double)listView.GetValue(ItemsMinHeightProperty);
        }

        public static void SetItemsMinHeight(ListView listView, double value)
        {
            listView.SetValue(ItemsMinHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsMinHeightProperty =
            DependencyProperty.RegisterAttached("ItemsMinHeight", typeof(double), typeof(ListViewHelper), new PropertyMetadata(0d));
        #endregion

        #region ItemsMaxHeight
        public static double GetItemsMaxHeight(ListView listView)
        {
            return (double)listView.GetValue(ItemsMaxHeightProperty);
        }

        public static void SetItemsMaxHeight(ListView listView, double value)
        {
            listView.SetValue(ItemsMaxHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsMaxHeightProperty =
            DependencyProperty.RegisterAttached("ItemsMaxHeight", typeof(double), typeof(ListViewHelper), new PropertyMetadata(double.PositiveInfinity));
        #endregion

        #region ItemsCornerRadius
        public static CornerRadius GetItemsCornerRadius(ListView listView)
        {
            return (CornerRadius)listView.GetValue(ItemsCornerRadiusProperty);
        }

        public static void SetItemsCornerRadius(ListView listView, CornerRadius value)
        {
            listView.SetValue(ItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCornerRadius", typeof(CornerRadius), typeof(ListViewHelper));
        #endregion

        #region ItemsBackground
        public static Brush GetItemsBackground(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsBackgroundProperty);
        }

        public static void SetItemsBackground(ListView listView, Brush value)
        {
            listView.SetValue(ItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(ListViewHelper), new PropertyMetadata(Brushes.Transparent));

        #endregion

        #region ItemsBorderBrush
        public static Brush GetItemsBorderBrush(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsBorderBrushProperty);
        }

        public static void SetItemsBorderBrush(ListView listView, Brush value)
        {
            listView.SetValue(ItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsBorderBrush", typeof(Brush), typeof(ListViewHelper));

        #endregion

        #region ItemsBorderThickness
        public static Thickness GetItemsBorderThickness(ListView listView)
        {
            return (Thickness)listView.GetValue(ItemsBorderThicknessProperty);
        }

        public static void SetItemsBorderThickness(ListView listView, Thickness value)
        {
            listView.SetValue(ItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsBorderThickness", typeof(Thickness), typeof(ListViewHelper));
        #endregion

        #region ItemsHoverBackground
        public static Brush GetItemsHoverBackground(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsHoverBackgroundProperty);
        }

        public static void SetItemsHoverBackground(ListView listView, Brush value)
        {
            listView.SetValue(ItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBackground", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ItemsHoverForeground
        public static Brush GetItemsHoverForeground(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsHoverForegroundProperty);
        }

        public static void SetItemsHoverForeground(ListView listView, Brush value)
        {
            listView.SetValue(ItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverForeground", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ItemsHoverBorderBrush
        public static Brush GetItemsHoverBorderBrush(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsHoverBorderBrushProperty);
        }

        public static void SetItemsHoverBorderBrush(ListView listView, Brush value)
        {
            listView.SetValue(ItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderBrush", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ItemsSelectedBackground
        public static Brush GetItemsSelectedBackground(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsSelectedBackgroundProperty);
        }

        public static void SetItemsSelectedBackground(ListView listView, Brush value)
        {
            listView.SetValue(ItemsSelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBackground", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ItemsSelectedForeground
        public static Brush GetItemsSelectedForeground(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsSelectedForegroundProperty);
        }

        public static void SetItemsSelectedForeground(ListView listView, Brush value)
        {
            listView.SetValue(ItemsSelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedForeground", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ItemsSelectedBorderBrush
        public static Brush GetItemsSelectedBorderBrush(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsSelectedBorderBrushProperty);
        }

        public static void SetItemsSelectedBorderBrush(ListView listView, Brush value)
        {
            listView.SetValue(ItemsSelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderBrush", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ItemsSelectedBorderThickness
        public static Thickness? GetItemsSelectedBorderThickness(ListView listView)
        {
            return (Thickness?)listView.GetValue(ItemsSelectedBorderThicknessProperty);
        }

        public static void SetItemsSelectedBorderThickness(ListView listView, Thickness? value)
        {
            listView.SetValue(ItemsSelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderThickness", typeof(Thickness?), typeof(ListViewHelper));
        #endregion

        #region ItemsSeparatorBrush
        public static Brush GetItemsSeparatorBrush(ListView listView)
        {
            return (Brush)listView.GetValue(ItemsSeparatorBrushProperty);
        }

        public static void SetItemsSeparatorBrush(ListView listView, Brush value)
        {
            listView.SetValue(ItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorBrush", typeof(Brush), typeof(ListViewHelper));
        #endregion

        #region ItemsSeparatorThickness
        public static double GetItemsSeparatorThickness(ListView listView)
        {
            return (double)listView.GetValue(ItemsSeparatorThicknessProperty);
        }

        public static void SetItemsSeparatorThickness(ListView listView, double value)
        {
            listView.SetValue(ItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorThickness", typeof(double), typeof(ListViewHelper));
        #endregion

        #region ItemsSeparatorMargin
        public static Thickness GetItemsSeparatorMargin(ListView listView)
        {
            return (Thickness)listView.GetValue(ItemsSeparatorMarginProperty);
        }

        public static void SetItemsSeparatorMargin(ListView listView, Thickness value)
        {
            listView.SetValue(ItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorMargin", typeof(Thickness), typeof(ListViewHelper));
        #endregion

        #region ItemsSeparatorVisibility
        public static Visibility GetItemsSeparatorVisibility(ListView listView)
        {
            return (Visibility)listView.GetValue(ItemsSeparatorVisibilityProperty);
        }

        public static void SetItemsSeparatorVisibility(ListView listView, Visibility value)
        {
            listView.SetValue(ItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorVisibility", typeof(Visibility), typeof(ListViewHelper));
        #endregion

        #endregion

        #endregion

        #region Internal Properties

        #region Hook
        internal static bool GetHook(ListView listView)
        {
            return (bool)listView.GetValue(HookProperty);
        }

        internal static void SetHook(ListView listView, bool value)
        {
            listView.SetValue(HookProperty, value);
        }

        internal static readonly DependencyProperty HookProperty =
            DependencyProperty.RegisterAttached("Hook", typeof(bool), typeof(ListViewHelper), new PropertyMetadata(OnHookChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var listView = (ListView)d;

            if ((bool)e.NewValue)
            {
                listView.SetValue(SelectedItemsProperty, listView.SelectedItems);
            }
        }
        #endregion

        #region Functions
        #endregion
    }
}
