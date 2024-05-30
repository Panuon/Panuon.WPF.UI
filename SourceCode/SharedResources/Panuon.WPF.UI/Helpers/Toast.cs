using Panuon.WPF.UI.Configurations;
using System.Windows;
using System.Linq;
using System;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class Toast
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey LabelStyleKey { get; } =
            new ComponentResourceKey(typeof(Toast), nameof(LabelStyleKey));

        public static ComponentResourceKey ContentTemplateKey { get; } =
            new ComponentResourceKey(typeof(Toast), nameof(ContentTemplateKey));
        #endregion

        #region Methods
        public static void Show(string message,
            int durationMs = 1000,
            ToastWindow targetWindow = ToastWindow.ActiveWindow)
        {
            CallToast(null, message, null, ToastSettings.Setting.DefaultPosition, 0, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window,
            string message,
            int durationMs = 1000)
        {
            CallToast(window, message, null, ToastSettings.Setting.DefaultPosition, 0, durationMs, null, ToastWindow.ActiveWindow);
        }

        public static void Show(string message,
            MessageBoxIcon icon,
            int durationMs = 1000,
            ToastWindow targetWindow = ToastWindow.ActiveWindow)
        {
            CallToast(null, message, icon, ToastSettings.Setting.DefaultPosition, 0, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window, 
            string message,
            MessageBoxIcon icon,
            int durationMs = 1000)
        {
            CallToast(window, message, icon, ToastSettings.Setting.DefaultPosition, 0, durationMs, null, ToastWindow.ActiveWindow);
        }


        public static void Show(string message,
            ToastPosition position,
            int durationMs = 1000,
            ToastWindow targetWindow = ToastWindow.ActiveWindow)
        {
            CallToast(null, message, null, position, 0, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window,
            string message,
            ToastPosition position,
            int durationMs = 1000)
        {
            CallToast(window, message, null, position, 0, durationMs, null, ToastWindow.ActiveWindow);
        }


        public static void Show(string message,
            MessageBoxIcon icon,
            ToastPosition position,
            int durationMs = 1000,
            ToastWindow targetWindow = ToastWindow.ActiveWindow)
        {
            CallToast(null, message, icon, position, 0, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window,
            string message,
            MessageBoxIcon icon,
            ToastPosition position,
            int durationMs = 1000)
        {
            CallToast(window, message, icon, position, 0, durationMs, null, ToastWindow.ActiveWindow);
        }

        public static void Show(string message,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastWindow targetWindow = ToastWindow.ActiveWindow)
        {
            CallToast(null, message, null, position, offset, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window, 
            string message,
            ToastPosition position,
            double offset,
            int durationMs)
        {
            CallToast(window, message, null, position, offset, durationMs, null, ToastWindow.ActiveWindow);
        }

        public static void Show(string message,
            MessageBoxIcon icon,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastWindow targetWindow = ToastWindow.ActiveWindow)
        {
            CallToast(null, message, icon, position, offset, durationMs, null, targetWindow);
        }

        public static void Show(WindowX window,
            string message,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastSetting setting)
        {
            CallToast(window, message, null, position, offset, durationMs, setting, ToastWindow.ActiveWindow);
        }

        public static void Show(WindowX window,
            string message,
            MessageBoxIcon icon,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastSetting setting)
        {
            CallToast(window, message, icon, position, offset, durationMs, setting, ToastWindow.ActiveWindow);
        }

        #endregion

        #region Functions
        private static void CallToast(WindowX window,
            string message,
            MessageBoxIcon? icon,
            ToastPosition position,
            double offset,
            int durationMs,
            ToastSetting setting,
            ToastWindow targetWindow)
        {
            window = window ?? GetTargetWindow(targetWindow);
            window.CallToast(message, icon, position, offset, durationMs, setting);
        }

        private static WindowX GetTargetWindow(ToastWindow window)
        {
            switch(window)
            {
                case ToastWindow.ActiveWindow:
                    if(Application.Current.MainWindow is WindowX windowX)
                    {
                        return windowX;
                    }
                    throw new InvalidOperationException("Toast can only be displayed on a window of type 'Panuon.WPF.UI.WindowX'. The value of 'Application.Current.MainWindow' is null, or its type is not 'WindowX'. To specify a different window for the Toast, use the overloaded methods that include a 'window' or 'targetWindow' parameter.");
                default:
                    foreach (var loopObj in Application.Current.Windows)
                    {
                        if (loopObj is WindowX loopWindowX
                            && loopWindowX.IsActive)
                        {
                            return loopWindowX;
                        }
                    }
                    throw new InvalidOperationException("Toast can only be displayed on a window of type 'Panuon.WPF.UI.WindowX'. There is no active window, or the active window is not of type 'WindowX'. To specify a different window for the Toast, use the overloaded methods that include a 'window' or 'targetWindow' parameter.");
            }
        }
        #endregion
    }
}
