using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class LightenSolidColorBrushConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var brush = value as SolidColorBrush;
            if (brush == null)
            {
                return value;
            }
            double.TryParse(parameter?.ToString(), out double percent);
            if (percent == 0)
            {
                percent = 1;
            }
            var color = brush.Color;
            if(color.A == 0)
            {
                return null;
            }   
            double a1 = 255 / 255.0, r1 = 255 / 255.0, g1 = 255 / 255.0, b1 = 255 / 255.0;
            double a2 = color.A / 255.0, r2 = color.R / 255.0, g2 = color.G / 255.0, b2 = color.B / 255.0;

            byte a = System.Convert.ToByte((a1 + (a2 - a1) * percent) * 255);
            byte r = System.Convert.ToByte((r1 + (r2 - r1) * percent) * 255);
            byte g = System.Convert.ToByte((g1 + (g2 - g1) * percent) * 255);
            byte b = System.Convert.ToByte((b1 + (b2 - b1) * percent) * 255);
            var newColor = Color.FromArgb(a, r, g, b);
            var newBrush = brush.CloneCurrentValue();
            newBrush.Color = newColor;
            return newBrush;
        }
    }
}
