using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class SwitchToggleMarginConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var boxWidth = values[0] as double? ?? 0;
            var toggleWidth = values[1] as double? ?? 0;
            return new Thickness(0, 0, boxWidth - toggleWidth, 0);
        }
    }
}
