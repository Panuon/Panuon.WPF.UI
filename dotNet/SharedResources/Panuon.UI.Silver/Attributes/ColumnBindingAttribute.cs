using System;
using System.Windows.Data;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnBindingAttribute :Attribute
    {
        #region Properties
        public UpdateSourceTrigger? UpdateSourceTrigger { get; set; }

        public BindingMode? Mode { get; set; }

        public Type ConverterType { get; set; }

        public object ConverterParameter { get; set; }

        public string StringFormat { get; set; }
        #endregion
    }
}
