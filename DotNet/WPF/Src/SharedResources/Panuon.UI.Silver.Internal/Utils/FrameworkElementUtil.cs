using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Utils
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
        public static IEnumerable<T> FindVisualChildren<T>(FrameworkElement obj, string name)
            where T : FrameworkElement
        {
            if (obj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    var child = VisualTreeHelper.GetChild(obj, i) as FrameworkElement;
                    if (child != null && child is T && (string.IsNullOrEmpty(name) || child.Name == name))
                    {
                        yield return (T)child;
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
        public static T FindVisualChild<T>(FrameworkElement obj, string name)
            where T : FrameworkElement
        {
            foreach (T child in FindVisualChildren<T>(obj, name))
            {
                return child;
            }

            return null;
        }
        #endregion

        #endregion

    }
}
