using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
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

        #region SelectedBackground
        public Brush SelectedBackground
        {
            get { return (Brush)GetValue(SelectedBackgroundProperty); }
            set { SetValue(SelectedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.Register("SelectedBackground", typeof(Brush), typeof(PaginationItem));

        #endregion

        #region SelectedForeground
        public Brush SelectedForeground
        {
            get { return (Brush)GetValue(SelectedForegroundProperty); }
            set { SetValue(SelectedForegroundProperty, value); }
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.Register("SelectedForeground", typeof(Brush), typeof(PaginationItem));
        #endregion

        #region SelectedBorderBrush
        public Brush SelectedBorderBrush
        {
            get { return (Brush)GetValue(SelectedBorderBrushProperty); }
            set { SetValue(SelectedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.Register("SelectedBorderBrush", typeof(Brush), typeof(PaginationItem));
        #endregion

        #region SelectedBorderThickness
        public Thickness? SelectedBorderThickness
        {
            get { return (Thickness?)GetValue(SelectedBorderThicknessProperty); }
            set { SetValue(SelectedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty SelectedBorderThicknessProperty =
            DependencyProperty.Register("SelectedBorderThickness", typeof(Thickness?), typeof(PaginationItem));
        #endregion

        #region SelectedShadowColor
        public Color? SelectedShadowColor
        {
            get { return (Color?)GetValue(SelectedShadowColorProperty); }
            set { SetValue(SelectedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty SelectedShadowColorProperty =
            VisualStateHelper.SelectedShadowColorProperty.AddOwner(typeof(PaginationItem));
        #endregion

        #endregion
    }
}
