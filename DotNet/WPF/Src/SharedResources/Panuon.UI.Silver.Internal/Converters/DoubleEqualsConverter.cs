using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Linq;

namespace Panuon.UI.Silver.Internal.Converters
{
    public class DoubleEqualsConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var lastValue = double.Parse(values[0].ToString());
            foreach(var value in values)
            {
                var doubleValue = double.Parse(value.ToString());
                if(lastValue != doubleValue)
                {
                    return false;
                }
                lastValue = doubleValue;
            }
            return true;
        }
    }
}
