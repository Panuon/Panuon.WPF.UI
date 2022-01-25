using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class CalendarX
        : Control
    {
        #region Fields
        private const string CalendarXDayPresenterTemplateName = "PART_CalendarXDayPresenter";

        private const string CalendarXMonthPresenterTemplateName = "PART_CalendarXMonthPresenter";

        private const string CalendarXYearPresenterTemplateName = "PART_CalendarXYearPresenter";

        private CalendarXItemPresenter _dayPresenter;

        private CalendarXItemPresenter _monthPresenter;

        private CalendarXItemPresenter _yearPresenter;

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

        #region Overrides
        public override void OnApplyTemplate()
        {
            _dayPresenter = GetTemplateChild(CalendarXDayPresenterTemplateName) as CalendarXItemPresenter;
            _dayPresenter.Init(_dayRows, _dayColumns);
            UpdateDay();

            _monthPresenter = GetTemplateChild(CalendarXMonthPresenterTemplateName) as CalendarXItemPresenter;
            _monthPresenter.Init(_monthRows, _monthColumns);
            UpdateMonth();

            _yearPresenter = GetTemplateChild(CalendarXYearPresenterTemplateName) as CalendarXItemPresenter;
            _yearPresenter.Init(_yearRows, _yearColumns);
            UpdateYear();
        }
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
            DependencyProperty.Register("SelectedDate", typeof(DateTime), typeof(CalendarX), new PropertyMetadata(OnSelectedDateTimeChanged));
        #endregion

        #endregion

        #region Methods
        #endregion

        #region Event Handlers
        private static void OnSelectedDateTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var calendar = (CalendarX)d;
            calendar.OnSelectedDateTimeChanged();
        }
        #endregion

        #region Functions
        private void OnSelectedDateTimeChanged()
        {
            if (_yearPresenter == null
                || _monthPresenter == null
                || _dayPresenter == null)
            {
                return;
            }
        }

        private void UpdateYear()
        {
            var selectedDate = SelectedDate;

            var currentYear = Math.Max(0, selectedDate.Year - (_yearRows * _yearColumns - 1) / 2);
            for (int i = 0; i < _yearRows; i++)
            {
                for (int j = 0; j < _yearColumns; j++)
                {
                    var item = _yearPresenter.GetItem(i, j);
                    item.IsChecked = selectedDate.Year == currentYear;
                    item.Tag = currentYear;
                    item.Content = currentYear.ToString("0000");
                    currentYear++;
                }
            }
        }

        private void UpdateMonth()
        {
            var selectedDate = SelectedDate;

            for (int i = 0; i < 12; i++)
            {
                var item = _monthPresenter.GetItem(i);
                var culture = Culture ?? Thread.CurrentThread.CurrentCulture;
                item.Tag = i + 1;
                item.Content = culture.DateTimeFormat.GetMonthName(i + 1);
            }
        }

        private void UpdateDay()
        {
            var selectedDate = SelectedDate;

        }
        #endregion

    }
}
