using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class DoubleToThicknessConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && double.TryParse(value.ToString(), out double doubleValue))
            {
                switch (parameter?.ToString()?.ToLower())
                {
                    case "left":
                        return new Thickness(doubleValue, 0, 0, 0);
                    case "top":
                        return new Thickness(0, doubleValue, 0, 0);
                    case "right":
                        return new Thickness(0, 0, doubleValue, 0);
                    case "bottom":
                        return new Thickness(0, 0, 0, doubleValue);
                }
                return new Thickness(doubleValue);
            }
            return new Thickness();
        }
    }
}
