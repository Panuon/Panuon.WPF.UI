using Panuon.UI.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class BrushToColorConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                if (parameter != null)
                {
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString(parameter as string));
                }
                return null;
            }
            return new SolidColorBrush((Color)value);
        }
    }
}
