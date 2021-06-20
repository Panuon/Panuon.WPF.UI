using Panuon.UI.Core;
using System;

namespace Panuon.UI.Silver.Internal.Models
{
    class CalendarXDayItem : NotifyPropertyChangedBase
    {
        #region DisplayName
        public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
        private string _displayName;
        #endregion

        #region CurrentDate
        public DateTime CurrentDate { get => _currentDate; set => Set(ref _currentDate, value); }
        private DateTime _currentDate;
        #endregion

        #region IsSpecialDay
        public bool IsSpecialDay { get => _isSpecialDay; set => Set(ref _isSpecialDay, value); }
        private bool _isSpecialDay;
        #endregion

        #region IsToday
        public bool IsToday { get => _isToday; set => Set(ref _isToday, value); }
        private bool _isToday;
        #endregion

        #region CanSelect
        public bool CanSelect { get => _canSelect; set => Set(ref _canSelect, value); }
        private bool _canSelect;
        #endregion

        #region IsSelected
        public bool IsSelected { get => _isSelected; set => Set(ref _isSelected, value); }
        private bool _isSelected;
        #endregion

        #region IsWeakenDisplay
        public bool IsWeakenDisplay { get => _isWeakenDisplay; set => Set(ref _isWeakenDisplay, value); }
        private bool _isWeakenDisplay;
        #endregion

        #region IsInSelectionRange
        public bool IsInSelectionRange { get => _isInSelectionRange; set => Set(ref _isInSelectionRange, value); }
        private bool _isInSelectionRange;
        #endregion



    }
}
