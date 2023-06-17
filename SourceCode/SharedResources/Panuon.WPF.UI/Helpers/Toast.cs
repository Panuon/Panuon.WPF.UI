using Panuon.WPF.UI.Configurations;
using System.Windows;
using System.Linq;
using System;

namespace Panuon.WPF.UI
{
    public static class Toast
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey LabelStyleKey { get; } =
            new ComponentResourceKey(typeof(Toast), nameof(LabelStyleKey));
        #endregion

        #region Methods
        public static void Show(string message,
            int durationMs = 1000,
            ToastWindow targetWindow = ToastWindow.MainWindow)
        {
            Show(null, message, ToastSettings.Setting.DefaultPosition, 0, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window,
            string message,
            int durationMs = 1000)
        {
            Show(window, message, ToastSettings.Setting.DefaultPosition, 0, durationMs, null, ToastWindow.MainWindow);
        }

        public static void Show(string message,
            ToastPosition position,
            int durationMs = 1000,
            ToastWindow targetWindow = ToastWindow.MainWindow)
        {
            Show(null, message, position, 0, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window,
            string message,
            ToastPosition position,
            int durationMs = 1000)
        {
            Show(window, message, position, 0, durationMs, null, ToastWindow.MainWindow);
        }

        public static void Show(string message,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastWindow targetWindow = ToastWindow.MainWindow)
        {
            Show(null, message, position, offset, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window,
            string message,
            ToastPosition position,
            double offset,
            int durationMs)
        {
            Show(window, message, position, offset, durationMs, null, ToastWindow.MainWindow);
        }

        public static void Show(WindowX window,
            string message,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastSetting setting)
        {
            Show(window, message, position, offset, durationMs, setting, ToastWindow.MainWindow);
        }

        public static void Show(string message,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastSetting setting,
            ToastWindow targetWindow = ToastWindow.MainWindow)
        {
            Show(null, message, position, offset, durationMs, setting, targetWindow);
        }
        #endregion

        #region Functions
        private static void Show(WindowX window,
            string message,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastSetting setting,
            ToastWindow targetWindow)
        {
            window = window ?? GetTargetWindow(targetWindow);
            window.Toast(message, position, offset, durationMs, setting);
        }

        private static WindowX GetTargetWindow(ToastWindow window)
        {
            switch(window)
            {
                case ToastWindow.MainWindow:
                    if(Application.Current.MainWindow is WindowX windowX)
                    {
                        return windowX;
                    }
                    throw new ArgumentException("Toast : The main window in Application.Current is null, or the window is not of type Panuon.WPF.UI.WindowX. Please try to specify window parameter for Toast method.");
                default:
                    foreach (var loopObj in Application.Current.Windows)
                    {
                        if (loopObj is Window loopWindow
                            && loopWindow.IsActive)
                        {
                            if (loopWindow is WindowX)
                            {
                                return loopWindow as WindowX;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    throw new ArgumentException("Toast : The activated window cannot be found in Application.Current, or the window is not of type Panuon.WPF.UI.WindowX. Please try to specify window parameter for Toast method.");
            }
        }
        #endregion
    }
}
