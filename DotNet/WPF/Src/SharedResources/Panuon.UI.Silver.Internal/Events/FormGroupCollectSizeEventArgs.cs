using System;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal
{
    internal class FormGroupCollectSizeEventArgs : EventArgs
    {
        #region Ctor
        public FormGroupCollectSizeEventArgs(Orientation orientation, double size)
        {
            Orientation = orientation;
            Maximuim = size;
        }
        #endregion

        #region Properties
        public Orientation Orientation { get; }

        public double Maximuim { get; set; }
        #endregion
    }
}
