using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Threading;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = nameof(CloseButtonTemplateName), Type = typeof(Button))]
    public class ToastItem
    : Control
    {
        #region Fields
        private const string CloseButtonTemplateName = "PART_CloseButton";

        private Button _closeButton;

        private Timer _timer;

        private TimeSpan _animationDuration;

        private bool _closed;
        #endregion

        #region Ctor
        static ToastItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToastItem), new FrameworkPropertyMetadata(typeof(ToastItem)));
        }

        public ToastItem(TimeSpan animationDuration, int? duration)
        {
            Opacity = 0;
            _animationDuration = animationDuration;
            if (duration != null)
            {
                _timer = new Timer(OnTimerTicked, null, (int)duration, Timeout.Infinite);
            }
        }
        #endregion

        #region Events
        public event EventHandler Closed;
        #endregion

        #region Properties

        #region Spacing
        public double Spacing
        {
            get { return (double)GetValue(SpacingProperty); }
            set { SetValue(SpacingProperty, value); }
        }

        public static readonly DependencyProperty SpacingProperty =
            DependencyProperty.Register("Spacing", typeof(double), typeof(ToastItem), new PropertyMetadata(20d));
        #endregion

        #region Message
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(ToastItem));
        #endregion

        #region Icon
        public MessageBoxIcon Icon
        {
            get { return (MessageBoxIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(MessageBoxIcon), typeof(ToastItem));
        #endregion

        #region ImageIcon
        public ImageSource ImageIcon
        {
            get { return (ImageSource)GetValue(ImageIconProperty); }
            set { SetValue(ImageIconProperty, value); }
        }

        public static readonly DependencyProperty ImageIconProperty =
            DependencyProperty.Register("ImageIcon", typeof(ImageSource), typeof(ToastItem), new PropertyMetadata(null));
        #endregion

        #region CanClose
        public bool CanClose
        {
            get { return (bool)GetValue(CanCloseProperty); }
            set { SetValue(CanCloseProperty, value); }
        }

        public static readonly DependencyProperty CanCloseProperty =
            DependencyProperty.Register("CanClose", typeof(bool), typeof(ToastItem));
        #endregion

        #region CloseButtonStyle
        public Style CloseButtonStyle
        {
            get { return (Style)GetValue(CloseButtonStyleProperty); }
            set { SetValue(CloseButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty CloseButtonStyleProperty =
            DependencyProperty.Register("CloseButtonStyle", typeof(Style), typeof(ToastItem));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ToastItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ToastItem));
        #endregion

        #region Placement
        public ToastPlacement Placement
        {
            get { return (ToastPlacement)GetValue(PlacementProperty); }
            set { SetValue(PlacementProperty, value); }
        }

        public static readonly DependencyProperty PlacementProperty =
            DependencyProperty.Register("Placement", typeof(ToastPlacement), typeof(ToastItem));
        #endregion

        #endregion

        #region Overrides

        #region OnApplyTemplate
        public override void OnApplyTemplate()
        {
            _closeButton = GetTemplateChild(CloseButtonTemplateName) as Button;
            if (_closeButton != null)
            {
                _closeButton.Click += CloseButton_Click;
            }
        }
        #endregion

        #endregion

        #region Methods
        public void Show()
        {
        }

        public void Close()
        {
            Dispatcher.Invoke(new Action(() =>
            {

                if (_closed)
                {
                    return;
                }
                _closed = true;

                AnimationUtil.BeginDoubleAnimation(this, OpacityProperty, null, 0, _animationDuration, callback: () =>
                {
                    Closed?.Invoke(this, new EventArgs());
                });
            }));
        }
        #endregion

        #region Event Handlers
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Close();
        }

        private void OnTimerTicked(object state)
        {
            Close();
        }
        #endregion
    }
}
