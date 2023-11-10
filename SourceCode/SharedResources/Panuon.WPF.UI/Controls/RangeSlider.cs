using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = Thumb1TemplateName, Type = typeof(Thumb))]
    [TemplatePart(Name = Thumb2TemplateName, Type = typeof(Thumb))]
    [TemplatePart(Name = CanvasTemplateName, Type = typeof(Canvas))]
    public class RangeSlider
        : Control
    {
        #region Fields
        private const string Thumb1TemplateName = "PART_Thumb1";
        private const string Thumb2TemplateName = "PART_Thumb2";
        private const string CanvasTemplateName = "PART_Canvas";

        private Thumb _thumb1;
        private Thumb _thumb2;
        private Canvas _canvas;

        private bool _isInternalSet;
        #endregion

        #region Ctor
        static RangeSlider()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RangeSlider), new FrameworkPropertyMetadata(typeof(RangeSlider)));
        }
        #endregion

        #region Properties

        #region From
        public double From
        {
            get { return (double)GetValue(FromProperty); }
            set { SetValue(FromProperty, value); }
        }

        public static readonly DependencyProperty FromProperty =
            DependencyProperty.Register("From", typeof(double), typeof(RangeSlider), new PropertyMetadata(0d, OnFromChanged));
        #endregion

        #region To
        public double To
        {
            get { return (double)GetValue(ToProperty); }
            set { SetValue(ToProperty, value); }
        }

        public static readonly DependencyProperty ToProperty =
            DependencyProperty.Register("To", typeof(double), typeof(RangeSlider), new PropertyMetadata(0d, OnToChanged));
        #endregion

        #region Minimum
        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(double), typeof(RangeSlider), new PropertyMetadata(0d));
        #endregion

        #region Maximum
        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(double), typeof(RangeSlider), new PropertyMetadata(0d));
        #endregion

        #region TickBarThickness
        public double TickBarThickness
        {
            get { return (double)GetValue(TickBarThicknessProperty); }
            set { SetValue(TickBarThicknessProperty, value); }
        }

        public static readonly DependencyProperty TickBarThicknessProperty =
            DependencyProperty.Register("TickBarThickness", typeof(double), typeof(RangeSlider), new PropertyMetadata(4d));
        #endregion

        #region TickBarForeground
        public Brush TickBarForeground
        {
            get { return (Brush)GetValue(TickBarForegroundProperty); }
            set { SetValue(TickBarForegroundProperty, value); }
        }

        public static readonly DependencyProperty TickBarForegroundProperty =
            DependencyProperty.Register("TickBarForeground", typeof(Brush), typeof(RangeSlider));
        #endregion

        #region TrackThickness
        public double TrackThickness
        {
            get { return (double)GetValue(TrackThicknessProperty); }
            set { SetValue(TrackThicknessProperty, value); }
        }

        public static readonly DependencyProperty TrackThicknessProperty =
            DependencyProperty.Register("TrackThickness", typeof(double), typeof(RangeSlider), new PropertyMetadata(4d));
        #endregion

        #region TrackCornerRadius
        public CornerRadius TrackCornerRadius
        {
            get { return (CornerRadius)GetValue(TrackCornerRadiusProperty); }
            set { SetValue(TrackCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty TrackCornerRadiusProperty =
            DependencyProperty.Register("TrackCornerRadius", typeof(CornerRadius), typeof(RangeSlider));
        #endregion

        #region CoveredBackground
        public Brush CoveredBackground
        {
            get { return (Brush)GetValue(CoveredBackgroundProperty); }
            set { SetValue(CoveredBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CoveredBackgroundProperty =
            DependencyProperty.Register("CoveredBackground", typeof(Brush), typeof(RangeSlider));
        #endregion

        #region ThumbWidth
        public double ThumbWidth
        {
            get { return (double)GetValue(ThumbWidthProperty); }
            set { SetValue(ThumbWidthProperty, value); }
        }

        public static readonly DependencyProperty ThumbWidthProperty =
            DependencyProperty.Register("ThumbWidth", typeof(double), typeof(RangeSlider), new PropertyMetadata(20d));
        #endregion

        #region ThumbHeight
        public double ThumbHeight
        {
            get { return (double)GetValue(ThumbHeightProperty); }
            set { SetValue(ThumbHeightProperty, value); }
        }

        public static readonly DependencyProperty ThumbHeightProperty =
            DependencyProperty.Register("ThumbHeight", typeof(double), typeof(RangeSlider), new PropertyMetadata(20d));
        #endregion

        #region ThumbShadowColor
        public Color? ThumbShadowColor
        {
            get { return (Color?)GetValue(ThumbShadowColorProperty); }
            set { SetValue(ThumbShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ThumbShadowColorProperty =
            DependencyProperty.Register("ThumbShadowColor", typeof(Color?), typeof(RangeSlider));
        #endregion

        #region ThumbCornerRadius
        public CornerRadius ThumbCornerRadius
        {
            get { return (CornerRadius)GetValue(ThumbCornerRadiusProperty); }
            set { SetValue(ThumbCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ThumbCornerRadiusProperty =
            DependencyProperty.Register("ThumbCornerRadius", typeof(CornerRadius), typeof(RangeSlider));
        #endregion

        #region ThumbBackground
        public Brush ThumbBackground
        {
            get { return (Brush)GetValue(ThumbBackgroundProperty); }
            set { SetValue(ThumbBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ThumbBackgroundProperty =
            DependencyProperty.Register("ThumbBackground", typeof(Brush), typeof(RangeSlider));
        #endregion

        #region ThumbBorderBrush
        public Brush ThumbBorderBrush
        {
            get { return (Brush)GetValue(ThumbBorderBrushProperty); }
            set { SetValue(ThumbBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ThumbBorderBrushProperty =
            DependencyProperty.Register("ThumbBorderBrush", typeof(Brush), typeof(RangeSlider));
        #endregion

        #region ThumbBorderThickness
        public Thickness ThumbBorderThickness
        {
            get { return (Thickness)GetValue(ThumbBorderThicknessProperty); }
            set { SetValue(ThumbBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ThumbBorderThicknessProperty =
            DependencyProperty.Register("ThumbBorderThickness", typeof(Thickness), typeof(RangeSlider));
        #endregion

        #region ThumbStyle
        public Style ThumbStyle
        {
            get { return (Style)GetValue(ThumbStyleProperty); }
            set { SetValue(ThumbStyleProperty, value); }
        }

        public static readonly DependencyProperty ThumbStyleProperty =
            DependencyProperty.Register("ThumbStyle", typeof(Style), typeof(RangeSlider));
        #endregion

        #region IsTextVisible
        public bool IsTextVisible
        {
            get { return (bool)GetValue(IsTextVisibleProperty); }
            set { SetValue(IsTextVisibleProperty, value); }
        }

        public static readonly DependencyProperty IsTextVisibleProperty =
            DependencyProperty.Register("IsTextVisible", typeof(bool), typeof(RangeSlider));
        #endregion

        #region TextStringFormat
        public string TextStringFormat
        {
            get { return (string)GetValue(TextStringFormatProperty); }
            set { SetValue(TextStringFormatProperty, value); }
        }

        public static readonly DependencyProperty TextStringFormatProperty =
            DependencyProperty.Register("TextStringFormat", typeof(string), typeof(RangeSlider), new PropertyMetadata("N2", OnTextStringFormatChanged));

        #endregion

        #region TextSpacing
        public double TextSpacing
        {
            get { return (double)GetValue(TextSpacingProperty); }
            set { SetValue(TextSpacingProperty, value); }
        }

        public static readonly DependencyProperty TextSpacingProperty =
            DependencyProperty.Register("TextSpacing", typeof(double), typeof(RangeSlider));
        #endregion

        #endregion

        #region Internal Properties

        #region Thumb1Offset
        internal double Thumb1Offset
        {
            get { return (double)GetValue(Thumb1OffsetProperty); }
            set { SetValue(Thumb1OffsetProperty, value); }
        }

        internal static readonly DependencyProperty Thumb1OffsetProperty =
            DependencyProperty.Register("Thumb1Offset", typeof(double), typeof(RangeSlider), new PropertyMetadata(0d));
        #endregion

        #region Thumb2Offset
        internal double Thumb2Offset
        {
            get { return (double)GetValue(Thumb2OffsetProperty); }
            set { SetValue(Thumb2OffsetProperty, value); }
        }

        internal static readonly DependencyProperty Thumb2OffsetProperty =
            DependencyProperty.Register("Thumb2Offset", typeof(double), typeof(RangeSlider), new PropertyMetadata(1d));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _thumb1 = GetTemplateChild(Thumb1TemplateName) as Thumb;
            _thumb2 = GetTemplateChild(Thumb2TemplateName) as Thumb;
            _canvas = GetTemplateChild(CanvasTemplateName) as Canvas;

            _thumb1.DragDelta += Thumb_DragDelta;

            _thumb2.DragDelta += Thumb_DragDelta;
        }
        #endregion

        #region Event Handlers
        private static void OnFromChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var slider = (RangeSlider)d;
            slider.OnFromChanged();
        }

        private static void OnToChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var slider = (RangeSlider)d;
            slider.OnToChanged();
        }

        private void Thumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (_isInternalSet)
            {
                return;
            }

            _isInternalSet = true;
            var thumb = sender as Thumb;

            var actualWidth = Math.Max(1, _canvas.ActualWidth) - thumb.ActualWidth;
            var actualHeight = Math.Max(1, _canvas.ActualHeight) - thumb.ActualHeight;

            var left = Canvas.GetLeft(thumb);
            var top = Canvas.GetTop(thumb);

            left = Math.Max(0, Math.Min(actualWidth, left + e.HorizontalChange));
            top = Math.Max(0, Math.Min(actualHeight, top + e.VerticalChange));

            if (thumb == _thumb1)
            {
                SetCurrentValue(Thumb1OffsetProperty, Math.Round(left / actualWidth, 2));
            }
            else
            {
                SetCurrentValue(Thumb2OffsetProperty, Math.Round(left / actualWidth, 2));
            }
            _isInternalSet = false;
        }
        #endregion

        #region Functions
        private void OnFromChanged()
        {
            if (_isInternalSet)
            {
                return;
            }

            _isInternalSet = true;

            CoerceValue(MinimumProperty);
            CoerceValue(MaximumProperty);

            var offset = 0d;
            var delta = Math.Max(0, Maximum - Minimum);
            if(delta > 0)
            {
                offset = From / delta;
            }
            offset = Math.Min(1, Math.Max(0, offset));
            if(Thumb1Offset < Thumb2Offset)
            {
                SetCurrentValue(Thumb1OffsetProperty, offset);
            }
            else
            {
                SetCurrentValue(Thumb2OffsetProperty, offset);
            }

            _isInternalSet = false;
        }

        private void OnToChanged()
        {
            if (_isInternalSet)
            {
                return;
            }

            _isInternalSet = true;

            CoerceValue(MinimumProperty);
            CoerceValue(MaximumProperty);

            var offset = 0d;
            var delta = Math.Max(0, Maximum - Minimum);
            if (delta > 0)
            {
                offset = To / delta;
            }
            offset = Math.Min(1, Math.Max(0, offset));
            if (Thumb1Offset >= Thumb2Offset)
            {
                SetCurrentValue(Thumb1OffsetProperty, offset);
            }
            else
            {
                SetCurrentValue(Thumb2OffsetProperty, offset);
            }

            _isInternalSet = false;
        }

        private static void OnTextStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var slider = (RangeSlider)d;
        }
        #endregion
    }
}
