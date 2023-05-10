using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Media;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class BubblePathConverter
       : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = values[0] as double? ?? 0;
            var actualHeight = values[1] as double? ?? 0;
            var radius = values[2] as double? ?? 0;
            var toggleSize = values[3] as double? ?? 5;
            var thickness = values[4] as double? ?? 0;

            var halfThickness = thickness / 2;

            var pathBuilder = new StringBuilder();
            pathBuilder.Append($@"M{radius + halfThickness},{halfThickness}
H {actualWidth - radius - halfThickness}
A {radius},{radius} 0 0 1 {actualWidth - halfThickness},{radius + halfThickness}
V {actualHeight - radius - toggleSize} 
A {radius},{radius} 0 0 1 {actualWidth - radius - halfThickness},{actualHeight - toggleSize}
H {actualWidth / 2 + toggleSize / 2}
L {actualWidth / 2},{actualHeight}
L {actualWidth / 2 - toggleSize / 2},{actualHeight - toggleSize}
H {radius + halfThickness}
A {radius},{radius} 0 0 1 {halfThickness},{actualHeight - toggleSize - radius}
V {radius + halfThickness}
A {radius},{radius} 0 0 1 {radius + halfThickness},{halfThickness}");
            return Geometry.Parse(pathBuilder.ToString());
        }
    }
}
