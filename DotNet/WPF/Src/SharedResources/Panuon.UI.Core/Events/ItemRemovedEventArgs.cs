using System.Windows;

namespace Panuon.UI.Core
{
    public class ItemRemovedEventArgs : RoutedEventArgs
    {
        #region Ctor
        public ItemRemovedEventArgs(RoutedEvent routedEvent, object item)
            : base(routedEvent)
        {
            Item = item;
        }
        #endregion

        #region Properties
        public object Item { get; set; }
        #endregion
    }
}
