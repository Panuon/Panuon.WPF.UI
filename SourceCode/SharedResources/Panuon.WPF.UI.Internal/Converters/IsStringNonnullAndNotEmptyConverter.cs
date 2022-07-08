using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsStringNonnullAndNotEmptyConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is string stringValue && !string.IsNullOrEmpty(stringValue);
        }
    }
}
