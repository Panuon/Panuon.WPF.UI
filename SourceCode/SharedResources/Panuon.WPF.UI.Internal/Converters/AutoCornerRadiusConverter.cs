using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class AutoCornerRadiusConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var param = parameter.ToString();
            var width = (double)values[0];
            var height = (double)values[1];
            var size = Math.Min(width, height);

            var paramSplits = param.Split(',');
            return new CornerRadius(paramSplits[0] == "-" ? (size / 2) : double.Parse(paramSplits[0]),
                paramSplits[1] == "-" ? (size / 2) : double.Parse(paramSplits[1]),
                paramSplits[2] == "-" ? (size / 2) : double.Parse(paramSplits[2]),
                paramSplits[3] == "-" ? (size / 2) : double.Parse(paramSplits[3]));
        }
    }
}
