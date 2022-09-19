using System;
using System.ComponentModel;

namespace Panuon.WPF.UI
{
    public interface IPendingHandler
    {
        event CancelEventHandler Cancelling;

        event EventHandler Closed;
         
        void Close();

        void Hide();

        void Show();

        void UpdateMessage(string message);
    }
}