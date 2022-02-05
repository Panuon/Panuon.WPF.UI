using System;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnWidthAttribute : Attribute
    {
        #region Ctor
        #endregion

        #region Properties
        public string Width { get; set; }

        public double MinWidth 
        {
            get => _minWidth;
            set { _minWidth = value; IsMinWidthSet = true; }
        }
        private double _minWidth;

        internal bool IsMinWidthSet { get; set; }

        public double MaxWidth
        {
            get => _maxWidth;
            set { _maxWidth = value; IsMaxWidthSet = true; }
        }
        private double _maxWidth;

        internal bool IsMaxWidthSet { get; set; }

        #endregion
    }
}
