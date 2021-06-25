using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class Arc2Converter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = values[0] as double? ?? 0;
            var actualHeight = values[1] as double? ?? 0;
            var size = Math.Min(actualHeight, actualWidth);
            if (actualWidth == 0 || actualWidth == 0)
            {
                return null;
            }
            var minimuim = values[2] as double? ?? 0;
            var maximuim = values[3] as double? ?? 0;
            var value = values[4] as double? ?? 0;
            var percent = (value - minimuim) / (maximuim - minimuim);
            var thickness = values[5] as double? ?? 0;

            var center = size / 2;
            var radius = actualWidth - thickness;
            var startX = center;
            var startY = thickness / 2;
            var endX = (radius / 2) * (Math.Cos((2 * percent - 0.5) * Math.PI)) + center;
            var endY = (center) - (radius / 2 * Math.Sin((2 * percent + 0.5) * Math.PI));
            var pathBuilder = new StringBuilder();
            if (percent > 0)
            {
                pathBuilder.Append($"M{startX},{startY} A{radius / 2},{radius / 2} 0 0 1 ");
                if (percent <= 0.5)
                    pathBuilder.Append($"{endX},{endY}");
                else
                    pathBuilder.Append($"{center},{radius + thickness / 2} A{radius / 2},{radius / 2} 0 0 1 {endX},{endY}");
            }

            return Geometry.Parse(pathBuilder.ToString());

        }
    }
}
