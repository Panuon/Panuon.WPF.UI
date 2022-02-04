using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Panuon.UI.Silver
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

        #region Properties

        #region Animation
        public CarouselAnimation Animation
        {
            get { return (CarouselAnimation)GetValue(AnimationProperty); }
            set { SetValue(AnimationProperty, value); }
        }

        public static readonly DependencyProperty AnimationProperty =
            DependencyProperty.Register("Animation", typeof(CarouselAnimation), typeof(CarouselPanel));
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
            DependencyProperty.Register("CurrentIndex", typeof(int), typeof(CarouselPanel), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnCurrentIndexChanged, OnSelectedCoerceValue));
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
            return base.ArrangeOverride(finalSize);
        }

        #endregion

        #region Event Handlers

        private static void OnCurrentIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var cardPanel = (CarouselPanel)d;
            cardPanel.OnCurrentIndexChanged((int)e.OldValue, (int)e.NewValue);
        }

        private static object OnSelectedCoerceValue(DependencyObject d, object baseValue)
        {
            var cardPanel = (CarouselPanel)d;
            var CurrentIndex = (int)baseValue;
            if (CurrentIndex < 0)
            {
                return 0;
            }
            if (cardPanel.IsLoaded && CurrentIndex > cardPanel.Children.Count - 1)
            {
                return cardPanel.Children.Count - 1;
            }
            return baseValue;
        }

        #endregion

        #region Functions
        private void OnCurrentIndexChanged(int oldIndex, int newIndex)
        {
            var oldChild = InternalChildren[oldIndex];
            oldChild.Opacity = 0;
            oldChild.Visibility = Visibility.Collapsed;

            var newChild = InternalChildren[newIndex];
            newChild.Opacity = 0;
            newChild.Visibility = Visibility.Visible;

            newChild.BeginAnimation(OpacityProperty, null);
            newChild.BeginAnimation(MarginProperty, null);
            var opacityAnima = new DoubleAnimation()
            {
                To = 1,
                Duration = TimeSpan.FromSeconds(0.4),
                EasingFunction = new CircleEase() { EasingMode = EasingMode.EaseInOut },
            };
            var thicknessAnima = new ThicknessAnimation()
            {
                To = new Thickness(),
                Duration = TimeSpan.FromSeconds(0.4),
                EasingFunction = new CircleEase() { EasingMode = EasingMode.EaseInOut },
            };
            thicknessAnima.From = Orientation == Orientation.Horizontal ?
                (newIndex > oldIndex ? new Thickness(10, 0, -10, 0) : new Thickness(-10, 0, 10, 0))
                : (newIndex > oldIndex ? new Thickness(0, 10, 0, -10) : new Thickness(0, -10, 0, 10));

            newChild.BeginAnimation(OpacityProperty, opacityAnima);
            newChild.BeginAnimation(MarginProperty, thicknessAnima);
        }
        #endregion
    }
}
