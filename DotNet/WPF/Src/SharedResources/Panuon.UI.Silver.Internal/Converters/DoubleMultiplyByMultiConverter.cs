using Panuon.UI.Core;
using System;
using System.Globalization;

namespace Panuon.UI.Silver.Internal.Converters
{
    class DoubleMultiplyByMultiConverter : MultiValueConverterBase
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
