using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DoubleIsConverter
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (double.TryParse(value?.ToString(), out double newValue)
                && double.TryParse(parameter?.ToString(), out double param))
            {
                return newValue == param;
            }
            return false;
        }
    }
}