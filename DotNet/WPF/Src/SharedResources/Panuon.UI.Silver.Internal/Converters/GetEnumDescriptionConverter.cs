using Panuon.UI.Core;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Panuon.UI.Silver.Internal.Converters
{
    class GetEnumDescriptionConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return false;
            }
            var enumValue = ((Enum)value);
            var description = enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttribute<DescriptionAttribute>();
            return description.Description;
        }
    }
}
