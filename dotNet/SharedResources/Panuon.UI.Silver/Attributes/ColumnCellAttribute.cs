using System;
using System.Windows;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnCellAttribute : Attribute
    {
        #region Ctor
        public ColumnCellAttribute()
        {

        }

        public ColumnCellAttribute(VerticalAlignment verticalContentAlignment)
        {
            VerticalContentAlignment = verticalContentAlignment;
        }

        public ColumnCellAttribute(HorizontalAlignment horizontalContentAlignment)
        {
            HorizontalContentAlignment = horizontalContentAlignment;
        }

        public ColumnCellAttribute(VerticalAlignment verticalContentAlignment, HorizontalAlignment horizontalContentAlignment)
        {
            VerticalContentAlignment = verticalContentAlignment;
            HorizontalContentAlignment = horizontalContentAlignment;
        }
        #endregion

        #region Properties
        public object ElementStyleKey { get; set; }

        public object EditingElementStyleKey { get; set; }

        public VerticalAlignment? VerticalContentAlignment { get; set; }

        public HorizontalAlignment? HorizontalContentAlignment { get; set; }
        #endregion
    }
}
