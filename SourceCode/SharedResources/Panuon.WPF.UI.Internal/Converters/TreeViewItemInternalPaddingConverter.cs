using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.WPF.UI.Internal.Converters
{
    internal class TreeViewItemInternalPaddingConverter 
        : OneWayMultiValueConverterBase
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
