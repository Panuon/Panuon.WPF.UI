using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsFirstItemInItemsControlConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var item = values[0] as DependencyObject;
            var itemsControl = values[1] as ItemsControl;
            if (item != null
                && itemsControl != null)
            {
                return itemsControl.ItemContainerGenerator.IndexFromContainer(item) == 0;
            }

            return false;
        }
    }
}