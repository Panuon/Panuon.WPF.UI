using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class BrushOpacityConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var brush = (Brush)value;
            var newBrush = brush.CloneCurrentValue();
            if(double.TryParse(parameter?.ToString(), out double opacity))
            {
                newBrush.Opacity = opacity;
            }
            if (newBrush.CanFreeze)
            {
                newBrush.Freeze();
            }
            return newBrush;
        }
    }
}
