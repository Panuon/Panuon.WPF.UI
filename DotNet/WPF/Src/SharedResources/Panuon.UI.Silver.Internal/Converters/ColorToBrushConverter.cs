using Panuon.UI.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class ColorToBrushConverter : ValueConverterBase
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
