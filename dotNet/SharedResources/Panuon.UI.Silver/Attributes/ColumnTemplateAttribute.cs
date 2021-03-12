using System;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnTemplateAttribute : Attribute
    {
        public object CellTemplateKey { get; set; }

        public object CellEditingTemplateKey { get; set; }
    }
}
