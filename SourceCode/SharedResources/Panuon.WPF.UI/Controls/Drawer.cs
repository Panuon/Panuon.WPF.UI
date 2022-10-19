using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class Drawer : ContentControl
    {
        #region Fields
        #endregion

        #region Ctor
        static Drawer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Drawer), new FrameworkPropertyMetadata(typeof(Drawer)));
        }
        #endregion

        #region Routed Events

        public event EventHandler Opened;

        public event EventHandler Closed;
        #endregion

        #region Properties

        #region IsOpen
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(Drawer), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnIsOpenChanged));
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

        #region Functions
        private void OnIsOpenChanged()
        {
            if (IsOpen)
            {
                Open();
                Closed?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Close();
                Opened?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Open()
        {
            if (ActualWidth != 0
                || ActualHeight != 0)
            {

                if (!StaysOpen)
                {
                    Mouse.AddPreviewMouseDownOutsideCapturedElementHandler(this, OnLostMouseCapture);
                    Mouse.Capture(this, CaptureMode.SubTree);
                }

                switch (Placement)
                {
                    case DrawerPlacement.Left:
                    case DrawerPlacement.Right:
                        if (double.IsPositiveInfinity(MaxWidth))
                        {
                            throw new Exception("Drawer : a specific value must be specified for MaxWidth.");
                        }
                        AnimationUtil.BeginDoubleAnimation(this, WidthProperty, double.IsNaN(Width) ? 0 : Width, MaxWidth - ShadowHelper.GetBlurRadius(this), IsLoaded ? AnimationDuration : TimeSpan.Zero, null, AnimationEase);
                        break;
                    default:
                        if (double.IsPositiveInfinity(MaxHeight))
                        {
                            throw new Exception("Drawer : a specific value must be specified for MaxHeight.");
                        }
                        AnimationUtil.BeginDoubleAnimation(this, HeightProperty, double.IsNaN(Height) ? 0 : Height, MaxHeight - ShadowHelper.GetBlurRadius(this), IsLoaded ? AnimationDuration : TimeSpan.Zero, null, AnimationEase); ;
                        break;
                }
            }

            SetCurrentValue(IsOpenProperty, true);
        }

        public void Close()
        {
            if (ActualWidth != 0
                || ActualHeight != 0)
            {
                switch (Placement)
                {
                    case DrawerPlacement.Left:
                    case DrawerPlacement.Right:
                        if (double.IsInfinity(MaxWidth)
                            || double.IsNaN(MaxWidth))
                        {
                            throw new Exception("Drawer : a specific value must be specified for MaxWidth.");
                        }
                        AnimationUtil.BeginDoubleAnimation(this, WidthProperty, double.IsNaN(Width) ? 0 : Width, MinWidth, IsLoaded ? AnimationDuration : TimeSpan.Zero, null, AnimationEase);
                        break;
                    default:
                        if (double.IsInfinity(MaxHeight)
                            || double.IsNaN(MaxHeight))
                        {
                            throw new Exception("Drawer : a specific value must be specified for MaxHeight.");
                        }
                        AnimationUtil.BeginDoubleAnimation(this, HeightProperty, double.IsNaN(Height) ? 0 : Height, MinHeight, IsLoaded ? AnimationDuration : TimeSpan.Zero, null, AnimationEase); ;
                        break;
                }
            }
            SetCurrentValue(IsOpenProperty, false);
        }
        #endregion
    }
}