using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class ScrollableControlScrollButtonVisibilityConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var extentWidth = (double)values[1];
            return extentWidth > actualWidth ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
