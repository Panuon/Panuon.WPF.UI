using Panuon.WPF;
using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsTypeConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.GetType()?.Name == parameter?.ToString();
        }
    }
}
