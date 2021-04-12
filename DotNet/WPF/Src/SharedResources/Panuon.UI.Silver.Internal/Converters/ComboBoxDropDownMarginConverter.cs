using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class ComboBoxDropDownMarginConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var blurRadius = (double)values[0];
            var placement = (PopupXPlacement)values[1];
            var clipShadow = (bool)values[2];
            switch (placement)
            {
                case PopupXPlacement.Bottom:
                case PopupXPlacement.BottomRight:
                case PopupXPlacement.BottomLeft:
                    return new Thickness(blurRadius, clipShadow ? 0 : blurRadius, blurRadius, blurRadius);
                case PopupXPlacement.Left:
                case PopupXPlacement.LeftTop:
                case PopupXPlacement.LeftBottom:
                    return new Thickness(blurRadius, blurRadius, clipShadow ? 0 : blurRadius, blurRadius);
                case PopupXPlacement.Top:
                case PopupXPlacement.TopRight:
                case PopupXPlacement.TopLeft:
                    return new Thickness(blurRadius, blurRadius, blurRadius, clipShadow ? 0 : blurRadius);
                case PopupXPlacement.Right:
                case PopupXPlacement.RightTop:
                case PopupXPlacement.RightBottom:
                    return new Thickness(clipShadow ? 0 : blurRadius, blurRadius, blurRadius, blurRadius);
            }
            return new Thickness(0);
        }
    }
}
