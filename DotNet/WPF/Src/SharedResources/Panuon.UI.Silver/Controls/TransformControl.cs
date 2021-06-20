using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = nameof(ContentPresenterTemplatePartName), Type = typeof(ContentPresenter))]
    public class TransformControl : ContentControl
    {
        #region Fields
        private const string ContentPresenterTemplatePartName = "PART_ContentPresenter";

        private ContentPresenter _contentPresenter;

        private ScaleTransform _scaleTransform;
        #endregion

        #region Ctor
        static TransformControl()
        {
            FocusableProperty.OverrideMetadata(typeof(TransformControl), new FrameworkPropertyMetadata(false));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TransformControl), new FrameworkPropertyMetadata(typeof(TransformControl)));
        }
        #endregion

        #region Properties

        #region Origin
        public Point Origin
        {
            get { return (Point)GetValue(OriginProperty); }
            set { SetValue(OriginProperty, value); }
        }

        public static readonly DependencyProperty OriginProperty =
            DependencyProperty.Register("Origin", typeof(Point), typeof(TransformControl), new PropertyMetadata(new Point(0.5, 0.5)));
        #endregion 

        #region ScaleX
        public int ScaleX
        {
            get { return (int)GetValue(ScaleXProperty); }
            set { SetValue(ScaleXProperty, value); }
        }

        public static readonly DependencyProperty ScaleXProperty =
            DependencyProperty.Register("ScaleX", typeof(int), typeof(TransformControl), new PropertyMetadata(1, OnScaleXChanged));
        #endregion

        #region ScaleY
        public int ScaleY
        {
            get { return (int)GetValue(ScaleYProperty); }
            set { SetValue(ScaleYProperty, value); }
        }

        public static readonly DependencyProperty ScaleYProperty =
            DependencyProperty.Register("ScaleY", typeof(int), typeof(TransformControl), new PropertyMetadata(1, OnScaleYChanged));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(TransformControl));
        #endregion

        #region AnimationEase
        public AnimationEase AnimationEase
        {
            get { return (AnimationEase)GetValue(AnimationEaseProperty); }
            set { SetValue(AnimationEaseProperty, value); }
        }

        public static readonly DependencyProperty AnimationEaseProperty =
            DependencyProperty.Register("AnimationEase", typeof(AnimationEase), typeof(TransformControl));
        #endregion 

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            
            _contentPresenter = GetTemplateChild(ContentPresenterTemplatePartName) as ContentPresenter;

            var transformGroup = new TransformGroup();
            _scaleTransform = new ScaleTransform(ScaleX, ScaleY);
            transformGroup.Children.Add(_scaleTransform);

            _contentPresenter.RenderTransform = transformGroup;
        }
        #endregion

        #region Event Handlers
        private static void OnScaleXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TransformControl)d;
            control.OnScaleXChanged();
        }

        private static void OnScaleYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TransformControl)d;
            control.OnScaleYChanged();
        }
        #endregion

        #region Functions
        private void OnScaleXChanged()
        {
            if(_scaleTransform == null || _scaleTransform.ScaleX == ScaleX)
            {
                return;
            }
            AnimationUtil.BeginDoubleAnimation(_scaleTransform, ScaleTransform.ScaleXProperty, null, ScaleX, AnimationDuration, null, AnimationEase);
        }

        private void OnScaleYChanged()
        {
            if (_scaleTransform == null || _scaleTransform.ScaleY == ScaleY)
            {
                return;
            }
            AnimationUtil.BeginDoubleAnimation(_scaleTransform, ScaleTransform.ScaleYProperty, null, ScaleY, AnimationDuration, null, AnimationEase);
        }
        #endregion
    }
}
