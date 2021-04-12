using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class TabPanelMaxWidthConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var width = (double)values[0];
            var alignment = (HorizontalAlignment)values[1];
            if(double.IsNaN(width) || alignment != HorizontalAlignment.Stretch)
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
            return tabActualWidth - frontWidth - endWidth;
        }
    }
}
