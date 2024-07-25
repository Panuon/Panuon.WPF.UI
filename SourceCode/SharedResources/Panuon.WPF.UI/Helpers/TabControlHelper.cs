using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class TabControlHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey RemoveButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(TabControlHelper), nameof(RemoveButtonStyleKey));

        public static ComponentResourceKey HeaderPanelScrollButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(TabControlHelper), nameof(HeaderPanelScrollButtonStyleKey));
        #endregion

        #region Routed Event

        #region ItemRemoving
        public static void AddItemRemovingHandler(DependencyObject d, ItemRemovingRoutedEventHandler handler)
        {
            var element = d as UIElement;
            if (element != null)
            {
                element.AddHandler(ItemRemovingEvent, handler);
            }
        }

        public static void RemoveItemRemovingHandler(DependencyObject d, ItemRemovingRoutedEventHandler handler)
        {
            var element = d as UIElement;
            if (element != null)
            {
                element.RemoveHandler(ItemRemovingEvent, handler);
            }
        }

        public static readonly RoutedEvent ItemRemovingEvent =
            EventManager.RegisterRoutedEvent("ItemRemoving", RoutingStrategy.Bubble, typeof(ItemRemovingRoutedEventHandler), typeof(TabControlHelper));
        #endregion

        #region ItemRemoved
        public static void AddItemRemovedHandler(DependencyObject d, ItemRemovedRoutedEventHandler handler)
        {
            var element = d as UIElement;
            if (element != null)
            {
                element.AddHandler(ItemRemovedEvent, handler);
            }
        }

        public static void RemoveItemRemovedHandler(DependencyObject d, ItemRemovedRoutedEventHandler handler)
        {
            var element = d as UIElement;
            if (element != null)
            {
                element.RemoveHandler(ItemRemovedEvent, handler);
            }
        }

        public static readonly RoutedEvent ItemRemovedEvent =
            EventManager.RegisterRoutedEvent("ItemRemoved", RoutingStrategy.Bubble, typeof(ItemRemovedRoutedEventHandler), typeof(TabControlHelper));
        #endregion

        #endregion

        #region Properties

        #region CornerRadius
        public static CornerRadius GetCornerRadius(TabControl tabControl)
        {
            return (CornerRadius)tabControl.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(TabControl tabControl, CornerRadius value)
        {
            tabControl.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(TabControlHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(TabControl tabControl)
        {
            return (Color?)tabControl.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(TabControl tabControl, Color? value)
        {
            tabControl.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(TabControlHelper));
        #endregion

        #region FrontControl
        public static object GetFrontControl(TabControl tabControl)
        {
            return (object)tabControl.GetValue(FrontControlProperty);
        }

        public static void SetFrontControl(TabControl tabControl, object value)
        {
            tabControl.SetValue(FrontControlProperty, value);
        }

        public static readonly DependencyProperty FrontControlProperty =
            DependencyProperty.RegisterAttached("FrontControl", typeof(object), typeof(TabControlHelper));
        #endregion

        #region EndControl
        public static object GetEndControl(TabControl tabControl)
        {
            return (object)tabControl.GetValue(EndControlProperty);
        }

        public static void SetEndControl(TabControl tabControl, object value)
        {
            tabControl.SetValue(EndControlProperty, value);
        }

        public static readonly DependencyProperty EndControlProperty =
            DependencyProperty.RegisterAttached("EndControl", typeof(object), typeof(TabControlHelper));
        #endregion

        #region CanHeaderPanelScroll
        public static bool GetCanHeaderPanelScroll(TabControl tabControl)
        {
            return (bool)tabControl.GetValue(CanHeaderPanelScrollProperty);
        }

        public static void SetCanHeaderPanelScroll(TabControl tabControl, bool value)
        {
            tabControl.SetValue(CanHeaderPanelScrollProperty, value);
        }

        public static readonly DependencyProperty CanHeaderPanelScrollProperty =
            DependencyProperty.RegisterAttached("CanHeaderPanelScroll", typeof(bool), typeof(TabControlHelper));
        #endregion

        #region ScrollButtonStyle
        public static Style GetScrollButtonStyle(TabControl tabControl)
        {
            return (Style)tabControl.GetValue(ScrollButtonStyleProperty);
        }

        public static void SetScrollButtonStyle(TabControl tabControl, Style value)
        {
            tabControl.SetValue(ScrollButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ScrollButtonStyleProperty =
            DependencyProperty.RegisterAttached("ScrollButtonStyle", typeof(Style), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelHeight
        public static double GetHeaderPanelHeight(TabControl tabControl)
        {
            return (double)tabControl.GetValue(HeaderPanelHeightProperty);
        }

        public static void SetHeaderPanelHeight(TabControl tabControl, double value)
        {
            tabControl.SetValue(HeaderPanelHeightProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelHeightProperty =
            DependencyProperty.RegisterAttached("HeaderPanelHeight", typeof(double), typeof(TabControlHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region HeaderPanelBorderBrush
        public static Brush GetHeaderPanelBorderBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(HeaderPanelBorderBrushProperty);
        }

        public static void SetHeaderPanelBorderBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(HeaderPanelBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelBorderBrushProperty =
            DependencyProperty.RegisterAttached("HeaderPanelBorderBrush", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelBorderThickness
        public static Thickness GetHeaderPanelBorderThickness(TabControl tabControl)
        {
            return (Thickness)tabControl.GetValue(HeaderPanelBorderThicknessProperty);
        }

        public static void SetHeaderPanelBorderThickness(TabControl tabControl, Thickness value)
        {
            tabControl.SetValue(HeaderPanelBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelBorderThicknessProperty =
            DependencyProperty.RegisterAttached("HeaderPanelBorderThickness", typeof(Thickness), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelBackground
        public static Brush GetHeaderPanelBackground(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(HeaderPanelBackgroundProperty);
        }

        public static void SetHeaderPanelBackground(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(HeaderPanelBackgroundProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelBackgroundProperty =
            DependencyProperty.RegisterAttached("HeaderPanelBackground", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelShadowColor
        public static Color? GetHeaderPanelShadowColor(TabControl tabControl)
        {
            return (Color?)tabControl.GetValue(HeaderPanelShadowColorProperty);
        }

        public static void SetHeaderPanelShadowColor(TabControl tabControl, Color? value)
        {
            tabControl.SetValue(HeaderPanelShadowColorProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelShadowColorProperty =
            DependencyProperty.RegisterAttached("HeaderPanelShadowColor", typeof(Color?), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelCornerRadius
        public static CornerRadius GetHeaderPanelCornerRadius(TabControl tabControl)
        {
            return (CornerRadius)tabControl.GetValue(HeaderPanelCornerRadiusProperty);
        }

        public static void SetHeaderPanelCornerRadius(TabControl tabControl, CornerRadius value)
        {
            tabControl.SetValue(HeaderPanelCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelCornerRadiusProperty =
            DependencyProperty.RegisterAttached("HeaderPanelCornerRadius", typeof(CornerRadius), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelMargin
        public static Thickness GetHeaderPanelMargin(TabControl tabControl)
        {
            return (Thickness)tabControl.GetValue(HeaderPanelMarginProperty);
        }

        public static void SetHeaderPanelMargin(TabControl tabControl, Thickness value)
        {
            tabControl.SetValue(HeaderPanelMarginProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelMarginProperty =
            DependencyProperty.RegisterAttached("HeaderPanelMargin", typeof(Thickness), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelPadding
        public static Thickness GetHeaderPanelPadding(TabControl tabControl)
        {
            return (Thickness)tabControl.GetValue(HeaderPanelPaddingProperty);
        }

        public static void SetHeaderPanelPadding(TabControl tabControl, Thickness value)
        {
            tabControl.SetValue(HeaderPanelPaddingProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelPaddingProperty =
            DependencyProperty.RegisterAttached("HeaderPanelPadding", typeof(Thickness), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelRibbonLineVisibility
        public static Visibility GetHeaderPanelRibbonLineVisibility(TabControl tabControl)
        {
            return (Visibility)tabControl.GetValue(HeaderPanelRibbonLineVisibilityProperty);
        }

        public static void SetHeaderPanelRibbonLineVisibility(TabControl tabControl, Visibility value)
        {
            tabControl.SetValue(HeaderPanelRibbonLineVisibilityProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelRibbonLineVisibilityProperty =
            DependencyProperty.RegisterAttached("HeaderPanelRibbonLineVisibility", typeof(Visibility), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelRibbonLineBrush
        public static Brush GetHeaderPanelRibbonLineBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(HeaderPanelRibbonLineBrushProperty);
        }

        public static void SetHeaderPanelRibbonLineBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(HeaderPanelRibbonLineBrushProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelRibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("HeaderPanelRibbonLineBrush", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelRibbonLineThickness
        public static double GetHeaderPanelRibbonLineThickness(TabControl tabControl)
        {
            return (double)tabControl.GetValue(HeaderPanelRibbonLineThicknessProperty);
        }

        public static void SetHeaderPanelRibbonLineThickness(TabControl tabControl, double value)
        {
            tabControl.SetValue(HeaderPanelRibbonLineThicknessProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelRibbonLineThicknessProperty =
            DependencyProperty.RegisterAttached("HeaderPanelRibbonLineThickness", typeof(double), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelRibbonLineCornerRadius
        public static CornerRadius GetHeaderPanelRibbonLineCornerRadius(TabControl tabControl)
        {
            return (CornerRadius)tabControl.GetValue(HeaderPanelRibbonLineCornerRadiusProperty);
        }

        public static void SetHeaderPanelRibbonLineCornerRadius(TabControl tabControl, CornerRadius value)
        {
            tabControl.SetValue(HeaderPanelRibbonLineCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelRibbonLineCornerRadiusProperty =
            DependencyProperty.RegisterAttached("HeaderPanelRibbonLineCornerRadius", typeof(CornerRadius), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelRibbonLineStrategy
        public static HeaderPanelRibbonLineStrategy GetHeaderPanelRibbonLineStrategy(TabControl tabControl)
        {
            return (HeaderPanelRibbonLineStrategy)tabControl.GetValue(HeaderPanelRibbonLineStrategyProperty);
        }

        public static void SetHeaderPanelRibbonLineStrategy(TabControl tabControl, HeaderPanelRibbonLineStrategy value)
        {
            tabControl.SetValue(HeaderPanelRibbonLineStrategyProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelRibbonLineStrategyProperty =
            DependencyProperty.RegisterAttached("HeaderPanelRibbonLineStrategy", typeof(HeaderPanelRibbonLineStrategy), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelAlignment
        public static TabControlHeaderPanelAlignment GetHeaderPanelAlignment(TabControl tabControl)
        {
            return (TabControlHeaderPanelAlignment)tabControl.GetValue(HeaderPanelAlignmentProperty);
        }

        public static void SetHeaderPanelAlignment(TabControl tabControl, TabControlHeaderPanelAlignment value)
        {
            tabControl.SetValue(HeaderPanelAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderPanelAlignment", typeof(TabControlHeaderPanelAlignment), typeof(TabControlHelper));
        #endregion

        #region HeaderPanelScrollButtonStyle
        public static Style GetHeaderPanelScrollButtonStyle(TabControl tabControl)
        {
            return (Style)tabControl.GetValue(HeaderPanelScrollButtonStyleProperty);
        }

        public static void SetHeaderPanelScrollButtonStyle(TabControl tabControl, Style value)
        {
            tabControl.SetValue(HeaderPanelScrollButtonStyleProperty, value);
        }

        public static readonly DependencyProperty HeaderPanelScrollButtonStyleProperty =
            DependencyProperty.RegisterAttached("HeaderPanelScrollButtonStyle", typeof(Style), typeof(TabControlHelper));
        #endregion

        #region RemoveButtonStyle
        public static Style GetRemoveButtonStyle(TabControl tabControl)
        {
            return (Style)tabControl.GetValue(RemoveButtonStyleProperty);
        }

        public static void SetRemoveButtonStyle(TabControl tabControl, Style value)
        {
            tabControl.SetValue(RemoveButtonStyleProperty, value);
        }

        public static readonly DependencyProperty RemoveButtonStyleProperty =
            DependencyProperty.RegisterAttached("RemoveButtonStyle", typeof(Style), typeof(TabControlHelper));
        #endregion

        #region RemovingAnimationDuration
        public static TimeSpan? GetRemovingAnimationDuration(TabControl tabControl)
        {
            return (TimeSpan?)tabControl.GetValue(RemovingAnimationDurationProperty);
        }

        public static void SetRemovingAnimationDuration(TabControl tabControl, TimeSpan? value)
        {
            tabControl.SetValue(RemovingAnimationDurationProperty, value);
        }

        public static readonly DependencyProperty RemovingAnimationDurationProperty =
            DependencyProperty.RegisterAttached("RemovingAnimationDuration", typeof(TimeSpan?), typeof(TabControlHelper));
        #endregion

        #region RemovingAnimationEasing
        public static AnimationEasing GetRemovingAnimationEasing(TabControl tabControl)
        {
            return (AnimationEasing)tabControl.GetValue(RemovingAnimationEasingProperty);
        }

        public static void SetRemovingAnimationEasing(TabControl tabControl, AnimationEasing value)
        {
            tabControl.SetValue(RemovingAnimationEasingProperty, value);
        }

        public static readonly DependencyProperty RemovingAnimationEasingProperty =
            DependencyProperty.RegisterAttached("RemovingAnimationEasing", typeof(AnimationEasing), typeof(TabControlHelper));
        #endregion

        #region Items Properties

        #region ItemsIcon
        public static object GetItemsIcon(TabControl tabControl)
        {
            return (object)tabControl.GetValue(ItemsIconProperty);
        }

        public static void SetItemsIcon(TabControl tabControl, object value)
        {
            tabControl.SetValue(ItemsIconProperty, value);
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.RegisterAttached("ItemsIcon", typeof(object), typeof(TabControlHelper));
        #endregion

        #region ItemsIconPlacement
        public static IconPlacement GetItemsIconPlacement(TabControl tabControl)
        {
            return (IconPlacement)tabControl.GetValue(ItemsIconPlacementProperty);
        }

        public static void SetItemsIconPlacement(TabControl tabControl, IconPlacement value)
        {
            tabControl.SetValue(ItemsIconPlacementProperty, value);
        }

        public static readonly DependencyProperty ItemsIconPlacementProperty =
            DependencyProperty.RegisterAttached("ItemsIconPlacement", typeof(IconPlacement), typeof(TabControlHelper), new PropertyMetadata(IconPlacement.Left));
        #endregion

        #region ItemsWidth
        public static double GetItemsWidth(TabControl tabControl)
        {
            return (double)tabControl.GetValue(ItemsWidthProperty);
        }

        public static void SetItemsWidth(TabControl tabControl, double value)
        {
            tabControl.SetValue(ItemsWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.RegisterAttached("ItemsWidth", typeof(double), typeof(TabControlHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsHeight
        public static double GetItemsHeight(TabControl tabControl)
        {
            return (double)tabControl.GetValue(ItemsHeightProperty);
        }

        public static void SetItemsHeight(TabControl tabControl, double value)
        {
            tabControl.SetValue(ItemsHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.RegisterAttached("ItemsHeight", typeof(double), typeof(TabControlHelper), new PropertyMetadata(30.0));
        #endregion

        #region ItemsMargin
        public static Thickness GetItemsMargin(TabControl tabControl)
        {
            return (Thickness)tabControl.GetValue(ItemsMarginProperty);
        }

        public static void SetItemsMargin(TabControl tabControl, Thickness value)
        {
            tabControl.SetValue(ItemsMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.RegisterAttached("ItemsMargin", typeof(Thickness), typeof(TabControlHelper));
        #endregion

        #region ItemsPadding
        public static Thickness GetItemsPadding(TabControl tabControl)
        {
            return (Thickness)tabControl.GetValue(ItemsPaddingProperty);
        }

        public static void SetItemsPadding(TabControl tabControl, Thickness value)
        {
            tabControl.SetValue(ItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.RegisterAttached("ItemsPadding", typeof(Thickness), typeof(TabControlHelper));
        #endregion

        #region ItemsFontSize
        public static double GetItemsFontSize(TabControl tabControl)
        {
            return (double)tabControl.GetValue(ItemsFontSizeProperty);
        }

        public static void SetItemsFontSize(TabControl tabControl, double value)
        {
            tabControl.SetValue(ItemsFontSizeProperty, value);
        }

        public static readonly DependencyProperty ItemsFontSizeProperty =
            DependencyProperty.RegisterAttached("ItemsFontSize", typeof(double), typeof(TabControlHelper), new PropertyMetadata(12d));
        #endregion

        #region ItemsCornerRadius
        public static CornerRadius GetItemsCornerRadius(TabControl tabControl)
        {
            return (CornerRadius)tabControl.GetValue(ItemsCornerRadiusProperty);
        }

        public static void SetItemsCornerRadius(TabControl tabControl, CornerRadius value)
        {
            tabControl.SetValue(ItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCornerRadius", typeof(CornerRadius), typeof(TabControlHelper));
        #endregion

        #region ItemsVerticalHeaderAlignment
        public static VerticalAlignment GetItemsVerticalHeaderAlignment(TabControl tabControl)
        {
            return (VerticalAlignment)tabControl.GetValue(ItemsVerticalHeaderAlignmentProperty);
        }

        public static void SetItemsVerticalHeaderAlignment(TabControl tabControl, VerticalAlignment value)
        {
            tabControl.SetValue(ItemsVerticalHeaderAlignmentProperty, value);
        }

        public static readonly DependencyProperty ItemsVerticalHeaderAlignmentProperty =
            DependencyProperty.RegisterAttached("ItemsVerticalHeaderAlignment", typeof(VerticalAlignment), typeof(TabControlHelper));
        #endregion

        #region ItemsHorizontalHeaderAlignment
        public static HorizontalAlignment GetItemsHorizontalHeaderAlignment(TabControl tabControl)
        {
            return (HorizontalAlignment)tabControl.GetValue(ItemsHorizontalHeaderAlignmentProperty);
        }

        public static void SetItemsHorizontalHeaderAlignment(TabControl tabControl, HorizontalAlignment value)
        {
            tabControl.SetValue(ItemsHorizontalHeaderAlignmentProperty, value);
        }

        public static readonly DependencyProperty ItemsHorizontalHeaderAlignmentProperty =
            DependencyProperty.RegisterAttached("ItemsHorizontalHeaderAlignment", typeof(HorizontalAlignment), typeof(TabControlHelper));
        #endregion

        #region ItemsVerticalAlignment
        public static VerticalAlignment GetItemsVerticalAlignment(TabControl tabControl)
        {
            return (VerticalAlignment)tabControl.GetValue(ItemsVerticalAlignmentProperty);
        }

        public static void SetItemsVerticalAlignment(TabControl tabControl, VerticalAlignment value)
        {
            tabControl.SetValue(ItemsVerticalAlignmentProperty, value);
        }

        public static readonly DependencyProperty ItemsVerticalAlignmentProperty =
            DependencyProperty.RegisterAttached("ItemsVerticalAlignment", typeof(VerticalAlignment), typeof(TabControlHelper));
        #endregion

        #region ItemsHorizontalAlignment
        public static HorizontalAlignment GetItemsHorizontalAlignment(TabControl tabControl)
        {
            return (HorizontalAlignment)tabControl.GetValue(ItemsHorizontalAlignmentProperty);
        }

        public static void SetItemsHorizontalAlignment(TabControl tabControl, HorizontalAlignment value)
        {
            tabControl.SetValue(ItemsHorizontalAlignmentProperty, value);
        }

        public static readonly DependencyProperty ItemsHorizontalAlignmentProperty =
            DependencyProperty.RegisterAttached("ItemsHorizontalAlignment", typeof(HorizontalAlignment), typeof(TabControlHelper));
        #endregion

        #region ItemsFontFamily
        public static FontFamily GetItemsFontFamily(TabControl tabControl)
        {
            return (FontFamily)tabControl.GetValue(ItemsFontFamilyProperty);
        }

        public static void SetItemsFontFamily(TabControl tabControl, FontFamily value)
        {
            tabControl.SetValue(ItemsFontFamilyProperty, value);
        }

        public static readonly DependencyProperty ItemsFontFamilyProperty =
            DependencyProperty.RegisterAttached("ItemsFontFamily", typeof(FontFamily), typeof(TabControlHelper), new PropertyMetadata(SystemFonts.MessageFontFamily));
        #endregion

        #region ItemsForeground
        public static Brush GetItemsForeground(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsForegroundProperty);
        }

        public static void SetItemsForeground(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsForeground", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsBackground
        public static Brush GetItemsBackground(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsBackgroundProperty);
        }

        public static void SetItemsBackground(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(TabControlHelper), new PropertyMetadata(Brushes.Transparent));

        #endregion

        #region ItemsBorderBrush
        public static Brush GetItemsBorderBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsBorderBrushProperty);
        }

        public static void SetItemsBorderBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsBorderBrush", typeof(Brush), typeof(TabControlHelper));

        #endregion

        #region ItemsRibbonLineBrush
        public static Brush GetItemsRibbonLineBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsRibbonLineBrushProperty);
        }

        public static void SetItemsRibbonLineBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsRibbonLineBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsRibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("ItemsRibbonLineBrush", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsRibbonLineThickness
        public static double GetItemsRibbonLineThickness(TabControl tabControl)
        {
            return (double)tabControl.GetValue(ItemsRibbonLineThicknessProperty);
        }

        public static void SetItemsRibbonLineThickness(TabControl tabControl, double value)
        {
            tabControl.SetValue(ItemsRibbonLineThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsRibbonLineThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsRibbonLineThickness", typeof(double), typeof(TabControlHelper));
        #endregion

        #region ItemsRibbonLineCornerRadius
        public static CornerRadius GetItemsRibbonLineCornerRadius(TabControl tabControl)
        {
            return (CornerRadius)tabControl.GetValue(ItemsRibbonLineCornerRadiusProperty);
        }

        public static void SetItemsRibbonLineCornerRadius(TabControl tabControl, CornerRadius value)
        {
            tabControl.SetValue(ItemsRibbonLineCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsRibbonLineCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsRibbonLineCornerRadius", typeof(CornerRadius), typeof(TabControlHelper));
        #endregion

        #region ItemsRibbonLineVisibility
        public static Visibility GetItemsRibbonLineVisibility(TabControl tabControl)
        {
            return (Visibility)tabControl.GetValue(ItemsRibbonLineVisibilityProperty);
        }

        public static void SetItemsRibbonLineVisibility(TabControl tabControl, Visibility value)
        {
            tabControl.SetValue(ItemsRibbonLineVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsRibbonLineVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsRibbonLineVisibility", typeof(Visibility), typeof(TabControlHelper));
        #endregion

        #region ItemsRibbonLinePlacement
        public static RibbonLinePlacement GetItemsRibbonLinePlacement(TabControl tabControl)
        {
            return (RibbonLinePlacement)tabControl.GetValue(ItemsRibbonLinePlacementProperty);
        }

        public static void SetItemsRibbonLinePlacement(TabControl tabControl, RibbonLinePlacement value)
        {
            tabControl.SetValue(ItemsRibbonLinePlacementProperty, value);
        }

        public static readonly DependencyProperty ItemsRibbonLinePlacementProperty =
            DependencyProperty.RegisterAttached("ItemsRibbonLinePlacement", typeof(RibbonLinePlacement), typeof(TabControlHelper));
        #endregion

        #region ItemsRibbonLineMargin
        public static Thickness GetItemsRibbonLineMargin(TabControl tabControl)
        {
            return (Thickness)tabControl.GetValue(ItemsRibbonLineMarginProperty);
        }

        public static void SetItemsRibbonLineMargin(TabControl tabControl, Thickness value)
        {
            tabControl.SetValue(ItemsRibbonLineMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsRibbonLineMarginProperty =
            DependencyProperty.RegisterAttached("ItemsRibbonLineMargin", typeof(Thickness), typeof(TabControlHelper));
        #endregion

        #region ItemsBorderThickness
        public static Thickness GetItemsBorderThickness(TabControl tabControl)
        {
            return (Thickness)tabControl.GetValue(ItemsBorderThicknessProperty);
        }

        public static void SetItemsBorderThickness(TabControl tabControl, Thickness value)
        {
            tabControl.SetValue(ItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsBorderThickness", typeof(Thickness), typeof(TabControlHelper));
        #endregion

        #region ItemsHoverBackground
        public static Brush GetItemsHoverBackground(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsHoverBackgroundProperty);
        }

        public static void SetItemsHoverBackground(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBackground", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsHoverForeground
        public static Brush GetItemsHoverForeground(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsHoverForegroundProperty);
        }

        public static void SetItemsHoverForeground(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverForeground", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsHoverBorderBrush
        public static Brush GetItemsHoverBorderBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsHoverBorderBrushProperty);
        }

        public static void SetItemsHoverBorderBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderBrush", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsHoverBorderThickness
        public static Thickness? GetItemsHoverBorderThickness(TabControl tabControl)
        {
            return (Thickness?)tabControl.GetValue(ItemsHoverBorderThicknessProperty);
        }

        public static void SetItemsHoverBorderThickness(TabControl tabControl, Thickness? value)
        {
            tabControl.SetValue(ItemsHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderThickness", typeof(Thickness?), typeof(TabControlHelper));
        #endregion

        #region ItemsHoverCornerRadius
        public static CornerRadius? GetItemsHoverCornerRadius(TabControl tabControl)
        {
            return (CornerRadius?)tabControl.GetValue(ItemsHoverCornerRadiusProperty);
        }

        public static void SetItemsHoverCornerRadius(TabControl tabControl, CornerRadius? value)
        {
            tabControl.SetValue(ItemsHoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsHoverCornerRadius", typeof(CornerRadius?), typeof(TabControlHelper));
        #endregion

        #region ItemsHoverRibbonLineBrush
        public static Brush GetItemsHoverRibbonLineBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsHoverRibbonLineBrushProperty);
        }

        public static void SetItemsHoverRibbonLineBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsHoverRibbonLineBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverRibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverRibbonLineBrush", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsHoverRibbonLineThickness
        public static double? GetItemsHoverRibbonLineThickness(TabControl tabControl)
        {
            return (double?)tabControl.GetValue(ItemsHoverRibbonLineThicknessProperty);
        }

        public static void SetItemsHoverRibbonLineThickness(TabControl tabControl, double? value)
        {
            tabControl.SetValue(ItemsHoverRibbonLineThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverRibbonLineThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsHoverRibbonLineThickness", typeof(double?), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedBackground
        public static Brush GetItemsSelectedBackground(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsSelectedBackgroundProperty);
        }

        public static void SetItemsSelectedBackground(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsSelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBackground", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedForeground
        public static Brush GetItemsSelectedForeground(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsSelectedForegroundProperty);
        }

        public static void SetItemsSelectedForeground(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsSelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedForeground", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedBorderBrush
        public static Brush GetItemsSelectedBorderBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsSelectedBorderBrushProperty);
        }

        public static void SetItemsSelectedBorderBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsSelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderBrush", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedBorderThickness
        public static Thickness? GetItemsSelectedBorderThickness(TabControl tabControl)
        {
            return (Thickness?)tabControl.GetValue(ItemsSelectedBorderThicknessProperty);
        }

        public static void SetItemsSelectedBorderThickness(TabControl tabControl, Thickness? value)
        {
            tabControl.SetValue(ItemsSelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderThickness", typeof(Thickness?), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedCornerRadius
        public static CornerRadius? GetItemsSelectedCornerRadius(TabControl tabControl)
        {
            return (CornerRadius?)tabControl.GetValue(ItemsSelectedCornerRadiusProperty);
        }

        public static void SetItemsSelectedCornerRadius(TabControl tabControl, CornerRadius? value)
        {
            tabControl.SetValue(ItemsSelectedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedCornerRadius", typeof(CornerRadius?), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedFontSize
        public static double? GetItemsSelectedFontSize(TabControl tabControl)
        {
            return (double?)tabControl.GetValue(ItemsSelectedFontSizeProperty);
        }

        public static void SetItemsSelectedFontSize(TabControl tabControl, double? value)
        {
            tabControl.SetValue(ItemsSelectedFontSizeProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedFontSizeProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedFontSize", typeof(double?), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedRibbonLineBrush
        public static Brush GetItemsSelectedRibbonLineBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsSelectedRibbonLineBrushProperty);
        }

        public static void SetItemsSelectedRibbonLineBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsSelectedRibbonLineBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedRibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedRibbonLineBrush", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedRibbonLineThickness
        public static double? GetItemsSelectedRibbonLineThickness(TabControl tabControl)
        {
            return (double?)tabControl.GetValue(ItemsSelectedRibbonLineThicknessProperty);
        }

        public static void SetItemsSelectedRibbonLineThickness(TabControl tabControl, double? value)
        {
            tabControl.SetValue(ItemsSelectedRibbonLineThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedRibbonLineThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedRibbonLineThickness", typeof(double?), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedWidth
        public static double? GetItemsSelectedWidth(TabControl tabControl)
        {
            return (double?)tabControl.GetValue(ItemsSelectedWidthProperty);
        }

        public static void SetItemsSelectedWidth(TabControl tabControl, double? value)
        {
            tabControl.SetValue(ItemsSelectedWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedWidthProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedWidth", typeof(double?), typeof(TabControlHelper));
        #endregion

        #region ItemsSelectedHeight
        public static double? GetItemsSelectedHeight(TabControl tabControl)
        {
            return (double?)tabControl.GetValue(ItemsSelectedHeightProperty);
        }

        public static void SetItemsSelectedHeight(TabControl tabControl, double? value)
        {
            tabControl.SetValue(ItemsSelectedHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedHeightProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedHeight", typeof(double?), typeof(TabControlHelper));
        #endregion

        #region ItemsRemoveButtonVisibility
        public static AuxiliaryButtonVisibility GetItemsRemoveButtonVisibility(TabControl tabControl)
        {
            return (AuxiliaryButtonVisibility)tabControl.GetValue(ItemsRemoveButtonVisibilityProperty);
        }

        public static void SetItemsRemoveButtonVisibility(TabControl tabControl, AuxiliaryButtonVisibility value)
        {
            tabControl.SetValue(ItemsRemoveButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsRemoveButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsRemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(TabControlHelper));
        #endregion

        #region ItemsSeparatorBrush
        public static Brush GetItemsSeparatorBrush(TabControl tabControl)
        {
            return (Brush)tabControl.GetValue(ItemsSeparatorBrushProperty);
        }

        public static void SetItemsSeparatorBrush(TabControl tabControl, Brush value)
        {
            tabControl.SetValue(ItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorBrush", typeof(Brush), typeof(TabControlHelper));
        #endregion

        #region ItemsSeparatorThickness
        public static double GetItemsSeparatorThickness(TabControl tabControl)
        {
            return (double)tabControl.GetValue(ItemsSeparatorThicknessProperty);
        }

        public static void SetItemsSeparatorThickness(TabControl tabControl, double value)
        {
            tabControl.SetValue(ItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorThickness", typeof(double), typeof(TabControlHelper));
        #endregion

        #region ItemsSeparatorMargin
        public static Thickness GetItemsSeparatorMargin(TabControl tabControl)
        {
            return (Thickness)tabControl.GetValue(ItemsSeparatorMarginProperty);
        }

        public static void SetItemsSeparatorMargin(TabControl tabControl, Thickness value)
        {
            tabControl.SetValue(ItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorMargin", typeof(Thickness), typeof(TabControlHelper));
        #endregion

        #region ItemsSeparatorVisibility
        public static Visibility GetItemsSeparatorVisibility(TabControl tabControl)
        {
            return (Visibility)tabControl.GetValue(ItemsSeparatorVisibilityProperty);
        }

        public static void SetItemsSeparatorVisibility(TabControl tabControl, Visibility value)
        {
            tabControl.SetValue(ItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorVisibility", typeof(Visibility), typeof(TabControlHelper));
        #endregion

        #endregion

        #endregion

        #region Commands

        #region ScrollForwardCommand
        internal static ICommand GetScrollForwardCommand(TabControl tabControl)
        {
            return (ICommand)tabControl.GetValue(ScrollForwardCommandProperty);
        }

        internal static readonly DependencyProperty ScrollForwardCommandProperty =
            DependencyProperty.RegisterAttached("ScrollForwardCommand", typeof(ICommand), typeof(TabControlHelper), new PropertyMetadata(new RelayCommand(OnScrollForwardCommandExecute)));
        #endregion

        #region ScrollBackwardCommand
        internal static ICommand GetScrollBackwardCommand(TabControl tabControl)
        {
            return (ICommand)tabControl.GetValue(ScrollBackwardCommandProperty);
        }

        internal static readonly DependencyProperty ScrollBackwardCommandProperty =
            DependencyProperty.RegisterAttached("ScrollBackwardCommand", typeof(ICommand), typeof(TabControlHelper), new PropertyMetadata(new RelayCommand(OnScrollBackwardCommandExecute)));
        #endregion

        #region RemoveCommand
        public static ICommand GetRemoveCommand(TabItem tabItem)
        {
            return (ICommand)tabItem.GetValue(RemoveCommandProperty);
        }

        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.RegisterAttached("RemoveCommand", typeof(ICommand), typeof(TabControlHelper), new PropertyMetadata(new RelayCommand(OnRemoveCommandExecute)));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnScrollBackwardCommandExecute(object obj)
        {
            var scrollViewer = (ScrollViewer)obj;
            var tabControl = scrollViewer.TemplatedParent as TabControl;

            switch (tabControl.TabStripPlacement)
            {
                case Dock.Top:
                case Dock.Bottom:
                    scrollViewer.LineLeft();
                    break;
                default:
                    scrollViewer.LineUp();
                    break;
            }
        }

        private static void OnScrollForwardCommandExecute(object obj)
        {
            var scrollViewer = (ScrollViewer)obj;
            var tabControl = scrollViewer.TemplatedParent as TabControl;

            switch (tabControl.TabStripPlacement)
            {
                case Dock.Top:
                case Dock.Bottom:
                    scrollViewer.LineRight();
                    break;
                default:
                    scrollViewer.LineDown();
                    break;
            }
        }
        private static void OnRemoveCommandExecute(object obj)
        {
            var tabItem = (TabItem)obj;
            var tabControl = (TabControl)ItemsControl.ItemsControlFromItemContainer(tabItem);
            var animationDuration = GetRemovingAnimationDuration(tabControl);
            var animationEase = GetRemovingAnimationEasing(tabControl);
            var dataItem = tabControl.ItemContainerGenerator.ItemFromContainer(tabItem);

            var removingArgs = new ItemRemovingRoutedEventArgs(ItemRemovingEvent, dataItem);
            tabControl.RaiseEvent(removingArgs);
            if (removingArgs.Cancel)
            {
                return;
            }

            var action = new Action(() =>
            {
                tabControl.Dispatcher.Invoke(new Action(() =>
                {
                    var collectionView = (IEditableCollectionView)tabControl.Items;
                    if (collectionView.CanRemove)
                    {
                        collectionView.Remove(dataItem);
                    }
                    else
                    {
                        tabControl.Items.Remove(dataItem);
                    }

                    var removedArgs = new ItemRemovedRoutedEventArgs(ItemRemovedEvent, dataItem);
                    tabControl.RaiseEvent(removedArgs);
                }));
            });
            if (animationDuration != null && ((TimeSpan)animationDuration).TotalMilliseconds > 0)
            {
                var isLeftRight = tabItem.TabStripPlacement == Dock.Left || tabItem.TabStripPlacement == Dock.Right;
                AnimationUtil.BeginDoubleAnimation(tabItem, isLeftRight ? TabItem.HeightProperty : TabItem.WidthProperty, isLeftRight ? tabItem.ActualHeight : tabItem.ActualWidth, 0, animationDuration, null, animationEase, action);
            }
            else
            {
                action?.Invoke();
            }
        }
        #endregion
    }
}
