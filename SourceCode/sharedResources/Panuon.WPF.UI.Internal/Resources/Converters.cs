using Panuon.WPF.UI.Internal.Converters;
using System.Windows.Data;

namespace Panuon.WPF.UI.Internal.Resources
{
    static class Converters
    {
        public static IMultiValueConverter ArcConverter = new ArcConverter();
        public static IMultiValueConverter Arc2Converter = new Arc2Converter();
        public static IMultiValueConverter BubblePathConverter = new BubblePathConverter();
        public static IValueConverter BrushOpacityConverter = new BrushOpacityConverter();
        public static IMultiValueConverter CheckBoxCheckPathConverter = new CheckBoxCheckPathConverter();
        public static IMultiValueConverter CheckBoxGlyphPathStrokeConverter = new CheckBoxGlyphPathStrokeConverter();
        public static IMultiValueConverter ColorSelectorOpacitySliderBackgroundConverter = new ColorSelectorOpacitySliderBackgroundConverter();
        public static IValueConverter ColorSelectorThumbFenceBackgroundConverter = new ColorSelectorThumbFenceBackgroundConverter();
        public static IMultiValueConverter ComboBoxDropDownHorizontalOffsetConverter = new ComboBoxDropDownHorizontalOffsetConverter();
        public static IMultiValueConverter ComboBoxDropDownMarginConverter = new ComboBoxDropDownMarginConverter();
        public static IMultiValueConverter ComboBoxDropDownVerticalOffsetConverter = new ComboBoxDropDownVerticalOffsetConverter();
        public static IMultiValueConverter ContextMenuDropDownMarginConverter = new ContextMenuDropDownMarginConverter();
        public static IValueConverter DataGridSelectionUnitIsNotFullRowConverter = new DataGridSelectionUnitIsNotFullRowConverter();
        public static IMultiValueConverter DisplayMemberPathPropertyValueConverter = new DisplayMemberPathPropertyValueConverter();
        public static IValueConverter DoubleHalfToCornerRadiusConverter = new DoubleHalfToCornerRadiusConverter();
        public static IMultiValueConverter DrawerContentMarginConverter = new DrawerContentMarginConverter();
        public static IMultiValueConverter DrawerBorderMarginConverter = new DrawerBorderMarginConverter();
        public static IValueConverter DropDownMarginConverter = new DropDownMarginConverter();
        public static IMultiValueConverter DropDownMinWidthConverter = new DropDownMinWidthConverter();
        public static IMultiValueConverter DropDownOffsetConverter = new DropDownOffsetConverter();
        public static IMultiValueConverter DropShadowEffectWithDepthConverter = new DropShadowEffectWithDepthConverter();
        public static IValueConverter FontSizeMinusConverter = new FontSizeMinusConverter();
        public static IMultiValueConverter GetIndexOfItemsControlConverter = new GetIndexOfItemsControlConverter();
        public static IValueConverter GetTypeConverter = new GetTypeConverter();
        public static IValueConverter GroupBoxHeaderCornerRadiusConverter = new GroupBoxHeaderCornerRadiusConverter();
        public static IValueConverter IconPlacementToDockConverter = new IconPlacementToDockConverter();
        public static IMultiValueConverter IconVisibilityConverter = new IconVisibilityConverter();
        public static IMultiValueConverter InternalSpinClassicRenderTransformOriginConverter = new InternalSpinClassicRenderTransformOriginConverter();
        public static IValueConverter IsEnumContainsInSpecificValueConverter = new IsEnumContainsInSpecificValueConverter();
        public static IMultiValueConverter IsItemSeparatorShallVisibleControlConverter = new IsItemSeparatorShallVisibleControlConverter();
        public static IValueConverter IsTypeConverter = new IsTypeConverter();
        public static IMultiValueConverter ProgressBarBorderClipConverter = new ProgressBarBorderClipConverter();
        public static IMultiValueConverter ProgressBarTextForegroundConverter = new ProgressBarTextForegroundConverter();
        public static IMultiValueConverter ProgressBarIndeterminateMarginConverter = new ProgressBarIndeterminateMarginConverter();
        public static IMultiValueConverter RangeSliderCanvasOffsetConverter = new RangeSliderCanvasOffsetConverter();
        public static IMultiValueConverter ScrollableControlScrollButtonVisibilityConverter = new ScrollableControlScrollButtonVisibilityConverter();
        public static IMultiValueConverter SliderBorderClipConverter = new SliderBorderClipConverter();
        public static IMultiValueConverter SliderTextLeftConverter = new SliderTextLeftConverter();
        public static IMultiValueConverter SliderTextTopConverter = new SliderTextTopConverter();
        public static IMultiValueConverter SwitchToggleMarginConverter = new SwitchToggleMarginConverter();
        public static IMultiValueConverter TabControlScrollButtonVisibilityConverter = new TabControlScrollButtonVisibilityConverter();
        public static IMultiValueConverter TabPanelMaxHeightConverter = new TabPanelMaxHeightConverter();
        public static IMultiValueConverter TabPanelMaxWidthConverter = new TabPanelMaxWidthConverter();
        public static IValueConverter ThicknessLeftRightOnlyConverter = new ThicknessLeftRightOnlyConverter();
        public static IMultiValueConverter TransparentColorToBrushConverter = new TransparentColorToBrushConverter();
        public static IValueConverter TreeViewInternalPaddingConverter = new TreeViewInternalPaddingConverter();
        public static IMultiValueConverter TreeViewItemHorizontalSeparatorWidthConverter = new TreeViewItemHorizontalSeparatorWidthConverter();
        public static IMultiValueConverter TreeViewItemHorizontalSeparatorMarginConverter = new TreeViewItemHorizontalSeparatorMarginConverter();
        public static IMultiValueConverter TreeViewItemVerticalSeparatorMarginConverter = new TreeViewItemVerticalSeparatorMarginConverter();
        public static IMultiValueConverter TreeViewItemInternalPaddingConverter = new TreeViewItemInternalPaddingConverter();
        public static IValueConverter WindowXCaptionDataContextConverter = new WindowXCaptionDataContextConverter();
        public static IMultiValueConverter ZoomViewerViewboxScaleConverter = new ZoomViewerViewboxScaleConverter();
    }
    
}
