using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal.Converters
{
    class GetIndexOfItemsControlConverter
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var index = 0;
            var startIndex = 0;
            if (parameter != null
                && int.TryParse(parameter.ToString(), out int start))
            {
                startIndex = start;
            }

            var item = values[0] as DependencyObject;
            var itemsControl = values[1] as ItemsControl;
            if (item != null
                && itemsControl != null)
            {
                index = itemsControl.ItemContainerGenerator.IndexFromContainer(item);
            }

            return index + startIndex;
        }
    }
}