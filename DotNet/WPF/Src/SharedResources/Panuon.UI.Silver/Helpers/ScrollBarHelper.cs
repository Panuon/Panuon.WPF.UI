using Panuon.UI.Silver.Internal.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class ScrollBarHelper
    {
        #region Properties

        #region TrackBackground
        public static Brush GetTrackBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(TrackBackgroundProperty);
        }

        public static void SetTrackBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(TrackBackgroundProperty, value);
        }

        public static readonly DependencyProperty TrackBackgroundProperty =
            DependencyProperty.RegisterAttached("TrackBackground", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region TrackBorderBrush
        public static Brush GetTrackBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(TrackBorderBrushProperty);
        }

        public static void SetTrackBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(TrackBorderBrushProperty, value);
        }

        public static readonly DependencyProperty TrackBorderBrushProperty =
            DependencyProperty.RegisterAttached("TrackBorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region TrackBorderThickness
        public static Thickness GetTrackBorderThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(TrackBorderThicknessProperty);
        }

        public static void SetTrackBorderThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(TrackBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty TrackBorderThicknessProperty =
            DependencyProperty.RegisterAttached("TrackBorderThickness", typeof(Thickness), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region TrackCornerRadius
        public static CornerRadius GetTrackCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(TrackCornerRadiusProperty);
        }

        public static void SetTrackCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(TrackCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty TrackCornerRadiusProperty =
            DependencyProperty.RegisterAttached("TrackCornerRadius", typeof(CornerRadius), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new CornerRadius(), FrameworkPropertyMetadataOptions.Inherits));
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
            DependencyProperty.RegisterAttached("ThumbCornerRadius", typeof(CornerRadius), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(new CornerRadius(5), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region HoverTrackBackground
        public static Brush GetHoverTrackBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverTrackBackgroundProperty);
        }

        public static void SetHoverTrackBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverTrackBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverTrackBackgroundProperty =
            DependencyProperty.RegisterAttached("HoverTrackBackground", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region HoverTrackBorderBrush
        public static Brush GetHoverTrackBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverTrackBorderBrushProperty);
        }

        public static void SetHoverTrackBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverTrackBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverTrackBorderBrushProperty =
            DependencyProperty.RegisterAttached("HoverTrackBorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
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

        #region InternalTrackBackground
        internal static Brush GetInternalTrackBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(InternalTrackBackgroundProperty);
        }

        internal static void SetInternalTrackBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(InternalTrackBackgroundProperty, value);
        }

        internal static readonly DependencyProperty InternalTrackBackgroundProperty =
            DependencyProperty.RegisterAttached("InternalTrackBackground", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region InternalTrackBorderBrush
        internal static Brush GetInternalTrackBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(InternalTrackBorderBrushProperty);
        }

        internal static void SetInternalTrackBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(InternalTrackBorderBrushProperty, value);
        }

        internal static readonly DependencyProperty InternalTrackBorderBrushProperty =
            DependencyProperty.RegisterAttached("InternalTrackBorderBrush", typeof(Brush), typeof(ScrollBarHelper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
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

        #region IsTrackHover
        internal static bool GetIsTrackHover(FrameworkElement element)
        {
            return (bool)element.GetValue(IsTrackHoverProperty);
        }

        internal static void SetIsTrackHover(FrameworkElement element, bool value)
        {
            element.SetValue(IsTrackHoverProperty, value);
        }

        internal static readonly DependencyProperty IsTrackHoverProperty =
            DependencyProperty.RegisterAttached("IsTrackHover", typeof(bool), typeof(ScrollBarHelper), new PropertyMetadata(OnIsTrackHoverChanged));
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
        private static void OnIsTrackHoverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;

             if ((bool)e.NewValue)
            {
                var propertyBrushes = new Dictionary<DependencyProperty, Brush>();
                if (element.GetValue(HoverTrackBackgroundProperty) is Brush hoverBackground)
                {
                    propertyBrushes.Add(InternalTrackBackgroundProperty, hoverBackground);
                }
                 if (element.GetValue(HoverTrackBorderBrushProperty) is Brush hoverBorder)
                {
                    propertyBrushes.Add(InternalTrackBorderBrushProperty, hoverBorder);
                }
                if (propertyBrushes.Any())
                  {
                    AnimationUtil.BeginBrushAnimationStoryboard(element, propertyBrushes);
                }
            }
            else
            {
                var propertyBrushes = new List<DependencyProperty>();
                if (element.GetValue(HoverTrackBackgroundProperty) != null)
                {
                    propertyBrushes.Add(InternalTrackBackgroundProperty);
                }
                if (element.GetValue(HoverTrackBorderBrushProperty) != null)
                {
                    propertyBrushes.Add(InternalTrackBorderBrushProperty);
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
