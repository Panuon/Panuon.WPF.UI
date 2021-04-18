using System;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal
{
    internal class FormGroupSizeDeterminedEventArgs : EventArgs
    {
        #region Ctor
        public FormGroupSizeDeterminedEventArgs(Orientation orientation, double size)
        {
            Orientation = orientation;
            Size = size;
        }
        #endregion

        #region Properties
        public Orientation Orientation { get; }

        public double Size { get; }
        #endregion
    }
}
