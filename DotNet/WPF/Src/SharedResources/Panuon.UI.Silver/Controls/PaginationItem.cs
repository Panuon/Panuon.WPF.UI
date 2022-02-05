using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class PaginationItem : RadioButton
    {
        #region Ctor
        static PaginationItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PaginationItem), new FrameworkPropertyMetadata(typeof(PaginationItem)));
        }
        #endregion

        #region Properties

        #region IsOmitting
        public bool IsOmitting
        {
            get { return (bool)GetValue(IsOmittingProperty); }
            set { SetValue(IsOmittingProperty, value); }
        }

        public static readonly DependencyProperty IsOmittingProperty =
            DependencyProperty.Register("IsOmitting", typeof(bool), typeof(PaginationItem));
        #endregion

        #region OmittingTextBlockStyle
        public Style OmittingTextBlockStyle
        {
            get { return (Style)GetValue(OmittingTextBlockStyleProperty); }
            set { SetValue(OmittingTextBlockStyleProperty, value); }
        }

        public static readonly DependencyProperty OmittingTextBlockStyleProperty =
            DependencyProperty.Register("OmittingTextBlockStyle", typeof(Style), typeof(PaginationItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(PaginationItem));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(PaginationItem));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(PaginationItem));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(PaginationItem));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(PaginationItem));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(PaginationItem));
        #endregion

        #region CheckedBackground
        public Brush CheckedBackground
        {
            get { return (Brush)GetValue(CheckedBackgroundProperty); }
            set { SetValue(CheckedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register("CheckedBackground", typeof(Brush), typeof(PaginationItem));

        #endregion

        #region CheckedForeground
        public Brush CheckedForeground
        {
            get { return (Brush)GetValue(CheckedForegroundProperty); }
            set { SetValue(CheckedForegroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.Register("CheckedForeground", typeof(Brush), typeof(PaginationItem));
        #endregion

        #region CheckedBorderBrush
        public Brush CheckedBorderBrush
        {
            get { return (Brush)GetValue(CheckedBorderBrushProperty); }
            set { SetValue(CheckedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.Register("CheckedBorderBrush", typeof(Brush), typeof(PaginationItem));
        #endregion

        #region CheckedBorderThickness
        public Thickness? CheckedBorderThickness
        {
            get { return (Thickness?)GetValue(CheckedBorderThicknessProperty); }
            set { SetValue(CheckedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.Register("CheckedBorderThickness", typeof(Thickness?), typeof(PaginationItem));
        #endregion

        #region CheckedShadowColor
        public Color? CheckedShadowColor
        {
            get { return (Color?)GetValue(CheckedShadowColorProperty); }
            set { SetValue(CheckedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty CheckedShadowColorProperty =
            VisualStateHelper.CheckedShadowColorProperty.AddOwner(typeof(PaginationItem));
        #endregion

        #endregion
    }
}
