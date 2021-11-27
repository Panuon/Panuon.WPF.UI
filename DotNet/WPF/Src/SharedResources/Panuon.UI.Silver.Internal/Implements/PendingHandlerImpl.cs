using Panuon.UI.Silver.Internal.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Panuon.UI.Silver.Internal.Implements
{
    class PendingHandlerImpl : IPendingHandler
    {
        #region Fields
        private PendingBoxWindow _window;
        #endregion

        #region Ctor
        public PendingHandlerImpl()
        {
        }
        #endregion

        #region Events
        public event CancelEventHandler Cancelling;

        public event EventHandler Closed;
        #endregion

        #region Methods
        public void Close()
        {
            _window.Dispatcher.Invoke(new Action(() =>
            {
                _window.Close();
            }));
        }
        #endregion

        #region Internal Methods
        internal void SetWindow(PendingBoxWindow window)
        {
            _window = window;
        }

        internal bool TriggerCancel()
        {
            var args = new CancelEventArgs();
            Cancelling?.Invoke(this, args);
            return !args.Cancel;
        }

        internal void TriggerClosed()
        {
            Closed?.Invoke(_window, new EventArgs());
        }

        public void UpdateMessage(string message)
        {
            _window.Dispatcher.Invoke(new Action(() =>
            {
                _window.UpdateMessage(message);
            }));
        }
        #endregion
    }
}
