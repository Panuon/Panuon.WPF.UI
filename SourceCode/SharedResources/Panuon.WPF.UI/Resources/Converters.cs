using Panuon.WPF.UI.Internal.Converters;
using System.Windows.Data;

namespace Panuon.WPF.UI.Resources
{
    public static class Converters
    {
        public static IMultiValueConverter AutoCornerRadiusConverter = new AutoCornerRadiusConverter();
        public static IMultiValueConverter BoolOrConverter = new BoolOrConverter();
        public static IValueConverter BrushToColorConverter = new BrushToColorConverter();
        public static IMultiValueConverter BubblePathConverter = new BubblePathConverter();
        public static IValueConverter ColorToBrushConverter = new ColorToBrushConverter();
        public static IValueConverter DoubleDivideByConverter = new DoubleDivideByConverter();
        public static IMultiValueConverter IsAllDoublesEqualConverter = new IsAllDoublesEqualConverter();
        public static IValueConverter DoubleIsConverter = new DoubleIsConverter();
        public static IValueConverter DoubleMinusConverter = new DoubleMinusConverter();
        public static IValueConverter DoubleMultiplyByConverter = new DoubleMultiplyByConverter();
        public static IValueConverter DoublePlusConverter = new DoublePlusConverter();
        public static IValueConverter DoublePowConverter = new DoublePowConverter();
        public static IValueConverter DoubleToGridLengthConverter = new DoubleToGridLengthConverter();
        public static IValueConverter DoubleToThicknessConverter = new DoubleToThicknessConverter();
        public static IValueConverter FalseToCollapseConverter = new FalseToCollapseConverter();
        public static IValueConverter FalseToHiddenConverter = new FalseToHiddenConverter();
        public static IValueConverter GetEnumDescriptionConverter = new GetEnumDescriptionConverter();
        public static IValueConverter IntDivideByConverter = new IntDivideByConverter();
        public static IValueConverter IsDoubleEqualToConverter = new IsDoubleEqualToConverter();
        public static IValueConverter IsDoubleNotEqualToConverter = new IsDoubleNotEqualToConverter();
        public static IValueConverter IsIntEqualToConverter = new IsIntEqualToConverter();
        public static IValueConverter IsIntNotEqualToConverter = new IsIntNotEqualToConverter();
        public static IValueConverter IntMinusConverter = new IntMinusConverter();
        public static IValueConverter IntMultiplyByConverter = new IntMultiplyByConverter();
        public static IValueConverter IntPlusConverter = new IntPlusConverter();
        public static IMultiValueConverter IsAllEqualConverter = new IsAllEqualConverter();
        public static IValueConverter IsDoubleGreaterThanConverter = new IsDoubleGreaterThanConverter();
        public static IValueConverter IsDoubleLessThanConverter = new IsDoubleLessThanConverter();
        public static IMultiValueConverter IsFirstItemInItemsControlConverter = new IsFirstItemInItemsControlConverter();
        public static IMultiValueConverter IsLastItemInItemsControlConverter = new IsLastItemInItemsControlConverter();
        public static IValueConverter IsNullConverter = new IsNullConverter();
        public static IValueConverter IsNonnullConverter = new IsNonnullConverter();
        public static IValueConverter IsStringEqualToConverter = new IsStringEqualToConverter();
        public static IValueConverter IsStringUnequalConverter = new IsStringUnequalConverter();
        public static IValueConverter IsStringNonnullAndNotEmptyConverter = new IsStringNonnullAndNotEmptyConverter();
        public static IValueConverter IsIEnumerableHasItemsConverter = new IsIEnumerableHasItemsConverter();
        public static IValueConverter IsIntGreaterThanConverter = new IsIntGreaterThanConverter();
        public static IValueConverter IsIntLessThanConverter = new IsIntLessThanConverter();
        public static IValueConverter IsStringNullOrEmptyConverter = new IsStringNullOrEmptyConverter();
        public static IValueConverter NonnullToCollapseConverter = new NonnullToCollapseConverter();
        public static IValueConverter NonnullToHiddenConverter = new NonnullToHiddenConverter();
        public static IValueConverter NullToCollapseConverter = new NullToCollapseConverter();
        public static IValueConverter NullToHiddenConverter = new NullToHiddenConverter();
        public static IValueConverter OppositeColorConverter = new OppositeColorConverter();
        public static IValueConverter OppositeBrushConverter = new OppositeBrushConverter();
        public static IValueConverter StringNonnullAndNotEmptyToCollapseConverter = new StringNonnullAndNotEmptyToCollapseConverter();
        public static IValueConverter StringNonnullAndNotEmptyToHiddenConverter = new StringNonnullAndNotEmptyToHiddenConverter();
        public static IValueConverter StringNullOrEmptyToCollapseConverter = new StringNullOrEmptyToCollapseConverter();
        public static IValueConverter StringNullOrEmptyToHiddenConverter = new StringNullOrEmptyToHiddenConverter();
        public static IValueConverter TrueToCollapseConverter = new TrueToCollapseConverter();
        public static IValueConverter TrueToFalseConverter = new TrueToFalseConverter();
        public static IValueConverter TrueToHiddenConverter = new TrueToHiddenConverter();
    }
}
