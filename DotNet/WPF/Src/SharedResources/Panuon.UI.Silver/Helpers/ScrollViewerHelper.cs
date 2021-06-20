using System;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver
{
    public static class ScrollViewerHelper
    {
        #region Fields
        private const double MouseWheelDelta = 48.0;
        #endregion

        #region Properties

        #region ScrollBarThickness
        public static double GetScrollBarThickness(DependencyObject obj)
        {
            return (double)obj.GetValue(ScrollBarThicknessProperty);
        }

        public static void SetScrollBarThickness(DependencyObject obj, double value)
        {
            obj.SetValue(ScrollBarThicknessProperty, value);
        }

        public static readonly DependencyProperty ScrollBarThicknessProperty =
            DependencyProperty.RegisterAttached("ScrollBarThickness", typeof(double), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(10.0, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region ScrollBarPosition
        public static ScrollBarPosition GetScrollBarPosition(DependencyObject obj)
        {
            return (ScrollBarPosition)obj.GetValue(ScrollBarPositionProperty);
        }

        public static void SetScrollBarPosition(DependencyObject obj, ScrollBarPosition value)
        {
            obj.SetValue(ScrollBarPositionProperty, value);
        }

        public static readonly DependencyProperty ScrollBarPositionProperty =
            DependencyProperty.RegisterAttached("ScrollBarPosition", typeof(ScrollBarPosition), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(ScrollBarPosition.Inside, FrameworkPropertyMetadataOptions.Inherits));

        #endregion

        #region WheelScrollingDirection
        public static WheelScrollingDirection GetWheelScrollingDirection(DependencyObject obj)
        {
            return (WheelScrollingDirection)obj.GetValue(WheelScrollingDirectionProperty);
        }

        public static void SetWheelScrollingDirection(DependencyObject obj, WheelScrollingDirection value)
        {
            obj.SetValue(WheelScrollingDirectionProperty, value);
        }

        public static readonly DependencyProperty WheelScrollingDirectionProperty =
            DependencyProperty.RegisterAttached("WheelScrollingDirection", typeof(WheelScrollingDirection), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(WheelScrollingDirection.Vertical, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region HandleMouseWheel
        public static bool GetHandleMouseWheel(DependencyObject obj)
        {
            return (bool)obj.GetValue(HandleMouseWheelProperty);
        }

        public static void SetHandleMouseWheel(DependencyObject obj, bool value)
        {
            obj.SetValue(HandleMouseWheelProperty, value);
        }

        public static readonly DependencyProperty HandleMouseWheelProperty =
            DependencyProperty.RegisterAttached("HandleMouseWheel", typeof(bool), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #endregion

        #region Internal Properties
        internal static bool GetRegist(DependencyObject obj)
        {
            return (bool)obj.GetValue(RegistProperty);
        }

        internal static void SetRegist(DependencyObject obj, bool value)
        {
            obj.SetValue(RegistProperty, value);
        }

        internal static readonly DependencyProperty RegistProperty =
            DependencyProperty.RegisterAttached("Regist", typeof(bool), typeof(ScrollViewerHelper), new PropertyMetadata(OnRegistChanged));
        #endregion

        #region Event Handlers
        private static void OnRegistChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)d;
            scrollViewer.PreviewMouseWheel += ScrollViewer_PreviewMouseWheel;
        }

        private static void ScrollViewer_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            var scrollViewer = (ScrollViewer)sender;
            switch (GetWheelScrollingDirection(scrollViewer))
            {
                case WheelScrollingDirection.Horizontal:
                    scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + (e.Delta < 0 ? MouseWheelDelta : -MouseWheelDelta));
                    e.Handled = true;
                    break;
                case WheelScrollingDirection.HorizontalThenVertical:
                    if (e.Delta < 0 && scrollViewer.HorizontalOffset != scrollViewer.ScrollableWidth)
                    {
                        scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + (e.Delta < 0 ? MouseWheelDelta : -MouseWheelDelta));
                        e.Handled = true;
                    }
                    else if (e.Delta > 0 && scrollViewer.HorizontalOffset != 0)
                    {
                        scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + (e.Delta < 0 ? MouseWheelDelta : -MouseWheelDelta));
                        e.Handled = true;
                    }
                    break;
                case WheelScrollingDirection.VerticalThenHorizontal:
                    if (e.Delta < 0 && scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
                    {
                        scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + (e.Delta < 0 ? MouseWheelDelta : -MouseWheelDelta));
                        e.Handled = true;
                    }
                    else if (e.Delta > 0 && scrollViewer.VerticalOffset == 0)
                    {
                        scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + (e.Delta < 0 ? MouseWheelDelta : -MouseWheelDelta));
                        e.Handled = true;
                    }
                    break;
                case WheelScrollingDirection.Both:
                    scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + (e.Delta < 0 ? MouseWheelDelta : -MouseWheelDelta));
                    break;
            }
            if (GetHandleMouseWheel(scrollViewer))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
