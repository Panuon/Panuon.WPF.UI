using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsItemSeparatorShallVisibleControlConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is ItemsControl itemsControl
                && values[1] is DependencyObject item)
            {
                return itemsControl.ItemContainerGenerator.IndexFromContainer(item) != itemsControl.Items.Count - 1;
            }
            return Visibility.Visible;
        }
    }
}