using Panuon.WPF.UI.Internal.TemplateSelectors;
using System.Windows;
using System.Windows.Controls;

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

        #region Functions
        private void UpdateBinding()
        {
            //FrameworkElementUtil.BindingPropertyIfUndefaultAndUninherited(this, VisibilityProperty, this, ContentProperty, 
            //    (Source != null && IconHelper.GetHiddenOnNull(Source))
            //    ? (ValueConverterBase)new NullToHiddenConverter()
            //    : new NullToCollapseConverter());
        }
        #endregion
    }
}
