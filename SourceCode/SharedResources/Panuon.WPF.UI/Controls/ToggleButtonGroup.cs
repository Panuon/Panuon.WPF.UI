using Panuon.WPF.UI.Internal.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class ToggleButtonGroup
        : MultiSelector
    {
        #region Fields
        private string _groupId = Guid.NewGuid().ToString();
        #endregion

        #region Ctor
        static ToggleButtonGroup()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(ToggleButtonGroup), 
                new FrameworkPropertyMetadata(typeof(ToggleButtonGroup))
                );
        }

        public ToggleButtonGroup()
        {
            AddHandler(ToggleButton.CheckedEvent, new RoutedEventHandler(OnToggleButtonCheckChanged));
            AddHandler(ToggleButton.UncheckedEvent, new RoutedEventHandler(OnToggleButtonCheckChanged));
        }
        #endregion

        #region Overrides
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            if (item is ToggleButton toggleButton)
            {
                ToggleButtonHelper.SetGroupName(toggleButton, AllowMultipleSelection ? null : _groupId);
                return true;
            }
            return false;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            var toggleButton = new ToggleButton();
            ToggleButtonHelper.SetGroupName(toggleButton, AllowMultipleSelection ? null : _groupId);
            return toggleButton;
        }
        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey ToggleButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(ToggleButtonGroup), nameof(ToggleButtonStyleKey));
        #endregion

        #region Properties

        #region AllowMultipleSelection
        public bool AllowMultipleSelection
        {
            get { return (bool)GetValue(AllowMultipleSelectionProperty); }
            set { SetValue(AllowMultipleSelectionProperty, value); }
        }

        public static readonly DependencyProperty AllowMultipleSelectionProperty =
            DependencyProperty.Register("AllowMultipleSelection", typeof(bool), typeof(ToggleButtonGroup), new PropertyMetadata(true, OnAllowMultipleSelectionChanged));
        #endregion

        #region BindToEnum
        public Enum BindToEnum
        {
            get { return (Enum)GetValue(BindToEnumProperty); }
            set { SetValue(BindToEnumProperty, value); }
        }

        public static readonly DependencyProperty BindToEnumProperty =
            DependencyProperty.Register("BindToEnum", typeof(Enum), typeof(ToggleButtonGroup), new PropertyMetadata(OnBindToEnumChanged));
        #endregion

        #region ItemsWidth
        public double ItemsWidth
        {
            get { return (double)GetValue(ItemsWidthProperty); }
            set { SetValue(ItemsWidthProperty, value); }
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.Register("ItemsWidth", typeof(double), typeof(ToggleButtonGroup), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsHeight
        public double ItemsHeight
        {
            get { return (double)GetValue(ItemsHeightProperty); }
            set { SetValue(ItemsHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.Register("ItemsHeight", typeof(double), typeof(ToggleButtonGroup), new PropertyMetadata(30d));
        #endregion

        #region ItemsIcon
        public object ItemsIcon
        {
            get { return (object)GetValue(ItemsIconProperty); }
            set { SetValue(ItemsIconProperty, value); }
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.Register("ItemsIcon", typeof(object), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsIconWidth
        public double ItemsIconWidth
        {
            get { return (double)GetValue(ItemsIconWidthProperty); }
            set { SetValue(ItemsIconWidthProperty, value); }
        }

        public static readonly DependencyProperty ItemsIconWidthProperty =
            DependencyProperty.Register("ItemsIconWidth", typeof(double), typeof(ToggleButtonGroup), new PropertyMetadata(double.NaN));
        #endregion

        #region ItemsFontSize
        public double ItemsFontSize
        {
            get { return (double)GetValue(ItemsFontSizeProperty); }
            set { SetValue(ItemsFontSizeProperty, value); }
        }

        public static readonly DependencyProperty ItemsFontSizeProperty =
            DependencyProperty.Register("ItemsFontSize", typeof(double), typeof(ToggleButtonGroup), new PropertyMetadata(SystemFonts.MessageFontSize));
        #endregion

        #region ItemsCheckBoxVisibility
        public Visibility ItemsCheckBoxVisibility
        {
            get { return (Visibility)GetValue(ItemsCheckBoxVisibilityProperty); }
            set { SetValue(ItemsCheckBoxVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckBoxVisibilityProperty =
            DependencyProperty.Register("ItemsCheckBoxVisibility", typeof(Visibility), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsMargin
        public Thickness ItemsMargin
        {
            get { return (Thickness)GetValue(ItemsMarginProperty); }
            set { SetValue(ItemsMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.Register("ItemsMargin", typeof(Thickness), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsPadding
        public Thickness ItemsPadding
        {
            get { return (Thickness)GetValue(ItemsPaddingProperty); }
            set { SetValue(ItemsPaddingProperty, value); }
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.Register("ItemsPadding", typeof(Thickness), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsForeground
        public Brush ItemsForeground
        {
            get { return (Brush)GetValue(ItemsForegroundProperty); }
            set { SetValue(ItemsForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.Register("ItemsForeground", typeof(Brush), typeof(ToggleButtonGroup), new PropertyMetadata(Brushes.Black));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(ToggleButtonGroup), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsBorderThickness
        public Thickness ItemsBorderThickness
        {
            get { return (Thickness)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsHoverBackground
        public Brush ItemsHoverBackground
        {
            get { return (Brush)GetValue(ItemsHoverBackgroundProperty); }
            set { SetValue(ItemsHoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.Register("ItemsHoverBackground", typeof(Brush), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsHoverForeground
        public Brush ItemsHoverForeground
        {
            get { return (Brush)GetValue(ItemsHoverForegroundProperty); }
            set { SetValue(ItemsHoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.Register("ItemsHoverForeground", typeof(Brush), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsHoverBorderBrush
        public Brush ItemsHoverBorderBrush
        {
            get { return (Brush)GetValue(ItemsHoverBorderBrushProperty); }
            set { SetValue(ItemsHoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.Register("ItemsHoverBorderBrush", typeof(Brush), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsHoverShadowColor
        public Color? ItemsHoverShadowColor
        {
            get { return (Color?)GetValue(ItemsHoverShadowColorProperty); }
            set { SetValue(ItemsHoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverShadowColorProperty =
            DependencyProperty.Register("ItemsHoverShadowColor", typeof(Color?), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsCheckedBackground
        public Brush ItemsCheckedBackground
        {
            get { return (Brush)GetValue(ItemsCheckedBackgroundProperty); }
            set { SetValue(ItemsCheckedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBackgroundProperty =
            DependencyProperty.Register("ItemsCheckedBackground", typeof(Brush), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsCheckedForeground
        public Brush ItemsCheckedForeground
        {
            get { return (Brush)GetValue(ItemsCheckedForegroundProperty); }
            set { SetValue(ItemsCheckedForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedForegroundProperty =
            DependencyProperty.Register("ItemsCheckedForeground", typeof(Brush), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsCheckedBorderBrush
        public Brush ItemsCheckedBorderBrush
        {
            get { return (Brush)GetValue(ItemsCheckedBorderBrushProperty); }
            set { SetValue(ItemsCheckedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBorderBrushProperty =
            DependencyProperty.Register("ItemsCheckedBorderBrush", typeof(Brush), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsCheckedBorderThickness
        public Thickness? ItemsCheckedBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsCheckedBorderThicknessProperty); }
            set { SetValue(ItemsCheckedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBorderThicknessProperty =
            DependencyProperty.Register("ItemsCheckedBorderThickness", typeof(Thickness?), typeof(ToggleButtonGroup));
        #endregion

        #region ItemsHorizontalContentAlignment
        public HorizontalAlignment ItemsHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(ItemsHorizontalContentAlignmentProperty); }
            set { SetValue(ItemsHorizontalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ItemsHorizontalContentAlignmentProperty =
            DependencyProperty.Register("ItemsHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(ToggleButtonGroup), new PropertyMetadata(HorizontalAlignment.Center));
        #endregion

        #region ItemsVerticalContentAlignment
        public VerticalAlignment ItemsVerticalContentAlignment
        {
            get { return (VerticalAlignment)GetValue(ItemsVerticalContentAlignmentProperty); }
            set { SetValue(ItemsVerticalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ItemsVerticalContentAlignmentProperty =
            DependencyProperty.Register("ItemsVerticalContentAlignment", typeof(VerticalAlignment), typeof(ToggleButtonGroup), new PropertyMetadata(VerticalAlignment.Center));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnBindToEnumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var toggleButtonGroup = d as ToggleButtonGroup;

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
                toggleButtonGroup.DisplayMemberPath = nameof(EnumInfo.DisplayName);
                toggleButtonGroup.SelectedValuePath = nameof(EnumInfo.Value);
                toggleButtonGroup.ItemsSource = enumList;
            }
        }

        private static void OnAllowMultipleSelectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var toggleButtonGroup = d as ToggleButtonGroup;
            toggleButtonGroup.OnAllowMultipleSelectionChanged();
        }

        private void OnToggleButtonCheckChanged(object sender, RoutedEventArgs e)
        {
            var toggleButton = e.OriginalSource as ToggleButton;
            if(toggleButton.IsChecked == true)
            {
                BeginUpdateSelectedItems();
                SelectedItems.Add(ItemContainerGenerator.ItemFromContainer(toggleButton));
                EndUpdateSelectedItems();
            }
            else
            {
                BeginUpdateSelectedItems();
                SelectedItems.Remove(ItemContainerGenerator.ItemFromContainer(toggleButton));
                EndUpdateSelectedItems();
            }
        }
        #endregion

        #region Functions
        private void OnAllowMultipleSelectionChanged()
        {
            foreach (ToggleButton toggleButton in ItemContainerGenerator.Items)
            {
                ToggleButtonHelper.SetGroupName(toggleButton, AllowMultipleSelection ? null : _groupId);
            }
        }
        #endregion
    }
}
