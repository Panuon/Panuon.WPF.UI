using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ProgressBarHelper
    {
        #region Events

        #region GeneratingPercentText
        public static void AddGeneratingPercentTextHandler(UIElement element, GeneratingPercentTextRoutedEventHandler eventHandler)
        {
            element.AddHandler(GeneratingPercentTextEvent, eventHandler);
        }

        public static void RemoveGeneratingPercentTextHandler(UIElement element, GeneratingPercentTextRoutedEventHandler eventHandler)
        {
            element.RemoveHandler(GeneratingPercentTextEvent, eventHandler);
        }

        public static readonly RoutedEvent GeneratingPercentTextEvent
            = EventManager.RegisterRoutedEvent("GeneratingPercentText", RoutingStrategy.Bubble, typeof(GeneratingPercentTextRoutedEventHandler), typeof(ProgressBarHelper));
        #endregion

        #endregion

        #region Properties

        #region FilledBackground
        public static Brush GetFilledBackground(ProgressBar progressBar)
        {
            return (Brush)progressBar.GetValue(FilledBackgroundProperty);
        }

        public static void SetFilledBackground(ProgressBar progressBar, Brush value)
        {
            progressBar.SetValue(FilledBackgroundProperty, value);
        }

        public static readonly DependencyProperty FilledBackgroundProperty =
            DependencyProperty.RegisterAttached("FilledBackground", typeof(Brush), typeof(ProgressBarHelper));
        #endregion

        #region Direction
        public static ProgressDirection GetDirection(ProgressBar progressBar)
        {
            return (ProgressDirection)progressBar.GetValue(DirectionProperty);
        }

        public static void SetDirection(ProgressBar progressBar, ProgressDirection value)
        {
            progressBar.SetValue(DirectionProperty, value);
        }

        public static readonly DependencyProperty DirectionProperty =
            DependencyProperty.RegisterAttached("Direction", typeof(ProgressDirection), typeof(ProgressBarHelper));

        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(ProgressBar progressBar)
        {
            return (CornerRadius)progressBar.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(ProgressBar progressBar, CornerRadius value)
        {
            progressBar.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(ProgressBarHelper));
        #endregion

        #region IsPercentVisible
        public static bool GetIsPercentVisible(ProgressBar progressBar)
        {
            return (bool)progressBar.GetValue(IsPercentVisibleProperty);
        }

        public static void SetIsPercentVisible(ProgressBar progressBar, bool value)
        {
            progressBar.SetValue(IsPercentVisibleProperty, value);
        }

        public static readonly DependencyProperty IsPercentVisibleProperty =
            DependencyProperty.RegisterAttached("IsPercentVisible", typeof(bool), typeof(ProgressBarHelper));
        #endregion

        #region PercentStringFormat
        public static string GetPercentStringFormat(ProgressBar progressBar)
        {
            return (string)progressBar.GetValue(PercentStringFormatProperty);
        }

        public static void SetPercentStringFormat(ProgressBar progressBar, string value)
        {
            progressBar.SetValue(PercentStringFormatProperty, value);
        }

        public static readonly DependencyProperty PercentStringFormatProperty =
            DependencyProperty.RegisterAttached("PercentStringFormat", typeof(string), typeof(ProgressBarHelper), new PropertyMetadata("P0", OnPercentStringFormatChanged));

        #endregion

        #region InvertedForeground
        public static Brush GetInvertedForeground(ProgressBar progressBar)
        {
            return (Brush)progressBar.GetValue(InvertedForegroundProperty);
        }

        public static void SetInvertedForeground(ProgressBar progressBar, Brush value)
        {
            progressBar.SetValue(InvertedForegroundProperty, value);
        }

        public static readonly DependencyProperty InvertedForegroundProperty =
            DependencyProperty.RegisterAttached("InvertedForeground", typeof(Brush), typeof(ProgressBarHelper));
        #endregion

        #region AnimationEasing
        public static AnimationEasing GetAnimationEasing(ProgressBar progressBar)
        {
            return (AnimationEasing)progressBar.GetValue(AnimationEasingProperty);
        }

        public static void SetAnimationEasing(ProgressBar progressBar, AnimationEasing value)
        {
            progressBar.SetValue(AnimationEasingProperty, value);
        }

        public static readonly DependencyProperty AnimationEasingProperty =
            DependencyProperty.RegisterAttached("AnimationEasing", typeof(AnimationEasing), typeof(ProgressBarHelper));
        #endregion

        #region AnimationDuration
        public static TimeSpan GetAnimationDuration(ProgressBar progressBar)
        {
            return (TimeSpan)progressBar.GetValue(AnimationDurationProperty);
        }

        public static void SetAnimationDuration(ProgressBar progressBar, TimeSpan value)
        {
            progressBar.SetValue(AnimationDurationProperty, value);
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.RegisterAttached("AnimationDuration", typeof(TimeSpan), typeof(ProgressBarHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(ProgressBar progressBar)
        {
            return (Color?)progressBar.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(ProgressBar progressBar, Color? value)
        {
            progressBar.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.RegisterAttached("ShadowColor", typeof(Color?), typeof(ProgressBarHelper));
        #endregion

        #endregion

        #region Internal Properties

        #region Hook
        internal static bool GetHook(DependencyObject obj)
        {
            return (bool)obj.GetValue(HookProperty);
        }

        internal static void SetHook(DependencyObject obj, bool value)
        {
            obj.SetValue(HookProperty, value);
        }

        internal static readonly DependencyProperty HookProperty =
            DependencyProperty.RegisterAttached("Hook", typeof(bool), typeof(ProgressBarHelper), new PropertyMetadata(OnHookChanged));
        #endregion

        #region Text
        internal static string GetText(DependencyObject obj)
        {
            return (string)obj.GetValue(TextProperty);
        }

        internal static void SetText(DependencyObject obj, string value)
        {
            obj.SetValue(TextProperty, value);
        }

        internal static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text", typeof(string), typeof(ProgressBarHelper));
        #endregion

        #region Value
        internal static double GetValue(DependencyObject obj)
        {
            return (double)obj.GetValue(ValueProperty);
        }

        internal static void SetValue(DependencyObject obj, double value)
        {
            obj.SetValue(ValueProperty, value);
        }

        internal static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", typeof(double), typeof(ProgressBarHelper), new PropertyMetadata(0d, OnValueChanged, OnValueCoerceValue));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var progressBar = (ProgressBar)d;
            progressBar.ValueChanged -= ProgressBar_ValueChanged;
            progressBar.ValueChanged += ProgressBar_ValueChanged;
            ProgressBar_ValueChanged(progressBar, new RoutedPropertyChangedEventArgs<double>(progressBar.Minimum, progressBar.Value));
        }

        private static object OnValueCoerceValue(DependencyObject d, object baseValue)
        {
            var progressBar = (ProgressBar)d;
            var value = (double)baseValue;
            if (value < progressBar.Minimum)
            {
                return progressBar.Minimum;
            }
            if (value > progressBar.Maximum)
            {
                return progressBar.Maximum;
            }
            return value;
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var progressBar = (ProgressBar)d;
            var stringFormat = GetPercentStringFormat(progressBar);
            var value = GetValue(progressBar);
            var percent = (value - progressBar.Minimum) / (progressBar.Maximum - progressBar.Minimum);
            var text = string.IsNullOrEmpty(stringFormat) ? percent.ToString("P0") : percent.ToString(stringFormat);
            var args = new GeneratingPercentTextRoutedEventArgs(GeneratingPercentTextEvent, progressBar.Value, percent, text);
            progressBar.RaiseEvent(args);
            SetText(progressBar, args.Text);
        }


        private static void OnPercentStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var progressBar = (ProgressBar)d;
            var stringFormat = GetPercentStringFormat(progressBar);
            var value = GetValue(progressBar);
            var percent = (value - progressBar.Minimum) / (progressBar.Maximum - progressBar.Minimum);
            var text = string.IsNullOrEmpty(stringFormat) ? percent.ToString("P0") : percent.ToString(stringFormat);
            var args = new GeneratingPercentTextRoutedEventArgs(GeneratingPercentTextEvent, progressBar.Value, percent, text);
            progressBar.RaiseEvent(args);
            SetText(progressBar, args.Text);
        }

        private static void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var progressBar = (ProgressBar)sender;
            var newValue = e.NewValue;
            var animationDuration = GetAnimationDuration(progressBar);
            var animationEase = GetAnimationEasing(progressBar);

            if (progressBar.IsLoaded)
            {
                AnimationUtil.BeginDoubleAnimation(progressBar, ValueProperty, null, newValue, animationDuration, null, animationEase);
            }
            else
            {
                SetValue(progressBar, newValue);
            }
        }
        #endregion
    }
}
