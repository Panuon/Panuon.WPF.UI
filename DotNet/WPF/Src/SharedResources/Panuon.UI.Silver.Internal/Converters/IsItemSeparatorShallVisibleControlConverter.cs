using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal.Converters
{
    class IsItemSeparatorShallVisibleControlConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var itemsControl = (ItemsControl)values[0];
            var item = (DependencyObject)values[1];
            return itemsControl.ItemContainerGenerator.IndexFromContainer(item) != itemsControl.Items.Count - 1;
        }
    }
}
