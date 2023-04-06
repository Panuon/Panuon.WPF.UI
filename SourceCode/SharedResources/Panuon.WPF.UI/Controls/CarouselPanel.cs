using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.WPF.UI
{
    public class CarouselPanel 
        : Panel
    {
        #region Ctor
        static CarouselPanel()
        {
            ClipToBoundsProperty.OverrideMetadata(typeof(CarouselPanel), new FrameworkPropertyMetadata(true));
        }
        #endregion

        #region Internal Events
        internal event EventHandler InternalChildrenChanged;
        #endregion

        #region Properties

        #region Animation
        public CarouselAnimation Animation
        {
            get { return (CarouselAnimation)GetValue(AnimationProperty); }
            set { SetValue(AnimationProperty, value); }
        }

        public static readonly DependencyProperty AnimationProperty =
            DependencyProperty.Register("Animation", typeof(CarouselAnimation), typeof(CarouselPanel), new PropertyMetadata(CarouselAnimation.Slide));
        #endregion

        #region AnimationEasing
        public AnimationEasing AnimationEasing
        {
            get { return (AnimationEasing)GetValue(AnimationEasingProperty); }
            set { SetValue(AnimationEasingProperty, value); }
        }

        public static readonly DependencyProperty AnimationEasingProperty =
            DependencyProperty.Register("AnimationEasing", typeof(AnimationEasing), typeof(CarouselPanel));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(CarouselPanel), new PropertyMetadata(TimeSpan.FromSeconds(0.3)));
        #endregion

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(CarouselPanel));
        #endregion

        #region CurrentIndex
        public int CurrentIndex
        {
            get { return (int)GetValue(CurrentIndexProperty); }
            set { SetValue(CurrentIndexProperty, value); }
        }

        public static readonly DependencyProperty CurrentIndexProperty =
            DependencyProperty.Register("CurrentIndex", typeof(int), typeof(CarouselPanel), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnCurrentIndexChanged, OnCurrentIndexCoerceValue));
        #endregion

        #region IsCyclic
        public bool IsCyclic
        {
            get { return (bool)GetValue(IsCyclicProperty); }
            set { SetValue(IsCyclicProperty, value); }
        }

        public static readonly DependencyProperty IsCyclicProperty =
            DependencyProperty.Register("IsCyclic", typeof(bool), typeof(CarouselPanel), new PropertyMetadata(true));
        #endregion

        #endregion

        #region Internal Properties

        #region CurrentAnimation
        public static AnimationTimeline GetCurrentAnimation(DependencyObject obj)
        {
            return (AnimationTimeline)obj.GetValue(CurrentAnimationProperty);
        }

        public static void SetCurrentAnimation(DependencyObject obj, AnimationTimeline value)
        {
            obj.SetValue(CurrentAnimationProperty, value);
        }

        public static readonly DependencyProperty CurrentAnimationProperty =
            DependencyProperty.RegisterAttached("CurrentAnimation", typeof(AnimationTimeline), typeof(CarouselPanel));
        #endregion

        #endregion

        #region Overrides
        protected override Size MeasureOverride(Size availableSize)
        {
            foreach (UIElement child in InternalChildren)
            {
                child.Measure(availableSize);
            }
            return base.MeasureOverride(availableSize);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            for (int i = 0; i < InternalChildren.Count; i++)
            {
                var child = InternalChildren[i];
                if (i != CurrentIndex)
                {
                    child.Opacity = 0;
                    child.Visibility = Visibility.Hidden;
                }

                child.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
            }
            InternalChildrenChanged?.Invoke(this, EventArgs.Empty);
            CoerceValue(CurrentIndexProperty);
            return base.ArrangeOverride(finalSize);
        }

        protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
        {
            base.OnVisualChildrenChanged(visualAdded, visualRemoved);

            var currentIndex = CurrentIndex;
            if (currentIndex >= 0 && currentIndex < InternalChildren.Count)
            {
                var currentElement = InternalChildren[currentIndex] as UIElement;
                if (currentElement == null)
                {

                    while (currentElement == null)
                    {
                        currentIndex++;

                        if (currentIndex > InternalChildren.Count - 1)
                        {
                            currentIndex = 0;
                        }

                        if (currentIndex == CurrentIndex)
                        {
                            return;
                        }
                        currentElement = InternalChildren[currentIndex] as UIElement;

                    }

                    if (currentIndex >= 0 && currentIndex < InternalChildren.Count)
                    {
                        OnCurrentIndexChanged(CurrentIndex, currentIndex);
                    }
                }
            }
        }
        #endregion

        #region Event Handlers
        private static void OnCurrentIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var cardPanel = (CarouselPanel)d;
            cardPanel.OnCurrentIndexChanged((int)e.OldValue, (int)e.NewValue);
        }

        private static object OnCurrentIndexCoerceValue(DependencyObject d, object baseValue)
        {
            var carousel = (CarouselPanel)d;
            var currentIndex = (int)baseValue;
            if (currentIndex < 0)
            {
                return carousel.IsCyclic
                    ? Math.Max(0, carousel.Children.Count - 1)
                    : 0;
            }
            if (carousel.IsLoaded && currentIndex > carousel.Children.Count - 1)
            {
                return carousel.IsCyclic
                    ? 0
                    : Math.Max(0, carousel.Children.Count - 1);
            }
            return baseValue;
        }
        #endregion

        #region Functions
        private void OnCurrentIndexChanged(int oldIndex, int newIndex)
        {
            if (Animation.HasFlag(CarouselAnimation.Flow)
                && Animation.HasFlag(CarouselAnimation.Slide))
            {
                throw new Exception("CarouselPanel : Flow animation and Slide animation cannot be used together.");
            }
            if(ActualWidth == 0
                && ActualHeight == 0)
            {
                return;
            }

            var oldChild = (oldIndex >= 0 && oldIndex <= InternalChildren.Count - 1)
                ? InternalChildren[oldIndex] as FrameworkElement
                : null;

            var newChild = (newIndex >= 0 && newIndex <= InternalChildren.Count - 1)
                ? InternalChildren[newIndex] as FrameworkElement
                : null;

            BeginOldChildAnimation(oldChild, newIndex > oldIndex);
            BeginNewChildAnimation(newChild, newIndex > oldIndex);
        }

        private void BeginOldChildAnimation(FrameworkElement oldChild, bool forward)
        {
            if(oldChild == null)
            {
                return;
            }
            
            var oldTranformGroup = oldChild.RenderTransform as TransformGroup;
            if (oldTranformGroup == null
                || oldTranformGroup.Children.Count != 2
                || !(oldTranformGroup.Children[0] is TranslateTransform)
                || !(oldTranformGroup.Children[1] is ScaleTransform))
            {
                oldTranformGroup = new TransformGroup();
                var translateTransform = new TranslateTransform();
                oldTranformGroup.Children.Add(translateTransform);
                var scaleTransform = new ScaleTransform();
                oldTranformGroup.Children.Add(scaleTransform);
                oldChild.RenderTransformOrigin = new Point(0.5, 0.5);
                oldChild.RenderTransform = oldTranformGroup;
            }
            var oldScaleTranform = oldTranformGroup.Children[1] as ScaleTransform;

            if (Animation.HasFlag(CarouselAnimation.Fade))
            {
                var oldOpacityAnimation = new DoubleAnimation()
                {
                    To = 0,
                    Duration = AnimationDuration,
                    EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                };
                oldOpacityAnimation.Completed += delegate
                {
                    if (GetCurrentAnimation(oldChild) == oldOpacityAnimation)
                    {
                        oldChild.Visibility = Visibility.Collapsed;
                        SetCurrentAnimation(oldChild, null);
                    }
                };
                SetCurrentAnimation(oldChild, oldOpacityAnimation);
                oldChild.BeginAnimation(OpacityProperty, oldOpacityAnimation);
            }
            else
            {
                oldChild.BeginAnimation(OpacityProperty, null);
                oldChild.Opacity = 1;
            }

            if (Animation.HasFlag(CarouselAnimation.Slide))
            {
                if (forward)
                {
                    var oldThicknessAnimation = new ThicknessAnimation()
                    {
                        From = new Thickness(),
                        To = Orientation == Orientation.Horizontal
                            ? new Thickness(-ActualWidth, 0, ActualWidth, 0)
                            : new Thickness(0, -ActualHeight, 0, ActualHeight),
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };
                    oldChild.BeginAnimation(MarginProperty, oldThicknessAnimation);
                    SetCurrentAnimation(oldChild, oldThicknessAnimation);

                    oldThicknessAnimation.Completed += delegate
                    {
                        if (GetCurrentAnimation(oldChild) == oldThicknessAnimation)
                        {
                            oldChild.Visibility = Visibility.Collapsed;
                            SetCurrentAnimation(oldChild, null);
                        }
                    };
                }
                else
                {
                    var oldThicknessAnimation = new ThicknessAnimation()
                    {
                        From = new Thickness(),
                        To = Orientation == Orientation.Horizontal
                            ? new Thickness(ActualWidth, 0, -ActualWidth, 0)
                            : new Thickness(0, ActualHeight, 0, -ActualHeight),
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };
                    oldChild.BeginAnimation(MarginProperty, oldThicknessAnimation);
                    SetCurrentAnimation(oldChild, oldThicknessAnimation);

                    oldThicknessAnimation.Completed += delegate
                    {
                        if (GetCurrentAnimation(oldChild) == oldThicknessAnimation)
                        {
                            oldChild.Visibility = Visibility.Collapsed;
                            SetCurrentAnimation(oldChild, null);
                        }
                    };
                }
            }
            else if (Animation.HasFlag(CarouselAnimation.Flow))
            {
                oldChild.Visibility = Visibility.Collapsed;
            }
            else
            {
                oldChild.BeginAnimation(MarginProperty, null);
                oldChild.Margin = new Thickness();
            }

            if (Animation.HasFlag(CarouselAnimation.Scale))
            {
                if (forward)
                {
                    var oldDoubleAnimation = new DoubleAnimation()
                    {
                        From = 1,
                        To = 0.8,
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };

                    oldDoubleAnimation.Completed += delegate
                    {
                        if (GetCurrentAnimation(oldChild) == oldDoubleAnimation)
                        {
                            oldChild.Visibility = Visibility.Collapsed;
                            SetCurrentAnimation(oldChild, null);
                        }
                    };
                    oldScaleTranform.BeginAnimation(ScaleTransform.ScaleXProperty, oldDoubleAnimation);
                    oldScaleTranform.BeginAnimation(ScaleTransform.ScaleYProperty, oldDoubleAnimation);
                    SetCurrentAnimation(oldChild, oldDoubleAnimation);
                }
                else
                {
                    var newDoubleAnimation = new DoubleAnimation()
                    {
                        From = 0.8,
                        To = 1,
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };

                    var oldDoubleAnimation = new DoubleAnimation()
                    {
                        From = 1,
                        To = 1.2,
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };

                    oldDoubleAnimation.Completed += delegate
                    {
                        if (GetCurrentAnimation(oldChild) == oldDoubleAnimation)
                        {
                            oldChild.Visibility = Visibility.Collapsed;
                            SetCurrentAnimation(oldChild, null);
                        }
                    };
                    oldScaleTranform.BeginAnimation(ScaleTransform.ScaleXProperty, oldDoubleAnimation);
                    oldScaleTranform.BeginAnimation(ScaleTransform.ScaleYProperty, oldDoubleAnimation);
                    SetCurrentAnimation(oldChild, oldDoubleAnimation);
                }
            }
            else
            {
                oldScaleTranform.BeginAnimation(ScaleTransform.ScaleXProperty, null);
                oldScaleTranform.BeginAnimation(ScaleTransform.ScaleYProperty, null);
                oldScaleTranform.ScaleX = 1;
                oldScaleTranform.ScaleY = 1;
            }

        }

        private void BeginNewChildAnimation(FrameworkElement newChild, bool forward)
        {
            if(newChild == null)
            {
                return;
            }
            
            var newTranformGroup = newChild?.RenderTransform as TransformGroup;
            if (newTranformGroup == null
                || newTranformGroup.Children.Count != 2
                || !(newTranformGroup.Children[0] is TranslateTransform)
                || !(newTranformGroup.Children[1] is ScaleTransform))
            {
                newChild.RenderTransformOrigin = new Point(0.5, 0.5);
                newTranformGroup = new TransformGroup();
                var translateTransform = new TranslateTransform();
                newTranformGroup.Children.Add(translateTransform);
                var scaleTransform = new ScaleTransform();
                newTranformGroup.Children.Add(scaleTransform);
                newChild.RenderTransform = newTranformGroup;
            }
            var newScaleTranform = newTranformGroup.Children[1] as ScaleTransform;

            newChild.Visibility = Visibility.Visible;

            if (Animation.HasFlag(CarouselAnimation.Fade))
            {
                var newOpacityAnimation = new DoubleAnimation()
                {
                    To = 1,
                    Duration = AnimationDuration,
                    EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                };
                newChild.BeginAnimation(OpacityProperty, newOpacityAnimation);
                SetCurrentAnimation(newChild, newOpacityAnimation);

            }
            else
            {
                newChild.BeginAnimation(OpacityProperty, null);
                newChild.Opacity = 1;
            }

            if (Animation.HasFlag(CarouselAnimation.Slide))
            {
                if (forward)
                {
                    var newThicknessAnimation = new ThicknessAnimation()
                    {
                        From = Orientation == Orientation.Horizontal
                            ? new Thickness(ActualWidth, 0, -ActualWidth, 0)
                            : new Thickness(0, ActualHeight, 0, -ActualHeight),
                        To = new Thickness(),
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };
                    newChild.BeginAnimation(MarginProperty, newThicknessAnimation);
                }
                else
                {
                    var newThicknessAnimation = new ThicknessAnimation()
                    {
                        From = Orientation == Orientation.Horizontal
                            ? new Thickness(-ActualWidth, 0, ActualWidth, 0)
                            : new Thickness(0, -ActualHeight, 0, ActualHeight),
                        To = new Thickness(),
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };
                    newChild.BeginAnimation(MarginProperty, newThicknessAnimation);
                }
            }
            else if (Animation.HasFlag(CarouselAnimation.Flow))
            {
                var newThicknessAnimation = new ThicknessAnimation()
                {
                    From = Orientation == Orientation.Horizontal
                            ? (forward ? new Thickness(10, 0, -10, 0) : new Thickness(-10, 0, 10, 0))
                            : (forward ? new Thickness(0, 10, 0, -10) : new Thickness(0, -10, 0, 10)),
                    To = new Thickness(),
                    Duration = AnimationDuration,
                    EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                };
                newChild.BeginAnimation(MarginProperty, newThicknessAnimation);
            }
            else
            {
                newChild.BeginAnimation(MarginProperty, null);
                newChild.Margin = new Thickness();
            }

            if (Animation.HasFlag(CarouselAnimation.Scale))
            {
                if (forward)
                {
                    var newDoubleAnimation = new DoubleAnimation()
                    {
                        From = 1.2,
                        To = 1,
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };
                    newScaleTranform.BeginAnimation(ScaleTransform.ScaleXProperty, newDoubleAnimation);
                    newScaleTranform.BeginAnimation(ScaleTransform.ScaleYProperty, newDoubleAnimation);
                }
                else
                {
                    var newDoubleAnimation = new DoubleAnimation()
                    {
                        From = 0.8,
                        To = 1,
                        Duration = AnimationDuration,
                        EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                    };
                    newScaleTranform.BeginAnimation(ScaleTransform.ScaleXProperty, newDoubleAnimation);
                    newScaleTranform.BeginAnimation(ScaleTransform.ScaleYProperty, newDoubleAnimation);
                }
            }
            else
            {
                newScaleTranform.BeginAnimation(ScaleTransform.ScaleXProperty, null);
                newScaleTranform.BeginAnimation(ScaleTransform.ScaleYProperty, null);
                newScaleTranform.ScaleX = 1;
                newScaleTranform.ScaleY = 1;
            }
        }
        #endregion
    }
}
