using Panuon.UI.Silver.Configurations;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class AnimationStackPanel : StackPanel
    {
        #region Ctor
        public AnimationStackPanel()
        {
            FrameworkElementUtil.BindingPropertyIfUndefault(this, AnimationDurationProperty, GlobalSettings.Setting, GlobalSetting.AnimationDurationProperty);
        }
        #endregion

        #region Properties

        #region AnimationEase
        public AnimationEase AnimationEase
        {
            get { return (AnimationEase)GetValue(AnimationEaseProperty); }
            set { SetValue(AnimationEaseProperty, value); }
        }

        public static readonly DependencyProperty AnimationEaseProperty =
            DependencyProperty.Register("AnimationEase", typeof(AnimationEase), typeof(AnimationStackPanel));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(AnimationStackPanel));
        #endregion

        #endregion

        #region Internal Properties

        #region AnimateIn
        internal static double GetAnimateIn(DependencyObject obj)
        {
            return (double)obj.GetValue(AnimateInProperty);
        }

        internal static void SetAnimateIn(DependencyObject obj, double value)
        {
            obj.SetValue(AnimateInProperty, value);
        }

        internal static readonly DependencyProperty AnimateInProperty =
            DependencyProperty.RegisterAttached("AnimateIn", typeof(double), typeof(AnimationStackPanel), new PropertyMetadata(0d, OnAnimateInChanged));
        #endregion

        #region AnimateOut
        internal static double GetAnimateOut(DependencyObject obj)
        {
            return (double)obj.GetValue(AnimateOutProperty);
        }

        internal static void SetAnimateOut(DependencyObject obj, double value)
        {
            obj.SetValue(AnimateOutProperty, value);
        }

        internal static readonly DependencyProperty AnimateOutProperty =
            DependencyProperty.RegisterAttached("AnimateOut", typeof(double), typeof(AnimationStackPanel), new PropertyMetadata(0d, OnAnimateInChanged));
        #endregion

        #endregion

        #region Overrides

        #region OnVisualChildrenChanged
        protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
        {
            var isVertical = Orientation == Orientation.Vertical;
            if (visualAdded is UIElement elementAdded)
            {
                SetAnimateIn(elementAdded, 1);
                AnimationUtil.BeginDoubleAnimation(elementAdded, AnimateInProperty, null, 0, AnimationDuration, ease: AnimationEase);
            }
            if (visualRemoved is UIElement elementRemoved)
            {
                var flag = false;
                var size = 0d;
                foreach (UIElement child in InternalChildren)
                {
                    if (flag)
                    {
                        SetAnimateOut(child, size);
                        child.BeginAnimation(AnimateOutProperty, null);
                        AnimationUtil.BeginDoubleAnimation(child, AnimateOutProperty, null, 0, AnimationDuration, ease: AnimationEase);
                    }
                    if (child == null)
                    {
                        flag = true;
                        size = isVertical ? elementRemoved.RenderSize.Height : elementRemoved.RenderSize.Width;
                    }
                }
            }
            base.OnVisualChildrenChanged(visualAdded, visualRemoved);
        }
        #endregion

        #region OnVisualChildrenChanged
        protected override Size ArrangeOverride(Size finalSize)
        {
            var isVertical = Orientation == Orientation.Vertical;

            var offset = 0d;

            foreach (UIElement child in InternalChildren)
            {
                var animateIn = GetAnimateIn(child);
                var animateOut = GetAnimateOut(child);
                if (animateOut != 0)
                {
                    if (isVertical)
                    {
                        child.Arrange(new Rect(0, offset + animateOut, finalSize.Width, child.DesiredSize.Height));
                        offset += child.DesiredSize.Height;
                    }
                    else
                    {
                        child.Arrange(new Rect(offset + animateOut, 0, child.DesiredSize.Width, finalSize.Height));
                        offset += child.DesiredSize.Width;
                    }
                }
                else
                {
                    if (isVertical)
                    {
                        child.Arrange(new Rect(0, offset, finalSize.Width, (1 - animateIn) * child.DesiredSize.Height));
                        offset += (1 - animateIn) * child.DesiredSize.Height;
                    }
                    else
                    {
                        child.Arrange(new Rect(offset, 0, (1 - animateIn) * child.DesiredSize.Width, finalSize.Height));
                        offset += (1 - animateIn) * child.DesiredSize.Width;
                    }
                }
            }
            return finalSize;
        }
        #endregion

        #endregion

        #region Event Handlers
        private static void OnAnimateInChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (VisualTreeHelper.GetParent(d) is AnimationStackPanel stackPanel)
            {
                stackPanel.InvalidateArrange();
            }
        }
        #endregion
    }
}
