using Panuon.UI.Silver.Internal;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class SearchBoxItem
        : ButtonBase
    {
        #region Ctor
        static SearchBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SearchBoxItem), new FrameworkPropertyMetadata(typeof(SearchBoxItem)));
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
            DependencyProperty.Register("Icon", typeof(object), typeof(SearchBoxItem));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(SearchBoxItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(SearchBoxItem));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(SearchBoxItem));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(SearchBoxItem));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(SearchBoxItem));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(SearchBoxItem));
        #endregion

        #region ClickBackground
        public Brush ClickBackground
        {
            get { return (Brush)GetValue(ClickBackgroundProperty); }
            set { SetValue(ClickBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ClickBackgroundProperty =
            DependencyProperty.Register("ClickBackground", typeof(Brush), typeof(SearchBoxItem));
        #endregion

        #region ClickForeground
        public Brush ClickForeground
        {
            get { return (Brush)GetValue(ClickForegroundProperty); }
            set { SetValue(ClickForegroundProperty, value); }
        }

        public static readonly DependencyProperty ClickForegroundProperty =
            DependencyProperty.Register("ClickForeground", typeof(Brush), typeof(SearchBoxItem));
        #endregion

        #region ClickBorderBrush
        public Brush ClickBorderBrush
        {
            get { return (Brush)GetValue(ClickBorderBrushProperty); }
            set { SetValue(ClickBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ClickBorderBrushProperty =
            DependencyProperty.Register("ClickBorderBrush", typeof(Brush), typeof(SearchBoxItem));
        #endregion

        #region ClickBorderThickness
        public Thickness? ClickBorderThickness
        {
            get { return (Thickness?)GetValue(ClickBorderThicknessProperty); }
            set { SetValue(ClickBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ClickBorderThicknessProperty =
            DependencyProperty.Register("ClickBorderThickness", typeof(Thickness?), typeof(SearchBoxItem));
        #endregion

        #region ClickEffect
        public ClickEffect ClickEffect
        {
            get { return (ClickEffect)GetValue(ClickEffectProperty); }
            set { SetValue(ClickEffectProperty, value); }
        }

        public static readonly DependencyProperty ClickEffectProperty =
            VisualStateHelper.ClickEffectProperty.AddOwner(typeof(SearchBoxItem));
        #endregion

        #region SeparatorBrush
        public Brush SeparatorBrush
        {
            get { return (Brush)GetValue(SeparatorBrushProperty); }
            set { SetValue(SeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty SeparatorBrushProperty =
            DependencyProperty.Register("SeparatorBrush", typeof(Brush), typeof(SearchBoxItem));
        #endregion

        #region SeparatorThickness
        public double SeparatorThickness
        {
            get { return (double)GetValue(SeparatorThicknessProperty); }
            set { SetValue(SeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty SeparatorThicknessProperty =
            DependencyProperty.Register("SeparatorThickness", typeof(double), typeof(SearchBoxItem));
        #endregion

        #region SeparatorMargin
        public Thickness SeparatorMargin
        {
            get { return (Thickness)GetValue(SeparatorMarginProperty); }
            set { SetValue(SeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.Register("SeparatorMargin", typeof(Thickness), typeof(SearchBoxItem));
        #endregion

        #region SeparatorVisibility
        public Visibility SeparatorVisibility
        {
            get { return (Visibility)GetValue(SeparatorVisibilityProperty); }
            set { SetValue(SeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty SeparatorVisibilityProperty =
            DependencyProperty.Register("SeparatorVisibility", typeof(Visibility), typeof(SearchBoxItem));
        #endregion

        #endregion

        #region Internal Properties
        internal SearchBox ParentSearchBox
        {
            get
            {
                return ItemsControl.ItemsControlFromItemContainer(this) as SearchBox;
            }
        }

        #region IsKeyboardHover
        public bool IsKeyboardHover
        {
            get { return (bool)GetValue(IsKeyboardHoverProperty); }
            set { SetValue(IsKeyboardHoverProperty, value); }
        }

        public static readonly DependencyProperty IsKeyboardHoverProperty =
            DependencyProperty.Register("IsKeyboardHover", typeof(bool), typeof(SearchBoxItem), new PropertyMetadata(OnIsKeyboardHoverChanged));

        #endregion

        #endregion

        #region Overrides
        protected override void OnClick()
        {
            if (ParentSearchBox != null)
            {
                ParentSearchBox.OnItemClicked(this);
            }
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            if (ParentSearchBox != null)
            {
                ParentSearchBox.OnItemHoverChanged(this);
            }
        }
        #endregion

        #region Event Handlers
        private static void OnIsKeyboardHoverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchBoxItem = (SearchBoxItem)d;
            searchBoxItem.OnIsKeyboardHoverChanged();
        }
        #endregion

        #region Functions
        private void OnIsKeyboardHoverChanged()
        {
            if (IsKeyboardHover
                && ParentSearchBox != null)
            {
                BringIntoView();
                ParentSearchBox.OnItemHoverChanged(this);
            }
        }
        #endregion
    }
}
