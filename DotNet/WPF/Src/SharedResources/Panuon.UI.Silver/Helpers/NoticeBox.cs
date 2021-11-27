using Panuon.UI.Silver.Internal.Controls;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Panuon.UI.Silver
{
    public static class NoticeBox
    {
        #region Fields
        private static NoticeBoxWindow _noticeWindow;

        private static Thread _thread;
        #endregion

        #region Methods
        public static INoticeHandler Show(string message)
        {
            return Show(message: message, canClose: true);
        }

        public static INoticeHandler Show(string message, bool canClose)
        {
            return Show(message: message, caption: null, canClose: canClose);
        }

        public static INoticeHandler Show(string message, bool canClose, MessageBoxIcon icon)
        {
            return Show(message: message, caption: null, canClose: canClose, icon: icon, duration: null, imageIcon: null);
        }

        public static INoticeHandler Show(string message, bool canClose, ImageSource icon)
        {
            return Show(message: message, caption: null, canClose: canClose, imageIcon: icon, duration: null, icon: MessageBoxIcon.None);
        }

        public static INoticeHandler Show(string message, string caption)
        {
            return Show(message: message, caption: caption, canClose: true);
        }

        public static INoticeHandler Show(string message, string caption, MessageBoxIcon icon)
        {
            return Show(message: message, caption: caption, canClose: true, icon: icon, duration: null, imageIcon: null);
        }

        public static INoticeHandler Show(string message, string caption, ImageSource icon)
        {
            return Show(message: message, caption: caption, canClose: true, icon: MessageBoxIcon.None, imageIcon: icon, duration: null);
        }

        public static INoticeHandler Show(string message, string caption, bool canClose)
        {
            return Show(message: message, caption: caption, canClose: canClose, duration: null);
        }

        public static INoticeHandler Show(string message, string caption, int? duration)
        {
            return Show(message: message, caption: caption, canClose: true, duration: duration);
        }

        public static INoticeHandler Show(string message, string caption, MessageBoxIcon icon, int? duration)
        {
            return Show(message: message, caption: caption, canClose: true, icon: icon, duration: duration, imageIcon: null);
        }

        public static INoticeHandler Show(string message, string caption, ImageSource icon, int? duration)
        {
            return Show(message: message, caption: caption, canClose: true, icon: MessageBoxIcon.None, imageIcon: icon, duration: duration);
        }

        public static INoticeHandler Show(string message, string caption, bool canClose, int? duration)
        {
            return Show(message: message, caption: caption, canClose: canClose, icon: MessageBoxIcon.None, duration: duration, imageIcon: null);
        }

        #endregion

        #region Functions
        private static INoticeHandler Show(string message, string caption, bool canClose, MessageBoxIcon icon, ImageSource imageIcon, int? duration)
        {
            return Application.Current.Dispatcher.Invoke(new Func<INoticeHandler>(() =>
            {
                var setting = NoticeBoxSettings.Setting;
                var animationEase = setting.AnimationEase;
                var animationDuration = setting.AnimationDuration;
                var noticeBoxItemStyle = XamlUtil.ToXaml(setting.NoticeBoxItemStyle);
                var createOnNewThread = setting.CreateOnNewThread;

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
                var handler = _noticeWindow.AddItem(message, caption, icon, imageIcon, duration, canClose, animationDuration, noticeBoxItemStyle);
                return handler;

            }));
        }

        #endregion
    }
}