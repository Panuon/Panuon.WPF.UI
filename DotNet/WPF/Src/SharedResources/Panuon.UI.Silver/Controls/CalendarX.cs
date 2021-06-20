using Panuon.UI.Silver.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    class CalendarX : Control
    {
        #region Fields
        private bool _isInternalSet;
        #endregion

        #region Ctor
        static CalendarX()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarX), new FrameworkPropertyMetadata(typeof(CalendarX)));
        }

        public CalendarX()
        {
            DayPresenter = new CalendarXDayPresenter(this);
        }
        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            RefreshDayPresenter();
        }
        #endregion

        #region Properties

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
            DependencyProperty.Register("ShadowColor", typeof(Color?), typeof(CalendarX));
        #endregion

        #region CalendarXItemStyle
        public Style CalendarXItemStyle
        {
            get { return (Style)GetValue(CalendarXItemStyleProperty); }
            set { SetValue(CalendarXItemStyleProperty, value); }
        }

        public static readonly DependencyProperty CalendarXItemStyleProperty =
            DependencyProperty.Register("CalendarXItemStyle", typeof(Style), typeof(CalendarX));
        #endregion

        #region HeaderHeight
        public double HeaderHeight
        {
            get { return (double)GetValue(HeaderHeightProperty); }
            set { SetValue(HeaderHeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.Register("HeaderHeight", typeof(double), typeof(CalendarX), new PropertyMetadata(40d));
        #endregion

        #region DisplayDate
        public DateTime DisplayDate
        {
            get { return (DateTime)GetValue(DisplayDateProperty); }
            set { SetValue(DisplayDateProperty, value); }
        }

        public static readonly DependencyProperty DisplayDateProperty =
            DependencyProperty.Register("DisplayDate", typeof(DateTime), typeof(CalendarX), new PropertyMetadata(DateTime.Now.Date));
        #endregion

        #region SelectedDate
        public DateTime? SelectedDate
        {
            get { return (DateTime?)GetValue(SelectedDateProperty); }
            set { SetValue(SelectedDateProperty, value); }
        }

        public static readonly DependencyProperty SelectedDateProperty =
            DependencyProperty.Register("SelectedDate", typeof(DateTime?), typeof(CalendarX));
        #endregion

        #region SelectedDates
        public SelectedDatesCollection SelectedDates
        {
            get { return (SelectedDatesCollection)GetValue(SelectedDatesProperty); }
            set { SetValue(SelectedDatesProperty, value); }
        }

        public static readonly DependencyProperty SelectedDatesProperty =
            DependencyProperty.Register("SelectedDates", typeof(SelectedDatesCollection), typeof(CalendarX), new PropertyMetadata(OnSelectedDatesChanged));
        #endregion

        #region BlackoutDates
        public IEnumerable<CalendarDateRange> BlackoutDates
        {
            get { return (IEnumerable<CalendarDateRange>)GetValue(BlackoutDatesProperty); }
            set { SetValue(BlackoutDatesProperty, value); }
        }

        public static readonly DependencyProperty BlackoutDatesProperty =
            DependencyProperty.Register("BlackoutDates", typeof(IEnumerable<CalendarDateRange>), typeof(CalendarX));
        #endregion

        #region SpecialDays
        public IEnumerable<CalendarXSpecialDay> SpecialDays
        {
            get { return (IEnumerable<CalendarXSpecialDay>)GetValue(SpecialDaysProperty); }
            set { SetValue(SpecialDaysProperty, value); }
        }

        public static readonly DependencyProperty SpecialDaysProperty =
            DependencyProperty.Register("SpecialDays", typeof(IEnumerable<CalendarXSpecialDay>), typeof(CalendarX), new PropertyMetadata(OnSpecialDaysChanged));
        #endregion

        #region MinDate
        public DateTime? MinDate
        {
            get { return (DateTime?)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(DateTime?), typeof(CalendarX));
        #endregion

        #region MaxDate
        public DateTime? MaxDate
        {
            get { return (DateTime?)GetValue(MaxDateProperty); }
            set { SetValue(MaxDateProperty, value); }
        }

        public static readonly DependencyProperty MaxDateProperty =
            DependencyProperty.Register("MaxDate", typeof(DateTime?), typeof(CalendarX));
        #endregion

        #region DisplayMode
        public CalendarMode DisplayMode
        {
            get { return (CalendarMode)GetValue(DisplayModeProperty); }
            set { SetValue(DisplayModeProperty, value); }
        }

        public static readonly DependencyProperty DisplayModeProperty =
            DependencyProperty.Register("DisplayMode", typeof(CalendarMode), typeof(CalendarX));
        #endregion

        #region SelectionMode
        public CalendarSelectionMode SelectionMode
        {
            get { return (CalendarSelectionMode)GetValue(SelectionModeProperty); }
            set { SetValue(SelectionModeProperty, value); }
        }

        public static readonly DependencyProperty SelectionModeProperty =
            DependencyProperty.Register("SelectionMode", typeof(CalendarSelectionMode), typeof(CalendarX));
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

        #region IsTodayHighlighted
        public bool IsTodayHighlighted
        {
            get { return (bool)GetValue(IsTodayHighlightedProperty); }
            set { SetValue(IsTodayHighlightedProperty, value); }
        }

        public static readonly DependencyProperty IsTodayHighlightedProperty =
            DependencyProperty.Register("IsTodayHighlighted", typeof(bool), typeof(CalendarX), new PropertyMetadata(true, OnIsTodayHighlightedChanged));
        #endregion

        #region CultureInfo
        [TypeConverter(typeof(CultureInfoConverter))]
        public CultureInfo CultureInfo
        {
            get { return (CultureInfo)GetValue(CultureInfoProperty); }
            set { SetValue(CultureInfoProperty, value); }
        }

        public static readonly DependencyProperty CultureInfoProperty =
            DependencyProperty.Register("CultureInfo", typeof(CultureInfo), typeof(CalendarX));
        #endregion

        #endregion

        #region Internal Properties

        #region DayPresenter
        internal CalendarXDayPresenter DayPresenter
        {
            get { return (CalendarXDayPresenter)GetValue(DayPresenterProperty); }
            set { SetValue(DayPresenterProperty, value); }
        }

        internal static readonly DependencyProperty DayPresenterProperty =
            DependencyProperty.Register("DayPresenter", typeof(CalendarXDayPresenter), typeof(CalendarX));
        #endregion

        #endregion

        #region Methods
        public bool AddSelectedDate(DateTime currentDate)
        {
            SetCurrentValue(SelectedDateProperty, currentDate);

            _isInternalSet = true;
            if (SelectedDates == null)
            {
                var selectedDates = new SelectedDatesCollection(this);
                selectedDates.Add(currentDate);
                SetCurrentValue(SelectedDatesProperty, selectedDates);
            }
            else
            {
                SelectedDates.Clear();
                SelectedDates.Add(currentDate);
            }
            _isInternalSet = false;

            return true;
        }
        #endregion

        #region Internal Methods
        internal CultureInfo GetCultureInfo()
        {
            return CultureInfo ?? CultureInfo.CurrentUICulture;
        }
        #endregion

        #region Functions
        private void RefreshDayPresenter()
        {
            DayPresenter.Update(DisplayDate.Year, DisplayDate.Month, SelectedDates, BlackoutDates, SpecialDays);
        }
        #endregion

        #region Event Handlers
        private static void OnSpecialDaysChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var calendarX = (CalendarX)d;
            if (calendarX.IsInitialized)
            {
                calendarX.RefreshDayPresenter();
            }
        }

        private static void OnIsTodayHighlightedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var calendarX = (CalendarX)d;
            if (calendarX.IsInitialized)
            {
                calendarX.RefreshDayPresenter();
            }
        }

        private static void OnSelectedDatesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }
        #endregion
    }
}
