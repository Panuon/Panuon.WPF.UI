using System;
using System.Windows;
using System.Windows.Input;

namespace Panuon.UI.Silver.Internal.Utils
{
    static class CursorUtil
    {
        #region Properties
        public static Cursor DropperCursor
        {
            get
            {
                if(_dropperCursor == null)
                {
                    var info = Application.GetResourceStream(new Uri("/Panuon.UI.Silver;component/Resources/dropper.cur", UriKind.Relative));
#if NET40
                    _dropperCursor = new Cursor(info.Stream);
#elif NET45
                    _dropperCursor = new Cursor(info.Stream);
#else
                    _dropperCursor = new Cursor(info.Stream, true);
#endif
                }
                return _dropperCursor;
            }
        }
        private static Cursor _dropperCursor;
#endregion
    }
}
