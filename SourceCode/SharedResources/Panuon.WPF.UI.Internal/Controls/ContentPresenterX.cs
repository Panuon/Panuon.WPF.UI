using System;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal
{
    internal class ContentPresenterX
        : ContentPresenter
    {
        #region Fields
        private Size _measuredSize;
        #endregion

        #region Routed Event

        #region IsVertical
        public bool IsVertical
        {
            get { return (bool)GetValue(IsVerticalProperty); }
            set { SetValue(IsVerticalProperty, value); }
        }

        public static readonly DependencyProperty IsVerticalProperty =
            DependencyProperty.Register("IsVertical", typeof(bool), typeof(ContentPresenterX));
        #endregion

        #region HandleArranged
        public bool HandleArranged
        {
            get { return (bool)GetValue(HandleArrangedProperty); }
            set { SetValue(HandleArrangedProperty, value); }
        }

        public static readonly DependencyProperty HandleArrangedProperty =
            DependencyProperty.Register("HandleArranged", typeof(bool), typeof(ContentPresenterX));
        #endregion

        #region Arranged
        public event SelectedValueChangedRoutedEventHandler<Size> Arranged
        {
            add { AddHandler(ArrangedEvent, value); }
            remove { RemoveHandler(ArrangedEvent, value); }
        }

        public static readonly RoutedEvent ArrangedEvent =
            EventManager.RegisterRoutedEvent("Arranged", RoutingStrategy.Bubble, typeof(SelectedValueChangedRoutedEventHandler<Size>), typeof(ContentPresenterX));
        #endregion

        #endregion

        #region Overrides
        protected override Size MeasureOverride(Size constraint)
        {
            if (IsVertical)
            {
                var size = base.MeasureOverride(new Size(constraint.Width, double.PositiveInfinity));
                _measuredSize = size;
                return size;
            }
            else
            {
                var size = base.MeasureOverride(new Size(double.PositiveInfinity, constraint.Height));
                _measuredSize = size;
                return size;
            }
        }

        protected override Size ArrangeOverride(Size arrangeSize)
        {
            var size = base.ArrangeOverride(arrangeSize);

            if (!HandleArranged)
            {
                if (IsVertical)
                {
                    RaiseEvent(new SelectedValueChangedRoutedEventArgs<Size>(ArrangedEvent,
                        new Size(),
                        new Size(size.Width + Margin.Left + Margin.Right, _measuredSize.Height + Margin.Top + Margin.Bottom)));
                }
                else
                {
                    RaiseEvent(new SelectedValueChangedRoutedEventArgs<Size>(ArrangedEvent,
                        new Size(),
                        new Size(_measuredSize.Width + Margin.Left + Margin.Right, size.Height + Margin.Top + Margin.Bottom)));
                }
            }
            return size;
        }
        #endregion
    }
}