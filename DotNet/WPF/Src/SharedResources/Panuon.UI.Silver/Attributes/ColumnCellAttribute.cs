using System;
using System.Windows;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnCellAttribute : Attribute
    {
        #region Ctor
        public ColumnCellAttribute()
        {

        }

        public ColumnCellAttribute(HorizontalAlignment horizontalContentAlignment)
        {
            HorizontalContentAlignment = horizontalContentAlignment;
        }

        public ColumnCellAttribute(VerticalAlignment verticalContentAlignment)
        {
            VerticalContentAlignment = verticalContentAlignment;
        }

        public ColumnCellAttribute(HorizontalAlignment horizontalContentAlignment, VerticalAlignment verticalContentAlignment)
        {
            VerticalContentAlignment = verticalContentAlignment;
            HorizontalContentAlignment = horizontalContentAlignment;
        }
        #endregion

        #region Properties
        public object ElementStyleKey { get; set; }

        public object EditingElementStyleKey { get; set; }

        public VerticalAlignment? VerticalContentAlignment { get; }

        public HorizontalAlignment? HorizontalContentAlignment { get; }

        public string Foreground { get; set; }

        public string ForegroundBrushKey { get; set; }

        public string Background { get; set; }

        public string BackgroundBrushKey { get; set; }
        #endregion
    }
}
