using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.WPF.UI.Internal.Utils
{
    static class AnimationUtil
    {
        #region Methods

        #region BeginAnimationStoryboard
        public static void BeginAnimationStoryboard(DependencyObject obj,
            Dictionary<DependencyProperty, object> propertyValues,
            TimeSpan? duration = null)
        {
            var storyboard = new Storyboard();
            foreach (var propertyValue in propertyValues)
            {
                AnimationTimeline anima = null;
                if (propertyValue.Value is Brush)
                {
                    var value = (Brush)propertyValue.Value;
                    if (!value.CanFreeze)
                    {
                        continue;
                    }
                    anima = new BrushAnimation()
                    {
                        To = value,
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                else if (propertyValue.Value is Thickness)
                {
                    var value = (Thickness)propertyValue.Value;
                    anima = new ThicknessAnimation()
                    {
                        To = value,
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                else if (propertyValue.Value is CornerRadius)
                {
                    var value = (CornerRadius)propertyValue.Value;
                    anima = new CornerRadiusAnimation()
                    {
                        To = value,
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                if (anima != null)
                {
                    Storyboard.SetTarget(anima, obj);
                    Storyboard.SetTargetProperty(anima, new PropertyPath(propertyValue.Key));
                    storyboard.Children.Add(anima);
                }
            }
            storyboard.Begin();
        }
        #endregion

        #region BeginBrushAnimationStoryboard
        public static void BeginBrushAnimationStoryboard(FrameworkElement element, 
            Dictionary<DependencyProperty, Brush> propertyValues, 
            TimeSpan? duration = null)
        {
            var storyboard = new Storyboard();
            foreach (var propertyValue in propertyValues)
            {
                if (!propertyValue.Value.CanFreeze)
                {
                    continue;
                }
                var anima = new BrushAnimation()
                {
                    To = propertyValue.Value,
                    Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                };
                Storyboard.SetTarget(anima, element);
                Storyboard.SetTargetProperty(anima, new PropertyPath(propertyValue.Key));
                storyboard.Children.Add(anima);
            }
            storyboard.Begin();
        }

        public static void BeginBrushAnimationStoryboard(FrameworkElement element,
            Dictionary<DependencyProperty, object> propertyValues,
            TimeSpan? duration = null)
        {
            var storyboard = new Storyboard();
            foreach (var propertyValue in propertyValues)
            {
                AnimationTimeline anima = null;

                if (propertyValue.Value is Brush brushValue)
                {
                    if (!brushValue.CanFreeze)
                    {
                        continue;
                    }
                    anima = new BrushAnimation()
                    {
                        To = brushValue,
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                if (propertyValue.Value is Thickness thicknessValue)
                {
                    anima = new ThicknessAnimation()
                    {
                        To = thicknessValue,
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                if (propertyValue.Value is CornerRadius cornerRadiusValue)
                {
                    anima = new CornerRadiusAnimation()
                    {
                        To = cornerRadiusValue,
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                Storyboard.SetTarget(anima, element);
                Storyboard.SetTargetProperty(anima, new PropertyPath(propertyValue.Key));
                storyboard.Children.Add(anima);
            }
            storyboard.Begin();
        }

        public static void BeginBrushAnimationStoryboard(FrameworkElement element,
            List<DependencyProperty> properties,
            TimeSpan? duration = null)
        {
            var storyboard = new Storyboard();
            foreach (var dp in properties)
            {
                AnimationTimeline anima = null;

                if (dp.PropertyType == typeof(Brush))
                {
                    anima = new BrushAnimation()
                    {
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                else if (dp.PropertyType == typeof(Thickness))
                {
                    anima = new ThicknessAnimation()
                    {
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                else if (dp.PropertyType == typeof(CornerRadius))
                {
                    anima = new CornerRadiusAnimation()
                    {
                        Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    };
                }
                Storyboard.SetTarget(anima, element);
                    Storyboard.SetTargetProperty(anima, new PropertyPath(dp));
                    storyboard.Children.Add(anima);
            }
            storyboard.Begin();
        }
        #endregion

        #region BeginDoubleAnimationStoryboard
        public static void BeginDoubleAnimationStoryboard(DependencyObject obj, 
            Dictionary<DependencyProperty, double> propertyValues, 
            TimeSpan? duration = null, 
            TimeSpan? beginTime = null, 
            AnimationEasing? easing = null, 
            Action callback = null,
            RepeatBehavior? repeatBehavior = null)
        {
            var storyboard = new Storyboard();
            if(repeatBehavior != null)
            {
                storyboard.RepeatBehavior = (RepeatBehavior)repeatBehavior;
            }
            foreach (var propertyValue in propertyValues)
            {
                var anima = new DoubleAnimation()
                {
                    To = propertyValue.Value,
                    Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    BeginTime = beginTime ?? TimeSpan.Zero,
                    EasingFunction = CreateEasingFunction(easing),
                };
                Storyboard.SetTarget(anima, obj);
                Storyboard.SetTargetProperty(anima, new PropertyPath(propertyValue.Key));
                storyboard.Children.Add(anima);
            }

            if (callback != null)
            {
                storyboard.Completed += delegate
                {
                    callback?.Invoke();
                };
            }

            storyboard.Begin();
        }
        #endregion

        #region BeginDoubleAnimation
        public static void BeginDoubleAnimation(UIElement element,
            DependencyProperty property, 
            double? from, 
            double? to,
            TimeSpan? duration = null, 
            TimeSpan? beginTime = null,
            AnimationEasing? ease = null, 
            Action callback = null)
        {
            var anima = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                BeginTime = beginTime ?? TimeSpan.Zero,
                EasingFunction = CreateEasingFunction(ease),
            };

            if (callback != null)
            {
                anima.Completed += delegate
                {
                    callback?.Invoke();
                };
            }

            element.BeginAnimation(property, anima);
        }

        public static void BeginDoubleAnimation(Animatable animatable, DependencyProperty property, double? from, double? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEasing? ease = null, Action callback = null)
        {
            var anima = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                BeginTime = beginTime ?? TimeSpan.Zero,
                EasingFunction = CreateEasingFunction(ease),
            };

            if (callback != null)
            {
                anima.Completed += delegate
                {
                    callback?.Invoke();
                };
            }

            animatable.BeginAnimation(property, anima);
        }

        #endregion

        #region BeginThicknessAnimation
        public static void BeginThicknessAnimation(UIElement element, DependencyProperty property, Thickness? from, Thickness? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEasing? ease = null, Action callback = null)
        {
            var anima = new ThicknessAnimation()
            {
                From = from,
                To = to,
                Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                BeginTime = beginTime ?? TimeSpan.Zero,
                EasingFunction = CreateEasingFunction(ease),
            };

            if (callback != null)
            {
                anima.Completed += delegate
                {
                    callback?.Invoke();
                };
            }

            element.BeginAnimation(property, anima);
        }

        public static void BeginThicknessAnimation(Animatable animatable, DependencyProperty property, Thickness? from, Thickness? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEasing? ease = null, Action callback = null)
        {
            var anima = new ThicknessAnimation()
            {
                From = from,
                To = to,
                Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                BeginTime = beginTime ?? TimeSpan.Zero,
                EasingFunction = CreateEasingFunction(ease),
            };

            if (callback != null)
            {
                anima.Completed += delegate
                {
                    callback?.Invoke();
                };
            }

            animatable.BeginAnimation(property, anima);
        }

        #endregion

        #region BeginColorAnimation
        public static void BeginColorAnimation(UIElement element, DependencyProperty property, Color? from, Color? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEasing? ease = null, Action callback = null)
        {
            var anima = new ColorAnimation()
            {
                From = from,
                To = to,
                Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                BeginTime = beginTime ?? TimeSpan.Zero,
                EasingFunction = CreateEasingFunction(ease),
            };

            if (callback != null)
            {
                anima.Completed += delegate
                {
                    callback?.Invoke();
                };
            }

            element.BeginAnimation(property, anima);
        }


        public static void BeginColorAnimation(Animatable obj, DependencyProperty property, Color? from, Color? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEasing? ease = null, Action callback = null)
        {
            var anima = new ColorAnimation()
            {
                From = from,
                To = to,
                Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                BeginTime = beginTime ?? TimeSpan.Zero,
                EasingFunction = CreateEasingFunction(ease),
            };

            if (callback != null)
            {
                anima.Completed += delegate
                {
                    callback?.Invoke();
                };
            }

            obj.BeginAnimation(property, anima);
        }
        #endregion

        #region CreateEasingFunction
        public static IEasingFunction CreateEasingFunction(AnimationEasing? animationEasing)
        {
            if (animationEasing == null)
            {
                return null;
            }
            switch (animationEasing)
            {
                case AnimationEasing.BackIn:
                    return new BackEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.BackOut:
                    return new BackEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.BackInOut:
                    return new BackEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.BounceIn:
                    return new BounceEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.BounceOut:
                    return new BounceEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.BounceInOut:
                    return new BounceEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.CircleIn:
                    return new CircleEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.CircleOut:
                    return new CircleEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.CircleInOut:
                    return new CircleEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.CubicIn:
                    return new CubicEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.CubicOut:
                    return new CubicEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.CubicInOut:
                    return new CubicEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.ElasticIn:
                    return new ElasticEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.ElasticOut:
                    return new ElasticEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.ElasticInOut:
                    return new ElasticEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.ExponentialIn:
                    return new ExponentialEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.ExponentialOut:
                    return new ExponentialEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.ExponentialInOut:
                    return new ExponentialEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.PowerIn:
                    return new PowerEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.PowerOut:
                    return new PowerEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.PowerInOut:
                    return new PowerEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.QuadraticIn:
                    return new QuadraticEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.QuadraticOut:
                    return new QuadraticEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.QuadraticInOut:
                    return new QuadraticEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.QuarticIn:
                    return new QuarticEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.QuarticOut:
                    return new QuarticEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.QuarticInOut:
                    return new QuarticEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.QuinticIn:
                    return new QuarticEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.QuinticOut:
                    return new QuarticEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.QuinticInOut:
                    return new QuarticEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEasing.SineIn:
                    return new SineEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEasing.SineOut:
                    return new SineEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEasing.SineInOut:
                    return new SineEase() { EasingMode = EasingMode.EaseInOut };
            }
            return null;
        }
        #endregion

        #endregion
    }
}
