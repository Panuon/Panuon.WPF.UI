using System;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnResizeAttribute : Attribute
    {
        #region Ctor
        public ColumnResizeAttribute(bool canUserResize)
        {
            CanUserResize = canUserResize;
        }
        #endregion

        #region Properties
        public bool CanUserResize { get; set; }
        #endregion
    }
}
