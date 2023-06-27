using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Panuon.WPF.UI.Internal.Converters
{
    public class BoolToVisibilityToggleConverter : IMultiValueConverter
    {
        private readonly Dictionary<int, bool> sr_toggles = new Dictionary<int, bool>();

        public object Convert(
            object[] values,
            Type targetType,
            object parameter,
            CultureInfo culture
        )
        {
            if (values is null || values.Length < 2)
                throw new ArgumentException($"{nameof(values)} min length is 2");
            if (values[1] is bool value)
            {
                var hashCode = values[0].GetHashCode();
                if (bool.TryParse(values[2].ToString(), out var execute) && execute is true)
                {
                    if (sr_toggles.TryGetValue(hashCode, out var toggle) is false)
                    {
                        toggle = value;
                        sr_toggles.Add(hashCode, toggle);
                        return BoolToVisibility(toggle);
                    }
                    else
                    {
                        if (value is false)
                            return BoolToVisibility(toggle);
                        return BoolToVisibility(sr_toggles[hashCode] = !toggle);
                    }
                }
                else
                    return BoolToVisibility(value);
            }
            else
                throw new ArgumentException($"{nameof(values)}[0] must be bool", nameof(values));
        }

        private static Visibility BoolToVisibility(bool value)
        {
            if (value is true)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object[] ConvertBack(
            object value,
            Type[] targetTypes,
            object parameter,
            CultureInfo culture
        )
        {
            throw new NotImplementedException();
        }
    }
}
