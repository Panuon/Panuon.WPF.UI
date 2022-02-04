using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class SliderHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ThumbStyle { get; } =
            new ComponentResourceKey(typeof(SliderHelper), nameof(ThumbStyle));
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

        #endregion
    }
}
