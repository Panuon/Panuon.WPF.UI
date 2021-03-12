using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class ComboBoxItemHelper
    {
        #region Icon
        public static object GetIcon(ComboBoxItem comboBoxItem)
        {
            return (object)comboBoxItem.GetValue(IconProperty);
        }

        public static void SetIcon(ComboBoxItem comboBoxItem, object value)
        {
            comboBoxItem.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ComboBoxItemHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(ComboBoxItem comboBoxItem)
        {
            return (CornerRadius)comboBoxItem.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(ComboBoxItem comboBoxItem, CornerRadius value)
        {
            comboBoxItem.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ComboBoxItemHelper));
        #endregion

        #region RemoveButtonVisibility
        public static AuxiliaryButtonVisibility GetRemoveButtonVisibility(ComboBoxItem comboBoxItem)
        {
            return (AuxiliaryButtonVisibility)comboBoxItem.GetValue(RemoveButtonVisibilityProperty);
        }

        public static void SetRemoveButtonVisibility(ComboBoxItem comboBoxItem, AuxiliaryButtonVisibility value)
        {
            comboBoxItem.SetValue(RemoveButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty RemoveButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("RemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(ComboBoxItemHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(ComboBoxItem comboBoxItem)
        {
            return (Brush)comboBoxItem.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(ComboBoxItem comboBoxItem, Brush value)
        {
            comboBoxItem.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ComboBoxItemHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(ComboBoxItem comboBoxItem)
        {
            return (Brush)comboBoxItem.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(ComboBoxItem comboBoxItem, Brush value)
        {
            comboBoxItem.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ComboBoxItemHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(ComboBoxItem comboBoxItem)
        {
            return (Brush)comboBoxItem.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(ComboBoxItem comboBoxItem, Brush value)
        {
            comboBoxItem.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ComboBoxItemHelper));
        #endregion

        #region SelectedBackground
        public static Brush GetSelectedBackground(ComboBoxItem comboBoxItem)
        {
            return (Brush)comboBoxItem.GetValue(SelectedBackgroundProperty);
        }

        public static void SetSelectedBackground(ComboBoxItem comboBoxItem, Brush value)
        {
            comboBoxItem.SetValue(SelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("SelectedBackground", typeof(Brush), typeof(ComboBoxItemHelper));
        #endregion

        #region SelectedForeground
        public static Brush GetSelectedForeground(ComboBoxItem comboBoxItem)
        {
            return (Brush)comboBoxItem.GetValue(SelectedForegroundProperty);
        }

        public static void SetSelectedForeground(ComboBoxItem comboBoxItem, Brush value)
        {
            comboBoxItem.SetValue(SelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.RegisterAttached("SelectedForeground", typeof(Brush), typeof(ComboBoxItemHelper));
        #endregion

        #region SelectedBorderBrush
        public static Brush GetSelectedBorderBrush(ComboBoxItem comboBoxItem)
        {
            return (Brush)comboBoxItem.GetValue(SelectedBorderBrushProperty);
        }

        public static void SetSelectedBorderBrush(ComboBoxItem comboBoxItem, Brush value)
        {
            comboBoxItem.SetValue(SelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("SelectedBorderBrush", typeof(Brush), typeof(ComboBoxItemHelper));
        #endregion

        #region SelectedBorderThickness
        public static Thickness? GetSelectedBorderThickness(ComboBoxItem comboBoxItem)
        {
            return (Thickness?)comboBoxItem.GetValue(SelectedBorderThicknessProperty);
        }

        public static void SetSelectedBorderThickness(ComboBoxItem comboBoxItem, Thickness? value)
        {
            comboBoxItem.SetValue(SelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SelectedBorderThickness", typeof(Thickness?), typeof(ComboBoxItemHelper));
        #endregion

        #region SeparatorBrush
        public static Brush GetSeparatorBrush(ComboBoxItem comboBoxItem)
        {
            return (Brush)comboBoxItem.GetValue(SeparatorBrushProperty);
        }

        public static void SetSeparatorBrush(ComboBoxItem comboBoxItem, Brush value)
        {
            comboBoxItem.SetValue(SeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.RegisterAttached("SeparatorBrush", typeof(Brush), typeof(ComboBoxItemHelper));
        #endregion

        #region SeparatorThickness
        public static double GetSeparatorThickness(ComboBoxItem comboBoxItem)
        {
            return (double)comboBoxItem.GetValue(SeparatorThicknessProperty);
        }

        public static void SetSeparatorThickness(ComboBoxItem comboBoxItem, double value)
        {
            comboBoxItem.SetValue(SeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("SeparatorThickness", typeof(double), typeof(ComboBoxItemHelper));
        #endregion

        #region SeparatorMargin
        public static Thickness GetSeparatorMargin(ComboBoxItem comboBoxItem)
        {
            return (Thickness)comboBoxItem.GetValue(SeparatorMarginProperty);
        }

        public static void SetSeparatorMargin(ComboBoxItem comboBoxItem, Thickness value)
        {
            comboBoxItem.SetValue(SeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.RegisterAttached("SeparatorMargin", typeof(Thickness), typeof(ComboBoxItemHelper));
        #endregion

        #region SeparatorVisibility
        public static Visibility GetSeparatorVisibility(ComboBoxItem comboBoxItem)
        {
            return (Visibility)comboBoxItem.GetValue(SeparatorVisibilityProperty);
        }

        public static void SetSeparatorVisibility(ComboBoxItem comboBoxItem, Visibility value)
        {
            comboBoxItem.SetValue(SeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("SeparatorVisibility", typeof(Visibility), typeof(ComboBoxItemHelper));
        #endregion

    }
}
