using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class MenuHelper
    {
        #region Properties

        #region CheckedIconTemplate
        public static DataTemplate GetCheckedIconTemplate(Menu menu)
        {
            return (DataTemplate)menu.GetValue(CheckedIconTemplateProperty);
        }

        public static void SetCheckedIconTemplate(Menu menu, DataTemplate value)
        {
            menu.SetValue(CheckedIconTemplateProperty, value);
        }

        public static readonly DependencyProperty CheckedIconTemplateProperty =
            DependencyProperty.RegisterAttached("CheckedIconTemplate", typeof(DataTemplate), typeof(MenuHelper));
        #endregion

        #region ArrowIconTemplate
        public static DataTemplate GetArrowIconTemplate(Menu menu)
        {
            return (DataTemplate)menu.GetValue(ArrowIconTemplateProperty);
        }

        public static void SetArrowIconTemplate(Menu menu, DataTemplate value)
        {
            menu.SetValue(ArrowIconTemplateProperty, value);
        }

        public static readonly DependencyProperty ArrowIconTemplateProperty =
            DependencyProperty.RegisterAttached("ArrowIconTemplate", typeof(DataTemplate), typeof(MenuHelper));
        #endregion

        #region TopLevelArrowIconTemplate
        public static DataTemplate GetTopLevelArrowIconTemplate(Menu menu)
        {
            return (DataTemplate)menu.GetValue(TopLevelArrowIconTemplateProperty);
        }

        public static void SetTopLevelArrowIconTemplate(Menu menu, DataTemplate value)
        {
            menu.SetValue(TopLevelArrowIconTemplateProperty, value);
        }

        public static readonly DependencyProperty TopLevelArrowIconTemplateProperty =
            DependencyProperty.RegisterAttached("TopLevelArrowIconTemplate", typeof(DataTemplate), typeof(MenuHelper));
        #endregion

        #region SubmenuArrowIconTemplate
        public static DataTemplate GetSubmenuArrowIconTemplate(Menu menu)
        {
            return (DataTemplate)menu.GetValue(SubmenuArrowIconTemplateProperty);
        }

        public static void SetSubmenuArrowIconTemplate(Menu menu, DataTemplate value)
        {
            menu.SetValue(SubmenuArrowIconTemplateProperty, value);
        }

        public static readonly DependencyProperty SubmenuArrowIconTemplateProperty =
            DependencyProperty.RegisterAttached("SubmenuArrowIconTemplate", typeof(DataTemplate), typeof(MenuHelper));
        #endregion

        #region Scrollable
        public static bool GetScrollable(Menu menu)
        {
            return (bool)menu.GetValue(ScrollableProperty);
        }

        public static void SetScrollable(Menu menu, bool value)
        {
            menu.SetValue(ScrollableProperty, value);
        }

        public static readonly DependencyProperty ScrollableProperty =
            DependencyProperty.RegisterAttached("Scrollable", typeof(bool), typeof(MenuHelper), new PropertyMetadata(true));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(Menu menu)
        {
            return (CornerRadius)menu.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(Menu menu, CornerRadius value)
        {
            menu.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(MenuHelper));
        #endregion

        #region TopLevel Item

        #region TopLevelItemsHorizontalContentAlignment
        public static double GetTopLevelItemsHorizontalContentAlignment(Menu menu)
        {
            return (double)menu.GetValue(TopLevelItemsHorizontalContentAlignmentProperty);
        }

        public static void SetTopLevelItemsHorizontalContentAlignment(Menu menu, HorizontalAlignment value)
        {
            menu.SetValue(TopLevelItemsHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsVerticalContentAlignment
        public static double GetTopLevelItemsVerticalContentAlignment(Menu menu)
        {
            return (double)menu.GetValue(TopLevelItemsVerticalContentAlignmentProperty);
        }

        public static void SetTopLevelItemsVerticalContentAlignment(Menu menu, VerticalAlignment value)
        {
            menu.SetValue(TopLevelItemsVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsVerticalContentAlignment", typeof(VerticalAlignment), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsIconWidth
        public static double GetTopLevelItemsIconWidth(Menu menu)
        {
            return (double)menu.GetValue(TopLevelItemsIconWidthProperty);
        }

        public static void SetTopLevelItemsIconWidth(Menu menu, double value)
        {
            menu.SetValue(TopLevelItemsIconWidthProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsIconWidthProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsIconWidth", typeof(double), typeof(MenuHelper),new PropertyMetadata(double.NaN));
        #endregion

        #region TopLevelItemsHeight
        public static double GetTopLevelItemsHeight(Menu contextMneu)
        {
            return (double)contextMneu.GetValue(TopLevelItemsHeightProperty);
        }

        public static void SetTopLevelItemsHeight(Menu menu, double value)
        {
            menu.SetValue(TopLevelItemsHeightProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsHeightProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsHeight", typeof(double), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsWidth
        public static double GetTopLevelItemsWidth(Menu contextMneu)
        {
            return (double)contextMneu.GetValue(TopLevelItemsWidthProperty);
        }

        public static void SetTopLevelItemsWidth(Menu menu, double value)
        {
            menu.SetValue(TopLevelItemsWidthProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsWidthProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsWidth", typeof(double), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsPadding
        public static Thickness GetTopLevelItemsPadding(Menu menu)
        {
            return (Thickness)menu.GetValue(TopLevelItemsPaddingProperty);
        }

        public static void SetTopLevelItemsPadding(Menu menu, Thickness value)
        {
            menu.SetValue(TopLevelItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsPaddingProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsPadding", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsMargin
        public static Thickness GetTopLevelItemsMargin(Menu menu)
        {
            return (Thickness)menu.GetValue(TopLevelItemsMarginProperty);
        }

        public static void SetTopLevelItemsMargin(Menu menu, Thickness value)
        {
            menu.SetValue(TopLevelItemsMarginProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsMarginProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsMargin", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsIcon
        public static object GetTopLevelItemsIcon(Menu menu)
        {
            return (object)menu.GetValue(TopLevelItemsIconProperty);
        }

        public static void SetTopLevelItemsIcon(Menu menu, object value)
        {
            menu.SetValue(TopLevelItemsIconProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsIconProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsIcon", typeof(object), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsBackground
        public static Brush GetTopLevelItemsBackground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsBackgroundProperty);
        }

        public static void SetTopLevelItemsBackground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsBackground", typeof(Brush), typeof(MenuHelper), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region TopLevelItemsForeground
        public static Brush GetTopLevelItemsForeground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsForegroundProperty);
        }

        public static void SetTopLevelItemsForeground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsForegroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsForegroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsBorderBrush
        public static Brush GetTopLevelItemsBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsBorderBrushProperty);
        }

        public static void SetTopLevelItemsBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsBorderBrush", typeof(Brush), typeof(MenuHelper));

        #endregion

        #region TopLevelItemsBorderThickness
        public static Thickness GetTopLevelItemsBorderThickness(Menu menu)
        {
            return (Thickness)menu.GetValue(TopLevelItemsBorderThicknessProperty);
        }

        public static void SetTopLevelItemsBorderThickness(Menu menu, Thickness value)
        {
            menu.SetValue(TopLevelItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsBorderThickness", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsCornerRadius
        public static CornerRadius GetTopLevelItemsCornerRadius(Menu menu)
        {
            return (CornerRadius)menu.GetValue(TopLevelItemsCornerRadiusProperty);
        }

        public static void SetTopLevelItemsCornerRadius(Menu menu, CornerRadius value)
        {
            menu.SetValue(TopLevelItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsCornerRadius", typeof(CornerRadius), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsHoverBackground
        public static Brush GetTopLevelItemsHoverBackground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsHoverBackgroundProperty);
        }

        public static void SetTopLevelItemsHoverBackground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsHoverBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsHoverForeground
        public static Brush GetTopLevelItemsHoverForeground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsHoverForegroundProperty);
        }

        public static void SetTopLevelItemsHoverForeground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsHoverForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsHoverBorderBrush
        public static Brush GetTopLevelItemsHoverBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsHoverBorderBrushProperty);
        }

        public static void SetTopLevelItemsHoverBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsHoverBorderBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsHoverBorderThickness
        public static Thickness? GetTopLevelItemsHoverBorderThickness(Menu menu)
        {
            return (Thickness?)menu.GetValue(TopLevelItemsHoverBorderThicknessProperty);
        }

        public static void SetTopLevelItemsHoverBorderThickness(Menu menu, Thickness? value)
        {
            menu.SetValue(TopLevelItemsHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsHoverBorderThickness", typeof(Thickness?), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsHoverCornerRadius
        public static CornerRadius? GetTopLevelItemsHoverCornerRadius(Menu menu)
        {
            return (CornerRadius?)menu.GetValue(TopLevelItemsHoverCornerRadiusProperty);
        }

        public static void SetTopLevelItemsHoverCornerRadius(Menu menu, CornerRadius? value)
        {
            menu.SetValue(TopLevelItemsHoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsHoverCornerRadiusProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsHoverCornerRadius", typeof(CornerRadius?), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsClickBackground
        public static Brush GetTopLevelItemsClickBackground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsClickBackgroundProperty);
        }

        public static void SetTopLevelItemsClickBackground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsClickBackgroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsClickBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsClickForeground
        public static Brush GetTopLevelItemsClickForeground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsClickForegroundProperty);
        }

        public static void SetTopLevelItemsClickForeground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsClickForegroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsClickForegroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsClickForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsClickBorderBrush
        public static Brush GetTopLevelItemsClickBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsClickBorderBrushProperty);
        }

        public static void SetTopLevelItemsClickBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsClickBorderBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsClickBorderThickness
        public static Thickness? GetTopLevelItemsClickBorderThickness(Menu menu)
        {
            return (Thickness?)menu.GetValue(TopLevelItemsClickBorderThicknessProperty);
        }

        public static void SetTopLevelItemsClickBorderThickness(Menu menu, Thickness? value)
        {
            menu.SetValue(TopLevelItemsClickBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsClickBorderThicknessProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsClickBorderThickness", typeof(Thickness?), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsClickCornerRadius
        public static CornerRadius? GetTopLevelItemsClickCornerRadius(Menu menu)
        {
            return (CornerRadius?)menu.GetValue(TopLevelItemsClickCornerRadiusProperty);
        }

        public static void SetTopLevelItemsClickCornerRadius(Menu menu, CornerRadius? value)
        {
            menu.SetValue(TopLevelItemsClickCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsClickCornerRadiusProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsClickCornerRadius", typeof(CornerRadius?), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsOpenedBackground
        public static Brush GetTopLevelItemsOpenedBackground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsOpenedBackgroundProperty);
        }

        public static void SetTopLevelItemsOpenedBackground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsOpenedBackgroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsOpenedBackgroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsOpenedBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsOpenedForeground
        public static Brush GetTopLevelItemsOpenedForeground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsOpenedForegroundProperty);
        }

        public static void SetTopLevelItemsOpenedForeground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsOpenedForegroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsOpenedForegroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsOpenedForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsOpenedBorderBrush
        public static Brush GetTopLevelItemsOpenedBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsOpenedBorderBrushProperty);
        }

        public static void SetTopLevelItemsOpenedBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsOpenedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsOpenedBorderBrushProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsOpenedBorderBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsOpenedBorderThickness
        public static Thickness? GetTopLevelItemsOpenedBorderThickness(Menu menu)
        {
            return (Thickness?)menu.GetValue(TopLevelItemsOpenedBorderThicknessProperty);
        }

        public static void SetTopLevelItemsOpenedBorderThickness(Menu menu, Thickness? value)
        {
            menu.SetValue(TopLevelItemsOpenedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsOpenedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsOpenedBorderThickness", typeof(Thickness?), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsOpenedCornerRadius
        public static CornerRadius? GetTopLevelItemsOpenedCornerRadius(Menu menu)
        {
            return (CornerRadius?)menu.GetValue(TopLevelItemsOpenedCornerRadiusProperty);
        }

        public static void SetTopLevelItemsOpenedCornerRadius(Menu menu, CornerRadius? value)
        {
            menu.SetValue(TopLevelItemsOpenedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsOpenedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsOpenedCornerRadius", typeof(CornerRadius?), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsCheckedBackground
        public static Brush GetTopLevelItemsCheckedBackground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsCheckedBackgroundProperty);
        }

        public static void SetTopLevelItemsCheckedBackground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsCheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsCheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsCheckedBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsCheckedForeground
        public static Brush GetTopLevelItemsCheckedForeground(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsCheckedForegroundProperty);
        }

        public static void SetTopLevelItemsCheckedForeground(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsCheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsCheckedForegroundProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsCheckedForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsCheckedBorderBrush
        public static Brush GetTopLevelItemsCheckedBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsCheckedBorderBrushProperty);
        }

        public static void SetTopLevelItemsCheckedBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsCheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsCheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsCheckedBorderBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsCheckedBorderThickness
        public static Thickness? GetTopLevelItemsCheckedBorderThickness(Menu menu)
        {
            return (Thickness?)menu.GetValue(TopLevelItemsCheckedBorderThicknessProperty);
        }

        public static void SetTopLevelItemsCheckedBorderThickness(Menu menu, Thickness? value)
        {
            menu.SetValue(TopLevelItemsCheckedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsCheckedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsCheckedBorderThickness", typeof(Thickness?), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsCheckedCornerRadius
        public static CornerRadius? GetTopLevelItemsCheckedCornerRadius(Menu menu)
        {
            return (CornerRadius?)menu.GetValue(TopLevelItemsCheckedCornerRadiusProperty);
        }

        public static void SetTopLevelItemsCheckedCornerRadius(Menu menu, CornerRadius? value)
        {
            menu.SetValue(TopLevelItemsCheckedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsCheckedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsCheckedCornerRadius", typeof(CornerRadius?), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsSeparatorBrush
        public static Brush GetTopLevelItemsSeparatorBrush(Menu menu)
        {
            return (Brush)menu.GetValue(TopLevelItemsSeparatorBrushProperty);
        }

        public static void SetTopLevelItemsSeparatorBrush(Menu menu, Brush value)
        {
            menu.SetValue(TopLevelItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsSeparatorBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsSeparatorThickness
        public static double GetTopLevelItemsSeparatorThickness(Menu menu)
        {
            return (double)menu.GetValue(TopLevelItemsSeparatorThicknessProperty);
        }

        public static void SetTopLevelItemsSeparatorThickness(Menu menu, double value)
        {
            menu.SetValue(TopLevelItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsSeparatorThickness", typeof(double), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsSeparatorMargin
        public static Thickness GetTopLevelItemsSeparatorMargin(Menu menu)
        {
            return (Thickness)menu.GetValue(TopLevelItemsSeparatorMarginProperty);
        }

        public static void SetTopLevelItemsSeparatorMargin(Menu menu, Thickness value)
        {
            menu.SetValue(TopLevelItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsSeparatorMargin", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region TopLevelItemsSeparatorVisibility
        public static Visibility GetTopLevelItemsSeparatorVisibility(Menu menu)
        {
            return (Visibility)menu.GetValue(TopLevelItemsSeparatorVisibilityProperty);
        }

        public static void SetTopLevelItemsSeparatorVisibility(Menu menu, Visibility value)
        {
            menu.SetValue(TopLevelItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty TopLevelItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("TopLevelItemsSeparatorVisibility", typeof(Visibility), typeof(MenuHelper), new PropertyMetadata(Visibility.Collapsed));
        #endregion

        #endregion

        #region Submenu Item

        #region SubmenuItemsHorizontalContentAlignment
        public static double GetSubmenuItemsHorizontalContentAlignment(Menu menu)
        {
            return (double)menu.GetValue(SubmenuItemsHorizontalContentAlignmentProperty);
        }

        public static void SetSubmenuItemsHorizontalContentAlignment(Menu menu, HorizontalAlignment value)
        {
            menu.SetValue(SubmenuItemsHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsVerticalContentAlignment
        public static double GetSubmenuItemsVerticalContentAlignment(Menu menu)
        {
            return (double)menu.GetValue(SubmenuItemsVerticalContentAlignmentProperty);
        }

        public static void SetSubmenuItemsVerticalContentAlignment(Menu menu, VerticalAlignment value)
        {
            menu.SetValue(SubmenuItemsVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsVerticalContentAlignment", typeof(VerticalAlignment), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsIconWidth
        public static double GetSubmenuItemsIconWidth(Menu menu)
        {
            return (double)menu.GetValue(SubmenuItemsIconWidthProperty);
        }

        public static void SetSubmenuItemsIconWidth(Menu menu, double value)
        {
            menu.SetValue(SubmenuItemsIconWidthProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsIconWidthProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsIconWidth", typeof(double), typeof(MenuHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region SubmenuItemsHeight
        public static double GetSubmenuItemsHeight(Menu contextMneu)
        {
            return (double)contextMneu.GetValue(SubmenuItemsHeightProperty);
        }

        public static void SetSubmenuItemsHeight(Menu menu, double value)
        {
            menu.SetValue(SubmenuItemsHeightProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsHeightProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsHeight", typeof(double), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsWidth
        public static double GetSubmenuItemsWidth(Menu contextMneu)
        {
            return (double)contextMneu.GetValue(SubmenuItemsWidthProperty);
        }

        public static void SetSubmenuItemsWidth(Menu menu, double value)
        {
            menu.SetValue(SubmenuItemsWidthProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsWidthProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsWidth", typeof(double), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsPadding
        public static Thickness GetSubmenuItemsPadding(Menu menu)
        {
            return (Thickness)menu.GetValue(SubmenuItemsPaddingProperty);
        }

        public static void SetSubmenuItemsPadding(Menu menu, Thickness value)
        {
            menu.SetValue(SubmenuItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsPaddingProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsPadding", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsMargin
        public static Thickness GetSubmenuItemsMargin(Menu menu)
        {
            return (Thickness)menu.GetValue(SubmenuItemsMarginProperty);
        }

        public static void SetSubmenuItemsMargin(Menu menu, Thickness value)
        {
            menu.SetValue(SubmenuItemsMarginProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsMarginProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsMargin", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsIcon
        public static object GetSubmenuItemsIcon(Menu menu)
        {
            return (object)menu.GetValue(SubmenuItemsIconProperty);
        }

        public static void SetSubmenuItemsIcon(Menu menu, object value)
        {
            menu.SetValue(SubmenuItemsIconProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsIconProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsIcon", typeof(object), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsBackground
        public static Brush GetSubmenuItemsBackground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsBackgroundProperty);
        }

        public static void SetSubmenuItemsBackground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsBackground", typeof(Brush), typeof(MenuHelper), new PropertyMetadata(Brushes.Transparent));

        #endregion

        #region SubmenuItemsForeground
        public static Brush GetSubmenuItemsForeground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsForegroundProperty);
        }

        public static void SetSubmenuItemsForeground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsForegroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsForegroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsForeground", typeof(Brush), typeof(MenuHelper));

        #endregion

        #region SubmenuItemsBorderBrush
        public static Brush GetSubmenuItemsBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsBorderBrushProperty);
        }

        public static void SetSubmenuItemsBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsBorderBrush", typeof(Brush), typeof(MenuHelper));

        #endregion

        #region SubmenuItemsBorderThickness
        public static Thickness GetSubmenuItemsBorderThickness(Menu menu)
        {
            return (Thickness)menu.GetValue(SubmenuItemsBorderThicknessProperty);
        }

        public static void SetSubmenuItemsBorderThickness(Menu menu, Thickness value)
        {
            menu.SetValue(SubmenuItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsBorderThickness", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsCornerRadius
        public static CornerRadius GetSubmenuItemsCornerRadius(Menu menu)
        {
            return (CornerRadius)menu.GetValue(SubmenuItemsCornerRadiusProperty);
        }

        public static void SetSubmenuItemsCornerRadius(Menu menu, CornerRadius value)
        {
            menu.SetValue(SubmenuItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsCornerRadius", typeof(CornerRadius), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsHoverBackground
        public static Brush GetSubmenuItemsHoverBackground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsHoverBackgroundProperty);
        }

        public static void SetSubmenuItemsHoverBackground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsHoverBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsHoverForeground
        public static Brush GetSubmenuItemsHoverForeground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsHoverForegroundProperty);
        }

        public static void SetSubmenuItemsHoverForeground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsHoverForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsHoverBorderBrush
        public static Brush GetSubmenuItemsHoverBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsHoverBorderBrushProperty);
        }

        public static void SetSubmenuItemsHoverBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsHoverBorderBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsHoverBorderThickness
        public static Thickness? GetSubmenuItemsHoverBorderThickness(Menu menu)
        {
            return (Thickness?)menu.GetValue(SubmenuItemsHoverBorderThicknessProperty);
        }

        public static void SetSubmenuItemsHoverBorderThickness(Menu menu, Thickness? value)
        {
            menu.SetValue(SubmenuItemsHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsHoverBorderThickness", typeof(Thickness?), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsHoverCornerRadius
        public static CornerRadius? GetSubmenuItemsHoverCornerRadius(Menu menu)
        {
            return (CornerRadius?)menu.GetValue(SubmenuItemsHoverCornerRadiusProperty);
        }

        public static void SetSubmenuItemsHoverCornerRadius(Menu menu, CornerRadius? value)
        {
            menu.SetValue(SubmenuItemsHoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsHoverCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsHoverCornerRadius", typeof(CornerRadius?), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsClickBackground
        public static Brush GetSubmenuItemsClickBackground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsClickBackgroundProperty);
        }

        public static void SetSubmenuItemsClickBackground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsClickBackgroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsClickBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsClickForeground
        public static Brush GetSubmenuItemsClickForeground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsClickForegroundProperty);
        }

        public static void SetSubmenuItemsClickForeground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsClickForegroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsClickForegroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsClickForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsClickBorderBrush
        public static Brush GetSubmenuItemsClickBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsClickBorderBrushProperty);
        }

        public static void SetSubmenuItemsClickBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsClickBorderBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsClickBorderThickness
        public static Thickness? GetSubmenuItemsClickBorderThickness(Menu menu)
        {
            return (Thickness?)menu.GetValue(SubmenuItemsClickBorderThicknessProperty);
        }

        public static void SetSubmenuItemsClickBorderThickness(Menu menu, Thickness? value)
        {
            menu.SetValue(SubmenuItemsClickBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsClickBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsClickBorderThickness", typeof(Thickness?), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsClickCornerRadius
        public static CornerRadius? GetSubmenuItemsClickCornerRadius(Menu menu)
        {
            return (CornerRadius?)menu.GetValue(SubmenuItemsClickCornerRadiusProperty);
        }

        public static void SetSubmenuItemsClickCornerRadius(Menu menu, CornerRadius? value)
        {
            menu.SetValue(SubmenuItemsClickCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsClickCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsClickCornerRadius", typeof(CornerRadius?), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsOpenedBackground
        public static Brush GetSubmenuItemsOpenedBackground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsOpenedBackgroundProperty);
        }

        public static void SetSubmenuItemsOpenedBackground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsOpenedBackgroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsOpenedBackgroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsOpenedBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsOpenedForeground
        public static Brush GetSubmenuItemsOpenedForeground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsOpenedForegroundProperty);
        }

        public static void SetSubmenuItemsOpenedForeground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsOpenedForegroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsOpenedForegroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsOpenedForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsOpenedBorderBrush
        public static Brush GetSubmenuItemsOpenedBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsOpenedBorderBrushProperty);
        }

        public static void SetSubmenuItemsOpenedBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsOpenedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsOpenedBorderBrushProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsOpenedBorderBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsOpenedBorderThickness
        public static Thickness? GetSubmenuItemsOpenedBorderThickness(Menu menu)
        {
            return (Thickness?)menu.GetValue(SubmenuItemsOpenedBorderThicknessProperty);
        }

        public static void SetSubmenuItemsOpenedBorderThickness(Menu menu, Thickness? value)
        {
            menu.SetValue(SubmenuItemsOpenedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsOpenedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsOpenedBorderThickness", typeof(Thickness?), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsOpenedCornerRadius
        public static CornerRadius? GetSubmenuItemsOpenedCornerRadius(Menu menu)
        {
            return (CornerRadius?)menu.GetValue(SubmenuItemsOpenedCornerRadiusProperty);
        }

        public static void SetSubmenuItemsOpenedCornerRadius(Menu menu, CornerRadius? value)
        {
            menu.SetValue(SubmenuItemsOpenedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsOpenedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsOpenedCornerRadius", typeof(CornerRadius?), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsCheckedBackground
        public static Brush GetSubmenuItemsCheckedBackground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsCheckedBackgroundProperty);
        }

        public static void SetSubmenuItemsCheckedBackground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsCheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsCheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsCheckedBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsCheckedForeground
        public static Brush GetSubmenuItemsCheckedForeground(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsCheckedForegroundProperty);
        }

        public static void SetSubmenuItemsCheckedForeground(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsCheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsCheckedForegroundProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsCheckedForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsCheckedBorderBrush
        public static Brush GetSubmenuItemsCheckedBorderBrush(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsCheckedBorderBrushProperty);
        }

        public static void SetSubmenuItemsCheckedBorderBrush(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsCheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsCheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsCheckedBorderBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsCheckedBorderThickness
        public static Thickness? GetSubmenuItemsCheckedBorderThickness(Menu menu)
        {
            return (Thickness?)menu.GetValue(SubmenuItemsCheckedBorderThicknessProperty);
        }

        public static void SetSubmenuItemsCheckedBorderThickness(Menu menu, Thickness? value)
        {
            menu.SetValue(SubmenuItemsCheckedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsCheckedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsCheckedBorderThickness", typeof(Thickness?), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsCheckedCornerRadius
        public static CornerRadius? GetSubmenuItemsCheckedCornerRadius(Menu menu)
        {
            return (CornerRadius?)menu.GetValue(SubmenuItemsCheckedCornerRadiusProperty);
        }

        public static void SetSubmenuItemsCheckedCornerRadius(Menu menu, CornerRadius? value)
        {
            menu.SetValue(SubmenuItemsCheckedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsCheckedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsCheckedCornerRadius", typeof(CornerRadius?), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsSeparatorBrush
        public static Brush GetSubmenuItemsSeparatorBrush(Menu menu)
        {
            return (Brush)menu.GetValue(SubmenuItemsSeparatorBrushProperty);
        }

        public static void SetSubmenuItemsSeparatorBrush(Menu menu, Brush value)
        {
            menu.SetValue(SubmenuItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsSeparatorBrush", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsSeparatorThickness
        public static double GetSubmenuItemsSeparatorThickness(Menu menu)
        {
            return (double)menu.GetValue(SubmenuItemsSeparatorThicknessProperty);
        }

        public static void SetSubmenuItemsSeparatorThickness(Menu menu, double value)
        {
            menu.SetValue(SubmenuItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsSeparatorThickness", typeof(double), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsSeparatorMargin
        public static Thickness GetSubmenuItemsSeparatorMargin(Menu menu)
        {
            return (Thickness)menu.GetValue(SubmenuItemsSeparatorMarginProperty);
        }

        public static void SetSubmenuItemsSeparatorMargin(Menu menu, Thickness value)
        {
            menu.SetValue(SubmenuItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsSeparatorMargin", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region SubmenuItemsSeparatorVisibility
        public static Visibility GetSubmenuItemsSeparatorVisibility(Menu menu)
        {
            return (Visibility)menu.GetValue(SubmenuItemsSeparatorVisibilityProperty);
        }

        public static void SetSubmenuItemsSeparatorVisibility(Menu menu, Visibility value)
        {
            menu.SetValue(SubmenuItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("SubmenuItemsSeparatorVisibility", typeof(Visibility), typeof(MenuHelper), new PropertyMetadata(Visibility.Collapsed));
        #endregion

        #endregion

        #region Submenu 

        #region TopLevelDropDownPlacement
        public static PopupXPlacement GetTopLevelDropDownPlacement(Menu menu)
        {
            return (PopupXPlacement)menu.GetValue(TopLevelDropDownPlacementProperty);
        }

        public static void SetTopLevelDropDownPlacement(Menu menu, PopupXPlacement value)
        {
            menu.SetValue(TopLevelDropDownPlacementProperty, value);
        }

        public static readonly DependencyProperty TopLevelDropDownPlacementProperty =
            DependencyProperty.RegisterAttached("TopLevelDropDownPlacement", typeof(PopupXPlacement), typeof(MenuHelper));
        #endregion

        #region TopLevelDropDownHorizontalOffset
        public static double GetTopLevelDropDownHorizontalOffset(Menu menu)
        {
            return (double)menu.GetValue(TopLevelDropDownHorizontalOffsetProperty);
        }

        public static void SetTopLevelDropDownHorizontalOffset(Menu menu, double value)
        {
            menu.SetValue(TopLevelDropDownHorizontalOffsetProperty, value);
        }

        public static readonly DependencyProperty TopLevelDropDownHorizontalOffsetProperty =
            DependencyProperty.RegisterAttached("TopLevelDropDownHorizontalOffset", typeof(double), typeof(MenuHelper));
        #endregion

        #region TopLevelDropDownVerticalOffset
        public static double GetTopLevelDropDownVerticalOffset(Menu menu)
        {
            return (double)menu.GetValue(TopLevelDropDownVerticalOffsetProperty);
        }

        public static void SetTopLevelDropDownVerticalOffset(Menu menu, double value)
        {
            menu.SetValue(TopLevelDropDownVerticalOffsetProperty, value);
        }

        public static readonly DependencyProperty TopLevelDropDownVerticalOffsetProperty =
            DependencyProperty.RegisterAttached("TopLevelDropDownVerticalOffset", typeof(double), typeof(MenuHelper));
        #endregion

        #region SubmenuDropDownPlacement
        public static PopupXPlacement GetSubmenuDropDownPlacement(Menu menu)
        {
            return (PopupXPlacement)menu.GetValue(SubmenuDropDownPlacementProperty);
        }

        public static void SetSubmenuDropDownPlacement(Menu menu, PopupXPlacement value)
        {
            menu.SetValue(SubmenuDropDownPlacementProperty, value);
        }

        public static readonly DependencyProperty SubmenuDropDownPlacementProperty =
            DependencyProperty.RegisterAttached("SubmenuDropDownPlacement", typeof(PopupXPlacement), typeof(MenuHelper));
        #endregion

        #region SubmenuDropDownHorizontalOffset
        public static double GetSubmenuDropDownHorizontalOffset(Menu menu)
        {
            return (double)menu.GetValue(SubmenuDropDownHorizontalOffsetProperty);
        }

        public static void SetSubmenuDropDownHorizontalOffset(Menu menu, double value)
        {
            menu.SetValue(SubmenuDropDownHorizontalOffsetProperty, value);
        }

        public static readonly DependencyProperty SubmenuDropDownHorizontalOffsetProperty =
            DependencyProperty.RegisterAttached("SubmenuDropDownHorizontalOffset", typeof(double), typeof(MenuHelper));
        #endregion

        #region SubmenuDropDownVerticalOffset
        public static double GetSubmenuDropDownVerticalOffset(Menu menu)
        {
            return (double)menu.GetValue(SubmenuDropDownVerticalOffsetProperty);
        }

        public static void SetSubmenuDropDownVerticalOffset(Menu menu, double value)
        {
            menu.SetValue(SubmenuDropDownVerticalOffsetProperty, value);
        }

        public static readonly DependencyProperty SubmenuDropDownVerticalOffsetProperty =
            DependencyProperty.RegisterAttached("SubmenuDropDownVerticalOffset", typeof(double), typeof(MenuHelper));
        #endregion

        #endregion

        #endregion
    }
}
