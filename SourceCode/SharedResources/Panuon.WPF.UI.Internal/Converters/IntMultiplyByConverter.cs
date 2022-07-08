using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IntMultiplyByConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var intValue = value as int? ?? 0;
            if (parameter == null)
            {
                return intValue;
            }
            var para = int.Parse(parameter.ToString());
            return intValue * para;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var intValue = value as int? ?? 0;
            if (parameter == null)
            {
                return intValue;
            }
            var para = int.Parse(parameter.ToString());
            return intValue / para;
        }
    }
}
