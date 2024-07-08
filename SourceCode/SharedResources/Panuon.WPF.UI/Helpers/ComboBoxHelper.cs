using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Models;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ComboBoxHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ClearButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(ComboBoxHelper), nameof(ClearButtonStyleKey));
     
        public static ComponentResourceKey RemoveButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(ComboBoxHelper), nameof(RemoveButtonStyleKey));

        public static ComponentResourceKey ToggleArrowTransformControlStyleKey { get; } =
            new ComponentResourceKey(typeof(ComboBoxHelper), nameof(ToggleArrowTransformControlStyleKey));

        public static ComponentResourceKey SearchTextBoxStyleKey { get; } =
            new ComponentResourceKey(typeof(ComboBoxHelper), nameof(SearchTextBoxStyleKey));
        #endregion

        #region Routed Event

        #region ItemRemoving
        public static void AddItemRemovingHandler(UIElement element, ItemRemovingRoutedEventHandler eventHandler)
        {
            element.AddHandler(ItemRemovingEvent, eventHandler);
        }

        public static void RemoveItemRemovingHandler(UIElement element, ItemRemovingRoutedEventHandler eventHandler)
        {
            element.RemoveHandler(ItemRemovingEvent, eventHandler);
        }

        public static readonly RoutedEvent ItemRemovingEvent
            = EventManager.RegisterRoutedEvent("ItemRemoving", RoutingStrategy.Bubble, typeof(ItemRemovingRoutedEventHandler), typeof(ComboBoxHelper));
        #endregion

        #region ItemRemoved
        public static void AddItemRemovedHandler(UIElement element, ItemRemovedRoutedEventHandler handler)
        {
            element.AddHandler(ItemRemovedEvent, handler);
        }

        public static void RemoveItemRemovedHandler(UIElement element, ItemRemovedRoutedEventHandler handler)
        {
            element.RemoveHandler(ItemRemovedEvent, handler);
        }

        public static readonly RoutedEvent ItemRemovedEvent
            = EventManager.RegisterRoutedEvent("ItemRemoved", RoutingStrategy.Bubble, typeof(ItemRemovedRoutedEventHandler), typeof(ComboBoxHelper));
        #endregion

        #region SearchTextChanged
        public static void AddSearchTextChangedHandler(UIElement element, SearchTextChangedRoutedEventHandler handler)
        {
            element.AddHandler(SearchTextChangedEvent, handler);
        }

        public static void RemoveSearchTextChangedHandler(UIElement element, SearchTextChangedRoutedEventHandler handler)
        {
            element.RemoveHandler(SearchTextChangedEvent, handler);
        }

        public static readonly RoutedEvent SearchTextChangedEvent
            = EventManager.RegisterRoutedEvent("SearchTextChanged", RoutingStrategy.Bubble, typeof(SearchTextChangedRoutedEventHandler), typeof(ComboBoxHelper));
        #endregion

        #endregion

        #region Properties

        #region Icon
        public static object GetIcon(ComboBox comboBox)
        {
            return (object)comboBox.GetValue(IconProperty);
        }

        public static void SetIcon(ComboBox comboBox, object value)
        {
            comboBox.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ComboBoxHelper));
        #endregion

        #region Watermark
        public static object GetWatermark(ComboBox comboBox)
        {
            return (object)comboBox.GetValue(WatermarkProperty);
        }

        public static void SetWatermark(ComboBox comboBox, object value)
        {
            comboBox.SetValue(WatermarkProperty, value);
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.RegisterAttached("Watermark", typeof(object), typeof(ComboBoxHelper));
        #endregion

        #region WatermarkForeground
        public static Brush GetWatermarkForeground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(WatermarkForegroundProperty);
        }

        public static void SetWatermarkForeground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(WatermarkForegroundProperty, value);
        }

        public static readonly DependencyProperty WatermarkForegroundProperty =
            VisualStateHelper.WatermarkForegroundProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(ComboBox comboBox)
        {
            return (CornerRadius)comboBox.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(ComboBox comboBox, CornerRadius value)
        {
            comboBox.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(ComboBox comboBox)
        {
            return (Color?)comboBox.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(ComboBox comboBox, Color? value)
        {
            comboBox.SetValue(ShadowColorProperty, value);
        }
        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region ToggleArrowTransformControlStyle
        public static Style GetToggleArrowTransformControlStyle(ComboBox comboBox)
        {
            return (Style)comboBox.GetValue(ToggleArrowTransformControlStyleProperty);
        }

        public static void SetToggleArrowTransformControlStyle(ComboBox comboBox, Style value)
        {
            comboBox.SetValue(ToggleArrowTransformControlStyleProperty, value);
        }

        public static readonly DependencyProperty ToggleArrowTransformControlStyleProperty =
            DependencyProperty.RegisterAttached("ToggleArrowTransformControlStyle", typeof(Style), typeof(ComboBoxHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region HoverBorderThickness
        public static Thickness? GetHoverBorderThickness(ComboBox comboBox)
        {
            return (Thickness)comboBox.GetValue(HoverBorderThicknessProperty);
        }

        public static void SetHoverBorderThickness(ComboBox comboBox, Thickness? value)
        {
            comboBox.SetValue(HoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region HoverCornerRadius
        public static CornerRadius? GetHoverCornerRadius(ComboBox comboBox)
        {
            return (CornerRadius)comboBox.GetValue(HoverCornerRadiusProperty);
        }

        public static void SetHoverCornerRadius(ComboBox comboBox, CornerRadius? value)
        {
            comboBox.SetValue(HoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region HoverShadowColor
        public static Color? GetHoverShadowColor(ComboBox comboBox)
        {
            return (Color?)comboBox.GetValue(HoverShadowColorProperty);
        }

        public static void SetHoverShadowColor(ComboBox comboBox, Color? value)
        {
            comboBox.SetValue(HoverShadowColorProperty, value);
        }
        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region FocusedBackground
        public static Brush GetFocusedBackground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(FocusedBackgroundProperty);
        }

        public static void SetFocusedBackground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(FocusedBackgroundProperty, value);
        }

        public static readonly DependencyProperty FocusedBackgroundProperty =
            VisualStateHelper.FocusedBackgroundProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region FocusedForeground
        public static Brush GetFocusedForeground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(FocusedForegroundProperty);
        }

        public static void SetFocusedForeground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(FocusedForegroundProperty, value);
        }

        public static readonly DependencyProperty FocusedForegroundProperty =
            VisualStateHelper.FocusedForegroundProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region FocusedBorderBrush
        public static Brush GetFocusedBorderBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(FocusedBorderBrushProperty);
        }

        public static void SetFocusedBorderBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(FocusedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            VisualStateHelper.FocusedBorderBrushProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region FocusedBorderThickness
        public static Thickness? GetFocusedBorderThickness(ComboBox comboBox)
        {
            return (Thickness?)comboBox.GetValue(FocusedBorderThicknessProperty);
        }

        public static void SetFocusedBorderThickness(ComboBox comboBox, Thickness? value)
        {
            comboBox.SetValue(FocusedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty FocusedBorderThicknessProperty =
            VisualStateHelper.FocusedBorderThicknessProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region FocusedCornerRadius
        public static CornerRadius? GetFocusedCornerRadius(ComboBox comboBox)
        {
            return (CornerRadius)comboBox.GetValue(FocusedCornerRadiusProperty);
        }

        public static void SetFocusedCornerRadius(ComboBox comboBox, CornerRadius? value)
        {
            comboBox.SetValue(FocusedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty FocusedCornerRadiusProperty =
            VisualStateHelper.FocusedCornerRadiusProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region FocusedShadowColor
        public static Color? GetFocusedShadowColor(ComboBox comboBox)
        {
            return (Color?)comboBox.GetValue(FocusedShadowColorProperty);
        }

        public static void SetFocusedShadowColor(ComboBox comboBox, Color? value)
        {
            comboBox.SetValue(FocusedShadowColorProperty, value);
        }
        public static readonly DependencyProperty FocusedShadowColorProperty =
            VisualStateHelper.FocusedShadowColorProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region OpenedBackground
        public static Brush GetOpenedBackground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(OpenedBackgroundProperty);
        }

        public static void SetOpenedBackground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(OpenedBackgroundProperty, value);
        }

        public static readonly DependencyProperty OpenedBackgroundProperty =
            DependencyProperty.RegisterAttached("OpenedBackground", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region OpenedForeground
        public static Brush GetOpenedForeground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(OpenedForegroundProperty);
        }

        public static void SetOpenedForeground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(OpenedForegroundProperty, value);
        }

        public static readonly DependencyProperty OpenedForegroundProperty =
            DependencyProperty.RegisterAttached("OpenedForeground", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region OpenedBorderBrush
        public static Brush GetOpenedBorderBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(OpenedBorderBrushProperty);
        }

        public static void SetOpenedBorderBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(OpenedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty OpenedBorderBrushProperty =
            DependencyProperty.RegisterAttached("OpenedBorderBrush", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region OpenedBorderThickness
        public static Thickness? GetOpenedBorderThickness(ComboBox comboBox)
        {
            return (Thickness?)comboBox.GetValue(OpenedBorderThicknessProperty);
        }

        public static void SetOpenedBorderThickness(ComboBox comboBox, Thickness? value)
        {
            comboBox.SetValue(OpenedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty OpenedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("OpenedBorderThickness", typeof(Thickness?), typeof(ComboBoxHelper));
        #endregion

        #region OpenedCornerRadius
        public static CornerRadius? GetOpenedCornerRadius(ComboBox comboBox)
        {
            return (CornerRadius)comboBox.GetValue(OpenedCornerRadiusProperty);
        }

        public static void SetOpenedCornerRadius(ComboBox comboBox, CornerRadius? value)
        {
            comboBox.SetValue(OpenedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty OpenedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("OpenedCornerRadius", typeof(CornerRadius?), typeof(ComboBoxHelper));
        #endregion

        #region OpenedShadowColor
        public static Color? GetOpenedShadowColor(ComboBox comboBox)
        {
            return (Color?)comboBox.GetValue(OpenedShadowColorProperty);
        }

        public static void SetOpenedShadowColor(ComboBox comboBox, Color? value)
        {
            comboBox.SetValue(OpenedShadowColorProperty, value);
        }
        public static readonly DependencyProperty OpenedShadowColorProperty =
            VisualStateHelper.OpenedShadowColorProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region FocusedWatermarkForeground

        public static Brush GetFocusedWatermarkForeground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(FocusedWatermarkForegroundProperty);
        }

        public static void SetFocusedWatermarkForeground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(FocusedWatermarkForegroundProperty, value);
        }

        public static readonly DependencyProperty FocusedWatermarkForegroundProperty =
            VisualStateHelper.FocusedWatermarkForegroundProperty.AddOwner(typeof(ComboBoxHelper));
        #endregion

        #region ClearButtonStyle
        public static Style GetClearButtonStyle(ComboBox comboBox)
        {
            return (Style)comboBox.GetValue(ClearButtonStyleProperty);
        }

        public static void SetClearButtonStyle(ComboBox comboBox, Style value)
        {
            comboBox.SetValue(ClearButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ClearButtonStyleProperty =
            DependencyProperty.RegisterAttached("ClearButtonStyle", typeof(Style), typeof(ComboBoxHelper));
        #endregion

        #region ClearButtonVisibility
        public static AuxiliaryButtonVisibility GetClearButtonVisibility(ComboBox comboBox)
        {
            return (AuxiliaryButtonVisibility)comboBox.GetValue(ClearButtonVisibilityProperty);
        }

        public static void SetClearButtonVisibility(ComboBox comboBox, AuxiliaryButtonVisibility value)
        {
            comboBox.SetValue(ClearButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("ClearButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(ComboBoxHelper));
        #endregion

        #region RemoveButtonStyle
        public static Style GetRemoveButtonStyle(ComboBox comboBox)
        {
            return (Style)comboBox.GetValue(RemoveButtonStyleProperty);
        }

        public static void SetRemoveButtonStyle(ComboBox comboBox, Style value)
        {
            comboBox.SetValue(RemoveButtonStyleProperty, value);
        }

        public static readonly DependencyProperty RemoveButtonStyleProperty =
            DependencyProperty.RegisterAttached("RemoveButtonStyle", typeof(Style), typeof(ComboBoxHelper));
        #endregion

        #region RemovingAnimationDuration
        public static TimeSpan? GetRemovingAnimationDuration(ComboBox comboBox)
        {
            return (TimeSpan?)comboBox.GetValue(RemovingAnimationDurationProperty);
        }

        public static void SetRemovingAnimationDuration(ComboBox comboBox, TimeSpan? value)
        {
            comboBox.SetValue(RemovingAnimationDurationProperty, value);
        }

        public static readonly DependencyProperty RemovingAnimationDurationProperty =
            DependencyProperty.RegisterAttached("RemovingAnimationDuration", typeof(TimeSpan?), typeof(ComboBoxHelper));
        #endregion

        #region RemovingAnimationEasing
        public static AnimationEasing GetRemovingAnimationEasing(ComboBox comboBox)
        {
            return (AnimationEasing)comboBox.GetValue(RemovingAnimationEasingProperty);
        }

        public static void SetRemovingAnimationEasing(ComboBox comboBox, AnimationEasing value)
        {
            comboBox.SetValue(RemovingAnimationEasingProperty, value);
        }

        public static readonly DependencyProperty RemovingAnimationEasingProperty =
            DependencyProperty.RegisterAttached("RemovingAnimationEasing", typeof(AnimationEasing), typeof(ComboBoxHelper));
        #endregion

        #region StaysOpenOnEdit
        public static bool GetStaysOpenOnEdit(ComboBox comboBox)
        {
            return (bool)comboBox.GetValue(StaysOpenOnEditProperty);
        }

        public static void SetStaysOpenOnEdit(ComboBox comboBox, bool value)
        {
            comboBox.SetValue(StaysOpenOnEditProperty, value);
        }

        public static readonly DependencyProperty StaysOpenOnEditProperty =
            DependencyProperty.RegisterAttached("StaysOpenOnEdit", typeof(bool), typeof(ComboBoxHelper), new PropertyMetadata(OnStaysOpenOnEditChanged));
        #endregion

        #region BindToEnum
        public static Enum GetBindToEnum(ComboBox comboBox)
        {
            return (Enum)comboBox.GetValue(BindToEnumProperty);
        }

        public static void SetBindToEnum(ComboBox comboBox, Enum value)
        {
            comboBox.SetValue(BindToEnumProperty, value);
        }

        public static readonly DependencyProperty BindToEnumProperty =
            DependencyProperty.RegisterAttached("BindToEnum", typeof(Enum), typeof(ComboBoxHelper), new PropertyMetadata(OnBindToEnumChanged));
        #endregion

        #region SearchTextBoxVisibility
        public static Visibility GetSearchTextBoxVisibility(ComboBox comboBox)
        {
            return (Visibility)comboBox.GetValue(SearchTextBoxVisibilityProperty);
        }

        public static void SetSearchTextBoxVisibility(ComboBox comboBox, Visibility value)
        {
            comboBox.SetValue(SearchTextBoxVisibilityProperty, value);
        }

        public static readonly DependencyProperty SearchTextBoxVisibilityProperty =
            DependencyProperty.RegisterAttached("SearchTextBoxVisibility", typeof(Visibility), typeof(ComboBoxHelper), new PropertyMetadata(Visibility.Collapsed));
        #endregion

        #region SearchTextBoxStyle
        public static Style GetSearchTextBoxStyle(ComboBox comboBox)
        {
            return (Style)comboBox.GetValue(SearchTextBoxStyleProperty);
        }

        public static void SetSearchTextBoxStyle(ComboBox comboBox, Style value)
        {
            comboBox.SetValue(SearchTextBoxStyleProperty, value);
        }

        public static readonly DependencyProperty SearchTextBoxStyleProperty =
            DependencyProperty.RegisterAttached("SearchTextBoxStyle", typeof(Style), typeof(ComboBoxHelper));
        #endregion 

        #region SearchText
        public static string GetSearchText(ComboBox comboBox)
        {
            return (string)comboBox.GetValue(SearchTextProperty);
        }

        public static void SetSearchText(ComboBox comboBox, string value)
        {
            comboBox.SetValue(SearchTextProperty, value);
        }

        public static readonly DependencyProperty SearchTextProperty =
            DependencyProperty.RegisterAttached("SearchText", typeof(string), typeof(ComboBoxHelper));
        #endregion

        #region FocusToEditor
        public static bool GetFocusToEditor(ComboBox comboBox)
        {
            return (bool)comboBox.GetValue(FocusToEditorProperty);
        }

        public static void SetFocusToEditor(ComboBox comboBox, bool value)
        {
            comboBox.SetValue(FocusToEditorProperty, value);
        }

        public static readonly DependencyProperty FocusToEditorProperty =
            DependencyProperty.RegisterAttached("FocusToEditor", typeof(bool), typeof(ComboBoxHelper), new PropertyMetadata(OnFocusToEditorChanged));
        #endregion

        #region Items Properties

        #region ItemsHorizontalContentAlignment
        public static HorizontalAlignment GetItemsHorizontalContentAlignment(ComboBox comboBox)
        {
            return (HorizontalAlignment)comboBox.GetValue(ItemsHorizontalContentAlignmentProperty);
        }

        public static void SetItemsHorizontalContentAlignment(ComboBox comboBox, HorizontalAlignment value)
        {
            comboBox.SetValue(ItemsHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty ItemsHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("ItemsHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(ComboBoxHelper));
        #endregion

        #region ItemsVerticalContentAlignment
        public static VerticalAlignment GetItemsVerticalContentAlignment(ComboBox comboBox)
        {
            return (VerticalAlignment)comboBox.GetValue(ItemsVerticalContentAlignmentProperty);
        }

        public static void SetItemsVerticalContentAlignment(ComboBox comboBox, VerticalAlignment value)
        {
            comboBox.SetValue(ItemsVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty ItemsVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("ItemsVerticalContentAlignment", typeof(VerticalAlignment), typeof(ComboBoxHelper));
        #endregion

        #region ItemsIcon
        public static object GetItemsIcon(ComboBox comboBox)
        {
            return (object)comboBox.GetValue(ItemsIconProperty);
        }

        public static void SetItemsIcon(ComboBox comboBox, object value)
        {
            comboBox.SetValue(ItemsIconProperty, value);
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.RegisterAttached("ItemsIcon", typeof(object), typeof(ComboBoxHelper));
        #endregion

        #region ItemsIconWidth
        public static double GetItemsIconWidth(ComboBox comboBox)
        {
            return (double)comboBox.GetValue(ItemsIconWidthProperty);
        }

        public static void SetItemsIconWidth(ComboBox comboBox, double value)
        {
            comboBox.SetValue(ItemsIconWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsIconWidthProperty =
            DependencyProperty.RegisterAttached("ItemsIconWidth", typeof(double), typeof(ComboBoxHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsWidth
        public static double GetItemsWidth(ComboBox comboBox)
        {
            return (double)comboBox.GetValue(ItemsWidthProperty);
        }

        public static void SetItemsWidth(ComboBox comboBox, double value)
        {
            comboBox.SetValue(ItemsWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.RegisterAttached("ItemsWidth", typeof(double), typeof(ComboBoxHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsHeight
        public static double GetItemsHeight(ComboBox comboBox)
        {
            return (double)comboBox.GetValue(ItemsHeightProperty);
        }

        public static void SetItemsHeight(ComboBox comboBox, double value)
        {
            comboBox.SetValue(ItemsHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.RegisterAttached("ItemsHeight", typeof(double), typeof(ComboBoxHelper), new PropertyMetadata(30.0));
        #endregion

        #region ItemsFontSize
        public static double GetItemsFontSize(ComboBox comboBox)
        {
            return (double)comboBox.GetValue(ItemsFontSizeProperty);
        }

        public static void SetItemsFontSize(ComboBox comboBox, double value)
        {
            comboBox.SetValue(ItemsFontSizeProperty, value);
        }

        public static readonly DependencyProperty ItemsFontSizeProperty =
            DependencyProperty.RegisterAttached("ItemsFontSize", typeof(double), typeof(ComboBoxHelper), new PropertyMetadata(SystemFonts.MessageFontSize));
        #endregion

        #region ItemsMargin
        public static Thickness GetItemsMargin(ComboBox comboBox)
        {
            return (Thickness)comboBox.GetValue(ItemsMarginProperty);
        }

        public static void SetItemsMargin(ComboBox comboBox, Thickness value)
        {
            comboBox.SetValue(ItemsMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.RegisterAttached("ItemsMargin", typeof(Thickness), typeof(ComboBoxHelper));
        #endregion

        #region ItemsPadding
        public static Thickness GetItemsPadding(ComboBox comboBox)
        {
            return (Thickness)comboBox.GetValue(ItemsPaddingProperty);
        }

        public static void SetItemsPadding(ComboBox comboBox, Thickness value)
        {
            comboBox.SetValue(ItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.RegisterAttached("ItemsPadding", typeof(Thickness), typeof(ComboBoxHelper));
        #endregion

        #region ItemsCornerRadius
        public static CornerRadius GetItemsCornerRadius(ComboBox comboBox)
        {
            return (CornerRadius)comboBox.GetValue(ItemsCornerRadiusProperty);
        }

        public static void SetItemsCornerRadius(ComboBox comboBox, CornerRadius value)
        {
            comboBox.SetValue(ItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCornerRadius", typeof(CornerRadius), typeof(ComboBoxHelper));
        #endregion

        #region ItemsBackground
        public static Brush GetItemsBackground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsBackgroundProperty);
        }

        public static void SetItemsBackground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(ComboBoxHelper), new PropertyMetadata(Brushes.Transparent));

        #endregion

        #region ItemsBorderBrush
        public static Brush GetItemsBorderBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsBorderBrushProperty);
        }

        public static void SetItemsBorderBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsBorderBrush", typeof(Brush), typeof(ComboBoxHelper));

        #endregion

        #region ItemsForeground
        public static Brush GetItemsForeground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsForegroundProperty);
        }

        public static void SetItemsForeground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsForeground", typeof(Brush), typeof(ComboBoxHelper));

        #endregion

        #region ItemsBorderThickness
        public static Thickness GetItemsBorderThickness(ComboBox comboBox)
        {
            return (Thickness)comboBox.GetValue(ItemsBorderThicknessProperty);
        }

        public static void SetItemsBorderThickness(ComboBox comboBox, Thickness value)
        {
            comboBox.SetValue(ItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsBorderThickness", typeof(Thickness), typeof(ComboBoxHelper));
        #endregion

        #region ItemsHoverBackground
        public static Brush GetItemsHoverBackground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsHoverBackgroundProperty);
        }

        public static void SetItemsHoverBackground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBackground", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region ItemsHoverForeground
        public static Brush GetItemsHoverForeground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsHoverForegroundProperty);
        }

        public static void SetItemsHoverForeground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverForeground", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region ItemsHoverBorderBrush
        public static Brush GetItemsHoverBorderBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsHoverBorderBrushProperty);
        }

        public static void SetItemsHoverBorderBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderBrush", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region ItemsHoverBorderThickness
        public static Thickness? GetItemsHoverBorderThickness(ComboBox comboBox)
        {
            return (Thickness?)comboBox.GetValue(ItemsHoverBorderThicknessProperty);
        }

        public static void SetItemsHoverBorderThickness(ComboBox comboBox, Thickness? value)
        {
            comboBox.SetValue(ItemsHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderThickness", typeof(Thickness?), typeof(ComboBoxHelper));
        #endregion

        #region ItemsHoverCornerRadius
        public static CornerRadius? GetItemsHoverCornerRadius(ComboBox comboBox)
        {
            return (CornerRadius?)comboBox.GetValue(ItemsHoverCornerRadiusProperty);
        }

        public static void SetItemsHoverCornerRadius(ComboBox comboBox, CornerRadius? value)
        {
            comboBox.SetValue(ItemsHoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsHoverCornerRadius", typeof(CornerRadius?), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSelectedBackground
        public static Brush GetItemsSelectedBackground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsSelectedBackgroundProperty);
        }

        public static void SetItemsSelectedBackground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsSelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBackground", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSelectedForeground
        public static Brush GetItemsSelectedForeground(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsSelectedForegroundProperty);
        }

        public static void SetItemsSelectedForeground(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsSelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedForeground", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSelectedBorderBrush
        public static Brush GetItemsSelectedBorderBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsSelectedBorderBrushProperty);
        }

        public static void SetItemsSelectedBorderBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsSelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderBrush", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSelectedBorderThickness
        public static Thickness? GetItemsSelectedBorderThickness(ComboBox comboBox)
        {
            return (Thickness?)comboBox.GetValue(ItemsSelectedBorderThicknessProperty);
        }

        public static void SetItemsSelectedBorderThickness(ComboBox comboBox, Thickness? value)
        {
            comboBox.SetValue(ItemsSelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderThickness", typeof(Thickness?), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSelectedCornerRadius
        public static CornerRadius? GetItemsSelectedCornerRadius(ComboBox comboBox)
        {
            return (CornerRadius?)comboBox.GetValue(ItemsSelectedCornerRadiusProperty);
        }

        public static void SetItemsSelectedCornerRadius(ComboBox comboBox, CornerRadius? value)
        {
            comboBox.SetValue(ItemsSelectedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedCornerRadius", typeof(CornerRadius?), typeof(ComboBoxHelper));
        #endregion

        #region ItemsRemoveButtonVisibility
        public static AuxiliaryButtonVisibility GetItemsRemoveButtonVisibility(ComboBox comboBox)
        {
            return (AuxiliaryButtonVisibility)comboBox.GetValue(ItemsRemoveButtonVisibilityProperty);
        }

        public static void SetItemsRemoveButtonVisibility(ComboBox comboBox, AuxiliaryButtonVisibility value)
        {
            comboBox.SetValue(ItemsRemoveButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsRemoveButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsRemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSeparatorBrush
        public static Brush GetItemsSeparatorBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(ItemsSeparatorBrushProperty);
        }

        public static void SetItemsSeparatorBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(ItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorBrush", typeof(Brush), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSeparatorThickness
        public static double GetItemsSeparatorThickness(ComboBox comboBox)
        {
            return (double)comboBox.GetValue(ItemsSeparatorThicknessProperty);
        }

        public static void SetItemsSeparatorThickness(ComboBox comboBox, double value)
        {
            comboBox.SetValue(ItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorThickness", typeof(double), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSeparatorMargin
        public static Thickness GetItemsSeparatorMargin(ComboBox comboBox)
        {
            return (Thickness)comboBox.GetValue(ItemsSeparatorMarginProperty);
        }

        public static void SetItemsSeparatorMargin(ComboBox comboBox, Thickness value)
        {
            comboBox.SetValue(ItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorMargin", typeof(Thickness), typeof(ComboBoxHelper));
        #endregion

        #region ItemsSeparatorVisibility
        public static Visibility GetItemsSeparatorVisibility(ComboBox comboBox)
        {
            return (Visibility)comboBox.GetValue(ItemsSeparatorVisibilityProperty);
        }

        public static void SetItemsSeparatorVisibility(ComboBox comboBox, Visibility value)
        {
            comboBox.SetValue(ItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorVisibility", typeof(Visibility), typeof(ComboBoxHelper));
        #endregion

        #endregion

        #endregion

        #region Internal Properties

        #region SearchTextBoxHook
        internal static bool GetSearchTextBoxHook(TextBox textBox)
        {
            return (bool)textBox.GetValue(SearchTextBoxHookProperty);
        }

        internal static void SetSearchTextBoxHook(TextBox textBox, bool value)
        {
            textBox.SetValue(SearchTextBoxHookProperty, value);
        }

        internal static readonly DependencyProperty SearchTextBoxHookProperty =
            DependencyProperty.RegisterAttached("SearchTextBoxHook", typeof(bool), typeof(ComboBoxHelper), new PropertyMetadata(OnSearchTextBoxHookChanged));
        #endregion

        #endregion

        #region Commands

        #region RemoveCommand
        public static ICommand GetRemoveCommand(ComboBoxItem comboBoxItem)
        {
            return (ICommand)comboBoxItem.GetValue(RemoveCommandProperty);
        }

        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.RegisterAttached("RemoveCommand", typeof(ICommand), typeof(ComboBoxHelper), new PropertyMetadata(new RelayCommand(OnRemoveCommandExecute)));
        #endregion

        #region ClearCommand
        public static ICommand GetClearCommand(UIElement element)
        {
            return (ICommand)element.GetValue(ClearCommandProperty);
        }

        public static readonly DependencyProperty ClearCommandProperty =
            DependencyProperty.RegisterAttached("ClearCommand", typeof(ICommand), typeof(ComboBoxHelper), new PropertyMetadata(new RelayCommand<ComboBox>(OnClearCommandExecute)));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnSearchTextBoxHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textBox = (TextBox)d;
            textBox.TextChanged -= TextBox_TextChanged;
            if ((bool)e.NewValue)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }
        }

        private static void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            var comboBox = textBox.TemplatedParent as ComboBox;
            if (comboBox != null)
            {
                comboBox.RaiseEvent(new SearchTextChangedRoutedEventArgs(SearchTextChangedEvent, textBox.Text));
            }
        }

        private static void OnRemoveCommandExecute(object obj)
        {
            var comboBoxItem = (ComboBoxItem)obj;
            var comboBox = (ComboBox)ItemsControl.ItemsControlFromItemContainer(comboBoxItem);
            var animationDuration = GetRemovingAnimationDuration(comboBox);
            var animationEase = GetRemovingAnimationEasing(comboBox);
            var dataItem = comboBox.ItemContainerGenerator.ItemFromContainer(comboBoxItem);

            var removingArgs = new ItemRemovingRoutedEventArgs(ItemRemovingEvent, dataItem);
            comboBox.RaiseEvent(removingArgs);
            if (removingArgs.Cancel)
            {
                return;
            }

            var action = new Action(() =>
            {
                comboBox.Dispatcher.Invoke(new Action(() =>
                {
                    var collectionView = (IEditableCollectionView)comboBox.Items;
                    if (collectionView.CanRemove)
                    {
                        collectionView.Remove(dataItem);
                    }
                    else
                    {
                        comboBox.Items.Remove(dataItem);
                    }

                    var removedArgs = new ItemRemovedRoutedEventArgs(ItemRemovedEvent, dataItem);
                    comboBox.RaiseEvent(removedArgs);
                }));
            });
            if (animationDuration != null && ((TimeSpan)animationDuration).TotalMilliseconds > 0)
            {
                AnimationUtil.BeginDoubleAnimation(comboBoxItem, ComboBoxItem.HeightProperty, null, 0, animationDuration, null, animationEase, action);
            }
            else
            {
                action?.Invoke();
            }
        }

        private static void OnStaysOpenOnEditChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var comboBox = d as ComboBox;
            comboBox.StaysOpenOnEdit = (bool)e.NewValue;

            comboBox.RemoveHandler(TextBox.GotFocusEvent, (RoutedEventHandler)OnTextBoxGotFocus);
            comboBox.RemoveHandler(TextBox.TextChangedEvent, (RoutedEventHandler)OnTextBoxTextChangedEvent);

            if ((bool)e.NewValue)
            {
                comboBox.AddHandler(TextBox.GotFocusEvent, (RoutedEventHandler)OnTextBoxGotFocus);
                comboBox.AddHandler(TextBox.TextChangedEvent, (RoutedEventHandler)OnTextBoxTextChangedEvent);
            }
        }

        private static void OnTextBoxTextChangedEvent(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox.IsEditable && comboBox.IsKeyboardFocusWithin && !comboBox.IsDropDownOpen && !string.IsNullOrEmpty(comboBox.Text))
            {
                comboBox.IsDropDownOpen = true;
                if(e.OriginalSource is TextBox textBox)
                {
                    textBox.Focus();
                    var comboText = comboBox.Text;
                    if (!string.IsNullOrEmpty(comboText))
                    {
                        textBox.CaretIndex = comboText.Length;
                    }
                }
            }
        }

        private static void OnTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox.IsEditable && !comboBox.IsDropDownOpen && e.OriginalSource is TextBox)
            {
                comboBox.IsDropDownOpen = true;
                if (e.OriginalSource is TextBox textBox)
                {
                    textBox.Focus();
                    var comboText = comboBox.Text;
                    if (!string.IsNullOrEmpty(comboText))
                    {
                        textBox.CaretIndex = comboText.Length;
                    }
                }
            }
        }

        private static void OnBindToEnumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var comboBox = d as ComboBox;

            var type = e.NewValue?.GetType();

            if (type != null)
            {
                var enumList = new ArrayList();
                foreach (Enum item in Enum.GetValues(type))
                {
                    var field = type.GetField(item.ToString());
                    if (null != field)
                    {
                        var descriptions = field.GetCustomAttributes(typeof(DescriptionAttribute), true) as DescriptionAttribute[];
                        if (descriptions.Length > 0)
                        {
                            enumList.Add(new EnumInfo(descriptions[0].Description, item));
                        }
                        else
                        {
                            enumList.Add(new EnumInfo(item.ToString(), item));
                        }
                    }
                }
                comboBox.DisplayMemberPath = nameof(EnumInfo.DisplayName);
                comboBox.SelectedValuePath = nameof(EnumInfo.Value);
                comboBox.ItemsSource = enumList;
            }
        }

        private static void OnClearCommandExecute(ComboBox comboBox)
        {
            comboBox.Text = null;
            comboBox.SelectedIndex = -1;
            comboBox.Focus();
        }

        private static void OnFocusToEditorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var comboBox = (ComboBox)d;
            comboBox.GotFocus -= ComboBox_GotFocus;

            if ((bool)e.NewValue)
            {
                comboBox.GotFocus -= ComboBox_GotFocus;
                comboBox.GotFocus += ComboBox_GotFocus;
            }
        }

        private static void ComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var comboBox = (ComboBox)sender;
            if (comboBox.IsEditable)
            {
                var textBox = (comboBox.Template.FindName("PART_EditableTextBox", comboBox) as TextBox);
                if (textBox != null)
                {
                    textBox.Focus();
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }
        #endregion

    }

}
