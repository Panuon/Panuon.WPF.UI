using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Panuon.UI.Silver
{
    [ContentProperty(nameof(Content))]
    public class StateItem : DependencyObject
    {
        #region Events 

        public event EventHandler StateChanged;
        #endregion

        #region Properties

        #region State
        public object State
        {
            get { return (object)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        public static readonly DependencyProperty StateProperty =
            DependencyProperty.Register("State", typeof(object), typeof(StateItem), new PropertyMetadata(OnStateChanged));

        #endregion

        #region Content
        public object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(StateItem));
        #endregion

        #region ContentTemplate
        public DataTemplate ContentTemplate
        {
            get { return (DataTemplate)GetValue(ContentTemplateProperty); }
            set { SetValue(ContentTemplateProperty, value); }
        }

        public static readonly DependencyProperty ContentTemplateProperty =
            DependencyProperty.Register("ContentTemplate", typeof(DataTemplate), typeof(StateItem));
        #endregion

        #region ContentTemplateSelector
        public DataTemplateSelector ContentTemplateSelector
        {
            get { return (DataTemplateSelector)GetValue(ContentTemplateSelectorProperty); }
            set { SetValue(ContentTemplateSelectorProperty, value); }
        }

        public static readonly DependencyProperty ContentTemplateSelectorProperty =
            DependencyProperty.Register("ContentTemplateSelector", typeof(DataTemplateSelector), typeof(StateItem));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var stateItem = (StateItem)d;
            stateItem.OnStateChanged();
        }
        #endregion

        #region Functions
        private void OnStateChanged()
        {
            StateChanged?.Invoke(this, new EventArgs());
        }
        #endregion
    }
}
