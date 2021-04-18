using System;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver
{
    public class UniformWrapPanel : Panel
    {
        #region Fields
        private bool _isVertical;
        #endregion

        #region Properties

        #region Groups
        public int Groups
        {
            get { return (int)GetValue(GroupsProperty); }
            set { SetValue(GroupsProperty, value); }
        }

        public static readonly DependencyProperty GroupsProperty =
            DependencyProperty.Register("Groups", typeof(int), typeof(UniformWrapPanel), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange, null, OnGroupsCoerceValue));

        #endregion

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(UniformWrapPanel), new FrameworkPropertyMetadata(Orientation.Vertical, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange));
        #endregion

        #region HorizontalSpacing
        public double HorizontalSpacing
        {
            get { return (double)GetValue(HorizontalSpacingProperty); }
            set { SetValue(HorizontalSpacingProperty, value); }
        }

        public static readonly DependencyProperty HorizontalSpacingProperty =
            DependencyProperty.Register("HorizontalSpacing", typeof(double), typeof(UniformWrapPanel), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange, null, OnHorizontalSpacingCoerceValue));

        #endregion

        #region VerticalSpacing
        public double VerticalSpacing
        {
            get { return (double)GetValue(VerticalSpacingProperty); }
            set { SetValue(VerticalSpacingProperty, value); }
        }

        public static readonly DependencyProperty VerticalSpacingProperty =
            DependencyProperty.Register("VerticalSpacing", typeof(double), typeof(UniformWrapPanel), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange, null, OnVerticalSpacingCoerceValue));
        #endregion

        #endregion

        #region Overrides

        #region MeasureOverride
        protected override Size MeasureOverride(Size constraint)
        {
            UpdateComputedValues();

            var width = _isVertical
                ? constraint.Width
                : 0.0;
            var height = _isVertical
                ? 0.0
                : constraint.Height;
            var childConstraint = new Size(
                _isVertical
                    ? (constraint.Width - (Groups - 1) * HorizontalSpacing) / Groups
                    : constraint.Width,
                _isVertical
                    ? constraint.Height
                    : (constraint.Height - (Groups - 1) * VerticalSpacing) / Groups);

            var rowWidth = 0.0;
            var rowHeight = 0.0;

            for (var i = 0; i < InternalChildren.Count; i++)
            {
                if (i % Groups == 0)
                {
                    width += rowWidth;
                    height += rowHeight;
                    rowWidth = 0;
                    rowHeight = 0;
                }

                var child = InternalChildren[i];
                child.Measure(childConstraint);

                rowWidth = Math.Max(rowWidth, child.DesiredSize.Width);
                rowHeight = Math.Max(rowHeight, child.DesiredSize.Height);
            }

            width += rowWidth;
            height += rowHeight;

            return new Size(
                _isVertical
                    ? (double.IsInfinity(constraint.Width) ? 0 : constraint.Width)
                    : width,
                _isVertical
                    ? height
                    : (double.IsInfinity(constraint.Height) ? 0 : constraint.Height));
        }
        #endregion

        #region ArrangeOverride
        protected override Size ArrangeOverride(Size finalSize)
        {
            var left = 0.0;
            var top = 0.0;

            var childWidth = (finalSize.Width - (Groups - 1) * HorizontalSpacing) / Groups;
            var childHeight = (finalSize.Height - (Groups - 1) * VerticalSpacing) / Groups;
            var rowWidth = 0.0;
            var rowHeight = 0.0;

            for (var i = 0; i < InternalChildren.Count; i++)
            {
                if ((_isVertical && left >= finalSize.Width) || (!_isVertical && top >= finalSize.Height))
                {
                    left = _isVertical ? 0.0 : (left + rowWidth + HorizontalSpacing);
                    top = _isVertical ? (top + rowHeight +VerticalSpacing) : 0.0;
                    rowHeight = 0;
                    rowWidth = 0;
                }

                var child = InternalChildren[i];
                var childSize = new Rect(left, top,
                    _isVertical
                        ? childWidth
                        : child.DesiredSize.Width,
                    _isVertical
                        ? child.DesiredSize.Height
                        : childHeight);
                child.Arrange(childSize);

                if (child.Visibility != Visibility.Collapsed)
                {
                    left += _isVertical ? (HorizontalSpacing + childWidth) : 0;
                    top += _isVertical ? 0 : (VerticalSpacing + childHeight);
                }

                rowHeight = Math.Max(rowHeight, child.DesiredSize.Height);
                rowWidth = Math.Max(rowWidth, child.DesiredSize.Width);
            }

            return finalSize;
        }
        #endregion

        #endregion

        #region Event Handlers
        private static object OnGroupsCoerceValue(DependencyObject d, object baseValue)
        {
            var Groups = (int)baseValue;
            if (Groups < 1)
            {
                return 1;
            }
            return baseValue;
        }

        private static object OnHorizontalSpacingCoerceValue(DependencyObject d, object baseValue)
        {
            var spacing = (double)baseValue;
            if (double.IsNaN(spacing) || double.IsInfinity(spacing) || spacing < 0)
            {
                throw new ArgumentException($"{spacing} is not a valid value for {nameof(HorizontalSpacing)}.", nameof(HorizontalSpacing));
            }
            return baseValue;
        }

        private static object OnVerticalSpacingCoerceValue(DependencyObject d, object baseValue)
        {
            var spacing = (double)baseValue;
            if (double.IsNaN(spacing) || double.IsInfinity(spacing) || spacing < 0)
            {
                throw new ArgumentException($"{spacing} is not a valid value for {nameof(VerticalSpacing)}.", nameof(VerticalSpacing));
            }
            return baseValue;
        }
        #endregion

        #region Functions
        private void UpdateComputedValues()
        {
            _isVertical = Orientation == Orientation.Vertical;
        }
        #endregion
    }

}
