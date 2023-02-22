using System;
using System.Globalization;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Converters
{
    class OppositeBrushConverter 
        : ValueConverterBase  
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            if(!(value is SolidColorBrush))
            {
                return Brushes.White;
            }

            var color = ((SolidColorBrush)value).Color;
            var minValue = Math.Min(Math.Min(color.R, color.G), color.B);
            var oppositeValue = (byte)(minValue ^ 0xff);
            if (Math.Abs(minValue - oppositeValue) < 20)
            {
                oppositeValue = minValue < oppositeValue
                    ? (byte)(minValue + 20)
                    : (byte)(minValue - 20);
            }
            color = Color.FromRgb(oppositeValue, oppositeValue, oppositeValue);
            var brush = new SolidColorBrush(color);
            brush.Freeze();
            return brush;
        }
    }
} 
