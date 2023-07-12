using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class TabControlScrollButtonVisibilityConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var containerWidth = (double)values[1];
            var frontWidth = (double)values[2];
            var endWidth = (double)values[3];
            var contentWidth = containerWidth + frontWidth + endWidth;

            if(contentWidth > actualWidth
                && Math.Abs(actualWidth - contentWidth) > 1)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }
    }
}
