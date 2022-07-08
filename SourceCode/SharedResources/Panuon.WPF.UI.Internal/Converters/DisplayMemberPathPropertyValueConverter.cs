using Panuon.WPF;
using System;
using System.Globalization;
using System.Reflection;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DisplayMemberPathPropertyValueConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var value = values[0];
            var displayMemberPath = (string)values[1];
            if (value == null || string.IsNullOrEmpty(displayMemberPath))
            {
                return value;
            }
            var type = value.GetType();
            var propertyInfo = type.GetProperty(displayMemberPath, BindingFlags.Public | BindingFlags.Instance);
            if(propertyInfo == null)
            {
                throw new Exception($"Can not find property names {propertyInfo.Name} in {type}");
            }
            return propertyInfo.GetValue(value, null);
        }
    }
}
