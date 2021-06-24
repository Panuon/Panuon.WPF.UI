using System.Windows;

namespace Panuon.UI.Core
{
    public class CancelEventArgs : RoutedEventArgs
    {
        #region Ctor
        public CancelEventArgs(RoutedEvent routedEvent)
            : base(routedEvent)
        {

        }
        #endregion

        #region Properties
        public bool Cancel { get; set; }
        #endregion
    }
}
