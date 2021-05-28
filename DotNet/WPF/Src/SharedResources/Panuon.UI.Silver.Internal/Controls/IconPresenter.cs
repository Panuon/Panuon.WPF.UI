using Panuon.UI.Silver.Internal.Converters;
using Panuon.UI.Silver.Internal.TemplateSelectors;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal
{
    class IconPresenter : ContentControl
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
            UpdateBinding();
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
            if (Source != null && IsInitialized)
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
                FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, VisibilityProperty, this, ContentProperty, new NullToCollapseConverter());
            }
        }
        #endregion
    }
}
