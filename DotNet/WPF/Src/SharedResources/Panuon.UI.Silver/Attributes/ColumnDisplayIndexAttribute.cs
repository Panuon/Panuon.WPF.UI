using System;

namespace Panuon.UI.Silver
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
