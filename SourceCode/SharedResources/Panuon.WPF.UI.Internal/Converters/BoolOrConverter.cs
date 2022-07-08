using Panuon.WPF;
using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class BoolOrConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach(var value in values)
            {
                if(bool.TryParse(value?.ToString(), out bool result)
                    && result)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
