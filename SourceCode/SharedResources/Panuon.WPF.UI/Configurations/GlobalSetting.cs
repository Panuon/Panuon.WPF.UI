using Panuon.WPF.UI.Internal.Resources;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Panuon.WPF.UI.Configurations
{
    public class GlobalSetting 
        : DependencyObject
    {
        #region Ctor
        public GlobalSetting()
        {
            SetValue(ThemesProperty, new Collection<ApplicationTheme>());

            var rectangle = new FrameworkElementFactory(typeof(Rectangle));
            rectangle.SetValue(Rectangle.StrokeDashArrayProperty, new DoubleCollection(new double[] { 1.5, 1.5 }));
            rectangle.SetValue(Rectangle.StrokeThicknessProperty, 1d);
            rectangle.SetValue(Rectangle.StrokeProperty, Brushes.DimGray);
            var visualStyle = new Style();
            visualStyle.Setters.Add(new Setter()
            {
                Property = Control.TemplateProperty,
                Value = new ControlTemplate()
                {
                    VisualTree = rectangle
                }
            });
            visualStyle.Seal();
            SetValue(FocusVisualStyleProperty, visualStyle);
        }
        #endregion

        #region Properties

        #region DisabledOpacity
        public double DisabledOpacity
        {
            get { return (double)GetValue(DisabledOpacityProperty); }
            set { SetValue(DisabledOpacityProperty, value); }
        }

        public static readonly DependencyProperty DisabledOpacityProperty =
            DependencyProperty.Register("DisabledOpacity", typeof(double), typeof(GlobalSetting), new PropertyMetadata(0.4));
        #endregion

        #region FontFamily
        public FontFamily FontFamily
        {
            get { return (FontFamily)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public static readonly DependencyProperty FontFamilyProperty =
            DependencyProperty.Register("FontFamily", typeof(FontFamily), typeof(GlobalSetting), new PropertyMetadata(SystemFonts.MessageFontFamily));
        #endregion

        #region FontSize
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(GlobalSetting), new PropertyMetadata(SystemFonts.MessageFontSize));
        #endregion

        #region IconFontFamily
        public FontFamily IconFontFamily
        {
            get { return (FontFamily)GetValue(IconFontFamilyProperty); }
            set { SetValue(IconFontFamilyProperty, value); }
        }

        public static readonly DependencyProperty IconFontFamilyProperty =
            DependencyProperty.Register("IconFontFamily", typeof(FontFamily), typeof(GlobalSetting), new PropertyMetadata(SystemFonts.MessageFontFamily));
        #endregion

        #region IconFontSize
        public double IconFontSize
        {
            get { return (double)GetValue(IconFontSizeProperty); }
            set { SetValue(IconFontSizeProperty, value); }
        }

        public static readonly DependencyProperty IconFontSizeProperty =
            DependencyProperty.Register("IconFontSize", typeof(double), typeof(GlobalSetting), new PropertyMetadata(SystemFonts.MessageFontSize + 2));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(GlobalSetting), new PropertyMetadata(TimeSpan.FromSeconds(0.3)));
        #endregion

        #region FocusVisualStyle
        public Style FocusVisualStyle
        {
            get { return (Style)GetValue(FocusVisualStyleProperty); }
            set { SetValue(FocusVisualStyleProperty, value); }
        }

        public static readonly DependencyProperty FocusVisualStyleProperty =
            DependencyProperty.Register("FocusVisualStyle", typeof(Style), typeof(GlobalSetting));
        #endregion

        #region Themes
        public Collection<ApplicationTheme> Themes
        {
            get { return (Collection<ApplicationTheme>)GetValue(ThemesProperty); }
            set { SetValue(ThemesProperty, value); }
        }

        public static readonly DependencyProperty ThemesProperty =
            DependencyProperty.Register("Themes", typeof(Collection<ApplicationTheme>), typeof(GlobalSetting));
        #endregion

        #endregion

    }
}
