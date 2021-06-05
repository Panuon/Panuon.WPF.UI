using Panuon.UI.Silver.Internal.Models;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal
{
    class CalendarXDayPresenter : FrameworkElement
    {
        #region Fields

        private const int ItemsRows = 6;

        private const int ItemsColumns = 7;

        private Grid _grid;

        private readonly List<CalendarXDayItem> _dayItems;

        private readonly List<CalendarXDayItem> _weekNames;

        private CalendarX _calendar;

        private int _displayYear;

        private int _displayMonth;

        private readonly List<DateTime> _selectedDates = new List<DateTime>();

        private readonly List<CalendarDateRange> _blackoutDateRanges = new List<CalendarDateRange>();

        private readonly List<CalendarXSpecialDay> _specialDays = new List<CalendarXSpecialDay>();

        private bool _isInternalSet;
        #endregion

        #region Ctor
        public CalendarXDayPresenter(CalendarX calendarX)
        {
            _calendar = calendarX;

            //Init items source
            _dayItems = CreateDayItems();
            _weekNames = CreateWeekNames();

            var weeksDisplayItemsControl = new ItemsControl()
            {
                ItemTemplate = new DataTemplate()
                {
                    VisualTree = CreateWeekNameFactory(calendarX),
                },
                ItemsPanel = new ItemsPanelTemplate()
                {
                    VisualTree = CreateUniformGridFactory(1, ItemsColumns),
                },
                ItemsSource = _weekNames,
            };

            //Init items control
            var itemsControl = new ItemsControl()
            {
                ItemTemplate = new DataTemplate()
                {
                    VisualTree = CreateCalendarXItemFactory(calendarX),
                },
                ItemsPanel = new ItemsPanelTemplate()
                {
                    VisualTree = CreateUniformGridFactory(ItemsRows, ItemsColumns),
                },
                ItemsSource = _dayItems,
            };
            Grid.SetRow(itemsControl, 1);
            

            _grid = new Grid();
            _grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            _grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(ItemsRows, GridUnitType.Star) });
            _grid.Children.Add(weeksDisplayItemsControl);
            _grid.Children.Add(itemsControl);

            //add to view
            AddVisualChild(_grid);
            AddLogicalChild(_grid);

            AddHandler(CalendarXItem.SelectedEvent, new RoutedEventHandler(OnCalendarXItemClicked));
        }

        #endregion

        #region Overrides

        #region VisualChildrenCount
        protected override int VisualChildrenCount => 1;
        #endregion

        #region GetVisualChild
        protected override Visual GetVisualChild(int index) => _grid;
        #endregion

        #region MeasureOverride
        protected override Size MeasureOverride(Size availableSize)
        {
            _grid.Measure(availableSize);
            return base.MeasureOverride(availableSize);
        }
        #endregion

        #region ArrangeOverride
        protected override Size ArrangeOverride(Size finalSize)
        {
            _grid.Arrange(new Rect(new Point(0, 0), finalSize));
            return base.ArrangeOverride(finalSize);
        }
        #endregion

        #endregion

        #region Properties


        #endregion

        #region Methods
        public void Update(int year, int month, IEnumerable<DateTime> selectedDates, IEnumerable<CalendarDateRange> blackoutDates, IEnumerable<CalendarXSpecialDay> specialDays)
        {
            _selectedDates.Clear();
            if(selectedDates != null)
            {
                _selectedDates.AddRange(selectedDates);
            }
            _blackoutDateRanges.Clear();
            if(blackoutDates != null)
            {
                _blackoutDateRanges.AddRange(blackoutDates);
            }
            _specialDays.Clear();
            if(specialDays != null)
            {
                _specialDays.AddRange(specialDays);
            }
            UpdateDayItems(year, month);
        }

        public void SetSelectedDates()
        {

        }
        #endregion

        #region Event Handlers
        private List<CalendarXDayItem> CreateWeekNames()
        {
            var cultureInfo = _calendar.GetCultureInfo();

            var weekNames = new List<CalendarXDayItem>();
            for(int i = (int)_calendar.FirstDayOfWeek; i < 7; i++)
            {
                weekNames.Add(new CalendarXDayItem()
                {
                    DisplayName = cultureInfo.DateTimeFormat.GetShortestDayName((DayOfWeek)i),
                });
            }
            for (int i = 0; i < (int)_calendar.FirstDayOfWeek; i++)
            {
                weekNames.Add(new CalendarXDayItem()
                {
                    DisplayName = cultureInfo.DateTimeFormat.GetShortestDayName((DayOfWeek)i),
                });
            }
            return weekNames;
        }

        private void OnCalendarXItemClicked(object sender, RoutedEventArgs e)
        {
            if(_calendar.SelectionMode == CalendarSelectionMode.None) 
            {
                return; 
            }

            var calendarXItem = e.OriginalSource as CalendarXItem;
            var dayItem = calendarXItem.DataContext as CalendarXDayItem;

            if (dayItem.IsSelected)
            {
                var result = _calendar.AddSelectedDate(dayItem.CurrentDate);
                if (result)
                {
                    if (dayItem.IsWeakenDisplay)
                    {
                        UpdateDayItems(dayItem.CurrentDate.Year, dayItem.CurrentDate.Month);
                    }
                    else
                    {
                        if (_calendar.SelectionMode == CalendarSelectionMode.SingleDate)
                        {
                            foreach (var item in _dayItems)
                            {
                                if (item.IsSelected && item != dayItem)
                                {
                                    item.IsSelected = false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    _isInternalSet = true;
                    calendarXItem.IsSelected = false;
                    _isInternalSet = false;
                }
            }
        }

        #endregion

        #region Functions
        private void UpdateDayItems(int year, int month)
        {
            _displayYear = year;
            _displayMonth = month;

            var firstDayOfWeek = _calendar.FirstDayOfWeek;
            var todayDate = DateTime.Now.Date;

            var firstDayInMonth = new DateTime(_displayYear, _displayMonth, 1);
            var firstDayOfWeekInMonth = firstDayInMonth.DayOfWeek;
            var preDelta = firstDayOfWeekInMonth - firstDayOfWeek;
            preDelta = preDelta <= 0 ? (preDelta + 7) : preDelta;

            var loopDate = firstDayInMonth.AddDays(-preDelta);

            foreach (var dayItem in _dayItems)
            {
                var specialDay = _specialDays.FirstOrDefault(x => x.Date.Equals(loopDate));

                dayItem.DisplayName = specialDay == null
                    ? loopDate.Day.ToString()
                    : specialDay.DisplayName;
                dayItem.CurrentDate = loopDate;
                dayItem.IsSpecialDay = specialDay != null;
                dayItem.IsToday = _calendar.IsTodayHighlighted ? loopDate.Date.Equals(todayDate) : false;
                dayItem.IsWeakenDisplay = loopDate.Date.Year != _displayYear || loopDate.Date.Month != _displayMonth;
                dayItem.IsSelected = _calendar.SelectedDates == null ? false : _calendar.SelectedDates.Any(x => x.Year == loopDate.Year && x.Month == loopDate.Month && x.Day == loopDate.Day);
                loopDate = loopDate.AddDays(1);
            }
        }

        private static List<CalendarXDayItem> CreateDayItems()
        {
            var dayItems = new List<CalendarXDayItem>();
            for (int i = 0; i < ItemsRows * ItemsColumns; i++)
            {
                dayItems.Add(new CalendarXDayItem());
            }
            return dayItems;
        }

        private static FrameworkElementFactory CreateWeekNameFactory(CalendarX calendarX)
        {
            var textFactory = new FrameworkElementFactory(typeof(TextBlock));
            textFactory.SetBinding(TextBlock.TextProperty, new Binding()
            {
                Path = new PropertyPath(nameof(CalendarXDayItem.DisplayName)),
            });
            textFactory.SetBinding(TextBlock.VerticalAlignmentProperty, new Binding()
            {
                Path = new PropertyPath(CalendarX.VerticalContentAlignmentProperty),
                Source = calendarX
            });
            textFactory.SetBinding(TextBlock.HorizontalAlignmentProperty, new Binding()
            {
                Path = new PropertyPath(CalendarX.HorizontalContentAlignmentProperty),
                Source = calendarX
            });
            return textFactory;
        }

        private static FrameworkElementFactory CreateCalendarXItemFactory(CalendarX calendarX)
        {
            var itemFactory = new FrameworkElementFactory(typeof(CalendarXItem));
            itemFactory.SetValue(CalendarXItem.ModeProperty, CalendarXItemMode.Day);
            itemFactory.SetBinding(CalendarXItem.StyleProperty, new Binding()
            {
                Path = new PropertyPath(CalendarX.CalendarXItemStyleProperty),
                Source = calendarX
            });
            itemFactory.SetBinding(CalendarXItem.ContentProperty, new Binding()
            {
                Path = new PropertyPath(nameof(CalendarXDayItem.DisplayName)),
            });
            itemFactory.SetBinding(CalendarXItem.VerticalContentAlignmentProperty, new Binding()
            {
                Path = new PropertyPath(CalendarX.VerticalContentAlignmentProperty),
                Source = calendarX
            });
            itemFactory.SetBinding(CalendarXItem.HorizontalContentAlignmentProperty, new Binding()
            {
                Path = new PropertyPath(CalendarX.HorizontalContentAlignmentProperty),
                Source = calendarX
            });
            itemFactory.SetBinding(CalendarXItem.IsSelectedProperty, new Binding()
            {
                Path = new PropertyPath(nameof(CalendarXDayItem.IsSelected)),
            });
            itemFactory.SetBinding(CalendarXItem.IsInSelectionRangeProperty, new Binding()
            {
                Path = new PropertyPath(nameof(CalendarXDayItem.IsInSelectionRange)),
            });
            itemFactory.SetBinding(CalendarXItem.IsSpecialDayProperty, new Binding()
            {
                Path = new PropertyPath(nameof(CalendarXDayItem.IsSpecialDay)),
            });
            itemFactory.SetBinding(CalendarXItem.IsWeakenDisplayProperty, new Binding()
            {
                Path = new PropertyPath(nameof(CalendarXDayItem.IsWeakenDisplay)),
            });
            itemFactory.SetBinding(CalendarXItem.IsTodayProperty, new Binding()
            {
                Path = new PropertyPath(nameof(CalendarXDayItem.IsToday)),
            });
            return itemFactory;
        }

        private static FrameworkElementFactory CreateUniformGridFactory(int rows, int columns)
        {
            var itemPanelFactory = new FrameworkElementFactory(typeof(UniformGrid));
            itemPanelFactory.SetValue(UniformGrid.RowsProperty, rows);
            itemPanelFactory.SetValue(UniformGrid.ColumnsProperty, columns);
            return itemPanelFactory;
        }

        #endregion
    }
}
