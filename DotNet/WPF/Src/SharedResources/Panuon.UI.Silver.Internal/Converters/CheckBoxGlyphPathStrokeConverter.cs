using Panuon.UI.Core;
using System;
using System.Collections;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class CheckBoxGlyphPathStrokeConverter
        : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var glyphBrush = (Brush)values[0];
            var checkedGlyphBrush = (Brush)values[1];
            var checkBox = (CheckBox)values[2];

            var grid = new Grid()
            {
                Width = 1,
                Height = 1,
            };
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            var borderChecked = new Border()
            {
                Background = checkedGlyphBrush,
            };
            borderChecked.SetBinding(Border.WidthProperty, new Binding()
            {
                Path = new PropertyPath(VisualStateHelper.PercentProperty),
                Source = checkBox
            });
            grid.Children.Add(borderChecked);

            var border = new Border()
            {
                Background = glyphBrush,
            };
            Grid.SetColumn(border, 1);
            grid.Children.Add(border);

            var visualBrush = new VisualBrush()
            {
                Visual = grid,
            };
            return visualBrush;
        }
    }
}
