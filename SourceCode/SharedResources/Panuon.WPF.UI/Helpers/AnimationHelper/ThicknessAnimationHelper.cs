using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.WPF.UI
{
    public static class ThicknessAnimationHelper
    {
        #region Properties

        #region CurrentThickness
        public static Thickness GetCurrentThickness(FrameworkElement element)
        {
            return (Thickness)element.GetValue(CurrentThicknessProperty);
        }

        public static void SetCurrentThickness(FrameworkElement element, Thickness value)
        {
            element.SetValue(CurrentThicknessProperty, value);
        }

        public static readonly DependencyProperty CurrentThicknessProperty =
            DependencyProperty.RegisterAttached("CurrentThickness", typeof(Thickness), typeof(ThicknessAnimationHelper));
        #endregion

        #region FromThickness
        public static Thickness GetFromThickness(FrameworkElement element)
        {
            return (Thickness)element.GetValue(FromThicknessProperty);
        }

        public static void SetFromThickness(FrameworkElement element, Thickness value)
        {
            element.SetValue(FromThicknessProperty, value);
        }

        public static readonly DependencyProperty FromThicknessProperty =
            DependencyProperty.RegisterAttached("FromThickness", typeof(Thickness), typeof(ThicknessAnimationHelper), new PropertyMetadata(OnFromThicknessChanged));
        #endregion

        #region ToThickness
        public static Thickness? GetToThickness(FrameworkElement element)
        {
            return (Thickness?)element.GetValue(ToThicknessProperty);
        }

        public static void SetToThickness(FrameworkElement element, Thickness? value)
        {
            element.SetValue(ToThicknessProperty, value);
        }

        public static readonly DependencyProperty ToThicknessProperty =
            DependencyProperty.RegisterAttached("ToThickness", typeof(Thickness?), typeof(ThicknessAnimationHelper));
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
            DependencyProperty.RegisterAttached("AnimationDuration", typeof(TimeSpan), typeof(ThicknessAnimationHelper), new PropertyMetadata(TimeSpan.FromSeconds(0.4)));
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
            DependencyProperty.RegisterAttached("IsTransitioning", typeof(bool), typeof(ThicknessAnimationHelper), new PropertyMetadata(OnIsTransitioningChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnFromThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element)
            {
                SetCurrentThickness(element, GetFromThickness(element));
            }
        }

        private static void OnIsTransitioningChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element
                && GetToThickness(element) != null)
            {
                var brushAnimation = new ThicknessAnimation()
                {
                    Duration = GetAnimationDuration(element),
                };

                if (GetIsTransitioning(element))
                {
                    brushAnimation.To = GetToThickness(element);
                }

                element.BeginAnimation(CurrentThicknessProperty, brushAnimation);
            }
        }
        #endregion

    }
}
