using System;
using System.ComponentModel;

namespace Panuon.WPF.UI
{
    public interface IPendingHandler
    {
        event CancelEventHandler Cancelling;

        event EventHandler Closed;
         
        void Close();

        void UpdateMessage(string message);
    }
}