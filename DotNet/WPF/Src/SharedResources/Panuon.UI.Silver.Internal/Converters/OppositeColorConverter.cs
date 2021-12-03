using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class OppositeColorConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = (Color)value;
            var minValue = Math.Min(Math.Min(color.R, color.G), color.B);
            var oppositeValue = (byte)(minValue ^ 0xff);
            if(Math.Abs(minValue - oppositeValue) < 20)
            {
                oppositeValue = minValue < oppositeValue
                    ? (byte)(minValue + 20)
                    : (byte)(minValue - 20);
            }
            color = Color.FromRgb(oppositeValue, oppositeValue, oppositeValue);
            if (parameter is string param && param == "Brush")
            {
                var brush = new SolidColorBrush(color);
                brush.Freeze();
                return brush;
            }
            return color;
        }
    }
}
