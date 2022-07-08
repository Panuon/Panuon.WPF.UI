using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class PopupX : Popup
    {
        #region Fields
        private WeakReference _parentWindow;

        private bool _isFirstInit = true;
        #endregion

        #region Ctor
        public PopupX()
        {
            base.Placement = PlacementMode.Custom;
            CustomPopupPlacementCallback = PopupPlacementCallback;
        }
        #endregion

        #region Properties

        #region Placement 
        public new PopupXPlacement Placement
        {
            get { return (PopupXPlacement)GetValue(PlacementProperty); }
            set { SetValue(PlacementProperty, value); }
        }

        public new static readonly DependencyProperty PlacementProperty =
            DependencyProperty.Register("Placement", typeof(PopupXPlacement), typeof(PopupX), new PropertyMetadata(PopupXPlacement.Bottom));
        #endregion

        #region ActualPlacement 
        public PopupXPlacement ActualPlacement
        {
            get { return (PopupXPlacement)GetValue(ActualPlacementProperty); }
            set { SetValue(ActualPlacementProperty, value); }
        }

        public static readonly DependencyProperty ActualPlacementProperty =
            DependencyProperty.Register("ActualPlacement", typeof(PopupXPlacement), typeof(PopupX));
        #endregion

        #region RelativePosition
        public Point RelativePosition
        {
            get { return (Point)GetValue(RelativePositionProperty); }
            set { SetValue(RelativePositionProperty, value); }
        }

        public static readonly DependencyProperty RelativePositionProperty =
            DependencyProperty.Register("RelativePosition", typeof(Point), typeof(PopupX));
        #endregion

        #endregion

        #region Overrides

        protected override void OnOpened(EventArgs e)
        {
            var parentWindow = Window.GetWindow(this);

            if (Child != null)
            {
                var hwndSource = ((HwndSource)PresentationSource.FromVisual(Child));
                hwndSource.AddHook(new HwndSourceHook(WndProc));
            }

            if (parentWindow != null)
            {
                _parentWindow = new WeakReference(parentWindow);
                parentWindow.LocationChanged -= ParentWindow_LocationChanged;
                parentWindow.LocationChanged += ParentWindow_LocationChanged;
                parentWindow.SizeChanged -= ParentWindow_SizeChanged;
                parentWindow.SizeChanged += ParentWindow_SizeChanged;
                parentWindow.MouseDown -= Window_MouseDown;
                parentWindow.MouseDown += Window_MouseDown;
            }
            if (!_isFirstInit)
            {
                UpdateActualPlacement();
            }

            base.OnOpened(e);
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == 0x0047) //WM_WINDOWPOSCHANGED
            {
                UpdateActualPlacement();
            }

            return IntPtr.Zero;
        }


        protected override void OnClosed(EventArgs e)
        {
            if (_parentWindow != null && _parentWindow.IsAlive && _parentWindow.Target is Window parentWindow)
            {
                parentWindow.LocationChanged -= ParentWindow_LocationChanged;
                parentWindow.SizeChanged -= ParentWindow_SizeChanged;
                parentWindow.MouseDown -= Window_MouseDown;
            }
            base.OnClosed(e);
        }

        #endregion

        #region Methods

        #region Relocate
        public void Relocate()
        {
            var offset = HorizontalOffset;
            SetCurrentValue(HorizontalOffsetProperty, offset + 1);
            SetCurrentValue(HorizontalOffsetProperty, offset);
        }
        #endregion

        #endregion

        #region Event Handlers
        private CustomPopupPlacement[] PopupPlacementCallback(Size popupSize, Size targetSize, Point offset)
        {
            if (_isFirstInit)
            {
                var hwndSource = ((HwndSource)PresentationSource.FromVisual(Child));
                var hwnd = hwndSource.Handle;
                Win32Util.ShowWindow(hwnd, 1);
                _isFirstInit = false;
            }

            var leftBottom = new Point(-popupSize.Width, 0);
            var left = new Point(-popupSize.Width, -(popupSize.Height - targetSize.Height) / 2);
            var leftTop = new Point(-popupSize.Width, -(popupSize.Height - targetSize.Height));
            var rightBottom = new Point(targetSize.Width, 0);
            var right = new Point(targetSize.Width, -(popupSize.Height - targetSize.Height) / 2);
            var rightTop = new Point(targetSize.Width, -(popupSize.Height - targetSize.Height));
            var topLeft = new Point(-(popupSize.Width - targetSize.Width), -popupSize.Height);
            var top = new Point(-(popupSize.Width - targetSize.Width) / 2, -popupSize.Height);
            var topRight = new Point(0, -popupSize.Height);
            var bottomLeft = new Point(-(popupSize.Width - targetSize.Width), targetSize.Height);
            var bottom = new Point(-(popupSize.Width - targetSize.Width) / 2, targetSize.Height);
            var bottomRight = new Point(0, targetSize.Height);

            switch (Placement)
            {
                case PopupXPlacement.LeftBottom:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(leftBottom, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(rightBottom, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.Left:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(left, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(right, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.LeftTop:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(leftTop, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(rightTop, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.RightBottom:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(rightBottom, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(leftBottom, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.Right:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(right, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(left, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.RightTop:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(rightTop, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(leftTop, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.TopLeft:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(topLeft, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(bottomLeft, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.Top:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(top, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(bottom, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.TopRight:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(topRight, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(bottomRight, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.BottomLeft:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(bottomLeft, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(topLeft, PopupPrimaryAxis.Horizontal), };
                case PopupXPlacement.Bottom:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(bottom, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(top, PopupPrimaryAxis.Horizontal), };
                default:
                    return new CustomPopupPlacement[] { new CustomPopupPlacement(bottomRight, PopupPrimaryAxis.Horizontal), new CustomPopupPlacement(topRight, PopupPrimaryAxis.Horizontal), };
            }
        }

        private void ParentWindow_LocationChanged(object sender, EventArgs e)
        {
            Relocate();
        }

        private void ParentWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Relocate();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsMouseOver
                && !StaysOpen
                && (PlacementTarget == null || !PlacementTarget.IsMouseOver))
            {
                SetCurrentValue(IsOpenProperty, false);
            }
        }

        private void UpdateActualPlacement()
        {
            var target = PlacementTarget ?? VisualTreeHelper.GetParent(this) as UIElement;
            if (Child == null)
            {
                return;
            }

            var location = Child.TranslatePoint(new Point(0, 0), target);
            if (RelativePosition.X != location.X || RelativePosition.Y != location.Y)
            {
                SetCurrentValue(RelativePositionProperty, location);
            }

            switch (Placement)
            {
                case PopupXPlacement.LeftBottom:
                    SetCurrentValue(ActualPlacementProperty, location.X < 0 ? PopupXPlacement.LeftBottom : PopupXPlacement.RightBottom);
                    break;
                case PopupXPlacement.Left:
                    SetCurrentValue(ActualPlacementProperty, location.X < 0 ? PopupXPlacement.Left : PopupXPlacement.Right);
                    break;
                case PopupXPlacement.LeftTop:
                    SetCurrentValue(ActualPlacementProperty, location.X < 0 ? PopupXPlacement.LeftTop : PopupXPlacement.RightTop);
                    break;
                case PopupXPlacement.RightBottom:
                    SetCurrentValue(ActualPlacementProperty, location.X > 0 ? PopupXPlacement.RightBottom : PopupXPlacement.LeftBottom);
                    break;
                case PopupXPlacement.Right:
                    SetCurrentValue(ActualPlacementProperty, location.X > 0 ? PopupXPlacement.Right : PopupXPlacement.Left);
                    break;
                case PopupXPlacement.RightTop:
                    SetCurrentValue(ActualPlacementProperty, location.X > 0 ? PopupXPlacement.RightTop : PopupXPlacement.RightBottom);
                    break;
                case PopupXPlacement.TopLeft:
                    SetCurrentValue(ActualPlacementProperty, location.Y < 0 ? PopupXPlacement.TopLeft : PopupXPlacement.BottomRight);
                    break;
                case PopupXPlacement.Top:
                    SetCurrentValue(ActualPlacementProperty, location.Y < 0 ? PopupXPlacement.Top : PopupXPlacement.Bottom);
                    break;
                case PopupXPlacement.TopRight:
                    SetCurrentValue(ActualPlacementProperty, location.Y < 0 ? PopupXPlacement.TopRight : PopupXPlacement.BottomRight);
                    break;
                case PopupXPlacement.BottomLeft:
                    SetCurrentValue(ActualPlacementProperty, location.Y > 0 ? PopupXPlacement.BottomLeft : PopupXPlacement.TopLeft);
                    break;
                case PopupXPlacement.Bottom:
                    SetCurrentValue(ActualPlacementProperty, location.Y > 0 ? PopupXPlacement.Bottom : PopupXPlacement.Top);
                    break;
                default:
                    SetCurrentValue(ActualPlacementProperty, location.Y > 0 ? PopupXPlacement.BottomRight : PopupXPlacement.TopRight);
                    break;
            }
        }
        #endregion
    }
}
