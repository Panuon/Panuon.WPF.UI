using System;
using System.Windows.Data;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnBindingAttribute :Attribute
    {
        #region Ctor
        public ColumnBindingAttribute()
        {

        }

        public ColumnBindingAttribute(UpdateSourceTrigger updateSourceTrigger)
        {
            UpdateSourceTrigger = updateSourceTrigger;
        }

        public ColumnBindingAttribute(BindingMode bindingMode)
        {
            BindingMode = bindingMode;
        }

        public ColumnBindingAttribute(BindingMode bindingMode,
            UpdateSourceTrigger updateSourceTrigger)
        {
            BindingMode = bindingMode;
            UpdateSourceTrigger = updateSourceTrigger;
        }
        #endregion

        #region Properties
        public UpdateSourceTrigger? UpdateSourceTrigger { get; }

        public BindingMode? BindingMode { get; }

        public Type ConverterType { get; set; }

        public object ConverterParameter { get; set; }

        public string StringFormat { get; set; }
        #endregion
    }
}
