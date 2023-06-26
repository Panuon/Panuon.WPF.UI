using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Panuon.WPF.UI.Internal.TemplateSelectors
{
    public class TextBlockFirstTemplateSelector
        : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if(item is string)
            {
                var textBlock = new FrameworkElementFactory(typeof(TextBlock));
                textBlock.SetValue(TextBlock.TextWrappingProperty, TextWrapping.Wrap);
                textBlock.SetValue(TextBlock.TextTrimmingProperty, TextTrimming.CharacterEllipsis);
                textBlock.SetValue(TextBlock.TextProperty, item);
                return new DataTemplate()
                {
                    VisualTree = textBlock,
                };
            }
            return base.SelectTemplate(item, container);
        }
    }
}
