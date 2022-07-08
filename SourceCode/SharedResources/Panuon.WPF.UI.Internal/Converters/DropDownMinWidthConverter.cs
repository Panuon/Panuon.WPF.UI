using Panuon.WPF;
using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DropDownMinWidthConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var blurRadius = (double)values[1];
            return Math.Max(0, actualWidth - blurRadius * 2);
        }
    }
}
