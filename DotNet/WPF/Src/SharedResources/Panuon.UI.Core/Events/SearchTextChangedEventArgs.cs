using System.Windows;

namespace Panuon.UI.Core
{
    public class SearchTextChangedEventArgs : RoutedEventArgs
    {
        #region Ctor
        public SearchTextChangedEventArgs(RoutedEvent routedEvent, string text)
            : base(routedEvent)
        {
            Text = text;
        }
        #endregion

        #region Properties
        public string Text { get; set; }
        #endregion
    }
}
