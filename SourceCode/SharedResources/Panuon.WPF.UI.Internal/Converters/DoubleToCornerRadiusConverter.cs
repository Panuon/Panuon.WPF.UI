using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DoubleToCornerRadiusConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && double.TryParse(value.ToString(), out double doubleValue))
            {
                return new CornerRadius(doubleValue);
            }
            return new CornerRadius(0);
        }
    }
}