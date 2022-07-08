using System;
using System.Windows;

namespace Panuon.WPF.UI
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnHeaderAttribute : Attribute
    {
        #region Ctor
        public ColumnHeaderAttribute()
        {

        }

        public ColumnHeaderAttribute(HorizontalAlignment horizontalHeaderAlignment)
        {
            HorizontalHeaderAlignment = horizontalHeaderAlignment;
        }

        public ColumnHeaderAttribute(VerticalAlignment verticalHeaderAlignment)
        {
            VerticalHeaderAlignment = verticalHeaderAlignment;
        }

        public ColumnHeaderAttribute(HorizontalAlignment horizontalHeaderAlignment, VerticalAlignment verticalHeaderAlignment)
        {
            HorizontalHeaderAlignment = horizontalHeaderAlignment;
            VerticalHeaderAlignment = verticalHeaderAlignment;
        }
        #endregion

        #region Properties
        public object TemplateKey { get; set; }

        public string StringFormat { get; set; }

        public VerticalAlignment? VerticalHeaderAlignment { get; }

        public HorizontalAlignment? HorizontalHeaderAlignment { get; }

        public string Foreground { get; set; }

        public string ForegroundBrushKey { get; set; }

        public string Background { get; set; }

        public string BackgroundBrushKey { get; set; }
        #endregion
    }
}
