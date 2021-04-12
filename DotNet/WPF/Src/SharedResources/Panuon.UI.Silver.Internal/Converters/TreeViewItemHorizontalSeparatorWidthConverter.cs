using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class TreeViewItemHorizontalSeparatorWidthConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var arrowPlacement = values[0] as ToggleArrowPlacement? ?? ToggleArrowPlacement.Left;
            var padding = values[1] as Thickness? ?? new Thickness();
            var toggleWidth = values[2] as double? ?? 0;
            if(arrowPlacement == ToggleArrowPlacement.Left)
            {
                return toggleWidth / 2 + toggleWidth;
            }
            else
            {
                return padding.Left / 2;
            }
        }
    }
}
