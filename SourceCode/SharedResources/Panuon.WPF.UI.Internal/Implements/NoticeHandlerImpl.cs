using System;

namespace Panuon.WPF.UI.Internal.Implements
{
    class NoticeHandlerImpl : INoticeHandler
    {
        #region Fields
        private bool _isClosed;

        private NoticeBoxItem _noticeBoxItem;
        #endregion

        #region Ctor
        public NoticeHandlerImpl(NoticeBoxItem noticeBoxItem)
        {
            _noticeBoxItem = noticeBoxItem;
        }
        #endregion

        #region Events
        public event EventHandler Click;

        public event EventHandler Closed;
        #endregion

        #region Methods
        public void Close()
        {
            try
            {
                _noticeBoxItem.Close();
            }
            catch
            {

            }
        }

        internal void TriggerClicked(NoticeBoxItem noticeBoxItem)
        {
            Click?.Invoke(noticeBoxItem, new EventArgs());
        }

        internal void TriggerClosed(NoticeBoxItem noticeBoxItem)
        {
            Closed?.Invoke(noticeBoxItem, new EventArgs());
        }
        #endregion
    }
}