using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class Drawer : ContentControl
    {
        #region Ctor
        static Drawer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Drawer), new FrameworkPropertyMetadata(typeof(Drawer)));
        }

        public Drawer()
        {
            Mouse.AddPreviewMouseDownOutsideCapturedElementHandler(this, new MouseButtonEventHandler(OnLostMouseCapture));
        }
        #endregion

        #region Events

        #region Opened
        public event RoutedEventHandler Opened
        {
            add { AddHandler(OpenedEvent, value); }
            remove { RemoveHandler(OpenedEvent, value); }
        }

        public static readonly RoutedEvent OpenedEvent =
            EventManager.RegisterRoutedEvent("Opened", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Drawer));
        #endregion

        #region Closed
        public event RoutedEventHandler Closed
        {
            add { AddHandler(ClosedEvent, value); }
            remove { RemoveHandler(ClosedEvent, value); }
        }

        public static readonly RoutedEvent ClosedEvent =
            EventManager.RegisterRoutedEvent("Closed", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Drawer));
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
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            OpenOrClose();
        }
        #endregion

        #region Event Handlers
        private static void OnIsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var drawer = (Drawer)d;
            if (drawer.IsOpen)
            {
                drawer.RaiseEvent(new RoutedEventArgs(OpenedEvent));
            }
            else
            {
                drawer.RaiseEvent(new RoutedEventArgs(ClosedEvent));
            }
            drawer.OpenOrClose();
        }

        private void OnLostMouseCapture(object sender, MouseButtonEventArgs e)
        {
            ReleaseMouseCapture();
            SetCurrentValue(IsOpenProperty, false);
        }
        #endregion

        #region Functions
        private void OpenOrClose()
        {
            if (IsOpen)
            {
                if (!StaysOpen)
                {
                    Mouse.Capture(this, CaptureMode.SubTree);
                }
            }
            switch (Placement)
            {
                case DrawerPlacement.Left:
                case DrawerPlacement.Right:
                    if (double.IsPositiveInfinity(MaxWidth))
                    {
                        throw new Exception("Drawer.MaxWidth must have a ensured value.");
                    }
                    AnimationUtil.BeginDoubleAnimation(this, WidthProperty, double.IsNaN(Width) ? 0 : Width, IsOpen ? (MaxWidth - ShadowHelper.GetBlurRadius(this)) : MinWidth, IsLoaded ? AnimationDuration : TimeSpan.Zero, null, AnimationEase);
                    break;
                default:
                    if (double.IsPositiveInfinity(MaxHeight))
                    {
                        throw new Exception("Drawer.MaxHeight must have a ensured value.");
                    }
                    AnimationUtil.BeginDoubleAnimation(this, HeightProperty, double.IsNaN(Height) ? 0 : Height, IsOpen ? (MaxHeight - ShadowHelper.GetBlurRadius(this)) : MinHeight, IsLoaded ? AnimationDuration : TimeSpan.Zero, null, AnimationEase); ;
                    break;
            }
        }

        #endregion
    }
}
