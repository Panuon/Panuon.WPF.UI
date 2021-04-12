using System;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnComboAttribute : Attribute
    {
        #region Properties
        public string ItemsSourceBindingPath { get; set; }

        public string DisplayMemberPath { get; set; }

        public string SelectedValuePath { get; set; }
        #endregion
    }
}
