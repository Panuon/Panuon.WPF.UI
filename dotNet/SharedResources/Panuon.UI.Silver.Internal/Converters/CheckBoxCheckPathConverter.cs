using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class CheckBoxCheckPathConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var actualHeight = (double)values[1];
            if (actualHeight == 0 || actualHeight == 0)
            {
                return null;
            }
            var path = $"M {actualWidth / 6},{ actualHeight * 7 / 12 - 1} L{actualWidth / 2 - 1},{actualHeight * 5 / 6 - 1} L{ actualWidth * 5 / 6},{actualHeight * 3 / 12 - 1}";
            return Geometry.Parse(path);
        }
    }
}
