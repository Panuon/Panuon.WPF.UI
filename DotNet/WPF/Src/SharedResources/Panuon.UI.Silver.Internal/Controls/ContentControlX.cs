using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Linq;

namespace Panuon.UI.Silver.Internal
{
    [TemplatePart(Name = IconPresenterPartName, Type = typeof(IconPresenter))]
    class ContentControlX : ContentControl
    {
        #region Fields
        private const string IconPresenterPartName = "PART_Icon";

        private IconPresenter _iconPresenter;
        #endregion

        #region Ctor
        static ContentControlX()
        {
            FocusableProperty.OverrideMetadata(typeof(ContentControlX), new FrameworkPropertyMetadata(false));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ContentControlX), new FrameworkPropertyMetadata(typeof(ContentControlX)));
        }
        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            
            _iconPresenter = GetTemplateChild(IconPresenterPartName) as IconPresenter;
            if (IconForeground != null)
            {
                _iconPresenter.Foreground = IconForeground;
            }
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
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ContentControlX));
        #endregion

        #region Effect
        public new Effect Effect
        {
            get { return (Effect)GetValue(EffectProperty); }
            set { SetValue(EffectProperty, value); }
        }

        public new static readonly DependencyProperty EffectProperty =
            DependencyProperty.Register("Effect", typeof(Effect), typeof(ContentControlX));
        #endregion

        #region Icon
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(ContentControlX));
        #endregion

        #region IconForeground
        public Brush IconForeground
        {
            get { return (Brush)GetValue(IconForegroundProperty); }
            set { SetValue(IconForegroundProperty, value); }
        }

        public static readonly DependencyProperty IconForegroundProperty =
            DependencyProperty.Register("IconForeground", typeof(Brush), typeof(ContentControlX), new PropertyMetadata(OnIconForegroundChanged));

        private static void OnIconForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var contentControl = (ContentControlX)d;
            contentControl.OnIconForegroundChanged();
        }
        #endregion

        #region IconPlacement
        public IconPlacement IconPlacement
        {
            get { return (IconPlacement)GetValue(IconPlacementProperty); }
            set { SetValue(IconPlacementProperty, value); }
        }

        public static readonly DependencyProperty IconPlacementProperty =
            DependencyProperty.Register("IconPlacement", typeof(IconPlacement), typeof(ContentControlX));
        #endregion

        #region IconWidth
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(ContentControlX), new PropertyMetadata(double.NaN));
        #endregion

        #region Source
        public FrameworkElement Source
        {
            get { return (FrameworkElement)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(FrameworkElement), typeof(ContentControlX));
        #endregion

        #endregion

        #region Functions
        private void OnIconForegroundChanged()
        {

            if (_iconPresenter != null)
            {
                if (IconForeground != null)
                {
                    var bindingProperty = BindingOperations.GetBinding(Source, IconHelper.ForegroundProperty)?.Path?.PathParameters?.FirstOrDefault() as DependencyProperty;
                    if(bindingProperty != null && bindingProperty.OwnerType == typeof(Internal.VisualStateHelper))
                    {
                        _iconPresenter.Foreground = IconForeground;
                    }
                }
                else
                {
                    var bindingProperty = BindingOperations.GetBinding(Source, IconHelper.ForegroundProperty)?.Path?.PathParameters?.FirstOrDefault() as DependencyProperty;
                    if (bindingProperty != null && bindingProperty.OwnerType == typeof(Internal.VisualStateHelper))
                    {
                        FrameworkElementUtil.BindingProperty(_iconPresenter, IconPresenter.ForegroundProperty, Source, IconHelper.ForegroundProperty);
                    }
                }
            }

        }
        #endregion

    }
}
