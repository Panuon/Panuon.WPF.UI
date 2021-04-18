using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System.Windows;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class Spinner : FrameworkElement
    {
        #region Fields
        private InternalSpinner _internalSpinner;
        #endregion

        #region Ctor
        static Spinner()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spinner), new FrameworkPropertyMetadata(typeof(Spinner)));
        }

        public Spinner()
        {
            _internalSpinner = new InternalSpinner();
            FrameworkElementUtil.BindingProperty(_internalSpinner, InternalSpinner.SpinnerStyleProperty, this, SpinnerStyleProperty);
            FrameworkElementUtil.BindingProperty(_internalSpinner, InternalSpinner.IsSpinningProperty, this, IsSpinningProperty);
            FrameworkElementUtil.BindingProperty(_internalSpinner, InternalSpinner.ForegroundProperty, this, GlyphBrushProperty);
            FrameworkElementUtil.BindingProperty(_internalSpinner, InternalSpinner.ThicknessProperty, this, GlyphSizeProperty);
            FrameworkElementUtil.BindingProperty(_internalSpinner, InternalSpinner.CornerRadiusProperty, this, GlyphCornerRadiusProperty);
            FrameworkElementUtil.BindingProperty(_internalSpinner, InternalSpinner.HeightProperty, this, ActualHeightProperty);
            FrameworkElementUtil.BindingProperty(_internalSpinner, InternalSpinner.WidthProperty, this, ActualWidthProperty);

            AddLogicalChild(_internalSpinner);
            AddVisualChild(_internalSpinner);
        }


        #endregion

        #region Overrides
        protected override int VisualChildrenCount => 1;

        protected override Visual GetVisualChild(int index)
        {
            return _internalSpinner;
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            _internalSpinner.Measure(availableSize);
            return _internalSpinner.DesiredSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            _internalSpinner.Arrange(new Rect(new Point(0, 0), finalSize));
            return base.ArrangeOverride(finalSize);
        }
        #endregion

        #region Properties

        #region SpinnerStyle
        public SpinnerStyle SpinnerStyle
        {
            get { return (SpinnerStyle)GetValue(SpinnerStyleProperty); }
            set { SetValue(SpinnerStyleProperty, value); }
        }

        public static readonly DependencyProperty SpinnerStyleProperty =
            DependencyProperty.Register("SpinnerStyle", typeof(SpinnerStyle), typeof(Spinner));
        #endregion

        #region IsSpinning
        public bool IsSpinning
        {
            get { return (bool)GetValue(IsSpinningProperty); }
            set { SetValue(IsSpinningProperty, value); }
        }

        public static readonly DependencyProperty IsSpinningProperty =
            DependencyProperty.Register("IsSpinning", typeof(bool), typeof(Spinner));
        #endregion

        #region GlyphBrush
        public Brush GlyphBrush
        {
            get { return (Brush)GetValue(GlyphBrushProperty); }
            set { SetValue(GlyphBrushProperty, value); }
        }

        public static readonly DependencyProperty GlyphBrushProperty =
            DependencyProperty.Register("GlyphBrush", typeof(Brush), typeof(Spinner));
        #endregion

        #region GlyphSize
        public double GlyphSize
        {
            get { return (double)GetValue(GlyphSizeProperty); }
            set { SetValue(GlyphSizeProperty, value); }
        }

        public static readonly DependencyProperty GlyphSizeProperty =
            DependencyProperty.Register("GlyphSize", typeof(double), typeof(Spinner));
        #endregion

        #region GlyphCornerRadius
        public double GlyphCornerRadius
        {
            get { return (double)GetValue(GlyphCornerRadiusProperty); }
            set { SetValue(GlyphCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty GlyphCornerRadiusProperty =
            DependencyProperty.Register("GlyphCornerRadius", typeof(double), typeof(Spinner));
        #endregion

        #endregion
    }
}
