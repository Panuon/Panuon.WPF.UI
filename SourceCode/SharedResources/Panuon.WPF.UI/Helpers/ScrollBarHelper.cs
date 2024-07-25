using Panuon.WPF.UI.Internal.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ScrollBarHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ScrollButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(ScrollBarHelper), nameof(ScrollButtonStyleKey));
        #endregion

        #region Properties

        #region Background
        public static Brush GetBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BackgroundProperty);
        }

        public static void SetBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(BackgroundProperty, value);
        }

        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region BorderBrush
        public static Brush GetBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BorderBrushProperty);
        }

        public static void SetBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(BorderBrushProperty, value);
        }

        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region BorderThickness
        public static Thickness GetBorderThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(BorderThicknessProperty);
        }

        public static void SetBorderThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(BorderThicknessProperty, value);
        }

        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.RegisterAttached("BorderThickness", typeof(Thickness), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new CornerRadius(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            DependencyProperty.RegisterAttached("HoverBackground", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("HoverBorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ThumbMinSize
        public static double GetThumbMinSize(DependencyObject obj)
        {
            return (double)obj.GetValue(ThumbMinSizeProperty);
        }

        public static void SetThumbMinSize(DependencyObject obj, double value)
        {
            obj.SetValue(ThumbMinSizeProperty, value);
        }

        public static readonly DependencyProperty ThumbMinSizeProperty =
            DependencyProperty.RegisterAttached("ThumbMinSize", typeof(double), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ThumbBackground
        public static Brush GetThumbBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ThumbBackgroundProperty);
        }

        public static void SetThumbBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ThumbBackgroundProperty, value);
        }

        public static readonly DependencyProperty ThumbBackgroundProperty =
            DependencyProperty.RegisterAttached("ThumbBackground", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new SolidColorBrush(Color.FromArgb(168, 168, 168, 168)), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ThumbBorderBrush
        public static Brush GetThumbBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ThumbBorderBrushProperty);
        }

        public static void SetThumbBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ThumbBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ThumbBorderBrushProperty =
            DependencyProperty.RegisterAttached("ThumbBorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ThumbBorderThickness
        public static Thickness GetThumbBorderThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(ThumbBorderThicknessProperty);
        }

        public static void SetThumbBorderThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(ThumbBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ThumbBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ThumbBorderThickness", typeof(Thickness), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ThumbCornerRadius
        public static CornerRadius GetThumbCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(ThumbCornerRadiusProperty);
        }

        public static void SetThumbCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(ThumbCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ThumbCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ThumbCornerRadius", typeof(CornerRadius), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new CornerRadius(1), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region HoverThumbBackground
        public static Brush GetHoverThumbBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverThumbBackgroundProperty);
        }

        public static void SetHoverThumbBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverThumbBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverThumbBackgroundProperty =
            DependencyProperty.RegisterAttached("HoverThumbBackground", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new SolidColorBrush(Color.FromRgb(168, 168, 168)), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region HoverThumbBorderBrush
        public static Brush GetHoverThumbBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverThumbBorderBrushProperty);
        }

        public static void SetHoverThumbBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverThumbBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverThumbBorderBrushProperty =
            DependencyProperty.RegisterAttached("HoverThumbBorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ScrollButtonVisibility
        public static Visibility GetScrollButtonVisibility(DependencyObject obj)
        {
            return (Visibility)obj.GetValue(ScrollButtonVisibilityProperty);
        }

        public static void SetScrollButtonVisibility(DependencyObject obj, Visibility value)
        {
            obj.SetValue(ScrollButtonVisibilityProperty, value);
        }

        public static readonly DependencyProperty ScrollButtonVisibilityProperty =
            DependencyProperty.RegisterAttached("ScrollButtonVisibility", typeof(Visibility), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(Visibility.Collapsed, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ScrollButtonStyle
        public static Style GetScrollButtonStyle(DependencyObject obj)
        {
            return (Style)obj.GetValue(ScrollButtonStyleProperty);
        }

        public static void SetScrollButtonStyle(DependencyObject obj, Style value)
        {
            obj.SetValue(ScrollButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ScrollButtonStyleProperty =
            DependencyProperty.RegisterAttached("ScrollButtonStyle", typeof(Style), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion 

        #endregion

        #region Internal Properties

        #region InternalBackground
        internal static Brush GetInternalBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(InternalBackgroundProperty);
        }

        internal static void SetInternalBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(InternalBackgroundProperty, value);
        }

        internal static readonly DependencyProperty InternalBackgroundProperty =
            DependencyProperty.RegisterAttached("InternalBackground", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region InternalBorderBrush
        internal static Brush GetInternalBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(InternalBorderBrushProperty);
        }

        internal static void SetInternalBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(InternalBorderBrushProperty, value);
        }

        internal static readonly DependencyProperty InternalBorderBrushProperty =
            DependencyProperty.RegisterAttached("InternalBorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region InternalThumbBackground
        internal static Brush GetInternalThumbBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(InternalThumbBackgroundProperty);
        }

        internal static void SetInternalThumbBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(InternalThumbBackgroundProperty, value);
        }

        internal static readonly DependencyProperty InternalThumbBackgroundProperty =
            DependencyProperty.RegisterAttached("InternalThumbBackground", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region InternalThumbBorderBrush
        internal static Brush GetInternalThumbBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(InternalThumbBorderBrushProperty);
        }

        internal static void SetInternalThumbBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(InternalThumbBorderBrushProperty, value);
        }

        internal static readonly DependencyProperty InternalThumbBorderBrushProperty =
            DependencyProperty.RegisterAttached("InternalThumbBorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region IsHover
        internal static bool GetIsHover(FrameworkElement element)
        {
            return (bool)element.GetValue(IsHoverProperty);
        }

        internal static void SetIsHover(FrameworkElement element, bool value)
        {
            element.SetValue(IsHoverProperty, value);
        }

        internal static readonly DependencyProperty IsHoverProperty =
            DependencyProperty.RegisterAttached("IsHover", typeof(bool), typeof(ScrollBarHelper), new PropertyMetadata(OnIsHoverChanged));
        #endregion

        #region IsThumbHover
        internal static bool GetIsThumbHover(FrameworkElement element)
        {
            return (bool)element.GetValue(IsThumbHoverProperty);
        }

        internal static void SetIsThumbHover(FrameworkElement element, bool value)
        {
            element.SetValue(IsThumbHoverProperty, value);
        }

        internal static readonly DependencyProperty IsThumbHoverProperty =
            DependencyProperty.RegisterAttached("IsThumbHover", typeof(bool), typeof(ScrollBarHelper), new PropertyMetadata(OnIsThumbHoverChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnIsHoverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;

             if ((bool)e.NewValue)
            {
                var propertyBrushes = new Dictionary<DependencyProperty, Brush>();
                if (element.GetValue(HoverBackgroundProperty) is Brush hoverBackground)
                {
                    propertyBrushes.Add(InternalBackgroundProperty, hoverBackground);
                }
                 if (element.GetValue(HoverBorderBrushProperty) is Brush hoverBorder)
                {
                    propertyBrushes.Add(InternalBorderBrushProperty, hoverBorder);
                }
                if (propertyBrushes.Any())
                  {
                    AnimationUtil.BeginBrushAnimationStoryboard(element, propertyBrushes);
                }
            }
            else
            {
                var propertyBrushes = new List<DependencyProperty>();
                if (element.GetValue(HoverBackgroundProperty) != null)
                {
                    propertyBrushes.Add(InternalBackgroundProperty);
                }
                if (element.GetValue(HoverBorderBrushProperty) != null)
                {
                    propertyBrushes.Add(InternalBorderBrushProperty);
                }
                if (propertyBrushes.Any())
                {
                    AnimationUtil.BeginBrushAnimationStoryboard(element, propertyBrushes);
                }
            }
          
        }

        private static void OnIsThumbHoverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;

            if ((bool)e.NewValue)
            {
                var propertyBrushes = new Dictionary<DependencyProperty, Brush>();
                if (element.GetValue(HoverThumbBackgroundProperty) is Brush hoverBackground)
                {
                    propertyBrushes.Add(InternalThumbBackgroundProperty, hoverBackground);
                }
                if (element.GetValue(HoverThumbBorderBrushProperty) is Brush hoverBorder)
                {
                    propertyBrushes.Add(InternalThumbBorderBrushProperty, hoverBorder);
                }
                if (propertyBrushes.Any())
                {
                    AnimationUtil.BeginBrushAnimationStoryboard(element.TemplatedParent, propertyBrushes);
                }
            }
            else
            {
                var propertyBrushes = new List<DependencyProperty>();
                if (element.GetValue(HoverThumbBackgroundProperty) != null)
                {
                    propertyBrushes.Add(InternalThumbBackgroundProperty);
                }
                if (element.GetValue(HoverThumbBorderBrushProperty) != null)
                {
                    propertyBrushes.Add(InternalThumbBorderBrushProperty);
                }
                if (propertyBrushes.Any())
                {
                    AnimationUtil.BeginBrushAnimationStoryboard(element.TemplatedParent, propertyBrushes);
                }
            }

        }
        #endregion
    }
}
