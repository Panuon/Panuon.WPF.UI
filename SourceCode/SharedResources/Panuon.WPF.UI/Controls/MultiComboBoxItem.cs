using Panuon.WPF.UI.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class MultiComboBoxItem
        : ListBoxItem
    {
        #region Ctor
        static MultiComboBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MultiComboBoxItem), new FrameworkPropertyMetadata(typeof(MultiComboBoxItem)));
        }
        #endregion

        #region Properties

        #region Icon
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(MultiComboBoxItem));
        #endregion

        #region CheckBoxVisibility
        public Visibility CheckBoxVisibility
        {
            get { return (Visibility)GetValue(CheckBoxVisibilityProperty); }
            set { SetValue(CheckBoxVisibilityProperty, value); }
        }

        public static readonly DependencyProperty CheckBoxVisibilityProperty =
            DependencyProperty.Register("CheckBoxVisibility", typeof(Visibility), typeof(MultiComboBoxItem), new PropertyMetadata(Visibility.Visible));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(MultiComboBoxItem));
        #endregion

        #region RemoveButtonVisibility
        public AuxiliaryButtonVisibility RemoveButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(RemoveButtonVisibilityProperty); }
            set { SetValue(RemoveButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty RemoveButtonVisibilityProperty =
            DependencyProperty.Register("RemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(MultiComboBoxItem), new PropertyMetadata(AuxiliaryButtonVisibility.Collapsed));
        #endregion

        #region UnselectButtonVisibility
        public AuxiliaryButtonVisibility UnselectButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(UnselectButtonVisibilityProperty); }
            set { SetValue(UnselectButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty UnselectButtonVisibilityProperty =
            DependencyProperty.Register("UnselectButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(MultiComboBoxItem), new PropertyMetadata(AuxiliaryButtonVisibility.Collapsed));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(MultiComboBoxItem));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(MultiComboBoxItem));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(MultiComboBoxItem));
        #endregion

        #region HoverBorderThickness
        public Thickness? HoverBorderThickness
        {
            get { return (Thickness?)GetValue(HoverBorderThicknessProperty); }
            set { SetValue(HoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(MultiComboBoxItem));
        #endregion

        #region HoverCornerRadius
        public CornerRadius? HoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(HoverCornerRadiusProperty); }
            set { SetValue(HoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(MultiComboBoxItem));
        #endregion

        #region SelectedBackground
        public Brush SelectedBackground
        {
            get { return (Brush)GetValue(SelectedBackgroundProperty); }
            set { SetValue(SelectedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.Register("SelectedBackground", typeof(Brush), typeof(MultiComboBoxItem));
        #endregion

        #region SelectedForeground
        public Brush SelectedForeground
        {
            get { return (Brush)GetValue(SelectedForegroundProperty); }
            set { SetValue(SelectedForegroundProperty, value); }
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.Register("SelectedForeground", typeof(Brush), typeof(MultiComboBoxItem));
        #endregion

        #region SelectedBorderBrush
        public Brush SelectedBorderBrush
        {
            get { return (Brush)GetValue(SelectedBorderBrushProperty); }
            set { SetValue(SelectedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.Register("SelectedBorderBrush", typeof(Brush), typeof(MultiComboBoxItem));
        #endregion

        #region SelectedBorderThickness
        public Thickness? SelectedBorderThickness
        {
            get { return (Thickness?)GetValue(SelectedBorderThicknessProperty); }
            set { SetValue(SelectedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty SelectedBorderThicknessProperty =
            DependencyProperty.Register("SelectedBorderThickness", typeof(Thickness?), typeof(MultiComboBoxItem));
        #endregion

        #region SelectedCornerRadius
        public CornerRadius? SelectedCornerRadius
        {
            get { return (CornerRadius?)GetValue(SelectedCornerRadiusProperty); }
            set { SetValue(SelectedCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty SelectedCornerRadiusProperty =
            DependencyProperty.Register("SelectedCornerRadius", typeof(CornerRadius?), typeof(MultiComboBoxItem));
        #endregion

        #region SeparatorBrush
        public Brush SeparatorBrush
        {
            get { return (Brush)GetValue(SeparatorBrushProperty); }
            set { SetValue(SeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.Register("SeparatorBrush", typeof(Brush), typeof(MultiComboBoxItem));
        #endregion

        #region SeparatorThickness
        public double SeparatorThickness
        {
            get { return (double)GetValue(SeparatorThicknessProperty); }
            set { SetValue(SeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.Register("SeparatorThickness", typeof(double), typeof(MultiComboBoxItem));
        #endregion

        #region SeparatorMargin
        public Thickness SeparatorMargin
        {
            get { return (Thickness)GetValue(SeparatorMarginProperty); }
            set { SetValue(SeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.Register("SeparatorMargin", typeof(Thickness), typeof(MultiComboBoxItem));
        #endregion

        #region SeparatorVisibility
        public Visibility SeparatorVisibility
        {
            get { return (Visibility)GetValue(SeparatorVisibilityProperty); }
            set { SetValue(SeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.Register("SeparatorVisibility", typeof(Visibility), typeof(MultiComboBoxItem));
        #endregion

        #endregion

        #region Overrides
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            e.Handled = true;

            SetCurrentValue(IsSelectedProperty, !IsSelected);

            base.OnMouseLeftButtonDown(e);
        }
        #endregion

        #region Internal Properties
        internal MultiComboBox ParentMultiComboBox
        {
            get
            {
                return ItemsControl.ItemsControlFromItemContainer(this) as MultiComboBox;
            }
        }
        #endregion

    }
}
