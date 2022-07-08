using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class FalseToHiddenConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is bool boolean && boolean) ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
