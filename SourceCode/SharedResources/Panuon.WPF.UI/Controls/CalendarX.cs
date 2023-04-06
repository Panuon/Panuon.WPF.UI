using Panuon.WPF;
using Panuon.WPF.UI.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [DefaultEvent(nameof(SelectedDateChanged))]
    public class CalendarX
        : Control
    {
        #region Fields
        private const string CalendarXDayPresenterTemplateName = "PART_CalendarXDayPresenter";
        private const string CalendarXMonthPresenterTemplateName = "PART_CalendarXMonthPresenter";
        private const string CalendarXYearPresenterTemplateName = "PART_CalendarXYearPresenter";
        private const string WeekNameUniformGridTemplateName = "PART_WeekNameUniformGrid";
        private const string BackwardButtonTemplateName = "PART_BackwardButton";
        private const string PreviousButtonTemplateName = "PART_PreviousButton";
        private const string NextButtonTemplateName = "PART_NextButton";
        private const string ForwardButtonTemplateName = "PART_ForwardButton";
        private const string YearButtonTemplateName = "PART_YearButton";
        private const string YearPeriodTextBlockTemplateName = "PART_YearPeriodTextBlock";
        private const string MonthButtonTemplateName = "PART_MonthButton";

        private CalendarXItemPresenter _dayPresenter;
        private CalendarXItemPresenter _monthPresenter;
        private CalendarXItemPresenter _yearPresenter;
        private UniformGrid _weekNameUniformGrid;
        private RepeatButton _backwardButton;
        private RepeatButton _previousButton;
        private RepeatButton _nextButton;
        private RepeatButton _forwardButton;
        private Button _yearButton;
        private TextBlock _yearPeriodTextBlock;
        private Button _monthButton;

        private int _dayRows = 6;
        private int _dayColumns = 7;
        private int _monthRows = 4;
        private int _monthColumns = 3;
        private int _yearRows = 5;
        private int _yearColumns = 3;
        #endregion

        #region Ctor
        static CalendarX()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarX), new FrameworkPropertyMetadata(typeof(CalendarX)));
        }
        #endregion

        #region Events

        #region SelectedDateChanged
        public event SelectedValueChangedRoutedEventHandler<DateTime> SelectedDateChanged
        {
            add { AddHandler(SelectedDateChangedEvent, value); }
            remove { RemoveHandler(SelectedDateChangedEvent, value); }
        }

        public static readonly RoutedEvent SelectedDateChangedEvent =
            EventManager.RegisterRoutedEvent("SelectedDateChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedRoutedEventHandler<DateTime>), typeof(CalendarX));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {

            _dayPresenter = GetTemplateChild(CalendarXDayPresenterTemplateName) as CalendarXItemPresenter;
            _dayPresenter.Selected += DayPresenter_Selected;
            _dayPresenter.Init(_dayRows, _dayColumns);

            _monthPresenter = GetTemplateChild(CalendarXMonthPresenterTemplateName) as CalendarXItemPresenter;
            _monthPresenter.Selected += MonthPresenter_Selected;
            _monthPresenter.Init(_monthRows, _monthColumns);

            _yearPresenter = GetTemplateChild(CalendarXYearPresenterTemplateName) as CalendarXItemPresenter;
            _yearPresenter.Selected += YearPresenter_Selected;
            _yearPresenter.Init(_yearRows, _yearColumns);

            _weekNameUniformGrid = GetTemplateChild(WeekNameUniformGridTemplateName) as UniformGrid;

            _backwardButton = GetTemplateChild(BackwardButtonTemplateName) as RepeatButton;
            _backwardButton.Click += BackwardButton_Click;

            _previousButton = GetTemplateChild(PreviousButtonTemplateName) as RepeatButton;
            _previousButton.Click += PreviousButton_Click;

            _nextButton = GetTemplateChild(NextButtonTemplateName) as RepeatButton;
            _nextButton.Click += NextButton_Click;

            _forwardButton = GetTemplateChild(ForwardButtonTemplateName) as RepeatButton;
            _forwardButton.Click += ForwardButton_Click;

            _yearButton = GetTemplateChild(YearButtonTemplateName) as Button;
            _yearButton.Click += YearButton_Click;

            _yearPeriodTextBlock = GetTemplateChild(YearPeriodTextBlockTemplateName) as TextBlock;

            _monthButton = GetTemplateChild(MonthButtonTemplateName) as Button;
            _monthButton.Click += MonthButton_Click;

            UpdateDay();
            UpdateMonth();
            UpdateYear();
            InitWeekNameUniformGrid();
            UpdateButtonContent();
            UpdateCurrentPanel();
            
            SetSelectedDate(SelectedDate);
        }
        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey YearMonthButtonStyle { get; } =
           new ComponentResourceKey(typeof(WindowXCaption), nameof(YearMonthButtonStyle));

        public static ComponentResourceKey PageTurnButtonStyle { get; } =
            new ComponentResourceKey(typeof(WindowXCaption), nameof(PageTurnButtonStyle));
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
            DependencyProperty.Register("Culture", typeof(CultureInfo), typeof(CalendarX));
        #endregion

        #region HeaderHeight
        public string HeaderHeight
        {
            get { return (string)GetValue(HeaderHeightProperty); }
            set { SetValue(HeaderHeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.Register("HeaderHeight", typeof(string), typeof(CalendarX), new PropertyMetadata("*"));
        #endregion

        #region HeaderSeparatorVisibility
        public Visibility HeaderSeparatorVisibility
        {
            get { return (Visibility)GetValue(HeaderSeparatorVisibilityProperty); }
            set { SetValue(HeaderSeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty HeaderSeparatorVisibilityProperty =
            DependencyProperty.Register("HeaderSeparatorVisibility", typeof(Visibility), typeof(CalendarX));
        #endregion

        #region HeaderSeparatorBrush
        public Brush HeaderSeparatorBrush
        {
            get { return (Brush)GetValue(HeaderSeparatorBrushProperty); }
            set { SetValue(HeaderSeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty HeaderSeparatorBrushProperty =
            DependencyProperty.Register("HeaderSeparatorBrush", typeof(Brush), typeof(CalendarX));
        #endregion

        #region HeaderSeparatorMargin
        public Thickness HeaderSeparatorMargin
        {
            get { return (Thickness)GetValue(HeaderSeparatorMarginProperty); }
            set { SetValue(HeaderSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty HeaderSeparatorMarginProperty =
            DependencyProperty.Register("HeaderSeparatorMargin", typeof(Thickness), typeof(CalendarX));
        #endregion

        #region HeaderSeparatorThickness
        public double HeaderSeparatorThickness
        {
            get { return (double)GetValue(HeaderSeparatorThicknessProperty); }
            set { SetValue(HeaderSeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty HeaderSeparatorThicknessProperty =
            DependencyProperty.Register("HeaderSeparatorThickness", typeof(double), typeof(CalendarX));
        #endregion

        #region YearMonthButtonStyle
        public static Style GetYearMonthButtonStyle(DependencyObject obj)
        {
            return (Style)obj.GetValue(YearMonthButtonStyleProperty);
        }

        public static void SetYearMonthButtonStyle(DependencyObject obj, Style value)
        {
            obj.SetValue(YearMonthButtonStyleProperty, value);
        }

        public static readonly DependencyProperty YearMonthButtonStyleProperty =
            DependencyProperty.RegisterAttached("YearMonthButtonStyle", typeof(Style), typeof(CalendarX));
        #endregion

        #region PageTurnButtonStyle
        public static Style GetPageTurnButtonStyle(DependencyObject obj)
        {
            return (Style)obj.GetValue(PageTurnButtonStyleProperty);
        }

        public static void SetPageTurnButtonStyle(DependencyObject obj, Style value)
        {
            obj.SetValue(PageTurnButtonStyleProperty, value);
        }

        public static readonly DependencyProperty PageTurnButtonStyleProperty =
            DependencyProperty.RegisterAttached("PageTurnButtonStyle", typeof(Style), typeof(CalendarX));
        #endregion

        #region ItemContainerStyle
        public static Style GetItemContainerStyle(DependencyObject obj)
        {
            return (Style)obj.GetValue(ItemContainerStyleProperty);
        }

        public static void SetItemContainerStyle(DependencyObject obj, Style value)
        {
            obj.SetValue(ItemContainerStyleProperty, value);
        }

        public static readonly DependencyProperty ItemContainerStyleProperty =
            DependencyProperty.RegisterAttached("ItemContainerStyle", typeof(Style), typeof(CalendarX));
        #endregion

        #region FirstDayOfWeek
        public DayOfWeek FirstDayOfWeek
        {
            get { return (DayOfWeek)GetValue(FirstDayOfWeekProperty); }
            set { SetValue(FirstDayOfWeekProperty, value); }
        }

        public static readonly DependencyProperty FirstDayOfWeekProperty =
            DependencyProperty.Register("FirstDayOfWeek", typeof(DayOfWeek), typeof(CalendarX), new PropertyMetadata(DayOfWeek.Sunday));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CalendarX));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(CalendarX));
        #endregion

        #region SelectedDate
        public DateTime SelectedDate
        {
            get { return (DateTime)GetValue(SelectedDateProperty); }
            set { SetValue(SelectedDateProperty, value); }
        }

        public static readonly DependencyProperty SelectedDateProperty =
            DependencyProperty.Register("SelectedDate", typeof(DateTime), typeof(CalendarX), new PropertyMetadata(DateTime.Now.Date, OnSelectedDateChanged, OnSelectedDateCoerceValue));
        #endregion

        #region SpecialDates
        public IEnumerable<DateTime> SpecialDates
        {
            get { return (IEnumerable<DateTime>)GetValue(SpecialDatesProperty); }
            set { SetValue(SpecialDatesProperty, value); }
        }

        public static readonly DependencyProperty SpecialDatesProperty =
            DependencyProperty.Register("SpecialDates", typeof(IEnumerable<DateTime>), typeof(CalendarX));
        #endregion

        #region Mode
        public CalendarXMode Mode
        {
            get { return (CalendarXMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(CalendarXMode), typeof(CalendarX), new PropertyMetadata(OnModeChanged));

        #endregion

        #region MinDate
        public DateTime MinDate
        {
            get { return (DateTime)GetValue(MinDateProperty); }
            set { SetValue(MinDateProperty, value); }
        }

        public static readonly DependencyProperty MinDateProperty =
            DependencyProperty.Register("MinDate", typeof(DateTime), typeof(CalendarX), new PropertyMetadata(DateTime.MinValue, OnMinDateChanged, OnMinDateCoerceValue));
        #endregion

        #region MaxDate
        public DateTime MaxDate
        {
            get { return (DateTime)GetValue(MaxDateProperty); }
            set { SetValue(MaxDateProperty, value); }
        }

        public static readonly DependencyProperty MaxDateProperty =
            DependencyProperty.Register("MaxDate", typeof(DateTime), typeof(CalendarX), new PropertyMetadata(DateTime.MaxValue, OnMaxDateChanged, OnMaxDateCoerceValue));
        #endregion

        #region Animation
        public CarouselAnimation Animation
        {
            get { return (CarouselAnimation)GetValue(AnimationProperty); }
            set { SetValue(AnimationProperty, value); }
        }

        public static readonly DependencyProperty AnimationProperty =
            DependencyProperty.Register("Animation", typeof(CarouselAnimation), typeof(CalendarX));
        #endregion

        #region AnimationEasing
        public AnimationEasing AnimationEasing
        {
            get { return (AnimationEasing)GetValue(AnimationEasingProperty); }
            set { SetValue(AnimationEasingProperty, value); }
        }

        public static readonly DependencyProperty AnimationEasingProperty =
            DependencyProperty.Register("AnimationEasing", typeof(AnimationEasing), typeof(CalendarX));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(CalendarX), new PropertyMetadata(TimeSpan.FromSeconds(0.5)));
        #endregion

        #region YearStringFormat
        public string YearStringFormat
        {
            get { return (string)GetValue(YearStringFormatProperty); }
            set { SetValue(YearStringFormatProperty, value); }
        }

        public static readonly DependencyProperty YearStringFormatProperty =
            DependencyProperty.Register("YearStringFormat", typeof(string), typeof(CalendarX), new PropertyMetadata("0000"));
        #endregion

        #region Items Property

        #region ItemsForeground
        public Brush ItemsForeground
        {
            get { return (Brush)GetValue(ItemsForegroundProperty); }
            set { SetValue(ItemsForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.Register("ItemsForeground", typeof(Brush), typeof(CalendarX));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(CalendarX), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(CalendarX));
        #endregion

        #region ItemsBorderThickness
        public Thickness? ItemsBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness?), typeof(CalendarX));
        #endregion

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(CalendarX));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(CalendarX));
        #endregion

        #region ItemsHoverBackground
        public Brush ItemsHoverBackground
        {
            get { return (Brush)GetValue(ItemsHoverBackgroundProperty); }
            set { SetValue(ItemsHoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.Register("ItemsHoverBackground", typeof(Brush), typeof(CalendarX));
        #endregion

        #region ItemsHoverForeground
        public Brush ItemsHoverForeground
        {
            get { return (Brush)GetValue(ItemsHoverForegroundProperty); }
            set { SetValue(ItemsHoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.Register("ItemsHoverForeground", typeof(Brush), typeof(CalendarX));
        #endregion

        #region ItemsHoverBorderBrush
        public Brush ItemsHoverBorderBrush
        {
            get { return (Brush)GetValue(ItemsHoverBorderBrushProperty); }
            set { SetValue(ItemsHoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.Register("ItemsHoverBorderBrush", typeof(Brush), typeof(CalendarX));
        #endregion

        #region ItemsHoverShadowColor
        public Color? ItemsHoverShadowColor
        {
            get { return (Color?)GetValue(ItemsHoverShadowColorProperty); }
            set { SetValue(ItemsHoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverShadowColorProperty =
            DependencyProperty.Register("ItemsHoverShadowColor", typeof(Color?), typeof(CalendarX));
        #endregion

        #region ItemsCheckedBackground
        public Brush ItemsCheckedBackground
        {
            get { return (Brush)GetValue(ItemsCheckedBackgroundProperty); }
            set { SetValue(ItemsCheckedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBackgroundProperty =
            DependencyProperty.Register("ItemsCheckedBackground", typeof(Brush), typeof(CalendarX));
        #endregion

        #region ItemsCheckedForeground
        public Brush ItemsCheckedForeground
        {
            get { return (Brush)GetValue(ItemsCheckedForegroundProperty); }
            set { SetValue(ItemsCheckedForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedForegroundProperty =
            DependencyProperty.Register("ItemsCheckedForeground", typeof(Brush), typeof(CalendarX));
        #endregion

        #region ItemsCheckedBorderBrush
        public Brush ItemsCheckedBorderBrush
        {
            get { return (Brush)GetValue(ItemsCheckedBorderBrushProperty); }
            set { SetValue(ItemsCheckedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBorderBrushProperty =
            DependencyProperty.Register("ItemsCheckedBorderBrush", typeof(Brush), typeof(CalendarX));
        #endregion

        #region ItemsCheckedBorderThickness
        public Thickness? ItemsCheckedBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsCheckedBorderThicknessProperty); }
            set { SetValue(ItemsCheckedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedBorderThicknessProperty =
            DependencyProperty.Register("ItemsCheckedBorderThickness", typeof(Thickness?), typeof(CalendarX));
        #endregion

        #region ItemsCheckedShadowColor
        public Color? ItemsCheckedShadowColor
        {
            get { return (Color?)GetValue(ItemsCheckedShadowColorProperty); }
            set { SetValue(ItemsCheckedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsCheckedShadowColorProperty =
            DependencyProperty.Register("ItemsCheckedShadowColor", typeof(Color?), typeof(CalendarX));
        #endregion

        #region ItemsSpecialDayHighlightTemplate
        public DataTemplate ItemsSpecialDayHighlightTemplate
        {
            get { return (DataTemplate)GetValue(ItemsSpecialDayHighlightTemplateProperty); }
            set { SetValue(ItemsSpecialDayHighlightTemplateProperty, value); }
        }

        public static readonly DependencyProperty ItemsSpecialDayHighlightTemplateProperty =
            DependencyProperty.Register("ItemsSpecialDayHighlightTemplate", typeof(DataTemplate), typeof(CalendarX));
        #endregion

        #endregion

        #endregion

        #region Internal Properties

        #region CurrentPanel
        internal int CurrentPanel
        {
            get { return (int)GetValue(CurrentPanelProperty); }
            set { SetValue(CurrentPanelProperty, value); }
        }

        internal static readonly DependencyProperty CurrentPanelProperty =
            DependencyProperty.Register("CurrentPanel", typeof(int), typeof(CalendarX));
        #endregion

        #endregion

        #region Methods
        #endregion

        #region Internal Methods
        internal CultureInfo GetCulture()
        {
            return Culture ?? Thread.CurrentThread.CurrentCulture;
        }
        #endregion

        #region Event Handlers
        private static object OnMinDateCoerceValue(DependencyObject d, object baseValue)
        {
            var calendarX = (CalendarX)d;
            var minDate = (DateTime)baseValue;
            minDate = minDate.Date;
            if (minDate > calendarX.MaxDate)
            {
                return calendarX.MaxDate;
            }
            return minDate;
        }

        private static void OnMinDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var calendarX = (CalendarX)d;
            calendarX.CoerceValue(MaxDateProperty);
            calendarX.CoerceValue(SelectedDateProperty);
            calendarX.UpdateDay();
            calendarX.UpdateMonth();
            calendarX.UpdateYear();
        }

        private static object OnMaxDateCoerceValue(DependencyObject d, object baseValue)
        {
            var calendarX = (CalendarX)d;
            var maxDate = (DateTime)baseValue;
            maxDate = maxDate.Date;
            if (maxDate < calendarX.MinDate)
            {
                return calendarX.MinDate;
            }
            return maxDate;
        }

        private static void OnMaxDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var calendarX = (CalendarX)d;
            calendarX.CoerceValue(MaxDateProperty);
            calendarX.CoerceValue(SelectedDateProperty);
            calendarX.UpdateDay();
            calendarX.UpdateMonth();
            calendarX.UpdateYear();
        }

        private static void OnSelectedDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var calendar = (CalendarX)d;
            calendar.OnSelectedDateChanged();
            calendar.RaiseEvent(new SelectedValueChangedRoutedEventArgs<DateTime>(SelectedDateChangedEvent, (DateTime)e.OldValue, (DateTime)e.NewValue));
        }

        private static object OnSelectedDateCoerceValue(DependencyObject d, object baseValue)
        {
            var calendarX = (CalendarX)d;
            var selectedDate = (DateTime)baseValue;
            selectedDate = selectedDate.Date;
            var maxDate = calendarX.MaxDate.Date;
            var minDate = calendarX.MinDate.Date;

            if (selectedDate > maxDate)
            {
                return maxDate;
            }
            if (selectedDate < minDate)
            {
                return minDate;
            }
            return selectedDate;
        }

        private static void OnModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var calendar = (CalendarX)d;
            if (calendar._dayPresenter != null)
            {
                calendar.UpdateCurrentPanel();
                calendar.SetSelectedDate(calendar.SelectedDate);
            }
        }

        private void DayPresenter_Selected(object sender, RoutedEventArgs e)
        {
            var item = e.OriginalSource as CalendarXItem;
            var day = (int?)item.Tag;
            if (day != null)
            {
                var selectedDate = SelectedDate;
                var firsDayOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);
                SetSelectedDate(firsDayOfMonth.AddDays((int)day));
            }
        }

        private void MonthPresenter_Selected(object sender, RoutedEventArgs e)
        {
            var item = e.OriginalSource as CalendarXItem;
            var month = (int)item.Tag;
            var selectedDate = SelectedDate;
            SetSelectedDate(new DateTime(selectedDate.Year, month, selectedDate.Day));
            switch (Mode)
            {
                case CalendarXMode.Date:
                    SetCurrentValue(CurrentPanelProperty, 0);
                    break;
            }
        }

        private void YearPresenter_Selected(object sender, RoutedEventArgs e)
        {
            var item = e.OriginalSource as CalendarXItem;
            var year = (int)item.Tag;
            var selectedDate = SelectedDate;
            SetSelectedDate(new DateTime(year, selectedDate.Month, selectedDate.Day));
            switch (Mode)
            {
                case CalendarXMode.Month:
                case CalendarXMode.Date:
                    SetCurrentValue(CurrentPanelProperty, 1);
                    break;
            }
        }

        private void BackwardButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedDate = SelectedDate;
            var minDate = DateTime.MinValue;
            try
            {
                switch (CurrentPanel)
                {
                    case 0:
                        selectedDate = selectedDate.AddYears(-1);
                        break;
                    case 1:
                        selectedDate = selectedDate.AddYears(-10);
                        break;
                    case 2:
                        selectedDate = selectedDate.AddYears(-_yearRows * _yearColumns);
                        break;
                }

                if (selectedDate >= minDate)
                {
                    SetSelectedDate(selectedDate);
                }
            }
            catch
            {
                SetSelectedDate(minDate);
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedDate = SelectedDate;
            var minDate = DateTime.MinValue;
            try
            {
                switch (CurrentPanel)
                {
                    case 0:
                        selectedDate = selectedDate.AddMonths(-1);
                        break;
                    case 1:
                        selectedDate = selectedDate.AddYears(-1);
                        break;
                }

                if (selectedDate >= minDate)
                {
                    SetSelectedDate(selectedDate);
                }
            }
            catch
            {
                SetSelectedDate(minDate);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedDate = SelectedDate;
            try
            {
                switch (CurrentPanel)

                {
                    case 0:
                        selectedDate = selectedDate.AddMonths(1);
                        break;
                    case 1:
                        selectedDate = selectedDate.AddYears(1);
                        break;
                }

                SetSelectedDate(selectedDate);
            }
            catch
            {
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedDate = SelectedDate;
            try
            {
                switch (CurrentPanel)

                {
                    case 0:
                        selectedDate = selectedDate.AddYears(1);
                        break;
                    case 1:
                        selectedDate = selectedDate.AddYears(10);
                        break;
                    case 2:
                        selectedDate = selectedDate.AddYears(_yearRows * _yearColumns);
                        break;
                }

                SetSelectedDate(selectedDate);
            }
            catch
            {
            }
        }

        private void MonthButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentValue(CurrentPanelProperty, 1);
        }

        private void YearButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentValue(CurrentPanelProperty, 2);
        }

        #endregion

        #region Functions
        private void OnSelectedDateChanged()
        {
            if (_yearPresenter == null
                || _monthPresenter == null
                || _dayPresenter == null)
            {
                return;
            }

            UpdateButtonContent();
            UpdateDay();
            UpdateMonth();
            UpdateYear();

        }

        private DateTimeFormatInfo GetDateTimeFormat()
        {
            var culture = GetCulture();
            return culture.DateTimeFormat;
        }

        private int GetIndexOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return 7;
                default:
                    return (int)dayOfWeek;
            }
        }

        private void UpdateButtonContent()
        {
            var dateTimeFormat = GetDateTimeFormat();
            var selectedDate = SelectedDate.Date;

            _yearButton.Content = selectedDate.Year;
            _monthButton.Content = dateTimeFormat.GetMonthName(selectedDate.Month);
        }

        private void UpdateYear()
        {
            if (_yearPresenter == null)
            {
                return;
            }

            var selectedDate = SelectedDate;
            var minDate = MinDate.Date;
            var maxDate = MaxDate.Date;

            var startYear = Math.Max(1, selectedDate.Year - (_yearRows * _yearColumns - 1) / 2);
            var currentYear = startYear;

            for (int i = 0; i < _yearRows * _yearColumns; i++)
            {
                var item = _yearPresenter.GetItem(i);

                item.SetCurrentValue(CalendarXItem.CanSelectProperty, currentYear >= minDate.Year
                        || currentYear <= maxDate.Year);
                item.SetCurrentValue(CalendarXItem.IsCheckedProperty, selectedDate.Year == currentYear);
                item.SetCurrentValue(CalendarXItem.TagProperty, currentYear);
                item.SetCurrentValue(CalendarXItem.ContentProperty, currentYear.ToString(YearStringFormat));
                item.SetCurrentValue(CalendarXItem.DateTimeProperty, new DateTime(currentYear, 1, 1));
                currentYear++;
            }

            _yearPeriodTextBlock.Text = $"{startYear.ToString(YearStringFormat)}-{(currentYear - 1).ToString(YearStringFormat)}";
        }

        private void UpdateMonth()
        {
            if (_monthPresenter == null)
            {
                return;
            }

            var dateTimeFormat = GetDateTimeFormat();
            var selectedDate = SelectedDate.Date;
            var minDate = MinDate.Date;
            var maxDate = MaxDate.Date;

            for (int i = 0; i < 12; i++)
            {
                var item = _monthPresenter.GetItem(i);

                item.SetCurrentValue(CalendarXItem.CanSelectProperty, selectedDate.Year != minDate.Year
                    || selectedDate.Year != maxDate.Year
                    || (i >= minDate.Month && i <= maxDate.Month));

                item.SetCurrentValue(CalendarXItem.IsCheckedProperty, selectedDate.Month == (i + 1));
                item.SetCurrentValue(CalendarXItem.TagProperty, i + 1);
                item.SetCurrentValue(CalendarXItem.ContentProperty, dateTimeFormat.GetMonthName(i + 1));
                item.SetCurrentValue(CalendarXItem.DateTimeProperty, new DateTime(selectedDate.Year, i + 1, 1));
            }
        }

        private void UpdateDay()
        {
            if (_dayPresenter == null)
            {
                return;
            }
            var selectedDate = SelectedDate.Date;
            var minDate = MinDate.Date;
            var maxDate = MaxDate.Date;
            var firsDayOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            var dayInMonth = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);

            var prevDays = GetIndexOfWeek(firsDayOfMonth.DayOfWeek) - GetIndexOfWeek(FirstDayOfWeek) + GetIndexOfWeek(FirstDayOfWeek);
            if (prevDays > 0)
            {
                prevDays *= -1;
            }
            else if (prevDays == 0)
            {
                prevDays = -7;
            }
            for (int i = 0; i < _dayRows * _dayColumns; i++)
            {
                DateTime? currentDate = null;
                if (prevDays >= 0
                    || firsDayOfMonth >= minDate.AddDays(-prevDays))
                {
                    currentDate = firsDayOfMonth.AddDays(prevDays);
                }
                var item = _dayPresenter.GetItem(i);
                item.SetCurrentValue(CalendarXItem.CanSelectProperty, currentDate == null || ((((DateTime)currentDate).Year > minDate.Year || (((DateTime)currentDate).Year == minDate.Year && (((DateTime)currentDate).Month > minDate.Month || (((DateTime)currentDate).Month == minDate.Month && ((DateTime)currentDate).Day >= minDate.Day))))
                    && (((DateTime)currentDate).Year < maxDate.Year || (((DateTime)currentDate).Year == maxDate.Year && (((DateTime)currentDate).Month < maxDate.Month || (((DateTime)currentDate).Month == maxDate.Month && ((DateTime)currentDate).Day <= maxDate.Day))))));

                item.SetCurrentValue(CalendarXItem.IsTodayProperty, currentDate != null
                    && DateTime.Now.Date.Equals(currentDate));

                item.SetCurrentValue(CalendarXItem.IsSpecialDayProperty, SpecialDates != null
                    && currentDate != null
                    && SpecialDates.Any(x => x.Date.Equals(currentDate)));
                item.SetCurrentValue(CalendarXItem.IsOutsideThisMonthProperty, prevDays < 0 || prevDays >= dayInMonth);
                item.SetCurrentValue(CalendarXItem.IsCheckedProperty, item.CanSelect && currentDate != null && selectedDate.Equals(currentDate));
                item.SetCurrentValue(CalendarXItem.TagProperty, currentDate == null ? (int?)null : prevDays);
                item.SetCurrentValue(CalendarXItem.ContentProperty, currentDate == null ? null : ((DateTime)currentDate).Day.ToString());
                item.SetCurrentValue(CalendarXItem.DateTimeProperty, currentDate);
                prevDays++;
            }
        }

        private void InitWeekNameUniformGrid()
        {
            var dateTimeFormat = GetDateTimeFormat();
            var daysOfWeek = FirstDayOfWeek;
            for (int i = 0; i < 7; i++)
            {
                if ((int)daysOfWeek > 6)
                {
                    daysOfWeek -= 7;
                }
                var textBlock = new TextBlock()
                {
                    Text = dateTimeFormat.GetShortestDayName(daysOfWeek),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                };
                _weekNameUniformGrid.Children.Add(textBlock);
                daysOfWeek++;
            }
        }

        private void UpdateCurrentPanel()
        {
            switch (Mode)
            {
                case CalendarXMode.Date:
                    SetCurrentValue(CurrentPanelProperty, 0);
                    break;
                case CalendarXMode.Month:
                    SetCurrentValue(CurrentPanelProperty, 1);
                    break;
                case CalendarXMode.Year:
                    SetCurrentValue(CurrentPanelProperty, 2);
                    break;
            }
        }

        private void SetSelectedDate(DateTime dateTime)
        {
            switch (Mode)
            {
                case CalendarXMode.Year:
                    if (dateTime.Month != 1
                        || dateTime.Day != 1)
                    {
                        dateTime = new DateTime(dateTime.Year, 1, 1);
                    }
                    break;
                case CalendarXMode.Month:
                    if (dateTime.Day != 1)
                    {
                        dateTime = new DateTime(dateTime.Year, dateTime.Month, 1);
                    }
                    break;
            }
            SetCurrentValue(SelectedDateProperty, dateTime);

            if (ParentDateTimePicker != null
                && ParentDateTimePicker.SelectedDateTime == null)
            {
                RaiseEvent(new SelectedValueChangedRoutedEventArgs<DateTime>(SelectedDateChangedEvent, dateTime, dateTime));
            }
        }
        #endregion
    }
}
