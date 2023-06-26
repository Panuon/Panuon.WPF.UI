using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IconVisibilityConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var icon = values[0];
            var hidden = (bool)values[1];
            return icon == null
                ? (hidden ? Visibility.Hidden : Visibility.Collapsed)
                : Visibility.Visible;
        }
    }
}
