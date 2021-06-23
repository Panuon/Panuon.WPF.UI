using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class RingProgressBar : RangeBase
    {
        #region Ctor
        static RingProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RingProgressBar), new FrameworkPropertyMetadata(typeof(RingProgressBar)));
        }
        #endregion

        #region Events

        public event GeneratingPercentTextRoutedEventHandler GeneratingPercentText
        {
            add { AddHandler(GeneratingPercentTextEvent, value); }
            remove { RemoveHandler(GeneratingPercentTextEvent, value); }
        }

        public static readonly RoutedEvent GeneratingPercentTextEvent =
            EventManager.RegisterRoutedEvent("GeneratingPercentText", RoutingStrategy.Bubble, typeof(GeneratingPercentTextRoutedEventHandler), typeof(RingProgressBar));
        #endregion

        #region Properties

        #region BorderThickness
        public new double BorderThickness
        {
            get { return (double)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public new static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(double), typeof(RingProgressBar));
        #endregion

        #region IsPercentVisible
        public bool IsPercentVisible
        {
            get { return (bool)GetValue(IsPercentVisibleProperty); }
            set { SetValue(IsPercentVisibleProperty, value); }
        }

        public static readonly DependencyProperty IsPercentVisibleProperty =
            DependencyProperty.Register("IsPercentVisible", typeof(bool), typeof(RingProgressBar));
        #endregion

        #region PercentStringFormat
        public string PercentStringFormat
        {
            get { return (string)GetValue(PercentStringFormatProperty); }
            set { SetValue(PercentStringFormatProperty, value); }
        }

        public static readonly DependencyProperty PercentStringFormatProperty =
            DependencyProperty.Register("PercentStringFormat", typeof(string), typeof(RingProgressBar), new PropertyMetadata("{0:P0}"));
        #endregion

        #region AnimationEase
        public AnimationEase AnimationEase
        {
            get { return (AnimationEase)GetValue(AnimationEaseProperty); }
            set { SetValue(AnimationEaseProperty, value); }
        }

        public static readonly DependencyProperty AnimationEaseProperty =
            DependencyProperty.Register("AnimationEase", typeof(AnimationEase), typeof(RingProgressBar));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(RingProgressBar));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.Register("ShadowColor", typeof(Color?), typeof(RingProgressBar));
        #endregion

        #endregion

        #region Overrides
        protected override void OnValueChanged(double oldValue, double newValue)
        {
            if (IsLoaded)
            {
                AnimationUtil.BeginDoubleAnimation(this, InternalValueProperty, null, newValue, AnimationDuration, null, AnimationEase);
            }
            else
            {
                InternalValue = newValue;
            }
        }
        #endregion

        #region Internal Properties

        #region Text
        internal string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        internal static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(RingProgressBar));
        #endregion

        #region InternalValue
        internal double InternalValue
        {
            get { return (double)GetValue(InternalValueProperty); }
            set { SetValue(InternalValueProperty, value); }
        }

        internal static readonly DependencyProperty InternalValueProperty =
            DependencyProperty.Register("InternalValue", typeof(double), typeof(RingProgressBar), new PropertyMetadata(OnInternalValueChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnInternalValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var progressBar = (RingProgressBar)d;
            progressBar.OnInternalValueChanged();
        }
        #endregion

        #region Functions
        private void OnInternalValueChanged()
        {
            var percent = (InternalValue - Minimum) / (Maximum - Minimum);
            var text = string.IsNullOrEmpty(PercentStringFormat) ? percent.ToString("P0") : string.Format(PercentStringFormat, percent);
            var args = new GeneratingPercentTextRoutedEventArgs(GeneratingPercentTextEvent, InternalValue, percent, text);
            RaiseEvent(args);
            Text = args.Text;
        }
        #endregion
    }
}
