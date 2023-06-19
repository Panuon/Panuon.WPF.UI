using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class Timeline
        : ItemsControl
    {
        #region Ctor
        static Timeline()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Timeline), new FrameworkPropertyMetadata(typeof(Timeline)));
        }
        #endregion

        #region Properties

        #region ToggleTemplate
        public DataTemplate ToggleTemplate
        {
            get { return (DataTemplate)GetValue(ToggleTemplateProperty); }
            set { SetValue(ToggleTemplateProperty, value); }
        }

        public static readonly DependencyProperty ToggleTemplateProperty =
            DependencyProperty.Register("ToggleTemplate", typeof(DataTemplate), typeof(Timeline));
        #endregion

        #region EmptyContent
        public object EmptyContent
        {
            get { return (object)GetValue(EmptyContentProperty); }
            set { SetValue(EmptyContentProperty, value); }
        }

        public static readonly DependencyProperty EmptyContentProperty =
            DependencyProperty.Register("EmptyContent", typeof(object), typeof(Timeline));
        #endregion

        #region LineVisibility
        public Visibility LineVisibility
        {
            get { return (Visibility)GetValue(LineVisibilityProperty); }
            set { SetValue(LineVisibilityProperty, value); }
        }

        public static readonly DependencyProperty LineVisibilityProperty =
            DependencyProperty.Register("LineVisibility", typeof(Visibility), typeof(TimelineItem), new PropertyMetadata(Visibility.Collapsed));
        #endregion

        #region LineBrush
        public Brush LineBrush
        {
            get { return (Brush)GetValue(LineBrushProperty); }
            set { SetValue(LineBrushProperty, value); }
        }

        public static readonly DependencyProperty LineBrushProperty =
            DependencyProperty.Register("LineBrush", typeof(Brush), typeof(TimelineItem), new PropertyMetadata(Brushes.Black));
        #endregion

        #region LineThickness
        public double LineThickness
        {
            get { return (double)GetValue(LineThicknessProperty); }
            set { SetValue(LineThicknessProperty, value); }
        }

        public static readonly DependencyProperty LineThicknessProperty =
            DependencyProperty.Register("LineThickness", typeof(double), typeof(TimelineItem), new PropertyMetadata(1d));
        #endregion

        #region LineMargin
        public Thickness LineMargin
        {
            get { return (Thickness)GetValue(LineMarginProperty); }
            set { SetValue(LineMarginProperty, value); }
        }

        public static readonly DependencyProperty LineMarginProperty =
            DependencyProperty.Register("LineMargin", typeof(Thickness), typeof(TimelineItem));
        #endregion

        #region Scrollable
        public bool Scrollable
        {
            get { return (bool)GetValue(ScrollableProperty); }
            set { SetValue(ScrollableProperty, value); }
        }

        public static readonly DependencyProperty ScrollableProperty =
            DependencyProperty.Register("Scrollable", typeof(bool), typeof(Timeline));
        #endregion

        #region Items Properties

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(Timeline));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(Timeline));
        #endregion

        #region ItemsMargin
        public Thickness ItemsMargin
        {
            get { return (Thickness)GetValue(ItemsMarginProperty); }
            set { SetValue(ItemsMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.Register("ItemsMargin", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsPadding
        public Thickness ItemsPadding
        {
            get { return (Thickness)GetValue(ItemsPaddingProperty); }
            set { SetValue(ItemsPaddingProperty, value); }
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.Register("ItemsPadding", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsForeground
        public Brush ItemsForeground
        {
            get { return (Brush)GetValue(ItemsForegroundProperty); }
            set { SetValue(ItemsForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.Register("ItemsForeground", typeof(Brush), typeof(Timeline), new PropertyMetadata(Brushes.Black));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(Timeline), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsBorderThickness
        public Thickness ItemsBorderThickness
        {
            get { return (Thickness)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsHeaderPadding
        public Thickness ItemsHeaderPadding
        {
            get { return (Thickness)GetValue(ItemsHeaderPaddingProperty); }
            set { SetValue(ItemsHeaderPaddingProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderPaddingProperty =
            DependencyProperty.Register("ItemsHeaderPadding", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsHeaderFontSize
        public double ItemsHeaderFontSize
        {
            get { return (double)GetValue(ItemsHeaderFontSizeProperty); }
            set { SetValue(ItemsHeaderFontSizeProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderFontSizeProperty =
            DependencyProperty.Register("ItemsHeaderFontSize", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsHeaderFontWeight
        public FontWeight ItemsHeaderFontWeight
        {
            get { return (FontWeight)GetValue(ItemsHeaderFontWeightProperty); }
            set { SetValue(ItemsHeaderFontWeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderFontWeightProperty =
            DependencyProperty.Register("ItemsHeaderFontWeight", typeof(FontWeight), typeof(Timeline));
        #endregion

        #region ItemsHeaderForeground
        public Brush ItemsHeaderForeground
        {
            get { return (Brush)GetValue(ItemsHeaderForegroundProperty); }
            set { SetValue(ItemsHeaderForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderForegroundProperty =
            DependencyProperty.Register("ItemsHeaderForeground", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsHeaderBackground
        public Brush ItemsHeaderBackground
        {
            get { return (Brush)GetValue(ItemsHeaderBackgroundProperty); }
            set { SetValue(ItemsHeaderBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderBackgroundProperty =
            DependencyProperty.Register("ItemsHeaderBackground", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsHeaderBorderBrush
        public Brush ItemsHeaderBorderBrush
        {
            get { return (Brush)GetValue(ItemsHeaderBorderBrushProperty); }
            set { SetValue(ItemsHeaderBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderBorderBrushProperty =
            DependencyProperty.Register("ItemsHeaderBorderBrush", typeof(Brush), typeof(Timeline));
        #endregion

        #region ItemsHeaderBorderThickness
        public Thickness ItemsHeaderBorderThickness
        {
            get { return (Thickness)GetValue(ItemsHeaderBorderThicknessProperty); }
            set { SetValue(ItemsHeaderBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderBorderThicknessProperty =
            DependencyProperty.Register("ItemsHeaderBorderThickness", typeof(Thickness), typeof(Timeline));
        #endregion

        #region ItemsHeaderCornerRadius
        public CornerRadius ItemsHeaderCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsHeaderCornerRadiusProperty); }
            set { SetValue(ItemsHeaderCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderCornerRadiusProperty =
            DependencyProperty.Register("ItemsHeaderCornerRadius", typeof(CornerRadius), typeof(Timeline));
        #endregion

        #region ItemsHeaderShadowColor
        public Color? ItemsHeaderShadowColor
        {
            get { return (Color?)GetValue(ItemsHeaderShadowColorProperty); }
            set { SetValue(ItemsHeaderShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderShadowColorProperty =
            DependencyProperty.Register("ItemsHeaderShadowColor", typeof(Color?), typeof(Timeline));
        #endregion

        #region ItemsHeaderHeight
        public double ItemsHeaderHeight
        {
            get { return (double)GetValue(ItemsHeaderHeightProperty); }
            set { SetValue(ItemsHeaderHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderHeightProperty =
            DependencyProperty.Register("ItemsHeaderHeight", typeof(double), typeof(Timeline));
        #endregion

        #region ItemsHeaderPlacement
        public HeaderPlacement ItemsHeaderPlacement
        {
            get { return (HeaderPlacement)GetValue(ItemsHeaderPlacementProperty); }
            set { SetValue(ItemsHeaderPlacementProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeaderPlacementProperty =
            DependencyProperty.Register("ItemsHeaderPlacement", typeof(HeaderPlacement), typeof(Timeline));
        #endregion

        #region ItemsSeparatorVisibility
        public Visibility ItemsSeparatorVisibility
        {
            get { return (Visibility)GetValue(ItemsSeparatorVisibilityProperty); }
            set { SetValue(ItemsSeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.Register("ItemsSeparatorVisibility", typeof(Visibility), typeof(TimelineItem), new PropertyMetadata(Visibility.Collapsed));
        #endregion

        #region ItemsSeparatorBrush
        public Brush ItemsSeparatorBrush
        {
            get { return (Brush)GetValue(ItemsSeparatorBrushProperty); }
            set { SetValue(ItemsSeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.Register("ItemsSeparatorBrush", typeof(Brush), typeof(TimelineItem), new PropertyMetadata(Brushes.Black));
        #endregion

        #region ItemsSeparatorThickness
        public double ItemsSeparatorThickness
        {
            get { return (double)GetValue(ItemsSeparatorThicknessProperty); }
            set { SetValue(ItemsSeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.Register("ItemsSeparatorThickness", typeof(double), typeof(TimelineItem), new PropertyMetadata(1d));
        #endregion

        #region ItemsSeparatorMargin
        public Thickness ItemsSeparatorMargin
        {
            get { return (Thickness)GetValue(ItemsSeparatorMarginProperty); }
            set { SetValue(ItemsSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.Register("ItemsSeparatorMargin", typeof(Thickness), typeof(TimelineItem));
        #endregion

        #endregion

        #endregion

        #region Overrides
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TimelineItem;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TimelineItem();
        }
        #endregion

        #region Methods
        #endregion
    }
}
