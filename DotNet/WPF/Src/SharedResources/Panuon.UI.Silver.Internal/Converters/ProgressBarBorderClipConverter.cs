using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Panuon.UI.Silver.Internal.Converters
{
    class ProgressBarBorderClipConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var width = (double)values[0];
            var height = (double)values[1];
            var min = (double)values[2];
            var max = (double)values[3];
            var value = (double)values[4];
            var direction = (ProgressDirection)values[5];
            var orientation = (Orientation)values[6];


            var percent = (value - min) / (max - min);

            var rect = new Rect();
            if (orientation == Orientation.Horizontal)
            {
                switch (direction)
                {
                    case ProgressDirection.Normal:
                        rect = new Rect(0, 0, width * percent, height);
                        break;
                    case ProgressDirection.Inverse:
                        rect = new Rect(width * (1 - percent), 0, width * percent, height);
                        break;
                }
            }
            else
            {
                switch (direction)
                {
                    case ProgressDirection.Normal:
                        rect = new Rect(0, height * (1 - percent), width, height * percent);
                        break;
                    case ProgressDirection.Inverse:
                        rect = new Rect(0, 0, width, height * percent);
                        break;
                }
            }

            var geometry = new RectangleGeometry(rect);
            geometry.Freeze();
            return geometry;
        }
    }
}
