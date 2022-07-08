using Panuon.WPF;
using System;
using System.Globalization;
using System.Linq;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DoubleEqualsConverter 
        : OneWayMultiValueConverterBase
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
