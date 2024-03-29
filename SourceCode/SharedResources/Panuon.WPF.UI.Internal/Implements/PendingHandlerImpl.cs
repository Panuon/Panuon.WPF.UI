﻿using Panuon.WPF.UI.Internal.Controls;
using System;
using System.ComponentModel;

namespace Panuon.WPF.UI.Internal.Implements
{
    class PendingHandlerImpl : IPendingHandler
    {
        #region Fields
        private WeakReference _window;
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
            try
            {
                if (_window.IsAlive && _window.Target is PendingBoxWindow window)
                {
                    window.Dispatcher.Invoke(new Action(() =>
                    {
                        window.Close();
                    }));
                }
            }
            catch
            {
            }
        }

        public void Hide()
        {
            try
            {
                if (_window.IsAlive && _window.Target is PendingBoxWindow window)
                {
                    window.Dispatcher.Invoke(new Action(() =>
                    {
                        window.Hide();
                    }));
                }
            }
            catch
            {
            }
        }

        public void Show()
        {
            try
            {
                if (_window.IsAlive && _window.Target is PendingBoxWindow window)
                {
                    window.Dispatcher.Invoke(new Action(() =>
                    {
                        window.Show();
                    }));
                }
            }
            catch
            {
            }
        }
        #endregion

        #region Internal Methods
        internal void SetWindow(PendingBoxWindow window)
        {
            _window = new WeakReference(window);
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
            if (_window.IsAlive && _window.Target is PendingBoxWindow window)
            {
                window.Dispatcher.Invoke(new Action(() =>
                {
                    window.UpdateMessage(message);
                }));
            }
        }
        #endregion
    }
}
