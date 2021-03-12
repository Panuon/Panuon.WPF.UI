using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Effects;

namespace Panuon.UI.Silver.Internal
{
    class ContentControlX : ContentControl
    {
        #region Ctor
        static ContentControlX()
        {
            FocusableProperty.OverrideMetadata(typeof(ContentControlX), new FrameworkPropertyMetadata(false));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ContentControlX), new FrameworkPropertyMetadata(typeof(ContentControlX)));
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

    }
}
