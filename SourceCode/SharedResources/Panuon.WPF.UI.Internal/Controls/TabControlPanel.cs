using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Media3D;

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
                    if(contentHeight + ccFront.DesiredSize.Height + ccFront.DesiredSize.Height < arrangeSize.Height)
                    {
                        switch (HeaderPanelAlignment)
                        {
                            case TabControlHeaderPanelAlignment.Stretch:
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

                    ccFront.Arrange(new Rect(0, top, arrangeSize.Width, ccFront.DesiredSize.Height));
                    bdrFront.Arrange(new Rect(0, top, arrangeSize.Width, ccFront.DesiredSize.Height));
                    top += ccFront.DesiredSize.Height;

                    scrollViewer.Height = scrollViewerHeight;
                    scrollViewer.Arrange(new Rect(0, top, arrangeSize.Width, scrollViewerHeight));

                    top += scrollViewerHeight;
                    bdrEnd.Arrange(new Rect(0, top, arrangeSize.Width, ccEnd.DesiredSize.Height));
                    ccEnd.Arrange(new Rect(0, top, arrangeSize.Width, ccEnd.DesiredSize.Height));
                    break;
                default:
                    var contentWidth = (scrollViewer.Content as StackPanel).ActualWidth;
                    SetCurrentValue(ContentWidthOrHeightProperty, contentWidth);

                    var left = 0d;
                    var scrollViewerWidth = Math.Max(0, arrangeSize.Width - ccFront.DesiredSize.Width - ccEnd.DesiredSize.Width);

                    if (contentWidth + ccFront.DesiredSize.Width + ccFront.DesiredSize.Width < arrangeSize.Width)
                    {
                        switch (HeaderPanelAlignment)
                        {
                            case TabControlHeaderPanelAlignment.Stretch:
                                break;
                            case TabControlHeaderPanelAlignment.Front:
                                scrollViewerWidth = Math.Min(scrollViewerWidth, contentWidth);
                                break;
                            case TabControlHeaderPanelAlignment.Center:
                                scrollViewerWidth = Math.Min(scrollViewerWidth, contentWidth);
                                left = (arrangeSize.Width - ccFront.DesiredSize.Width - scrollViewerWidth - ccEnd.DesiredSize.Width) / 2;
                                break;
                            case TabControlHeaderPanelAlignment.End:
                                scrollViewerWidth = Math.Min(scrollViewerWidth, contentWidth);
                                left = arrangeSize.Width - ccFront.DesiredSize.Width - scrollViewerWidth - ccEnd.DesiredSize.Width;
                                break;
                        }
                    }

                    ccFront.Arrange(new Rect(left, 0, ccFront.DesiredSize.Width, arrangeSize.Height));
                    bdrFront.Arrange(new Rect(left, 0, ccFront.DesiredSize.Width, arrangeSize.Height));
                    left += ccFront.DesiredSize.Width;

                    scrollViewer.Width = scrollViewerWidth;
                    scrollViewer.Arrange(new Rect(left, 0, scrollViewerWidth, arrangeSize.Height));

                    left += scrollViewerWidth;
                    bdrEnd.Arrange(new Rect(left, 0, ccEnd.DesiredSize.Width, arrangeSize.Height));
                    ccEnd.Arrange(new Rect(left, 0, ccEnd.DesiredSize.Width, arrangeSize.Height));
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
