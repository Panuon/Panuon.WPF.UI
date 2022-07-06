using Panuon.UI.Core;
using System;
using System.Globalization;

namespace Panuon.UI.Silver.Internal.Converters
{
    public class ZoomViewerViewboxScaleConverter 
        : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var scale = (double)values[1];
            return actualWidth * scale;
        }
    }
}
