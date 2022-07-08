using Panuon.WPF;
using System;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsAllEqualConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var lastObject = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                var obj = values[i];
                if((lastObject == null && obj != null)
                    || (lastObject != null && obj == null))
                {
                    return false;
                }
                if(lastObject != null && obj != null)
                {
                    if (!lastObject.Equals(obj))
                    {
                        return false;
                    }
                }
                lastObject = obj;
            }
            return true;
        }
    }
}
