using System;
using System.ComponentModel;

namespace Panuon.UI.Silver
{
    public interface IPendingHandler
    {
        event CancelEventHandler Cancelling;

        event EventHandler Closed;
         
        void Close();

        void UpdateMessage(string message);
    }
}