using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class SeparatorX : FrameworkElement
    {
        #region Fields
        private Pen _pen;

        private bool _isVertical;
        #endregion

        #region Ctor
        static SeparatorX()
        {
            IsHitTestVisibleProperty.OverrideMetadata(typeof(SeparatorX), new FrameworkPropertyMetadata(false));
            FocusableProperty.OverrideMetadata(typeof(SeparatorX), new FrameworkPropertyMetadata(false));
            RenderOptions.EdgeModeProperty.OverrideMetadata(typeof(SeparatorX), new FrameworkPropertyMetadata(EdgeMode.Aliased));
        }

        public SeparatorX()
        {
            RecreatePen();
        }
        #endregion

        #region Properties

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(SeparatorX), new FrameworkPropertyMetadata(Orientation.Horizontal, FrameworkPropertyMetadataOptions.AffectsRender));
        #endregion 

        #region Stroke
        public Brush Stroke
        {
            get { return (Brush)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }

        public static readonly DependencyProperty StrokeProperty =
            DependencyProperty.Register("Stroke", typeof(Brush), typeof(SeparatorX), new FrameworkPropertyMetadata(Brushes.Black, FrameworkPropertyMetadataOptions.AffectsRender, OnAffectsPenPropertyChanged));
        #endregion

        #region StrokeThickness
        public double StrokeThickness
        {
            get { return (double)GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty StrokeThicknessProperty =
            DependencyProperty.Register("StrokeThickness", typeof(double), typeof(SeparatorX), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsRender, OnAffectsPenPropertyChanged));
        #endregion

        #region StrokeLineCap
        public PenLineCap StrokeLineCap
        {
            get { return (PenLineCap)GetValue(StrokeLineCapProperty); }
            set { SetValue(StrokeLineCapProperty, value); }
        }

        public static readonly DependencyProperty StrokeLineCapProperty =
            DependencyProperty.Register("StrokeLineCap", typeof(PenLineCap), typeof(SeparatorX), new FrameworkPropertyMetadata(PenLineCap.Flat, FrameworkPropertyMetadataOptions.AffectsRender, OnAffectsPenPropertyChanged));

        #endregion

        #region StrokeDashCap
        public PenLineCap StrokeDashCap
        {
            get { return (PenLineCap)GetValue(StrokeDashCapProperty); }
            set { SetValue(StrokeDashCapProperty, value); }
        }

        public static readonly DependencyProperty StrokeDashCapProperty =
            DependencyProperty.Register("StrokeDashCap", typeof(PenLineCap), typeof(SeparatorX), new FrameworkPropertyMetadata(PenLineCap.Flat, FrameworkPropertyMetadataOptions.AffectsRender, OnAffectsPenPropertyChanged));
        #endregion

        #region StrokeDashArray
        [TypeConverter(typeof(DoubleCollectionConverter))]
        public DoubleCollection StrokeDashArray
        {
            get { return (DoubleCollection)GetValue(StrokeDashArrayProperty); }
            set { SetValue(StrokeDashArrayProperty, value); }
        }

        public static readonly DependencyProperty StrokeDashArrayProperty =
            DependencyProperty.Register("StrokeDashArray", typeof(DoubleCollection), typeof(SeparatorX), new FrameworkPropertyMetadata(new DoubleCollection(), FrameworkPropertyMetadataOptions.AffectsRender, OnAffectsPenPropertyChanged));
        #endregion

        #region StrokeDashOffset
        public double StrokeDashOffset
        {
            get { return (double)GetValue(StrokeDashOffsetProperty); }
            set { SetValue(StrokeDashOffsetProperty, value); }
        }

        public static readonly DependencyProperty StrokeDashOffsetProperty =
            DependencyProperty.Register("StrokeDashOffset", typeof(double), typeof(SeparatorX), new FrameworkPropertyMetadata(new double(), FrameworkPropertyMetadataOptions.AffectsRender, OnAffectsPenPropertyChanged));
        #endregion

        #endregion

        #region Overrides

        #region MeasureOverride
        protected override Size MeasureOverride(Size availableSize)
        {
            UpdateComputedValues();

            var width = (double.IsNaN(availableSize.Width) || double.IsInfinity(availableSize.Width)) ? 0.0 : availableSize.Width;
            var height = (double.IsNaN(availableSize.Height) || double.IsInfinity(availableSize.Height)) ? 0.0 : availableSize.Height;
            if (_isVertical)
            {
                width = StrokeThickness;
            }
            else
            {
                height = StrokeThickness;
            }
            return new Size(width, height);
        }
        #endregion

       

        #region OnRender
        protected override void OnRender(DrawingContext drawingContext)
        {
            if (RenderSize.Width == 0 || RenderSize.Height == 0)
            {
                return;
            }
            if (_isVertical)
            {
                drawingContext.DrawLine(_pen, new Point(StrokeThickness, 0), new Point(StrokeThickness, RenderSize.Height));
            }
            else
            {
                drawingContext.DrawLine(_pen, new Point(0, StrokeThickness), new Point(RenderSize.Width, StrokeThickness));
            }
        }
        #endregion

        #endregion

        #region Functions
        private void UpdateComputedValues()
        {
            _isVertical = Orientation == Orientation.Vertical;
        }

        private static void OnAffectsPenPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var separator = (SeparatorX)d;
            separator.RecreatePen();
        }

        private void RecreatePen()
        {
            if (Stroke == null)
            {
                _pen = null;
            }
            else
            {
                var brush = Stroke.CloneCurrentValue();
                brush.Freeze();
                _pen = new Pen(brush, StrokeThickness);
                _pen.StartLineCap = StrokeLineCap;
                _pen.EndLineCap = StrokeLineCap;
                _pen.DashStyle = new DashStyle(StrokeDashArray, StrokeDashOffset);
                _pen.DashCap = StrokeDashCap;
                _pen.Freeze();
            }

        }
        #endregion
    }
}
