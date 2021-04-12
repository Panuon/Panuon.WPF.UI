using Panuon.UI.Silver.Internal.Utils;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal
{
    class ClippingBorder : Border
    {
        #region Ctor
        public ClippingBorder()
        {
        }
        #endregion

        #region Properties

        #region CornerRadius
        public new CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public new static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ClippingBorder), new PropertyMetadata(OnCornerRadiusOrBorderThicknessChanged));
        #endregion

        #region BorderThickness
        public new Thickness BorderThickness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public new static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(ClippingBorder), new PropertyMetadata(OnCornerRadiusOrBorderThicknessChanged));
        #endregion

        #endregion

        #region Overrides
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            UpdateClip();
        }
        #endregion

        #region Event Handlers
        private static void OnCornerRadiusOrBorderThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var clippingBorder = (ClippingBorder)d;
            clippingBorder.OnCornerRadiusChanged();
        }
        #endregion

        #region Functions
        private void OnCornerRadiusChanged()
        {
            base.CornerRadius = CornerRadius;
            base.BorderThickness = BorderThickness;
            UpdateClip();
        }

        private void UpdateClip()
        {
            Clip = GeometryUtil.GetRoundRectangle(new Rect(RenderSize), BorderThickness, CornerRadius);
        }
        #endregion
    }
}
