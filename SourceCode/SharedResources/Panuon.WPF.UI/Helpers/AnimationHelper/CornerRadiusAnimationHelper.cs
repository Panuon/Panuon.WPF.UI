using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.WPF.UI
{
    public static class CornerRadiusAnimationHelper
    {
        #region Properties

        #region CurrentCornerRadius
        public static CornerRadius GetCurrentCornerRadius(FrameworkElement element)
        {
            return (CornerRadius)element.GetValue(CurrentCornerRadiusProperty);
        }

        public static void SetCurrentCornerRadius(FrameworkElement element, CornerRadius value)
        {
            element.SetValue(CurrentCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CurrentCornerRadiusProperty =
            DependencyProperty.RegisterAttached("CurrentCornerRadius", typeof(CornerRadius), typeof(CornerRadiusAnimationHelper));
        #endregion

        #region FromCornerRadius
        public static CornerRadius GetFromCornerRadius(FrameworkElement element)
        {
            return (CornerRadius)element.GetValue(FromCornerRadiusProperty);
        }

        public static void SetFromCornerRadius(FrameworkElement element, CornerRadius value)
        {
            element.SetValue(FromCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty FromCornerRadiusProperty =
            DependencyProperty.RegisterAttached("FromCornerRadius", typeof(CornerRadius), typeof(CornerRadiusAnimationHelper), new PropertyMetadata(OnFromCornerRadiusChanged));
        #endregion

        #region ToCornerRadius
        public static CornerRadius? GetToCornerRadius(FrameworkElement element)
        {
            return (CornerRadius?)element.GetValue(ToCornerRadiusProperty);
        }

        public static void SetToCornerRadius(FrameworkElement element, CornerRadius? value)
        {
            element.SetValue(ToCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ToCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ToCornerRadius", typeof(CornerRadius?), typeof(CornerRadiusAnimationHelper));
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
            DependencyProperty.RegisterAttached("AnimationDuration", typeof(TimeSpan), typeof(CornerRadiusAnimationHelper), new PropertyMetadata(TimeSpan.FromSeconds(0.4)));
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
            DependencyProperty.RegisterAttached("IsTransitioning", typeof(bool), typeof(CornerRadiusAnimationHelper), new PropertyMetadata(OnIsTransitioningChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnFromCornerRadiusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element)
            {
                SetCurrentCornerRadius(element, GetFromCornerRadius(element));
            }
        }

        private static void OnIsTransitioningChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element
                && GetToCornerRadius(element) != null)
            {
                var brushAnimation = new CornerRadiusAnimation()
                {
                    Duration = GetAnimationDuration(element),
                };

                if (GetIsTransitioning(element))
                {
                    brushAnimation.To = GetToCornerRadius(element);
                }

                element.BeginAnimation(CurrentCornerRadiusProperty, brushAnimation);
            }
        }
        #endregion

    }
}
