using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = CanvasTemplateName, Type = typeof(Canvas))]
    [TemplatePart(Name = ThumbTemplateName, Type = typeof(Thumb))]
    public class ThumbFence : Control
    {
        #region Fields
        private const string CanvasTemplateName = "PART_Canvas";

        private const string ThumbTemplateName = "PART_Thumb";

        private Canvas _canvas;

        private Thumb _thumb;

        private bool _isCoerceEffects;
        #endregion

        #region Ctor
        static ThumbFence()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ThumbFence), new FrameworkPropertyMetadata(typeof(ThumbFence)));
        }
        #endregion

        #region Routed Events



        #endregion

        #region Properties

        #region CenterPosition
        public Point CenterPosition
        {
            get { return (Point)GetValue(CenterPositionProperty); }
            set { SetValue(CenterPositionProperty, value); }
        }

        public static readonly DependencyProperty CenterPositionProperty =
            DependencyProperty.Register("CenterPosition", typeof(Point), typeof(ThumbFence), new PropertyMetadata(new Point(), OnCenterPositionChanged, OnCenterPositionCoerceValue));

        #endregion

        #region ThumbStyle
        public Style ThumbStyle
        {
            get { return (Style)GetValue(ThumbStyleProperty); }
            set { SetValue(ThumbStyleProperty, value); }
        }

        public static readonly DependencyProperty ThumbStyleProperty =
            DependencyProperty.Register("ThumbStyle", typeof(Style), typeof(ThumbFence), new PropertyMetadata(OnEffectivePropertyChanged));
        #endregion

        #region Strategy
        public FenceStrategy Strategy
        {
            get { return (FenceStrategy)GetValue(StrategyProperty); }
            set { SetValue(StrategyProperty, value); }
        }

        public static readonly DependencyProperty StrategyProperty =
            DependencyProperty.Register("Strategy", typeof(FenceStrategy), typeof(ThumbFence), new PropertyMetadata(OnEffectivePropertyChanged));
        #endregion

        #region ClickToPosition
        public bool ClickToPosition
        {
            get { return (bool)GetValue(ClickToPositionProperty); }
            set { SetValue(ClickToPositionProperty, value); }
        }

        public static readonly DependencyProperty ClickToPositionProperty =
            DependencyProperty.Register("ClickToPosition", typeof(bool), typeof(ThumbFence), new PropertyMetadata(true));
        #endregion

        #endregion

        #region Overrides

        #region OnApplyTemplate
        public override void OnApplyTemplate()
        {
            _canvas = GetTemplateChild(CanvasTemplateName) as Canvas;

            _thumb = GetTemplateChild(ThumbTemplateName) as Thumb;
            _thumb.DragDelta += Thumb_DragDelta;
            
            CoerceValue(CenterPositionProperty);
            if (!_isCoerceEffects)
            {
                Relocation();
            }
        }
        #endregion

        #region OnPreviewMouseLeftButtonDown
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);

            if (ClickToPosition)
            {
                var centerPosition = e.GetPosition(_canvas);
                SetCurrentValue(CenterPositionProperty, centerPosition);

                Dispatcher.BeginInvoke(DispatcherPriority.Input, new Action(() =>
                {
                    _thumb.RaiseEvent(e);
                }));
            }
        }
        #endregion

        #endregion

        #region Event Handlers
        private static object OnCenterPositionCoerceValue(DependencyObject d, object baseValue)
        {
            var fence = (ThumbFence)d;
            var centerPosition = (Point)baseValue;
            fence.EnsureLocation(ref centerPosition);
            return centerPosition;
        }

        private static void OnCenterPositionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var fence = (ThumbFence)d;
            fence.Relocation();
        }

        private static void OnEffectivePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var fence = (ThumbFence)d;
            fence.CoerceValue(CenterPositionProperty);
        }

        private void Thumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var centerPosition = CenterPosition;
            centerPosition.X += e.HorizontalChange;
            centerPosition.Y += e.VerticalChange;
            SetCurrentValue(CenterPositionProperty, centerPosition);
        }
        #endregion

        #region Functions
        private void Relocation()
        {
            if (_thumb == null || _canvas == null)
            {
                return;
            }
            _isCoerceEffects = true;

            Canvas.SetLeft(_thumb, CenterPosition.X - _thumb.RenderSize.Width / 2);
            Canvas.SetTop(_thumb, CenterPosition.Y - _thumb.RenderSize.Height / 2);

        }

        private void EnsureLocation(ref Point centerPosition)
        {
            if(_thumb == null || _canvas == null)
            {
                return;
            }
            var halfThumbWidth = _thumb.RenderSize.Width / 2;
            var halfThumbHeight = _thumb.RenderSize.Width / 2;
            var canvasWidth = _canvas.RenderSize.Width;
            var canvasHeight = _canvas.RenderSize.Height;

            switch (Strategy)
            {
                case FenceStrategy.AllowCross:
                    if (centerPosition.X < 0)
                    {
                        centerPosition.X = 0;
                    }
                    else if (centerPosition.X > canvasWidth)
                    {
                        centerPosition.X = canvasWidth;
                    }
                    if (centerPosition.Y < 0)
                    {
                        centerPosition.Y = 0;
                    }
                    else if (centerPosition.Y > canvasHeight)
                    {
                        centerPosition.Y = canvasHeight;
                    }
                    break;
                case FenceStrategy.Entire:
                    if (centerPosition.X < halfThumbWidth)
                    {
                        centerPosition.X = halfThumbWidth;
                    }
                    else if (centerPosition.X > canvasWidth - halfThumbWidth)
                    {
                        centerPosition.X = canvasWidth - halfThumbWidth;
                    }
                    if (centerPosition.Y < halfThumbHeight)
                    {
                        centerPosition.Y = halfThumbHeight;
                    }
                    else if (centerPosition.Y > canvasHeight - halfThumbHeight)
                    {
                        centerPosition.Y = canvasHeight - halfThumbHeight;
                    }
                    break;
            }

        }
        #endregion

    }
}
