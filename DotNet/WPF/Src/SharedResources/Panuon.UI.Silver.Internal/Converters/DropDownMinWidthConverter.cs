using Panuon.UI.Core;
using System;
using System.Globalization;

namespace Panuon.UI.Silver.Internal.Converters
{
    class DropDownMinWidthConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var blurRadius = (double)values[1];
            return actualWidth - blurRadius * 2;
        }
    }
}
