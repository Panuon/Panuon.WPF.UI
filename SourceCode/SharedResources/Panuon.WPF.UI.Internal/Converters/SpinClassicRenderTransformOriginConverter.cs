using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class InternalSpinClassicRenderTransformOriginConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var height = values[0] as double? ?? 0;
            var thickness = values[1] as double? ?? 0;
            return new Point(0.5, -(height / 2 - thickness) / thickness);
        }
    }
}