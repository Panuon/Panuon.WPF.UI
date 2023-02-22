using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DoubleDivideByConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var doubleValue = value as double? ?? 0;
            if (parameter == null)
            {
                return doubleValue; 
            }
            var para = double.Parse(parameter.ToString());
            return doubleValue / para;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var doubleValue = value as double? ?? 0;
            if (parameter == null)
            {
                return doubleValue;
            }
            var para = double.Parse(parameter.ToString());
            return doubleValue * para;
        }
    }
}
