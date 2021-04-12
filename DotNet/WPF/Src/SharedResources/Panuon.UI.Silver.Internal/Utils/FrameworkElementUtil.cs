using System.Windows;
using System.Windows.Data;

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

        #endregion

    }
}
