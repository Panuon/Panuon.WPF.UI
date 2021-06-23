using System.Windows;

namespace Panuon.UI.Core
{
    public class SelectedValueChangedEventArgs<T> : RoutedEventArgs
    {
        #region Ctor
        public SelectedValueChangedEventArgs(RoutedEvent routedEvent, T newValue, T oldValue)
            : base(routedEvent)
        {
            NewValue = newValue;
            OldValue = oldValue;
        }
        #endregion

        #region Properties
        public T NewValue { get; }

        public T OldValue { get; }
        #endregion
    }
}
