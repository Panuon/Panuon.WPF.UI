using Panuon.WPF.UI.Configurations;
using Panuon.WPF.UI.Internal.Controls;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Panuon.WPF.UI
{
    public static class NoticeBox
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey NoticeBoxItemStyle { get; } =
            new ComponentResourceKey(typeof(NoticeBox), nameof(NoticeBoxItemStyle));
        #endregion

        #region Fields
        private static NoticeBoxWindow _noticeWindow;

        private static Thread _thread;
        #endregion

        #region Methods
        public static INoticeHandler Show(string message)
        {
            return CallNoticeBox(message: message, caption: null, canClose: true, icon: MessageBoxIcon.None, timeout: null, imageIcon: null, setting: null);
        }

        public static INoticeHandler Show(string message,
            string caption)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: true, icon: MessageBoxIcon.None, timeout: null, imageIcon: null, setting: null);
        }

        public static INoticeHandler Show(string message,
           string caption,
           NoticeBoxSetting setting)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: true, icon: MessageBoxIcon.None, timeout: null, imageIcon: null, setting: setting);
        }

        public static INoticeHandler Show(string message,
            string caption,
            MessageBoxIcon icon)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: true, icon: icon, timeout: null, imageIcon: null, setting: null);
        }

        public static INoticeHandler Show(string message,
           string caption,
           MessageBoxIcon icon,
           NoticeBoxSetting setting)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: true, icon: icon, timeout: null, imageIcon: null, setting: setting);
        }

        public static INoticeHandler Show(string message,
            string caption,
            ImageSource icon)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: true, icon: MessageBoxIcon.None, imageIcon: icon, timeout: null, setting: null);
        }

        public static INoticeHandler Show(string message,
           string caption,
           ImageSource imageIcon,
           NoticeBoxSetting setting)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: true, icon: MessageBoxIcon.None, timeout: null, imageIcon: imageIcon, setting: setting);
        }

        public static INoticeHandler Show(string message,
           string caption,
           MessageBoxIcon icon,
           bool canClose)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: canClose, icon: icon, timeout: null, imageIcon: null, setting: null);
        }

        public static INoticeHandler Show(string message,
           string caption,
           MessageBoxIcon icon,
           bool canClose,
           NoticeBoxSetting setting)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: canClose, icon: icon, timeout: null, imageIcon: null, setting: setting);
        }

        public static INoticeHandler Show(string message,
           string caption,
           ImageSource imageIcon,
           bool canClose)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: canClose, icon: MessageBoxIcon.None, timeout: null, imageIcon: imageIcon, setting: null);
        }

        public static INoticeHandler Show(string message,
           string caption,
           ImageSource imageIcon,
           bool canClose,
           NoticeBoxSetting setting)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: canClose, icon: MessageBoxIcon.None, timeout: null, imageIcon: imageIcon, setting: setting);
        }

        public static INoticeHandler Show(string message,
          string caption,
          MessageBoxIcon icon,
          bool canClose,
          int? duration)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: canClose, icon: icon, timeout: duration, imageIcon: null, setting: null);
        }

        public static INoticeHandler Show(string message,
           string caption,
           MessageBoxIcon icon,
           bool canClose,
           int? duration,
           NoticeBoxSetting setting)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: canClose, icon: icon, timeout: duration, imageIcon: null, setting: setting);
        }

        public static INoticeHandler Show(string message,
           string caption,
           ImageSource imageIcon,
           bool canClose,
           int? duration)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: canClose, icon: MessageBoxIcon.None, timeout: duration, imageIcon: imageIcon, setting: null);
        }

        public static INoticeHandler Show(string message,
           string caption,
           ImageSource imageIcon,
           bool canClose,
           int? duration,
           NoticeBoxSetting setting)
        {
            return CallNoticeBox(message: message, caption: caption, canClose: canClose, icon: MessageBoxIcon.None, timeout: duration, imageIcon: imageIcon, setting: setting);
        }

        public static void DestroyInstance()
        {
            if (_noticeWindow != null)
            {
                _noticeWindow.Dispatcher.Invoke(new Action(() =>
                {
                    _noticeWindow.Close();
                }));
                _noticeWindow = null;
            }
        }
        #endregion

        #region Functions
        private static INoticeHandler CallNoticeBox(string message,
            string caption,
            bool canClose,
            MessageBoxIcon icon,
            ImageSource imageIcon,
            int? timeout,
            NoticeBoxSetting setting)
        {
            return (INoticeHandler)Application.Current.Dispatcher.Invoke(new Func<INoticeHandler>(() =>
            {
                setting = setting ?? NoticeBoxSettings.Setting;
                var animationEase = setting.AnimationEase;
                var animationDuration = setting.AnimationDuration;
                var noticeBoxItemStyle = XamlUtil.ToXaml(setting.NoticeBoxItemStyle);
                var createOnNewThread = setting.CreateOnNewThread;
                var defaultDuration = GlobalSettings.Setting.AnimationDuration;
                
                if (_noticeWindow == null)
                {
                    if (createOnNewThread)
                    {
                        var autoReset = new AutoResetEvent(false);
                        _thread = new Thread(() =>
                        {
                            _noticeWindow = new NoticeBoxWindow(animationEase, animationDuration);
                            _noticeWindow.Closed += delegate
                            {
                                _noticeWindow.Dispatcher.InvokeShutdown();
                            };
                            _noticeWindow.Show();
                            autoReset.Set();
                            Dispatcher.Run();
                        });
                        _thread.SetApartmentState(ApartmentState.STA);
                        _thread.IsBackground = true;
                        _thread.Start();
                        autoReset.WaitOne();
                    }
                    else
                    {
                        _noticeWindow = new NoticeBoxWindow(animationEase, animationDuration);
                        _noticeWindow.Show();
                    }
                }
                var handler = _noticeWindow.AddItem(message, caption, icon, imageIcon, timeout, defaultDuration, canClose, noticeBoxItemStyle);
                return handler;

            }));
        }

        #endregion
    }
}