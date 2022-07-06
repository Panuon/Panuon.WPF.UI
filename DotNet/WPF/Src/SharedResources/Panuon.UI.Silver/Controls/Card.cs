using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class Card 
        : ButtonBase
    {
        #region Ctor
        static Card()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Card), new FrameworkPropertyMetadata(typeof(Card)));
        }
        #endregion

        #region Properties

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Card));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(Card));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(Card));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(Card));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(Card));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(Card));
        #endregion

        #region ClickBackground
        public Brush ClickBackground
        {
            get { return (Brush)GetValue(ClickBackgroundProperty); }
            set { SetValue(ClickBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ClickBackgroundProperty =
            DependencyProperty.Register("ClickBackground", typeof(Brush), typeof(Card));
        #endregion

        #region ClickForeground
        public Brush ClickForeground
        {
            get { return (Brush)GetValue(ClickForegroundProperty); }
            set { SetValue(ClickForegroundProperty, value); }
        }

        public static readonly DependencyProperty ClickForegroundProperty =
            DependencyProperty.Register("ClickForeground", typeof(Brush), typeof(Card));
        #endregion

        #region ClickBorderBrush
        public Brush ClickBorderBrush
        {
            get { return (Brush)GetValue(ClickBorderBrushProperty); }
            set { SetValue(ClickBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ClickBorderBrushProperty =
            DependencyProperty.Register("ClickBorderBrush", typeof(Brush), typeof(Card));
        #endregion

        #region ClickBorderThickness
        public Thickness? ClickBorderThickness
        {
            get { return (Thickness?)GetValue(ClickBorderThicknessProperty); }
            set { SetValue(ClickBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ClickBorderThicknessProperty =
            DependencyProperty.Register("ClickBorderThickness", typeof(Thickness?), typeof(Card));
        #endregion

        #region ClickEffect
        public ClickEffect ClickEffect
        {
            get { return (ClickEffect)GetValue(ClickEffectProperty); }
            set { SetValue(ClickEffectProperty, value); }
        }

        public static readonly DependencyProperty ClickEffectProperty =
            VisualStateHelper.ClickEffectProperty.AddOwner(typeof(Card));
        #endregion

        #endregion

    }
}
