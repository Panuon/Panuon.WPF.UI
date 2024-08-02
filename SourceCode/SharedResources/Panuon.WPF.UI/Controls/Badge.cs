using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = WaveBorderTemplateName, Type = typeof(Border))]
    public class Badge
        : ButtonBase
    {
        #region Fields
        private const string WaveBorderTemplateName = "PART_WaveBorder";

        private Border _waveBorder;
        private ScaleTransform _scaleTransform;
        #endregion

        #region Ctor
        static Badge()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Badge), new FrameworkPropertyMetadata(typeof(Badge)));
        }
        #endregion

        #region Properties

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(Badge));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(Badge));
        #endregion

        #region IsWaving
        public bool IsWaving
        {
            get { return (bool)GetValue(IsWavingProperty); }
            set { SetValue(IsWavingProperty, value); }
        }

        public static readonly DependencyProperty IsWavingProperty =
            DependencyProperty.Register("IsWaving", typeof(bool), typeof(Badge), new PropertyMetadata(OnScaleChanged));
        #endregion

        #region WaveBrush
        public Brush WaveBrush
        {
            get { return (Brush)GetValue(WaveBrushProperty); }
            set { SetValue(WaveBrushProperty, value); }
        }

        public static readonly DependencyProperty WaveBrushProperty =
            DependencyProperty.Register("WaveBrush", typeof(Brush), typeof(Badge));
        #endregion

        #region WaveThickness
        public Thickness WaveThickness
        {
            get { return (Thickness)GetValue(WaveThicknessProperty); }
            set { SetValue(WaveThicknessProperty, value); }
        }

        public static readonly DependencyProperty WaveThicknessProperty =
            DependencyProperty.Register("WaveThickness", typeof(Thickness), typeof(Badge));
        #endregion

        #region WaveScale
        public double WaveScale
        {
            get { return (double)GetValue(WaveScaleProperty); }
            set { SetValue(WaveScaleProperty, value); }
        }

        public static readonly DependencyProperty WaveScaleProperty =
            DependencyProperty.Register("WaveScale", typeof(double), typeof(Badge), new PropertyMetadata(1.5d));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(Badge));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(Badge));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(Badge));
        #endregion

        #region HoverBorderThickness
        public Thickness? HoverBorderThickness
        {
            get { return (Thickness?)GetValue(HoverBorderThicknessProperty); }
            set { SetValue(HoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(Badge));
        #endregion

        #region HoverCornerRadius
        public CornerRadius? HoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(HoverCornerRadiusProperty); }
            set { SetValue(HoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(Badge));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(Badge));
        #endregion

        #region ClickBackground
        public Brush ClickBackground
        {
            get { return (Brush)GetValue(ClickBackgroundProperty); }
            set { SetValue(ClickBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ClickBackgroundProperty =
            DependencyProperty.Register("ClickBackground", typeof(Brush), typeof(Badge));
        #endregion

        #region ClickForeground
        public Brush ClickForeground
        {
            get { return (Brush)GetValue(ClickForegroundProperty); }
            set { SetValue(ClickForegroundProperty, value); }
        }

        public static readonly DependencyProperty ClickForegroundProperty =
            DependencyProperty.Register("ClickForeground", typeof(Brush), typeof(Badge));
        #endregion

        #region ClickBorderBrush
        public Brush ClickBorderBrush
        {
            get { return (Brush)GetValue(ClickBorderBrushProperty); }
            set { SetValue(ClickBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ClickBorderBrushProperty =
            DependencyProperty.Register("ClickBorderBrush", typeof(Brush), typeof(Badge));
        #endregion

        #region ClickBorderThickness
        public Thickness? ClickBorderThickness
        {
            get { return (Thickness?)GetValue(ClickBorderThicknessProperty); }
            set { SetValue(ClickBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ClickBorderThicknessProperty =
            DependencyProperty.Register("ClickBorderThickness", typeof(Thickness?), typeof(Badge));
        #endregion

        #region ClickCornerRadius
        public CornerRadius? ClickCornerRadius
        {
            get { return (CornerRadius?)GetValue(ClickCornerRadiusProperty); }
            set { SetValue(ClickCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ClickCornerRadiusProperty =
            DependencyProperty.Register("ClickCornerRadius", typeof(CornerRadius?), typeof(Badge));
        #endregion

        #region ClickEffect
        public ClickEffect ClickEffect
        {
            get { return (ClickEffect)GetValue(ClickEffectProperty); }
            set { SetValue(ClickEffectProperty, value); }
        }

        public static readonly DependencyProperty ClickEffectProperty =
            VisualStateHelper.ClickEffectProperty.AddOwner(typeof(Badge));
        #endregion

        #region AnimationEasing
        public AnimationEasing AnimationEasing
        {
            get { return (AnimationEasing)GetValue(AnimationEasingProperty); }
            set { SetValue(AnimationEasingProperty, value); }
        }

        public static readonly DependencyProperty AnimationEasingProperty =
            DependencyProperty.Register("AnimationEasing", typeof(AnimationEasing), typeof(Badge), new PropertyMetadata(OnAnimationEasingChanged));

        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(Badge), new PropertyMetadata(TimeSpan.FromSeconds(0.7), OnAnimationEasingChanged));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _waveBorder = GetTemplateChild(WaveBorderTemplateName) as Border;

            _scaleTransform = new ScaleTransform()
            {
                ScaleX = 1,
                ScaleY = 1,
            };
            _waveBorder.RenderTransform = _scaleTransform;
            
            OnScaleChanged();
        }
        #endregion

        #region Event Handlers
        private static void OnScaleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var badge = (Badge)d;
            badge.OnScaleChanged();
        }

        private static void OnAnimationEasingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var badge = (Badge)d;
            badge.OnScaleChanged();
        }
        #endregion

        #region Functions
        private void OnScaleChanged()
        {
            if (_waveBorder == null)
            {
                return;
            }

            if (IsWaving)
            {
                var storyboard = new Storyboard()
                {
                    RepeatBehavior = RepeatBehavior.Forever,
                };

                var scaleXAnimation = new DoubleAnimation()
                {
                    From = 1,
                    To = WaveScale,
                    Duration = AnimationDuration,
                    EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                };
                Storyboard.SetTarget(scaleXAnimation, _waveBorder);
                Storyboard.SetTargetProperty(scaleXAnimation, new PropertyPath("RenderTransform.ScaleX"));
                storyboard.Children.Add(scaleXAnimation);

                var scaleYAnimation = new DoubleAnimation()
                {
                    From = 1,
                    To = WaveScale,
                    Duration = AnimationDuration,
                    EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                };
                Storyboard.SetTarget(scaleYAnimation, _waveBorder);
                Storyboard.SetTargetProperty(scaleYAnimation, new PropertyPath("RenderTransform.ScaleY"));
                storyboard.Children.Add(scaleYAnimation);

                var opacityAnimation = new DoubleAnimation()
                {
                    From = 1,
                    To = 0,
                    Duration = AnimationDuration,
                    EasingFunction = AnimationUtil.CreateEasingFunction(AnimationEasing),
                };
                Storyboard.SetTarget(opacityAnimation, _waveBorder);
                Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath(Border.OpacityProperty));
                storyboard.Children.Add(opacityAnimation);

                storyboard.Begin();
            }
            else
            {
                var storyboard = new Storyboard()
                {
                    RepeatBehavior = RepeatBehavior.Forever,
                };

                var scaleXAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.Zero,
                };
                Storyboard.SetTarget(scaleXAnimation, _waveBorder);
                Storyboard.SetTargetProperty(scaleXAnimation, new PropertyPath("RenderTransform.ScaleX"));
                storyboard.Children.Add(scaleXAnimation);

                var scaleYAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.Zero,
                };
                Storyboard.SetTarget(scaleYAnimation, _waveBorder);
                Storyboard.SetTargetProperty(scaleYAnimation, new PropertyPath("RenderTransform.ScaleY"));
                storyboard.Children.Add(scaleYAnimation);

                var opacityAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.Zero,
                };
                Storyboard.SetTarget(opacityAnimation, _waveBorder);
                Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath(Border.OpacityProperty));
                storyboard.Children.Add(opacityAnimation);

                storyboard.Begin();

            }
        }
        #endregion
    }
}
