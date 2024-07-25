using Panuon.WPF.UI.Internal;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class SliderHelper
    {
        #region Events

        #region GeneratingValueText
        public static void AddGeneratingValueTextHandler(UIElement element, GeneratingValueTextRoutedEventHandler eventHandler)
        {
            element.AddHandler(GeneratingValueTextEvent, eventHandler);
        }

        public static void RemoveGeneratingValueTextHandler(UIElement element, GeneratingValueTextRoutedEventHandler eventHandler)
        {
            element.RemoveHandler(GeneratingValueTextEvent, eventHandler);
        }

        public static readonly RoutedEvent GeneratingValueTextEvent
            = EventManager.RegisterRoutedEvent("GeneratingValueText", RoutingStrategy.Bubble, typeof(GeneratingValueTextRoutedEventHandler), typeof(SliderHelper));
        #endregion

        #endregion
        
        #region ComponentResourceKeys
        public static ComponentResourceKey ThumbStyleKey { get; } =
            new ComponentResourceKey(typeof(SliderHelper), nameof(ThumbStyleKey));
        #endregion

        #region Properties

        #region TickBarThickness
        public static double GetTickBarThickness(Slider slider)
        {
            return (double)slider.GetValue(TickBarThicknessProperty);
        }

        public static void SetTickBarThickness(Slider slider, double value)
        {
            slider.SetValue(TickBarThicknessProperty, value);
        }

        public static readonly DependencyProperty TickBarThicknessProperty =
            DependencyProperty.RegisterAttached("TickBarThickness", typeof(double), typeof(SliderHelper), new PropertyMetadata(4d));
        #endregion

        #region TickBarForeground
        public static Brush GetTickBarForeground(Slider slider)
        {
            return (Brush)slider.GetValue(TickBarForegroundProperty);
        }

        public static void SetTickBarForeground(Slider slider, Brush value)
        {
            slider.SetValue(TickBarForegroundProperty, value);
        }

        public static readonly DependencyProperty TickBarForegroundProperty =
            DependencyProperty.RegisterAttached("TickBarForeground", typeof(Brush), typeof(SliderHelper));
        #endregion

        #region TrackThickness
        public static double GetTrackThickness(Slider slider)
        {
            return (double)slider.GetValue(TrackThicknessProperty);
        }

        public static void SetTrackThickness(Slider slider, double value)
        {
            slider.SetValue(TrackThicknessProperty, value);
        }

        public static readonly DependencyProperty TrackThicknessProperty =
            DependencyProperty.RegisterAttached("TrackThickness", typeof(double), typeof(SliderHelper), new PropertyMetadata(4d));
        #endregion

        #region TrackCornerRadius
        public static double GetTrackCornerRadius(Slider slider)
        {
            return (double)slider.GetValue(TrackCornerRadiusProperty);
        }

        public static void SetTrackCornerRadius(Slider slider, double value)
        {
            slider.SetValue(TrackCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty TrackCornerRadiusProperty =
            DependencyProperty.RegisterAttached("TrackCornerRadius", typeof(double), typeof(SliderHelper), new PropertyMetadata(0d));
        #endregion

        #region CoveredBackground
        public static Brush GetCoveredBackground(Slider slider)
        {
            return (Brush)slider.GetValue(CoveredBackgroundProperty);
        }

        public static void SetCoveredBackground(Slider slider, Brush value)
        {
            slider.SetValue(CoveredBackgroundProperty, value);
        }

        public static readonly DependencyProperty CoveredBackgroundProperty =
            DependencyProperty.RegisterAttached("CoveredBackground", typeof(Brush), typeof(SliderHelper));
        #endregion

        #region ThumbWidth
        public static double GetThumbWidth(Slider slider)
        {
            return (double)slider.GetValue(ThumbWidthProperty);
        }

        public static void SetThumbWidth(Slider slider, double value)
        {
            slider.SetValue(ThumbWidthProperty, value);
        }

        public static readonly DependencyProperty ThumbWidthProperty =
            DependencyProperty.RegisterAttached("ThumbWidth", typeof(double), typeof(SliderHelper), new PropertyMetadata(20d));
        #endregion

        #region ThumbHeight
        public static double GetThumbHeight(Slider slider)
        {
            return (double)slider.GetValue(ThumbHeightProperty);
        }

        public static void SetThumbHeight(Slider slider, double value)
        {
            slider.SetValue(ThumbHeightProperty, value);
        }

        public static readonly DependencyProperty ThumbHeightProperty =
            DependencyProperty.RegisterAttached("ThumbHeight", typeof(double), typeof(SliderHelper), new PropertyMetadata(20d));
        #endregion

        #region ThumbShadowColor
        public static Color? GetThumbShadowColor(Slider slider)
        {
            return (Color?)slider.GetValue(ThumbShadowColorProperty);
        }

        public static void SetThumbShadowColor(Slider slider, Color? value)
        {
            slider.SetValue(ThumbShadowColorProperty, value);
        }

        public static readonly DependencyProperty ThumbShadowColorProperty =
            DependencyProperty.RegisterAttached("ThumbShadowColor", typeof(Color?), typeof(SliderHelper));
        #endregion

        #region ThumbCornerRadius
        public static CornerRadius GetThumbCornerRadius(Slider slider)
        {
            return (CornerRadius)slider.GetValue(ThumbCornerRadiusProperty);
        }

        public static void SetThumbCornerRadius(Slider slider, CornerRadius value)
        {
            slider.SetValue(ThumbCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ThumbCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ThumbCornerRadius", typeof(CornerRadius), typeof(SliderHelper));
        #endregion

        #region ThumbBackground
        public static Brush GetThumbBackground(Slider slider)
        {
            return (Brush)slider.GetValue(ThumbBackgroundProperty);
        }

        public static void SetThumbBackground(Slider slider, Brush value)
        {
            slider.SetValue(ThumbBackgroundProperty, value);
        }

        public static readonly DependencyProperty ThumbBackgroundProperty =
            DependencyProperty.RegisterAttached("ThumbBackground", typeof(Brush), typeof(SliderHelper));
        #endregion

        #region ThumbBorderBrush
        public static Brush GetThumbBorderBrush(Slider slider)
        {
            return (Brush)slider.GetValue(ThumbBorderBrushProperty);
        }

        public static void SetThumbBorderBrush(Slider slider, Brush value)
        {
            slider.SetValue(ThumbBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ThumbBorderBrushProperty =
            DependencyProperty.RegisterAttached("ThumbBorderBrush", typeof(Brush), typeof(SliderHelper));
        #endregion

        #region ThumbBorderThickness
        public static Thickness GetThumbBorderThickness(Slider slider)
        {
            return (Thickness)slider.GetValue(ThumbBorderThicknessProperty);
        }

        public static void SetThumbBorderThickness(Slider slider, Thickness value)
        {
            slider.SetValue(ThumbBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ThumbBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ThumbBorderThickness", typeof(Thickness), typeof(SliderHelper));
        #endregion

        #region ThumbStyle
        public static Style GetThumbStyle(Slider slider)
        {
            return (Style)slider.GetValue(ThumbStyleProperty);
        }

        public static void SetThumbStyle(Slider slider, Style value)
        {
            slider.SetValue(ThumbStyleProperty, value);
        }

        public static readonly DependencyProperty ThumbStyleProperty =
            DependencyProperty.RegisterAttached("ThumbStyle", typeof(Style), typeof(SliderHelper));
        #endregion

        #region IsTextVisible
        public static bool GetIsTextVisible(Slider slider)
        {
            return (bool)slider.GetValue(IsTextVisibleProperty);
        }

        public static void SetIsTextVisible(Slider slider, bool value)
        {
            slider.SetValue(IsTextVisibleProperty, value);
        }

        public static readonly DependencyProperty IsTextVisibleProperty =
            DependencyProperty.RegisterAttached("IsTextVisible", typeof(bool), typeof(SliderHelper));
        #endregion

        #region TextStringFormat
        public static string GetTextStringFormat(Slider slider)
        {
            return (string)slider.GetValue(TextStringFormatProperty);
        }

        public static void SetTextStringFormat(Slider slider, string value)
        {
            slider.SetValue(TextStringFormatProperty, value);
        }

        public static readonly DependencyProperty TextStringFormatProperty =
            DependencyProperty.RegisterAttached("TextStringFormat", typeof(string), typeof(SliderHelper), new PropertyMetadata("N2", OnTextStringFormatChanged));

        #endregion

        #region TextSpacing
        public static double GetTextSpacing(Slider slider)
        {
            return (double)slider.GetValue(TextSpacingProperty);
        }

        public static void SetTextSpacing(Slider slider, double value)
        {
            slider.SetValue(TextSpacingProperty, value);
        }

        public static readonly DependencyProperty TextSpacingProperty =
            DependencyProperty.RegisterAttached("TextSpacing", typeof(double), typeof(SliderHelper));
        #endregion

        #endregion

        #region Internal Properties

        #region ShadowColor
        internal static Color? GetShadowColor(Thumb thumb)
        {
            return (Color?)thumb.GetValue(ShadowColorProperty);
        }

        internal static void SetShadowColor(Thumb thumb, Color? value)
        {
            thumb.SetValue(ShadowColorProperty, value);
        }

        internal static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(SliderHelper));
        #endregion

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
            DependencyProperty.RegisterAttached("Hook", typeof(bool), typeof(SliderHelper), new PropertyMetadata(OnHookChanged));
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
            DependencyProperty.RegisterAttached("Text", typeof(string), typeof(SliderHelper));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var slider = (Slider)d;
            slider.ValueChanged -= Slider_ValueChanged;
            slider.ValueChanged += Slider_ValueChanged;
            Slider_ValueChanged(slider, new RoutedPropertyChangedEventArgs<double>(slider.Minimum, slider.Value));
        }
        
        private static void OnTextStringFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var slider = (Slider)d;
            UpdateText(slider);
        }

        private static void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            UpdateText(slider);
        }

        private static void UpdateText(Slider slider)
        {
            var stringFormat = GetTextStringFormat(slider);
            var value = slider.Value;
            var text = string.IsNullOrEmpty(stringFormat) ? value.ToString() : value.ToString(stringFormat);
            var args = new GeneratingValueTextRoutedEventArgs(GeneratingValueTextEvent, value, text);
            slider.RaiseEvent(args);
            SetText(slider, args.Text);
        }

        #endregion
    }
}
