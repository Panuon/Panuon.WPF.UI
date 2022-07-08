using Panuon.WPF;
using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class SliderTextLeftConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var minimum = (double)values[0];
            var value = (double)values[1];
            var maximum = (double)values[2];
            var actualWidth = (double)values[3];
            var toggleWidth = (double)values[4];
            var textWidth = (double)values[5];

            var percent = (value - minimum) / (maximum - minimum);
            return (actualWidth - toggleWidth) * percent + toggleWidth / 2 - (textWidth / 2);
        }
    }
}
