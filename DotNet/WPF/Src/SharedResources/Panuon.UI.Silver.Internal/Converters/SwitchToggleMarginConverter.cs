using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class SwitchToggleMarginConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var boxWidth = values[0] as double? ?? 0;
            var toggleWidth = values[1] as double? ?? 0;
            return new Thickness(0, 0, boxWidth - toggleWidth, 0);
        }
    }
}
