using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DoubleToGridLengthConverter 
        : ValueConverterBase
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
            else if (value is string stringValue && !string.IsNullOrEmpty(stringValue))
            {
                stringValue = stringValue.Trim();
                if (stringValue.EndsWith("*"))
                {
                    stringValue = stringValue.Remove(stringValue.Length - 1);
                    if (string.IsNullOrEmpty(stringValue))
                    {
                        return new GridLength(1, GridUnitType.Star);
                    }
                    else if (int.TryParse(stringValue, out int starsResult))
                    {
                        return new GridLength(starsResult, GridUnitType.Star);
                    }
                }
            }
            return new GridLength(1, GridUnitType.Auto);
        }
    }
}
