using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal
{
    internal class CalendarXItemPresenter
        : FrameworkElement
    {
        #region Fields
        private int _row;

        private int _column;

        private readonly List<CalendarXItem> _calendarXItems
            = new List<CalendarXItem>();
        #endregion

        #region Ctor
        public CalendarXItemPresenter()
        {
            AddHandler(CalendarXItem.SelectedEvent, new RoutedEventHandler(OnCalendarXItemSelected));
        }
        #endregion

        #region Routed Events

        #region Selected
        public event RoutedEventHandler Selected
        {
            add { AddHandler(SelectedEvent, value); }
            remove { RemoveHandler(SelectedEvent, value); }
        }

        public static readonly RoutedEvent SelectedEvent =
            EventManager.RegisterRoutedEvent("Selected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CalendarXItemPresenter));
        #endregion

        #endregion

        #region Properties

        #region CalendarXItemStyle
        public Style CalendarXItemStyle
        {
            get { return (Style)GetValue(CalendarXItemStyleProperty); }
            set { SetValue(CalendarXItemStyleProperty, value); }
        }

        public static readonly DependencyProperty CalendarXItemStyleProperty =
            DependencyProperty.Register("CalendarXItemStyle", typeof(Style), typeof(CalendarXItemPresenter));
        #endregion

        #endregion

        #region Overrides
        protected override int VisualChildrenCount => _calendarXItems.Count;

        protected override Visual GetVisualChild(int index) => _calendarXItems[index];

        protected override Size MeasureOverride(Size availableSize)
        {
            foreach (var calendarItem in _calendarXItems)
            {
                calendarItem.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            }
            return base.MeasureOverride(availableSize);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            var row = 0;
            var column = 0;
            var itemWidth = finalSize.Width / _column;
            var itemHeight = finalSize.Height / _row;

            foreach (var calendarItem in _calendarXItems)
            {
                if (column == _column)
                {
                    row++;
                    column = 0;
                }
                calendarItem.Arrange(new Rect(column * itemWidth, row * itemHeight, itemWidth, itemHeight));
                column++;
            }
            return base.ArrangeOverride(finalSize);
        }
        #endregion

        #region Event Handlers
        private void OnCalendarXItemSelected(object sender, RoutedEventArgs e)
        {
            var item = e.Source as CalendarXItem;
            foreach (var calendarXItem in _calendarXItems)
            {
                calendarXItem.IsChecked = calendarXItem == item;
            }
            RaiseEvent(new RoutedEventArgs(SelectedEvent, item));
        }
        #endregion

        #region Methods
        public void Init(int row, int column)
        {
            _row = row;
            _column = column;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var calendarXItem = new CalendarXItem()
                    {
                        Type = Tag.ToString(),
                    };
                    FrameworkElementUtil.BindingProperty(calendarXItem, CalendarXItem.StyleProperty, this, CalendarXItemStyleProperty);

                    AddVisualChild(calendarXItem);
                    AddLogicalChild(calendarXItem);

                    _calendarXItems.Add(calendarXItem);
                }
            }

            InvalidateMeasure();
            InvalidateArrange();
            UpdateLayout();
        }

        public CalendarXItem GetItem(int row
            , int column)
        {
            var targetIndex = row * _column + column;
            var target = _calendarXItems[targetIndex];
            return target;
        }

        public CalendarXItem GetItem(int index)
        {
            var target = _calendarXItems[index];
            return target;
        }
        #endregion
    }
}
