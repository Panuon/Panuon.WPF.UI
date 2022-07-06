using System.Windows;

namespace Panuon.UI.Silver
{
    public static class ElementHelper
    {

        #region Properties

        #region HandlePreviewMouseWheel
        public static bool GetHandlePreviewMouseWheel(UIElement obj)
        {
            return (bool)obj.GetValue(HandlePreviewMouseWheelProperty);
        }

        public static void SetHandlePreviewMouseWheel(UIElement obj, bool value)
        {
            obj.SetValue(HandlePreviewMouseWheelProperty, value);
        }

        public static readonly DependencyProperty HandlePreviewMouseWheelProperty =
            DependencyProperty.RegisterAttached("HandlePreviewMouseWheel", typeof(bool), typeof(ElementHelper), new PropertyMetadata(false, OnHandlePreviewMouseWheel));
        #endregion

        #region FocusOnLoaded
        public static bool GetFocusOnLoaded(FrameworkElement obj)
        {
            return (bool)obj.GetValue(FocusOnLoadedProperty);
        }

        public static void SetFocusOnLoaded(FrameworkElement obj, bool value)
        {
            obj.SetValue(FocusOnLoadedProperty, value);
        }

        public static readonly DependencyProperty FocusOnLoadedProperty =
            DependencyProperty.RegisterAttached("FocusOnLoaded", typeof(bool), typeof(ElementHelper), new PropertyMetadata(false, OnFocusOnLoaded));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnHandlePreviewMouseWheel(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (UIElement)d;
            element.PreviewMouseWheel -= Element_PreviewMouseWheel;
            if ((bool)e.NewValue)
            {
                element.PreviewMouseWheel += Element_PreviewMouseWheel;
            }
        }

        private static void Element_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            e.Handled = true;
        }

        private static void OnFocusOnLoaded(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;

            element.Loaded -= Element_Loaded;

            if ((bool)e.NewValue)
            {
                if (element.IsLoaded)
                {
                    element.Focus();
                }
                element.Loaded += Element_Loaded;
            }
        }

        private static void Element_Loaded(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            element.Focus();
        }
        #endregion

    }
}
