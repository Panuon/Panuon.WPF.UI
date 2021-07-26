using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class ContextMenuHelper
    {
        #region Properties

        #region CheckedIconTemplate
        public static DataTemplate GetCheckedIconTemplate(ContextMenu contextMenu)
        {
            return (DataTemplate)contextMenu.GetValue(CheckedIconTemplateProperty);
        }

        public static void SetCheckedIconTemplate(ContextMenu contextMenu, DataTemplate value)
        {
            contextMenu.SetValue(CheckedIconTemplateProperty, value);
        }

        public static readonly DependencyProperty CheckedIconTemplateProperty =
            DependencyProperty.RegisterAttached("CheckedIconTemplate", typeof(DataTemplate), typeof(ContextMenuHelper));
        #endregion

        #region ArrowIconTemplate
        public static DataTemplate GetArrowIconTemplate(ContextMenu contextMenu)
        {
            return (DataTemplate)contextMenu.GetValue(ArrowIconTemplateProperty);
        }

        public static void SetArrowIconTemplate(ContextMenu contextMenu, DataTemplate value)
        {
            contextMenu.SetValue(ArrowIconTemplateProperty, value);
        }

        public static readonly DependencyProperty ArrowIconTemplateProperty =
            DependencyProperty.RegisterAttached("ArrowIconTemplate", typeof(DataTemplate), typeof(ContextMenuHelper));
        #endregion

        #region Foreground
        public static Brush GetForeground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ForegroundProperty);
        }

        public static void SetForeground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ForegroundProperty, value);
        }

        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(ContextMenuHelper), new PropertyMetadata(Brushes.Black));

        #endregion

        #region Background
        public static Brush GetBackground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(BackgroundProperty);
        }

        public static void SetBackground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(BackgroundProperty, value);
        }

        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(ContextMenuHelper), new PropertyMetadata(Brushes.White));
        #endregion

        #region BorderBrush
        public static Brush GetBorderBrush(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(BorderBrushProperty);
        }

        public static void SetBorderBrush(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(BorderBrushProperty, value);
        }

        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(ContextMenuHelper), new PropertyMetadata(Brushes.LightGray));

        #endregion

        #region BorderThickness
        public static Thickness GetBorderThickness(ContextMenu contextMenu)
        {
            return (Thickness)contextMenu.GetValue(BorderThicknessProperty);
        }

        public static void SetBorderThickness(ContextMenu contextMenu, Thickness value)
        {
            contextMenu.SetValue(BorderThicknessProperty, value);
        }

        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.RegisterAttached("BorderThickness", typeof(Thickness), typeof(ContextMenuHelper), new PropertyMetadata(new Thickness(1)));

        #endregion

        #region Padding
        public static Thickness GetPadding(ContextMenu contextMenu)
        {
            return (Thickness)contextMenu.GetValue(PaddingProperty);
        }

        public static void SetPadding(ContextMenu contextMenu, Thickness value)
        {
            contextMenu.SetValue(PaddingProperty, value);
        }

        public static readonly DependencyProperty PaddingProperty =
            DependencyProperty.RegisterAttached("Padding", typeof(Thickness), typeof(ContextMenuHelper));

        #endregion

        #region Items

        #region ItemsIcon
        public static object GetItemsIcon(ContextMenu contextMenu)
        {
            return (object)contextMenu.GetValue(ItemsIconProperty);
        }

        public static void SetItemsIcon(ContextMenu contextMenu, object value)
        {
            contextMenu.SetValue(ItemsIconProperty, value);
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.RegisterAttached("ItemsIcon", typeof(object), typeof(ContextMenuHelper));
        #endregion

        #region ItemsIconWidth
        public static double GetItemsIconWidth(ContextMenu contextMenu)
        {
            return (double)contextMenu.GetValue(ItemsIconWidthProperty);
        }

        public static void SetItemsIconWidth(ContextMenu contextMenu, double value)
        {
            contextMenu.SetValue(ItemsIconWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsIconWidthProperty =
            DependencyProperty.RegisterAttached("ItemsIconWidth", typeof(double), typeof(ContextMenuHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsWidth
        public static double GetItemsWidth(ContextMenu contextMneu)
        {
            return (double)contextMneu.GetValue(ItemsWidthProperty);
        }

        public static void SetItemsWidth(ContextMenu contextMenu, double value)
        {
            contextMenu.SetValue(ItemsWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.RegisterAttached("ItemsWidth", typeof(double), typeof(ContextMenuHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsHeight
        public static double GetItemsHeight(ContextMenu contextMneu)
        {
            return (double)contextMneu.GetValue(ItemsHeightProperty);
        }

        public static void SetItemsHeight(ContextMenu contextMenu, double value)
        {
            contextMenu.SetValue(ItemsHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.RegisterAttached("ItemsHeight", typeof(double), typeof(ContextMenuHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsMargin
        public static Thickness GetItemsMargin(ContextMenu contextMenu)
        {
            return (Thickness)contextMenu.GetValue(ItemsMarginProperty);
        }

        public static void SetItemsMargin(ContextMenu contextMenu, Thickness value)
        {
            contextMenu.SetValue(ItemsMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.RegisterAttached("ItemsMargin", typeof(Thickness), typeof(ContextMenuHelper));
        #endregion

        #region ItemsPadding
        public static Thickness GetItemsPadding(ContextMenu contextMenu)
        {
            return (Thickness)contextMenu.GetValue(ItemsPaddingProperty);
        }

        public static void SetItemsPadding(ContextMenu contextMenu, Thickness value)
        {
            contextMenu.SetValue(ItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.RegisterAttached("ItemsPadding", typeof(Thickness), typeof(ContextMenuHelper));
        #endregion

        #region ItemsBackground
        public static Brush GetItemsBackground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsBackgroundProperty);
        }

        public static void SetItemsBackground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsBorderBrush
        public static Brush GetItemsBorderBrush(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsBorderBrushProperty);
        }

        public static void SetItemsBorderBrush(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsBorderBrush", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsBorderThickness
        public static Thickness GetItemsBorderThickness(ContextMenu contextMenu)
        {
            return (Thickness)contextMenu.GetValue(ItemsBorderThicknessProperty);
        }

        public static void SetItemsBorderThickness(ContextMenu contextMenu, Thickness value)
        {
            contextMenu.SetValue(ItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsBorderThickness", typeof(Thickness), typeof(ContextMenuHelper));
        #endregion

        #region ItemsCornerRadius
        public static CornerRadius GetItemsCornerRadius(ContextMenu contextMenu)
        {
            return (CornerRadius)contextMenu.GetValue(ItemsCornerRadiusProperty);
        }

        public static void SetItemsCornerRadius(ContextMenu contextMenu, CornerRadius value)
        {
            contextMenu.SetValue(ItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCornerRadius", typeof(CornerRadius), typeof(ContextMenuHelper));
        #endregion

        #region ItemsHoverBackground
        public static Brush GetItemsHoverBackground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsHoverBackgroundProperty);
        }

        public static void SetItemsHoverBackground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBackground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsHoverForeground
        public static Brush GetItemsHoverForeground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsHoverForegroundProperty);
        }

        public static void SetItemsHoverForeground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverForeground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsHoverBorderBrush
        public static Brush GetItemsHoverBorderBrush(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsHoverBorderBrushProperty);
        }

        public static void SetItemsHoverBorderBrush(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderBrush", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsClickBackground
        public static Brush GetItemsClickBackground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsClickBackgroundProperty);
        }

        public static void SetItemsClickBackground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsClickBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsClickBackground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsClickForeground
        public static Brush GetItemsClickForeground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsClickForegroundProperty);
        }

        public static void SetItemsClickForeground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsClickForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsClickForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsClickForeground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsClickBorderBrush
        public static Brush GetItemsClickBorderBrush(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsClickBorderBrushProperty);
        }

        public static void SetItemsClickBorderBrush(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsClickBorderBrush", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsCheckedBackground
        public static Brush GetItemsCheckedBackground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsCheckedBackgroundProperty);
        }

        public static void SetItemsCheckedBackground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsCheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedBackground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsCheckedForeground
        public static Brush GetItemsCheckedForeground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsCheckedForegroundProperty);
        }

        public static void SetItemsCheckedForeground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsCheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedForeground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsCheckedBorderBrush
        public static Brush GetItemsCheckedBorderBrush(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsCheckedBorderBrushProperty);
        }

        public static void SetItemsCheckedBorderBrush(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsCheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedBorderBrush", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsCheckedBorderThickness
        public static Thickness? GetItemsCheckedBorderThickness(ContextMenu contextMenu)
        {
            return (Thickness?)contextMenu.GetValue(ItemsCheckedBorderThicknessProperty);
        }

        public static void SetItemsCheckedBorderThickness(ContextMenu contextMenu, Thickness? value)
        {
            contextMenu.SetValue(ItemsCheckedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedBorderThickness", typeof(Thickness?), typeof(ContextMenuHelper));
        #endregion

        #region ItemsSeparatorBrush
        public static Brush GetItemsSeparatorBrush(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsSeparatorBrushProperty);
        }

        public static void SetItemsSeparatorBrush(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorBrush", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsSeparatorThickness
        public static double GetItemsSeparatorThickness(ContextMenu contextMenu)
        {
            return (double)contextMenu.GetValue(ItemsSeparatorThicknessProperty);
        }

        public static void SetItemsSeparatorThickness(ContextMenu contextMenu, double value)
        {
            contextMenu.SetValue(ItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorThickness", typeof(double), typeof(ContextMenuHelper));
        #endregion

        #region ItemsSeparatorMargin
        public static Thickness GetItemsSeparatorMargin(ContextMenu contextMenu)
        {
            return (Thickness)contextMenu.GetValue(ItemsSeparatorMarginProperty);
        }

        public static void SetItemsSeparatorMargin(ContextMenu contextMenu, Thickness value)
        {
            contextMenu.SetValue(ItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorMargin", typeof(Thickness), typeof(ContextMenuHelper));
        #endregion

        #region ItemsSeparatorVisibility
        public static Visibility GetItemsSeparatorVisibility(ContextMenu contextMenu)
        {
            return (Visibility)contextMenu.GetValue(ItemsSeparatorVisibilityProperty);
        }

        public static void SetItemsSeparatorVisibility(ContextMenu contextMenu, Visibility value)
        {
            contextMenu.SetValue(ItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorVisibility", typeof(Visibility), typeof(ContextMenuHelper));
        #endregion

        #endregion

        #endregion
    }
}
