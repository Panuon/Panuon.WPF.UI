using System;

namespace Panuon.WPF.UI
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnDisplayIndexAttribute : Attribute
    {
        #region Ctor
        public ColumnDisplayIndexAttribute(int displayIndex)
        {
            DisplayIndex = displayIndex;
        }
        #endregion

        #region Properties
        public int DisplayIndex { get; set; }
        #endregion
    }
}
