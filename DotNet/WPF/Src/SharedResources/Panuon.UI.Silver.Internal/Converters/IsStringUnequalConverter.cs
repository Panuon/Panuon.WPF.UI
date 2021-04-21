using Panuon.UI.Core;
using System;
using System.Globalization;

namespace Panuon.UI.Silver.Internal.Converters
{
    class IsStringUnequalConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = value?.ToString();
            var stringParameter = parameter?.ToString();
            return !((stringValue == null && stringParameter == null)
                || (stringValue != null && stringParameter != null && stringValue.Equals(stringParameter)));
        }
    }
}
