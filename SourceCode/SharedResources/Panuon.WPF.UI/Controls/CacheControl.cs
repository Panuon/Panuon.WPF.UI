using System.Collections.Generic;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [ContentProperty(nameof(Child))]
    public class CacheControl
        : FrameworkElement
    {
        #region Fields
        private readonly List<UIElement> _children = new List<UIElement>();
        #endregion

        #region Ctor
        public CacheControl()
        {
        }
        #endregion

        #region Properties

        #region Child
        public UIElement Child
        {
            get { return (UIElement)GetValue(ChildProperty); }
            set { SetValue(ChildProperty, value); }
        }

        public static readonly DependencyProperty ChildProperty =
            DependencyProperty.Register("Child", typeof(UIElement), typeof(CacheControl), new PropertyMetadata(OnChildChanged));
        #endregion

        #region CacheLimit
        public int CacheLimit
        {
            get { return (int)GetValue(CacheLimitProperty); }
            set { SetValue(CacheLimitProperty, value); }
        }

        public static readonly DependencyProperty CacheLimitProperty =
            DependencyProperty.Register("CacheLimit", typeof(int), typeof(CacheControl), new PropertyMetadata(int.MaxValue));
        #endregion

        #endregion

        #region Overrides
        protected override Size MeasureOverride(Size availableSize)
        {
            if(Child != null)
            {
                Child.Measure(availableSize);
            }
            return Child == null 
                ? base.MeasureOverride(availableSize)
                : Child.DesiredSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            foreach(var child in _children)
            {
                if (child == Child)
                {
                    child.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
                }
                else
                {
                    child.Arrange(new Rect());
                }
            }
            return Child == null 
                ? base.ArrangeOverride(finalSize)
                : Child.RenderSize;
        }

        protected override Visual GetVisualChild(int index) => _children[index];

        protected override int VisualChildrenCount => _children.Count;
        #endregion

        #region Event Handlers
        private static void OnChildChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (CacheControl)d;
            control.OnChildChanged();
        }
        #endregion

        #region Function
        private void OnChildChanged()
        {
            if (Child is UIElement child)
            {
                if (!_children.Contains(child))
                {
                    _children.Add(child);
                    AddVisualChild(child);
                    AddLogicalChild(child);
                }

                if (CacheLimit != int.MaxValue)
                {
                    var removeCount = _children.Count - CacheLimit;
                    if (removeCount > 0)
                    {
                        _children.RemoveRange(0, removeCount);
                    }
                }
            }

            InvalidateMeasure();
            InvalidateArrange();
            UpdateLayout();
        }
        #endregion

    }
}
