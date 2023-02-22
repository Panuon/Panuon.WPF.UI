using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsStringEqualToConverter
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = value?.ToString();
            var stringParameter = parameter?.ToString();
            return (stringValue == null && stringParameter == null)
                || (stringValue != null && stringParameter != null && stringValue.Equals(stringParameter));
        }
    }
}
