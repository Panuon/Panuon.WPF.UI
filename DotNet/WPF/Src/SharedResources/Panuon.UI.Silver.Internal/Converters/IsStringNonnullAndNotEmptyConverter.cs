using Panuon.UI.Core;
using System;
using System.Globalization;

namespace Panuon.UI.Silver.Internal.Converters
{
    class IsStringNonnullAndNotEmptyConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is string stringValue && !string.IsNullOrEmpty(stringValue);
        }
    }
}
