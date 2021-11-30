using System.Windows;

namespace Panuon.UI.Core
{
    public class PositionChangedEventArgs : RoutedEventArgs
    {
        #region Ctor
        public PositionChangedEventArgs(RoutedEvent routedEvent, Point position)
            : base(routedEvent)
        {
            Position = position;
        }
        #endregion

        #region Properties
        public Point Position { get; }
        #endregion
    }
}
