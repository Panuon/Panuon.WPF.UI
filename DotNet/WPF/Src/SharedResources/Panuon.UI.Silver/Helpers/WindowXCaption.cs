using Panuon.UI.Silver.Utils;
using System.Windows;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class WindowXCaption
    {
        #region Properties

        #region Height
        public static double GetHeight(WindowX windowX)
        {
            return (double)windowX.GetValue(HeightProperty);
        }

        public static void SetHeight(WindowX windowX, double value)
        {
            windowX.SetValue(HeightProperty, value);
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.RegisterAttached("Height", typeof(double), typeof(WindowXCaption), new PropertyMetadata(double.NaN, OnHeightChanged));
        #endregion

        #region Padding
        public static Thickness GetPadding(WindowX windowX)
        {
            return (Thickness)windowX.GetValue(PaddingProperty);
        }

        public static void SetPadding(WindowX windowX, Thickness value)
        {
            windowX.SetValue(PaddingProperty, value);
        }

        public static readonly DependencyProperty PaddingProperty =
            DependencyProperty.RegisterAttached("Padding", typeof(Thickness), typeof(WindowXCaption), new PropertyMetadata(new Thickness(0)));
        #endregion

        #region Foreground
        public static Brush GetForeground(WindowX windowX)
        {
            return (Brush)windowX.GetValue(ForegroundProperty);
        }

        public static void SetForeground(WindowX windowX, Brush value)
        {
            windowX.SetValue(ForegroundProperty, value);
        }

        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(WindowXCaption));
        #endregion

        #region Background
        public static Brush GetBackground(WindowX windowX)
        {
            return (Brush)windowX.GetValue(BackgroundProperty);
        }

        public static void SetBackground(WindowX windowX, Brush value)
        {
            windowX.SetValue(BackgroundProperty, value);
        }

        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(WindowXCaption));
        #endregion

        #region BorderBrush
        public static Brush GetBorderBrush(WindowX windowX)
        {
            return (Brush)windowX.GetValue(BorderBrushProperty);
        }

        public static void SetBorderBrush(WindowX windowX, Brush value)
        {
            windowX.SetValue(BorderBrushProperty, value);
        }

        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(WindowXCaption));
        #endregion

        #region BorderThickness
        public static Thickness GetBorderThickness(WindowX windowX)
        {
            return (Thickness)windowX.GetValue(BorderThicknessProperty);
        }

        public static void SetBorderThickness(WindowX windowX, Thickness value)
        {
            windowX.SetValue(BorderThicknessProperty, value);
        }

        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.RegisterAttached("BorderThickness", typeof(Thickness), typeof(WindowXCaption));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(WindowX windowX)
        {
            return (Color?)windowX.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(WindowX windowX, Color? value)
        {
            windowX.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.RegisterAttached("ShadowColor", typeof(Color?), typeof(WindowXCaption));
        #endregion

        #region HeaderTemplate
        public static DataTemplate GetHeaderTemplate(WindowX windowX)
        {
            return (DataTemplate)windowX.GetValue(HeaderTemplateProperty);
        }

        public static void SetHeaderTemplate(WindowX windowX, DataTemplate value)
        {
            windowX.SetValue(HeaderTemplateProperty, value);
        }

        public static readonly DependencyProperty HeaderTemplateProperty =
            DependencyProperty.RegisterAttached("HeaderTemplate", typeof(DataTemplate), typeof(WindowXCaption));
        #endregion

        #region HeaderAlignment
        public static WindowXHeaderAlignment GetHeaderAlignment(WindowX windowX)
        {
            return (WindowXHeaderAlignment)windowX.GetValue(HeaderAlignmentProperty);
        }

        public static void SetHeaderAlignment(WindowX windowX, WindowXHeaderAlignment value)
        {
            windowX.SetValue(HeaderAlignmentProperty, value);
        }

        public static readonly DependencyProperty HeaderAlignmentProperty =
            DependencyProperty.RegisterAttached("HeaderAlignment", typeof(WindowXHeaderAlignment), typeof(WindowXCaption));
        #endregion

        #region ExtendControl
        public static object GetExtendControl(WindowX windowX)
        {
            return (object)windowX.GetValue(ExtendControlProperty);
        }

        public static void SetExtendControl(WindowX windowX, object value)
        {
            windowX.SetValue(ExtendControlProperty, value);
        }

        public static readonly DependencyProperty ExtendControlProperty =
            DependencyProperty.RegisterAttached("ExtendControl", typeof(object), typeof(WindowXCaption));
        #endregion

        #region Buttons
        public static CaptionButtons GetButtons(WindowX windowX)
        {
            return (CaptionButtons)windowX.GetValue(ButtonsProperty);
        }

        public static void SetButtons(WindowX windowX, CaptionButtons value)
        {
            windowX.SetValue(ButtonsProperty, value);
        }

        public static readonly DependencyProperty ButtonsProperty =
            DependencyProperty.RegisterAttached("Buttons", typeof(CaptionButtons), typeof(WindowXCaption));
        #endregion

        #region MinimizeButtonStyle
        public static Style GetMinimizeButtonStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(MinimizeButtonStyleProperty);
        }

        public static void SetMinimizeButtonStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(MinimizeButtonStyleProperty, value);
        }

        public static readonly DependencyProperty MinimizeButtonStyleProperty =
            DependencyProperty.RegisterAttached("MinimizeButtonStyle", typeof(Style), typeof(WindowXCaption));
        #endregion

        #region MaximizeButtonStyle
        public static Style GetMaximizeButtonStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(MaximizeButtonStyleProperty);
        }

        public static void SetMaximizeButtonStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(MaximizeButtonStyleProperty, value);
        }

        public static readonly DependencyProperty MaximizeButtonStyleProperty =
            DependencyProperty.RegisterAttached("MaximizeButtonStyle", typeof(Style), typeof(WindowXCaption));
        #endregion

        #region CloseButtonStyle
        public static Style GetCloseButtonStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(CloseButtonStyleProperty);
        }

        public static void SetCloseButtonStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(CloseButtonStyleProperty, value);
        }

        public static readonly DependencyProperty CloseButtonStyleProperty =
            DependencyProperty.RegisterAttached("CloseButtonStyle", typeof(Style), typeof(WindowXCaption));
        #endregion

        #region BackstageMinimizeButtonStyle
        public static Style GetBackstageMinimizeButtonStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(BackstageMinimizeButtonStyleProperty);
        }

        public static void SetBackstageMinimizeButtonStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(BackstageMinimizeButtonStyleProperty, value);
        }

        public static readonly DependencyProperty BackstageMinimizeButtonStyleProperty =
            DependencyProperty.RegisterAttached("BackstageMinimizeButtonStyle", typeof(Style), typeof(WindowXCaption));
        #endregion

        #region BackstageMaximizeButtonStyle
        public static Style GetBackstageMaximizeButtonStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(BackstageMaximizeButtonStyleProperty);
        }

        public static void SetBackstageMaximizeButtonStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(BackstageMaximizeButtonStyleProperty, value);
        }

        public static readonly DependencyProperty BackstageMaximizeButtonStyleProperty =
            DependencyProperty.RegisterAttached("BackstageMaximizeButtonStyle", typeof(Style), typeof(WindowXCaption));
        #endregion

        #region BackstageCloseButtonStyle
        public static Style GetBackstageCloseButtonStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(BackstageCloseButtonStyleProperty);
        }

        public static void SetBackstageCloseButtonStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(BackstageCloseButtonStyleProperty, value);
        }

        public static readonly DependencyProperty BackstageCloseButtonStyleProperty =
            DependencyProperty.RegisterAttached("BackstageCloseButtonStyle", typeof(Style), typeof(WindowXCaption));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var windowX = d as WindowX;
            if (windowX == null)
            {
                return;
            }
            WindowChromeUtil.SetCaptionHeight(windowX, windowX.IsMaskVisible ? 0 : (windowX.DisableDragMove ? 0 : WindowXCaption.GetHeight(windowX)));
        }
        #endregion
    }
}
