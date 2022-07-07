using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.UI.Silver
{
    public class Drawer
        : ContentControl
    {
        #region Fields
        private const string ContentControlTemplateName = "PART_ContentControl";

        private ContentControlX _contentControl;

        private TranslateTransform _translateTransform = new TranslateTransform();
        #endregion

        #region Ctor
        static Drawer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Drawer), new FrameworkPropertyMetadata(typeof(Drawer)));
        }
        #endregion

        #region Events

        #region Opened or Closed
        public event EventHandler Opened;

        public event EventHandler Closed;
        #endregion

        #endregion

        #region Properties

        #region IsOpen
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(Drawer), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnIsOpenChanged));
        #endregion

        #region StaysOpen
        public bool StaysOpen
        {
            get { return (bool)GetValue(StaysOpenProperty); }
            set { SetValue(StaysOpenProperty, value); }
        }

        public static readonly DependencyProperty StaysOpenProperty =
            DependencyProperty.Register("StaysOpen", typeof(bool), typeof(Drawer), new PropertyMetadata(true));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(Drawer), new PropertyMetadata(TimeSpan.FromSeconds(0.2)));
        #endregion

        #region AnimationEase
        public AnimationEase AnimationEase
        {
            get { return (AnimationEase)GetValue(AnimationEaseProperty); }
            set { SetValue(AnimationEaseProperty, value); }
        }

        public static readonly DependencyProperty AnimationEaseProperty =
            DependencyProperty.Register("AnimationEase", typeof(AnimationEase), typeof(Drawer));
        #endregion

        #region Placement
        public DrawerPlacement Placement
        {
            get { return (DrawerPlacement)GetValue(PlacementProperty); }
            set { SetValue(PlacementProperty, value); }
        }

        public static readonly DependencyProperty PlacementProperty =
            DependencyProperty.Register("Placement", typeof(DrawerPlacement), typeof(Drawer));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Drawer));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(Drawer));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _contentControl = GetTemplateChild(ContentControlTemplateName) as ContentControlX;
            _contentControl.RenderTransform = _translateTransform;

            OnIsOpenChanged();
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            OnIsOpenChanged();
        }
        #endregion

        #region Event Handlers
        private static void OnIsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var drawer = (Drawer)d;
            drawer.OnIsOpenChanged();
        }

        private void OnLostMouseCapture(object sender, MouseButtonEventArgs e)
        {
            Mouse.RemovePreviewMouseDownOutsideCapturedElementHandler(this, OnLostMouseCapture);
            ReleaseMouseCapture();
            SetCurrentValue(IsOpenProperty, false);
        }
        #endregion

        #region Methods
        public void Open()
        {
            if (_contentControl == null
                || ActualWidth == 0
                || ActualHeight == 0)
            {
                return;
            }

            if (!StaysOpen)
            {
                Mouse.AddPreviewMouseDownOutsideCapturedElementHandler(this, OnLostMouseCapture);
                Mouse.Capture(this, CaptureMode.SubTree);
            }

            switch (Placement)
            {
                case DrawerPlacement.Left:
                case DrawerPlacement.Right:
                    if (IsLoaded)
                    {
                        var leftRightAnimation = new DoubleAnimation()
                        {
                            To = 0,
                            Duration = AnimationDuration,
                            EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEase),
                        };
                        _translateTransform.BeginAnimation(TranslateTransform.XProperty, leftRightAnimation);
                    }
                    _translateTransform.BeginAnimation(TranslateTransform.YProperty, null);
                    break;
                default:
                    if (IsLoaded)
                    {
                        var topBottomAnimation = new DoubleAnimation()
                        {
                            To = 0,
                            Duration = AnimationDuration,
                            EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEase),
                        };
                        _translateTransform.BeginAnimation(TranslateTransform.YProperty, topBottomAnimation);
                    }
                    _translateTransform.BeginAnimation(TranslateTransform.XProperty, null);
                    break;
            }

            Opened?.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
            if (_contentControl == null
                || ActualWidth == 0
                || ActualHeight == 0)
            {
                return;
            }


            switch (Placement)
            {
                case DrawerPlacement.Left:
                case DrawerPlacement.Right:
                    if (!IsLoaded)
                    {
                        _translateTransform.X = ActualWidth - MinWidth;
                    }
                    else
                    {
                        var leftRightAnimation = new DoubleAnimation()
                        {
                            To = ActualWidth - MinWidth,
                            Duration = AnimationDuration,
                            EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEase),
                        };
                        _translateTransform.BeginAnimation(TranslateTransform.XProperty, leftRightAnimation);
                    }
                    _translateTransform.BeginAnimation(TranslateTransform.YProperty, null);
                    break;
                default:
                    if (!IsLoaded)
                    {
                        _translateTransform.X = MinHeight;
                    }
                    else
                    {
                        var topBottomAnimation = new DoubleAnimation()
                        {
                            To = ActualHeight - MinHeight,
                            Duration = AnimationDuration,
                            EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEase),
                        };
                        _translateTransform.BeginAnimation(TranslateTransform.YProperty, topBottomAnimation);
                    }
                    _translateTransform.BeginAnimation(TranslateTransform.XProperty, null);
                    break;
            }
            Closed?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Functions
        private void OnIsOpenChanged()
        {
            if (IsOpen)
            {
                Open();
            }
            else
            {
                Close();
            }
        }

        #endregion
    }
}
