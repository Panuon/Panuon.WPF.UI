using Panuon.UI.Silver.Configurations;
using Panuon.UI.Silver.Internal.Implements;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Controls
{
    internal class NoticeBoxWindow : Window
    {
        #region Fields
        private AnimationStackPanel _astkItems;

        private NoticeHandlerImpl _noticeHandler;
        #endregion

        #region Ctor
        public NoticeBoxWindow(AnimationEase animationEase, TimeSpan animationDuration)
        {
            SizeToContent = SizeToContent.Width;
            ShowInTaskbar = false;
            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;
            Background = Brushes.Transparent;

            _astkItems = new AnimationStackPanel()
            {
                AnimationEase = animationEase,
                AnimationDuration = animationDuration,
                ArrangeDirection = ArrangeDirection.Reverse,
                HorizontalAlignment = HorizontalAlignment.Right,
                Spacing = 15,
            };
            Content = _astkItems;
        }
        #endregion

        #region Overrides

        #region OnApplyTemplate
        public override void OnApplyTemplate()
        {
        }
        #endregion

        #region OnSourceInitialized
        protected override void OnSourceInitialized(EventArgs e)
        {
            var hwnd = new WindowInteropHelper(this).Handle;

            var extendStyle = Win32Util.GetWindowLong(hwnd, -20);
            var newStyle = extendStyle | 0x00000080 | 0x08000000;

            Win32Util.SetWindowLong(hwnd, -20, newStyle);
            Win32Util.SetWindowPos(hwnd, -1, 0, 0, 0, 0, 0x0010 | 0x0002); //TOPMOST SWP_NOACTIVATE NO_MOVE  

            Height = SystemParameters.MaximizedPrimaryScreenHeight - 14;

            base.OnSourceInitialized(e);
        }
        #endregion

        #region OnRenderSizeChanged
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            Top = 0;
            Left = SystemParameters.MaximizedPrimaryScreenWidth - RenderSize.Width - 15;

            base.OnRenderSizeChanged(sizeInfo);
        }
        #endregion

        #endregion

        #region Methods
        public INoticeHandler AddItem(string message, string caption, MessageBoxIcon icon, ImageSource imageIcon, int? duration, bool canClose, TimeSpan animationDuration, string noticeBoxItemStyle)
        {
            return Dispatcher.Invoke(() =>
            {
                var noticeBoxItem = new NoticeBoxItem(animationDuration, duration)
                {
                    Style = XamlUtil.FromXaml<Style>(noticeBoxItemStyle),
                    Caption = caption,
                    Message = message,
                    Icon = icon,
                    ImageIcon = imageIcon,
                    CanClose = canClose,
                };
                noticeBoxItem.Closed += NoticeBoxItem_Closed;
                noticeBoxItem.Click += NoticeBoxItem_Click;
                _noticeHandler = new NoticeHandlerImpl(noticeBoxItem);
                _astkItems.Children.Add(noticeBoxItem);
                return _noticeHandler;
            });
        }
        #endregion

        #region Event Handlers
        private void NoticeBoxItem_Click(object sender, RoutedEventArgs e)
        {
            _noticeHandler.TriggerClicked(sender as NoticeBoxItem);
        }

        private void NoticeBoxItem_Closed(object sender, EventArgs e)
        {
            var noticeBoxItem = sender as NoticeBoxItem;
            Dispatcher.Invoke(() =>
            {
                if (_astkItems.Children.Contains(noticeBoxItem))
                {
                    _astkItems.Children.Remove(noticeBoxItem);
                }
            });
            _noticeHandler.TriggerClosed(noticeBoxItem);
        }
        #endregion
    }
}