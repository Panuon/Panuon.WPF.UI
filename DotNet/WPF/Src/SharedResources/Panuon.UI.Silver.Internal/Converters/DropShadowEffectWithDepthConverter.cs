using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Panuon.UI.Silver.Internal.Converters
{
    class DropShadowEffectWithDepthConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var color = (Color?)values[0];
            if (color == null)
            {
                return null;
            }

            var blurRadius = (double)values[1];
            var shadowDepth = (double)values[2];
            var shadowDirection = (double)values[3];
            var opacity = (double)values[4];
            Enum.TryParse(values[5]?.ToString(), out RenderingBias renderingBias);

            return new DropShadowEffect()
            {
                Color = (Color)color,
                ShadowDepth = shadowDepth,
                BlurRadius = blurRadius,
                Direction = shadowDirection,
                Opacity = opacity,
                RenderingBias = renderingBias,
            };
        }
    }

}
