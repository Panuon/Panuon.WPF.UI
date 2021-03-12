using System.Windows;
using System.Windows.Media.Effects;

namespace Panuon.UI.Silver
{
    public static class ShadowHelper
    {
        #region Properties

        #region BlurRadius
        public static double GetBlurRadius(UIElement element)
        {
            return (double)element.GetValue(BlurRadiusProperty);
        }

        public static void SetBlurRadius(UIElement element, double value)
        {
            element.SetValue(BlurRadiusProperty, value);
        }

        public static readonly DependencyProperty BlurRadiusProperty =
            DependencyProperty.RegisterAttached("BlurRadius", typeof(double), typeof(ShadowHelper), new PropertyMetadata(10.0));
        #endregion

        #region ShadowDepth
        public static double GetShadowDepth(UIElement element)
        {
            return (double)element.GetValue(ShadowDepthProperty);
        }

        public static void SetShadowDepth(UIElement element, double value)
        {
            element.SetValue(ShadowDepthProperty, value);
        }

        public static readonly DependencyProperty ShadowDepthProperty =
            DependencyProperty.RegisterAttached("ShadowDepth", typeof(double), typeof(ShadowHelper), new PropertyMetadata(0.0));
        #endregion

        #region Direction
        public static double GetDirection(UIElement element)
        {
            return (double)element.GetValue(DirectionProperty);
        }

        public static void SetDirection(UIElement element, double value)
        {
            element.SetValue(DirectionProperty, value);
        }

        public static readonly DependencyProperty DirectionProperty =
            DependencyProperty.RegisterAttached("Direction", typeof(double), typeof(ShadowHelper), new PropertyMetadata(315.0));
        #endregion

        #region Opacity
        public static double GetOpacity(UIElement element)
        {
            return (double)element.GetValue(OpacityProperty);
        }

        public static void SetOpacity(UIElement element, double value)
        {
            element.SetValue(OpacityProperty, value);
        }

        public static readonly DependencyProperty OpacityProperty =
            DependencyProperty.RegisterAttached("Opacity", typeof(double), typeof(ShadowHelper), new PropertyMetadata(1.0));
        #endregion

        #region RenderingBias
        public static RenderingBias GetRenderingBias(UIElement element)
        {
            return (RenderingBias)element.GetValue(RenderingBiasProperty);
        }

        public static void SetRenderingBias(UIElement element, RenderingBias value)
        {
            element.SetValue(RenderingBiasProperty, value);
        }

        public static readonly DependencyProperty RenderingBiasProperty =
            DependencyProperty.RegisterAttached("RenderingBias", typeof(RenderingBias), typeof(ShadowHelper), new PropertyMetadata(RenderingBias.Performance));
        #endregion

        #endregion
    }
}
