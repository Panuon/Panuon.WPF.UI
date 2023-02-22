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
            var itemsControl = (ItemsControl)values[0];
            var item = (DependencyObject)values[1];
            return itemsControl.ItemContainerGenerator.IndexFromContainer(item) != itemsControl.Items.Count - 1;
        }
    }
}
