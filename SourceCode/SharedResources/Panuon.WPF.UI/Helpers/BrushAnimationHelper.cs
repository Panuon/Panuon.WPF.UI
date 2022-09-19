using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class BrushAnimationHelper
    {
        #region Properties

        #region CurrentBrush
        public static Brush GetCurrentBrush(FrameworkElement element)
        {
            return (Brush)element.GetValue(CurrentBrushProperty);
        }

        public static void SetCurrentBrush(FrameworkElement element, Brush value)
        {
            element.SetValue(CurrentBrushProperty, value);
        }

        public static readonly DependencyProperty CurrentBrushProperty =
            DependencyProperty.RegisterAttached("CurrentBrush", typeof(Brush), typeof(BrushAnimationHelper));
        #endregion

        #region FromBrush
        public static Brush GetFromBrush(FrameworkElement element)
        {
            return (Brush)element.GetValue(FromBrushProperty);
        }

        public static void SetFromBrush(FrameworkElement element, Brush value)
        {
            element.SetValue(FromBrushProperty, value);
        }

        public static readonly DependencyProperty FromBrushProperty =
            DependencyProperty.RegisterAttached("FromBrush", typeof(Brush), typeof(BrushAnimationHelper), new PropertyMetadata(OnFromBrushChanged));
        #endregion

        #region ToBrush
        public static Brush GetToBrush(FrameworkElement element)
        {
            return (Brush)element.GetValue(ToBrushProperty);
        }

        public static void SetToBrush(FrameworkElement element, Brush value)
        {
            element.SetValue(ToBrushProperty, value);
        }

        public static readonly DependencyProperty ToBrushProperty =
            DependencyProperty.RegisterAttached("ToBrush", typeof(Brush), typeof(BrushAnimationHelper));
        #endregion

        #region AnimationDuration
        public static TimeSpan GetAnimationDuration(FrameworkElement element)
        {
            return (TimeSpan)element.GetValue(AnimationDurationProperty);
        }

        public static void SetAnimationDuration(FrameworkElement element, TimeSpan value)
        {
            element.SetValue(AnimationDurationProperty, value);
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.RegisterAttached("AnimationDuration", typeof(TimeSpan), typeof(BrushAnimationHelper), new PropertyMetadata(TimeSpan.FromSeconds(0.4)));
        #endregion

        #region IsTransitioning
        public static bool GetIsTransitioning(FrameworkElement element)
        {
            return (bool)element.GetValue(IsTransitioningProperty);
        }

        public static void SetIsTransitioning(FrameworkElement element, bool value)
        {
            element.SetValue(IsTransitioningProperty, value);
        }

        public static readonly DependencyProperty IsTransitioningProperty =
            DependencyProperty.RegisterAttached("IsTransitioning", typeof(bool), typeof(BrushAnimationHelper), new PropertyMetadata(OnIsTransitioningChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnFromBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element)
            {
                SetCurrentBrush(element, GetFromBrush(element));
            }
        }

        private static void OnIsTransitioningChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element)
            {
                var brushAnimation = new BrushAnimation()
                {
                    Duration = GetAnimationDuration(element),
                    
                };

                if (GetIsTransitioning(element))
                {
                    brushAnimation.To = GetToBrush(element);
                }

                element.BeginAnimation(CurrentBrushProperty, brushAnimation);
            }
        }
        #endregion

    }
}
