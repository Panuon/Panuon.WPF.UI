using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DrawerContentMarginConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var shadowColor = (Color?)values[0];
            var blurRadius = (double)values[1];
            var placement = (DrawerPlacement)values[2];
            if (shadowColor != null)
            {
                switch (placement)
                {
                    case DrawerPlacement.Left:
                        return new Thickness(0, 0, blurRadius, 0);
                    case DrawerPlacement.Top:
                        return new Thickness(0, 0, 0, blurRadius);
                    case DrawerPlacement.Right:
                        return new Thickness(blurRadius, 0, 0, 0);
                    case DrawerPlacement.Bottom:
                        return new Thickness(0, blurRadius, 0, 0);
                }
            }
            return new Thickness();
        }
    }
}
