using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.WPF.UI
{
    public static class ExpanderHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ToggleArrowTransformControlStyleKey { get; } =
            new ComponentResourceKey(typeof(ExpanderHelper), nameof(ToggleArrowTransformControlStyleKey));
        #endregion

        #region Properties

        #region Icon
        public static object GetIcon(Expander expander)
        {
            return (object)expander.GetValue(IconProperty);
        }

        public static void SetIcon(Expander expander, object value)
        {
            expander.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ExpanderHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(Expander expander)
        {
            return (CornerRadius)expander.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(Expander expander, CornerRadius value)
        {
            expander.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(ExpanderHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(Expander expander)
        {
            return (Color?)expander.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(Expander expander, Color? value)
        {
            expander.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ExpanderHelper));
        #endregion

        #region ToggleArrowPlacement
        public static ToggleArrowPlacement GetToggleArrowPlacement(Expander expander)
        {
            return (ToggleArrowPlacement)expander.GetValue(ToggleArrowPlacementProperty);
        }

        public static void SetToggleArrowPlacement(Expander expander, ToggleArrowPlacement value)
        {
            expander.SetValue(ToggleArrowPlacementProperty, value);
        }

        public static readonly DependencyProperty ToggleArrowPlacementProperty =
            DependencyProperty.RegisterAttached("ToggleArrowPlacement", typeof(ToggleArrowPlacement), typeof(ExpanderHelper));
        #endregion

        #region ToggleArrowTransformControlStyle
        public static Style GetToggleArrowTransformControlStyle(Expander expander)
        {
            return (Style)expander.GetValue(ToggleArrowTransformControlStyleProperty);
        }

        public static void SetToggleArrowTransformControlStyle(Expander expander, Style value)
        {
            expander.SetValue(ToggleArrowTransformControlStyleProperty, value);
        }

        public static readonly DependencyProperty ToggleArrowTransformControlStyleProperty =
            DependencyProperty.RegisterAttached("ToggleArrowTransformControlStyle", typeof(Style), typeof(ExpanderHelper));
        #endregion

        #region HeaderPadding
        public static Thickness GetHeaderPadding(Expander expander)
        {
            return (Thickness)expander.GetValue(HeaderPaddingProperty);
        }

        public static void SetHeaderPadding(Expander expander, Thickness value)
        {
            expander.SetValue(HeaderPaddingProperty, value);
        }

        public static readonly DependencyProperty HeaderPaddingProperty =
            DependencyProperty.RegisterAttached("HeaderPadding", typeof(Thickness), typeof(ExpanderHelper));
        #endregion

        #region HeaderForeground
        public static Brush GetHeaderForeground(Expander expander)
        {
            return (Brush)expander.GetValue(HeaderForegroundProperty);
        }

        public static void SetHeaderForeground(Expander expander, Brush value)
        {
            expander.SetValue(HeaderForegroundProperty, value);
        }

        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.RegisterAttached("HeaderForeground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region HeaderBackground
        public static Brush GetHeaderBackground(Expander expander)
        {
            return (Brush)expander.GetValue(HeaderBackgroundProperty);
        }

        public static void SetHeaderBackground(Expander expander, Brush value)
        {
            expander.SetValue(HeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.RegisterAttached("HeaderBackground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region HeaderBorderBrush
        public static Brush GetHeaderBorderBrush(Expander expander)
        {
            return (Brush)expander.GetValue(HeaderBorderBrushProperty);
        }

        public static void SetHeaderBorderBrush(Expander expander, Brush value)
        {
            expander.SetValue(HeaderBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HeaderBorderBrushProperty =
            DependencyProperty.RegisterAttached("HeaderBorderBrush", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region HeaderBorderThickness
        public static Thickness GetHeaderBorderThickness(Expander expander)
        {
            return (Thickness)expander.GetValue(HeaderBorderThicknessProperty);
        }

        public static void SetHeaderBorderThickness(Expander expander, Thickness value)
        {
            expander.SetValue(HeaderBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty HeaderBorderThicknessProperty =
            DependencyProperty.RegisterAttached("HeaderBorderThickness", typeof(Thickness), typeof(ExpanderHelper));
        #endregion

        #region HeaderCornerRadius
        public static CornerRadius GetHeaderCornerRadius(Expander expander)
        {
            return (CornerRadius)expander.GetValue(HeaderCornerRadiusProperty);
        }

        public static void SetHeaderCornerRadius(Expander expander, CornerRadius value)
        {
            expander.SetValue(HeaderCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty HeaderCornerRadiusProperty =
            DependencyProperty.RegisterAttached("HeaderCornerRadius", typeof(CornerRadius), typeof(ExpanderHelper));
        #endregion

        #region HeaderShadowColor
        public static Color? GetHeaderShadowColor(Expander expander)
        {
            return (Color?)expander.GetValue(HeaderShadowColorProperty);
        }

        public static void SetHeaderShadowColor(Expander expander, Color? value)
        {
            expander.SetValue(HeaderShadowColorProperty, value);
        }

        public static readonly DependencyProperty HeaderShadowColorProperty =
            DependencyProperty.RegisterAttached("HeaderShadowColor", typeof(Color?), typeof(ExpanderHelper));
        #endregion

        #region HeaderFontSize
        public static double GetHeaderFontSize(Expander expander)
        {
            return (double)expander.GetValue(HeaderFontSizeProperty);
        }

        public static void SetHeaderFontSize(Expander expander, double value)
        {
            expander.SetValue(HeaderFontSizeProperty, value);
        }

        public static readonly DependencyProperty HeaderFontSizeProperty =
            DependencyProperty.RegisterAttached("HeaderFontSize", typeof(double), typeof(ExpanderHelper), new PropertyMetadata(SystemFonts.MessageFontSize));
        #endregion

        #region HeaderFontWeight
        public static FontWeight GetHeaderFontWeight(Expander expander)
        {
            return (FontWeight)expander.GetValue(HeaderFontWeightProperty);
        }

        public static void SetHeaderFontWeight(Expander expander, FontWeight value)
        {
            expander.SetValue(HeaderFontWeightProperty, value);
        }

        public static readonly DependencyProperty HeaderFontWeightProperty =
            DependencyProperty.RegisterAttached("HeaderFontWeight", typeof(FontWeight), typeof(ExpanderHelper), new PropertyMetadata(SystemFonts.MessageFontWeight));
        #endregion

        #region HeaderFontFamily
        public static FontFamily GetHeaderFontFamily(Expander expander)
        {
            return (FontFamily)expander.GetValue(HeaderFontFamilyProperty);
        }

        public static void SetHeaderFontFamily(Expander expander, FontFamily value)
        {
            expander.SetValue(HeaderFontFamilyProperty, value);
        }

        public static readonly DependencyProperty HeaderFontFamilyProperty =
            DependencyProperty.RegisterAttached("HeaderFontFamily", typeof(FontFamily), typeof(ExpanderHelper));
        #endregion

        #region HeaderHeight
        public static double GetHeaderHeight(Expander expander)
        {
            return (double)expander.GetValue(HeaderHeightProperty);
        }

        public static void SetHeaderHeight(Expander expander, double value)
        {
            expander.SetValue(HeaderHeightProperty, value);
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.RegisterAttached("HeaderHeight", typeof(double), typeof(ExpanderHelper), new PropertyMetadata(double.NaN));
        #endregion

        #region HeaderHorizontalContentAlignment
        public static HorizontalAlignment GetHeaderHorizontalContentAlignment(Expander expander)
        {
            return (HorizontalAlignment)expander.GetValue(HeaderHorizontalContentAlignmentProperty);
        }

        public static void SetHeaderHorizontalContentAlignment(Expander expander, HorizontalAlignment value)
        {
            expander.SetValue(HeaderHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(ExpanderHelper));
        #endregion

        #region HeaderVerticalContentAlignment
        public static VerticalAlignment GetHeaderVerticalContentAlignment(Expander expander)
        {
            return (VerticalAlignment)expander.GetValue(HeaderVerticalContentAlignmentProperty);
        }

        public static void SetHeaderVerticalContentAlignment(Expander expander, VerticalAlignment value)
        {
            expander.SetValue(HeaderVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderVerticalContentAlignment", typeof(VerticalAlignment), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeader
        public static object GetExpandedHeader(Expander expander)
        {
            return (object)expander.GetValue(ExpandedHeaderProperty);
        }

        public static void SetExpandedHeader(Expander expander, object value)
        {
            expander.SetValue(ExpandedHeaderProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderProperty =
            DependencyProperty.RegisterAttached("ExpandedHeader", typeof(object), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeaderForeground
        public static Brush GetExpandedHeaderForeground(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedHeaderForegroundProperty);
        }

        public static void SetExpandedHeaderForeground(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedHeaderForegroundProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderForegroundProperty =
            DependencyProperty.RegisterAttached("ExpandedHeaderForeground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeaderBackground
        public static Brush GetExpandedHeaderBackground(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedHeaderBackgroundProperty);
        }

        public static void SetExpandedHeaderBackground(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedHeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderBackgroundProperty =
            DependencyProperty.RegisterAttached("ExpandedHeaderBackground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeaderBorderBrush
        public static Brush GetExpandedHeaderBorderBrush(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedHeaderBorderBrushProperty);
        }

        public static void SetExpandedHeaderBorderBrush(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedHeaderBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderBorderBrushProperty =
            DependencyProperty.RegisterAttached("ExpandedHeaderBorderBrush", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeaderBorderThickness
        public static Thickness? GetExpandedHeaderBorderThickness(Expander expander)
        {
            return (Thickness?)expander.GetValue(ExpandedHeaderBorderThicknessProperty);
        }

        public static void SetExpandedHeaderBorderThickness(Expander expander, Thickness? value)
        {
            expander.SetValue(ExpandedHeaderBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ExpandedHeaderBorderThickness", typeof(Thickness?), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeaderCornerRadius
        public static CornerRadius? GetExpandedHeaderCornerRadius(Expander expander)
        {
            return (CornerRadius?)expander.GetValue(ExpandedHeaderCornerRadiusProperty);
        }

        public static void SetExpandedHeaderCornerRadius(Expander expander, CornerRadius? value)
        {
            expander.SetValue(ExpandedHeaderCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ExpandedHeaderCornerRadius", typeof(CornerRadius?), typeof(ExpanderHelper));
        #endregion

        #region ExpandedHeaderShadowColor
        public static Color? GetExpandedHeaderShadowColor(Expander expander)
        {
            return (Color?)expander.GetValue(ExpandedHeaderShadowColorProperty);
        }

        public static void SetExpandedHeaderShadowColor(Expander expander, Color? value)
        {
            expander.SetValue(ExpandedHeaderShadowColorProperty, value);
        }

        public static readonly DependencyProperty ExpandedHeaderShadowColorProperty =
            DependencyProperty.RegisterAttached("ExpandedHeaderShadowColor", typeof(Color?), typeof(ExpanderHelper));
        #endregion

        #region ExpandedBackground
        public static Brush GetExpandedBackground(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedBackgroundProperty);
        }

        public static void SetExpandedBackground(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedBackgroundProperty, value);
        }

        public static readonly DependencyProperty ExpandedBackgroundProperty =
            DependencyProperty.RegisterAttached("ExpandedBackground", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region ExpandedBorderBrush
        public static Brush GetExpandedBorderBrush(Expander expander)
        {
            return (Brush)expander.GetValue(ExpandedBorderBrushProperty);
        }

        public static void SetExpandedBorderBrush(Expander expander, Brush value)
        {
            expander.SetValue(ExpandedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ExpandedBorderBrushProperty =
            DependencyProperty.RegisterAttached("ExpandedBorderBrush", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region ExpandedBorderThickness
        public static Thickness? GetExpandedBorderThickness(Expander expander)
        {
            return (Thickness?)expander.GetValue(ExpandedBorderThicknessProperty);
        }

        public static void SetExpandedBorderThickness(Expander expander, Thickness? value)
        {
            expander.SetValue(ExpandedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ExpandedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ExpandedBorderThickness", typeof(Thickness?), typeof(ExpanderHelper));
        #endregion

        #region ExpandedCornerRadius
        public static CornerRadius? GetExpandedCornerRadius(Expander expander)
        {
            return (CornerRadius?)expander.GetValue(ExpandedCornerRadiusProperty);
        }

        public static void SetExpandedCornerRadius(Expander expander, CornerRadius? value)
        {
            expander.SetValue(ExpandedCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ExpandedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ExpandedCornerRadius", typeof(CornerRadius?), typeof(ExpanderHelper));
        #endregion

        #region ExpandedShadowColor
        public static Color? GetExpandedShadowColor(Expander expander)
        {
            return (Color?)expander.GetValue(ExpandedShadowColorProperty);
        }

        public static void SetExpandedShadowColor(Expander expander, Color? value)
        {
            expander.SetValue(ExpandedShadowColorProperty, value);
        }

        public static readonly DependencyProperty ExpandedShadowColorProperty =
            DependencyProperty.RegisterAttached("ExpandedShadowColor", typeof(Color?), typeof(ExpanderHelper));
        #endregion

        #region HeaderSeparatorVisibility
        public static Visibility GetHeaderSeparatorVisibility(Expander expander)
        {
            return (Visibility)expander.GetValue(HeaderSeparatorVisibilityProperty);
        }

        public static void SetHeaderSeparatorVisibility(Expander expander, Visibility value)
        {
            expander.SetValue(HeaderSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorVisibility", typeof(Visibility), typeof(ExpanderHelper));
        #endregion

        #region HeaderSeparatorBrush
        public static Brush GetHeaderSeparatorBrush(Expander expander)
        {
            return (Brush)expander.GetValue(HeaderSeparatorBrushProperty);
        }

        public static void SetHeaderSeparatorBrush(Expander expander, Brush value)
        {
            expander.SetValue(HeaderSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorBrush", typeof(Brush), typeof(ExpanderHelper));
        #endregion

        #region HeaderSeparatorThickness
        public static double GetHeaderSeparatorThickness(Expander expander)
        {
            return (double)expander.GetValue(HeaderSeparatorThicknessProperty);
        }

        public static void SetHeaderSeparatorThickness(Expander expander, double value)
        {
            expander.SetValue(HeaderSeparatorThicknessProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorThicknessProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorThickness", typeof(double), typeof(ExpanderHelper));
        #endregion

        #region HeaderSeparatorMargin
        public static Thickness GetHeaderSeparatorMargin(Expander expander)
        {
            return (Thickness)expander.GetValue(HeaderSeparatorMarginProperty);
        }

        public static void SetHeaderSeparatorMargin(Expander expander, Thickness value)
        {
            expander.SetValue(HeaderSeparatorMarginProperty, value);
        }

        public static readonly DependencyProperty HeaderSeparatorMarginProperty =
            DependencyProperty.RegisterAttached("HeaderSeparatorMargin", typeof(Thickness), typeof(ExpanderHelper));
        #endregion

        #region ExtendControl
        public static object GetExtendControl(Expander expander)
        {
            return (object)expander.GetValue(ExtendControlProperty);
        }

        public static void SetExtendControl(Expander expander, object value)
        {
            expander.SetValue(ExtendControlProperty, value);
        }

        public static readonly DependencyProperty ExtendControlProperty =
            DependencyProperty.RegisterAttached("ExtendControl", typeof(object), typeof(ExpanderHelper));
        #endregion

        #region AnimationEasing
        public static AnimationEasing GetAnimationEasing(Expander expander)
        {
            return (AnimationEasing)expander.GetValue(AnimationEasingProperty);
        }

        public static void SetAnimationEasing(Expander expander, AnimationEasing value)
        {
            expander.SetValue(AnimationEasingProperty, value);
        }

        public static readonly DependencyProperty AnimationEasingProperty =
            DependencyProperty.RegisterAttached("AnimationEasing", typeof(AnimationEasing), typeof(ExpanderHelper));
        #endregion

        #region AnimationDuration
        public static TimeSpan GetAnimationDuration(Expander expander)
        {
            return (TimeSpan)expander.GetValue(AnimationDurationProperty);
        }

        public static void SetAnimationDuration(Expander expander, TimeSpan value)
        {
            expander.SetValue(AnimationDurationProperty, value);
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.RegisterAttached("AnimationDuration", typeof(TimeSpan), typeof(ExpanderHelper));
        #endregion

        #endregion

        #region Internal Properties

        #region RegistContentPresenter
        internal static ContentPresenterX GetRegistContentPresenter(DependencyObject obj)
        {
            return (ContentPresenterX)obj.GetValue(RegistContentPresenterProperty);
        }

        internal static void SetRegistContentPresenter(DependencyObject obj, ContentPresenterX value)
        {
            obj.SetValue(RegistContentPresenterProperty, value);
        }

        internal static readonly DependencyProperty RegistContentPresenterProperty =
            DependencyProperty.RegisterAttached("RegistContentPresenter", typeof(ContentPresenterX), typeof(ExpanderHelper), new PropertyMetadata(OnRegistContentPresenter));
        #endregion

        #region ChildSize
        internal static Size GetChildSize(DependencyObject obj)
        {
            return (Size)obj.GetValue(ChildSizeProperty);
        }

        internal static void SetChildSize(DependencyObject obj, Size value)
        {
            obj.SetValue(ChildSizeProperty, value);
        }

        internal static readonly DependencyProperty ChildSizeProperty =
            DependencyProperty.RegisterAttached("ChildSize", typeof(Size), typeof(ExpanderHelper), new PropertyMetadata(OnChildSizeChanged));
        #endregion

        #endregion

        #region Evemt Handlers

        private static void OnRegistContentPresenter(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ContentPresenterX contentPresenter)
            {
                var expander = contentPresenter.TemplatedParent as Expander;

                expander.SizeChanged -= Expander_SizeChanged;
                expander.SizeChanged += Expander_SizeChanged;
                expander.Expanded -= Expander_ExpandedOrCollapsed;
                expander.Expanded += Expander_ExpandedOrCollapsed;
                expander.Collapsed -= Expander_ExpandedOrCollapsed;
                expander.Collapsed += Expander_ExpandedOrCollapsed;

                SetRegistContentPresenter(expander, contentPresenter);
                contentPresenter.Arranged += (s, args) =>
                {
                    SetChildSize(expander, args.NewValue);
                };
            }
        }

        private static void Expander_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var expander = (Expander)sender;
            if ((expander.ExpandDirection == ExpandDirection.Up || expander.ExpandDirection == ExpandDirection.Down)
                && e.WidthChanged)
            {
                var childSize = GetChildSize(expander);
                SetChildSize(expander, new Size(double.NaN, childSize.Height));
                var contentPresenter = GetRegistContentPresenter(expander);
                contentPresenter.InvalidateArrange();
            }
            else if((expander.ExpandDirection == ExpandDirection.Left || expander.ExpandDirection == ExpandDirection.Right)
                && e.HeightChanged)
            {
                var childSize = GetChildSize(expander);
                SetChildSize(expander, new Size(childSize.Width, double.NaN));
                var contentPresenter = GetRegistContentPresenter(expander);
                contentPresenter.InvalidateArrange();
            }
        }

        private static void Expander_ExpandedOrCollapsed(object sender, RoutedEventArgs e)
        {
            var expander = sender as Expander;
            var contentPresenterX = GetRegistContentPresenter(expander);
            var containerBorder = contentPresenterX.Parent as Border;
            var childSize = GetChildSize(expander);
            var isVertical = expander.ExpandDirection == ExpandDirection.Up
                || expander.ExpandDirection == ExpandDirection.Down;
            var property = isVertical
                ? ContentPresenterX.HeightProperty
                : ContentPresenterX.WidthProperty;
            var from = isVertical
                ? (double.IsNaN(containerBorder.Height)
                    ? containerBorder.ActualHeight
                    : (double?)null)
                : (double.IsNaN(containerBorder.Width)
                    ? containerBorder.ActualWidth
                    : (double?)null);

            if (expander.IsExpanded)
            {
                var to = isVertical
                    ? childSize.Height
                    : childSize.Width;

                contentPresenterX.HandleArranged = true;
                var animation = new DoubleAnimation()
                {
                    From = from,
                    To = to,
                    Duration = GetAnimationDuration(expander),
                    EasingFunction = AnimationUtil.CreateEasingFunction(GetAnimationEasing(expander)),
                };
                animation.Completed += delegate
                {
                    contentPresenterX.HandleArranged = false;
                };
                containerBorder.BeginAnimation(property, animation);
            }
            else
            {
                contentPresenterX.HandleArranged = true;
                var animation = new DoubleAnimation()
                {
                    From = from,
                    To = 0,
                    Duration = GetAnimationDuration(expander),
                    EasingFunction = AnimationUtil.CreateEasingFunction(GetAnimationEasing(expander)),
                };
                animation.Completed += delegate
                {
                    contentPresenterX.HandleArranged = false;
                };
                containerBorder.BeginAnimation(property, animation);
            }
        }

        private static void OnChildSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var expander = (Expander)d;
            var childSize = (Size)e.NewValue;
            var contentPresenterX = GetRegistContentPresenter(expander);
            var containerBorder = contentPresenterX.Parent as Border;

            containerBorder.BeginAnimation(Border.WidthProperty, null);
            containerBorder.BeginAnimation(Border.HeightProperty, null);

            if (expander.IsExpanded)
            {
                containerBorder.Width = childSize.Width;
                containerBorder.Height = childSize.Height;
            }
            else
            {
                if (expander.ExpandDirection == ExpandDirection.Up
                    || expander.ExpandDirection == ExpandDirection.Down)
                {
                    containerBorder.Width = childSize.Width;
                    containerBorder.Height = 0;
                }
                else
                {
                    containerBorder.Width = 0;
                    containerBorder.Height = childSize.Height;
                }
            }
        }

        #endregion
    }
}
