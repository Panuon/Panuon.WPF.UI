using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Panuon.WPF.UI.Internal.Converters
{
    class StringNullOrEmptyToHiddenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = value as string;
            return string.IsNullOrEmpty(text) ? Visibility.Hidden : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
