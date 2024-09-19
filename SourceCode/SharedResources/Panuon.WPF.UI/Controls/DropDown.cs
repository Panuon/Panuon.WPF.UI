using Panuon.WPF.UI.Internal;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = PopupTemplateName, Type = typeof(Popup))]
    [TemplatePart(Name = ContentPresenterName, Type = typeof(ContentPresenter))]
    [ContentProperty(nameof(Child))]
    public class DropDown : ContentControl
    {
        #region Fields
        private const string PopupTemplateName = "PART_Popup";
        private const string ContentPresenterName = "PART_ContentPresenter";

        private Popup _popup;
        private ContentPresenter _contentPresenter;

        private bool _isInited = true;

        private double _popupHeight = double.NaN;
        #endregion

        #region Ctor
        static DropDown()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DropDown), new FrameworkPropertyMetadata(typeof(DropDown)));
        }
        #endregion

        #region Events
        public event EventHandler Closed;

        public event EventHandler Opened;
        #endregion

        #region Properties

        #region IsOpen
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(DropDown), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, null, OnIsOpenCoerceValue));

        private static object OnIsOpenCoerceValue(DependencyObject d, object baseValue)
        {
            var dropDown = (DropDown)d;
            if (!dropDown._isInited)
            {
                return false;
            }
            return baseValue;
        }
        #endregion

        #region StaysOpen
        public bool StaysOpen
        {
            get { return (bool)GetValue(StaysOpenProperty); }
            set { SetValue(StaysOpenProperty, value); }
        }

        public static readonly DependencyProperty StaysOpenProperty =
            DependencyProperty.Register("StaysOpen", typeof(bool), typeof(DropDown));
        #endregion

        #region Child
        public object Child
        {
            get { return (object)GetValue(ChildProperty); }
            set { SetValue(ChildProperty, value); }
        }

        public static readonly DependencyProperty ChildProperty =
            DependencyProperty.Register("Child", typeof(object), typeof(DropDown), new PropertyMetadata(OnChildChanged));
        #endregion

        #region InitBeforeOpen
        public bool InitBeforeOpen
        {
            get { return (bool)GetValue(InitBeforeOpenProperty); }
            set { SetValue(InitBeforeOpenProperty, value); }
        }

        public static readonly DependencyProperty InitBeforeOpenProperty =
            DependencyProperty.Register("InitBeforeOpen", typeof(bool), typeof(DropDown));
        #endregion

        #endregion

        #region Internal Methods
        internal void Open()
        {
            _popup.IsOpen = true;
        }

        internal void Close()
        {
            _popup.IsOpen = false;
        }
        #endregion

        #region Overrides
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            e.Handled = true;
            base.OnPreviewMouseDown(e);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _popup = GetTemplateChild(PopupTemplateName) as Popup;
            _contentPresenter = GetTemplateChild(ContentPresenterName) as ContentPresenter;

            if (InitBeforeOpen)
            {
                _isInited = false;
                Dispatcher.BeginInvoke(DispatcherPriority.Send, new Action(() =>
                {
                    _popupHeight = _popup.Height;
                    _popup.Height = 0d;

                    _popup.IsOpen = true;
                }));
                Dispatcher.BeginInvoke(DispatcherPriority.Render, new Action(() =>
                {
                    _popup.Closed += Popup_Closed;
                    if (!_isInited)
                    {
                    _popup.IsOpen = false;
                    }
                    if (!_isInited)
                    {
                        _popup.IsOpen = true;
                        Dispatcher.BeginInvoke(DispatcherPriority.Send, new Action(() =>
                        {
                            _popup.IsOpen = false;
                        }));
                    }
                    _popup.Opened += Popup_Opened;
                }));
            }
            else
            {
                _popup.Opened += Popup_Opened;
                _popup.Closed += Popup_Closed;
                _popup.SetBinding(Popup.IsOpenProperty, new Binding()
                {
                    Path = new PropertyPath(IsOpenProperty),
                    Source = this,
                    Mode = BindingMode.TwoWay,
                });
            }
        }

        protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
        {
            base.OnVisualChildrenChanged(visualAdded, visualRemoved);
        }
        #endregion

        #region Event Handlers
        private static void OnChildChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dropDown = d as DropDown;
            dropDown.OnChildChanged(e.OldValue as DispatcherObject, e.NewValue as DispatcherObject);
        }
        #endregion

        #region Functions
        private void Popup_Closed(object sender, EventArgs e)
        {
            Initialize();
            Closed?.Invoke(this, e);
        }

        private void Initialize()
        {
            if (!_isInited)
            {
                _popup.Height = _popupHeight;
                _popup.SetBinding(PopupX.IsOpenProperty, new Binding()
                {
                    Path = new PropertyPath(IsOpenProperty),
                    Source = this,
                    Mode = BindingMode.TwoWay,
                });
                _isInited = true;
                Dispatcher.BeginInvoke(DispatcherPriority.Send, new Action(() =>
                {
                    CoerceValue(IsOpenProperty);
                }));
                return;
            }
        }

        private void Popup_Opened(object sender, EventArgs e)
        {
            Opened?.Invoke(this, e);
        }

        private void OnChildChanged(DispatcherObject oldChild, DispatcherObject newChild)
        {
            RemoveLogicalChild(oldChild);
            AddLogicalChild(newChild);
        }
        #endregion
    }
}
