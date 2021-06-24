using System;
using System.Windows;
#if NET40
using Microsoft.Windows.Shell;
#else
using System.Windows.Shell;
#endif

namespace Panuon.UI.Silver.Utils
{
    static class WindowChromeUtil
    {
        internal static void SetIsHitTestVisibleInChrome(UIElement element, bool hitTestVisible)
        {
            WindowChrome.SetIsHitTestVisibleInChrome(element, hitTestVisible);
        }

        internal static void SetCaptionHeight(WindowX windowX, double height)
        {
            var action = new Action(() =>
            {
                var chrome = WindowChrome.GetWindowChrome(windowX);
                if (chrome == null)
                {
                    return;
                }
                chrome.CaptionHeight = height;
            });

            if (windowX.IsLoaded)
            {
                action();
            }
            else
            {
                windowX.Dispatcher.BeginInvoke(new Action(() =>
                {
                    action();
                }), System.Windows.Threading.DispatcherPriority.Loaded);
            }

        }

    }
}
