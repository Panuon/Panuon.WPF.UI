using Panuon.WPF.UI.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class BreadcrumbItem
        : ButtonBase
    {
        #region Ctor
        static BreadcrumbItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BreadcrumbItem), new FrameworkPropertyMetadata(typeof(BreadcrumbItem)));
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
            DependencyProperty.Register("Icon", typeof(object), typeof(BreadcrumbItem));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region HoverBorderThickness
        public Thickness? HoverBorderThickness
        {
            get { return (Thickness?)GetValue(HoverBorderThicknessProperty); }
            set { SetValue(HoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region HoverCornerRadius
        public CornerRadius? HoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(HoverCornerRadiusProperty); }
            set { SetValue(HoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region ClickBackground
        public Brush ClickBackground
        {
            get { return (Brush)GetValue(ClickBackgroundProperty); }
            set { SetValue(ClickBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ClickBackgroundProperty =
            DependencyProperty.Register("ClickBackground", typeof(Brush), typeof(BreadcrumbItem));
        #endregion

        #region ClickForeground
        public Brush ClickForeground
        {
            get { return (Brush)GetValue(ClickForegroundProperty); }
            set { SetValue(ClickForegroundProperty, value); }
        }

        public static readonly DependencyProperty ClickForegroundProperty =
            DependencyProperty.Register("ClickForeground", typeof(Brush), typeof(BreadcrumbItem));
        #endregion

        #region ClickBorderBrush
        public Brush ClickBorderBrush
        {
            get { return (Brush)GetValue(ClickBorderBrushProperty); }
            set { SetValue(ClickBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ClickBorderBrushProperty =
            DependencyProperty.Register("ClickBorderBrush", typeof(Brush), typeof(BreadcrumbItem));
        #endregion

        #region ClickBorderThickness
        public Thickness? ClickBorderThickness
        {
            get { return (Thickness?)GetValue(ClickBorderThicknessProperty); }
            set { SetValue(ClickBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ClickBorderThicknessProperty =
            DependencyProperty.Register("ClickBorderThickness", typeof(Thickness?), typeof(BreadcrumbItem));
        #endregion

        #region ClickCornerRadius
        public CornerRadius? ClickCornerRadius
        {
            get { return (CornerRadius?)GetValue(ClickCornerRadiusProperty); }
            set { SetValue(ClickCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ClickCornerRadiusProperty =
            DependencyProperty.Register("ClickCornerRadius", typeof(CornerRadius?), typeof(BreadcrumbItem));
        #endregion

        #region ClickEffect
        public ClickEffect ClickEffect
        {
            get { return (ClickEffect)GetValue(ClickEffectProperty); }
            set { SetValue(ClickEffectProperty, value); }
        }

        public static readonly DependencyProperty ClickEffectProperty =
            VisualStateHelper.ClickEffectProperty.AddOwner(typeof(BreadcrumbItem));
        #endregion

        #region SeparatorTemplate
        public DataTemplate SeparatorTemplate
        {
            get { return (DataTemplate)GetValue(SeparatorTemplateProperty); }
            set { SetValue(SeparatorTemplateProperty, value); }
        }

        public static readonly DependencyProperty SeparatorTemplateProperty =
            DependencyProperty.Register("SeparatorTemplate", typeof(DataTemplate), typeof(BreadcrumbItem));
        #endregion

        #region SeparatorMargin
        public Thickness SeparatorMargin
        {
            get { return (Thickness)GetValue(SeparatorMarginProperty); }
            set { SetValue(SeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.Register("SeparatorMargin", typeof(Thickness), typeof(BreadcrumbItem));
        #endregion

        #endregion
    }
}
