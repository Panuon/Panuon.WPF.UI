using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Linq;

namespace Panuon.UI.Silver.Internal.Converters
{
    class DoubleEqualsConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double? lastValue = null;

            foreach(var value in values)
            {
                if(double.TryParse(value?.ToString(), out double newValue))
                {
                    if(lastValue != null)
                    {
                        if(lastValue != newValue)
                        {
                            return false;
                        }
                    }
                    lastValue = newValue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
