using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class DoubleHalfToCornerRadiusConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && double.TryParse(value.ToString(), out double doubleValue))
            {
                return new CornerRadius(doubleValue / 2);
            }
            return new CornerRadius(0);
        }
    }
}