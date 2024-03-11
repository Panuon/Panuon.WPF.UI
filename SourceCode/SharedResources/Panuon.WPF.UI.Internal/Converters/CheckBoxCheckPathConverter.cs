using Panuon.WPF.Internal.Utils;
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
            var path = $"M {NumberUtil.Format(actualWidth / 6)},{NumberUtil.Format(actualHeight * 7 / 12 - 1)} L{NumberUtil.Format(actualWidth / 2 - 1)},{NumberUtil.Format(actualHeight * 5 / 6 - 1)} L{NumberUtil.Format(actualWidth * 5 / 6)},{NumberUtil.Format(actualHeight * 3 / 12 - 1)}";
            return Geometry.Parse(path);
        }
    }
}
