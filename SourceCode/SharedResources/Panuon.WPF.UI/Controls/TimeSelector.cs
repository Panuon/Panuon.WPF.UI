using Panuon.WPF;
using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [StyleTypedProperty(Property = nameof(ItemContainerStyle), StyleTargetType = typeof(TimeSelector))]
    public class TimeSelector
        : Control
    {
        #region Fields
        private const string TimeSelectorHourPresenterTemplateName = "PART_TimeSelectorHourPresenter";
        private const string TimeSelectorMinutePresenterTemplateName = "PART_TimeSelectorMinutePresenter";
        private const string TimeSelectorSecondPresenterTemplateName = "PART_TimeSelectorSecondPresenter";
        private const string TimeNameUniformGridTemplateName = "PART_TimeNameUniformGrid";

        private TimeSelectorItemPresenter _hourPresenter;
        private TimeSelectorItemPresenter _minutePresenter;
        private TimeSelectorItemPresenter _secondPresenter;
        private UniformGrid _timeNameUniformGrid;

        #endregion

        #region Ctor
        static TimeSelector()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TimeSelector), new FrameworkPropertyMetadata(typeof(TimeSelector)));
        }
        #endregion

        #region Events

        #region SelectedTimeChanged
        public event SelectedValueChangedRoutedEventHandler<DateTime> SelectedTimeChanged
        {
            add { AddHandler(SelectedTimeChangedEvent, value); }
            remove { RemoveHandler(SelectedTimeChangedEvent, value); }
        }

        public static readonly RoutedEvent SelectedTimeChangedEvent =
            EventManager.RegisterRoutedEvent("SelectedTimeChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedRoutedEventHandler<DateTime>), typeof(TimeSelector));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _hourPresenter = GetTemplateChild(TimeSelectorHourPresenterTemplateName) as TimeSelectorItemPresenter;
            _hourPresenter.Selected += HourPresenter_Selected;
            _hourPresenter.Init(24);

            _minutePresenter = GetTemplateChild(TimeSelectorMinutePresenterTemplateName) as TimeSelectorItemPresenter;
            _minutePresenter.Selected += MinutePresenter_Selected;
            _minutePresenter.Init(60);

            _secondPresenter = GetTemplateChild(TimeSelectorSecondPresenterTemplateName) as TimeSelectorItemPresenter;
            _secondPresenter.Selected += SecondPresenter_Selected;
            _secondPresenter.Init(60);

            _timeNameUniformGrid = GetTemplateChild(TimeNameUniformGridTemplateName) as UniformGrid;

            InitTimeNameUniformGrid();

            UpdateSecond();
            UpdateMinute();
            UpdateHour();
            UpdateMode();
            
            SetSelectedTime(SelectedTime);
        }
        #endregion

        #region Internal Properties

        internal DateTimePicker ParentDateTimePicker { get; set; }

        #endregion

        #region Properties

        #region Culture
        public CultureInfo Culture
        {
            get { return (CultureInfo)GetValue(CultureProperty); }
            set { SetValue(CultureProperty, value); }
        }

        public static readonly DependencyProperty CultureProperty =
            DependencyProperty.Register("Culture", typeof(CultureInfo), typeof(TimeSelector), new PropertyMetadata(OnCultureChanged));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(TimeSelector));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(TimeSelector));
        #endregion

        #region SelectedTime
        public DateTime SelectedTime
        {
            get { return (DateTime)GetValue(SelectedTimeProperty); }
            set { SetValue(SelectedTimeProperty, value); }
        }

        public static readonly DependencyProperty SelectedTimeProperty =
            DependencyProperty.Register("SelectedTime", typeof(DateTime), typeof(TimeSelector), new PropertyMetadata(new DateTime(), OnSelectedTimeChanged, OnSelectedTimeCoerceValue));

        #endregion

        #region Mode
        public TimeSelectorMode Mode
        {
            get { return (TimeSelectorMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(TimeSelectorMode), typeof(TimeSelector), new PropertyMetadata(OnModeChanged));
        #endregion

        #region MinTime
        public DateTime MinTime
        {
            get { return (DateTime)GetValue(MinTimeProperty); }
            set { SetValue(MinTimeProperty, value); }
        }

        public static readonly DependencyProperty MinTimeProperty =
            DependencyProperty.Register("MinTime", typeof(DateTime), typeof(TimeSelector), new PropertyMetadata(new DateTime(1, 1, 1, 0, 0, 0), OnMinTimeChanged));
        #endregion

        #region MaxTime
        public DateTime MaxTime
        {
            get { return (DateTime)GetValue(MaxTimeProperty); }
            set { SetValue(MaxTimeProperty, value); }
        }

        public static readonly DependencyProperty MaxTimeProperty =
            DependencyProperty.Register("MaxTime", typeof(DateTime), typeof(TimeSelector), new PropertyMetadata(new DateTime(1, 1, 1, 23, 59, 59), OnMaxTimeChanged));
        #endregion

        #region ItemContainerStyle
        public Style ItemContainerStyle
        {
            get { return (Style)GetValue(ItemContainerStyleProperty); }
            set { SetValue(ItemContainerStyleProperty, value); }
        }

        public static readonly DependencyProperty ItemContainerStyleProperty =
            DependencyProperty.Register("ItemContainerStyle", typeof(Style), typeof(TimeSelector));
        #endregion

        #region HeaderHeight
        public string HeaderHeight
        {
            get { return (string)GetValue(HeaderHeightProperty); }
            set { SetValue(HeaderHeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.Register("HeaderHeight", typeof(string), typeof(TimeSelector), new PropertyMetadata("*"));
        #endregion

        #region HeaderSeparatorVisibility
        public Visibility HeaderSeparatorVisibility
        {
            get { return (Visibility)GetValue(HeaderSeparatorVisibilityProperty); }
            set { SetValue(HeaderSeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty HeaderSeparatorVisibilityProperty =
            DependencyProperty.Register("HeaderSeparatorVisibility", typeof(Visibility), typeof(TimeSelector));
        #endregion

        #region HeaderSeparatorBrush
        public Brush HeaderSeparatorBrush
        {
            get { return (Brush)GetValue(HeaderSeparatorBrushProperty); }
            set { SetValue(HeaderSeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty HeaderSeparatorBrushProperty =
            DependencyProperty.Register("HeaderSeparatorBrush", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region HeaderSeparatorMargin
        public Thickness HeaderSeparatorMargin
        {
            get { return (Thickness)GetValue(HeaderSeparatorMarginProperty); }
            set { SetValue(HeaderSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty HeaderSeparatorMarginProperty =
            DependencyProperty.Register("HeaderSeparatorMargin", typeof(Thickness), typeof(TimeSelector));
        #endregion

        #region HeaderSeparatorThickness
        public double HeaderSeparatorThickness
        {
            get { return (double)GetValue(HeaderSeparatorThicknessProperty); }
            set { SetValue(HeaderSeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty HeaderSeparatorThicknessProperty =
            DependencyProperty.Register("HeaderSeparatorThickness", typeof(double), typeof(TimeSelector));
        #endregion

        #region TimeSeparatorVisibility
        public Visibility TimeSeparatorVisibility
        {
            get { return (Visibility)GetValue(TimeSeparatorVisibilityProperty); }
            set { SetValue(TimeSeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty TimeSeparatorVisibilityProperty =
            DependencyProperty.Register("TimeSeparatorVisibility", typeof(Visibility), typeof(TimeSelector));
        #endregion

        #region TimeSeparatorBrush
        public Brush TimeSeparatorBrush
        {
            get { return (Brush)GetValue(TimeSeparatorBrushProperty); }
            set { SetValue(TimeSeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty TimeSeparatorBrushProperty =
            DependencyProperty.Register("TimeSeparatorBrush", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region TimeSeparatorMargin
        public Thickness TimeSeparatorMargin
        {
            get { return (Thickness)GetValue(TimeSeparatorMarginProperty); }
            set { SetValue(TimeSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty TimeSeparatorMarginProperty =
            DependencyProperty.Register("TimeSeparatorMargin", typeof(Thickness), typeof(TimeSelector));
        #endregion

        #region TimeSeparatorThickness
        public double TimeSeparatorThickness
        {
            get { return (double)GetValue(TimeSeparatorThicknessProperty); }
            set { SetValue(TimeSeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty TimeSeparatorThicknessProperty =
            DependencyProperty.Register("TimeSeparatorThickness", typeof(double), typeof(TimeSelector));
        #endregion

        #region HourName
        public string HourName
        {
            get { return (string)GetValue(HourNameProperty); }
            set { SetValue(HourNameProperty, value); }
        }

        public static readonly DependencyProperty HourNameProperty =
            DependencyProperty.Register("HourName", typeof(string), typeof(TimeSelector), new PropertyMetadata(LocalizationUtil.Hour));
        #endregion

        #region MinuteName
        public string MinuteName
        {
            get { return (string)GetValue(MinuteNameProperty); }
            set { SetValue(MinuteNameProperty, value); }
        }

        public static readonly DependencyProperty MinuteNameProperty =
            DependencyProperty.Register("MinuteName", typeof(string), typeof(TimeSelector), new PropertyMetadata(LocalizationUtil.Minute));
        #endregion

        #region SecondName
        public string SecondName
        {
            get { return (string)GetValue(SecondNameProperty); }
            set { SetValue(SecondNameProperty, value); }
        }

        public static readonly DependencyProperty SecondNameProperty =
            DependencyProperty.Register("SecondName", typeof(string), typeof(TimeSelector), new PropertyMetadata(LocalizationUtil.Second));
        #endregion

        #region Items Property

        #region ItemsHeight
        public double ItemsHeight
        {
            get { return (double)GetValue(ItemsHeightProperty); }
            set { SetValue(ItemsHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.Register("ItemsHeight", typeof(double), typeof(TimeSelector), new PropertyMetadata(40d));
        #endregion

        #region ItemsForeground
        public Brush ItemsForeground
        {
            get { return (Brush)GetValue(ItemsForegroundProperty); }
            set { SetValue(ItemsForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.Register("ItemsForeground", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(TimeSelector), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region ItemsBorderThickness
        public Thickness ItemsBorderThickness
        {
            get { return (Thickness)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness), typeof(TimeSelector));
        #endregion

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(TimeSelector));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(TimeSelector));
        #endregion

        #region ItemsHoverBackground
        public Brush ItemsHoverBackground
        {
            get { return (Brush)GetValue(ItemsHoverBackgroundProperty); }
            set { SetValue(ItemsHoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.Register("ItemsHoverBackground", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region ItemsHoverForeground
        public Brush ItemsHoverForeground
        {
            get { return (Brush)GetValue(ItemsHoverForegroundProperty); }
            set { SetValue(ItemsHoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.Register("ItemsHoverForeground", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region ItemsHoverBorderBrush
        public Brush ItemsHoverBorderBrush
        {
            get { return (Brush)GetValue(ItemsHoverBorderBrushProperty); }
            set { SetValue(ItemsHoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.Register("ItemsHoverBorderBrush", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region ItemsHoverShadowColor
        public Color? ItemsHoverShadowColor
        {
            get { return (Color?)GetValue(ItemsHoverShadowColorProperty); }
            set { SetValue(ItemsHoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverShadowColorProperty =
            DependencyProperty.Register("ItemsHoverShadowColor", typeof(Color?), typeof(TimeSelector));
        #endregion

        #region ItemsCheckedBackground
        public Brush ItemsCheckedBackground
        {
            get { return (Brush)GetValue(ItemsCheckedBackgroundProperty); }
            set { SetValue(ItemsCheckedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBackgroundProperty =
            DependencyProperty.Register("ItemsCheckedBackground", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region ItemsCheckedForeground
        public Brush ItemsCheckedForeground
        {
            get { return (Brush)GetValue(ItemsCheckedForegroundProperty); }
            set { SetValue(ItemsCheckedForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedForegroundProperty =
            DependencyProperty.Register("ItemsCheckedForeground", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region ItemsCheckedBorderBrush
        public Brush ItemsCheckedBorderBrush
        {
            get { return (Brush)GetValue(ItemsCheckedBorderBrushProperty); }
            set { SetValue(ItemsCheckedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBorderBrushProperty =
            DependencyProperty.Register("ItemsCheckedBorderBrush", typeof(Brush), typeof(TimeSelector));
        #endregion

        #region ItemsCheckedBorderThickness
        public Thickness? ItemsCheckedBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsCheckedBorderThicknessProperty); }
            set { SetValue(ItemsCheckedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBorderThicknessProperty =
            DependencyProperty.Register("ItemsCheckedBorderThickness", typeof(Thickness?), typeof(TimeSelector));
        #endregion

        #region ItemsCheckedShadowColor
        public Color? ItemsCheckedShadowColor
        {
            get { return (Color?)GetValue(ItemsCheckedShadowColorProperty); }
            set { SetValue(ItemsCheckedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedShadowColorProperty =
            DependencyProperty.Register("ItemsCheckedShadowColor", typeof(Color?), typeof(TimeSelector));
        #endregion

        #endregion

        #endregion

        #region Event Handlers
        private static void OnCultureChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var timeSelector = (TimeSelector)d;
            if(!FrameworkElementUtil.IsDefault(timeSelector, HourNameProperty))
            {
                timeSelector.SetCurrentValue(HourNameProperty, LocalizationUtil.GetHour(timeSelector.Culture));
            }
            if (!FrameworkElementUtil.IsDefault(timeSelector, MinuteNameProperty))
            {
                timeSelector.SetCurrentValue(MinuteNameProperty, LocalizationUtil.GetMinute(timeSelector.Culture));
            }
            if (!FrameworkElementUtil.IsDefault(timeSelector, SecondNameProperty))
            {
                timeSelector.SetCurrentValue(SecondNameProperty, LocalizationUtil.GetSecond(timeSelector.Culture));
            }
        }

        private static void OnMinTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var timeSelector = (TimeSelector)d;
            timeSelector.CoerceValue(MaxTimeProperty);
            timeSelector.CoerceValue(SelectedTimeProperty);

            timeSelector.UpdateSecond();
            timeSelector.UpdateMinute();
            timeSelector.UpdateHour();
        }

        private static void OnMaxTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var timeSelector = (TimeSelector)d;
            timeSelector.CoerceValue(MaxTimeProperty);
            timeSelector.CoerceValue(SelectedTimeProperty);

            timeSelector.UpdateSecond();
            timeSelector.UpdateMinute();
            timeSelector.UpdateHour();
        }

        private static void OnModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var timeSelector = (TimeSelector)d;
            if (timeSelector._hourPresenter != null)
            {
                timeSelector.UpdateMode();
                timeSelector.SetSelectedTime(timeSelector.SelectedTime);
            }
        }

        private static object OnSelectedTimeCoerceValue(DependencyObject d, object baseValue)
        {
            var timeSelector = (TimeSelector)d;
            var maxTime = timeSelector.MaxTime.GetTime();
            var minTime = timeSelector.MinTime.GetTime();
            var selectedTime = ((DateTime)baseValue).GetTime();
            if (selectedTime > maxTime)
            {
                return maxTime;
            }
            else if(selectedTime < minTime)
            {
                return minTime;
            }
            return selectedTime;
        }

        private static void OnSelectedTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var timeSelector = (TimeSelector)d;
            timeSelector.OnSelectedTimeChanged();
            timeSelector.RaiseEvent(new SelectedValueChangedRoutedEventArgs<DateTime>(SelectedTimeChangedEvent, (DateTime)e.OldValue, (DateTime)e.NewValue));
        }

        private void SecondPresenter_Selected(object sender, RoutedEventArgs e)
        {
            var item = e.OriginalSource as TimeSelectorItem;
            var day = item.Time;
            var selectedTime = SelectedTime;
            SetSelectedTime(new DateTime(1, 1, 1, selectedTime.Hour, selectedTime.Minute, day));
        }

        private void MinutePresenter_Selected(object sender, RoutedEventArgs e)
        {
            var item = e.OriginalSource as TimeSelectorItem;
            var minute = item.Time;
            var selectedTime = SelectedTime;
            SetSelectedTime(new DateTime(1, 1, 1, selectedTime.Hour, minute, selectedTime.Second));
        }

        private void HourPresenter_Selected(object sender, RoutedEventArgs e)
        {
            var item = e.OriginalSource as TimeSelectorItem;
            var hour = (int)item.Time;
            var selectedTime = SelectedTime;
            SetSelectedTime(new DateTime(1, 1, 1, hour, selectedTime.Minute, selectedTime.Second));
        }
        #endregion

        #region Functions
        private void OnSelectedTimeChanged()
        {
            if (_hourPresenter == null
                || _minutePresenter == null
                || _secondPresenter == null)
            {
                return;
            }

            UpdateSecond();
            UpdateMinute();
            UpdateHour();
        }

        private void InitTimeNameUniformGrid()
        {
            for (int i = 0; i < 3; i++)
            {
                var textBlock = new TextBlock()
                {
                    Text = i == 0
                        ? HourName
                        : (i == 1 ? MinuteName : SecondName),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                };
                _timeNameUniformGrid.Children.Add(textBlock);
            }
        }

        private void UpdateHour()
        {
            if (_hourPresenter == null)
            {
                return;
            }

            var selectedTime = SelectedTime.GetTime();
            var minTime = MinTime.GetTime();
            var maxDate = MaxTime.GetTime();

            for (int i = 0; i < 24; i++)
            {
                var item = _hourPresenter.GetItem(i);
                item.SetCurrentValue(TimeSelectorItem.CanSelectProperty, (i >= minTime.Hour)
                    && (i <= maxDate.Hour));

                item.SetCurrentValue(TimeSelectorItem.IsCheckedProperty, selectedTime.Hour == i);
                item.SetCurrentValue(TimeSelectorItem.ContentProperty, i.ToString("00"));
                item.SetCurrentValue(TimeSelectorItem.TimeProperty, i);
            }

            _hourPresenter.SetSelectedIndex(selectedTime.Hour);
        }

        private void UpdateMinute()
        {
            if (_minutePresenter == null)
            {
                return;
            }

            var selectedTime = SelectedTime.GetTime();
            var minTime = MinTime.GetTime();
            var maxDate = MaxTime.GetTime();

            for (int i = 0; i < 60; i++)
            {
                var item = _minutePresenter.GetItem(i);
                item.SetCurrentValue(TimeSelectorItem.CanSelectProperty, (selectedTime.Hour > minTime.Hour || (selectedTime.Hour == minTime.Hour && (i >= minTime.Minute)))
                    && (selectedTime.Hour < maxDate.Hour || (selectedTime.Hour == maxDate.Hour && (i <= maxDate.Minute))));

                item.SetCurrentValue(TimeSelectorItem.IsCheckedProperty, selectedTime.Minute == i);
                item.SetCurrentValue(TimeSelectorItem.ContentProperty, i.ToString("00"));
                item.SetCurrentValue(TimeSelectorItem.TimeProperty, i);
            }

            _minutePresenter.SetSelectedIndex(selectedTime.Minute);
        }

        private void UpdateSecond()
        {
            if (_secondPresenter == null)
            {
                return;
            }

            var selectedTime = SelectedTime.GetTime();
            var minTime = MinTime.GetTime();
            var maxDate = MaxTime.GetTime();

            for (int i = 0; i < 60; i++)
            {
                var item = _secondPresenter.GetItem(i);
                item.SetCurrentValue(TimeSelectorItem.CanSelectProperty, (selectedTime.Hour > minTime.Hour || (selectedTime.Hour == minTime.Hour && (selectedTime.Minute > minTime.Minute || (selectedTime.Minute == minTime.Minute && i >= minTime.Second))))
                    && (selectedTime.Hour < maxDate.Hour || (selectedTime.Hour == maxDate.Hour && (selectedTime.Minute < maxDate.Minute || (selectedTime.Minute == maxDate.Minute && i <= maxDate.Second)))));

                item.SetCurrentValue(TimeSelectorItem.IsCheckedProperty, selectedTime.Second == i);
                item.SetCurrentValue(TimeSelectorItem.ContentProperty, i.ToString("00"));
                item.SetCurrentValue(TimeSelectorItem.TimeProperty, i);
            }

            _secondPresenter.SetSelectedIndex(selectedTime.Second);
        }

        private void UpdateMode()
        {
            switch (Mode)
            {
                case TimeSelectorMode.Hour:
                    _hourPresenter.IsEnabled = true;
                    _minutePresenter.IsEnabled = false;
                    _secondPresenter.IsEnabled = false;
                    break;
                case TimeSelectorMode.Minute:
                    _hourPresenter.IsEnabled = true;
                    _minutePresenter.IsEnabled = true;
                    _secondPresenter.IsEnabled = false;
                    break;
                case TimeSelectorMode.Time:
                    _hourPresenter.IsEnabled = true;
                    _minutePresenter.IsEnabled = true;
                    _secondPresenter.IsEnabled = true;
                    break;
            }
        }

        private void SetSelectedTime(DateTime dateTime)
        {
            switch (Mode)
            {
                case TimeSelectorMode.Hour:
                    if (dateTime.Minute != 1
                        || dateTime.Second != 1)
                    {
                        dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0);
                    }
                    break;
                case TimeSelectorMode.Minute:
                    if (dateTime.Second != 1)
                    {
                        dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0);
                    }
                    break;
            }
            SetCurrentValue(SelectedTimeProperty, dateTime);


            if (ParentDateTimePicker != null
                && ParentDateTimePicker.SelectedDateTime == null)
            {
                RaiseEvent(new SelectedValueChangedRoutedEventArgs<DateTime>(SelectedTimeChangedEvent, dateTime, dateTime));
            }
        }
        #endregion
    }
}