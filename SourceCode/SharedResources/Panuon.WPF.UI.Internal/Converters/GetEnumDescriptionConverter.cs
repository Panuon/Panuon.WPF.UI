using Panuon.WPF;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Linq;

namespace Panuon.WPF.UI.Internal.Converters
{
    class GetEnumDescriptionConverter
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return false;
            }
            var enumValue = ((Enum)value);
            var description = enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), true)
                .FirstOrDefault() as DescriptionAttribute;
            return description?.Description;
        }
    }
}
