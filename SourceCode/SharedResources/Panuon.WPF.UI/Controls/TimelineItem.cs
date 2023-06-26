using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class TimelineItem
        : HeaderedContentControl
    {
        #region Ctor
        static TimelineItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TimelineItem), new FrameworkPropertyMetadata(typeof(TimelineItem)));
        }
        #endregion

        #region Properties

        #region Icon
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(TimelineItem));
        #endregion

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(TimelineItem), new PropertyMetadata(Orientation.Vertical));
        #endregion

        #region ShowIndex
        public bool ShowIndex
        {
            get { return (bool)GetValue(ShowIndexProperty); }
            set { SetValue(ShowIndexProperty, value); }
        }

        public static readonly DependencyProperty ShowIndexProperty =
            DependencyProperty.Register("ShowIndex", typeof(bool), typeof(TimelineItem));
        #endregion

        #region ToggleTemplate
        public DataTemplate ToggleTemplate
        {
            get { return (DataTemplate)GetValue(ToggleTemplateProperty); }
            set { SetValue(ToggleTemplateProperty, value); }
        }

        public static readonly DependencyProperty ToggleTemplateProperty =
            DependencyProperty.Register("ToggleTemplate", typeof(DataTemplate), typeof(TimelineItem));
        #endregion

        #region ToggleStroke
        public Brush ToggleStroke
        {
            get { return (Brush)GetValue(ToggleStrokeProperty); }
            set { SetValue(ToggleStrokeProperty, value); }
        }

        public static readonly DependencyProperty ToggleStrokeProperty =
            DependencyProperty.Register("ToggleStroke", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region ToggleStrokeThickness
        public double ToggleStrokeThickness
        {
            get { return (double)GetValue(ToggleStrokeThicknessProperty); }
            set { SetValue(ToggleStrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty ToggleStrokeThicknessProperty =
            DependencyProperty.Register("ToggleStrokeThickness", typeof(double), typeof(TimelineItem));
        #endregion

        #region ToggleFill
        public Brush ToggleFill
        {
            get { return (Brush)GetValue(ToggleFillProperty); }
            set { SetValue(ToggleFillProperty, value); }
        }

        public static readonly DependencyProperty ToggleFillProperty =
            DependencyProperty.Register("ToggleFill", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region ToggleSize
        public double ToggleSize
        {
            get { return (double)GetValue(ToggleSizeProperty); }
            set { SetValue(ToggleSizeProperty, value); }
        }

        public static readonly DependencyProperty ToggleSizeProperty =
            DependencyProperty.Register("ToggleSize", typeof(double), typeof(TimelineItem));
        #endregion

        #region PendingToggleTemplate
        public DataTemplate PendingToggleTemplate
        {
            get { return (DataTemplate)GetValue(PendingToggleTemplateProperty); }
            set { SetValue(PendingToggleTemplateProperty, value); }
        }

        public static readonly DependencyProperty PendingToggleTemplateProperty =
            DependencyProperty.Register("PendingToggleTemplate", typeof(DataTemplate), typeof(TimelineItem));
        #endregion

        #region PendingSpinGlyphBrush
        public Brush PendingSpinGlyphBrush
        {
            get { return (Brush)GetValue(PendingSpinGlyphBrushProperty); }
            set { SetValue(PendingSpinGlyphBrushProperty, value); }
        }

        public static readonly DependencyProperty PendingSpinGlyphBrushProperty =
            DependencyProperty.Register("PendingSpinGlyphBrush", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region PendingSpinGlyphThickness
        public double PendingSpinGlyphThickness
        {
            get { return (double)GetValue(PendingSpinGlyphThicknessProperty); }
            set { SetValue(PendingSpinGlyphThicknessProperty, value); }
        }

        public static readonly DependencyProperty PendingSpinGlyphThicknessProperty =
            DependencyProperty.Register("PendingSpinGlyphThickness", typeof(double), typeof(TimelineItem));
        #endregion

        #region StickThickness
        public double StickThickness
        {
            get { return (double)GetValue(StickThicknessProperty); }
            set { SetValue(StickThicknessProperty, value); }
        }

        public static readonly DependencyProperty StickThicknessProperty =
            DependencyProperty.Register("StickThickness", typeof(double), typeof(TimelineItem));
        #endregion

        #region StickStroke
        public Brush StickStroke
        {
            get { return (Brush)GetValue(StickStrokeProperty); }
            set { SetValue(StickStrokeProperty, value); }
        }

        public static readonly DependencyProperty StickStrokeProperty =
            DependencyProperty.Register("StickStroke", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region StickStrokeThickness
        public double StickStrokeThickness
        {
            get { return (double)GetValue(StickStrokeThicknessProperty); }
            set { SetValue(StickStrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty StickStrokeThicknessProperty =
            DependencyProperty.Register("StickStrokeThickness", typeof(double), typeof(TimelineItem));
        #endregion

        #region StickFill
        public Brush StickFill
        {
            get { return (Brush)GetValue(StickFillProperty); }
            set { SetValue(StickFillProperty, value); }
        }

        public static readonly DependencyProperty StickFillProperty =
            DependencyProperty.Register("StickFill", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region CompletedToggleStroke
        public Brush CompletedToggleStroke
        {
            get { return (Brush)GetValue(CompletedToggleStrokeProperty); }
            set { SetValue(CompletedToggleStrokeProperty, value); }
        }

        public static readonly DependencyProperty CompletedToggleStrokeProperty =
            DependencyProperty.Register("CompletedToggleStroke", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region CompletedToggleStrokeThickness
        public double CompletedToggleStrokeThickness
        {
            get { return (double)GetValue(CompletedToggleStrokeThicknessProperty); }
            set { SetValue(CompletedToggleStrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty CompletedToggleStrokeThicknessProperty =
            DependencyProperty.Register("CompletedToggleStrokeThickness", typeof(double), typeof(TimelineItem));
        #endregion

        #region CompletedToggleFill
        public Brush CompletedToggleFill
        {
            get { return (Brush)GetValue(CompletedToggleFillProperty); }
            set { SetValue(CompletedToggleFillProperty, value); }
        }

        public static readonly DependencyProperty CompletedToggleFillProperty =
            DependencyProperty.Register("CompletedToggleFill", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region CompletedGlyphTemplate
        public DataTemplate CompletedGlyphTemplate
        {
            get { return (DataTemplate)GetValue(CompletedGlyphTemplateProperty); }
            set { SetValue(CompletedGlyphTemplateProperty, value); }
        }

        public static readonly DependencyProperty CompletedGlyphTemplateProperty =
            DependencyProperty.Register("CompletedGlyphTemplate", typeof(DataTemplate), typeof(TimelineItem));
        #endregion

        #region CompletedGlyphBrush

        public Brush CompletedGlyphBrush
        {
            get { return (Brush)GetValue(CompletedGlyphBrushProperty); }
            set { SetValue(CompletedGlyphBrushProperty, value); }
        }

        public static readonly DependencyProperty CompletedGlyphBrushProperty =
            DependencyProperty.Register("CompletedGlyphBrush", typeof(Brush), typeof(TimelineItem), new PropertyMetadata(Brushes.Black));
        #endregion

        #region CompletedStickStroke
        public Brush CompletedStickStroke
        {
            get { return (Brush)GetValue(CompletedStickStrokeProperty); }
            set { SetValue(CompletedStickStrokeProperty, value); }
        }

        public static readonly DependencyProperty CompletedStickStrokeProperty =
            DependencyProperty.Register("CompletedStickStroke", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region CompletedStickStrokeThickness
        public double CompletedStickStrokeThickness
        {
            get { return (double)GetValue(CompletedStickStrokeThicknessProperty); }
            set { SetValue(CompletedStickStrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty CompletedStickStrokeThicknessProperty =
            DependencyProperty.Register("CompletedStickStrokeThickness", typeof(double), typeof(TimelineItem));
        #endregion

        #region CompletedStickFill
        public Brush CompletedStickFill
        {
            get { return (Brush)GetValue(CompletedStickFillProperty); }
            set { SetValue(CompletedStickFillProperty, value); }
        }

        public static readonly DependencyProperty CompletedStickFillProperty =
            DependencyProperty.Register("CompletedStickFill", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(TimelineItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(TimelineItem));
        #endregion

        #region IsPending
        public bool IsPending
        {
            get { return (bool)GetValue(IsPendingProperty); }
            set { SetValue(IsPendingProperty, value); }
        }

        public static readonly DependencyProperty IsPendingProperty =
            DependencyProperty.Register("IsPending", typeof(bool), typeof(TimelineItem));
        #endregion

        #region IsCompleted
        public bool IsCompleted
        {
            get { return (bool)GetValue(IsCompletedProperty); }
            set { SetValue(IsCompletedProperty, value); }
        }

        public static readonly DependencyProperty IsCompletedProperty =
            DependencyProperty.Register("IsCompleted", typeof(bool), typeof(TimelineItem));
        #endregion

        #region SeparatorVisibility
        public Visibility SeparatorVisibility
        {
            get { return (Visibility)GetValue(SeparatorVisibilityProperty); }
            set { SetValue(SeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.Register("SeparatorVisibility", typeof(Visibility), typeof(TimelineItem), new PropertyMetadata(Visibility.Collapsed));
        #endregion

        #region SeparatorBrush
        public Brush SeparatorBrush
        {
            get { return (Brush)GetValue(SeparatorBrushProperty); }
            set { SetValue(SeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.Register("SeparatorBrush", typeof(Brush), typeof(TimelineItem), new PropertyMetadata(Brushes.Black));
        #endregion

        #region SeparatorThickness
        public double SeparatorThickness
        {
            get { return (double)GetValue(SeparatorThicknessProperty); }
            set { SetValue(SeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.Register("SeparatorThickness", typeof(double), typeof(TimelineItem), new PropertyMetadata(1d));
        #endregion

        #region SeparatorMargin
        public Thickness SeparatorMargin
        {
            get { return (Thickness)GetValue(SeparatorMarginProperty); }
            set { SetValue(SeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.Register("SeparatorMargin", typeof(Thickness), typeof(TimelineItem));
        #endregion

        #region Header Property

        #region HeaderHorizontalContentAlignment
        public HorizontalAlignment HeaderHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(HeaderHorizontalContentAlignmentProperty); }
            set { SetValue(HeaderHorizontalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HeaderHorizontalContentAlignmentProperty =
            DependencyProperty.Register("HeaderHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(TimelineItem));
        #endregion

        #region HeaderVerticalContentAlignment
        public VerticalAlignment HeaderVerticalContentAlignment
        {
            get { return (VerticalAlignment)GetValue(HeaderVerticalContentAlignmentProperty); }
            set { SetValue(HeaderVerticalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HeaderVerticalContentAlignmentProperty =
            DependencyProperty.Register("HeaderVerticalContentAlignment", typeof(VerticalAlignment), typeof(TimelineItem));
        #endregion

        #region HeaderPadding
        public Thickness HeaderPadding
        {
            get { return (Thickness)GetValue(HeaderPaddingProperty); }
            set { SetValue(HeaderPaddingProperty, value); }
        }

        public static readonly DependencyProperty HeaderPaddingProperty =
            DependencyProperty.Register("HeaderPadding", typeof(Thickness), typeof(TimelineItem));
        #endregion

        #region HeaderFontSize
        public double HeaderFontSize
        {
            get { return (double)GetValue(HeaderFontSizeProperty); }
            set { SetValue(HeaderFontSizeProperty, value); }
        }

        public static readonly DependencyProperty HeaderFontSizeProperty =
            DependencyProperty.Register("HeaderFontSize", typeof(double), typeof(TimelineItem), new PropertyMetadata(SystemFonts.CaptionFontSize));
        #endregion

        #region HeaderFontWeight
        public FontWeight HeaderFontWeight
        {
            get { return (FontWeight)GetValue(HeaderFontWeightProperty); }
            set { SetValue(HeaderFontWeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderFontWeightProperty =
            DependencyProperty.Register("HeaderFontWeight", typeof(FontWeight), typeof(TimelineItem));
        #endregion

        #region HeaderForeground
        public Brush HeaderForeground
        {
            get { return (Brush)GetValue(HeaderForegroundProperty); }
            set { SetValue(HeaderForegroundProperty, value); }
        }

        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.Register("HeaderForeground", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region HeaderBackground
        public Brush HeaderBackground
        {
            get { return (Brush)GetValue(HeaderBackgroundProperty); }
            set { SetValue(HeaderBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.Register("HeaderBackground", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region HeaderBorderBrush
        public Brush HeaderBorderBrush
        {
            get { return (Brush)GetValue(HeaderBorderBrushProperty); }
            set { SetValue(HeaderBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HeaderBorderBrushProperty =
            DependencyProperty.Register("HeaderBorderBrush", typeof(Brush), typeof(TimelineItem));
        #endregion

        #region HeaderBorderThickness
        public Thickness HeaderBorderThickness
        {
            get { return (Thickness)GetValue(HeaderBorderThicknessProperty); }
            set { SetValue(HeaderBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty HeaderBorderThicknessProperty =
            DependencyProperty.Register("HeaderBorderThickness", typeof(Thickness), typeof(TimelineItem));
        #endregion

        #region HeaderCornerRadius
        public CornerRadius HeaderCornerRadius
        {
            get { return (CornerRadius)GetValue(HeaderCornerRadiusProperty); }
            set { SetValue(HeaderCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HeaderCornerRadiusProperty =
            DependencyProperty.Register("HeaderCornerRadius", typeof(CornerRadius), typeof(TimelineItem));
        #endregion

        #region HeaderShadowColor
        public Color? HeaderShadowColor
        {
            get { return (Color?)GetValue(HeaderShadowColorProperty); }
            set { SetValue(HeaderShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HeaderShadowColorProperty =
            DependencyProperty.Register("HeaderShadowColor", typeof(Color?), typeof(TimelineItem));
        #endregion

        #region HeaderHeight
        public double HeaderHeight
        {
            get { return (double)GetValue(HeaderHeightProperty); }
            set { SetValue(HeaderHeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.Register("HeaderHeight", typeof(double), typeof(TimelineItem));
        #endregion

        #region HeaderPlacement
        public HeaderPlacement HeaderPlacement
        {
            get { return (HeaderPlacement)GetValue(HeaderPlacementProperty); }
            set { SetValue(HeaderPlacementProperty, value); }
        }

        public static readonly DependencyProperty HeaderPlacementProperty =
            DependencyProperty.Register("HeaderPlacement", typeof(HeaderPlacement), typeof(TimelineItem));
        #endregion

        #endregion

        #endregion
    }
}