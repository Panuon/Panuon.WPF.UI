using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Converters
{
    class SliderBorderClipConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var width = (double)values[0];
            var height = (double)values[1];
            var rptWidth = (double)values[2];
            var rptHeight = (double)values[3];
            var orientation = (Orientation)values[4];
            var toggleWidth = (double)values[5];
            var toggleHeight = (double)values[6];
            var cornerRadius = (double)values[7];

            var rect = new Rect();
            if (orientation == Orientation.Horizontal)
            {
                rect = new Rect(0, 0, rptWidth + toggleWidth / 2, rptHeight);
            }
            else
            {
                rect = new Rect(0, height - rptHeight - toggleHeight / 2, width, rptHeight + toggleHeight / 2);
            }

            var geometry = new RectangleGeometry(rect, cornerRadius, cornerRadius);
            geometry.Freeze();
            return geometry;
        }
    }
}
