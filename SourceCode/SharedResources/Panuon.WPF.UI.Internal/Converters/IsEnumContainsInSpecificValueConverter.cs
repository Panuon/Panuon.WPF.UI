using System;
using System.Globalization;
using System.Linq;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsEnumContainsInSpecificValueConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
            {
                return false;
            }
            var enumValue = ((Enum)value).ToString();
            var values = parameter.ToString().Split(',');
            return values.Contains(enumValue);
        }
    }
}
