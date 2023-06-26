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
