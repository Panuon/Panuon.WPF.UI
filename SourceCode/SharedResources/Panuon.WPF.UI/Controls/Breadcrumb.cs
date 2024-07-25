using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [ContentProperty(nameof(Items))]
    public class Breadcrumb 
        : ItemsControl
    {
        #region Ctor
        static Breadcrumb()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Breadcrumb), new FrameworkPropertyMetadata(typeof(Breadcrumb)));
        }

        public Breadcrumb()
        {
            AddHandler(BreadcrumbItem.ClickEvent, new RoutedEventHandler(OnBreadcrumbItemClick));
        }
        #endregion

        #region Events

        #region ItemClick
        public event RoutedEventHandler ItemClick
        {
            add { AddHandler(ItemClickEvent, value); }
            remove { RemoveHandler(ItemClickEvent, value); }
        }

        public static readonly RoutedEvent ItemClickEvent =
            EventManager.RegisterRoutedEvent("ItemClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Breadcrumb));
        #endregion

        #endregion

        #region Overrides
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is BreadcrumbItem;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new BreadcrumbItem();
        }
        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey SeparatorTemplateKey { get; } =
            new ComponentResourceKey(typeof(Breadcrumb), nameof(SeparatorTemplateKey));
        #endregion
        
        #region Properties

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(Breadcrumb));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(Breadcrumb));
        #endregion

        #region ItemsProperties
        
        #region ItemsIcon
        public object ItemsIcon
        {
            get { return (object)GetValue(ItemsIconProperty); }
            set { SetValue(ItemsIconProperty, value); }
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.Register("ItemsIcon", typeof(object), typeof(Breadcrumb));
        #endregion

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(Breadcrumb));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(Breadcrumb));
        #endregion

        #region ItemsMargin
        public Thickness ItemsMargin
        {
            get { return (Thickness)GetValue(ItemsMarginProperty); }
            set { SetValue(ItemsMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.Register("ItemsMargin", typeof(Thickness), typeof(Breadcrumb));
        #endregion

        #region ItemsPadding
        public Thickness ItemsPadding
        {
            get { return (Thickness)GetValue(ItemsPaddingProperty); }
            set { SetValue(ItemsPaddingProperty, value); }
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.Register("ItemsPadding", typeof(Thickness), typeof(Breadcrumb));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(Breadcrumb));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(Breadcrumb));
        #endregion

        #region ItemsBorderThickness
        public Thickness ItemsBorderThickness
        {
            get { return (Thickness)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness), typeof(Breadcrumb));
        #endregion

        #region ItemsHoverBackground
        public Brush ItemsHoverBackground
        {
            get { return (Brush)GetValue(ItemsHoverBackgroundProperty); }
            set { SetValue(ItemsHoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.Register("ItemsHoverBackground", typeof(Brush), typeof(Breadcrumb));
        #endregion

        #region ItemsHoverForeground
        public Brush ItemsHoverForeground
        {
            get { return (Brush)GetValue(ItemsHoverForegroundProperty); }
            set { SetValue(ItemsHoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.Register("ItemsHoverForeground", typeof(Brush), typeof(Breadcrumb));
        #endregion

        #region ItemsHoverBorderBrush
        public Brush ItemsHoverBorderBrush
        {
            get { return (Brush)GetValue(ItemsHoverBorderBrushProperty); }
            set { SetValue(ItemsHoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.Register("ItemsHoverBorderBrush", typeof(Brush), typeof(Breadcrumb));
        #endregion

        #region ItemsHoverBorderThickness
        public Thickness? ItemsHoverBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsHoverBorderThicknessProperty); }
            set { SetValue(ItemsHoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderThicknessProperty =
            DependencyProperty.Register("ItemsHoverBorderThickness", typeof(Thickness?), typeof(Breadcrumb));
        #endregion

        #region ItemsHoverCornerRadius
        public CornerRadius? ItemsHoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(ItemsHoverCornerRadiusProperty); }
            set { SetValue(ItemsHoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverCornerRadiusProperty =
            DependencyProperty.Register("ItemsHoverCornerRadius", typeof(CornerRadius?), typeof(Breadcrumb));
        #endregion

        #region ItemsHoverShadowColor
        public Color? ItemsHoverShadowColor
        {
            get { return (Color?)GetValue(ItemsHoverShadowColorProperty); }
            set { SetValue(ItemsHoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverShadowColorProperty =
            DependencyProperty.Register("ItemsHoverShadowColor", typeof(Color?), typeof(Breadcrumb));
        #endregion

        #region ItemsClickBackground
        public Brush ItemsClickBackground
        {
            get { return (Brush)GetValue(ItemsClickBackgroundProperty); }
            set { SetValue(ItemsClickBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickBackgroundProperty =
            DependencyProperty.Register("ItemsClickBackground", typeof(Brush), typeof(Breadcrumb));
        #endregion

        #region ItemsClickForeground
        public Brush ItemsClickForeground
        {
            get { return (Brush)GetValue(ItemsClickForegroundProperty); }
            set { SetValue(ItemsClickForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickForegroundProperty =
            DependencyProperty.Register("ItemsClickForeground", typeof(Brush), typeof(Breadcrumb));
        #endregion

        #region ItemsClickBorderBrush
        public Brush ItemsClickBorderBrush
        {
            get { return (Brush)GetValue(ItemsClickBorderBrushProperty); }
            set { SetValue(ItemsClickBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickBorderBrushProperty =
            DependencyProperty.Register("ItemsClickBorderBrush", typeof(Brush), typeof(Breadcrumb));
        #endregion

        #region ItemsClickBorderThickness
        public Thickness? ItemsClickBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsClickBorderThicknessProperty); }
            set { SetValue(ItemsClickBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickBorderThicknessProperty =
            DependencyProperty.Register("ItemsClickBorderThickness", typeof(Thickness?), typeof(Breadcrumb));
        #endregion

        #region ItemsClickCornerRadius
        public CornerRadius? ItemsClickCornerRadius
        {
            get { return (CornerRadius?)GetValue(ItemsClickCornerRadiusProperty); }
            set { SetValue(ItemsClickCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickCornerRadiusProperty =
            DependencyProperty.Register("ItemsClickCornerRadius", typeof(CornerRadius?), typeof(Breadcrumb));
        #endregion

        #region ItemsClickEffect
        public ClickEffect ItemsClickEffect
        {
            get { return (ClickEffect)GetValue(ItemsClickEffectProperty); }
            set { SetValue(ItemsClickEffectProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickEffectProperty =
            DependencyProperty.Register("ItemsClickEffect", typeof(ClickEffect), typeof(Breadcrumb));
        #endregion

        #region ItemsSeparatorTemplate
        public DataTemplate ItemsSeparatorTemplate
        {
            get { return (DataTemplate)GetValue(ItemsSeparatorTemplateProperty); }
            set { SetValue(ItemsSeparatorTemplateProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorTemplateProperty =
            DependencyProperty.Register("ItemsSeparatorTemplate", typeof(DataTemplate), typeof(Breadcrumb));
        #endregion

        #region ItemsSeparatorMargin
        public Thickness ItemsSeparatorMargin
        {
            get { return (Thickness)GetValue(ItemsSeparatorMarginProperty); }
            set { SetValue(ItemsSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.Register("ItemsSeparatorMargin", typeof(Thickness), typeof(Breadcrumb));
        #endregion
        
        #endregion
        
        #endregion

        #region Event Handlers
        private void OnBreadcrumbItemClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ItemClickEvent, e.OriginalSource));
        }
        #endregion

    }
}
