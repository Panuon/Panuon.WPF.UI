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
            var enumerable = (IEnumerable)value;
            if (enumerable == null)
            {
                return false;
            }
            var enumerator = enumerable.GetEnumerator();
            return enumerator.MoveNext();
        }
    }
}