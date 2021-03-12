using System;
using System.Windows;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnHeaderAttribute : Attribute
    {
        #region Ctor
        public ColumnHeaderAttribute()
        {

        }

        public ColumnHeaderAttribute(VerticalAlignment verticalHeaderAlignment)
        {
            VerticalHeaderAlignment = verticalHeaderAlignment;
        }

        public ColumnHeaderAttribute(HorizontalAlignment horizontalHeaderAlignment)
        {
            HorizontalHeaderAlignment = horizontalHeaderAlignment;
        }

        public ColumnHeaderAttribute(VerticalAlignment verticalHeaderAlignment, HorizontalAlignment horizontalHeaderAlignment)
        {
            VerticalHeaderAlignment = verticalHeaderAlignment;
            HorizontalHeaderAlignment = horizontalHeaderAlignment;
        }
        #endregion

        #region Properties
        public object TemplateKey { get; set; }

        public string StringFormat { get; set; }

        public VerticalAlignment? VerticalHeaderAlignment { get; set; }

        public HorizontalAlignment? HorizontalHeaderAlignment { get; set; }
        #endregion
    }
}
