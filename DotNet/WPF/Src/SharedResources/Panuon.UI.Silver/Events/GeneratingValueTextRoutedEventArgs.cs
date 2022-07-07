using System.Windows;

namespace Panuon.UI.Silver
{
    public class GeneratingValueTextRoutedEventArgs : RoutedEventArgs
    {
        #region Ctor
        public GeneratingValueTextRoutedEventArgs(RoutedEvent routedEvent, 
            double value, 
            string text)
            : base(routedEvent)
        {
            Value = value;
            Text = text;
        }
        #endregion

        #region Properties
        public double Value { get; }

        public string Text { get; set; }
        #endregion
    }
}
