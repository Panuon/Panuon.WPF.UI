using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class ComboBoxDropDownHorizontalOffsetConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var blurRadius = (double)values[0];
            var offset = (double)values[1];
            var placement = (PopupXPlacement)values[2];
            var clipShadow = (bool)values[3];
            switch (placement)
            {
                case PopupXPlacement.Bottom:
                case PopupXPlacement.BottomRight:
                case PopupXPlacement.BottomLeft:
                case PopupXPlacement.Top:
                case PopupXPlacement.TopRight:
                case PopupXPlacement.TopLeft: 
                case PopupXPlacement.Left:
                case PopupXPlacement.LeftTop:
                case PopupXPlacement.LeftBottom:
                    return -blurRadius + offset;
                default:
                    return clipShadow ? offset : -blurRadius + offset;
            }
        }
    }
}
