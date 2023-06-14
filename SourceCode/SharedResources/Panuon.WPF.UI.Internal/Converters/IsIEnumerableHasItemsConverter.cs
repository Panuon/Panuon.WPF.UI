using System;
using System.Collections;
using System.Globalization;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsIEnumerableHasItemsConverter
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is IEnumerable enumerable)
            {
                var enumerator = enumerable.GetEnumerator();
                return enumerator.MoveNext();
            }
            return false;
        }
    }
}