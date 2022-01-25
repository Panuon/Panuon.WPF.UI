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
#if NET40
using Microsoft.Windows.Shell;
#else
using System.Windows.Shell;
#endif

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = ContentPresenterTemplateName, Type = typeof(ContentPresenter))]
    [TemplatePart(Name = CancelButtonTemplateName, Type = typeof(Button))]
    [TemplatePart(Name = NoButtonTemplateName, Type = typeof(Button))]
    [TemplatePart(Name = YesButtonTemplateName, Type = typeof(Button))]
    [TemplatePart(Name = OKButtonTemplateName, Type = typeof(Button))]
    public class WindowX : Window, INotifyPropertyChanged
    {
        #region Fields
        private const string ContentPresenterTemplateName = "PART_ContentPresenter";

        private const string CancelButtonTemplateName = "PART_CancelButton";

        private const string NoButtonTemplateName = "PART_NoButton";

        private const string YesButtonTemplateName = "PART_YesButton";

        private const string OKButtonTemplateName = "PART_OKButton";

        private Button _okButton;

        private Button _cancelButton;

        private Button _noButton;

        private Button _yesButton;

        private WindowState _lastWindowState;

        private WindowStyle _lastWindowStyle;

        private bool _isLoaded;
        #endregion

        #region Ctor
        static WindowX()
        {
            BackgroundProperty.OverrideMetadata(typeof(WindowX), new FrameworkPropertyMetadata(Brushes.White, null, OnBackgroundCoerceValue));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowX), new FrameworkPropertyMetadata(typeof(WindowX)));
            WindowChrome.WindowChromeProperty.OverrideMetadata(typeof(WindowX), new FrameworkPropertyMetadata(null, OnWindowChromeChanged));
            WindowChrome.GlassFrameThicknessProperty.OverrideMetadata(typeof(WindowX), new FrameworkPropertyMetadata(new Thickness(), null, OnGlassFrameThicknessCoerceValue));
            WindowXCaption.BackgroundProperty.OverrideMetadata(typeof(WindowX), new FrameworkPropertyMetadata(Brushes.White, null, OnCaptionBackgroundCoerceValue));
        }
        public WindowX()
        {
            Loaded += WindowX_Loaded;
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler FullScreenChanged;
        #endregion

        #region Overrides

        #region OnApplyTemplate
        public override void OnApplyTemplate()
        {
            _cancelButton = GetTemplateChild(CancelButtonTemplateName) as Button;
            _cancelButton.Click += ModalButton_Click;

            _okButton = GetTemplateChild(OKButtonTemplateName) as Button;
            _okButton.Click += ModalButton_Click;

            _yesButton = GetTemplateChild(YesButtonTemplateName) as Button;
            _yesButton.Click += ModalButton_Click;

            _noButton = GetTemplateChild(NoButtonTemplateName) as Button;
            _noButton.Click += ModalButton_Click;
        }

        #endregion

        #region OnPreviewKeyUp
        protected override void OnPreviewKeyUp(KeyEventArgs e)
        {
            if (IsEscEnabled && e.Key == Key.Escape)
            {
                Close();
            }
            else if(IsF11Enabled && e.Key == Key.F11)
            {
                SetCurrentValue(IsFullScreenProperty, !IsFullScreen);
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

            IsClosed = true;
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

        #region IsF11Enabled
        public bool IsF11Enabled
        {
            get { return (bool)GetValue(IsF11EnabledProperty); }
            set { SetValue(IsF11EnabledProperty, value); }
        }

        public static readonly DependencyProperty IsF11EnabledProperty =
            DependencyProperty.Register("IsF11Enabled", typeof(bool), typeof(WindowX));
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

        #region  WindowXEffect
        public new WindowXEffect Effect
        {
            get { return (WindowXEffect)GetValue(EffectProperty); }
            set { SetValue(EffectProperty, value); }
        }

        public new static readonly DependencyProperty EffectProperty =
            DependencyProperty.Register("Effect", typeof(WindowXEffect), typeof(WindowX), new PropertyMetadata(null, OnWindowXEffectChanged));
        #endregion

        #region IsFullScreen
        public bool IsFullScreen
        {
            get { return (bool)GetValue(IsFullScreenProperty); }
            set { SetValue(IsFullScreenProperty, value); }
        }

        public static readonly DependencyProperty IsFullScreenProperty =
            DependencyProperty.Register("IsFullScreen", typeof(bool), typeof(WindowX), new PropertyMetadata(false, OnIsFullScreenChanged));
        #endregion

        #region IsClosed
        public bool IsClosed { get; private set; }
        #endregion

        #endregion

        #region Internal Properties

        internal Button ModalOKButton => _okButton;

        internal Button ModalYesButton => _yesButton;

        internal Button ModalNoButton => _noButton;

        internal Button ModalCancelButton => _cancelButton;
         
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

        #region Toast
        public void Toast(string message)
        {
            ShowToast(message, MessageBoxIcon.None, ToastPlacement.Center, null);
        }

        public void Toast(string message, int duration)
        {
            ShowToast(message, MessageBoxIcon.None, ToastPlacement.Center, null);
        }

        public void Toast(string message, MessageBoxIcon icon)
        {
            ShowToast(message, icon, ToastPlacement.Center, null);
        }

        public void Toast(string message, MessageBoxIcon icon, int duration)
        {
            ShowToast(message, icon, ToastPlacement.Center, duration);
        }

        public void Toast(string message, ToastPlacement placement)
        {
            ShowToast(message, MessageBoxIcon.None, placement, null);
        }

        public void Toast(string message, ToastPlacement placement, int duration)
        {
            ShowToast(message, MessageBoxIcon.None, placement, duration);
        }

        public void Toast(string message, MessageBoxIcon icon, ToastPlacement placement)
        {
            ShowToast(message, icon, placement, null);
        }

        public void Toast(string message, MessageBoxIcon icon, ToastPlacement placement, int duration)
        {
            ShowToast(message, icon, placement, duration);
        }
        #endregion

        #region Close
        public new void Close()
        {
            SetCurrentValue(CanCloseProperty, true);
            base.Close();
        }
        #endregion

        #region Minimize
        public void Minimize()
        {
            _lastWindowState = WindowState;
            SetCurrentValue(WindowStateProperty, WindowState.Minimized);
        }
        #endregion

        #region Maximize
        public void Maximize()
        {
            _lastWindowState = WindowState;
            SetCurrentValue(WindowStateProperty, WindowState.Maximized);
        }
        #endregion

        #region Normalmize
        public void Normalmize()
        {
            _lastWindowState = WindowState;
            SetCurrentValue(WindowStateProperty, WindowState.Normal);
        }
        #endregion

        #region MaximizeOrRestore
        public void MaximizeOrRestore()
        {
            _lastWindowState = WindowState;
            if (WindowState == WindowState.Maximized)
            {
                SetCurrentValue(WindowStateProperty, _lastWindowState);
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
                SetCurrentValue(WindowStateProperty, _lastWindowState);
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
        private static void OnIsFullScreenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var windowX = (WindowX)d;
            windowX.OnFullScreenChanged();
        }

        private void OnFullScreenChanged()
        {
            if (IsFullScreen)
            {
                _lastWindowState = WindowState;
                _lastWindowStyle = WindowStyle;
                SetCurrentValue(WindowStyleProperty, WindowStyle.None);
                SetCurrentValue(WindowStateProperty, WindowState.Maximized);
            }
            else
            {
                SetCurrentValue(WindowStyleProperty, _lastWindowStyle);
                SetCurrentValue(WindowStateProperty, _lastWindowState);
            }
            FullScreenChanged?.Invoke(this, EventArgs.Empty);
        }

        private static void OnWindowXEffectChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var windowX = (WindowX)d;

            if (e.OldValue is WindowXEffect oldEffect)
            {
                oldEffect.Disable();
                windowX.CoerceValue(BackgroundProperty);
                windowX.CoerceValue(WindowChrome.GlassFrameThicknessProperty);
            }
            if (e.NewValue is WindowXEffect newEffect)
            {
                newEffect.Enable(windowX);
                windowX.CoerceValue(BackgroundProperty);
                windowX.CoerceValue(WindowChrome.GlassFrameThicknessProperty);
            }
        }

        private static object OnBackgroundCoerceValue(DependencyObject d, object baseValue)
        {
            var windowX = (WindowX)d;
            if(windowX.Effect is AcrylicWindowXEffect)
            {
                return Brushes.Transparent;
            }
            if (windowX.Effect is AeroWindowXEffect aeroEffect)
            {
                return aeroEffect.Background;
            }
            return baseValue;
        }

        private static object OnCaptionBackgroundCoerceValue(DependencyObject d, object baseValue)
        {
            var windowX = (WindowX)d;
            if (windowX.Effect is AcrylicWindowXEffect
                || windowX.Effect is AeroWindowXEffect aeroEffect)
            {
                return Brushes.Transparent;
            }
            return baseValue;
        }

        private static object OnGlassFrameThicknessCoerceValue(DependencyObject d, object baseValue)
        {
            var windowX = (WindowX)d;
            if (windowX.Effect is AcrylicWindowXEffect)
            {
                return new Thickness(0, 1, 0, 0);
            }
            return baseValue;
        }

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

        private static void OnWindowChromeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var windowX = (WindowX)d;
            WindowChromeUtil.SetCaptionHeight(windowX, windowX.DisableDragMove ? 0 : WindowXCaption.GetHeight(windowX));
        }


        private void ModalButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            switch (button.Tag)
            {
                case "Cancel":
                    Close();
                    break;
                case "Yes":
                case "OK":
                    DialogResult = true;
                    break;
                case "No":
                    DialogResult = false;
                    break;
            }
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

        internal void ShowToast(string message, MessageBoxIcon icon, ToastPlacement placement, int? duration)
        {

        }
        #endregion

    }
}
