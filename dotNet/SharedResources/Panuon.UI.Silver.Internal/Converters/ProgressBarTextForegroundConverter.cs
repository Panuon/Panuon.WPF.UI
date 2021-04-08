using Panuon.UI.Core;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Globalization;
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
            var foreground = values[8] as Brush;
            var inverseForeground = values[9] as Brush;
            var actualWidth = ((direction == ProgressDirection.LeftToRight || direction == ProgressDirection.RightToLeft) ? values[0] : values[1]) as double? ?? 0;
            var textWidth = ((direction == ProgressDirection.LeftToRight || direction == ProgressDirection.RightToLeft) ? values[2] : values[3]) as double? ?? 0;

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
                return inverseForeground;
            }

            var innerPercent = innerWidth / textWidth;
            switch (direction)
            {
                case ProgressDirection.RightToLeft:
                    return BrushUtil.GetStackedVisualBrush(foreground, inverseForeground, System.Windows.Controls.Orientation.Horizontal, 1 - innerPercent);
                case ProgressDirection.BottomToTop:
                    return BrushUtil.GetStackedVisualBrush(foreground, inverseForeground, System.Windows.Controls.Orientation.Vertical, 1 - innerPercent);
                case ProgressDirection.TopToBottom:
                    return BrushUtil.GetStackedVisualBrush(inverseForeground, foreground, System.Windows.Controls.Orientation.Vertical, innerPercent);
                default:
                    return BrushUtil.GetStackedVisualBrush(inverseForeground, foreground, System.Windows.Controls.Orientation.Horizontal, innerPercent);
            }
        }
    }
}
