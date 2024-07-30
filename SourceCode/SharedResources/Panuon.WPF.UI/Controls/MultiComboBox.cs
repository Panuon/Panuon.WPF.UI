using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Models;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Panuon.WPF.UI
{
    public class MultiComboBox
        : MultiSelector
    {
        #region Fields
        private List<object> _selectionBoxItems;
        private ItemsPresenter _itemsPresenter;
        private DropDown _dropDown;
        private ScrollViewer _itemsScrollViewer;
        private Border _containerBorder;
        #endregion

        #region Ctor
        static MultiComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MultiComboBox), new FrameworkPropertyMetadata(typeof(MultiComboBox)));
        }
        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey ClearButtonStyleKey { get; } =
          new ComponentResourceKey(typeof(MultiComboBox), nameof(ClearButtonStyleKey));

        public static ComponentResourceKey RemoveButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(MultiComboBox), nameof(RemoveButtonStyleKey));

        public static ComponentResourceKey ToggleArrowTransformControlStyleKey { get; } =
            new ComponentResourceKey(typeof(MultiComboBox), nameof(ToggleArrowTransformControlStyleKey));

        public static ComponentResourceKey CheckedIconTemplateKey { get; } =
            new ComponentResourceKey(typeof(MultiComboBox), nameof(CheckedIconTemplateKey));

        public static ComponentResourceKey SelectionBoxItemLabelStyleKey { get; } =
            new ComponentResourceKey(typeof(MultiComboBox), nameof(SelectionBoxItemLabelStyleKey));
        #endregion

        #region Events

        #region ItemRemoving
        public event RoutedEventHandler ItemRemoving
        {
            add { AddHandler(ItemRemovingEvent, value); }
            remove { RemoveHandler(ItemRemovingEvent, value); }
        }

        public static readonly RoutedEvent ItemRemovingEvent =
            EventManager.RegisterRoutedEvent("ItemRemoving", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MultiComboBox));
        #endregion

        #region ItemRemoved
        public event RoutedEventHandler ItemRemoved
        {
            add { AddHandler(ItemRemovedEvent, value); }
            remove { RemoveHandler(ItemRemovedEvent, value); }
        }

        public static readonly RoutedEvent ItemRemovedEvent =
            EventManager.RegisterRoutedEvent("ItemRemoved", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MultiComboBox));
        #endregion

        #endregion

        #region Properties

        #region BindToEnum
        public Enum BindToEnum
        {
            get { return (Enum)GetValue(BindToEnumProperty); }
            set { SetValue(BindToEnumProperty, value); }
        }

        public static readonly DependencyProperty BindToEnumProperty =
            DependencyProperty.Register("BindToEnum", typeof(Enum), typeof(MultiComboBox), new PropertyMetadata(OnBindToEnumChanged));
        #endregion

        #region ClearCommand
        public ICommand ClearCommand
        {
            get { return (ICommand)GetValue(ClearCommandProperty); }
            set { SetValue(ClearCommandProperty, value); }
        }

        public static readonly DependencyProperty ClearCommandProperty =
            DependencyProperty.Register("ClearCommand", typeof(ICommand), typeof(MultiComboBox), new PropertyMetadata(new RelayCommand<MultiComboBox>(OnClearCommandExecute)));
        #endregion

        #region UnselectCommand
        public ICommand UnselectCommand
        {
            get { return (ICommand)GetValue(UnselectCommandProperty); }
            set { SetValue(UnselectCommandProperty, value); }
        }

        public static readonly DependencyProperty UnselectCommandProperty =
            DependencyProperty.Register("UnselectCommand", typeof(ICommand), typeof(MultiComboBox), new PropertyMetadata(new RelayCommand(OnUnselectCommandExecute)));
        #endregion

        #region Icon
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(MultiComboBox));
        #endregion

        #region Watermark
        public object Watermark
        {
            get { return (object)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark", typeof(object), typeof(MultiComboBox));
        #endregion

        #region WatermarkForeground
        public Brush WatermarkForeground
        {
            get { return (Brush)GetValue(WatermarkForegroundProperty); }
            set { SetValue(WatermarkForegroundProperty, value); }
        }

        public static readonly DependencyProperty WatermarkForegroundProperty =
            VisualStateHelper.WatermarkForegroundProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region IsDropDownOpen
        public bool IsDropDownOpen
        {
            get { return (bool)GetValue(IsDropDownOpenProperty); }
            set { SetValue(IsDropDownOpenProperty, value); }
        }

        public static readonly DependencyProperty IsDropDownOpenProperty =
            DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(MultiComboBox));
        #endregion

        #region MaxDropDownHeight
        public double MaxDropDownHeight
        {
            get { return (double)GetValue(MaxDropDownHeightProperty); }
            set { SetValue(MaxDropDownHeightProperty, value); }
        }

        public static readonly DependencyProperty MaxDropDownHeightProperty =
            DependencyProperty.Register("MaxDropDownHeight", typeof(double), typeof(MultiComboBox), new PropertyMetadata(150d));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region FocusedBackground
        public Brush FocusedBackground
        {
            get { return (Brush)GetValue(FocusedBackgroundProperty); }
            set { SetValue(FocusedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedBackgroundProperty =
            VisualStateHelper.FocusedBackgroundProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region FocusedForeground
        public Brush FocusedForeground
        {
            get { return (Brush)GetValue(FocusedForegroundProperty); }
            set { SetValue(FocusedForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedForegroundProperty =
            VisualStateHelper.FocusedForegroundProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region FocusedBorderBrush
        public Brush FocusedBorderBrush
        {
            get { return (Brush)GetValue(FocusedBorderBrushProperty); }
            set { SetValue(FocusedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            VisualStateHelper.FocusedBorderBrushProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region FocusedBorderThickness
        public Thickness? FocusedBorderThickness
        {
            get { return (Thickness?)GetValue(FocusedBorderThicknessProperty); }
            set { SetValue(FocusedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty FocusedBorderThicknessProperty =
            VisualStateHelper.FocusedBorderThicknessProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region FocusedCornerRadius
        public CornerRadius? FocusedCornerRadius
        {
            get { return (CornerRadius?)GetValue(FocusedCornerRadiusProperty); }
            set { SetValue(FocusedCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty FocusedCornerRadiusProperty =
            VisualStateHelper.FocusedCornerRadiusProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region FocusedShadowColor
        public Color? FocusedShadowColor
        {
            get { return (Color?)GetValue(FocusedShadowColorProperty); }
            set { SetValue(FocusedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty FocusedShadowColorProperty =
            VisualStateHelper.FocusedShadowColorProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region FocusedWatermarkForeground
        public Brush FocusedWatermarkForeground
        {
            get { return (Brush)GetValue(FocusedWatermarkForegroundProperty); }
            set { SetValue(FocusedWatermarkForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedWatermarkForegroundProperty =
            VisualStateHelper.FocusedWatermarkForegroundProperty.AddOwner(typeof(MultiComboBox));
        #endregion

        #region ClearTextOnClick
        public bool ClearTextOnClick
        {
            get { return (bool)GetValue(ClearTextOnClickProperty); }
            set { SetValue(ClearTextOnClickProperty, value); }
        }

        public static readonly DependencyProperty ClearTextOnClickProperty =
            DependencyProperty.Register("ClearTextOnClick", typeof(bool), typeof(MultiComboBox), new PropertyMetadata(false));
        #endregion

        #region ClearButtonStyle
        public static Style GetClearButtonStyle(MultiComboBox multiComboBox)
        {
            return (Style)multiComboBox.GetValue(ClearButtonStyleProperty);
        }

        public static void SetClearButtonStyle(MultiComboBox multiComboBox, Style value)
        {
            multiComboBox.SetValue(ClearButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ClearButtonStyleProperty =
            DependencyProperty.RegisterAttached("ClearButtonStyle", typeof(Style), typeof(MultiComboBox));
        #endregion

        #region ClearButtonVisibility
        public AuxiliaryButtonVisibility ClearButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(ClearButtonVisibilityProperty); }
            set { SetValue(ClearButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.Register("ClearButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(MultiComboBox));
        #endregion

        #region RemoveButtonStyle
        public static Style GetRemoveButtonStyle(MultiComboBox multiComboBox)
        {
            return (Style)multiComboBox.GetValue(RemoveButtonStyleProperty);
        }

        public static void SetRemoveButtonStyle(MultiComboBox multiComboBox, Style value)
        {
            multiComboBox.SetValue(RemoveButtonStyleProperty, value);
        }

        public static readonly DependencyProperty RemoveButtonStyleProperty =
            DependencyProperty.RegisterAttached("RemoveButtonStyle", typeof(Style), typeof(MultiComboBox));
        #endregion

        #region RemoveCommand
        public ICommand RemoveCommand
        {
            get { return (ICommand)GetValue(RemoveCommandProperty); }
            set { SetValue(RemoveCommandProperty, value); }
        }

        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.Register("RemoveCommand", typeof(ICommand), typeof(MultiComboBox), new PropertyMetadata(new RelayCommand(OnRemoveCommandExecute)));
        #endregion

        #region RemovingAnimationDuration
        public TimeSpan? RemovingAnimationDuration
        {
            get { return (TimeSpan?)GetValue(RemovingAnimationDurationProperty); }
            set { SetValue(RemovingAnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty RemovingAnimationDurationProperty =
            DependencyProperty.Register("RemovingAnimationDuration", typeof(TimeSpan?), typeof(MultiComboBox));
        #endregion

        #region RemovingAnimationEasing
        public AnimationEasing RemovingAnimationEasing
        {
            get { return (AnimationEasing)GetValue(RemovingAnimationEasingProperty); }
            set { SetValue(RemovingAnimationEasingProperty, value); }
        }

        public static readonly DependencyProperty RemovingAnimationEasingProperty =
            DependencyProperty.Register("RemovingAnimationEasing", typeof(AnimationEasing), typeof(MultiComboBox));
        #endregion

        #region UncheckedIconTemplate
        public DataTemplate UncheckedIconTemplate
        {
            get { return (DataTemplate)GetValue(UncheckedIconTemplateProperty); }
            set { SetValue(UncheckedIconTemplateProperty, value); }
        }

        public static readonly DependencyProperty UncheckedIconTemplateProperty =
            DependencyProperty.Register("UncheckedIconTemplate", typeof(DataTemplate), typeof(MultiComboBox));
        #endregion

        #region CheckedIconTemplate
        public DataTemplate CheckedIconTemplate
        {
            get { return (DataTemplate)GetValue(CheckedIconTemplateProperty); }
            set { SetValue(CheckedIconTemplateProperty, value); }
        }

        public static readonly DependencyProperty CheckedIconTemplateProperty =
            DependencyProperty.Register("CheckedIconTemplate", typeof(DataTemplate), typeof(MultiComboBox));
        #endregion

        #region ToggleArrowTransformControlStyle
        public Style ToggleArrowTransformControlStyle
        {
            get { return (Style)GetValue(ToggleArrowTransformControlStyleProperty); }
            set { SetValue(ToggleArrowTransformControlStyleProperty, value); }
        }

        public static readonly DependencyProperty ToggleArrowTransformControlStyleProperty =
            DependencyProperty.Register("ToggleArrowTransformControlStyle", typeof(Style), typeof(MultiComboBox));
        #endregion

        #region SelectionBoxItemLabelStyle
        public Style SelectionBoxItemLabelStyle
        {
            get { return (Style)GetValue(SelectionBoxItemLabelStyleProperty); }
            set { SetValue(SelectionBoxItemLabelStyleProperty, value); }
        }

        public static readonly DependencyProperty SelectionBoxItemLabelStyleProperty =
            DependencyProperty.Register("SelectionBoxItemLabelStyle", typeof(Style), typeof(MultiComboBox));
        #endregion

        #region Items Properties

        #region ItemsWidth
        public double ItemsWidth
        {
            get { return (double)GetValue(ItemsWidthProperty); }
            set { SetValue(ItemsWidthProperty, value); }
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.Register("ItemsWidth", typeof(double), typeof(MultiComboBox), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsHeight
        public double ItemsHeight
        {
            get { return (double)GetValue(ItemsHeightProperty); }
            set { SetValue(ItemsHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.Register("ItemsHeight", typeof(double), typeof(MultiComboBox), new PropertyMetadata(30d));
        #endregion

        #region ItemsIcon
        public object ItemsIcon
        {
            get { return (object)GetValue(ItemsIconProperty); }
            set { SetValue(ItemsIconProperty, value); }
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.Register("ItemsIcon", typeof(object), typeof(MultiComboBox));
        #endregion

        #region ItemsIconWidth
        public double ItemsIconWidth
        {
            get { return (double)GetValue(ItemsIconWidthProperty); }
            set { SetValue(ItemsIconWidthProperty, value); }
        }

        public static readonly DependencyProperty ItemsIconWidthProperty =
            DependencyProperty.Register("ItemsIconWidth", typeof(double), typeof(MultiComboBox), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsFontSize
        public double ItemsFontSize
        {
            get { return (double)GetValue(ItemsFontSizeProperty); }
            set { SetValue(ItemsFontSizeProperty, value); }
        }

        public static readonly DependencyProperty ItemsFontSizeProperty =
            DependencyProperty.Register("ItemsFontSize", typeof(double), typeof(MultiComboBox), new PropertyMetadata(SystemFonts.MessageFontSize));
        #endregion

        #region ItemsCheckBoxVisibility
        public Visibility ItemsCheckBoxVisibility
        {
            get { return (Visibility)GetValue(ItemsCheckBoxVisibilityProperty); }
            set { SetValue(ItemsCheckBoxVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckBoxVisibilityProperty =
            DependencyProperty.Register("ItemsCheckBoxVisibility", typeof(Visibility), typeof(MultiComboBox));
        #endregion

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(MultiComboBox));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(MultiComboBox));
        #endregion

        #region ItemsMargin
        public Thickness ItemsMargin
        {
            get { return (Thickness)GetValue(ItemsMarginProperty); }
            set { SetValue(ItemsMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.Register("ItemsMargin", typeof(Thickness), typeof(MultiComboBox));
        #endregion

        #region ItemsPadding
        public Thickness ItemsPadding
        {
            get { return (Thickness)GetValue(ItemsPaddingProperty); }
            set { SetValue(ItemsPaddingProperty, value); }
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.Register("ItemsPadding", typeof(Thickness), typeof(MultiComboBox));
        #endregion

        #region ItemsForeground
        public Brush ItemsForeground
        {
            get { return (Brush)GetValue(ItemsForegroundProperty); }
            set { SetValue(ItemsForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.Register("ItemsForeground", typeof(Brush), typeof(MultiComboBox), new PropertyMetadata(Brushes.Black));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(MultiComboBox), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(MultiComboBox));
        #endregion

        #region ItemsBorderThickness
        public Thickness ItemsBorderThickness
        {
            get { return (Thickness)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness), typeof(MultiComboBox));
        #endregion

        #region ItemsHoverBackground
        public Brush ItemsHoverBackground
        {
            get { return (Brush)GetValue(ItemsHoverBackgroundProperty); }
            set { SetValue(ItemsHoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.Register("ItemsHoverBackground", typeof(Brush), typeof(MultiComboBox));
        #endregion

        #region ItemsHoverForeground
        public Brush ItemsHoverForeground
        {
            get { return (Brush)GetValue(ItemsHoverForegroundProperty); }
            set { SetValue(ItemsHoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.Register("ItemsHoverForeground", typeof(Brush), typeof(MultiComboBox));
        #endregion

        #region ItemsHoverBorderBrush
        public Brush ItemsHoverBorderBrush
        {
            get { return (Brush)GetValue(ItemsHoverBorderBrushProperty); }
            set { SetValue(ItemsHoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.Register("ItemsHoverBorderBrush", typeof(Brush), typeof(MultiComboBox));
        #endregion

        #region ItemsHoverBorderThickness
        public Thickness? ItemsHoverBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsHoverBorderThicknessProperty); }
            set { SetValue(ItemsHoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderThicknessProperty =
            DependencyProperty.Register("ItemsHoverBorderThickness", typeof(Thickness?), typeof(MultiComboBox));
        #endregion

        #region ItemsHoverCornerRadius
        public CornerRadius? ItemsHoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(ItemsHoverCornerRadiusProperty); }
            set { SetValue(ItemsHoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverCornerRadiusProperty =
            DependencyProperty.Register("ItemsHoverCornerRadius", typeof(CornerRadius?), typeof(MultiComboBox));
        #endregion

        #region ItemsHoverShadowColor
        public Color? ItemsHoverShadowColor
        {
            get { return (Color?)GetValue(ItemsHoverShadowColorProperty); }
            set { SetValue(ItemsHoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverShadowColorProperty =
            DependencyProperty.Register("ItemsHoverShadowColor", typeof(Color?), typeof(MultiComboBox));
        #endregion

        #region ItemsSelectedBackground
        public Brush ItemsSelectedBackground
        {
            get { return (Brush)GetValue(ItemsSelectedBackgroundProperty); }
            set { SetValue(ItemsSelectedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedBackgroundProperty =
            DependencyProperty.Register("ItemsSelectedBackground", typeof(Brush), typeof(MultiComboBox));
        #endregion

        #region ItemsSelectedForeground
        public Brush ItemsSelectedForeground
        {
            get { return (Brush)GetValue(ItemsSelectedForegroundProperty); }
            set { SetValue(ItemsSelectedForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedForegroundProperty =
            DependencyProperty.Register("ItemsSelectedForeground", typeof(Brush), typeof(MultiComboBox));
        #endregion

        #region ItemsSelectedBorderBrush
        public Brush ItemsSelectedBorderBrush
        {
            get { return (Brush)GetValue(ItemsSelectedBorderBrushProperty); }
            set { SetValue(ItemsSelectedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedBorderBrushProperty =
            DependencyProperty.Register("ItemsSelectedBorderBrush", typeof(Brush), typeof(MultiComboBox));
        #endregion

        #region ItemsSelectedBorderThickness
        public Thickness? ItemsSelectedBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsSelectedBorderThicknessProperty); }
            set { SetValue(ItemsSelectedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedBorderThicknessProperty =
            DependencyProperty.Register("ItemsSelectedBorderThickness", typeof(Thickness?), typeof(MultiComboBox));
        #endregion

        #region ItemsSelectedCornerRadius
        public CornerRadius? ItemsSelectedCornerRadius
        {
            get { return (CornerRadius?)GetValue(ItemsSelectedCornerRadiusProperty); }
            set { SetValue(ItemsSelectedCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedCornerRadiusProperty =
            DependencyProperty.Register("ItemsSelectedCornerRadius", typeof(CornerRadius?), typeof(MultiComboBox));
        #endregion

        #region ItemsSeparatorBrush
        public Brush ItemsSeparatorBrush
        {
            get { return (Brush)GetValue(ItemsSeparatorBrushProperty); }
            set { SetValue(ItemsSeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.Register("ItemsSeparatorBrush", typeof(Brush), typeof(MultiComboBox));
        #endregion

        #region ItemsSeparatorThickness
        public double ItemsSeparatorThickness
        {
            get { return (double)GetValue(ItemsSeparatorThicknessProperty); }
            set { SetValue(ItemsSeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.Register("ItemsSeparatorThickness", typeof(double), typeof(MultiComboBox));
        #endregion

        #region ItemsSeparatorMargin
        public Thickness ItemsSeparatorMargin
        {
            get { return (Thickness)GetValue(ItemsSeparatorMarginProperty); }
            set { SetValue(ItemsSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.Register("ItemsSeparatorMargin", typeof(Thickness), typeof(MultiComboBox));
        #endregion

        #region ItemsSeparatorVisibility
        public Visibility ItemsSeparatorVisibility
        {
            get { return (Visibility)GetValue(ItemsSeparatorVisibilityProperty); }
            set { SetValue(ItemsSeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.Register("ItemsSeparatorVisibility", typeof(Visibility), typeof(MultiComboBox));
        #endregion

        #region ItemsHorizontalContentAlignment
        public HorizontalAlignment ItemsHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(ItemsHorizontalContentAlignmentProperty); }
            set { SetValue(ItemsHorizontalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ItemsHorizontalContentAlignmentProperty =
            DependencyProperty.Register("ItemsHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(MultiComboBox));
        #endregion

        #region ItemsVerticalContentAlignment
        public VerticalAlignment ItemsVerticalContentAlignment
        {
            get { return (VerticalAlignment)GetValue(ItemsVerticalContentAlignmentProperty); }
            set { SetValue(ItemsVerticalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ItemsVerticalContentAlignmentProperty =
            DependencyProperty.Register("ItemsVerticalContentAlignment", typeof(VerticalAlignment), typeof(MultiComboBox));
        #endregion

        #region ItemsRemoveButtonVisibility
        public AuxiliaryButtonVisibility ItemsRemoveButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(ItemsRemoveButtonVisibilityProperty); }
            set { SetValue(ItemsRemoveButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ItemsRemoveButtonVisibilityProperty =
            DependencyProperty.Register("ItemsRemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(MultiComboBox), new PropertyMetadata(AuxiliaryButtonVisibility.Collapsed));
        #endregion


        #endregion

        #endregion

        #region Internal Properties

        #region SelectionBoxItems
        internal IEnumerable<object> SelectionBoxItems
        {
            get { return (IEnumerable<object>)GetValue(SelectionBoxItemsProperty); }
            private set { SetValue(SelectionBoxItemsProperty, value); }
        }

        internal static readonly DependencyProperty SelectionBoxItemsProperty =
            DependencyProperty.Register("SelectionBoxItems", typeof(IEnumerable<object>), typeof(MultiComboBox));
        #endregion

        #region SelectionBoxItemTemplate
        internal DataTemplate SelectionBoxItemTemplate
        {
            get { return (DataTemplate)GetValue(SelectionBoxItemTemplateProperty); }
            set { SetValue(SelectionBoxItemTemplateProperty, value); }
        }

        internal static readonly DependencyProperty SelectionBoxItemTemplateProperty =
            DependencyProperty.Register("SelectionBoxItemTemplate", typeof(DataTemplate), typeof(MultiComboBox));
        #endregion

        #region SelectionBoxItemStringFormat
        internal string SelectionBoxItemStringFormat
        {
            get { return (string)GetValue(SelectionBoxItemStringFormatProperty); }
            set { SetValue(SelectionBoxItemStringFormatProperty, value); }
        }

        internal static readonly DependencyProperty SelectionBoxItemStringFormatProperty =
            DependencyProperty.Register("SelectionBoxItemStringFormat", typeof(string), typeof(MultiComboBox));
        #endregion

        #endregion

        #region Overrides
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is MultiComboBoxItem;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new MultiComboBoxItem();
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);
            UpdateSelectionBoxItems();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _containerBorder = GetTemplateChild("PART_BorderContainer") as Border;
            _itemsPresenter = GetTemplateChild("PART_ItemsPresenter") as ItemsPresenter;
            _itemsScrollViewer = _itemsPresenter.Parent as ScrollViewer;

            _dropDown = GetTemplateChild("PART_DropDown") as DropDown;
            _dropDown.Opened += DropDown_Opened;
            _dropDown.Closed += DropDown_Closed;

            DropDown_Closed(null, null);
            UpdateSelectionBoxItems();
        }

        private void DropDown_Opened(object sender, EventArgs e)
        {
            _containerBorder.Child = null;
            _itemsScrollViewer.Content = _itemsPresenter;
            
        }

        private void DropDown_Closed(object sender, EventArgs e)
        {
            _itemsScrollViewer.Content = null;
            _containerBorder.Child = _itemsPresenter;
        }
        #endregion

        #region Event Handlers
        private static void OnBindToEnumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var comboBox = d as MultiComboBox;

            var type = e.NewValue?.GetType();

            if (type != null)
            {
                var enumList = new List<EnumInfo>();
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
        #endregion

        #region Functions
        private static void OnRemoveCommandExecute(object obj)
        {
            var comboBoxItem = (MultiComboBoxItem)obj;
            var comboBox = (MultiComboBox)ItemsControl.ItemsControlFromItemContainer(comboBoxItem);
            var animationDuration = comboBox.RemovingAnimationDuration;
            var animationEase = comboBox.RemovingAnimationEasing;
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

        private static void OnClearCommandExecute(MultiComboBox multiComboBox)
        {
            multiComboBox.UnselectAll();
            multiComboBox.Focus();
        }

        private static void OnUnselectCommandExecute(object sender)
        {
            var tagItem = (TagItem)sender;
            var comboBox = ItemsControl.ItemsControlFromItemContainer(tagItem);
            var multiComboBox = tagItem.TemplatedParent;
        }

        private void UpdateSelectionBoxItems()
        {

            _selectionBoxItems = new List<object>();
            foreach (var selectedItem in SelectedItems)
            {
                object item = selectedItem;
                var itemTemplate = ItemTemplate;
                var itemStringFormat = ItemStringFormat;

                if (item is ContentControl contentControl)
                {
                    item = contentControl.Content;
                    itemTemplate = contentControl.ContentTemplate;
                    itemStringFormat = contentControl.ContentStringFormat;
                }
                if(ItemTemplate == null && ItemTemplateSelector == null && itemStringFormat == null)
                {
                    if (item is DependencyObject logicElement)
                    {
                        var clonedElement = item as UIElement;

                        if (clonedElement != null)
                        {
                            var visualBrush = new VisualBrush(clonedElement);
                            visualBrush.Stretch = Stretch.None;

                            visualBrush.ViewboxUnits = BrushMappingMode.Absolute;
                            visualBrush.Viewbox = new Rect(clonedElement.RenderSize);

                            visualBrush.ViewportUnits = BrushMappingMode.Absolute;
                            visualBrush.Viewport = new Rect(clonedElement.RenderSize);

                            var parent = VisualTreeHelper.GetParent(clonedElement);
                            var parentFlowDirection = parent == null ? FlowDirection.LeftToRight : (FlowDirection)parent.GetValue(FlowDirectionProperty);
                            if (this.FlowDirection != parentFlowDirection)
                            {
                                visualBrush.Transform = new MatrixTransform(new Matrix(-1.0, 0.0, 0.0, 1.0, clonedElement.RenderSize.Width, 0.0));
                            }

                            var rect = new Rectangle();
                            rect.Fill = visualBrush;
                            rect.Width = clonedElement.RenderSize.Width;
                            rect.Height = clonedElement.RenderSize.Height;

                           
                            clonedElement.LayoutUpdated += delegate
                            {
                                rect.Width = clonedElement.RenderSize.Width;
                                rect.Height = clonedElement.RenderSize.Height;

                                var newVisualBrush = (VisualBrush)rect.Fill;
                                newVisualBrush.Viewbox = new Rect(clonedElement.RenderSize);
                                newVisualBrush.Viewport = new Rect(clonedElement.RenderSize);
                            };

                            item = rect;
                        }
                        else
                        {
                            item = ExtractString(logicElement);
                        }
                    }
                }
                _selectionBoxItems.Add(item);

                SetCurrentValue(SelectionBoxItemTemplateProperty, itemTemplate);
                SetCurrentValue(SelectionBoxItemStringFormatProperty, itemStringFormat);
            }

            SetCurrentValue(SelectionBoxItemsProperty, _selectionBoxItems);
            CollectionViewSource.GetDefaultView(SelectionBoxItems).Refresh();
        }

        private static string ExtractString(DependencyObject d)
        {
            TextBlock text;
            Visual visual;
            string strValue = String.Empty;

            if ((text = d as TextBlock) != null)
            {
                strValue = text.Text;
            }
            else if ((visual = d as Visual) != null)
            {
                int count = VisualTreeHelper.GetChildrenCount(visual);
                for (int i = 0; i < count; i++)
                {
                    strValue += ExtractString((DependencyObject)(VisualTreeHelper.GetChild(visual, i)));
                }
            }
            else if (d is TextElement textElement)
            {
                strValue += new TextRange(textElement.ContentStart, textElement.ContentEnd).Text;
            }

            return strValue;
        }

        #endregion
    }
}
