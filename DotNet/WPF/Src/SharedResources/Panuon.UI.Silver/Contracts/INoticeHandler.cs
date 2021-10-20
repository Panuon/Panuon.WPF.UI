using System;

namespace Panuon.UI.Silver
{
    public interface INoticeHandler
    {
        event EventHandler Clicked;

        event EventHandler Closed;

        void Close();
    }
}