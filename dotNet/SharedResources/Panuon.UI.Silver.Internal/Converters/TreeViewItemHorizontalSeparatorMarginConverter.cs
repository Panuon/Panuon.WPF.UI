using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class TreeViewItemHorizontalSeparatorMarginConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var togglePlacement = values[0] as ToggleArrowPlacement? ?? ToggleArrowPlacement.Left;
            var borderThickness = values[1] as Thickness? ?? new Thickness();
            var internalPadding = values[2] as Thickness? ?? new Thickness();
            var padding = values[3] as Thickness? ?? new Thickness();
            var toggleWidth = values[4] as double? ?? 0;
            var rulerThickness = values[5] as double? ?? 0;
            
            if (togglePlacement == ToggleArrowPlacement.Left)
            {
                return new Thickness(borderThickness.Left + internalPadding.Left - padding.Left / 2 + rulerThickness, 0, 0, 0);
            }
            else
            {
                return new Thickness(borderThickness.Left + internalPadding.Left  - padding.Left / 2 - rulerThickness, 0, 0, 0);
            }
        }
    }
}
