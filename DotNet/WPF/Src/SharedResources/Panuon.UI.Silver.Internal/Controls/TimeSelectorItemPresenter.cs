using Panuon.UI.Silver.Internal.Utils;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal
{
    internal class TimeSelectorItemPresenter
        : FrameworkElement
    {
        #region Fields
        private int _row;

        private int _selectedIndex;

        private readonly List<TimeSelectorItem> _timeSelectorItems
            = new List<TimeSelectorItem>();
        #endregion

        #region Ctor
        static TimeSelectorItemPresenter()
        {
            ClipToBoundsProperty.OverrideMetadata(typeof(TimeSelectorItemPresenter), new FrameworkPropertyMetadata(true));
        }
        public TimeSelectorItemPresenter()
        {
            AddHandler(TimeSelectorItem.SelectedEvent, new RoutedEventHandler(OnTimeSelectorItemSelected));
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
            EventManager.RegisterRoutedEvent("Selected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TimeSelectorItemPresenter));
        #endregion

        #endregion

        #region Properties

        #region TimeSelectorItemStyle
        public Style TimeSelectorItemStyle
        {
            get { return (Style)GetValue(TimeSelectorItemStyleProperty); }
            set { SetValue(TimeSelectorItemStyleProperty, value); }
        }

        public static readonly DependencyProperty TimeSelectorItemStyleProperty =
            DependencyProperty.Register("TimeSelectorItemStyle", typeof(Style), typeof(TimeSelectorItemPresenter));
        #endregion

        #endregion

        #region Overrides
        protected override int VisualChildrenCount => _timeSelectorItems.Count;

        protected override Visual GetVisualChild(int index) => _timeSelectorItems[index];

        protected override Size MeasureOverride(Size availableSize)
        {
            foreach (var calendarItem in _timeSelectorItems)
            {
                calendarItem.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            }
            return base.MeasureOverride(availableSize);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            var arrangedItems = new List<TimeSelectorItem>();

            var centerItem = _timeSelectorItems[_selectedIndex];

            var top = (finalSize.Height - centerItem.DesiredSize.Height) / 2;
            var bottom = (finalSize.Height + centerItem.DesiredSize.Height) / 2;

            centerItem.Arrange(new Rect(0, top, finalSize.Width, centerItem.DesiredSize.Height));
            arrangedItems.Add(centerItem);
            var loopIndex = _selectedIndex - 1;
            while (true)
            {
                if(top <= 0)
                {
                    break;
                }
                if(loopIndex < 0)
                {
                    loopIndex = _row - 1;
                }
                var targetItem = _timeSelectorItems[loopIndex];
                top -= targetItem.DesiredSize.Height;
                targetItem.Arrange(new Rect(0, top, finalSize.Width, targetItem.DesiredSize.Height));
                arrangedItems.Add(targetItem);

                loopIndex--;
            }

            loopIndex = _selectedIndex + 1;
            while (true)
            {
                if (bottom >= finalSize.Height)
                {
                    break;
                }
                if (loopIndex > _row - 1)
                {
                    loopIndex = 0;
                }
                var targetItem = _timeSelectorItems[loopIndex];
                targetItem.Arrange(new Rect(0, bottom, finalSize.Width, targetItem.DesiredSize.Height));
                bottom += targetItem.DesiredSize.Height;
                arrangedItems.Add(targetItem);

                loopIndex++;
            }

            foreach(var item in _timeSelectorItems)
            {
                if (!arrangedItems.Contains(item))
                {
                    item.Arrange(new Rect());
                }
            }

            return base.ArrangeOverride(finalSize);
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            var targetIndex = _selectedIndex;
            if (e.Delta > 0)
            {
                targetIndex--;
                if (targetIndex < 0)
                {
                    targetIndex = _row - 1;
                }
            }
            else
            {
                targetIndex++;
                if (targetIndex > _row - 1)
                {
                    targetIndex = 0;
                }
            }
            if (_timeSelectorItems[targetIndex].CanSelect)
            {
                _timeSelectorItems[targetIndex].Select();
                _selectedIndex = targetIndex;
            }
            base.OnMouseWheel(e);
        }
        #endregion

        #region Event Handlers
        private void OnTimeSelectorItemSelected(object sender, RoutedEventArgs e)
        {
            var item = e.Source as TimeSelectorItem;
            foreach (var timeSelectorItem in _timeSelectorItems)
            {
                timeSelectorItem.IsChecked = timeSelectorItem == item;
            }
            RaiseEvent(new RoutedEventArgs(SelectedEvent, item));
        }
        #endregion

        #region Methods
        public void Init(int row)
        {
            _row = row;

            for (int i = 0; i < row; i++)
            {
                var timeSelectorItem = new TimeSelectorItem();
                FrameworkElementUtil.BindingProperty(timeSelectorItem, TimeSelectorItem.StyleProperty, this, TimeSelectorItemStyleProperty);

                AddVisualChild(timeSelectorItem);
                AddLogicalChild(timeSelectorItem);

                _timeSelectorItems.Add(timeSelectorItem);
            }

            InvalidateMeasure();
            InvalidateArrange();
            UpdateLayout();
        }

        public void SetSelectedIndex(int index)
        {
            _selectedIndex = index;
            InvalidateArrange();
            UpdateLayout();
        }

        public TimeSelectorItem GetItem(int index)
        {
            var target = _timeSelectorItems[index];
            return target;
        }
        #endregion

    }
}
