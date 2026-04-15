using System.Windows.Data;

namespace Panuon.WPF.UI.Resources
{
    public static class Converters
    {
        public static IMultiValueConverter BoolOrConverter = Panuon.WPF.Resources.Converters.BoolOrConverter;
        public static IValueConverter BrushToColorConverter = Panuon.WPF.Resources.Converters.BrushToColorConverter;
        public static IValueConverter ColorToBrushConverter = Panuon.WPF.Resources.Converters.ColorToBrushConverter;
        public static IValueConverter DoubleDivideByConverter = Panuon.WPF.Resources.Converters.DoubleDivideByConverter;
        public static IMultiValueConverter IsAllDoublesEqualConverter = Panuon.WPF.Resources.Converters.IsAllDoublesEqualConverter;
        public static IValueConverter DoubleIsConverter = Panuon.WPF.Resources.Converters.DoubleIsConverter;
        public static IValueConverter DoubleMinusConverter = Panuon.WPF.Resources.Converters.DoubleMinusConverter;
        public static IValueConverter DoubleMultiplyByConverter = Panuon.WPF.Resources.Converters.DoubleMultiplyByConverter;
        public static IValueConverter DoublePlusConverter = Panuon.WPF.Resources.Converters.DoublePlusConverter;
        public static IValueConverter DoublePowConverter = Panuon.WPF.Resources.Converters.DoublePowConverter;
        public static IValueConverter DoubleToCornerRadiusConverter = Panuon.WPF.Resources.Converters.DoubleToCornerRadiusConverter;
        public static IValueConverter DoubleToGridLengthConverter = Panuon.WPF.Resources.Converters.DoubleToGridLengthConverter;
        public static IValueConverter DoubleToThicknessConverter = Panuon.WPF.Resources.Converters.DoubleToThicknessConverter;
        public static IValueConverter FalseToCollapseConverter = Panuon.WPF.Resources.Converters.FalseToCollapseConverter;
        public static IValueConverter FalseToHiddenConverter = Panuon.WPF.Resources.Converters.FalseToHiddenConverter;
        public static IValueConverter GetEnumDescriptionConverter = Panuon.WPF.Resources.Converters.GetEnumDescriptionConverter;
        public static IValueConverter IntDivideByConverter = Panuon.WPF.Resources.Converters.IntDivideByConverter;
        public static IValueConverter IsDoubleEqualToConverter = Panuon.WPF.Resources.Converters.IsDoubleEqualToConverter;
        public static IValueConverter IsDoubleNotEqualToConverter = Panuon.WPF.Resources.Converters.IsDoubleNotEqualToConverter;
        public static IValueConverter IsIntEqualToConverter = Panuon.WPF.Resources.Converters.IsIntEqualToConverter;
        public static IValueConverter IsIntNotEqualToConverter = Panuon.WPF.Resources.Converters.IsIntNotEqualToConverter;
        public static IValueConverter IntMinusConverter = Panuon.WPF.Resources.Converters.IntMinusConverter;
        public static IValueConverter IntMultiplyByConverter = Panuon.WPF.Resources.Converters.IntMultiplyByConverter;
        public static IValueConverter IntPlusConverter = Panuon.WPF.Resources.Converters.IntPlusConverter;
        public static IMultiValueConverter IsAllEqualConverter = Panuon.WPF.Resources.Converters.IsAllEqualConverter;
        public static IValueConverter IsDoubleGreaterThanConverter = Panuon.WPF.Resources.Converters.IsDoubleGreaterThanConverter;
        public static IValueConverter IsDoubleLessThanConverter = Panuon.WPF.Resources.Converters.IsDoubleLessThanConverter;
        public static IMultiValueConverter IsFirstItemInItemsControlConverter = Panuon.WPF.Resources.Converters.IsFirstItemInItemsControlConverter;
        public static IMultiValueConverter IsLastItemInItemsControlConverter = Panuon.WPF.Resources.Converters.IsLastItemInItemsControlConverter;
        public static IValueConverter IsNullConverter = Panuon.WPF.Resources.Converters.IsNullConverter;
        public static IValueConverter IsNonnullConverter = Panuon.WPF.Resources.Converters.IsNonnullConverter;
        public static IValueConverter IsStringEqualToConverter = Panuon.WPF.Resources.Converters.IsStringEqualToConverter;
        public static IValueConverter IsStringUnequalConverter = Panuon.WPF.Resources.Converters.IsStringUnequalConverter;
        public static IValueConverter IsStringNonnullAndNotEmptyConverter = Panuon.WPF.Resources.Converters.IsStringNonnullAndNotEmptyConverter;
        public static IValueConverter IsIEnumerableHasItemsConverter = Panuon.WPF.Resources.Converters.IsIEnumerableHasItemsConverter;
        public static IValueConverter IsIntGreaterThanConverter = Panuon.WPF.Resources.Converters.IsIntGreaterThanConverter;
        public static IValueConverter IsIntLessThanConverter = Panuon.WPF.Resources.Converters.IsIntLessThanConverter;
        public static IValueConverter IsStringNullOrEmptyConverter = Panuon.WPF.Resources.Converters.IsStringNullOrEmptyConverter;
        public static IValueConverter LightenSolidColorBrushConverter = Panuon.WPF.Resources.Converters.LightenSolidColorBrushConverter;
        public static IValueConverter NonnullToCollapseConverter = Panuon.WPF.Resources.Converters.NonnullToCollapseConverter;
        public static IValueConverter NonnullToHiddenConverter = Panuon.WPF.Resources.Converters.NonnullToHiddenConverter;
        public static IValueConverter NullToCollapseConverter = Panuon.WPF.Resources.Converters.NullToCollapseConverter;
        public static IValueConverter NullToHiddenConverter = Panuon.WPF.Resources.Converters.NullToHiddenConverter;
        public static IValueConverter OppositeColorConverter = Panuon.WPF.Resources.Converters.OppositeColorConverter;
        public static IValueConverter OppositeBrushConverter = Panuon.WPF.Resources.Converters.OppositeBrushConverter;
        public static IValueConverter StringNonnullAndNotEmptyToCollapseConverter = Panuon.WPF.Resources.Converters.StringNonnullAndNotEmptyToCollapseConverter;
        public static IValueConverter StringNonnullAndNotEmptyToHiddenConverter = Panuon.WPF.Resources.Converters.StringNonnullAndNotEmptyToHiddenConverter;
        public static IValueConverter StringNullOrEmptyToCollapseConverter = Panuon.WPF.Resources.Converters.StringNullOrEmptyToCollapseConverter;
        public static IValueConverter StringNullOrEmptyToHiddenConverter = Panuon.WPF.Resources.Converters.StringNullOrEmptyToHiddenConverter;
        public static IValueConverter TrueToCollapseConverter = Panuon.WPF.Resources.Converters.TrueToCollapseConverter;
        public static IValueConverter TrueToFalseConverter = Panuon.WPF.Resources.Converters.TrueToFalseConverter;
        public static IValueConverter TrueToHiddenConverter = Panuon.WPF.Resources.Converters.TrueToHiddenConverter;
    }
}
