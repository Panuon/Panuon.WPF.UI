using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsIntLessThanConverter
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (int.TryParse(value?.ToString(), out int intValue))
            {
                if (int.TryParse(parameter?.ToString(), out int intParameter))
                {
                    return intValue < intParameter;
                }
            }
            return false;
        }
    }
}
