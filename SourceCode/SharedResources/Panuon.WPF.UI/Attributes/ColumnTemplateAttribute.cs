using System;

namespace Panuon.WPF.UI
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnTemplateAttribute : Attribute
    {
        public object CellTemplateKey { get; set; }

        public object CellEditingTemplateKey { get; set; }
    }
}
