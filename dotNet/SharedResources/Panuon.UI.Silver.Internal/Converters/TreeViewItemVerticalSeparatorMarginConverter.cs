using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class TreeViewItemVerticalSeparatorMarginConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var padding = values[0] as Thickness? ?? new Thickness();
            var actualWidth = values[1] as double? ?? 0;
            return new Thickness(padding.Left + actualWidth / 2, 0, 0, 0);
        }
    }
}
