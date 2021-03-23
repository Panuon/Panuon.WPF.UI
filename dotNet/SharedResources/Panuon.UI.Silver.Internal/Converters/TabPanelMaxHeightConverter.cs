using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class TabPanelMaxHeightConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var height = (double)values[0];
            var alignment = (VerticalAlignment)values[1];
            if(double.IsNaN(height) || alignment != VerticalAlignment.Stretch)
            {
                return double.PositiveInfinity;
            }
            var tabActualHeight = (double)values[2];
            if (double.IsNaN(tabActualHeight))
            {
                return double.PositiveInfinity;
            }
            var frontHeight = (double)values[3];
            var endHeight = (double)values[4];
            return tabActualHeight - frontHeight - endHeight;
        }
    }
}
