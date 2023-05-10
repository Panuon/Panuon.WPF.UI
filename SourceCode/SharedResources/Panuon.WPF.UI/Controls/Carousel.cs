using Panuon.WPF;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.WPF.UI
{
    public class Carousel
        : ItemsControl
    {
        #region Fields
        private Timer _timer;
        #endregion

        #region Ctor
        static Carousel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Carousel), new FrameworkPropertyMetadata(typeof(Carousel)));
        }
        #endregion

        #region Commands
        public ICommand PageUpCommand => (ICommand)GetValue(PageUpCommandProperty);
        
        public static readonly DependencyProperty PageUpCommandProperty =
            DependencyProperty.Register("PageUpCommand", typeof(ICommand), typeof(Carousel), new PropertyMetadata(new RelayCommand(OnPageUpCommandExecute, OnPageUpCommandCanExecute)));

        public ICommand PageDownCommand => (ICommand)GetValue(PageDownCommandProperty);
        
        public static readonly DependencyProperty PageDownCommandProperty =
            DependencyProperty.Register("PageDownCommand", typeof(ICommand), typeof(Carousel), new PropertyMetadata(new RelayCommand(OnPageDownCommandExecute, OnPageDownCommandCanExecute)));
        #endregion

        #region Properties

        #region Animation
        public CarouselAnimation Animation
        {
            get { return (CarouselAnimation)GetValue(AnimationProperty); }
            set { SetValue(AnimationProperty, value); }
        }

        public static readonly DependencyProperty AnimationProperty =
            DependencyProperty.Register("Animation", typeof(CarouselAnimation), typeof(Carousel), new PropertyMetadata(CarouselAnimation.Slide));
        #endregion

        #region AnimationEasing
        public AnimationEasing AnimationEasing
        {
            get { return (AnimationEasing)GetValue(AnimationEasingProperty); }
            set { SetValue(AnimationEasingProperty, value); }
        }

        public static readonly DependencyProperty AnimationEasingProperty =
            DependencyProperty.Register("AnimationEasing", typeof(AnimationEasing), typeof(Carousel));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(Carousel), new PropertyMetadata(TimeSpan.FromSeconds(0.3)));
        #endregion

        #region CurrentIndex
        public int CurrentIndex
        {
            get { return (int)GetValue(CurrentIndexProperty); }
            set { SetValue(CurrentIndexProperty, value); }
        }

        public static readonly DependencyProperty CurrentIndexProperty =
            DependencyProperty.Register("CurrentIndex", typeof(int), typeof(Carousel), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnCurrentIndexChanged, OnCurrentIndexCoerceValue));

        #endregion

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(Carousel));
        #endregion

        #region IsCyclic
        public bool IsCyclic
        {
            get { return (bool)GetValue(IsCyclicProperty); }
            set { SetValue(IsCyclicProperty, value); }
        }

        public static readonly DependencyProperty IsCyclicProperty =
            DependencyProperty.Register("IsCyclic", typeof(bool), typeof(Carousel), new PropertyMetadata(true));
        #endregion

        #region AutoPlayDuration
        public TimeSpan AutoPlayDuration
        {
            get { return (TimeSpan)GetValue(AutoPlayDurationProperty); }
            set { SetValue(AutoPlayDurationProperty, value); }
        }

        public static readonly DependencyProperty AutoPlayDurationProperty =
            DependencyProperty.Register("AutoPlayDuration", typeof(TimeSpan), typeof(Carousel), new PropertyMetadata(OnAutoPlayDurationChanged));
        #endregion

        #region CanTurnPageWithKeys
        public bool CanTurnPageWithKeys
        {
            get { return (bool)GetValue(CanTurnPageWithKeysProperty); }
            set { SetValue(CanTurnPageWithKeysProperty, value); }
        }

        public static readonly DependencyProperty CanTurnPageWithKeysProperty =
            DependencyProperty.Register("CanTurnPageWithKeys", typeof(bool), typeof(CarouselPanel), new PropertyMetadata(true));
        #endregion

        #region PageTurnButtonStyle
        public static Style GetPageTurnButtonStyle(Carousel carousel)
        {
            return (Style)carousel.GetValue(PageTurnButtonStyleProperty);
        }

        public static void SetPageTurnButtonStyle(Carousel carousel, Style value)
        {
            carousel.SetValue(PageTurnButtonStyleProperty, value);
        }

        public static readonly DependencyProperty PageTurnButtonStyleProperty =
            DependencyProperty.RegisterAttached("PageTurnButtonStyle", typeof(Style), typeof(Carousel));
        #endregion

        #region PageTurnButtonVisibility
        public DecorationVisibility PageTurnButtonVisibility
        {
            get { return (DecorationVisibility)GetValue(PageTurnButtonVisibilityProperty); }
            set { SetValue(PageTurnButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty PageTurnButtonVisibilityProperty =
            DependencyProperty.Register("PageTurnButtonVisibility", typeof(DecorationVisibility), typeof(Carousel), new PropertyMetadata(DecorationVisibility.VisibleOnHover));
        #endregion

        #region IndicatorPosition
        public IndicatorPosition IndicatorPosition
        {
            get { return (IndicatorPosition)GetValue(IndicatorPositionProperty); }
            set { SetValue(IndicatorPositionProperty, value); }
        }

        public static readonly DependencyProperty IndicatorPositionProperty =
            DependencyProperty.Register("IndicatorPosition", typeof(IndicatorPosition), typeof(Carousel), new PropertyMetadata(IndicatorPosition.RightOrBottom));
        #endregion

        #region IndicatorVisibility
        public DecorationVisibility IndicatorVisibility
        {
            get { return (DecorationVisibility)GetValue(IndicatorVisibilityProperty); }
            set { SetValue(IndicatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty IndicatorVisibilityProperty =
            DependencyProperty.Register("IndicatorVisibility", typeof(DecorationVisibility), typeof(Carousel), new PropertyMetadata(DecorationVisibility.Visible));
        #endregion

        #region IndicatorPaginationStyle
        public static Style GetIndicatorPaginationStyle(Carousel carousel)
        {
            return (Style)carousel.GetValue(IndicatorPaginationStyleProperty);
        }

        public static void SetIndicatorPaginationStyle(Carousel carousel, Style value)
        {
            carousel.SetValue(IndicatorPaginationStyleProperty, value);
        }

        public static readonly DependencyProperty IndicatorPaginationStyleProperty =
            DependencyProperty.RegisterAttached("IndicatorPaginationStyle", typeof(Style), typeof(Carousel));
        #endregion

        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey PageTurnButtonStyleKey { get; }
            = new ComponentResourceKey(typeof(Carousel), nameof(PageTurnButtonStyleKey));

        public static ComponentResourceKey IndicatorPaginationStyleKey { get; }
            = new ComponentResourceKey(typeof(Carousel), nameof(IndicatorPaginationStyleKey));
        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            UpdateAutoPlayTimer();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    if (Orientation == Orientation.Horizontal
                        && CanTurnPageWithKeys)
                    {
                        PageUp();
                        e.Handled = true;
                    }
                    break;
                case Key.Right:
                    if (Orientation == Orientation.Horizontal
                        && CanTurnPageWithKeys)
                    {
                        PageDown();
                        e.Handled = true;
                    }
                    break;
                case Key.Up:
                    if (Orientation == Orientation.Vertical
                        && CanTurnPageWithKeys)
                    {
                        PageUp();
                        e.Handled = true;
                    }
                    break;
                case Key.Down:
                    if (Orientation == Orientation.Vertical
                        && CanTurnPageWithKeys)
                    {
                        PageDown();
                        e.Handled = true;
                    }
                    break;
            }
        }
        #endregion

        #region Methods

        #region PageUp
        public void PageUp()
        {
            SetCurrentValue(CurrentIndexProperty, CurrentIndex - 1);
        }
        #endregion

        #region PageDown
        public void PageDown()
        {
            SetCurrentValue(CurrentIndexProperty, CurrentIndex + 1);
        }
        #endregion

        #endregion

        #region Event Handlers
        private static void OnAutoPlayDurationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var carousel = (Carousel)d;
            carousel.UpdateAutoPlayTimer();
        }


        private static void OnCurrentIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs baseValue)
        {
            var carousel = (Carousel)d;
            carousel.OnCurrentIndexChanged();
        }

        private void OnCurrentIndexChanged()
        {
            UpdateAutoPlayTimer();
        }

        private static object OnCurrentIndexCoerceValue(DependencyObject d, object baseValue)
        {
            var carousel = (Carousel)d;
            var currentIndex = (int)baseValue;
            if (currentIndex < 0)
            {
                return carousel.IsCyclic
                    ? Math.Max(0, carousel.Items.Count - 1)
                    : 0;
            }
            if (carousel.IsInitialized && currentIndex > carousel.Items.Count - 1)
            {
                return carousel.IsCyclic
                    ? 0
                    : Math.Max(0, carousel.Items.Count - 1);
            }
            return baseValue;
        }

        private static void OnPageUpCommandExecute(object parameter)
        {
            if (parameter is Carousel carousel)
            {
                carousel.PageUp();
            }
        }

        private static bool OnPageUpCommandCanExecute(object parameter)
        {
            if (parameter is Carousel carousel)
            {
                return carousel.IsCyclic
                   ? true
                   : carousel.CurrentIndex > 0;
            }
            return false;
        }

        private static void OnPageDownCommandExecute(object parameter)
        {
            if (parameter is Carousel carousel)
            {
                carousel.PageDown();
            }
        }

        private static bool OnPageDownCommandCanExecute(object parameter)
        {
            if (parameter is Carousel carousel)
            {
                return carousel.IsCyclic
                   ? true
                   : carousel.CurrentIndex < carousel.Items.Count - 1;
            }
            return false;
        }

        private void OnTimerTicked(object state)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                CurrentIndex++;
            }));
        }

        #endregion

        #region Functions
        private void UpdateAutoPlayTimer()
        {
            if (!IsInitialized)
            {
                return;
            }

            if (_timer == null)
            {
                _timer = new Timer(OnTimerTicked);
            }
            if (AutoPlayDuration.TotalMilliseconds == 0)
            {
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
            }
            else
            {
                _timer.Change(AutoPlayDuration, TimeSpan.FromMilliseconds(-1));
            }
        }

        #endregion
    }
}
