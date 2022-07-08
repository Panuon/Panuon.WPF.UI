using Panuon.WPF;
using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    public class ZoomViewerViewboxScaleConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var scale = (double)values[1];
            return actualWidth * scale;
        }
    }
}
