using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    internal class TreeViewInternalPaddingConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var padding = value as Thickness? ?? new Thickness(0);
            return new Thickness(-padding.Left / 2, -padding.Top / 2, -padding.Right / 2, -padding.Bottom / 2);
        }
    }
}
