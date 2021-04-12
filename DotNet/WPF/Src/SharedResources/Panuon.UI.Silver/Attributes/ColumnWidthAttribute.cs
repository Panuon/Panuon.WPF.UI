using System;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnWidthAttribute : Attribute
    {
        #region Ctor
        public ColumnWidthAttribute() 
        {
        }

        public ColumnWidthAttribute(string width)
        {
            Width = width;
        }

        public ColumnWidthAttribute(string width, double minWidth)
            : this(width)
        {
            MinWidth = minWidth;
        }

        public ColumnWidthAttribute(string width, double minWidth, double maxWidth)
            : this(width, minWidth)
        {
            MaxWidth = maxWidth;
        }
        #endregion

        #region Properties
        public string Width { get; set; }

        public double? MinWidth { get; set; }

        public double? MaxWidth { get; set; }
        #endregion
    }
}
