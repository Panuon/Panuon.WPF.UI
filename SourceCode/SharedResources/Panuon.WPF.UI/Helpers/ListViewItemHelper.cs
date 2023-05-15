using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ListViewItemHelper
    {
        #region CornerRadius
        public static CornerRadius GetCornerRadius(ListViewItem listViewItem)
        {
            return (CornerRadius)listViewItem.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(ListViewItem listViewItem, CornerRadius value)
        {
            listViewItem.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ListViewItemHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(ListViewItem listViewItem)
        {
            return (Brush)listViewItem.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(ListViewItem listViewItem, Brush value)
        {
            listViewItem.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ListViewItemHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(ListViewItem listViewItem)
        {
            return (Brush)listViewItem.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(ListViewItem listViewItem, Brush value)
        {
            listViewItem.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ListViewItemHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(ListViewItem listViewItem)
        {
            return (Brush)listViewItem.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(ListViewItem listViewItem, Brush value)
        {
            listViewItem.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ListViewItemHelper));
        #endregion

        #region HoverBorderThickness
        public static Thickness? GetHoverBorderThickness(ComboBoxItem comboBoxItem)
        {
            return (Thickness?)comboBoxItem.GetValue(HoverBorderThicknessProperty);
        }

        public static void SetHoverBorderThickness(ComboBoxItem comboBoxItem, Thickness? value)
        {
            comboBoxItem.SetValue(HoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(ListViewItemHelper));
        #endregion

        #region HoverCornerRadius
        public static CornerRadius? GetHoverCornerRadius(ComboBoxItem comboBoxItem)
        {
            return (CornerRadius?)comboBoxItem.GetValue(HoverCornerRadiusProperty);
        }

        public static void SetHoverCornerRadius(ComboBoxItem comboBoxItem, CornerRadius? value)
        {
            comboBoxItem.SetValue(HoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(ListViewItemHelper));
        #endregion

        #region SelectedBackground
        public static Brush GetSelectedBackground(ListViewItem listViewItem)
        {
            return (Brush)listViewItem.GetValue(SelectedBackgroundProperty);
        }

        public static void SetSelectedBackground(ListViewItem listViewItem, Brush value)
        {
            listViewItem.SetValue(SelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("SelectedBackground", typeof(Brush), typeof(ListViewItemHelper));
        #endregion

        #region SelectedForeground
        public static Brush GetSelectedForeground(ListViewItem listViewItem)
        {
            return (Brush)listViewItem.GetValue(SelectedForegroundProperty);
        }

        public static void SetSelectedForeground(ListViewItem listViewItem, Brush value)
        {
            listViewItem.SetValue(SelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.RegisterAttached("SelectedForeground", typeof(Brush), typeof(ListViewItemHelper));
        #endregion

        #region SelectedBorderBrush
        public static Brush GetSelectedBorderBrush(ListViewItem listViewItem)
        {
            return (Brush)listViewItem.GetValue(SelectedBorderBrushProperty);
        }

        public static void SetSelectedBorderBrush(ListViewItem listViewItem, Brush value)
        {
            listViewItem.SetValue(SelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("SelectedBorderBrush", typeof(Brush), typeof(ListViewItemHelper));
        #endregion

        #region SelectedBorderThickness
        public static Thickness? GetSelectedBorderThickness(ListViewItem listViewItem)
        {
            return (Thickness?)listViewItem.GetValue(SelectedBorderThicknessProperty);
        }

        public static void SetSelectedBorderThickness(ListViewItem listViewItem, Thickness? value)
        {
            listViewItem.SetValue(SelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SelectedBorderThickness", typeof(Thickness?), typeof(ListViewItemHelper));
        #endregion

        #region SelectedCornerRadius
        public static CornerRadius? GetSelectedCornerRadius(ListViewItem listViewItem)
        {
            return (CornerRadius?)listViewItem.GetValue(SelectedCornerRadiusProperty);
        }

        public static void SetSelectedCornerRadius(ListViewItem listViewItem, CornerRadius? value)
        {
            listViewItem.SetValue(SelectedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SelectedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SelectedCornerRadius", typeof(CornerRadius?), typeof(ListViewItemHelper));
        #endregion

        #region SeparatorBrush
        public static Brush GetSeparatorBrush(ListViewItem listViewItem)
        {
            return (Brush)listViewItem.GetValue(SeparatorBrushProperty);
        }

        public static void SetSeparatorBrush(ListViewItem listViewItem, Brush value)
        {
            listViewItem.SetValue(SeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.RegisterAttached("SeparatorBrush", typeof(Brush), typeof(ListViewItemHelper));
        #endregion

        #region SeparatorThickness
        public static double GetSeparatorThickness(ListViewItem listViewItem)
        {
            return (double)listViewItem.GetValue(SeparatorThicknessProperty);
        }

        public static void SetSeparatorThickness(ListViewItem listViewItem, double value)
        {
            listViewItem.SetValue(SeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("SeparatorThickness", typeof(double), typeof(ListViewItemHelper));
        #endregion

        #region SeparatorMargin
        public static Thickness GetSeparatorMargin(ListViewItem listViewItem)
        {
            return (Thickness)listViewItem.GetValue(SeparatorMarginProperty);
        }

        public static void SetSeparatorMargin(ListViewItem listViewItem, Thickness value)
        {
            listViewItem.SetValue(SeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.RegisterAttached("SeparatorMargin", typeof(Thickness), typeof(ListViewItemHelper));
        #endregion

        #region SeparatorVisibility
        public static Visibility GetSeparatorVisibility(ListViewItem listViewItem)
        {
            return (Visibility)listViewItem.GetValue(SeparatorVisibilityProperty);
        }

        public static void SetSeparatorVisibility(ListViewItem listViewItem, Visibility value)
        {
            listViewItem.SetValue(SeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("SeparatorVisibility", typeof(Visibility), typeof(ListViewItemHelper));
        #endregion

    }
}
