using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class RangeSliderCanvasOffsetConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var offset = (double)values[0];
            var size = (double)values[1];
            var selfSize = (double)values[2];
            return (size - selfSize) * offset;
        }
    }
}
