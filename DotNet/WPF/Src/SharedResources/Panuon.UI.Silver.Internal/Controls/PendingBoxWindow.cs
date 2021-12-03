using Panuon.UI.Silver.Internal.Implements;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Threading;

namespace Panuon.UI.Silver.Internal.Controls
{
    class PendingBoxWindow : Window
    {
        #region Fields
        private const string CancelButtonTemplateName = "PART_CancelButton";

        private const string MessageTextBlockTemplateName = "PART_MessageTextBlock";

        private const string CaptionTextBlockTemplateName = "PART_CaptionTextBlock";

        private const string SpinnerTemplateName = "PART_Spinner";

        private Button _cancelButton;

        private object _cancelButtonContent;

        private PendingHandlerImpl _handler;

        private WindowX _owner;

        private string _messageText;

        private string _captionText;

        private TextBlock _messageTextBlock;

        private bool _canCancel;

        private bool _canClose = false;

        private Style _cancelButtonStyle;

        private Style _spinnerStyle;

        private Rect? _ownerRect;

        private bool _isClosed;
        #endregion

        #region Ctor
        public PendingBoxWindow(Window owner, bool interopOwnersMask, Rect? ownerRect, string message, string caption, bool canCancel, string windowStyle, string cancelButtonStyle, string spinnerStyle, string contentTemplate, object cancelButtonContent, PendingHandlerImpl handler)
        {
            _captionText = caption;
            _messageText = message;
            _canCancel = canCancel;

            _cancelButtonContent = cancelButtonContent;

            _handler = handler;
            _handler.SetWindow(this);


            Style = XamlUtil.FromXaml<Style>(windowStyle);
            ContentTemplate = XamlUtil.FromXaml<DataTemplate>(contentTemplate);
            _cancelButtonStyle = XamlUtil.FromXaml<Style>(cancelButtonStyle);
            _spinnerStyle = XamlUtil.FromXaml<Style>(spinnerStyle);

            WindowStartupLocation = owner == null
                ? (ownerRect == null ? WindowStartupLocation.CenterScreen : WindowStartupLocation.Manual)
                : WindowStartupLocation.CenterOwner;

            if (ownerRect == null)
            {
                Owner = owner;
            }
            else
            {
                _ownerRect = ownerRect;
                Topmost = true;
            }
            if (owner is WindowX ownerX && interopOwnersMask)
            {
                ownerX.Dispatcher.BeginInvoke(new Action(() =>
                {
                    ownerX.IsMaskVisible = true;
                }));
                _owner = ownerX;
            }
        }

        #endregion

        #region Overrides

        #region OnApplyTemplate
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                _cancelButton = FrameworkElementUtil.FindVisualChild<Button>(this, CancelButtonTemplateName);
                var captionTextBlock = FrameworkElementUtil.FindVisualChild<TextBlock>(this, CaptionTextBlockTemplateName);
                _messageTextBlock = FrameworkElementUtil.FindVisualChild<TextBlock>(this, MessageTextBlockTemplateName);
                var spinner = FrameworkElementUtil.FindVisualChild<Spinner>(this, SpinnerTemplateName);

                if (_cancelButton != null)
                {
                    _cancelButton.Style = _cancelButtonStyle;
                    _cancelButton.Content = _cancelButtonContent;
                    _cancelButton.Visibility = _canCancel ? Visibility.Visible : Visibility.Collapsed;
                    _cancelButton.Click += CancelButton_Click;
                }
                if(captionTextBlock != null)
                {
                    captionTextBlock.Text = _captionText;
                }
                if (_messageTextBlock != null)
                {
                    _messageTextBlock.Text = _messageText;
                }
                if(spinner != null)
                {
                    spinner.Style = _spinnerStyle;
                }

            }), DispatcherPriority.DataBind);
        }
        #endregion

        #region OnClosing
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!_canClose)
            {
                e.Cancel = true;
            }
            base.OnClosing(e);
        }
        #endregion

        #region OnClosed
        protected override void OnClosed(EventArgs e)
        {
            if(_owner != null)
            {
                _owner.Dispatcher.BeginInvoke(new Action(() =>
                {
                    if (_owner.OwnedWindows.Count == 0)
                    {
                        _owner.IsMaskVisible = false;
                    }
                }));
            }
            base.OnClosed(e);
            _isClosed = true;
            _handler.TriggerClosed();
        }
        #endregion

        #region 
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            if (_ownerRect is Rect ownerRect)
            {
                var source = PresentationSource.FromVisual(this).CompositionTarget.TransformToDevice;

                var width = (int)(sizeInfo.NewSize.Width * source.M11);
                var height = (int)(sizeInfo.NewSize.Height * source.M22);
                var left = ownerRect.X + (ownerRect.Width - width) / 2;
                var top = ownerRect.Y + (ownerRect.Height - height) / 2;

                Left = left / source.M11;
                Top = top / source.M22;
            }
            base.OnRenderSizeChanged(sizeInfo);
        }
        #endregion

        #endregion

        #region Methods
        public new void Close()
        {
            if (_isClosed)
            {
                return;
            }

            _canClose = true;
            base.Close();
        }

        public void UpdateMessage(string message)
        {
            if (_isClosed)
            {
                return;
            }

            Dispatcher.Invoke(new Action(() =>
            {
                _messageTextBlock.Text = message;
            }));
        }
        #endregion

        #region Event Handlers
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (_handler.TriggerCancel())
            {
                Close();
            }
        }
        #endregion

    }
}
