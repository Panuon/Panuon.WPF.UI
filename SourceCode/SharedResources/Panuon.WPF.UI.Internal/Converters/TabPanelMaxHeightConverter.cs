using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class TabPanelMaxHeightConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var tabActualHeight = (double)values[2];
            var frontHeight = (double)values[3];
            var endHeight = (double)values[4];
            return Math.Max(0, tabActualHeight - frontHeight - endHeight);
        }
    }
}
