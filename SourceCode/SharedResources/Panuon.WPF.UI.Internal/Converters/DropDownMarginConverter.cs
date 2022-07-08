using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DropDownMarginConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var blurRadius = (double)value; ;
            return new Thickness(blurRadius);
        }
    }
}
