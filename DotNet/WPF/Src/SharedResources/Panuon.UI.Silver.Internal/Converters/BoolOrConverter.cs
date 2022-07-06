using Panuon.UI.Core;
using System;
using System.Globalization;

namespace Panuon.UI.Silver.Internal.Converters
{
    class BoolOrConverter
        : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach(var value in values)
            {
                if(bool.TryParse(value?.ToString(), out bool result)
                    && result)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
