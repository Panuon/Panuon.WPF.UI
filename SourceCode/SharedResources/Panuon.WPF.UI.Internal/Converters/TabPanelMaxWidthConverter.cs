using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class TabPanelMaxWidthConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var height = (double)values[0];
            var alignment = (HorizontalAlignment)values[1];
            if (double.IsNaN(height) || alignment != HorizontalAlignment.Stretch)
            {
                return double.PositiveInfinity;
            }
            var tabActualWidth = (double)values[2];
            if (double.IsNaN(tabActualWidth))
            {
                return double.PositiveInfinity;
            }
            var frontWidth = (double)values[3];
            var endWidth = (double)values[4];
            var backWidth = (double)values[5];
            var foreWidth = (double)values[6];
            return Math.Max(0, tabActualWidth - frontWidth - endWidth - backWidth - foreWidth);
        }
    }
}