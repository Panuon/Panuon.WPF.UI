using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Utils
{
    static class FrameworkElementUtil
    {
        #region Methods

        #region BindingProperty
        public static void BindingProperty(FrameworkElement element,
            DependencyProperty targetProperty,
            object source,
            DependencyProperty sourceProperty,
            IValueConverter converter = null,
            BindingMode mode = BindingMode.Default,
            UpdateSourceTrigger trigger = UpdateSourceTrigger.Default)
        {
            var binding = new Binding()
            {
                Path = new PropertyPath(sourceProperty),
                Source = source,
                Mode = mode,
                Converter = converter,
                UpdateSourceTrigger = trigger
            };
            element.SetBinding(targetProperty, binding);
        }
        #endregion

        #region IsDefault
        public static bool IsDefault(FrameworkElement element,
            DependencyProperty property)
        {
            var baseValueSource = DependencyPropertyHelper.GetValueSource(element, property).BaseValueSource;
            return baseValueSource == BaseValueSource.Default;
        }

        #endregion

        #region BindingPropertyIfUndefault
        public static void BindingPropertyIfUndefault(FrameworkElement element,
            DependencyProperty targetProperty,
            object source,
            DependencyProperty sourceProperty,
            IValueConverter converter = null,
            BindingMode mode = BindingMode.Default,
            UpdateSourceTrigger trigger = UpdateSourceTrigger.Default)
        {
            var baseValueSource = DependencyPropertyHelper.GetValueSource(element, targetProperty).BaseValueSource;
            if (baseValueSource != BaseValueSource.Default)
            {
                return;
            }
            var binding = new Binding()
            {
                Path = new PropertyPath(sourceProperty),
                Source = source,
                Mode = mode,
                Converter = converter,
                UpdateSourceTrigger = trigger
            };
            element.SetBinding(targetProperty, binding);
        }
        #endregion

        #region BindingPropertyIfUndefaultAndUninherited
        public static void BindingPropertyIfUndefaultAndUninherited(FrameworkElement element,
            DependencyProperty targetProperty,
            object source,
            DependencyProperty sourceProperty,
            IValueConverter converter = null,
            BindingMode mode = BindingMode.Default,
            UpdateSourceTrigger trigger = UpdateSourceTrigger.Default)
        {
            var baseValueSource = DependencyPropertyHelper.GetValueSource(element, targetProperty).BaseValueSource;
            if (baseValueSource != BaseValueSource.Default && baseValueSource != BaseValueSource.Inherited)
            {
                return;
            }
            var binding = new Binding()
            {
                Path = new PropertyPath(sourceProperty),
                Source = source,
                Mode = mode,
                Converter = converter,
                UpdateSourceTrigger = trigger
            };
            element.SetBinding(targetProperty, binding);
        }
        #endregion

        #region FindVisualChildren
        public static IEnumerable<T> FindVisualChildren<T>(FrameworkElement obj)
            where T : FrameworkElement
        {
            if (obj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    var child = VisualTreeHelper.GetChild(obj, i) as FrameworkElement;
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        public static IEnumerable<T> FindVisualChildren<T>(FrameworkElement obj, string name)
            where T : FrameworkElement
        {
            if (obj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    var child = VisualTreeHelper.GetChild(obj, i) as FrameworkElement;
                    if (child is T t && (string.IsNullOrEmpty(name) || child.Name == name))
                    {
                        yield return t;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child, name))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
        #endregion

        #region FindVisualChild
        public static T FindVisualChild<T>(FrameworkElement obj)
            where T : FrameworkElement
        {
            return FindVisualChildren<T>(obj)
                .FirstOrDefault();
        }

        public static T FindVisualChild<T>(FrameworkElement obj, string name)
            where T : FrameworkElement
        {
            return FindVisualChildren<T>(obj, name)
                .FirstOrDefault();
        }
        #endregion

        #region FindVisualParent
        public static T FindVisualParent<T>(DependencyObject obj)
            where T : DependencyObject
        {
            while (obj != null && !(obj is T))
            {
                obj = VisualTreeHelper.GetParent(obj);
            }
            return obj as T;
        }
        #endregion

        #region MoveFocus
        public static void RemoveFocus(FrameworkElement element)
        {
            DependencyObject scope = FocusManager.GetFocusScope(element);
            var window = Window.GetWindow(element);
            FocusManager.SetFocusedElement(scope, window as IInputElement);
        }
        #endregion

        #endregion

    }
}
