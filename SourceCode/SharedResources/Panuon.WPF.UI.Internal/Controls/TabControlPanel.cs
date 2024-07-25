using System;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal
{
    class TabControlPanel
        : Panel
    {
        #region Properties

        #region HeaderPanelAlignment
        public TabControlHeaderPanelAlignment HeaderPanelAlignment
        {
            get { return (TabControlHeaderPanelAlignment)GetValue(HeaderPanelAlignmentProperty); }
            set { SetValue(HeaderPanelAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HeaderPanelAlignmentProperty =
            DependencyProperty.Register("HeaderPanelAlignment", typeof(TabControlHeaderPanelAlignment), typeof(TabControlPanel), new FrameworkPropertyMetadata(TabControlHeaderPanelAlignment.Stretch, FrameworkPropertyMetadataOptions.AffectsArrange));
        #endregion

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(TabControlPanel), new FrameworkPropertyMetadata(Orientation.Vertical, FrameworkPropertyMetadataOptions.AffectsArrange));
        #endregion

        #endregion

        protected override Size MeasureOverride(Size constraint)
        {
            var width = 0d;
            var height = 0d;
            foreach (FrameworkElement child in Children)
            {
                child.Measure(constraint);
                if (child is ScrollViewer scrollViewer)
                {
                    var tabPanel = scrollViewer.Content as StackPanel;
                    tabPanel.Measure(constraint);
                    switch (Orientation)
                    {
                        case Orientation.Vertical:
                            height += tabPanel.DesiredSize.Height;
                            break;
                        case Orientation.Horizontal:
                            width += tabPanel.DesiredSize.Width;
                            break;
                    }

                    tabPanel.SizeChanged -= TabPanel_SizeChanged;
                    tabPanel.SizeChanged += TabPanel_SizeChanged;
                }
                else
                {
                    switch (Orientation)
                    {
                        case Orientation.Vertical:
                            height += child.DesiredSize.Height;
                            break;
                        case Orientation.Horizontal:
                            width += child.DesiredSize.Width;
                            break;
                    }
                }
                switch (Orientation)
                {
                    case Orientation.Vertical:
                        width = Math.Max(width, child.DesiredSize.Width);
                        break;
                    case Orientation.Horizontal:
                        height = Math.Max(height, child.DesiredSize.Height);
                        break;
                }
            }

            switch (Orientation)
            {
                case Orientation.Vertical:
                    return new Size(width, double.IsInfinity(constraint.Height)
                        ? height
                        : constraint.Height);
                default:
                    return new Size(double.IsInfinity(constraint.Width)
                        ? width
                        : constraint.Width, height);
            }
        }

        private void TabPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            InvalidateMeasure();
            InvalidateArrange();
        }

        protected override Size ArrangeOverride(Size arrangeSize)
        {
            var ccFront = Children[0];
            var bdrFront = Children[1];
            var scrollViewer = (ScrollViewer)Children[2];
            var bdrEnd = Children[3];
            var ccEnd = Children[4];

            switch (Orientation)
            {
                case Orientation.Vertical:
                    var contentHeight = (scrollViewer.Content as StackPanel).ActualHeight;
                    SetCurrentValue(ContentWidthOrHeightProperty, contentHeight);

                    var top = 0d;
                    var scrollViewerHeight = Math.Max(0, arrangeSize.Height - ccFront.DesiredSize.Height - ccEnd.DesiredSize.Height);
                    if (contentHeight + ccFront.DesiredSize.Height + ccFront.DesiredSize.Height < arrangeSize.Height)
                    {
                        switch (HeaderPanelAlignment)
                        {
                            case TabControlHeaderPanelAlignment.Stretch:
                                scrollViewerHeight = arrangeSize.Height - ccFront.DesiredSize.Height - ccEnd.DesiredSize.Height;
                                break;
                            case TabControlHeaderPanelAlignment.Front:
                                scrollViewerHeight = Math.Min(scrollViewerHeight, contentHeight);
                                break;
                            case TabControlHeaderPanelAlignment.Center:
                                scrollViewerHeight = Math.Min(scrollViewerHeight, contentHeight);
                                top = (arrangeSize.Height - ccFront.DesiredSize.Height - scrollViewerHeight - ccEnd.DesiredSize.Height) / 2;
                                break;
                            case TabControlHeaderPanelAlignment.End:
                                scrollViewerHeight = Math.Min(scrollViewerHeight, contentHeight);
                                top = arrangeSize.Height - ccFront.DesiredSize.Height - scrollViewerHeight - ccEnd.DesiredSize.Height;
                                break;
                        }
                    }

                    bdrFront.Arrange(new Rect(0, 0, arrangeSize.Width, top));
                    ccFront.Arrange(new Rect(0, 0, arrangeSize.Width, top));
                    top += ccFront.DesiredSize.Height;

                    scrollViewer.Height = scrollViewerHeight;
                    scrollViewer.Arrange(new Rect(0, top, arrangeSize.Width, scrollViewerHeight));

                    top += scrollViewerHeight;
                    bdrEnd.Arrange(new Rect(0, top, arrangeSize.Width, arrangeSize.Height - top));
                    ccEnd.Arrange(new Rect(0, top, arrangeSize.Width, arrangeSize.Height - top));
                    break;
                default:
                    var stackPanel = scrollViewer.Content as StackPanel;
                    var left = 0d;
                    var contentWidth = Math.Max(0, Math.Min(stackPanel.DesiredSize.Width, arrangeSize.Width - ccFront.DesiredSize.Width - ccEnd.DesiredSize.Width));
                    SetCurrentValue(ContentWidthOrHeightProperty, Math.Max(contentWidth, stackPanel.ActualWidth));

                    if (contentWidth + ccFront.DesiredSize.Width + ccFront.DesiredSize.Width < arrangeSize.Width)
                    {
                        switch (HeaderPanelAlignment)
                        {
                            case TabControlHeaderPanelAlignment.Stretch:
                                contentWidth = arrangeSize.Width - ccFront.DesiredSize.Width - ccEnd.DesiredSize.Width;
                                break;
                            case TabControlHeaderPanelAlignment.Front:
                                contentWidth = Math.Min(contentWidth, contentWidth);
                                break;
                            case TabControlHeaderPanelAlignment.Center:
                                contentWidth = Math.Min(contentWidth, contentWidth);
                                break;
                            case TabControlHeaderPanelAlignment.End:
                                contentWidth = Math.Min(contentWidth, contentWidth);
                                break;
                        }
                    }

                    bdrFront.Arrange(new Rect(0, 0, ccFront.DesiredSize.Width, arrangeSize.Height));
                    ccFront.Arrange(new Rect(0, 0, ccFront.DesiredSize.Width, arrangeSize.Height));

                    switch (HeaderPanelAlignment)
                    {
                        case TabControlHeaderPanelAlignment.Stretch:
                            contentWidth = arrangeSize.Width - ccFront.DesiredSize.Width - ccEnd.DesiredSize.Width;
                            break;
                        case TabControlHeaderPanelAlignment.Front:
                            contentWidth = Math.Min(contentWidth, contentWidth);
                            break;
                        case TabControlHeaderPanelAlignment.Center:
                            contentWidth = Math.Min(contentWidth, contentWidth);
                            left = (arrangeSize.Width - ccFront.DesiredSize.Width - contentWidth - ccEnd.DesiredSize.Width) / 2;
                            break;
                        case TabControlHeaderPanelAlignment.End:
                            contentWidth = Math.Min(contentWidth, contentWidth);
                            left = arrangeSize.Width - ccFront.DesiredSize.Width - contentWidth - ccEnd.DesiredSize.Width;
                            break;
                    }
                    left += ccFront.DesiredSize.Width;

                    scrollViewer.Arrange(new Rect(left, 0, contentWidth, arrangeSize.Height));

                    left += contentWidth;
                    bdrEnd.Arrange(new Rect(left, 0, arrangeSize.Width - left, arrangeSize.Height));
                    ccEnd.Arrange(new Rect(arrangeSize.Width - ccEnd.DesiredSize.Width, 0, ccEnd.DesiredSize.Width, arrangeSize.Height));
                    break;
            }

            return arrangeSize;
        }

        public double ContentWidthOrHeight
        {
            get { return (double)GetValue(ContentWidthOrHeightProperty); }
            set { SetValue(ContentWidthOrHeightProperty, value); }
        }

        public static readonly DependencyProperty ContentWidthOrHeightProperty =
            DependencyProperty.Register("ContentWidthOrHeight", typeof(double), typeof(TabControlPanel));


    }
}
