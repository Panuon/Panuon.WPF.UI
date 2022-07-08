using Panuon.WPF.UI.Internal.Converters;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = VerticalScrollBarTemplateName, Type = typeof(ScrollBar))]
    [TemplatePart(Name = HorizontalScrollBarTemplateName, Type = typeof(ScrollBar))]
    [TemplatePart(Name = ContainerBorderTemplateName, Type = typeof(Border))]
    public class ZoomViewer
        : ContentControl
    {
        #region Fields
        private const string VerticalScrollBarTemplateName = "PART_VerticalScrollBar";
        private const string HorizontalScrollBarTemplateName = "PART_HorizontalScrollBar";
        private const string ContainerBorderTemplateName = "PART_ContainerBorder";

        private ScrollBar _verticalScrollBar;
        private ScrollBar _horizontalScrollBar;
        private Border _containerBorder;
        private TranslateTransform _translateTransform = new TranslateTransform();
        private Point _mouseDownPosition;
        private Vector _startVector;

        private bool _isInternalUpdateScrollBar;
        #endregion

        #region Ctor
        static ZoomViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ZoomViewer), new FrameworkPropertyMetadata(typeof(ZoomViewer)));
            ScrollViewer.VerticalScrollBarVisibilityProperty.OverrideMetadata(typeof(ZoomViewer), new FrameworkPropertyMetadata(ScrollBarVisibility.Auto, OnVerticalScrollBarVisibilityChanged));
            ScrollViewer.HorizontalScrollBarVisibilityProperty.OverrideMetadata(typeof(ZoomViewer), new FrameworkPropertyMetadata(ScrollBarVisibility.Auto, OnHorizontalScrollBarVisibilityChanged));
        }
        #endregion

        #region Properties

        #region MaxZoomLevel
        public double MaxZoomLevel
        {
            get { return (double)GetValue(MaxZoomLevelProperty); }
            set { SetValue(MaxZoomLevelProperty, value); }
        }

        public static readonly DependencyProperty MaxZoomLevelProperty =
            DependencyProperty.Register("MaxZoomLevel", typeof(double), typeof(ZoomViewer), new PropertyMetadata(1.5d, OnMaxZoomLevelChanged, OnMaxZoomLevelCoerceValue));
        #endregion

        #region MinZoomLevel
        public double MinZoomLevel
        {
            get { return (double)GetValue(MinZoomLevelProperty); }
            set { SetValue(MinZoomLevelProperty, value); }
        }

        public static readonly DependencyProperty MinZoomLevelProperty =
            DependencyProperty.Register("MinZoomLevel", typeof(double), typeof(ZoomViewer), new PropertyMetadata(0.5d, OnMinZoomLevelChanged, OnMinZoomLevelCoerceValue));
        #endregion

        #region ZoomLevelInterval
        public double ZoomLevelInterval
        {
            get { return (double)GetValue(ZoomLevelIntervalProperty); }
            set { SetValue(ZoomLevelIntervalProperty, value); }
        }

        public static readonly DependencyProperty ZoomLevelIntervalProperty =
            DependencyProperty.Register("ZoomLevelInterval", typeof(double), typeof(ZoomViewer), new PropertyMetadata(0.1d));
        #endregion

        #region ZoomLevel
        public double ZoomLevel
        {
            get { return (double)GetValue(ZoomLevelProperty); }
            set { SetValue(ZoomLevelProperty, value); }
        }

        public static readonly DependencyProperty ZoomLevelProperty =
            DependencyProperty.Register("ZoomLevel", typeof(double), typeof(ZoomViewer), new PropertyMetadata(1d, OnZoomLevelChanged, OnZoomLevelCoerceValue));

        #endregion

        #region MoveOnDragging
        public ComboKeys? MoveOnDragging
        {
            get { return (ComboKeys?)GetValue(MoveOnDraggingProperty); }
            set { SetValue(MoveOnDraggingProperty, value); }
        }

        public static readonly DependencyProperty MoveOnDraggingProperty =
            DependencyProperty.Register("MoveOnDragging", typeof(ComboKeys?), typeof(ZoomViewer), new PropertyMetadata(ComboKeys.None));
        #endregion

        #region ZoomOnWheeling
        public ComboKeys? ZoomOnWheeling
        {
            get { return (ComboKeys?)GetValue(ZoomOnWheelingProperty); }
            set { SetValue(ZoomOnWheelingProperty, value); }
        }

        public static readonly DependencyProperty ZoomOnWheelingProperty =
            DependencyProperty.Register("ZoomOnWheeling", typeof(ComboKeys?), typeof(ZoomViewer), new PropertyMetadata(ComboKeys.Ctrl));
        #endregion

        #region ZoomOrigin
        public Point? ZoomOrigin
        {
            get { return (Point?)GetValue(ZoomOriginProperty); }
            set { SetValue(ZoomOriginProperty, value); }
        }

        public static readonly DependencyProperty ZoomOriginProperty =
            DependencyProperty.Register("ZoomOrigin", typeof(Point?), typeof(ZoomViewer), new PropertyMetadata(new Point(0.5, 0.5)));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _verticalScrollBar = GetTemplateChild(VerticalScrollBarTemplateName) as ScrollBar;
            _verticalScrollBar.ValueChanged += VerticalScrollBar_ValueChanged;

            _horizontalScrollBar = GetTemplateChild(HorizontalScrollBarTemplateName) as ScrollBar;
            _horizontalScrollBar.ValueChanged += HorizontalScrollBar_ValueChanged;
            _containerBorder = GetTemplateChild(ContainerBorderTemplateName) as Border;
            _containerBorder.RenderTransform = _translateTransform;
            _containerBorder.MouseDown += ContainerBorder_MouseDown;
            _containerBorder.MouseMove += ContainerBorder_MouseMove;
            _containerBorder.MouseUp += ContainerBorder_MouseUp;

            UpdateVerticalScrollBar();
            UpdateHorizontalScrollBar();
            ScrollToCenter();
        }
        
        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            if (ZoomOnWheeling != null
                && EnumUtils.IsComboKeysPressed((ComboKeys)ZoomOnWheeling))
            {
                if (e.Delta > 0)
                {
                    ZoomIn();
                }
                else
                {
                    ZoomOut();
                }
            }
        }
        #endregion

        #region Event Handlers

        private void HorizontalScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_isInternalUpdateScrollBar)
            {
                return;
            }

            var delta = (ZoomLevel - 1) / 2 / ZoomLevel;
            var widthDelta = (_containerBorder.ActualWidth * delta);
            _translateTransform.X = (1 - _horizontalScrollBar.Value / (_horizontalScrollBar.Maximum / 2)) * widthDelta;
        }

        private void VerticalScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_isInternalUpdateScrollBar)
            {
                return;
            }
            
            var delta = (ZoomLevel - 1) / 2 / ZoomLevel;
            var heightDelta = (_containerBorder.ActualHeight * delta);
            _translateTransform.Y = (1 - _verticalScrollBar.Value / (_verticalScrollBar.Maximum / 2)) * heightDelta;
        }

        private void ContainerBorder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _containerBorder.ReleaseMouseCapture();
        }

        private void ContainerBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (_containerBorder.IsMouseCaptured)
            {
                var offset = Point.Subtract(e.GetPosition(this), _mouseDownPosition);
                offset.X = offset.X / ZoomLevel;
                offset.Y = offset.Y / ZoomLevel;
                var delta = (ZoomLevel - 1) / 2 / ZoomLevel;
                var widthDelta = (_containerBorder.ActualWidth * delta);
                var heightDelta = (_containerBorder.ActualHeight * delta);

                _translateTransform.X = Math.Max(-widthDelta, Math.Min(widthDelta, _startVector.X + offset.X));
                _translateTransform.Y = Math.Max(-heightDelta, Math.Min(heightDelta, _startVector.Y + offset.Y));

                ResetScrollBarOffset();
            }
        }

        private void ContainerBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MoveOnDragging != null
                && EnumUtils.IsComboKeysPressed((ComboKeys)MoveOnDragging)
                && ZoomLevel > 1)
            {
                _mouseDownPosition = e.GetPosition(this);
                _startVector = new Vector(_translateTransform.X, _translateTransform.Y);
                _containerBorder.CaptureMouse();
            }
        }

        private static object OnMaxZoomLevelCoerceValue(DependencyObject d, object baseValue)
        {
            var zoomLevel = (double)baseValue;
            if (zoomLevel < 1)
            {
                zoomLevel = 1;
            }
            return zoomLevel;
        }

        private static void OnMaxZoomLevelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var zoomViewer = (ZoomViewer)d;
            zoomViewer.CoerceValue(MinZoomLevelProperty);
            zoomViewer.CoerceValue(ZoomLevelProperty);
        }

        private static object OnMinZoomLevelCoerceValue(DependencyObject d, object baseValue)
        {
            var zoomViewer = (ZoomViewer)d;
            var zoomLevel = (double)baseValue;
            if (zoomLevel <= zoomViewer.ZoomLevelInterval)
            {
                zoomLevel = zoomViewer.ZoomLevelInterval;
            }
            return zoomLevel;
        }

        private static void OnMinZoomLevelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var zoomViewer = (ZoomViewer)d;
            zoomViewer.CoerceValue(MinZoomLevelProperty);
            zoomViewer.CoerceValue(ZoomLevelProperty);
        }

        private static object OnZoomLevelCoerceValue(DependencyObject d, object baseValue)
        {
            var zoomViewer = (ZoomViewer)d;
            var zoomLevel = (double)baseValue;
            if (zoomLevel > zoomViewer.MaxZoomLevel)
            {
                zoomLevel = zoomViewer.MaxZoomLevel;
            }
            if (zoomLevel < zoomViewer.MinZoomLevel)
            {
                zoomLevel = zoomViewer.MinZoomLevel;
            }
            return zoomLevel;
        }

        private static void OnZoomLevelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var zoomViewer = (ZoomViewer)d;
            zoomViewer.OnZoomLevelChanged((double)e.OldValue, (double)e.NewValue);
        }

        private static void OnVerticalScrollBarVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var zoomViewer = (ZoomViewer)d;
            zoomViewer.UpdateVerticalScrollBar();
        }

        private static void OnHorizontalScrollBarVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var zoomViewer = (ZoomViewer)d;
            zoomViewer.UpdateHorizontalScrollBar();
        }
        #endregion

        #region Methods
        public void ZoomIn()
        {
            SetCurrentValue(ZoomLevelProperty, ZoomLevel + ZoomLevelInterval);
        }

        public void ZoomOut()
        {
            SetCurrentValue(ZoomLevelProperty, ZoomLevel - ZoomLevelInterval);
        }

        public void ScrollToCenter()
        {
            ScrollToOrigin(new Point(0.5, 0.5), 0);
        }
        #endregion

        #region Functions
        private void OnZoomLevelChanged(double oldValue, double newValue)
        {
            UpdateVerticalScrollBar();
            UpdateHorizontalScrollBar();

            if (ZoomOrigin == null)
            {
                var position = Mouse.GetPosition(this);
                if (position.X >= 0
                    && position.Y >= 0
                    && position.X <= ActualWidth
                    && position.Y <= ActualHeight)
                {
                    ScrollToOrigin(new Point(position.X / ActualWidth, position.Y / ActualHeight), newValue - oldValue);
                    return;
                }
            }
            ScrollToOrigin((Point)ZoomOrigin, newValue - oldValue);
        }

        private void UpdateVerticalScrollBar()
        {
            if (_verticalScrollBar == null)
            {
                return;
            }

            var verticalScrollBarVisibility = ScrollViewer.GetVerticalScrollBarVisibility(this);

            _isInternalUpdateScrollBar = true;
            _verticalScrollBar.Visibility = verticalScrollBarVisibility == ScrollBarVisibility.Disabled
                ? Visibility.Collapsed
                : (verticalScrollBarVisibility == ScrollBarVisibility.Hidden
                    ? Visibility.Collapsed
                    : (verticalScrollBarVisibility == ScrollBarVisibility.Visible
                        ? Visibility.Visible
                        : (verticalScrollBarVisibility == ScrollBarVisibility.Auto
                            ? (ZoomLevel > 1 ? Visibility.Visible : Visibility.Collapsed)
                            : Visibility.Collapsed)));

            _verticalScrollBar.ViewportSize = 1;
            _verticalScrollBar.Maximum = ZoomLevel;
            _isInternalUpdateScrollBar = false;
        }

        private void UpdateHorizontalScrollBar()
        {
            if (_horizontalScrollBar == null)
            {
                return;
            }
            var horizontalScrollBarVisibility = ScrollViewer.GetHorizontalScrollBarVisibility(this);

            _isInternalUpdateScrollBar = true;
            _horizontalScrollBar.Visibility = horizontalScrollBarVisibility == ScrollBarVisibility.Disabled
                ? Visibility.Collapsed
                : (horizontalScrollBarVisibility == ScrollBarVisibility.Hidden
                    ? Visibility.Collapsed
                    : (horizontalScrollBarVisibility == ScrollBarVisibility.Visible
                        ? Visibility.Visible
                        : (horizontalScrollBarVisibility == ScrollBarVisibility.Auto
                            ? (ZoomLevel > 1 ? Visibility.Visible : Visibility.Collapsed)
                            : Visibility.Collapsed)));

            _horizontalScrollBar.ViewportSize = 1;
            _horizontalScrollBar.Maximum = ZoomLevel;
            _isInternalUpdateScrollBar = false;
        }

        private void ScrollToOrigin(Point origin, double scaleDelta)
        {
            if (_horizontalScrollBar == null
            || _verticalScrollBar == null)
            {
                return;
            }

            if (ZoomLevel <= 1)
            {
                _translateTransform.X = 0;
                _translateTransform.Y = 0;
            }
            else
            {
                var delta = (ZoomLevel - 1) / 2 / ZoomLevel;
                var widthDelta = (_containerBorder.ActualWidth * delta);
                var heightDelta = (_containerBorder.ActualHeight * delta);

                var originX = Math.Max(0, Math.Min(1, origin.X));
                var originY = Math.Max(0, Math.Min(1, origin.Y));
                var leftX = 0.5 - originX;
                var topY = 0.5 - originY;
                var deltaX = ActualWidth * scaleDelta * delta;
                var deltaY = ActualHeight * scaleDelta * delta;
                _translateTransform.X = Math.Max(-widthDelta, Math.Min(widthDelta, _translateTransform.X + leftX * deltaX));
                _translateTransform.Y = Math.Max(-heightDelta, Math.Min(heightDelta, _translateTransform.Y + topY * deltaY));
            }

            ResetScrollBarOffset();
        }

        private void ResetScrollBarOffset()
        {
            _isInternalUpdateScrollBar = true;
            if (_containerBorder.ActualWidth == 0
                || _containerBorder.ActualHeight == 0
                || ZoomLevel <= 1)
            {
                _verticalScrollBar.Value = _verticalScrollBar.Maximum / 2;
                _horizontalScrollBar.Value = _horizontalScrollBar.Maximum / 2;
                _isInternalUpdateScrollBar = false;
                return;
            }
            var delta = (ZoomLevel - 1) / 2 / ZoomLevel;
            var widthDelta = (_containerBorder.ActualWidth * delta);
            var heightDelta = (_containerBorder.ActualHeight * delta);

            var offsetX = 1 - _translateTransform.X / widthDelta;
            var offsetY = 1 - _translateTransform.Y / heightDelta;
            _verticalScrollBar.Value = (_verticalScrollBar.Maximum / 2) * offsetY;
            _horizontalScrollBar.Value = (_horizontalScrollBar.Maximum / 2) * offsetX;
            _isInternalUpdateScrollBar = false;
        }
        #endregion
    }
}
