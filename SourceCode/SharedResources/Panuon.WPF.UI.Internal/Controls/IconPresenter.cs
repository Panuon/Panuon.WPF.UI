using Panuon.WPF.UI.Internal.Converters;
using Panuon.WPF.UI.Internal.TemplateSelectors;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal
{
    class IconPresenter 
        : ContentControl
    {
        #region Ctor
        static IconPresenter()
        {
            FocusableProperty.OverrideMetadata(typeof(IconPresenter), new FrameworkPropertyMetadata(false));
            ContentTemplateSelectorProperty.OverrideMetadata(typeof(IconPresenter), new FrameworkPropertyMetadata(new IconPresenterContentTemplateSelector()));
            VerticalAlignmentProperty.OverrideMetadata(typeof(IconPresenter), new FrameworkPropertyMetadata(VerticalAlignment.Stretch));
            HorizontalAlignmentProperty.OverrideMetadata(typeof(IconPresenter), new FrameworkPropertyMetadata(HorizontalAlignment.Stretch));
        }
        #endregion

        #region Properties

        #region Source
        public FrameworkElement Source
        {
            get { return (FrameworkElement)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(FrameworkElement), typeof(IconPresenter), new PropertyMetadata(OnSourceChanged));
        #endregion

        #endregion

        #region Overrides
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }
        #endregion

        #region Event Handlers
        private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var presenter = d as IconPresenter;
                presenter.UpdateBinding();
        }
        #endregion

        #region Functions
        private void UpdateBinding()
        {
            if (Source != null)
            {

                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, HeightProperty, Source, IconHelper.HeightProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, WidthProperty, Source, IconHelper.WidthProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, VerticalContentAlignmentProperty, Source, IconHelper.VerticalAlignmentProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, HorizontalContentAlignmentProperty, Source, IconHelper.HorizontalAlignmentProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, MinWidthProperty, Source, IconHelper.MinWidthProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, MinHeightProperty, Source, IconHelper.MinHeightProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, MaxWidthProperty, Source, IconHelper.MaxWidthProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, MaxHeightProperty, Source, IconHelper.MaxHeightProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, MarginProperty, Source, IconHelper.MarginProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, FontFamilyProperty, Source, IconHelper.FontFamilyProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, ForegroundProperty, Source, IconHelper.ForegroundProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, FontSizeProperty, Source, IconHelper.FontSizeProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, ToolTipProperty, Source, IconHelper.ToolTipProperty);
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, VisibilityProperty, this, ContentProperty, 
                    (Source != null && IconHelper.GetHiddenOnNull(Source))
                    ? (ValueConverterBase)new NullToHiddenConverter()
                    : new NullToCollapseConverter());
            }
        }
        #endregion
    }
}
