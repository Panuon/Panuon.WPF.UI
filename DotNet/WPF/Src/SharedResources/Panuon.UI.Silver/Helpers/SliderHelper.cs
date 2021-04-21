using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class SliderHelper
    {
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
            DependencyProperty.RegisterAttached("TrackThickness", typeof(double), typeof(SliderHelper));
        #endregion

        #region ToggleWidth
        public static double GetToggleWidth(Slider slider)
        {
            return (double)slider.GetValue(ToggleWidthProperty);
        }

        public static void SetToggleWidth(Slider slider, double value)
        {
            slider.SetValue(ToggleWidthProperty, value);
        }

        public static readonly DependencyProperty ToggleWidthProperty =
            DependencyProperty.RegisterAttached("ToggleWidth", typeof(double), typeof(SliderHelper));
        #endregion

        #region ToggleHeight
        public static double GetToggleHeight(Slider slider)
        {
            return (double)slider.GetValue(ToggleHeightProperty);
        }

        public static void SetToggleHeight(Slider slider, double value)
        {
            slider.SetValue(ToggleHeightProperty, value);
        }

        public static readonly DependencyProperty ToggleHeightProperty =
            DependencyProperty.RegisterAttached("ToggleHeight", typeof(double), typeof(SliderHelper));
        #endregion

        #region ToggleCornerRadius
        public static CornerRadius GetToggleCornerRadius(Slider slider)
        {
            return (CornerRadius)slider.GetValue(ToggleCornerRadiusProperty);
        }

        public static void SetToggleCornerRadius(Slider slider, CornerRadius value)
        {
            slider.SetValue(ToggleCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ToggleCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ToggleCornerRadius", typeof(CornerRadius), typeof(SliderHelper));
        #endregion

        #region ToggleBackground
        public static Brush GetToggleBackground(Slider slider)
        {
            return (Brush)slider.GetValue(ToggleBackgroundProperty);
        }

        public static void SetToggleBackground(Slider slider, Brush value)
        {
            slider.SetValue(ToggleBackgroundProperty, value);
        }

        public static readonly DependencyProperty ToggleBackgroundProperty =
            DependencyProperty.RegisterAttached("ToggleBackground", typeof(Brush), typeof(SliderHelper));
        #endregion

        #region ToggleBorderBrush
        public static Brush GetToggleBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ToggleBorderBrushProperty);
        }

        public static void SetToggleBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ToggleBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ToggleBorderBrushProperty =
            DependencyProperty.RegisterAttached("ToggleBorderBrush", typeof(Brush), typeof(SliderHelper));
        #endregion

        #region ToggleBorderThickness
        public static double GetToggleBorderThickness(DependencyObject obj)
        {
            return (double)obj.GetValue(ToggleBorderThicknessProperty);
        }

        public static void SetToggleBorderThickness(DependencyObject obj, double value)
        {
            obj.SetValue(ToggleBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ToggleBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ToggleBorderThickness", typeof(double), typeof(SliderHelper));
        #endregion

        #region ToggleContent
        public static object GetToggleContent(Slider slider)
        {
            return (object)slider.GetValue(ToggleContentProperty);
        }

        public static void SetToggleContent(Slider slider, object value)
        {
            slider.SetValue(ToggleContentProperty, value);
        }

        public static readonly DependencyProperty ToggleContentProperty =
            DependencyProperty.RegisterAttached("ToggleContent", typeof(object), typeof(SliderHelper));
        #endregion

        #region ToggleShadowColor
        public static Color? GetToggleShadowColor(Slider slider)
        {
            return (Color?)slider.GetValue(ToggleShadowColorProperty);
        }

        public static void SetToggleShadowColor(Slider slider, Color? value)
        {
            slider.SetValue(ToggleShadowColorProperty, value);
        }

        public static readonly DependencyProperty ToggleShadowColorProperty =
            DependencyProperty.RegisterAttached("ToggleShadowColor", typeof(Color?), typeof(SliderHelper));
        #endregion
    }
}
