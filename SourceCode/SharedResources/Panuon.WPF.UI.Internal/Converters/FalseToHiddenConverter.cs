using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class FalseToHiddenConverter : ValueConverterBase
    {
        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture
        )
        {
            return (bool.TryParse(value.ToString(), out var result) && result)
                ? Visibility.Visible
                : Visibility.Hidden;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture
        )
        {
            return value is Visibility visibility && visibility == Visibility.Hidden;
        }
    }
}
