using Panuon.UI.Core;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Panuon.UI.Silver
{
    [ContentProperty(nameof(Items))]
    public class StateControl : Control
    {
        #region Fields
        private ObservableCollectionX<StateItem> _stateItems;
        #endregion

        #region Ctor
        static StateControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StateControl), new FrameworkPropertyMetadata(typeof(StateControl)));
        }

        public StateControl()
        {
            _stateItems = new ObservableCollectionX<StateItem>();
            _stateItems.CollectionChanged += StateItems_CollectionChanged;
        }
        #endregion

        #region Events
        public event RoutedEventHandler CurrentStateChanged
        {
            add { AddHandler(CurrentStateChangedEvent, value); }
            remove { RemoveHandler(CurrentStateChangedEvent, value); }
        }

        public static readonly RoutedEvent CurrentStateChangedEvent =
            EventManager.RegisterRoutedEvent("CurrentStateChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(StateControl));
        #endregion

        #region Properties

        #region StateItems
        public ObservableCollectionX<StateItem> Items
        {
            get
            {
                return _stateItems;
            }
        }
        #endregion

        #region CurrentState
        public object CurrentState
        {
            get { return (object)GetValue(CurrentStateProperty); }
            set { SetValue(CurrentStateProperty, value); }
        }

        public static readonly DependencyProperty CurrentStateProperty =
            DependencyProperty.Register("CurrentState", typeof(object), typeof(StateControl), new PropertyMetadata(OnCurrentStateChanged));
        #endregion

        #region Content
        public object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(StateControl));
        #endregion

        #region ContentTemplate
        public DataTemplate ContentTemplate
        {
            get { return (DataTemplate)GetValue(ContentTemplateProperty); }
            set { SetValue(ContentTemplateProperty, value); }
        }

        public static readonly DependencyProperty ContentTemplateProperty =
            DependencyProperty.Register("ContentTemplate", typeof(DataTemplate), typeof(StateControl));
        #endregion

        #region ContentTemplateSelector
        public DataTemplateSelector ContentTemplateSelector
        {
            get { return (DataTemplateSelector)GetValue(ContentTemplateSelectorProperty); }
            set { SetValue(ContentTemplateSelectorProperty, value); }
        }

        public static readonly DependencyProperty ContentTemplateSelectorProperty =
            DependencyProperty.Register("ContentTemplateSelector", typeof(DataTemplateSelector), typeof(StateControl));
        #endregion

        #endregion

        #region Event Handlers
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            ValidateCurrentStateItem();
        }

        private void StateItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
            {
                foreach (StateItem stateItem in e.OldItems)
                {
                    stateItem.StateChanged -= StateItem_StateChanged;
                }
            }
            if (e.NewItems != null)
            {
                foreach(StateItem stateItem in e.NewItems)
                {
                    stateItem.StateChanged -= StateItem_StateChanged;
                    stateItem.StateChanged += StateItem_StateChanged;
                }
            }
            ValidateCurrentStateItem();
        }

        private void StateItem_StateChanged(object sender, EventArgs e)
        {
            ValidateCurrentStateItem();
        }

        private static void OnCurrentStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var stateControl = d as StateControl;
            stateControl.OnCurrentStateChanged();
        }
        #endregion

        #region Functions
        private void OnCurrentStateChanged()
        {
            ValidateCurrentStateItem();
            RaiseEvent(new RoutedEventArgs(CurrentStateChangedEvent, this));
        }

        private void ValidateCurrentStateItem()
        {
            if (!IsInitialized)
            {
                return;
            }

            foreach (var item in Items)
            {
                if (item == null)
                {
                    continue;
                }

                if (VerifyState(item.State))
                {
                    FrameworkElementUtil.BindingProperty(this, ContentProperty, item, StateItem.ContentProperty);
                    FrameworkElementUtil.BindingProperty(this, ContentTemplateProperty, item, StateItem.ContentTemplateProperty);
                    FrameworkElementUtil.BindingProperty(this, ContentTemplateSelectorProperty, item, StateItem.ContentTemplateSelectorProperty);
                    break;
                }
            }
        }

        private bool VerifyState(object rawState)
        {
            if (CurrentState == null)
            {
                return rawState == null;
            }

            if (rawState == null)
            {
                return false;
            }

            var targetType = CurrentState.GetType();
            if (targetType.IsInstanceOfType(rawState))
            {
                return rawState.Equals(CurrentState);
            }
            var fromType = rawState.GetType();
            var converter = TypeDescriptor.GetConverter(targetType);
            if (converter.CanConvertFrom(fromType))
            {
                var state = converter.ConvertFrom(rawState);
                return state.Equals(CurrentState);
            }
            return false;
        }

        #endregion
    }
}
