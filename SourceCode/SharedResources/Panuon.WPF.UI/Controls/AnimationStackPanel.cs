using Panuon.WPF.UI.Configurations;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Linq;

namespace Panuon.WPF.UI
{
    public class AnimationStackPanel : StackPanel
    {
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
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(AnimationStackPanel), new PropertyMetadata(TimeSpan.FromSeconds(0.5)));
        #endregion

        #region Spacing
        public double Spacing
        {
            get { return (double)GetValue(SpacingProperty); }
            set { SetValue(SpacingProperty, value); }
        }

        public static readonly DependencyProperty SpacingProperty =
            DependencyProperty.Register("Spacing", typeof(double), typeof(AnimationStackPanel), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsArrange));
        #endregion

        #region ArrangeDirection
        public ArrangeDirection ArrangeDirection
        {
            get { return (ArrangeDirection)GetValue(ArrangeDirectionProperty); }
            set { SetValue(ArrangeDirectionProperty, value); }
        }

        public static readonly DependencyProperty ArrangeDirectionProperty =
            DependencyProperty.Register("ArrangeDirection", typeof(ArrangeDirection), typeof(AnimationStackPanel), new FrameworkPropertyMetadata(ArrangeDirection.Normal, FrameworkPropertyMetadataOptions.AffectsArrange));
        #endregion

        #endregion

        #region Internal Properties

        #region MultiplierX
        internal static double GetMultiplierX(DependencyObject obj)
        {
            return (double)obj.GetValue(MultiplierXProperty);
        }

        internal static void SetMultiplierX(DependencyObject obj, double value)
        {
            obj.SetValue(MultiplierXProperty, value);
        }

        internal static readonly DependencyProperty MultiplierXProperty =
            DependencyProperty.RegisterAttached("MultiplierX", typeof(double), typeof(AnimationStackPanel), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsParentArrange));
        #endregion

        #region MultiplierY
        internal static double GetMultiplierY(DependencyObject obj)
        {
            return (double)obj.GetValue(MultiplierYProperty);
        }

        internal static void SetMultiplierY(DependencyObject obj, double value)
        {
            obj.SetValue(MultiplierYProperty, value);
        }

        internal static readonly DependencyProperty MultiplierYProperty =
            DependencyProperty.RegisterAttached("MultiplierY", typeof(double), typeof(AnimationStackPanel), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsParentArrange));
        #endregion

        #endregion

        #region Overrides

        #region OnVisualChildrenChanged
        protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
        {
            var isVertical = Orientation == Orientation.Vertical;
            if (visualAdded is UIElement elementAdded)
            {
                if (isVertical)
                {
                    SetMultiplierX(elementAdded, 1);
                    AnimationUtil.BeginDoubleAnimation(elementAdded, MultiplierXProperty, null, 0, AnimationDuration, ease: AnimationEase);
                }
                else
                {
                    SetMultiplierY(elementAdded, -1);
                    AnimationUtil.BeginDoubleAnimation(elementAdded, MultiplierYProperty, null, 0, AnimationDuration, ease: AnimationEase);
                }
            }
            if (visualRemoved is UIElement elementRemoved)
            {
                var flag = false;
                foreach (UIElement child in InternalChildren)
                {
                    if (flag)
                    {
                        if (isVertical)
                        {
                            SetMultiplierY(child, 1);
                            child.BeginAnimation(MultiplierYProperty, null);
                            AnimationUtil.BeginDoubleAnimation(child, MultiplierYProperty, null, 0, AnimationDuration, ease: AnimationEase);
                        }
                        else
                        {
                            SetMultiplierX(child, 1);
                            child.BeginAnimation(MultiplierXProperty, null);
                            AnimationUtil.BeginDoubleAnimation(child, MultiplierXProperty, null, 0, AnimationDuration, ease: AnimationEase);
                        }

                    }
                    if (child == null)
                    {
                        flag = true;
                    }
                }
            }
            base.OnVisualChildrenChanged(visualAdded, visualRemoved);
        }
        #endregion

        #region ArrangeOverride
        protected override Size ArrangeOverride(Size finalSize)
        {
            var isVertical = Orientation == Orientation.Vertical;
            var reverse = ArrangeDirection == ArrangeDirection.Reverse;

            var offset = 0d;

            foreach (UIElement child in InternalChildren)
            {
                var multiplierX = GetMultiplierX(child);
                var multiplierY = GetMultiplierY(child);

                if (!reverse)
                {
                    if (isVertical)
                    {
                        child.Arrange(new Rect(multiplierX * finalSize.Width, offset + multiplierY * child.DesiredSize.Height, finalSize.Width, child.DesiredSize.Height));
                        offset += child.DesiredSize.Height;
                    }
                    else
                    {
                        child.Arrange(new Rect(offset + multiplierX * child.DesiredSize.Width, multiplierY * finalSize.Height, child.DesiredSize.Width, finalSize.Height));
                        offset += child.DesiredSize.Width;
                    }
                }
                else
                {
                    if (isVertical)
                    {
                        offset += child.DesiredSize.Height;
                        child.Arrange(new Rect(multiplierX * finalSize.Width, finalSize.Height - offset - multiplierY * child.DesiredSize.Height, finalSize.Width, child.DesiredSize.Height));
                    }
                    else
                    {
                        offset += child.DesiredSize.Width;
                        child.Arrange(new Rect(finalSize.Width - offset - multiplierX * child.DesiredSize.Width, multiplierY * finalSize.Height, child.DesiredSize.Width, finalSize.Height));
                    }
                }

                offset += Spacing;
            }
            return finalSize;
        }
        #endregion

        #endregion
    }
}
