using Panuon.WPF;
using Panuon.WPF.UI.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Threading;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = CanvasTemplateName, Type = typeof(Canvas))]
    [TemplatePart(Name = ThumbTemplateName, Type = typeof(Thumb))]
    public class ThumbFence : Control
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ThumbStyleKey { get; } =
            new ComponentResourceKey(typeof(ThumbFence), nameof(ThumbStyleKey));
        #endregion

        #region Fields
        private const string CanvasTemplateName = "PART_Canvas";

        private const string ThumbTemplateName = "PART_Thumb";

        private Canvas _canvas;

        internal Thumb _thumb;
        #endregion

        #region Ctor
        static ThumbFence()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ThumbFence), new FrameworkPropertyMetadata(typeof(ThumbFence)));
        }
        #endregion

        #region Routed Events

        #region PositionChanged
        public event PositionChangedRoutedEventHandler ThumbPositionChanged
        {
            add { AddHandler(ThumbPositionChangedEvent, value); }
            remove { RemoveHandler(ThumbPositionChangedEvent, value); }
        }

        public static readonly RoutedEvent ThumbPositionChangedEvent =
            EventManager.RegisterRoutedEvent("ThumbPositionChanged", RoutingStrategy.Bubble, typeof(PositionChangedRoutedEventHandler), typeof(ThumbFence));
        #endregion

        #region PositionChanging
        public event PositionChangingEventHandler ThumbPositionChanging
        {
            add { AddHandler(ThumbPositionChangingEvent, value); }
            remove { RemoveHandler(ThumbPositionChangingEvent, value); }
        }

        public static readonly RoutedEvent ThumbPositionChangingEvent =
            EventManager.RegisterRoutedEvent("ThumbPositionChanging", RoutingStrategy.Bubble, typeof(PositionChangingEventHandler), typeof(ThumbFence));
        #endregion

        #endregion

        #region Properties

        #region ThumbPosition
        public Point ThumbPosition
        {
            get { return (Point)GetValue(ThumbPositionProperty); }
            set { SetValue(ThumbPositionProperty, value); }
        }

        public static readonly DependencyProperty ThumbPositionProperty =
            DependencyProperty.Register("ThumbPosition", typeof(Point), typeof(ThumbFence), new PropertyMetadata(new Point(), OnPositionChanged, OnPositionCoerceValue));

        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(ThumbFence));
        #endregion

        #region ThumbStyle
        public static Style GetThumbStyle(ThumbFence thumbFence)
        {
            return (Style)thumbFence.GetValue(ThumbStyleProperty);
        }

        public static void SetThumbStyle(ThumbFence thumbFence, Style value)
        {
            thumbFence.SetValue(ThumbStyleProperty, value);
        }

        public static readonly DependencyProperty ThumbStyleProperty =
            DependencyProperty.RegisterAttached("ThumbStyle", typeof(Style), typeof(ThumbFence));
        #endregion

        #region AllowCross
        public bool AllowCross
        {
            get { return (bool)GetValue(AllowCrossProperty); }
            set { SetValue(AllowCrossProperty, value); }
        }

        public static readonly DependencyProperty AllowCrossProperty =
            DependencyProperty.Register("AllowCross", typeof(bool), typeof(ThumbFence), new PropertyMetadata(OnEffectivePropertyChanged));
        #endregion

        #endregion

        #region Overrides

        #region OnApplyTemplate
        public override void OnApplyTemplate()
        {
            _canvas = GetTemplateChild(CanvasTemplateName) as Canvas;

            _thumb = GetTemplateChild(ThumbTemplateName) as Thumb;
            _thumb.DragDelta += Thumb_DragDelta;
        }
        #endregion

        #region OnPreviewMouseLeftButtonDown
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            var renderWidth = _canvas.RenderSize.Width;
            var renderHeight = _canvas.RenderSize.Height;
            if (renderWidth == 0 || renderHeight == 0)
            {
                return;
            }
            var mousePosition = e.GetPosition(_canvas);
            var position = new Point(mousePosition.X / renderWidth, mousePosition.Y / renderHeight);

            var args = new PositionChangingRoutedEventArgs(ThumbPositionChangingEvent, position);
            RaiseEvent(args);
            if (!args.Cancel)
            {
                SetCurrentValue(ThumbPositionProperty, args.NewPosition);
            }

            _thumb.RaiseEvent(e);

            e.Handled = true;
            base.OnMouseLeftButtonDown(e);
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnPreviewMouseUp(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseUp(e);
        }
        #endregion

        #region OnRenderSizeChanged
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            base.OnRenderSizeChanged(sizeInfo);
            Relocation();
        }
        #endregion

        #endregion

        #region Event Handlers
        private static object OnPositionCoerceValue(DependencyObject d, object baseValue)
        {
            var position = (Point)baseValue;
            position.X = Math.Max(0, Math.Min(1, position.X));
            position.Y = Math.Max(0, Math.Min(1, position.Y));
            return position;
        }

        private static void OnPositionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var fence = (ThumbFence)d;
            fence.Relocation();
            fence.RaiseEvent(new PositionChangedRoutedEventArgs(ThumbPositionChangedEvent, (Point)e.NewValue));
        }

        private static void OnEffectivePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var fence = (ThumbFence)d;
            fence.Relocation();
        }

        private void Thumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var renderWidth = _canvas.RenderSize.Width;
            var renderHeight = _canvas.RenderSize.Height;
            if (renderWidth == 0 || renderHeight == 0)
            {
                return;
            }
            var mousePosition = Mouse.GetPosition(this);
            var position = new Point(mousePosition.X / renderWidth, mousePosition.Y / renderHeight);

            var args = new PositionChangingRoutedEventArgs(ThumbPositionChangingEvent, position);
            RaiseEvent(args);
            if (!args.Cancel)
            {
                SetCurrentValue(ThumbPositionProperty, args.NewPosition);
            }
        }
        #endregion

        #region Functions
        private void Relocation()
        {
            if (_thumb == null || _canvas == null
                || _canvas.RenderSize.Width == 0 || _canvas.RenderSize.Height == 0)
            {
                return;
            }

            var thumbWidth = _thumb.RenderSize.Width;
            var thumbHeight = _thumb.RenderSize.Height;
            var halfThumbWidth = thumbWidth / 2;
            var halfThumbHeight = thumbHeight / 2;
            var renderWidth = _canvas.RenderSize.Width;
            var renderHeight = _canvas.RenderSize.Height;

            var left = AllowCross
                 ? (ThumbPosition.X * renderWidth - halfThumbWidth)
                 : (ThumbPosition.X * (renderWidth - thumbWidth));
            var top = AllowCross
                    ? (ThumbPosition.Y * renderHeight - halfThumbHeight)
                    : (ThumbPosition.Y * (renderHeight - thumbHeight));
            Canvas.SetLeft(_thumb, left);
            Canvas.SetTop(_thumb, top);

        }

        #endregion

    }
}
