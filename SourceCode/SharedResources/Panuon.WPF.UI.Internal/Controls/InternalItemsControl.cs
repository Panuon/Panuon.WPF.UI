using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal
{
    internal class InternalItemsControl
        : ItemsControl
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ContentControl();
        }
    }
}
