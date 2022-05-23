using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class ScrollViewerHelper
    {
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
            DependencyProperty.RegisterAttached("ScrollBarPosition", typeof(ScrollBarPosition), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(ScrollBarPosition.Outside, FrameworkPropertyMetadataOptions.Inherits));

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

        #region ContentSpacing
        public static double GetContentSpacing(DependencyObject obj)
        {
            return (double)obj.GetValue(ContentSpacingProperty);
        }

        public static void SetContentSpacing(DependencyObject obj, double value)
        {
            obj.SetValue(ContentSpacingProperty, value);
        }

        public static readonly DependencyProperty ContentSpacingProperty =
            DependencyProperty.RegisterAttached("ContentSpacing", typeof(double), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region AnimationEase
        public static AnimationEase GetAnimationEase(DependencyObject obj)
        {
            return (AnimationEase)obj.GetValue(AnimationEaseProperty);
        }

        public static void SetAnimationEase(DependencyObject obj, AnimationEase value)
        {
            obj.SetValue(AnimationEaseProperty, value);
        }

        public static readonly DependencyProperty AnimationEaseProperty =
            DependencyProperty.RegisterAttached("AnimationEase", typeof(AnimationEase), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(AnimationEase.None, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region AnimationDuration
        public static TimeSpan GetAnimationDuration(DependencyObject obj)
        {
            return (TimeSpan)obj.GetValue(AnimationDurationProperty);
        }

        public static void SetAnimationDuration(DependencyObject obj, TimeSpan value)
        {
            obj.SetValue(AnimationDurationProperty, value);
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.RegisterAttached("AnimationDuration", typeof(TimeSpan), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(new TimeSpan(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region MouseWheelDelta
        public static double GetMouseWheelDelta(DependencyObject obj)
        {
            return (double)obj.GetValue(MouseWheelDeltaProperty);
        }

        public static void SetMouseWheelDelta(DependencyObject obj, double value)
        {
            obj.SetValue(MouseWheelDeltaProperty, value);
        }

        public static readonly DependencyProperty MouseWheelDeltaProperty =
            DependencyProperty.RegisterAttached("MouseWheelDelta", typeof(double), typeof(ScrollViewerHelper), new FrameworkPropertyMetadata(48d, FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region VerticalOffset
        public static double GetVerticalOffset(ScrollViewer scrollViewer)
        {
            return (double)scrollViewer.GetValue(VerticalOffsetProperty);
        }

        public static void SetVerticalOffset(ScrollViewer scrollViewer, double value)
        {
            value = Math.Min(scrollViewer.ScrollableHeight, Math.Max(0, value));

            scrollViewer.SetValue(TargetVerticalOffsetProperty, value);

            if (scrollViewer.IsLoaded)
            {
                var animationDuration = GetAnimationDuration(scrollViewer);
                var animationEase = GetAnimationEase(scrollViewer);
                AnimationUtil.BeginDoubleAnimation(scrollViewer, VerticalOffsetProperty, null, value, animationDuration, null, animationEase);
            }
            else
            {
                scrollViewer.SetValue(VerticalOffsetProperty, value);
            }
        }

        public static readonly DependencyProperty VerticalOffsetProperty =
            DependencyProperty.RegisterAttached("VerticalOffset", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(0d, OnVerticalOffsetChanged));

        #endregion

        #region HorizontalOffset
        public static double GetHorizontalOffset(ScrollViewer scrollViewer)
        {
            return (double)scrollViewer.GetValue(HorizontalOffsetProperty);
        }

        public static void SetHorizontalOffset(ScrollViewer scrollViewer, double value)
        {
            value = Math.Min(scrollViewer.ScrollableWidth, Math.Max(0, value));

            scrollViewer.SetValue(TargetHorizontalOffsetProperty, value);
            if (scrollViewer.IsLoaded)
            {
                var animationDuration = GetAnimationDuration(scrollViewer);
                var animationEase = GetAnimationEase(scrollViewer);
                AnimationUtil.BeginDoubleAnimation(scrollViewer, HorizontalOffsetProperty, null, value, animationDuration, null, animationEase);
            }
            else
            {
                scrollViewer.SetValue(HorizontalOffsetProperty, value);
            }
        }

        public static readonly DependencyProperty HorizontalOffsetProperty =
            DependencyProperty.RegisterAttached("HorizontalOffset", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(0d, OnHorizontalOffsetChanged));
        #endregion

        #endregion

        #region Internal Properties

        #region Regist
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

        #region TargetVerticalOffset
        internal static double GetTargetVerticalOffset(ScrollViewer scrollViewer)
        {
            return (double)scrollViewer.GetValue(TargetVerticalOffsetProperty);
        }

        internal static void SetTargetVerticalOffset(ScrollViewer scrollViewer, double value)
        {
            scrollViewer.SetValue(TargetVerticalOffsetProperty, value);
        }

        internal static readonly DependencyProperty TargetVerticalOffsetProperty =
            DependencyProperty.RegisterAttached("TargetVerticalOffset", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(0d));
        #endregion

        #region TargetHorizontalOffset
        internal static double GetTargetHorizontalOffset(ScrollViewer scrollViewer)
        {
            return (double)scrollViewer.GetValue(TargetHorizontalOffsetProperty);
        }

        internal static void SetTargetHorizontalOffset(ScrollViewer scrollViewer, double value)
        {
            scrollViewer.SetValue(TargetHorizontalOffsetProperty, value);
        }

        internal static readonly DependencyProperty TargetHorizontalOffsetProperty =
            DependencyProperty.RegisterAttached("TargetHorizontalOffset", typeof(double), typeof(ScrollViewerHelper), new PropertyMetadata(0d));
        #endregion

        #endregion

        #region Event Handlers

        private static void OnVerticalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)d;
            var newValue = (double)e.NewValue;
            scrollViewer.ScrollToVerticalOffset(newValue);
        }

        private static void OnHorizontalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)d;
            var newValue = (double)e.NewValue;
            scrollViewer.ScrollToHorizontalOffset(newValue);
        }

        private static void OnRegistChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)d;
            scrollViewer.ScrollChanged += ScrollViewer_ScrollChanged;
            scrollViewer.PreviewMouseWheel += ScrollViewer_PreviewMouseWheel;
        }

        private static void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var scrollViewer = sender as ScrollViewer;
            if(e.HorizontalChange != 0)
            {
                var offset = scrollViewer.HorizontalOffset;
                var thisOffset = GetHorizontalOffset(scrollViewer);
                if (offset != thisOffset)
                {
                    scrollViewer.SetCurrentValue(HorizontalOffsetProperty, offset);
                    scrollViewer.SetCurrentValue(TargetHorizontalOffsetProperty, offset);
                }
            }
            if (e.VerticalChange != 0)
            {
                var offset = scrollViewer.VerticalOffset;
                var thisOffset = GetVerticalOffset(scrollViewer);
                if(offset != thisOffset)
                {
                    scrollViewer.SetCurrentValue(VerticalOffsetProperty, offset);
                    scrollViewer.SetCurrentValue(TargetVerticalOffsetProperty, offset);
                }
            }
        }

        private static void ScrollViewer_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            var scrollViewer = (ScrollViewer)sender;
            var element = e.OriginalSource as DependencyObject;
            try
            {
                while (element != null
                    && element != scrollViewer)
                {
                    if (element is ScrollViewer childScrollViewer)
                    {
                        if (GetHandleMouseWheel(childScrollViewer)
                            && (childScrollViewer.ScrollableHeight > 0
                                || childScrollViewer.ScrollableWidth > 0))
                        {
                            return;
                        }
                    }
                    element = VisualTreeHelper.GetParent(element);
                }
            }
            catch { }
            var mouseWheelDelta = GetMouseWheelDelta(scrollViewer);
            switch (GetWheelScrollingDirection(scrollViewer))
            {
                case WheelScrollingDirection.Vertical:
                    SetVerticalOffset(scrollViewer, GetTargetVerticalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                    e.Handled = true;
                    break;
                case WheelScrollingDirection.Horizontal:
                    SetHorizontalOffset(scrollViewer, GetTargetHorizontalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                    e.Handled = true;
                    break;
                case WheelScrollingDirection.HorizontalThenVertical:
                    if (e.Delta < 0 && GetTargetHorizontalOffset(scrollViewer) != scrollViewer.ScrollableWidth)
                    {
                        SetHorizontalOffset(scrollViewer, GetTargetHorizontalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                        e.Handled = true;
                    }
                    else if (e.Delta > 0 && GetTargetHorizontalOffset(scrollViewer) != 0)
                    {
                        SetHorizontalOffset(scrollViewer, GetTargetHorizontalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                        e.Handled = true;
                    }
                    else
                    {
                        SetVerticalOffset(scrollViewer, GetTargetVerticalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                        e.Handled = true;
                    }
                    break;
                case WheelScrollingDirection.VerticalThenHorizontal:
                    if (e.Delta < 0 && GetTargetVerticalOffset(scrollViewer) == scrollViewer.ScrollableHeight)
                    {
                        SetHorizontalOffset(scrollViewer, GetTargetHorizontalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                        e.Handled = true;
                    }
                    else if (e.Delta > 0 && GetTargetVerticalOffset(scrollViewer) == 0)
                    {
                        SetHorizontalOffset(scrollViewer, GetTargetHorizontalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                        e.Handled = true;
                    }
                    else
                    {
                        SetVerticalOffset(scrollViewer, GetTargetVerticalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                        e.Handled = true;
                    }
                    break;
                case WheelScrollingDirection.Both:
                    SetVerticalOffset(scrollViewer, GetTargetVerticalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                    SetHorizontalOffset(scrollViewer, GetTargetHorizontalOffset(scrollViewer) + (e.Delta < 0 ? mouseWheelDelta : -mouseWheelDelta));
                    e.Handled = true;
                    break;
            }
            //if (GetHandleMouseWheel(scrollViewer))
            //{
            //    e.Handled = true;
            //}
        }

        #endregion
    }
}
