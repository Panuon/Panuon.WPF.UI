using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public static class ThumbHelper
    {
        #region Properties

        #region Content
        public static object GetContent(Thumb thunb)
        {
            return (object)thunb.GetValue(ContentProperty);
        }

        public static void SetContent(Thumb thunb, object value)
        {
            thunb.SetValue(ContentProperty, value);
        }

        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.RegisterAttached("Content", typeof(object), typeof(ThumbHelper));
        #endregion

        #region ContentTemplate
        public static DataTemplate GetContentTemplate(Thumb thunb)
        {
            return (DataTemplate)thunb.GetValue(ContentTemplateProperty);
        }

        public static void SetContentTemplate(Thumb thunb, DataTemplate value)
        {
            thunb.SetValue(ContentTemplateProperty, value);
        }

        public static readonly DependencyProperty ContentTemplateProperty =
            DependencyProperty.RegisterAttached("ContentTemplate", typeof(DataTemplate), typeof(ThumbHelper));
        #endregion

        #region ContentTemplateSelector
        public static DataTemplateSelector GetContentTemplateSelector(Thumb thunb)
        {
            return (DataTemplateSelector)thunb.GetValue(ContentTemplateSelectorProperty);
        }

        public static void SetContentTemplateSelector(Thumb thunb, DataTemplateSelector value)
        {
            thunb.SetValue(ContentTemplateSelectorProperty, value);
        }

        public static readonly DependencyProperty ContentTemplateSelectorProperty =
            DependencyProperty.RegisterAttached("ContentTemplateSelector", typeof(DataTemplateSelector), typeof(ThumbHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(Thumb thumb)
        {
            return (CornerRadius)thumb.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(Thumb thumb, CornerRadius value)
        {
            thumb.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ThumbHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(Thumb thumb)
        {
            return (Color?)thumb.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(Thumb thumb, Color? value)
        {
            thumb.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(ThumbHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(Thumb thumb)
        {
            return (Brush)thumb.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(Thumb thumb, Brush value)
        {
            thumb.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ThumbHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(Thumb thumb)
        {
            return (Brush)thumb.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(Thumb thumb, Brush value)
        {
            thumb.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ThumbHelper));
        #endregion

        #region HoverBorderBrush
        public static Brush GetHoverBorderBrush(Thumb thumb)
        {
            return (Brush)thumb.GetValue(HoverBorderBrushProperty);
        }

        public static void SetHoverBorderBrush(Thumb thumb, Brush value)
        {
            thumb.SetValue(HoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ThumbHelper));
        #endregion

        #region HoverShadowColor
        public static Color? GetHoverShadowColor(Thumb thumb)
        {
            return (Color?)thumb.GetValue(HoverShadowColorProperty);
        }

        public static void SetHoverShadowColor(Thumb thumb, Color? value)
        {
            thumb.SetValue(HoverShadowColorProperty, value);
        }
        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(ThumbHelper));
        #endregion

        #endregion
    }
}
