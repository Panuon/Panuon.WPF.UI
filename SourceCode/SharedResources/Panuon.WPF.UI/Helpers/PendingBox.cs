using Panuon.WPF.UI.Configurations;
using Panuon.WPF.UI.Internal.Controls;
using Panuon.WPF.UI.Internal.Implements;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Threading;

namespace Panuon.WPF.UI
{
    public static class PendingBox
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey CancelButtonStyle { get; } =
            new ComponentResourceKey(typeof(PendingBox), nameof(CancelButtonStyle));

        public static ComponentResourceKey SpinStyle { get; } =
            new ComponentResourceKey(typeof(PendingBox), nameof(SpinStyle));

        public static ComponentResourceKey WindowStyle { get; } =
            new ComponentResourceKey(typeof(PendingBox), nameof(WindowStyle));
        #endregion

        #region Methods
        public static IPendingHandler Show(string message)
        {
            return CallPendingBox(null, message, null, false, null);
        }

        public static IPendingHandler Show(Window owner, string message)
        {
            return CallPendingBox(owner, message, null, false, null);
        }

        public static IPendingHandler Show(Window owner, string message, PendingBoxSetting setting)
        {
            return CallPendingBox(owner, message, null, false, setting);
        }

        public static IPendingHandler Show(string message, bool canCancel)
        {
            return CallPendingBox(null, message, null, canCancel, null);
        }

        public static IPendingHandler Show(Window owner, string message, bool canCancel)
        {
            return CallPendingBox(owner, message, null, canCancel, null);
        }

        public static IPendingHandler Show(Window owner, string message, bool canCancel, PendingBoxSetting setting)
        {
            return CallPendingBox(owner, message, null, canCancel, setting);
        }

        public static IPendingHandler Show(string message, string caption)
        {
            return CallPendingBox(null, message, caption, false, null);
        }

        public static IPendingHandler Show(Window owner, string message, string caption)
        {
            return CallPendingBox(owner, message, caption, false, null);
        }

        public static IPendingHandler Show(Window owner, string message, string caption, PendingBoxSetting setting)
        {
            return CallPendingBox(owner, message, caption, false, setting);
        }

        public static IPendingHandler Show(string message, string caption, bool canCancel)
        {
            return CallPendingBox(null, message, caption, canCancel, null);
        }

        public static IPendingHandler Show(Window owner, string message, string caption, bool canCancel)
        {
            return CallPendingBox(owner, message, caption, canCancel, null);
        }

        public static IPendingHandler Show(Window owner, string message, string caption, bool canCancel, PendingBoxSetting setting)
        {
            return CallPendingBox(owner, message, caption, canCancel, setting);
        }
        #endregion

        #region Functions
        private static IPendingHandler CallPendingBox(Window owner, 
            string message, 
            string caption,
            bool canCancel,
            PendingBoxSetting setting)
        {
            return (IPendingHandler)Application.Current.Dispatcher.Invoke(new Func<IPendingHandler>(() =>
            {
                setting = setting ?? PendingBoxSettings.Setting;
                var windowStyle = XamlUtil.ToXaml(setting.WindowStyle);
                var cancelButtonStyle = XamlUtil.ToXaml(setting.CancelButtonStyle);
                var contentTemplate = XamlUtil.ToXaml(setting.ContentTemplate);
                var spinnerStyle = XamlUtil.ToXaml(setting.SpinStyle);
                var createOnNewThread = setting.CreateOnNewThread;
                var cancelButtonContent = setting.CancelButtonContent;
                var interopOwnersMask = setting.InteropOwnersMask;
                var handler = new PendingHandlerImpl();
                var ownerRect = GetOwnerRect(owner);

                if (createOnNewThread)
                {
                    var autoReset = new AutoResetEvent(false);
                    var thread = new Thread(() =>
                    {
                        var pendingWindow = new PendingBoxWindow(owner, interopOwnersMask, ownerRect, message, caption, canCancel, windowStyle, cancelButtonStyle, spinnerStyle, contentTemplate, cancelButtonContent, handler);
                        pendingWindow.Closed += delegate
                        {
                            pendingWindow.Dispatcher.InvokeShutdown();
                        };
                        pendingWindow.Show();
                        autoReset.Set();
                        Dispatcher.Run();
                    });
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.IsBackground = true;
                    thread.Start();
                    autoReset.WaitOne();
                }
                else
                {
                    var pendingWindow = new PendingBoxWindow(owner, interopOwnersMask, null, message, caption, canCancel, windowStyle, cancelButtonStyle, spinnerStyle, contentTemplate, cancelButtonContent, handler);
                    pendingWindow.Show();
                }

                return handler;
            }));
        }

        private static Rect? GetOwnerRect(Window owner)
        {
            if (owner != null)
            {
               return (Rect)owner.Dispatcher.Invoke(new Func<Rect>(() =>
                {
                    var handle = new WindowInteropHelper(owner).Handle;
                    Win32Util.GetWindowRect(handle, out Win32Util.RECT windowRect);
                    return new Rect()
                    {
                        Width = Math.Abs(windowRect.Right - windowRect.Left),
                        Height = Math.Abs(windowRect.Bottom - windowRect.Top),
                        X = windowRect.Left,
                        Y = windowRect.Top,
                    };
                }));
            }
            return null;
        }
        #endregion
    }
}
