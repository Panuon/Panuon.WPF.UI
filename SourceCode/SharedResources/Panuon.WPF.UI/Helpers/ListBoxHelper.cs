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
    public static class ListBoxHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey RemoveButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(ListBoxHelper), nameof(RemoveButtonStyleKey));
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
            = EventManager.RegisterRoutedEvent("ItemRemoving", RoutingStrategy.Bubble, typeof(ItemRemovingRoutedEventHandler), typeof(ListBoxHelper));
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
            = EventManager.RegisterRoutedEvent("ItemRemoved", RoutingStrategy.Bubble, typeof(ItemRemovedRoutedEventHandler), typeof(ListBoxHelper));
        #endregion

        #region ItemClick
        public static void AddItemClickHandler(UIElement element, RoutedEventHandler handler)
        {
            element.AddHandler(ItemClickEvent, handler);
        }

        public static void RemoveItemClickHandler(UIElement element, RoutedEventHandler handler)
        {
            element.RemoveHandler(ItemClickEvent, handler);
        }

        public static readonly RoutedEvent ItemClickEvent
            = EventManager.RegisterRoutedEvent("ItemClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ListBoxHelper));
        #endregion

        #endregion

        #region Properties

        #region CornerRadius
        public static CornerRadius GetCornerRadius(ListBox listBox)
        {
            return (CornerRadius)listBox.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(ListBox listBox, CornerRadius value)
        {
            listBox.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(ListBoxHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(ListBox listBox)
        {
            return (Color?)listBox.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(ListBox listBox, Color? value)
        {
            listBox.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ListBoxHelper));
        #endregion

        #region RemoveButtonStyle
        public static Style GetRemoveButtonStyle(ListBox listBox)
        {
            return (Style)listBox.GetValue(RemoveButtonStyleProperty);
        }

        public static void SetRemoveButtonStyle(ListBox listBox, Style value)
        {
            listBox.SetValue(RemoveButtonStyleProperty, value);
        }

        public static readonly DependencyProperty RemoveButtonStyleProperty =
            DependencyProperty.RegisterAttached("RemoveButtonStyle", typeof(Style), typeof(ListBoxHelper));
        #endregion

        #region RemovingAnimationDuration
        public static TimeSpan? GetRemovingAnimationDuration(ListBox listBox)
        {
            return (TimeSpan?)listBox.GetValue(RemovingAnimationDurationProperty);
        }

        public static void SetRemovingAnimationDuration(ListBox listBox, TimeSpan? value)
        {
            listBox.SetValue(RemovingAnimationDurationProperty, value);
        }

        public static readonly DependencyProperty RemovingAnimationDurationProperty =
            DependencyProperty.RegisterAttached("RemovingAnimationDuration", typeof(TimeSpan?), typeof(ListBoxHelper));
        #endregion

        #region RemovingAnimationEasing
        public static AnimationEasing GetRemovingAnimationEasing(ListBox listBox)
        {
            return (AnimationEasing)listBox.GetValue(RemovingAnimationEasingProperty);
        }

        public static void SetRemovingAnimationEasing(ListBox listBox, AnimationEasing value)
        {
            listBox.SetValue(RemovingAnimationEasingProperty, value);
        }

        public static readonly DependencyProperty RemovingAnimationEasingProperty =
            DependencyProperty.RegisterAttached("RemovingAnimationEasing", typeof(AnimationEasing), typeof(ListBoxHelper));
        #endregion

        #region AutoScrollIntoView
        public static bool GetAutoScrollIntoView(ListBox listBox)
        {
            return (bool)listBox.GetValue(AutoScrollIntoViewProperty);
        }

        public static void SetAutoScrollIntoView(ListBox listBox, bool value)
        {
            listBox.SetValue(AutoScrollIntoViewProperty, value);
        }

        public static readonly DependencyProperty AutoScrollIntoViewProperty =
            DependencyProperty.RegisterAttached("AutoScrollIntoView", typeof(bool), typeof(ListBoxHelper), new PropertyMetadata(false, OnAutoScrollIntoViewChanged));
        #endregion

        #region Scrollable
        public static bool GetScrollable(ListBox listBox)
        {
            return (bool)listBox.GetValue(ScrollableProperty);
        }

        public static void SetScrollable(ListBox listBox, bool value)
        {
            listBox.SetValue(ScrollableProperty, value);
        }

        public static readonly DependencyProperty ScrollableProperty =
            DependencyProperty.RegisterAttached("Scrollable", typeof(bool), typeof(ListBoxHelper), new PropertyMetadata(true));
        #endregion

        #region EmptyContent
        public static object GetEmptyContent(ListBox listBox)
        {
            return (object)listBox.GetValue(EmptyContentProperty);
        }

        public static void SetEmptyContent(ListBox listBox, object value)
        {
            listBox.SetValue(EmptyContentProperty, value);
        }

        public static readonly DependencyProperty EmptyContentProperty =
            DependencyProperty.RegisterAttached("EmptyContent", typeof(object), typeof(ListBoxHelper));
        #endregion

        #region SelectedItems
        public static IList GetSelectedItems(ListBox listBox)
        {
            return listBox.SelectedItems;
        }

        public static void SetSelectedItems(ListBox listBox, IList value)
        {
            throw new Exception("ListBoxHelper.SelectedItems is a read-only property.");
        }

        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.RegisterAttached("SelectedItems", typeof(IList), typeof(ListBoxHelper));
        #endregion

        #region BindToEnum
        public static Enum GetBindToEnum(ListBox listBox)
        {
            return (Enum)listBox.GetValue(BindToEnumProperty);
        }

        public static void SetBindToEnum(ListBox listBox, Enum value)
        {
            listBox.SetValue(BindToEnumProperty, value);
        }

        public static readonly DependencyProperty BindToEnumProperty =
            DependencyProperty.RegisterAttached("BindToEnum", typeof(Enum), typeof(ListBoxHelper), new PropertyMetadata(OnBindToEnumChanged));
        #endregion

        #region Items Properties

        #region ItemsIcon
        public static object GetItemsIcon(ListBox listBox)
        {
            return (object)listBox.GetValue(ItemsIconProperty);
        }

        public static void SetItemsIcon(ListBox listBox, object value)
        {
            listBox.SetValue(ItemsIconProperty, value);
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.RegisterAttached("ItemsIcon", typeof(object), typeof(ListBoxHelper));
        #endregion

        #region ItemsIconPlacement
        public static IconPlacement GetItemsIconPlacement(ListBox listBox)
        {
            return (IconPlacement)listBox.GetValue(ItemsIconPlacementProperty);
        }

        public static void SetItemsIconPlacement(ListBox listBox, IconPlacement value)
        {
            listBox.SetValue(ItemsIconPlacementProperty, value);
        }

        public static readonly DependencyProperty ItemsIconPlacementProperty =
            DependencyProperty.RegisterAttached("ItemsIconPlacement", typeof(IconPlacement), typeof(ListBoxHelper));
        #endregion

        #region ItemsIconWidth
        public static double GetItemsIconWidth(ListBox listBox)
        {
            return (double)listBox.GetValue(ItemsIconWidthProperty);
        }

        public static void SetItemsIconWidth(ListBox listBox, double value)
        {
            listBox.SetValue(ItemsIconWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsIconWidthProperty =
            DependencyProperty.RegisterAttached("ItemsIconWidth", typeof(double), typeof(ListBoxHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsWidth
        public static double GetItemsWidth(ListBox listBox)
        {
            return (double)listBox.GetValue(ItemsWidthProperty);
        }

        public static void SetItemsWidth(ListBox listBox, double value)
        {
            listBox.SetValue(ItemsWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.RegisterAttached("ItemsWidth", typeof(double), typeof(ListBoxHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsHeight
        public static double GetItemsHeight(ListBox listBox)
        {
            return (double)listBox.GetValue(ItemsHeightProperty);
        }

        public static void SetItemsHeight(ListBox listBox, double value)
        {
            listBox.SetValue(ItemsHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.RegisterAttached("ItemsHeight", typeof(double), typeof(ListBoxHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsMinHeight
        public static double GetItemsMinHeight(ListBox listBox)
        {
            return (double)listBox.GetValue(ItemsMinHeightProperty);
        }

        public static void SetItemsMinHeight(ListBox listBox, double value)
        {
            listBox.SetValue(ItemsMinHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsMinHeightProperty =
            DependencyProperty.RegisterAttached("ItemsMinHeight", typeof(double), typeof(ListBoxHelper), new PropertyMetadata(0d));
        #endregion

        #region ItemsMaxHeight
        public static double GetItemsMaxHeight(ListBox listBox)
        {
            return (double)listBox.GetValue(ItemsMaxHeightProperty);
        }

        public static void SetItemsMaxHeight(ListBox listBox, double value)
        {
            listBox.SetValue(ItemsMaxHeightProperty, value);
        }

        public static readonly DependencyProperty ItemsMaxHeightProperty =
            DependencyProperty.RegisterAttached("ItemsMaxHeight", typeof(double), typeof(ListBoxHelper), new PropertyMetadata(double.PositiveInfinity));
        #endregion

        #region ItemsMinWidth
        public static double GetItemsMinWidth(ListBox listBox)
        {
            return (double)listBox.GetValue(ItemsMinWidthProperty);
        }

        public static void SetItemsMinWidth(ListBox listBox, double value)
        {
            listBox.SetValue(ItemsMinWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsMinWidthProperty =
            DependencyProperty.RegisterAttached("ItemsMinWidth", typeof(double), typeof(ListBoxHelper), new PropertyMetadata(0d));
        #endregion

        #region ItemsMaxWidth
        public static double GetItemsMaxWidth(ListBox listBox)
        {
            return (double)listBox.GetValue(ItemsMaxWidthProperty);
        }

        public static void SetItemsMaxWidth(ListBox listBox, double value)
        {
            listBox.SetValue(ItemsMaxWidthProperty, value);
        }

        public static readonly DependencyProperty ItemsMaxWidthProperty =
            DependencyProperty.RegisterAttached("ItemsMaxWidth", typeof(double), typeof(ListBoxHelper), new PropertyMetadata(double.PositiveInfinity));
        #endregion

        #region ItemsPadding
        public static Thickness GetItemsPadding(ListBox listBox)
        {
            return (Thickness)listBox.GetValue(ItemsPaddingProperty);
        }

        public static void SetItemsPadding(ListBox listBox, Thickness value)
        {
            listBox.SetValue(ItemsPaddingProperty, value);
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.RegisterAttached("ItemsPadding", typeof(Thickness), typeof(ListBoxHelper));
        #endregion

        #region ItemsMargin
        public static Thickness GetItemsMargin(ListBox listBox)
        {
            return (Thickness)listBox.GetValue(ItemsMarginProperty);
        }

        public static void SetItemsMargin(ListBox listBox, Thickness value)
        {
            listBox.SetValue(ItemsMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.RegisterAttached("ItemsMargin", typeof(Thickness), typeof(ListBoxHelper));
        #endregion

        #region ItemsShadowColor
        public static Color? GetItemsShadowColor(ListBox listBox)
        {
            return (Color?)listBox.GetValue(ItemsShadowColorProperty);
        }

        public static void SetItemsShadowColor(ListBox listBox, Color? value)
        {
            listBox.SetValue(ItemsShadowColorProperty, value);
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.RegisterAttached("ItemsShadowColor", typeof(Color?), typeof(ListBoxHelper));
        #endregion

        #region ItemsCornerRadius
        public static CornerRadius GetItemsCornerRadius(ListBox listBox)
        {
            return (CornerRadius)listBox.GetValue(ItemsCornerRadiusProperty);
        }

        public static void SetItemsCornerRadius(ListBox listBox, CornerRadius value)
        {
            listBox.SetValue(ItemsCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsCornerRadius", typeof(CornerRadius), typeof(ListBoxHelper));
        #endregion

        #region ItemsBackground
        public static Brush GetItemsBackground(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsBackgroundProperty);
        }

        public static void SetItemsBackground(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsBackground", typeof(Brush), typeof(ListBoxHelper), new PropertyMetadata(Brushes.Transparent));

        #endregion

        #region ItemsBorderBrush
        public static Brush GetItemsBorderBrush(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsBorderBrushProperty);
        }

        public static void SetItemsBorderBrush(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsBorderBrush", typeof(Brush), typeof(ListBoxHelper));

        #endregion

        #region ItemsBorderThickness
        public static Thickness GetItemsBorderThickness(ListBox listBox)
        {
            return (Thickness)listBox.GetValue(ItemsBorderThicknessProperty);
        }

        public static void SetItemsBorderThickness(ListBox listBox, Thickness value)
        {
            listBox.SetValue(ItemsBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsBorderThickness", typeof(Thickness), typeof(ListBoxHelper));
        #endregion

        #region ItemsHoverBackground
        public static Brush GetItemsHoverBackground(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsHoverBackgroundProperty);
        }

        public static void SetItemsHoverBackground(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBackground", typeof(Brush), typeof(ListBoxHelper));
        #endregion

        #region ItemsHoverForeground
        public static Brush GetItemsHoverForeground(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsHoverForegroundProperty);
        }

        public static void SetItemsHoverForeground(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsHoverForeground", typeof(Brush), typeof(ListBoxHelper));
        #endregion

        #region ItemsHoverBorderBrush
        public static Brush GetItemsHoverBorderBrush(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsHoverBorderBrushProperty);
        }

        public static void SetItemsHoverBorderBrush(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderBrush", typeof(Brush), typeof(ListBoxHelper));
        #endregion

        #region ItemsHoverBorderThickness
        public static Thickness? GetItemsHoverBorderThickness(ListBox listBox)
        {
            return (Thickness?)listBox.GetValue(ItemsHoverBorderThicknessProperty);
        }

        public static void SetItemsHoverBorderThickness(ListBox listBox, Thickness? value)
        {
            listBox.SetValue(ItemsHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsHoverBorderThickness", typeof(Thickness?), typeof(ListBoxHelper));
        #endregion

        #region ItemsHoverCornerRadius
        public static CornerRadius? GetItemsHoverCornerRadius(ListBox listBox)
        {
            return (CornerRadius?)listBox.GetValue(ItemsHoverCornerRadiusProperty);
        }

        public static void SetItemsHoverCornerRadius(ListBox listBox, CornerRadius? value)
        {
            listBox.SetValue(ItemsHoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsHoverCornerRadius", typeof(CornerRadius?), typeof(ListBoxHelper));
        #endregion

        #region ItemsHoverShadowColor
        public static Color? GetItemsHoverShadowColor(ListBox listBox)
        {
            return (Color?)listBox.GetValue(ItemsHoverShadowColorProperty);
        }

        public static void SetItemsHoverShadowColor(ListBox listBox, Color? value)
        {
            listBox.SetValue(ItemsHoverShadowColorProperty, value);
        }

        public static readonly DependencyProperty ItemsHoverShadowColorProperty =
            DependencyProperty.RegisterAttached("ItemsHoverShadowColor", typeof(Color?), typeof(ListBoxHelper));
        #endregion

        #region ItemsSelectedBackground
        public static Brush GetItemsSelectedBackground(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsSelectedBackgroundProperty);
        }

        public static void SetItemsSelectedBackground(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsSelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBackground", typeof(Brush), typeof(ListBoxHelper));
        #endregion

        #region ItemsSelectedForeground
        public static Brush GetItemsSelectedForeground(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsSelectedForegroundProperty);
        }

        public static void SetItemsSelectedForeground(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsSelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedForegroundProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedForeground", typeof(Brush), typeof(ListBoxHelper));
        #endregion

        #region ItemsSelectedBorderBrush
        public static Brush GetItemsSelectedBorderBrush(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsSelectedBorderBrushProperty);
        }

        public static void SetItemsSelectedBorderBrush(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsSelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderBrush", typeof(Brush), typeof(ListBoxHelper));
        #endregion

        #region ItemsSelectedBorderThickness
        public static Thickness? GetItemsSelectedBorderThickness(ListBox listBox)
        {
            return (Thickness?)listBox.GetValue(ItemsSelectedBorderThicknessProperty);
        }

        public static void SetItemsSelectedBorderThickness(ListBox listBox, Thickness? value)
        {
            listBox.SetValue(ItemsSelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedBorderThickness", typeof(Thickness?), typeof(ListBoxHelper));
        #endregion

        #region ItemsSelectedCornerRadius
        public static CornerRadius? GetItemsSelectedCornerRadius(ListBox listBox)
        {
            return (CornerRadius?)listBox.GetValue(ItemsSelectedCornerRadiusProperty);
        }

        public static void SetItemsSelectedCornerRadius(ListBox listBox, CornerRadius? value)
        {
            listBox.SetValue(ItemsSelectedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedCornerRadius", typeof(CornerRadius?), typeof(ListBoxHelper));
        #endregion

        #region ItemsSelectedShadowColor
        public static Color? GetItemsSelectedShadowColor(ListBox listBox)
        {
            return (Color?)listBox.GetValue(ItemsSelectedShadowColorProperty);
        }

        public static void SetItemsSelectedShadowColor(ListBox listBox, Color? value)
        {
            listBox.SetValue(ItemsSelectedShadowColorProperty, value);
        }

        public static readonly DependencyProperty ItemsSelectedShadowColorProperty =
            DependencyProperty.RegisterAttached("ItemsSelectedShadowColor", typeof(Color?), typeof(ListBoxHelper));
        #endregion

        #region ItemsRemoveButtonVisibility
        public static AuxiliaryButtonVisibility GetItemsRemoveButtonVisibility(ListBox listBox)
        {
            return (AuxiliaryButtonVisibility)listBox.GetValue(ItemsRemoveButtonVisibilityProperty);
        }

        public static void SetItemsRemoveButtonVisibility(ListBox listBox, AuxiliaryButtonVisibility value)
        {
            listBox.SetValue(ItemsRemoveButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsRemoveButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsRemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(ListBoxHelper));
        #endregion

        #region ItemsSeparatorBrush
        public static Brush GetItemsSeparatorBrush(ListBox listBox)
        {
            return (Brush)listBox.GetValue(ItemsSeparatorBrushProperty);
        }

        public static void SetItemsSeparatorBrush(ListBox listBox, Brush value)
        {
            listBox.SetValue(ItemsSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorBrush", typeof(Brush), typeof(ListBoxHelper), new PropertyMetadata(Brushes.LightGray));
        #endregion

        #region ItemsSeparatorThickness
        public static double GetItemsSeparatorThickness(ListBox listBox)
        {
            return (double)listBox.GetValue(ItemsSeparatorThicknessProperty);
        }

        public static void SetItemsSeparatorThickness(ListBox listBox, double value)
        {
            listBox.SetValue(ItemsSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorThickness", typeof(double), typeof(ListBoxHelper), new PropertyMetadata(1d));
        #endregion

        #region ItemsSeparatorMargin
        public static Thickness GetItemsSeparatorMargin(ListBox listBox)
        {
            return (Thickness)listBox.GetValue(ItemsSeparatorMarginProperty);
        }

        public static void SetItemsSeparatorMargin(ListBox listBox, Thickness value)
        {
            listBox.SetValue(ItemsSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorMargin", typeof(Thickness), typeof(ListBoxHelper));
        #endregion

        #region ItemsSeparatorVisibility
        public static Visibility GetItemsSeparatorVisibility(ListBox listBox)
        {
            return (Visibility)listBox.GetValue(ItemsSeparatorVisibilityProperty);
        }

        public static void SetItemsSeparatorVisibility(ListBox listBox, Visibility value)
        {
            listBox.SetValue(ItemsSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorVisibility", typeof(Visibility), typeof(ListBoxHelper), new PropertyMetadata(Visibility.Collapsed));
        #endregion

        #region ItemsSeparatorOrientation
        public static Orientation GetItemsSeparatorOrientation(ListBox listBox)
        {
            return (Orientation)listBox.GetValue(ItemsSeparatorOrientationProperty);
        }

        public static void SetItemsSeparatorOrientation(ListBox listBox, Orientation value)
        {
            listBox.SetValue(ItemsSeparatorOrientationProperty, value);
        }

        public static readonly DependencyProperty ItemsSeparatorOrientationProperty =
            DependencyProperty.RegisterAttached("ItemsSeparatorOrientation", typeof(Orientation), typeof(ListBoxHelper), new PropertyMetadata(Orientation.Vertical));
        #endregion

        #endregion

        #endregion

        #region Internal Properties

        #region Hook
        internal static bool GetHook(ListBox listBox)
        {
            return (bool)listBox.GetValue(HookProperty);
        }

        internal static void SetHook(ListBox listBox, bool value)
        {
            listBox.SetValue(HookProperty, value);
        }

        internal static readonly DependencyProperty HookProperty =
            DependencyProperty.RegisterAttached("Hook", typeof(bool), typeof(ListBoxHelper), new PropertyMetadata(OnHookChanged));
        #endregion

        #endregion

        #region Commands

        #region RemoveCommand
        public static ICommand GetRemoveCommand(ListBoxItem listBoxItem)
        {
            return (ICommand)listBoxItem.GetValue(RemoveCommandProperty);
        }

        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.RegisterAttached("RemoveCommand", typeof(ICommand), typeof(ListBoxHelper), new PropertyMetadata(new RelayCommand(OnRemoveCommandExecute)));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var listBox = (ListBox)d;

            if ((bool)e.NewValue)
            {
                listBox.SetValue(SelectedItemsProperty, listBox.SelectedItems);
            }
        }

        private static void OnRemoveCommandExecute(object obj)
        {
            var listBoxItem = (ListBoxItem)obj;
            var listBox = (ListBox)ItemsControl.ItemsControlFromItemContainer(listBoxItem);
            var animationDuration = GetRemovingAnimationDuration(listBox);
            var animationEase = GetRemovingAnimationEasing(listBox);
            var dataItem = listBox.ItemContainerGenerator.ItemFromContainer(listBoxItem);

            var removingArgs = new ItemRemovingRoutedEventArgs(ItemRemovingEvent, dataItem);
            listBox.RaiseEvent(removingArgs);
            if (removingArgs.Cancel)
            {
                return;
            }

            var action = new Action(() =>
            {
                listBox.Dispatcher.Invoke(new Action(() =>
                {
                    var collectionView = (IEditableCollectionView)listBox.Items;
                    if (collectionView.CanRemove)
                    {
                        collectionView.Remove(dataItem);
                    }
                    else
                    {
                        listBox.Items.Remove(dataItem);
                    }

                    var removedArgs = new ItemRemovedRoutedEventArgs(ItemRemovedEvent, dataItem);
                    listBox.RaiseEvent(removedArgs);
                }));
            });
            if (animationDuration != null && ((TimeSpan)animationDuration).TotalMilliseconds > 0)
            {
                AnimationUtil.BeginDoubleAnimation(listBoxItem, ListBoxItem.HeightProperty, null, 0, animationDuration, null, animationEase, action);
            }
            else
            {
                action?.Invoke();
            }
        }

        private static void OnAutoScrollIntoViewChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var listBox = (ListBox)d;
            listBox.SelectionChanged -= ListBox_SelectionChanged;
            if((bool)e.NewValue)
            {
                listBox.SelectionChanged += ListBox_SelectionChanged;
            }
        }

        private static void OnBindToEnumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var listBox = d as ListBox;

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
                listBox.DisplayMemberPath = nameof(EnumInfo.DisplayName);
                listBox.SelectedValuePath = nameof(EnumInfo.Value);
                listBox.ItemsSource = enumList;
            }
        }


        private static void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listBox = (ListBox)sender;
            if(listBox.SelectedItem is object selectedItem)
            {
                listBox.ScrollIntoView(selectedItem);
            }
        }
        #endregion
    }
}
