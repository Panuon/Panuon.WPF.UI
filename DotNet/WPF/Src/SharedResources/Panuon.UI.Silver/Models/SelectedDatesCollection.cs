using System;
using Panuon.UI.Core;

namespace Panuon.UI.Silver
{
    class SelectedDatesCollection : ObservableCollectionX<DateTime>
    {
        #region Fields
        private CalendarX _calendarX;

        private bool _isAddingRange;
        #endregion

        #region Ctor
        public SelectedDatesCollection(CalendarX calendarX)
        {
            _calendarX = calendarX;
        }
        #endregion

        #region Methods

        #region AddRange
        public void AddRange(DateTime start, DateTime end)
        {
            _isAddingRange = true;

            _isAddingRange = false;
        }
        #endregion

        #endregion

        #region Functions
        #endregion
    }
}
