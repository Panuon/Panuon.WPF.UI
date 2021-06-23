using Panuon.UI.Core;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class ProgressBarTextForegroundConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var min = (double)values[4];
            var max = (double)values[5];
            var value = (double)values[6];
            var direction = (ProgressDirection)values[7];
            var orientation = (Orientation)values[8];
            var foreground = values[9] as Brush;
            var invertedForeground = values[10] as Brush;
            var actualWidth = (orientation == Orientation.Horizontal ? values[0] : values[1]) as double? ?? 0;
            var textWidth = (orientation == Orientation.Horizontal ? values[2] : values[3]) as double? ?? 0;

            if (textWidth == 0 || actualWidth == 0)
            {
                return foreground;
            }

            var totalPercent = ((value - min) / (max - min));
            var percentWidth = actualWidth * totalPercent;
            var innerWidth = percentWidth - ((actualWidth - textWidth) / 2);
            if (innerWidth <= 0)
            {
                return foreground;
            }
            else if (innerWidth >= textWidth)
            {
                return invertedForeground;
            }

            var innerPercent = innerWidth / textWidth;
            if (orientation == Orientation.Horizontal)
            {
                switch (direction)
                {
                    case ProgressDirection.Normal:
                        return BrushUtil.GetStackedVisualBrush(invertedForeground, foreground, Orientation.Horizontal, innerPercent);
                    case ProgressDirection.Inverse:
                        return BrushUtil.GetStackedVisualBrush(foreground, invertedForeground, Orientation.Horizontal, 1 - innerPercent);
                }
            }
            else
            {
                switch (direction)
                {
                    case ProgressDirection.Normal:
                        return BrushUtil.GetStackedVisualBrush(foreground, invertedForeground, Orientation.Vertical, 1 - innerPercent);
                    case ProgressDirection.Inverse:
                        return BrushUtil.GetStackedVisualBrush(invertedForeground, foreground, Orientation.Vertical, innerPercent);
                }
            }
            return null;
        }
    }
}
