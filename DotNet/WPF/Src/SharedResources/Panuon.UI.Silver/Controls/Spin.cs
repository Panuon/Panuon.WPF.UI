using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System.Windows;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class Spin : FrameworkElement
    {
        #region Fields
        private InternalSpin _internalSpin;
        #endregion

        #region Ctor
        static Spin()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spin), new FrameworkPropertyMetadata(typeof(Spin)));
            FocusableProperty.OverrideMetadata(typeof(Spin), new FrameworkPropertyMetadata(false));
        }

        public Spin()
        {
            _internalSpin = new InternalSpin();
            FrameworkElementUtil.BindingProperty(_internalSpin, InternalSpin.SpinStyleProperty, this, SpinStyleProperty);
            FrameworkElementUtil.BindingProperty(_internalSpin, InternalSpin.IsSpinningProperty, this, IsSpinningProperty);
            FrameworkElementUtil.BindingProperty(_internalSpin, InternalSpin.ForegroundProperty, this, GlyphBrushProperty);
            FrameworkElementUtil.BindingProperty(_internalSpin, InternalSpin.ThicknessProperty, this, GlyphSizeProperty);
            FrameworkElementUtil.BindingProperty(_internalSpin, InternalSpin.CornerRadiusProperty, this, GlyphCornerRadiusProperty);
            FrameworkElementUtil.BindingProperty(_internalSpin, InternalSpin.HeightProperty, this, ActualHeightProperty);
            FrameworkElementUtil.BindingProperty(_internalSpin, InternalSpin.WidthProperty, this, ActualWidthProperty);

            AddLogicalChild(_internalSpin);
            AddVisualChild(_internalSpin);
        }


        #endregion

        #region Overrides
        protected override int VisualChildrenCount => 1;

        protected override Visual GetVisualChild(int index)
        {
            return _internalSpin;
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            _internalSpin.Measure(availableSize);
            return _internalSpin.DesiredSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            _internalSpin.Arrange(new Rect(new Point(0, 0), finalSize));
            return base.ArrangeOverride(finalSize);
        }
        #endregion

        #region Properties

        #region SpinStyle
        public SpinStyle SpinStyle
        {
            get { return (SpinStyle)GetValue(SpinStyleProperty); }
            set { SetValue(SpinStyleProperty, value); }
        }

        public static readonly DependencyProperty SpinStyleProperty =
            DependencyProperty.Register("SpinStyle", typeof(SpinStyle), typeof(Spin));
        #endregion

        #region IsSpinning
        public bool IsSpinning
        {
            get { return (bool)GetValue(IsSpinningProperty); }
            set { SetValue(IsSpinningProperty, value); }
        }

        public static readonly DependencyProperty IsSpinningProperty =
            DependencyProperty.Register("IsSpinning", typeof(bool), typeof(Spin));
        #endregion

        #region GlyphBrush
        public Brush GlyphBrush
        {
            get { return (Brush)GetValue(GlyphBrushProperty); }
            set { SetValue(GlyphBrushProperty, value); }
        }

        public static readonly DependencyProperty GlyphBrushProperty =
            DependencyProperty.Register("GlyphBrush", typeof(Brush), typeof(Spin));
        #endregion

        #region GlyphSize
        public double GlyphSize
        {
            get { return (double)GetValue(GlyphSizeProperty); }
            set { SetValue(GlyphSizeProperty, value); }
        }

        public static readonly DependencyProperty GlyphSizeProperty =
            DependencyProperty.Register("GlyphSize", typeof(double), typeof(Spin));
        #endregion

        #region GlyphCornerRadius
        public double GlyphCornerRadius
        {
            get { return (double)GetValue(GlyphCornerRadiusProperty); }
            set { SetValue(GlyphCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty GlyphCornerRadiusProperty =
            DependencyProperty.Register("GlyphCornerRadius", typeof(double), typeof(Spin));
        #endregion

        #endregion
    }
}
