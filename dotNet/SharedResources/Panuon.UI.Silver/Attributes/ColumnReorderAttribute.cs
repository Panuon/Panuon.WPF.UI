using System;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnReorderAttribute : Attribute
    {
        #region Ctor
        public ColumnReorderAttribute(bool canUserReorder)
        {
            CanUserReorder = canUserReorder;
        }
        #endregion

        #region Properties
        public bool CanUserReorder { get; set; }
        #endregion
    }
}
