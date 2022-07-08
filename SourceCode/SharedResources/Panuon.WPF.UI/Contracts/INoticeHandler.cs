using System;

namespace Panuon.WPF.UI
{
    public interface INoticeHandler
    {
        event EventHandler Click;

        event EventHandler Closed;

        void Close();
    }
}