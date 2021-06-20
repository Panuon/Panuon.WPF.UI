using System;

namespace Panuon.UI.Silver
{
    public class CalendarXSpecialDay
    {
        #region Ctor
        public CalendarXSpecialDay(string displayName, DateTime date)
        {
            DisplayName = displayName;
            Date = date.Date;
        }
        #endregion


        #region Properties
        public string DisplayName { get; }

        public DateTime Date { get; }
        #endregion
    }
}
