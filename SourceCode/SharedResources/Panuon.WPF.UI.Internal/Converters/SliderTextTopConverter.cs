using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class SliderTextTopConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var minimum = (double)values[0];
            var value = (double)values[1];
            var maximum = (double)values[2];
            var actualHeight = (double)values[3];
            var toggleHeight = (double)values[4];
            var textHeight = (double)values[5];

            var percent = 1 - (value - minimum) / (maximum - minimum);
            return (actualHeight - toggleHeight) * percent + toggleHeight / 2 - (textHeight / 2);
        }
    }
}
