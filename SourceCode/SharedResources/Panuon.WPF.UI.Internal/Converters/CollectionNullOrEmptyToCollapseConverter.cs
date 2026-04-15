using System;
using System.Collections;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    class CollectionNullOrEmptyToCollapseConverter
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return IsNullOrEmpty(value)
                ? Visibility.Collapsed
                : Visibility.Visible;
        }

        internal static bool IsNullOrEmpty(object value)
        {
            var enumerable = value as IEnumerable;
            if (enumerable == null)
            {
                return true;
            }

            var collection = value as ICollection;
            if (collection != null)
            {
                return collection.Count == 0;
            }

            var enumerator = enumerable.GetEnumerator();
            try
            {
                return enumerator == null || !enumerator.MoveNext();
            }
            finally
            {
                var disposable = enumerator as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
        }
    }
}
