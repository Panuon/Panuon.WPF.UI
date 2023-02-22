using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class TrueToHiddenConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is bool boolean && boolean) ? Visibility.Hidden : Visibility.Visible;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is Visibility visibility && visibility == Visibility.Hidden;
        }
    }
}
