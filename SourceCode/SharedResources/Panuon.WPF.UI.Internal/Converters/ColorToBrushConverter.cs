using Panuon.WPF;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Converters
{
    class ColorToBrushConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return null;
            }
            return new SolidColorBrush((Color)value);
        }
    }
}
