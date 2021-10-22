using System;

namespace Panuon.UI.Silver
{
    public interface INoticeHandler
    {
        event EventHandler Click;

        event EventHandler Closed;

        void Close();
    }
}