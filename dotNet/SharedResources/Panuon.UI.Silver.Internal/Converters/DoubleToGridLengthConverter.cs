using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class DoubleToGridLengthConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && double.TryParse(value.ToString(), out double doubleValue))
            {
                if (double.IsNaN(doubleValue))
                {
                    return new GridLength(1, GridUnitType.Auto);
                }
                else if (double.IsInfinity(doubleValue))
                {
                    return new GridLength(1, GridUnitType.Star);
                }
                return new GridLength(doubleValue, GridUnitType.Pixel);
            }
            return new GridLength(1, GridUnitType.Auto);
        }
    }
}
