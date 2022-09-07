using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Converters
{
    class CheckBoxCheckPathConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var actualHeight = (double)values[1];
            if (actualWidth == 0 || actualHeight == 0)
            {
                return null;
            }
            var path = $"M {actualWidth / 6},{actualHeight * 7 / 12 - 1} L{actualWidth / 2 - 1},{actualHeight * 5 / 6 - 1} L{actualWidth * 5 / 6},{actualHeight * 3 / 12 - 1}";
            return Geometry.Parse(path);
        }
    }
}
