using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal.Converters
{
    class DataGridSelectionUnitIsNotFullRowConverter 
        : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var unit = value as DataGridSelectionUnit? ?? DataGridSelectionUnit.FullRow;
            return unit != DataGridSelectionUnit.FullRow;
        }
    }

}
