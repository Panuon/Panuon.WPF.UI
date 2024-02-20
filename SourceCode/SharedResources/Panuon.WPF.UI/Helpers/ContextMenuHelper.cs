using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ContextMenuHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey MenuItemStyleKey { get; } =
            new ComponentResourceKey(typeof(ContextMenuHelper), nameof(MenuItemStyleKey));
        #endregion

        #region Properties

        #region CheckedIconTemplate
        public static DataTemplate GetCheckedIconTemplate(DependencyObject obj)
        {
            return (DataTemplate)obj.GetValue(CheckedIconTemplateProperty);
        }

        public static void SetCheckedIconTemplate(DependencyObject obj, DataTemplate value)
        {
            obj.SetValue(CheckedIconTemplateProperty, value);
        }

        public static readonly DependencyProperty CheckedIconTemplateProperty =
            DependencyProperty.RegisterAttached("CheckedIconTemplate", typeof(DataTemplate), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(default, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ArrowIconTemplate
        public static DataTemplate GetArrowIconTemplate(DependencyObject obj)
        {
            return (DataTemplate)obj.GetValue(ArrowIconTemplateProperty);
        }

        public static void SetArrowIconTemplate(DependencyObject obj, DataTemplate value)
        {
            obj.SetValue(ArrowIconTemplateProperty, value);
        }

        public static readonly DependencyProperty ArrowIconTemplateProperty =
            DependencyProperty.RegisterAttached("ArrowIconTemplate", typeof(DataTemplate), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(default, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region Width
        public static double GetWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(WidthProperty);
        }

        public static void SetWidth(DependencyObject obj, double value)
        {
            obj.SetValue(WidthProperty, value);
        }

        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.RegisterAttached("Width", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(200d, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region MinWidth
        public static double GetMinWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(MinWidthProperty);
        }

        public static void SetMinWidth(DependencyObject obj, double value)
        {
            obj.SetValue(MinWidthProperty, value);
        }

        public static readonly DependencyProperty MinWidthProperty =
            DependencyProperty.RegisterAttached("MinWidth", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region MaxWidth
        public static double GetMaxWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(MaxWidthProperty);
        }

        public static void SetMaxWidth(DependencyObject obj, double value)
        {
            obj.SetValue(MaxWidthProperty, value);
        }

        public static readonly DependencyProperty MaxWidthProperty =
            DependencyProperty.RegisterAttached("MaxWidth", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(double.MaxValue, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region Height
        public static double GetHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(HeightProperty);
        }

        public static void SetHeight(DependencyObject obj, double value)
        {
            obj.SetValue(HeightProperty, value);
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.RegisterAttached("Height", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(double.NaN, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region MinHeight
        public static double GetMinHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(MinHeightProperty);
        }

        public static void SetMinHeight(DependencyObject obj, double value)
        {
            obj.SetValue(MinHeightProperty, value);
        }

        public static readonly DependencyProperty MinHeightProperty =
            DependencyProperty.RegisterAttached("MinHeight", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region MaxHeight
        public static double GetMaxHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(MaxHeightProperty);
        }

        public static void SetMaxHeight(DependencyObject obj, double value)
        {
            obj.SetValue(MaxHeightProperty, value);
        }

        public static readonly DependencyProperty MaxHeightProperty =
            DependencyProperty.RegisterAttached("MaxHeight", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(double.MaxValue, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region Padding
        public static Thickness GetPadding(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(PaddingProperty);
        }

        public static void SetPadding(DependencyObject obj, Thickness value)
        {
            obj.SetValue(PaddingProperty, value);
        }

        public static readonly DependencyProperty PaddingProperty =
            DependencyProperty.RegisterAttached("Padding", typeof(Thickness), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new Thickness(0), FrameworkPropertyMetadataOptions.Inherits));
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
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(ContextMenuHelper));
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
        public static object GetItemsIcon(DependencyObject obj)
        {
            return (object)obj.GetValue(ItemsIconProperty);
        }

        public static void SetItemsIcon(DependencyObject obj, object value)
        {
            obj.SetValue(ItemsIconProperty, value);
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.RegisterAttached("ItemsIcon", typeof(object), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(default, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsIconWidth
        public static double? GetItemsIconWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(ItemsIconWidthProperty);
        }

        public static void SetItemsIconWidth(DependencyObject obj, double? value)
        {
            obj.SetValue(ItemsIconWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsIconWidthProperty =
            DependencyProperty.RegisterAttached("ItemsIconWidth", typeof(double?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsWidth
        public static double GetItemsWidth(DependencyObject contextMneu)
        {
            return (double)contextMneu.GetValue(ItemsWidthProperty);
        }

        public static void SetItemsWidth(DependencyObject obj, double value)
        {
            obj.SetValue(ItemsWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.RegisterAttached("ItemsWidth", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(double.NaN, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsHeight
        public static double GetItemsHeight(DependencyObject contextMneu)
        {
            return (double)contextMneu.GetValue(ItemsHeightProperty);
        }

        public static void SetItemsHeight(DependencyObject obj, double value)
        {
            obj.SetValue(ItemsHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.RegisterAttached("ItemsHeight", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(30d, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsMargin
        public static Thickness GetItemsMargin(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(ItemsMarginProperty);
        }

        public static void SetItemsMargin(DependencyObject obj, Thickness value)
        {
            obj.SetValue(ItemsMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.RegisterAttached("ItemsMargin", typeof(Thickness), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsPadding
        public static Thickness GetItemsPadding(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(ItemsPaddingProperty);
        }

        public static void SetItemsPadding(DependencyObject obj, Thickness value)
        {
            obj.SetValue(ItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.RegisterAttached("ItemsPadding", typeof(Thickness), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new Thickness(5, 0, 5, 0), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsBackground
        public static Brush GetItemsBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsBackgroundProperty);
        }

        public static void SetItemsBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsBorderBrush
        public static Brush GetItemsBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsBorderBrushProperty);
        }

        public static void SetItemsBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsBorderBrush", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsBorderThickness
        public static Thickness GetItemsBorderThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(ItemsBorderThicknessProperty);
        }

        public static void SetItemsBorderThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(ItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsBorderThickness", typeof(Thickness), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsCornerRadius
        public static CornerRadius GetItemsCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(ItemsCornerRadiusProperty);
        }

        public static void SetItemsCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(ItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCornerRadius", typeof(CornerRadius), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new CornerRadius(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsHoverBackground
        public static Brush GetItemsHoverBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsHoverBackgroundProperty);
        }

        public static void SetItemsHoverBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBackground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F1F1F1")), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsHoverForeground
        public static Brush GetItemsHoverForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsHoverForegroundProperty);
        }

        public static void SetItemsHoverForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverForeground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsHoverBorderBrush
        public static Brush GetItemsHoverBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsHoverBorderBrushProperty);
        }

        public static void SetItemsHoverBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderBrush", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsHoverBorderThickness
        public static Thickness? GetItemsHoverBorderThickness(DependencyObject obj)
        {
            return (Thickness?)obj.GetValue(ItemsHoverBorderThicknessProperty);
        }

        public static void SetItemsHoverBorderThickness(DependencyObject obj, Thickness? value)
        {
            obj.SetValue(ItemsHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderThickness", typeof(Thickness?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsHoverCornerRadius
        public static CornerRadius? GetItemsHoverCornerRadius(DependencyObject obj)
        {
            return (CornerRadius?)obj.GetValue(ItemsHoverCornerRadiusProperty);
        }

        public static void SetItemsHoverCornerRadius(DependencyObject obj, CornerRadius? value)
        {
            obj.SetValue(ItemsHoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsHoverCornerRadius", typeof(CornerRadius?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsClickBackground
        public static Brush GetItemsClickBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsClickBackgroundProperty);
        }

        public static void SetItemsClickBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsClickBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsClickBackground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsClickForeground
        public static Brush GetItemsClickForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsClickForegroundProperty);
        }

        public static void SetItemsClickForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsClickForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsClickForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsClickForeground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsClickBorderBrush
        public static Brush GetItemsClickBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsClickBorderBrushProperty);
        }

        public static void SetItemsClickBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsClickBorderBrush", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsClickBorderThickness
        public static Thickness? GetItemsClickBorderThickness(DependencyObject obj)
        {
            return (Thickness?)obj.GetValue(ItemsClickBorderThicknessProperty);
        }

        public static void SetItemsClickBorderThickness(DependencyObject obj, Thickness? value)
        {
            obj.SetValue(ItemsClickBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsClickBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsClickBorderThickness", typeof(Thickness?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsClickCornerRadius
        public static CornerRadius? GetItemsClickCornerRadius(DependencyObject obj)
        {
            return (CornerRadius?)obj.GetValue(ItemsClickCornerRadiusProperty);
        }

        public static void SetItemsClickCornerRadius(DependencyObject obj, CornerRadius? value)
        {
            obj.SetValue(ItemsClickCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsClickCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsClickCornerRadius", typeof(CornerRadius?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsOpenedBackground
        public static Brush GetItemsOpenedBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsOpenedBackgroundProperty);
        }

        public static void SetItemsOpenedBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsOpenedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedBackground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsOpenedForeground
        public static Brush GetItemsOpenedForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsOpenedForegroundProperty);
        }

        public static void SetItemsOpenedForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsOpenedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedForeground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsOpenedBorderBrush
        public static Brush GetItemsOpenedBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsOpenedBorderBrushProperty);
        }

        public static void SetItemsOpenedBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsOpenedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedBorderBrush", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsOpenedBorderThickness
        public static Thickness? GetItemsOpenedBorderThickness(DependencyObject obj)
        {
            return (Thickness?)obj.GetValue(ItemsOpenedBorderThicknessProperty);
        }

        public static void SetItemsOpenedBorderThickness(DependencyObject obj, Thickness? value)
        {
            obj.SetValue(ItemsOpenedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedBorderThickness", typeof(Thickness?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsOpenedCornerRadius
        public static CornerRadius? GetItemsOpenedCornerRadius(DependencyObject obj)
        {
            return (CornerRadius?)obj.GetValue(ItemsOpenedCornerRadiusProperty);
        }

        public static void SetItemsOpenedCornerRadius(DependencyObject obj, CornerRadius? value)
        {
            obj.SetValue(ItemsOpenedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsOpenedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsOpenedCornerRadius", typeof(CornerRadius?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsCheckedBackground
        public static Brush GetItemsCheckedBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsCheckedBackgroundProperty);
        }

        public static void SetItemsCheckedBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsCheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedBackground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsCheckedForeground
        public static Brush GetItemsCheckedForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsCheckedForegroundProperty);
        }

        public static void SetItemsCheckedForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsCheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedForeground", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsCheckedBorderBrush
        public static Brush GetItemsCheckedBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsCheckedBorderBrushProperty);
        }

        public static void SetItemsCheckedBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsCheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedBorderBrush", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsCheckedBorderThickness
        public static Thickness? GetItemsCheckedBorderThickness(DependencyObject obj)
        {
            return (Thickness?)obj.GetValue(ItemsCheckedBorderThicknessProperty);
        }

        public static void SetItemsCheckedBorderThickness(DependencyObject obj, Thickness? value)
        {
            obj.SetValue(ItemsCheckedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedBorderThickness", typeof(Thickness?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsCheckedCornerRadius
        public static CornerRadius? GetItemsCheckedCornerRadius(DependencyObject obj)
        {
            return (CornerRadius?)obj.GetValue(ItemsCheckedCornerRadiusProperty);
        }

        public static void SetItemsCheckedCornerRadius(DependencyObject obj, CornerRadius? value)
        {
            obj.SetValue(ItemsCheckedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCheckedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCheckedCornerRadius", typeof(CornerRadius?), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsSeparatorBrush
        public static Brush GetItemsSeparatorBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ItemsSeparatorBrushProperty);
        }

        public static void SetItemsSeparatorBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorBrush", typeof(Brush), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E6E6E6")), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsSeparatorThickness
        public static double GetItemsSeparatorThickness(DependencyObject obj)
        {
            return (double)obj.GetValue(ItemsSeparatorThicknessProperty);
        }

        public static void SetItemsSeparatorThickness(DependencyObject obj, double value)
        {
            obj.SetValue(ItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorThickness", typeof(double), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(1d, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsSeparatorMargin
        public static Thickness GetItemsSeparatorMargin(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(ItemsSeparatorMarginProperty);
        }

        public static void SetItemsSeparatorMargin(DependencyObject obj, Thickness value)
        {
            obj.SetValue(ItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorMargin", typeof(Thickness), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ItemsSeparatorVisibility
        public static Visibility GetItemsSeparatorVisibility(DependencyObject obj)
        {
            return (Visibility)obj.GetValue(ItemsSeparatorVisibilityProperty);
        }

        public static void SetItemsSeparatorVisibility(DependencyObject obj, Visibility value)
        {
            obj.SetValue(ItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorVisibility", typeof(Visibility), typeof(ContextMenuHelper), new FrameworkPropertyMetadata(Visibility.Collapsed, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #endregion

        #endregion
    }
}
