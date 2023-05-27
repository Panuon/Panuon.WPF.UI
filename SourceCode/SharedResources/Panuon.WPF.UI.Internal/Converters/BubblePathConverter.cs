using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Media;
using System.Windows;
using Panuon.WPF.UI.Internal.Utils;

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
            pathBuilder.Append($@"M{NumberUtil.Format(radius + halfThickness)},{NumberUtil.Format(halfThickness)}
H {NumberUtil.Format(actualWidth - radius - halfThickness)}
A {NumberUtil.Format(radius)},{NumberUtil.Format(radius)} 0 0 1 {NumberUtil.Format(actualWidth - halfThickness)},{NumberUtil.Format(radius + halfThickness)}
V {NumberUtil.Format(actualHeight - radius - toggleSize)} 
A {NumberUtil.Format(radius)},{NumberUtil.Format(radius)} 0 0 1 {NumberUtil.Format(actualWidth - radius - halfThickness)},{NumberUtil.Format(actualHeight - toggleSize)}
H {NumberUtil.Format(actualWidth / 2 + toggleSize / 2)}
L {NumberUtil.Format(actualWidth / 2)},{NumberUtil.Format(actualHeight)}
L {NumberUtil.Format(actualWidth / 2 - toggleSize / 2)},{NumberUtil.Format(actualHeight - toggleSize)}
H {NumberUtil.Format(radius + halfThickness)}
A {NumberUtil.Format(radius)},{NumberUtil.Format(radius)} 0 0 1 {NumberUtil.Format(halfThickness)},{NumberUtil.Format(actualHeight - toggleSize - radius)}
V {NumberUtil.Format(radius + halfThickness)}
A {NumberUtil.Format(radius)},{NumberUtil.Format(radius)} 0 0 1 {NumberUtil.Format(radius + halfThickness)},{NumberUtil.Format(halfThickness)}");
            return Geometry.Parse(pathBuilder.ToString());
        }
    }
}
