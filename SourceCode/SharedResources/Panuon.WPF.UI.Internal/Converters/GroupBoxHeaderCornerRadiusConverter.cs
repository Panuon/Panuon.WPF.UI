using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class GroupBoxHeaderCornerRadiusConverter
    : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cornerRadius = (CornerRadius)value;

            return new CornerRadius(Math.Max(0, cornerRadius.TopLeft),
                Math.Max(0, cornerRadius.TopRight),
                0,
                0);
        }
    }
}
