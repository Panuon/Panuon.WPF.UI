using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal.Converters
{
    class IsLastItemInItemsControlConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var item = values[0] as DependencyObject;
            var itemsCount = values[1];

            var itemsControl = ItemsControl.ItemsControlFromItemContainer(item);
            return itemsControl.ItemContainerGenerator.IndexFromContainer(item) == itemsControl.Items.Count - 1;
        }
    }
}
