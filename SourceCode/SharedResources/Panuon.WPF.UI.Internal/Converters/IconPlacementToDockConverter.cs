using System;
using System.Globalization;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IconPlacementToDockConverter
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Enum.Parse(typeof(Dock), value.ToString());
        }
    }
}
