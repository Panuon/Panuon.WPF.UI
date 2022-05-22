using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.TemplateSelectors
{
    class WatermarkTemplateSelector : DataTemplateSelector
    {
        internal static WatermarkTemplateSelector Selector { get; } = new WatermarkTemplateSelector();

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item != null)
            {
                if (item is string stringItem)
                {
                    return CreateTextBlockTemplate(item);
                }
            }
            return CreateContentDataTemplate(item);
        }

        #region Function
        private DataTemplate CreateTextBlockTemplate(object item)
        {
            var factory = new FrameworkElementFactory(typeof(TextBlock));
            factory.SetBinding(TextBlock.TextProperty, new Binding() { Source = item });
            factory.SetBinding(TextBlock.MarginProperty, new Binding() { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(ContentControl), 1), Path = new PropertyPath(Control.PaddingProperty) });
            factory.SetValue(TextBlock.TextTrimmingProperty, TextTrimming.CharacterEllipsis);
            var dataTemplate = new DataTemplate
            {
                VisualTree = factory
            };
            dataTemplate.Seal();
            return dataTemplate;
        }

        private DataTemplate CreateContentDataTemplate(object item)
        {
            var factory = new FrameworkElementFactory(typeof(ContentPresenter));
            factory.SetBinding(ContentPresenter.ContentProperty, new Binding() { Source = item });
            factory.SetValue(ContentPresenter.FocusableProperty, false);
            factory.SetBinding(ContentPresenter.MarginProperty, new Binding() { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(ContentControl), 1), Path = new PropertyPath(ContentControl.PaddingProperty) });
            factory.SetBinding(ContentPresenter.VerticalAlignmentProperty, new Binding() { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(ContentControl), 1), Path = new PropertyPath(ContentControl.VerticalContentAlignmentProperty) });
            factory.SetBinding(ContentPresenter.HorizontalAlignmentProperty, new Binding() { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(ContentControl), 1), Path = new PropertyPath(Control.HorizontalContentAlignmentProperty) });
            var dataTemplate = new DataTemplate
            {
                VisualTree = factory
            };
            dataTemplate.Seal();
            return dataTemplate;
        }
        #endregion

    }

}
