using System;
using System.Globalization;
using System.Windows.Controls.Primitives;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DropDownOffsetConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var placement = (PlacementMode)values[0];
            var radius = (double)values[1];
            var type = (string)parameter;

            switch (type)
            {
                case "horizontal":
                    switch (placement)
                    {
                        case PlacementMode.Left:
                            return radius;
                        case PlacementMode.Top:
                        case PlacementMode.Right:
                        case PlacementMode.Bottom:
                            return -radius;
                    }
                    break;
                case "vertical":
                    switch (placement)
                    {
                        case PlacementMode.Top:
                            return radius;
                        case PlacementMode.Left:
                        case PlacementMode.Right:
                        case PlacementMode.Bottom:
                            return -radius;
                    }
                    break;
            }
            return 0d;
        }
    }
}
