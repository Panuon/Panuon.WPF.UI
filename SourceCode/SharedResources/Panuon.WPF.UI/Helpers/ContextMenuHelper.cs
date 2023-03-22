using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ContextMenuHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey MenuItemStyle { get; } =
            new ComponentResourceKey(typeof(ContextMenuHelper), nameof(MenuItemStyle));
        #endregion

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
        public static Brush GetForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ForegroundProperty);
        }

        public static void SetForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ForegroundProperty, value);
        }

        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(Brushes.Black, FrameworkPropertyMetadataOptions.Inherits));

        #endregion

        #region Background
        public static Brush GetBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BackgroundProperty);
        }

        public static void SetBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(BackgroundProperty, value);
        }

        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(Brushes.White, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region BorderBrush
        public static Brush GetBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BorderBrushProperty);
        }

        public static void SetBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(BorderBrushProperty, value);
        }

        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(Brushes.LightGray, FrameworkPropertyMetadataOptions.Inherits));

        #endregion

        #region BorderThickness
        public static Thickness GetBorderThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(BorderThicknessProperty);
        }

        public static void SetBorderThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(BorderThicknessProperty, value);
        }

        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.RegisterAttached("BorderThickness", typeof(Thickness), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new Thickness(1), FrameworkPropertyMetadataOptions.Inherits));

        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new CornerRadius(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(DependencyObject obj)
        {
            return (Color?)obj.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(DependencyObject obj, Color? value)
        {
            obj.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.RegisterAttached("ShadowColor", typeof(Color?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
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
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(ContextMenuHelper), new PropertyMetadata(Brushes.Transparent));
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

        #region ItemsHoverBorderThickness
        public static Thickness? GetItemsHoverBorderThickness(ContextMenu contextMenu)
        {
            return (Thickness?)contextMenu.GetValue(ItemsHoverBorderThicknessProperty);
        }

        public static void SetItemsHoverBorderThickness(ContextMenu contextMenu, Thickness? value)
        {
            contextMenu.SetValue(ItemsHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderThickness", typeof(Thickness?), typeof(ContextMenuHelper));
        #endregion

        #region ItemsHoverCornerRadius
        public static CornerRadius? GetItemsHoverCornerRadius(ContextMenu contextMenu)
        {
            return (CornerRadius?)contextMenu.GetValue(ItemsHoverCornerRadiusProperty);
        }

        public static void SetItemsHoverCornerRadius(ContextMenu contextMenu, CornerRadius? value)
        {
            contextMenu.SetValue(ItemsHoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsHoverCornerRadius", typeof(CornerRadius?), typeof(ContextMenuHelper));
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

        #region ItemsClickBorderThickness
        public static Thickness? GetItemsClickBorderThickness(ContextMenu contextMenu)
        {
            return (Thickness?)contextMenu.GetValue(ItemsClickBorderThicknessProperty);
        }

        public static void SetItemsClickBorderThickness(ContextMenu contextMenu, Thickness? value)
        {
            contextMenu.SetValue(ItemsClickBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsClickBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsClickBorderThickness", typeof(Thickness?), typeof(ContextMenuHelper));
        #endregion

        #region ItemsClickCornerRadius
        public static CornerRadius? GetItemsClickCornerRadius(ContextMenu contextMenu)
        {
            return (CornerRadius?)contextMenu.GetValue(ItemsClickCornerRadiusProperty);
        }

        public static void SetItemsClickCornerRadius(ContextMenu contextMenu, CornerRadius? value)
        {
            contextMenu.SetValue(ItemsClickCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsClickCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsClickCornerRadius", typeof(CornerRadius?), typeof(ContextMenuHelper));
        #endregion

        #region ItemsOpenedBackground
        public static Brush GetItemsOpenedBackground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsOpenedBackgroundProperty);
        }

        public static void SetItemsOpenedBackground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsOpenedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedBackground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsOpenedForeground
        public static Brush GetItemsOpenedForeground(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsOpenedForegroundProperty);
        }

        public static void SetItemsOpenedForeground(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsOpenedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedForeground", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsOpenedBorderBrush
        public static Brush GetItemsOpenedBorderBrush(ContextMenu contextMenu)
        {
            return (Brush)contextMenu.GetValue(ItemsOpenedBorderBrushProperty);
        }

        public static void SetItemsOpenedBorderBrush(ContextMenu contextMenu, Brush value)
        {
            contextMenu.SetValue(ItemsOpenedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedBorderBrush", typeof(Brush), typeof(ContextMenuHelper));
        #endregion

        #region ItemsOpenedBorderThickness
        public static Thickness? GetItemsOpenedBorderThickness(ContextMenu contextMenu)
        {
            return (Thickness?)contextMenu.GetValue(ItemsOpenedBorderThicknessProperty);
        }

        public static void SetItemsOpenedBorderThickness(ContextMenu contextMenu, Thickness? value)
        {
            contextMenu.SetValue(ItemsOpenedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedBorderThickness", typeof(Thickness?), typeof(ContextMenuHelper));
        #endregion

        #region ItemsOpenedCornerRadius
        public static CornerRadius? GetItemsOpenedCornerRadius(ContextMenu contextMenu)
        {
            return (CornerRadius?)contextMenu.GetValue(ItemsOpenedCornerRadiusProperty);
        }

        public static void SetItemsOpenedCornerRadius(ContextMenu contextMenu, CornerRadius? value)
        {
            contextMenu.SetValue(ItemsOpenedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedCornerRadius", typeof(CornerRadius?), typeof(ContextMenuHelper));
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

        #region ItemsCheckedCornerRadius
        public static CornerRadius? GetItemsCheckedCornerRadius(ContextMenu contextMenu)
        {
            return (CornerRadius?)contextMenu.GetValue(ItemsCheckedCornerRadiusProperty);
        }

        public static void SetItemsCheckedCornerRadius(ContextMenu contextMenu, CornerRadius? value)
        {
            contextMenu.SetValue(ItemsCheckedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedCornerRadius", typeof(CornerRadius?), typeof(ContextMenuHelper));
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
