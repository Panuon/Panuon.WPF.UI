using Panuon.UI.Core;
using Panuon.UI.Silver.Utils;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shell;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = ContentPresenterTemplateName, Type = typeof(ContentPresenter))]
    public class WindowX : Window, INotifyPropertyChanged
    {
        #region Fields
        protected const string ContentPresenterTemplateName = "PART_ContentPresenter";

        private WindowState _lastWindowState;

        private bool _isLoaded;
        #endregion

        #region Ctor
        static WindowX()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowX), new FrameworkPropertyMetadata(typeof(WindowX)));
        }

        public WindowX()
        {
            Loaded += WindowX_Loaded;
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Overrides

        #region OnPreviewKeyUp
        protected override void OnPreviewKeyUp(KeyEventArgs e)
        {
            if (e.Key == Key.Escape && IsEscEnabled)
            {
                Close();
            }
            base.OnPreviewKeyUp(e);
        }
        #endregion

        #region OnClosing
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (!CanClose)
            {
                e.Cancel = true;
            }
            base.OnClosing(e);
        }
        #endregion

        #region OnClosed
        protected override void OnClosed(EventArgs e)
        {
            if (InteropOwnersMask && Owner is WindowX owner && owner.OwnedWindows.Count == 0)
            {
                owner.IsMaskVisible = false;
            }
            base.OnClosed(e);
        }
        #endregion

        #region OnContentRendered
        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            InvalidateVisual();
        }
        #endregion

        #endregion

        #region Properties

        #region IsEscEnabled
        public bool IsEscEnabled
        {
            get { return (bool)GetValue(IsEscEnabledProperty); }
            set { SetValue(IsEscEnabledProperty, value); }
        }

        public static readonly DependencyProperty IsEscEnabledProperty =
            DependencyProperty.Register("IsEscEnabled", typeof(bool), typeof(WindowX));
        #endregion

        #region CanClose
        public bool CanClose
        {
            get { return (bool)GetValue(CanCloseProperty); }
            set { SetValue(CanCloseProperty, value); }
        }

        public static readonly DependencyProperty CanCloseProperty =
            DependencyProperty.Register("CanClose", typeof(bool), typeof(WindowX), new PropertyMetadata(true));
        #endregion

        #region DisableDragMove
        public bool DisableDragMove
        {
            get { return (bool)GetValue(DisableDragMoveProperty); }
            set { SetValue(DisableDragMoveProperty, value); }
        }

        public static readonly DependencyProperty DisableDragMoveProperty =
            DependencyProperty.Register("DisableDragMove", typeof(bool), typeof(WindowX), new PropertyMetadata(OnDisableDragMoveChanged));
        #endregion

        #region IsMaskVisible
        public bool IsMaskVisible
        {
            get { return (bool)GetValue(IsMaskVisibleProperty); }
            set { SetValue(IsMaskVisibleProperty, value); }
        }

        public static readonly DependencyProperty IsMaskVisibleProperty =
            DependencyProperty.Register("IsMaskVisible", typeof(bool), typeof(WindowX));
        #endregion

        #region MaskBrush
        public Brush MaskBrush
        {
            get { return (Brush)GetValue(MaskBrushProperty); }
            set { SetValue(MaskBrushProperty, value); }
        }

        public static readonly DependencyProperty MaskBrushProperty =
            DependencyProperty.Register("MaskBrush", typeof(Brush), typeof(WindowX));
        #endregion

        #region Overlayer
        public object Overlayer
        {
            get { return (object)GetValue(OverlayerProperty); }
            set { SetValue(OverlayerProperty, value); }
        }

        public static readonly DependencyProperty OverlayerProperty =
            DependencyProperty.Register("Overlayer", typeof(object), typeof(WindowX));
        #endregion

        #region IsOverlayerVisible
        public bool IsOverlayerVisible
        {
            get { return (bool)GetValue(IsOverlayerVisibleProperty); }
            set { SetValue(IsOverlayerVisibleProperty, value); }
        }

        public static readonly DependencyProperty IsOverlayerVisibleProperty =
            DependencyProperty.Register("IsOverlayerVisible", typeof(bool), typeof(WindowX));
        #endregion

        #region Backstage
        public object Backstage
        {
            get { return (object)GetValue(BackstageProperty); }
            set { SetValue(BackstageProperty, value); }
        }

        public static readonly DependencyProperty BackstageProperty =
            DependencyProperty.Register("Backstage", typeof(object), typeof(WindowX));
        #endregion

        #region IsBackstageVisible
        public bool IsBackstageVisible
        {
            get { return (bool)GetValue(IsBackstageVisibleProperty); }
            set { SetValue(IsBackstageVisibleProperty, value); }
        }

        public static readonly DependencyProperty IsBackstageVisibleProperty =
            DependencyProperty.Register("IsBackstageVisible", typeof(bool), typeof(WindowX));
        #endregion

        #region InteropOwnersMask
        public bool InteropOwnersMask
        {
            get { return (bool)GetValue(InteropOwnersMaskProperty); }
            set { SetValue(InteropOwnersMaskProperty, value); }
        }

        public static readonly DependencyProperty InteropOwnersMaskProperty =
            DependencyProperty.Register("InteropOwnersMask", typeof(bool), typeof(WindowX), new PropertyMetadata(true));
        #endregion

        #endregion

        #region Attached Properties

        #region IsDragMoveArea
        public static bool? GetIsDragMoveArea(DependencyObject obj)
        {
            return (bool?)obj.GetValue(IsDragMoveAreaProperty);
        }

        public static void SetIsDragMoveArea(DependencyObject obj, bool? value)
        {
            obj.SetValue(IsDragMoveAreaProperty, value);
        }

        public static readonly DependencyProperty IsDragMoveAreaProperty =
            DependencyProperty.RegisterAttached("IsDragMoveArea", typeof(bool?), typeof(WindowX), new PropertyMetadata(OnIsDragMoveAreaChanged));
        #endregion

        #endregion

        #region Internal Attached Property

        #region LastPosition
        internal static Point? GetLastPosition(DependencyObject obj)
        {
            return (Point?)obj.GetValue(LastPositionProperty);
        }

        internal static void SetLastPosition(DependencyObject obj, Point? value)
        {
            obj.SetValue(LastPositionProperty, value);
        }

        internal static readonly DependencyProperty LastPositionProperty =
            DependencyProperty.RegisterAttached("LastPosition", typeof(Point?), typeof(WindowX));
        #endregion 

        #endregion

        #region Methods

        #region Close
        public new void Close()
        {
            CanClose = true;
            base.Close();
        }
        #endregion

        #region Minimize
        public void Minimize()
        {
            _lastWindowState = WindowState;
            WindowState = WindowState.Minimized;
        }
        #endregion

        #region Maximize
        public void Maximize()
        {
            _lastWindowState = WindowState;
            WindowState = WindowState.Maximized;
        }
        #endregion

        #region Normalmize
        public void Normalmize()
        {
            _lastWindowState = WindowState;
            WindowState = WindowState.Normal;
        }
        #endregion

        #region MaximizeOrRestore
        public void MaximizeOrRestore()
        {
            _lastWindowState = WindowState;
            if (WindowState == WindowState.Maximized)
            {
                WindowState = _lastWindowState;
            }
            else
            {
                Maximize();
            }
        }
        #endregion

        #region MinimizeOrRestore
        public void MinimizeOrRestore()
        {
            _lastWindowState = WindowState;
            if (WindowState == WindowState.Minimized)
            {
                WindowState = _lastWindowState;
            }
            else
            {
                Minimize();
            }
        }
        #endregion

        #region NotifyOfPropertyChange
        public void NotifyOfPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NotifyOfPropertyChange<TProperty>(Expression<Func<TProperty>> property)
        {
            NotifyOfPropertyChange(property.Name);
        }
        #endregion

        #region Set
        public void Set<T>(ref T identifer, T value, [CallerMemberName] string propertyName = null)
        {
            identifer = value;
            NotifyOfPropertyChange(propertyName);
        }
        #endregion

        #endregion

        #region Commands
        public static readonly DependencyProperty MinimizeCommandProperty =
            DependencyProperty.Register("MinimizeCommand", typeof(ICommand), typeof(WindowX), new PropertyMetadata(new RelayCommand(OnMinimizeCommandExecute)));

        public static readonly DependencyProperty MaximizeCommandProperty =
            DependencyProperty.Register("MaximizeCommand", typeof(ICommand), typeof(WindowX), new PropertyMetadata(new RelayCommand(OnMaximizeCommandExecute)));

        public static readonly DependencyProperty CloseCommandProperty =
            DependencyProperty.Register("CloseCommand", typeof(ICommand), typeof(WindowX), new PropertyMetadata(new RelayCommand(OnCloseCommandExecute)));

        #endregion

        #region Event Handlers
        private void WindowX_Loaded(object sender, RoutedEventArgs e)
        {
            if (!_isLoaded)
            {
                if (InteropOwnersMask && Owner is WindowX owner)
                {
                    owner.IsMaskVisible = true;
                }
                _isLoaded = true;
            }
        }

        private static void OnDisableDragMoveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = (WindowX)d;
            window.OnDisableDragMoveChanged();
        }

        private static void OnIsDragMoveAreaChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = d as UIElement;
            if ((bool?)e.NewValue == true)
            {
                WindowChromeUtil.SetIsHitTestVisibleInChrome(element, false);
                element.PreviewMouseDown += Element_PreviewMouseDown;
                element.PreviewMouseUp += Element_PreviewMouseUp;
                element.PreviewMouseMove += Element_MouseMove;
            }
            else
            {
                WindowChromeUtil.SetIsHitTestVisibleInChrome(element, true);
                element.PreviewMouseDown -= Element_PreviewMouseDown; ;
                element.PreviewMouseUp -= Element_PreviewMouseUp;
                element.PreviewMouseMove -= Element_MouseMove;
            }
        }

        private static void Element_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = (UIElement)sender;
            SetLastPosition(element, Mouse.GetPosition(element));
        }

        private static void Element_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            var element = (UIElement)sender;
            SetLastPosition(element, null);
        }

        private static void Element_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var element = (UIElement)sender;
                if (GetLastPosition(element) is Point position)
                {
                    var newPosition = Mouse.GetPosition(element);
                    if (Math.Abs(newPosition.X - position.X) < 1 && Math.Abs(newPosition.Y - position.Y) < 1)
                    {
                        return;
                    }
                    else
                    {
                        SetLastPosition(element, null);
                    }
                    var window = GetWindow(element);
                    window.DragMove();
                    e.Handled = true;
                }
            }
        }

        private static void OnMinimizeCommandExecute(object obj)
        {
            var windowX = (obj as WindowX);
            windowX.Minimize();
        }

        private static void OnMaximizeCommandExecute(object obj)
        {
            var window = (obj as WindowX);
            if (window.WindowState == WindowState.Maximized)
            {
                window.WindowState = WindowState.Normal;
            }
            else
            {
                window.WindowState = WindowState.Maximized;
            }
        }


        private static void OnCloseCommandExecute(object obj)
        {
            var windowX = (obj as WindowX);
            windowX.Close();
        }

        #endregion

        #region Functions
        private void OnIsMaskVisibleChanged()
        {
            WindowChromeUtil.SetCaptionHeight(this, IsMaskVisible ? 0 : (DisableDragMove ? 0 : WindowXCaption.GetHeight(this)));
        }

        private void OnDisableDragMoveChanged()
        {
            WindowChromeUtil.SetCaptionHeight(this, DisableDragMove ? 0 : WindowXCaption.GetHeight(this));
        }
        #endregion

    }
}
