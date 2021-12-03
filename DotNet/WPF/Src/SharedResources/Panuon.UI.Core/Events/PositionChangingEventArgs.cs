using System.Windows;

namespace Panuon.UI.Core
{
    public class PositionChangingEventArgs : CancelEventArgs
    {
        #region Ctor
        public PositionChangingEventArgs(RoutedEvent routedEvent, Point position)
            : base(routedEvent)
        {
            NewPosition = position;
        }
        #endregion

        #region Properties
        public Point NewPosition { get; set; }
        #endregion
    }
}
