using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal.Converters
{
    class DataGridSelectionUnitIsNotFullRowConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var unit = value as DataGridSelectionUnit? ?? DataGridSelectionUnit.FullRow;
            return unit != DataGridSelectionUnit.FullRow;
        }
    }

}
