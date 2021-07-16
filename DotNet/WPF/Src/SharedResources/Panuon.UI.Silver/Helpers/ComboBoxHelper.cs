using Panuon.UI.Core;
using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class ComboBoxHelper
    {
        #region Routed Event

        #region ItemRemoving
        public static void AddItemRemovingHandler(UIElement element, ItemRemovingEventHandler eventHandler)
        {
            element.AddHandler(ItemRemovingEvent, eventHandler);
        }

        public static void RemoveItemRemovingHandler(UIElement element, ItemRemovingEventHandler eventHandler)
        {
            element.RemoveHandler(ItemRemovingEvent, eventHandler);
        }

        public static readonly RoutedEvent ItemRemovingEvent
            = EventManager.RegisterRoutedEvent("ItemRemoving", RoutingStrategy.Bubble, typeof(ItemRemovingEventHandler), typeof(ComboBoxHelper));
        #endregion

        #region ItemRemoved
        public static void AddItemRemovedHandler(UIElement element, ItemRemovedEventHandler handler)
        {
            element.AddHandler(ItemRemovedEvent, handler);
        }

        public static void RemoveItemRemovedHandler(UIElement element, ItemRemovedEventHandler handler)
        {
            element.RemoveHandler(ItemRemovedEvent, handler);
        }

        public static readonly RoutedEvent ItemRemovedEvent
            = EventManager.RegisterRoutedEvent("ItemRemoved", RoutingStrategy.Bubble, typeof(ItemRemovedEventHandler), typeof(ComboBoxHelper));
        #endregion

        #region SearchTextChanged
        public static void AddSearchTextChangedHandler(UIElement element, SearchTextChangedEventHandler handler)
        {
            element.AddHandler(SearchTextChangedEvent, handler);
        }

        public static void RemoveSearchTextChangedHandler(UIElement element, SearchTextChangedEventHandler handler)
        {
            element.RemoveHandler(SearchTextChangedEvent, handler);
        }

        public static readonly RoutedEvent SearchTextChangedEvent
            = EventManager.RegisterRoutedEvent("SearchTextChanged", RoutingStrategy.Bubble, typeof(SearchTextChangedEventHandler), typeof(ComboBoxHelper));
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
        public static string GetWatermark(ComboBox comboBox)
        {
            return (string)comboBox.GetValue(WatermarkProperty);
        }

        public static void SetWatermark(ComboBox comboBox, string value)
        {
            comboBox.SetValue(WatermarkProperty, value);
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.RegisterAttached("Watermark", typeof(string), typeof(ComboBoxHelper));
        #endregion

        #region WatermarkBrush
        public static Brush GetWatermarkBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(WatermarkBrushProperty);
        }

        public static void SetWatermarkBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(WatermarkBrushProperty, value);
        }

        public static readonly DependencyProperty WatermarkBrushProperty =
            VisualStateHelper.WatermarkBrushProperty.AddOwner(typeof(ComboBoxHelper));
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
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ComboBoxHelper));
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

        #region FocusedWatermarkBrush

        public static Brush GetFocusedWatermarkBrush(ComboBox comboBox)
        {
            return (Brush)comboBox.GetValue(FocusedWatermarkBrushProperty);
        }

        public static void SetFocusedWatermarkBrush(ComboBox comboBox, Brush value)
        {
            comboBox.SetValue(FocusedWatermarkBrushProperty, value);
        }

        public static readonly DependencyProperty FocusedWatermarkBrushProperty =
            VisualStateHelper.FocusedWatermarkBrushProperty.AddOwner(typeof(ComboBoxHelper));
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

        #region RemovingAnimationEase
        public static AnimationEase GetRemovingAnimationEase(ComboBox comboBox)
        {
            return (AnimationEase)comboBox.GetValue(RemovingAnimationEaseProperty);
        }

        public static void SetRemovingAnimationEase(ComboBox comboBox, AnimationEase value)
        {
            comboBox.SetValue(RemovingAnimationEaseProperty, value);
        }

        public static readonly DependencyProperty RemovingAnimationEaseProperty =
            DependencyProperty.RegisterAttached("RemovingAnimationEase", typeof(AnimationEase), typeof(ComboBoxHelper));
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

        #region IsSearchTextBoxPinned
        public static bool GetIsSearchTextBoxPinned(ComboBox comboBox)
        {
            return (bool)comboBox.GetValue(IsSearchTextBoxPinnedProperty);
        }

        public static void SetIsSearchTextBoxPinned(ComboBox comboBox, bool value)
        {
            comboBox.SetValue(IsSearchTextBoxPinnedProperty, value);
        }

        public static readonly DependencyProperty IsSearchTextBoxPinnedProperty =
            DependencyProperty.RegisterAttached("IsSearchTextBoxPinned", typeof(bool), typeof(ComboBoxHelper));
        #endregion 

        #region Items Properties

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
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(ComboBoxHelper));

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
                comboBox.RaiseEvent(new SearchTextChangedEventArgs(SearchTextChangedEvent, textBox.Text));
            }
        }

        private static void OnRemoveCommandExecute(object obj)
        {
            var comboBoxItem = (ComboBoxItem)obj;
            var comboBox = (ComboBox)ItemsControl.ItemsControlFromItemContainer(comboBoxItem);
            var animationDuration = GetRemovingAnimationDuration(comboBox);
            var animationEase = GetRemovingAnimationEase(comboBox);
            var dataItem = comboBox.ItemContainerGenerator.ItemFromContainer(comboBoxItem);

            var removingArgs = new ItemRemovingEventArgs(ItemRemovingEvent, dataItem);
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

                    var removedArgs = new ItemRemovedEventArgs(ItemRemovedEvent, dataItem);
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

            if (type == null)
            {
                comboBox.ItemsSource = null;
                comboBox.SelectedItem = null;
            }
            else
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
                            enumList.Add(new
                            {
                                Name = descriptions[0].Description,
                                Enum = item,
                            });
                        }
                        else
                            enumList.Add(new
                            {
                                Name = item.ToString(),
                                Enum = item,
                            });
                    }
                }
                comboBox.ItemsSource = enumList;
                comboBox.DisplayMemberPath = "Name";
                comboBox.SelectedValuePath = "Enum";
                comboBox.SelectedValue = comboBox.SelectedValue ?? e.NewValue;
            }
        }

        private static void OnClearCommandExecute(ComboBox comboBox)
        {
            comboBox.Text = null;
            comboBox.SelectedIndex = -1;
            comboBox.Focus();
        }

        #endregion

    }

}
