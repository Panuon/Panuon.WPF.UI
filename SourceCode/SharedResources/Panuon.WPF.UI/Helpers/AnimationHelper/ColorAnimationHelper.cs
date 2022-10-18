using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.WPF.UI
{
    public static class ColorAnimationHelper
    {
        #region Properties

        #region CurrentColor
        public static Color GetCurrentColor(FrameworkElement element)
        {
            return (Color)element.GetValue(CurrentColorProperty);
        }

        public static void SetCurrentColor(FrameworkElement element, Color value)
        {
            element.SetValue(CurrentColorProperty, value);
        }

        public static readonly DependencyProperty CurrentColorProperty =
            DependencyProperty.RegisterAttached("CurrentColor", typeof(Color), typeof(ColorAnimationHelper));
        #endregion

        #region FromColor
        public static Color GetFromColor(FrameworkElement element)
        {
            return (Color)element.GetValue(FromColorProperty);
        }

        public static void SetFromColor(FrameworkElement element, Color value)
        {
            element.SetValue(FromColorProperty, value);
        }

        public static readonly DependencyProperty FromColorProperty =
            DependencyProperty.RegisterAttached("FromColor", typeof(Color), typeof(ColorAnimationHelper), new PropertyMetadata(OnFromColorChanged));
        #endregion

        #region ToColor
        public static Color? GetToColor(FrameworkElement element)
        {
            return (Color?)element.GetValue(ToColorProperty);
        }

        public static void SetToColor(FrameworkElement element, Color? value)
        {
            element.SetValue(ToColorProperty, value);
        }

        public static readonly DependencyProperty ToColorProperty =
            DependencyProperty.RegisterAttached("ToColor", typeof(Color?), typeof(ColorAnimationHelper));
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
            DependencyProperty.RegisterAttached("AnimationDuration", typeof(TimeSpan), typeof(ColorAnimationHelper), new PropertyMetadata(TimeSpan.FromSeconds(0.4)));
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
            DependencyProperty.RegisterAttached("IsTransitioning", typeof(bool), typeof(ColorAnimationHelper), new PropertyMetadata(OnIsTransitioningChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnFromColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element)
            {
                SetCurrentColor(element, GetFromColor(element));
            }
        }

        private static void OnIsTransitioningChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement element
                && GetToColor(element) != null)
            {
                var brushAnimation = new ColorAnimation()
                {
                    Duration = GetAnimationDuration(element),
                };

                if (GetIsTransitioning(element))
                {
                    brushAnimation.To = GetToColor(element);
                }

                element.BeginAnimation(CurrentColorProperty, brushAnimation);
            }
        }
        #endregion

    }
}
