using System;
using System.ComponentModel;

namespace Panuon.UI.Silver
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnSortAttribute : Attribute
    {
        #region Ctor
        public ColumnSortAttribute(bool canUserSort)
        {
            CanUserSort = canUserSort;
        }

        public ColumnSortAttribute(bool canUserSort, ListSortDirection sortDirection)
            : this (canUserSort)
        {
            SortDirection = sortDirection;
        }
        #endregion

        #region Properties
        public bool CanUserSort { get; set; }

        public string SortMemberPath { get; set; }

        public ListSortDirection? SortDirection { get; set; }
        #endregion
    }
}
