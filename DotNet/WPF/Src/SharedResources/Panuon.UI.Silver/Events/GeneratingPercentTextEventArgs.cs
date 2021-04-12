using System.Windows;

namespace Panuon.UI.Silver
{
    public class GeneratingPercentTextEventArgs : RoutedEventArgs
    {
        #region Ctor
        public GeneratingPercentTextEventArgs(RoutedEvent routedEvent, double value, double percent, string text)
            : base(routedEvent)
        {
            Value = value;
            Percent = percent;
            Text = text;
        }
        #endregion

        #region Properties

        public double Value { get; }

        public double Percent { get; }

        public string Text { get; set; }

        #endregion
    }
}
