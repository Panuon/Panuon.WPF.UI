using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class MenuItemHelper
    {
        #region CornerRadius
        public static CornerRadius GetCornerRadius(MenuItem menuItem)
        {
            return (CornerRadius)menuItem.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(MenuItem menuItem, CornerRadius value)
        {
            menuItem.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(MenuItemHelper));
        #endregion

        #region RemoveButtonVisibility
        public static AuxiliaryButtonVisibility GetRemoveButtonVisibility(MenuItem menuItem)
        {
            return (AuxiliaryButtonVisibility)menuItem.GetValue(RemoveButtonVisibilityProperty);
        }

        public static void SetRemoveButtonVisibility(MenuItem menuItem, AuxiliaryButtonVisibility value)
        {
            menuItem.SetValue(RemoveButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty RemoveButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("RemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(MenuItemHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(MenuItemHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(MenuItemHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(MenuItemHelper));
        #endregion

        #region ClickBackground
        public static Brush GetClickBackground(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(ClickBackgroundProperty);
        }

        public static void SetClickBackground(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(ClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty ClickBackgroundProperty =
            DependencyProperty.RegisterAttached("ClickBackground", typeof(Brush), typeof(MenuItemHelper));
        #endregion

        #region ClickForeground
        public static Brush GetClickForeground(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(ClickForegroundProperty);
        }

        public static void SetClickForeground(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(ClickForegroundProperty, value);
        }

        public static readonly DependencyProperty ClickForegroundProperty =
            DependencyProperty.RegisterAttached("ClickForeground", typeof(Brush), typeof(MenuItemHelper));
        #endregion

        #region ClickBorderBrush
        public static Brush GetClickBorderBrush(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(ClickBorderBrushProperty);
        }

        public static void SetClickBorderBrush(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(ClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("ClickBorderBrush", typeof(Brush), typeof(MenuItemHelper));
        #endregion

        #region CheckedBackground
        public static Brush GetCheckedBackground(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(CheckedBackgroundProperty);
        }

        public static void SetCheckedBackground(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(CheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("CheckedBackground", typeof(Brush), typeof(MenuItemHelper));
        #endregion

        #region CheckedForeground
        public static Brush GetCheckedForeground(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(CheckedForegroundProperty);
        }

        public static void SetCheckedForeground(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(CheckedForegroundProperty, value);
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.RegisterAttached("CheckedForeground", typeof(Brush), typeof(MenuItemHelper));
        #endregion

        #region CheckedBorderBrush
        public static Brush GetCheckedBorderBrush(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(CheckedBorderBrushProperty);
        }

        public static void SetCheckedBorderBrush(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(CheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("CheckedBorderBrush", typeof(Brush), typeof(MenuItemHelper));
        #endregion

        #region CheckedBorderThickness
        public static Thickness? GetCheckedBorderThickness(MenuItem menuItem)
        {
            return (Thickness?)menuItem.GetValue(CheckedBorderThicknessProperty);
        }

        public static void SetCheckedBorderThickness(MenuItem menuItem, Thickness? value)
        {
            menuItem.SetValue(CheckedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("CheckedBorderThickness", typeof(Thickness?), typeof(MenuItemHelper));
        #endregion

        #region SeparatorBrush
        public static Brush GetSeparatorBrush(MenuItem menuItem)
        {
            return (Brush)menuItem.GetValue(SeparatorBrushProperty);
        }

        public static void SetSeparatorBrush(MenuItem menuItem, Brush value)
        {
            menuItem.SetValue(SeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.RegisterAttached("SeparatorBrush", typeof(Brush), typeof(MenuItemHelper));
        #endregion

        #region SeparatorThickness
        public static double GetSeparatorThickness(MenuItem menuItem)
        {
            return (double)menuItem.GetValue(SeparatorThicknessProperty);
        }

        public static void SetSeparatorThickness(MenuItem menuItem, double value)
        {
            menuItem.SetValue(SeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("SeparatorThickness", typeof(double), typeof(MenuItemHelper));
        #endregion

        #region SeparatorMargin
        public static Thickness GetSeparatorMargin(MenuItem menuItem)
        {
            return (Thickness)menuItem.GetValue(SeparatorMarginProperty);
        }

        public static void SetSeparatorMargin(MenuItem menuItem, Thickness value)
        {
            menuItem.SetValue(SeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.RegisterAttached("SeparatorMargin", typeof(Thickness), typeof(MenuItemHelper));
        #endregion

        #region SeparatorVisibility
        public static Visibility GetSeparatorVisibility(MenuItem menuItem)
        {
            return (Visibility)menuItem.GetValue(SeparatorVisibilityProperty);
        }

        public static void SetSeparatorVisibility(MenuItem menuItem, Visibility value)
        {
            menuItem.SetValue(SeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("SeparatorVisibility", typeof(Visibility), typeof(MenuItemHelper));
        #endregion
    }
}
