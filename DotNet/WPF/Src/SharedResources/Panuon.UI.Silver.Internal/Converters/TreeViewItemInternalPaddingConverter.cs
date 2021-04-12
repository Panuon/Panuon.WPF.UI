using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    internal class TreeViewItemInternalPaddingConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var parentPadding = values[0] as Thickness? ?? new Thickness(0);
            var padding = values[1] as Thickness? ?? new Thickness(0);
            padding.Left += parentPadding.Left;
            padding.Right += parentPadding.Right;
            return padding;
        }
    }
}
