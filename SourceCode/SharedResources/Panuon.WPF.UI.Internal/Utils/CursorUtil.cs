using System;
using System.Windows;
using System.Windows.Input;

namespace Panuon.WPF.UI.Internal.Utils
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
                    var info = Application.GetResourceStream(new Uri("/Panuon.WPF;component/Resources/dropper.cur", UriKind.Relative));
#if NET452
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
