using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = nameof(CloseButtonTemplateName), Type = typeof(Button))]
    public class NoticeBoxItem : ButtonBase
    {
        #region Fields
        private const string CloseButtonTemplateName = "PART_CloseButton";

        private Button _closeButton;

        private Timer _timer;

        private TimeSpan _animationDuration;

        private bool _closed;
        #endregion

        #region Ctor
        static NoticeBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NoticeBoxItem), new FrameworkPropertyMetadata(typeof(NoticeBoxItem)));
        }

        public NoticeBoxItem()
        {

        }

        public NoticeBoxItem(TimeSpan animationDuration, int? duration)
        {
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

        #region Caption
        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(NoticeBoxItem), new PropertyMetadata(null));
        #endregion

        #region CaptionHeight
        public double CaptionHeight
        {
            get { return (double)GetValue(CaptionHeightProperty); }
            set { SetValue(CaptionHeightProperty, value); }
        }

        public static readonly DependencyProperty CaptionHeightProperty =
            DependencyProperty.Register("CaptionHeight", typeof(double), typeof(NoticeBoxItem), new PropertyMetadata(35d));
        #endregion

        #region Message
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(NoticeBoxItem), new PropertyMetadata(null));
        #endregion

        #region CanClose
        public bool CanClose
        {
            get { return (bool)GetValue(CanCloseProperty); }
            set { SetValue(CanCloseProperty, value); }
        }

        public static readonly DependencyProperty CanCloseProperty =
            DependencyProperty.Register("CanClose", typeof(bool), typeof(NoticeBoxItem), new PropertyMetadata(false));
        #endregion

        #region Icon
        public MessageBoxIcon Icon
        {
            get { return (MessageBoxIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(MessageBoxIcon), typeof(NoticeBoxItem), new PropertyMetadata(MessageBoxIcon.None));
        #endregion

        #region ImageIcon
        public ImageSource ImageIcon
        {
            get { return (ImageSource)GetValue(ImageIconProperty); }
            set { SetValue(ImageIconProperty, value); }
        }

        public static readonly DependencyProperty ImageIconProperty =
            DependencyProperty.Register("ImageIcon", typeof(ImageSource), typeof(NoticeBoxItem), new PropertyMetadata(null));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(NoticeBoxItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(NoticeBoxItem));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(NoticeBoxItem));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(NoticeBoxItem));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(NoticeBoxItem));
        #endregion

        #region HoverBorderThickness
        public Thickness? HoverBorderThickness
        {
            get { return (Thickness?)GetValue(HoverBorderThicknessProperty); }
            set { SetValue(HoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(NoticeBoxItem));
        #endregion

        #region HoverCornerRadius
        public CornerRadius? HoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(HoverCornerRadiusProperty); }
            set { SetValue(HoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(NoticeBoxItem));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(NoticeBoxItem));
        #endregion

        #region ClickEffect
        public ClickEffect ClickEffect
        {
            get { return (ClickEffect)GetValue(ClickEffectProperty); }
            set { SetValue(ClickEffectProperty, value); }
        }

        public static readonly DependencyProperty ClickEffectProperty =
            VisualStateHelper.ClickEffectProperty.AddOwner(typeof(NoticeBoxItem));
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
        internal void Close()
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
