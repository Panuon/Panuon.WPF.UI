using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    internal class ProgressBarIndeterminateMarginConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var trackWidth = (double)values[0];
            var fillingWidth = (double)values[1];
            return new Thickness(0, 0, trackWidth - fillingWidth, 0);
        }
    }
}