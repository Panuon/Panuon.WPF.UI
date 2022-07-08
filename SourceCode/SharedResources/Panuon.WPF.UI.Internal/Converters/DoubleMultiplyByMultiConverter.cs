using Panuon.WPF;
using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DoubleMultiplyByMultiConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var result = 1d;
            foreach (double value in values)
            {
                result *= value;
            }
            return result;
        }
    }
}
