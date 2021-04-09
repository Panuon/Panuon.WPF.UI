using Panuon.UI.Core;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.UI.Silver.Internal.Utils
{
    static class AnimationUtil
    {
        #region Methods

        #region BeginBrushAnimationStoryboard
        public static void BeginBrushAnimationStoryboard(DependencyObject obj, Dictionary<DependencyProperty, Brush> propertyValues, TimeSpan? duration = null)
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
                Storyboard.SetTarget(anima, obj);
                Storyboard.SetTargetProperty(anima, new PropertyPath(propertyValue.Key));
                storyboard.Children.Add(anima);
            }
            storyboard.Begin();
        }

        public static void BeginBrushAnimationStoryboard(DependencyObject obj, List<DependencyProperty> properties, TimeSpan? duration = null)
        {
            var storyboard = new Storyboard();
            foreach (var dp in properties)
            {
                var anima = new BrushAnimation()
                {
                    Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                };
                Storyboard.SetTarget(anima, obj);
                Storyboard.SetTargetProperty(anima, new PropertyPath(dp));
                storyboard.Children.Add(anima);
            }
            storyboard.Begin();
        }
        #endregion

        #region BeginDoubleAnimationStoryboard
        public static void BeginDoubleAnimationStoryboard(DependencyObject obj, Dictionary<DependencyProperty, double> propertyValues, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEase? ease = null, Action callback = null)
        {
            var storyboard = new Storyboard();
            foreach (var propertyValue in propertyValues)
            {
                var anima = new DoubleAnimation()
                {
                    To = propertyValue.Value,
                    Duration = duration ?? GlobalSettings.Setting.AnimationDuration,
                    BeginTime = beginTime ?? TimeSpan.Zero,
                    EasingFunction = CreateEasingFunction(ease),
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
        public static void BeginDoubleAnimation(UIElement element, DependencyProperty property, double? from, double? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEase? ease = null, Action callback = null)
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

        public static void BeginDoubleAnimation(Animatable animatable, DependencyProperty property, double? from, double? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEase? ease = null, Action callback = null)
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
        public static void BeginThicknessAnimation(UIElement element, DependencyProperty property, Thickness? from, Thickness? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEase? ease = null, Action callback = null)
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

        public static void BeginThicknessAnimation(Animatable animatable, DependencyProperty property, Thickness? from, Thickness? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEase? ease = null, Action callback = null)
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
        public static void BeginColorAnimation(UIElement element, DependencyProperty property, Color? from, Color? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEase? ease = null, Action callback = null)
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


        public static void BeginColorAnimation(Animatable obj, DependencyProperty property, Color? from, Color? to, TimeSpan? duration = null, TimeSpan? beginTime = null, AnimationEase? ease = null, Action callback = null)
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
        public static IEasingFunction CreateEasingFunction(AnimationEase? animationEasing)
        {
            if (animationEasing == null)
            {
                return null;
            }
            switch (animationEasing)
            {
                case AnimationEase.BackIn:
                    return new BackEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.BackOut:
                    return new BackEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.BackInOut:
                    return new BackEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.BounceIn:
                    return new BounceEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.BounceOut:
                    return new BounceEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.BounceInOut:
                    return new BounceEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.CircleIn:
                    return new CircleEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.CircleOut:
                    return new CircleEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.CircleInOut:
                    return new CircleEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.CubicIn:
                    return new CubicEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.CubicOut:
                    return new CubicEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.CubicInOut:
                    return new CubicEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.ElasticIn:
                    return new ElasticEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.ElasticOut:
                    return new ElasticEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.ElasticInOut:
                    return new ElasticEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.ExponentialIn:
                    return new ExponentialEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.ExponentialOut:
                    return new ExponentialEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.ExponentialInOut:
                    return new ExponentialEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.PowerIn:
                    return new PowerEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.PowerOut:
                    return new PowerEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.PowerInOut:
                    return new PowerEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.QuadraticIn:
                    return new QuadraticEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.QuadraticOut:
                    return new QuadraticEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.QuadraticInOut:
                    return new QuadraticEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.QuarticIn:
                    return new QuarticEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.QuarticOut:
                    return new QuarticEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.QuarticInOut:
                    return new QuarticEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.QuinticIn:
                    return new QuarticEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.QuinticOut:
                    return new QuarticEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.QuinticInOut:
                    return new QuarticEase() { EasingMode = EasingMode.EaseInOut };
                case AnimationEase.SineIn:
                    return new SineEase() { EasingMode = EasingMode.EaseIn };
                case AnimationEase.SineOut:
                    return new SineEase() { EasingMode = EasingMode.EaseOut };
                case AnimationEase.SineInOut:
                    return new SineEase() { EasingMode = EasingMode.EaseInOut };
            }
            return null;
        }
        #endregion

        #endregion
    }
}
