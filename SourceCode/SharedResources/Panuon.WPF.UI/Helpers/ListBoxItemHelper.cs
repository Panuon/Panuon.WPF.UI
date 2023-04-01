using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ListBoxItemHelper
    {
        #region Properties

        #region Icon
        public static object GetIcon(ListBoxItem listBoxItem)
        {
            return (object)listBoxItem.GetValue(IconProperty);
        }

        public static void SetIcon(ListBoxItem listBoxItem, object value)
        {
            listBoxItem.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ListBoxItemHelper));
        #endregion

        #region IconPlacement
        public static IconPlacement GetIconPlacement(ListBoxItem listBoxItem)
        {
            return (IconPlacement)listBoxItem.GetValue(IconPlacementProperty);
        }

        public static void SetIconPlacement(ListBoxItem listBoxItem, IconPlacement value)
        {
            listBoxItem.SetValue(IconPlacementProperty, value);
        }

        public static readonly DependencyProperty IconPlacementProperty =
            DependencyProperty.RegisterAttached("IconPlacement", typeof(IconPlacement), typeof(ListBoxItemHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(ListBoxItem listBoxItem)
        {
            return (CornerRadius)listBoxItem.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(ListBoxItem listBoxItem, CornerRadius value)
        {
            listBoxItem.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ListBoxItemHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(ListBoxItem listBoxItem)
        {
            return (Color?)listBoxItem.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(ListBoxItem listBoxItem, Color? value)
        {
            listBoxItem.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ListBoxItemHelper));
        #endregion

        #region RemoveButtonVisibility
        public static AuxiliaryButtonVisibility GetRemoveButtonVisibility(ListBoxItem listBoxItem)
        {
            return (AuxiliaryButtonVisibility)listBoxItem.GetValue(RemoveButtonVisibilityProperty);
        }

        public static void SetRemoveButtonVisibility(ListBoxItem listBoxItem, AuxiliaryButtonVisibility value)
        {
            listBoxItem.SetValue(RemoveButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty RemoveButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("RemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(ListBoxItemHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(ListBoxItem listBoxItem)
        {
            return (Brush)listBoxItem.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(ListBoxItem listBoxItem, Brush value)
        {
            listBoxItem.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ListBoxItemHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(ListBoxItem listBoxItem)
        {
            return (Brush)listBoxItem.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(ListBoxItem listBoxItem, Brush value)
        {
            listBoxItem.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ListBoxItemHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(ListBoxItem listBoxItem)
        {
            return (Brush)listBoxItem.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(ListBoxItem listBoxItem, Brush value)
        {
            listBoxItem.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ListBoxItemHelper));
        #endregion

        #region HoverBorderThickness
        public static Thickness? GetHoverBorderThickness(ListBoxItem listBoxItem)
        {
            return (Thickness?)listBoxItem.GetValue(HoverBorderThicknessProperty);
        }

        public static void SetHoverBorderThickness(ListBoxItem listBoxItem, Thickness? value)
        {
            listBoxItem.SetValue(HoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(ListBoxItemHelper));
        #endregion

        #region HoverCornerRadius
        public static CornerRadius? GetHoverCornerRadius(ListBoxItem listBoxItem)
        {
            return (CornerRadius?)listBoxItem.GetValue(HoverCornerRadiusProperty);
        }

        public static void SetHoverCornerRadius(ListBoxItem listBoxItem, CornerRadius? value)
        {
            listBoxItem.SetValue(HoverCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(ListBoxItemHelper));
        #endregion

        #region HoverShadowColor
        public static Color? GetHoverShadowColor(ListBoxItem listBoxItem)
        {
            return (Color?)listBoxItem.GetValue(HoverShadowColorProperty);
        }

        public static void SetHoverShadowColor(ListBoxItem listBoxItem, Color? value)
        {
            listBoxItem.SetValue(HoverShadowColorProperty, value);
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(ListBoxItemHelper));
        #endregion

        #region SelectedBackground
        public static Brush GetSelectedBackground(ListBoxItem listBoxItem)
        {
            return (Brush)listBoxItem.GetValue(SelectedBackgroundProperty);
        }

        public static void SetSelectedBackground(ListBoxItem listBoxItem, Brush value)
        {
            listBoxItem.SetValue(SelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("SelectedBackground", typeof(Brush), typeof(ListBoxItemHelper));
        #endregion

        #region SelectedForeground
        public static Brush GetSelectedForeground(ListBoxItem listBoxItem)
        {
            return (Brush)listBoxItem.GetValue(SelectedForegroundProperty);
        }

        public static void SetSelectedForeground(ListBoxItem listBoxItem, Brush value)
        {
            listBoxItem.SetValue(SelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.RegisterAttached("SelectedForeground", typeof(Brush), typeof(ListBoxItemHelper));
        #endregion

        #region SelectedBorderBrush
        public static Brush GetSelectedBorderBrush(ListBoxItem listBoxItem)
        {
            return (Brush)listBoxItem.GetValue(SelectedBorderBrushProperty);
        }

        public static void SetSelectedBorderBrush(ListBoxItem listBoxItem, Brush value)
        {
            listBoxItem.SetValue(SelectedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("SelectedBorderBrush", typeof(Brush), typeof(ListBoxItemHelper));
        #endregion

        #region SelectedBorderThickness
        public static Thickness? GetSelectedBorderThickness(ListBoxItem listBoxItem)
        {
            return (Thickness?)listBoxItem.GetValue(SelectedBorderThicknessProperty);
        }

        public static void SetSelectedBorderThickness(ListBoxItem listBoxItem, Thickness? value)
        {
            listBoxItem.SetValue(SelectedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty SelectedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("SelectedBorderThickness", typeof(Thickness?), typeof(ListBoxItemHelper));
        #endregion

        #region SelectedCornerRadius
        public static CornerRadius? GetSelectedCornerRadius(ListBoxItem listBoxItem)
        {
            return (CornerRadius?)listBoxItem.GetValue(SelectedCornerRadiusProperty);
        }

        public static void SetSelectedCornerRadius(ListBoxItem listBoxItem, CornerRadius? value)
        {
            listBoxItem.SetValue(SelectedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty SelectedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("SelectedCornerRadius", typeof(CornerRadius?), typeof(ListBoxItemHelper));
        #endregion

        #region SelectedShadowColor
        public static Color? GetSelectedShadowColor(ListBoxItem listBoxItem)
        {
            return (Color?)listBoxItem.GetValue(SelectedShadowColorProperty);
        }

        public static void SetSelectedShadowColor(ListBoxItem listBoxItem, Color? value)
        {
            listBoxItem.SetValue(SelectedShadowColorProperty, value);
        }

        public static readonly DependencyProperty SelectedShadowColorProperty =
            VisualStateHelper.SelectedShadowColorProperty.AddOwner(typeof(ListBoxItemHelper));
        #endregion

        #region SeparatorBrush
        public static Brush GetSeparatorBrush(ListBoxItem listBoxItem)
        {
            return (Brush)listBoxItem.GetValue(SeparatorBrushProperty);
        }

        public static void SetSeparatorBrush(ListBoxItem listBoxItem, Brush value)
        {
            listBoxItem.SetValue(SeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.RegisterAttached("SeparatorBrush", typeof(Brush), typeof(ListBoxItemHelper));
        #endregion

        #region SeparatorThickness
        public static double GetSeparatorThickness(ListBoxItem listBoxItem)
        {
            return (double)listBoxItem.GetValue(SeparatorThicknessProperty);
        }

        public static void SetSeparatorThickness(ListBoxItem listBoxItem, double value)
        {
            listBoxItem.SetValue(SeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("SeparatorThickness", typeof(double), typeof(ListBoxItemHelper));
        #endregion

        #region SeparatorMargin
        public static Thickness GetSeparatorMargin(ListBoxItem listBoxItem)
        {
            return (Thickness)listBoxItem.GetValue(SeparatorMarginProperty);
        }

        public static void SetSeparatorMargin(ListBoxItem listBoxItem, Thickness value)
        {
            listBoxItem.SetValue(SeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.RegisterAttached("SeparatorMargin", typeof(Thickness), typeof(ListBoxItemHelper));
        #endregion

        #region SeparatorVisibility
        public static Visibility GetSeparatorVisibility(ListBoxItem listBoxItem)
        {
            return (Visibility)listBoxItem.GetValue(SeparatorVisibilityProperty);
        }

        public static void SetSeparatorVisibility(ListBoxItem listBoxItem, Visibility value)
        {
            listBoxItem.SetValue(SeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("SeparatorVisibility", typeof(Visibility), typeof(ListBoxItemHelper));
        #endregion

        #region SeparatorOrientation
        public static Orientation GetSeparatorOrientation(ListBoxItem listBoxItem)
        {
            return (Orientation)listBoxItem.GetValue(SeparatorOrientationProperty);
        }

        public static void SetSeparatorOrientation(ListBoxItem listBoxItem, Orientation value)
        {
            listBoxItem.SetValue(SeparatorOrientationProperty, value);
        }

        public static readonly DependencyProperty SeparatorOrientationProperty =
            DependencyProperty.RegisterAttached("SeparatorOrientation", typeof(Orientation), typeof(ListBoxItemHelper));
        #endregion


        #region IsStyleless
        public static bool GetIsStyleless(ListBoxItem listBoxItem)
        {
            return (bool)listBoxItem.GetValue(IsStylelessProperty);
        }

        public static void SetIsStyleless(ListBoxItem listBoxItem, bool value)
        {
            listBoxItem.SetValue(IsStylelessProperty, value);
        }

        public static readonly DependencyProperty IsStylelessProperty =
            DependencyProperty.RegisterAttached("IsStyleless", typeof(bool), typeof(ListBoxItemHelper));

        #endregion

        #endregion

        #region Internal Properties

        #region Regist
        internal static bool GetRegist(ListBoxItem listBoxItem)
        {
            return (bool)listBoxItem.GetValue(RegistProperty);
        }

        internal static void SetRegist(ListBoxItem listBoxItem, bool value)
        {
            listBoxItem.SetValue(RegistProperty, value);
        }

        internal static readonly DependencyProperty RegistProperty =
            DependencyProperty.RegisterAttached("Regist", typeof(bool), typeof(ListBoxItemHelper), new PropertyMetadata(OnRegistChanged));

        #endregion

        #endregion

        #region Event Handlers
        private static void OnRegistChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var listBoxItem = d as ListBoxItem;
            listBoxItem.PreviewMouseDown += ListBoxItem_PreviewMouseDown;
        }

        private static void ListBoxItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var listBoxItem = sender as ListBoxItem;
            var listBox = FrameworkElementUtil.FindVisualParent<ListBox>(listBoxItem);
            var removedArgs = new RoutedEventArgs(ListBoxHelper.ItemClickEvent, listBoxItem);
            listBox.RaiseEvent(removedArgs);
            if (removedArgs.Handled)
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
