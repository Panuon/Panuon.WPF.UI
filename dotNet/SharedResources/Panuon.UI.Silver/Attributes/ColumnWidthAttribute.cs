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
        #endregion

        #region Properties
        public string Width { get; set; }

        public double? MinWidth { get; set; }

        public double? MaxWidth { get; set; }
        #endregion
    }
}
