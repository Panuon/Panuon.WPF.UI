using Panuon.WPF.UI.Internal.Converters;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;

namespace Panuon.WPF.UI.Internal
{
    static class VisualStateHelper
    {
        #region Properties

        #region Regist
        public static bool GetRegist(DependencyObject obj)
        {
            return (bool)obj.GetValue(RegistProperty);
        }

        public static void SetRegist(DependencyObject obj, bool value)
        {
            obj.SetValue(RegistProperty, value);
        }

        public static readonly DependencyProperty RegistProperty =
            DependencyProperty.RegisterAttached("Regist", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnRegistChanged));
        #endregion 

        #region Background
        public static Brush GetBackground(Control control)
        {
            return (Brush)control.GetValue(BackgroundProperty);
        }

        public static void SetBackground(Control obj, Brush value)
        {
            obj.SetValue(BackgroundProperty, value);
        }

        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region Foreground
        public static Brush GetForeground(Control control)
        {
            return (Brush)control.GetValue(ForegroundProperty);
        }

        public static void SetForeground(Control control, Brush value)
        {
            control.SetValue(ForegroundProperty, value);
        }

        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region BorderBrush
        public static Brush GetBorderBrush(Control control)
        {
            return (Brush)control.GetValue(BorderBrushProperty);
        }

        public static void SetBorderBrush(Control control, Brush value)
        {
            control.SetValue(BorderBrushProperty, value);
        }

        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region BorderThickness
        public static Thickness GetBorderThickness(Control control)
        {
            return (Thickness)control.GetValue(BorderThicknessProperty);
        }

        public static void SetBorderThickness(Control control, Thickness value)
        {
            control.SetValue(BorderThicknessProperty, value);
        }

        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.RegisterAttached("BorderThickness", typeof(Thickness), typeof(VisualStateHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(Control control)
        {
            return (CornerRadius)control.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(Control control, CornerRadius value)
        {
            control.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(VisualStateHelper), new FrameworkPropertyMetadata(new CornerRadius(), FrameworkPropertyMetadataOptions.Inherits));
        #endregion

        #region WatermarkForeground
        public static Brush GetWatermarkForeground(Control control)
        {
            return (Brush)control.GetValue(WatermarkForegroundProperty);
        }

        public static void SetWatermarkForeground(Control control, Brush value)
        {
            control.SetValue(WatermarkForegroundProperty, value);
        }

        public static readonly DependencyProperty WatermarkForegroundProperty =
            DependencyProperty.RegisterAttached("WatermarkForeground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region GlyphBrush
        public static Brush GetGlyphBrush(Control control)
        {
            return (Brush)control.GetValue(GlyphBrushProperty);
        }

        public static void SetGlyphBrush(Control control, Brush value)
        {
            control.SetValue(GlyphBrushProperty, value);
        }

        public static readonly DependencyProperty GlyphBrushProperty =
            DependencyProperty.RegisterAttached("GlyphBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region ToggleSize
        public static double GetToggleSize(DependencyObject obj)
        {
            return (double)obj.GetValue(ToggleSizeProperty);
        }

        public static void SetToggleSize(DependencyObject obj, double value)
        {
            obj.SetValue(ToggleSizeProperty, value);
        }

        public static readonly DependencyProperty ToggleSizeProperty =
            DependencyProperty.RegisterAttached("ToggleSize", typeof(double), typeof(VisualStateHelper));
        #endregion

        #region ToggleCornerRadius
        public static CornerRadius GetToggleCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(ToggleCornerRadiusProperty);
        }

        public static void SetToggleCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(ToggleCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ToggleCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ToggleCornerRadius", typeof(CornerRadius), typeof(VisualStateHelper));
        #endregion

        #region ToggleBrush
        public static Brush GetToggleBrush(Control control)
        {
            return (Brush)control.GetValue(ToggleBrushProperty);
        }

        public static void SetToggleBrush(Control control, Brush value)
        {
            control.SetValue(ToggleBrushProperty, value);
        }

        public static readonly DependencyProperty ToggleBrushProperty =
            DependencyProperty.RegisterAttached("ToggleBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region RibbonLineBrush
        public static Brush GetRibbonLineBrush(Control control)
        {
            return (Brush)control.GetValue(RibbonLineBrushProperty);
        }

        public static void SetRibbonLineBrush(Control control, Brush value)
        {
            control.SetValue(RibbonLineBrushProperty, value);
        }

        public static readonly DependencyProperty RibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("RibbonLineBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region Effect
        public static DropShadowEffect GetEffect(DependencyObject obj)
        {
            return (DropShadowEffect)obj.GetValue(EffectProperty);
        }

        public static void SetEffect(DependencyObject obj, DropShadowEffect value)
        {
            obj.SetValue(EffectProperty, value);
        }

        public static readonly DependencyProperty EffectProperty =
            DependencyProperty.RegisterAttached("Effect", typeof(DropShadowEffect), typeof(VisualStateHelper));
        #endregion

        #region ToggleEffect
        public static DropShadowEffect GetToggleEffect(DependencyObject obj)
        {
            return (DropShadowEffect)obj.GetValue(ToggleEffectProperty);
        }

        public static void SetToggleEffect(DependencyObject obj, DropShadowEffect value)
        {
            obj.SetValue(ToggleEffectProperty, value);
        }

        public static readonly DependencyProperty ToggleEffectProperty =
            DependencyProperty.RegisterAttached("ToggleEffect", typeof(DropShadowEffect), typeof(VisualStateHelper));
        #endregion

        #region Percent
        public static double GetPercent(DependencyObject obj)
        {
            return (double)obj.GetValue(PercentProperty);
        }

        public static void SetPercent(DependencyObject obj, double value)
        {
            obj.SetValue(PercentProperty, value);
        }

        public static readonly DependencyProperty PercentProperty =
            DependencyProperty.RegisterAttached("Percent", typeof(double), typeof(VisualStateHelper));
        #endregion

        #region ClickEffect
        public static ClickEffect GetClickEffect(DependencyObject obj)
        {
            return (ClickEffect)obj.GetValue(ClickEffectProperty);
        }

        public static void SetEffect(DependencyObject obj, ClickEffect value)
        {
            obj.SetValue(ClickEffectProperty, value);
        }

        public static readonly DependencyProperty ClickEffectProperty =
            DependencyProperty.RegisterAttached("ClickEffect", typeof(ClickEffect), typeof(VisualStateHelper));
        #endregion

        #region IsClickEffectPressed
        public static bool GetIsClickEffectPressed(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsClickEffectPressedProperty);
        }

        public static void SetIsClickEffectPressed(DependencyObject obj, bool value)
        {
            obj.SetValue(IsClickEffectPressedProperty, value);
        }

        public static readonly DependencyProperty IsClickEffectPressedProperty =
            DependencyProperty.RegisterAttached("IsClickEffectPressed", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsClickEffectPressedChanged));

        #endregion

        #endregion

        #region 
        internal static Thickness GetMargin(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(MarginProperty);
        }

        internal static void SetMargin(DependencyObject obj, Thickness value)
        {
            obj.SetValue(MarginProperty, value);
        }

        internal static readonly DependencyProperty MarginProperty =
            DependencyProperty.RegisterAttached("Margin", typeof(Thickness), typeof(VisualStateHelper));
        #endregion

        #region ShadowColor Properties

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.RegisterAttached("ShadowColor", typeof(Color?), typeof(VisualStateHelper));

        public static readonly DependencyProperty ToggleShadowColorProperty =
            DependencyProperty.RegisterAttached("ToggleShadowColor", typeof(Color?), typeof(VisualStateHelper));

        #endregion

        #region Hover Properties

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            DependencyProperty.RegisterAttached("HoverCornerRadius", typeof(CornerRadius?), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("HoverBorderBrush", typeof(Brush), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("HoverBorderThickness", typeof(Thickness?), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverBackgroundProperty =
            DependencyProperty.RegisterAttached("HoverBackground", typeof(Brush), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverForegroundProperty =
            DependencyProperty.RegisterAttached("HoverForeground", typeof(Brush), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverGlyphBrushProperty =
            DependencyProperty.RegisterAttached("HoverGlyphBrush", typeof(Brush), typeof(VisualStateHelper));
        
        public static readonly DependencyProperty HoverToggleBrushProperty =
            DependencyProperty.RegisterAttached("HoverToggleBrush", typeof(Brush), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverRibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("HoverRibbonLineBrush", typeof(Brush), typeof(VisualStateHelper));

        #region HoverBorderBrushLock
        public static bool GetHoverBorderBrushLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverBorderBrushLockProperty);
        }

        public static void SetHoverBorderBrushLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverBorderBrushLockProperty, value);
        }

        public static readonly DependencyProperty HoverBorderBrushLockProperty =
            DependencyProperty.RegisterAttached("HoverBorderBrushLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region HoverBorderThicknessLock
        public static bool GetHoverBorderThicknessLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverBorderThicknessLockProperty);
        }

        public static void SetHoverBorderThicknessLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverBorderThicknessLockProperty, value);
        }

        public static readonly DependencyProperty HoverBorderThicknessLockProperty =
            DependencyProperty.RegisterAttached("HoverBorderThicknessLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region HoverCornerRadiusLock
        public static bool GetHoverCornerRadiusLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverCornerRadiusLockProperty);
        }

        public static void SetHoverCornerRadiusLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverCornerRadiusLockProperty, value);
        }

        public static readonly DependencyProperty HoverCornerRadiusLockProperty =
            DependencyProperty.RegisterAttached("HoverCornerRadiusLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region HoverBackgroundLock
        public static bool GetHoverBackgroundLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverBackgroundLockProperty);
        }

        public static void SetHoverBackgroundLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverBackgroundLockProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundLockProperty =
            DependencyProperty.RegisterAttached("HoverBackgroundLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region HoverForegroundLock
        public static bool GetHoverForegroundLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverForegroundLockProperty);
        }

        public static void SetHoverForegroundLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverForegroundLockProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundLockProperty =
            DependencyProperty.RegisterAttached("HoverForegroundLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region HoverShadowColorLock
        public static bool GetHoverShadowColorLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverShadowColorLockProperty);
        }

        public static void SetHoverShadowColorLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverShadowColorLockProperty, value);
        }

        public static readonly DependencyProperty HoverShadowColorLockProperty =
            DependencyProperty.RegisterAttached("HoverShadowColorLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region HoverToggleShadowColorLock
        public static bool GetHoverToggleShadowColorLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverToggleShadowColorLockProperty);
        }

        public static void SetHoverToggleShadowColorLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverToggleShadowColorLockProperty, value);
        }

        public static readonly DependencyProperty HoverToggleShadowColorLockProperty =
            DependencyProperty.RegisterAttached("HoverToggleShadowColorLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region FocusedShadowColorLock
        public static bool GetFocusedShadowColorLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(FocusedShadowColorLockProperty);
        }

        public static void SetFocusedShadowColorLock(DependencyObject obj, bool value)
        {
            obj.SetValue(FocusedShadowColorLockProperty, value);
        }

        public static readonly DependencyProperty FocusedShadowColorLockProperty =
            DependencyProperty.RegisterAttached("FocusedShadowColorLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnFocusedLockChanged));
        #endregion

        #region IsHover
        public static bool GetIsHover(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsHoverProperty);
        }

        public static void SetIsHover(DependencyObject obj, bool value)
        {
            obj.SetValue(IsHoverProperty, value);
        }

        public static readonly DependencyProperty IsHoverProperty =
            DependencyProperty.RegisterAttached("IsHover", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsHoverChanged));
        #endregion

        public static readonly DependencyProperty HoverShadowColorProperty =
            DependencyProperty.RegisterAttached("HoverShadowColor", typeof(Color?), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverToggleSizeProperty =
            DependencyProperty.RegisterAttached("HoverToggleSize", typeof(double?), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverToggleCornerRadiusProperty =
            DependencyProperty.RegisterAttached("HoverToggleCornerRadius", typeof(CornerRadius?), typeof(VisualStateHelper));

        public static readonly DependencyProperty HoverToggleShadowColorProperty =
            DependencyProperty.RegisterAttached("HoverToggleShadowColor", typeof(Color?), typeof(VisualStateHelper));

        public static readonly DependencyProperty CheckedToggleShadowColorProperty =
            DependencyProperty.RegisterAttached("CheckedToggleShadowColor", typeof(Color?), typeof(VisualStateHelper));
        #endregion

        #region Focused Properties

        #region FocusedCornerRadius
        public static readonly DependencyProperty FocusedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("FocusedCornerRadius", typeof(CornerRadius?), typeof(VisualStateHelper));
        #endregion

        #region FocusedBorderBrush
        public static readonly DependencyProperty FocusedBorderBrushProperty =
            DependencyProperty.RegisterAttached("FocusedBorderBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region FocusedBorderThickness
        public static readonly DependencyProperty FocusedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("FocusedBorderThickness", typeof(Thickness?), typeof(VisualStateHelper));
        #endregion

        #region FocusedBackground
        public static readonly DependencyProperty FocusedBackgroundProperty =
            DependencyProperty.RegisterAttached("FocusedBackground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region FocusedForeground
        public static readonly DependencyProperty FocusedForegroundProperty =
            DependencyProperty.RegisterAttached("FocusedForeground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region FocusedShadowColor
        public static readonly DependencyProperty FocusedShadowColorProperty =
            DependencyProperty.RegisterAttached("FocusedShadowColor", typeof(Color?), typeof(VisualStateHelper));
        #endregion

        #region FocusedWatermarkForeground
        public static readonly DependencyProperty FocusedWatermarkForegroundProperty =
            DependencyProperty.RegisterAttached("FocusedWatermarkForeground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region IsFocused
        public static bool GetIsFocused(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsFocusedProperty);
        }

        public static void SetIsFocused(DependencyObject obj, bool value)
        {
            obj.SetValue(IsFocusedProperty, value);
        }

        public static readonly DependencyProperty IsFocusedProperty =
            DependencyProperty.RegisterAttached("IsFocused", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsFocusedChanged));
        #endregion

        #endregion

        #region Opened Properties

        #region OpenedShadowColor
        public static readonly DependencyProperty OpenedShadowColorProperty =
            DependencyProperty.RegisterAttached("OpenedShadowColor", typeof(Color?), typeof(VisualStateHelper));
        #endregion

        #region IsOpened
        public static bool GetIsOpened(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsOpenedProperty);
        }

        public static void SetIsOpened(DependencyObject obj, bool value)
        {
            obj.SetValue(IsOpenedProperty, value);
        }

        public static readonly DependencyProperty IsOpenedProperty =
            DependencyProperty.RegisterAttached("IsOpened", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsOpenedChanged));
        #endregion

        #endregion

        #region Selected Properties

        #region SelectedShadowColor
        public static readonly DependencyProperty SelectedShadowColorProperty =
            DependencyProperty.RegisterAttached("SelectedShadowColor", typeof(Color?), typeof(VisualStateHelper), new PropertyMetadata(OnSelectedShadowColorChanged));
        #endregion

        #region IsSelected
        public static bool GetIsSelected(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsSelectedProperty);
        }

        public static void SetIsSelected(DependencyObject obj, bool value)
        {
            obj.SetValue(IsSelectedProperty, value);
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.RegisterAttached("IsSelected", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsSelectedChanged));
        #endregion

        #endregion

        #region Expanded Properties

        #region ExpandedShadowColor
        public static readonly DependencyProperty ExpandedShadowColorProperty =
            DependencyProperty.RegisterAttached("ExpandedShadowColor", typeof(Color?), typeof(VisualStateHelper), new PropertyMetadata(OnExpandedShadowColorChanged));
        #endregion

        #region IsExpanded
        public static bool GetIsExpanded(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsExpandedProperty);
        }

        public static void SetIsExpanded(DependencyObject obj, bool value)
        {
            obj.SetValue(IsExpandedProperty, value);
        }

        public static readonly DependencyProperty IsExpandedProperty =
            DependencyProperty.RegisterAttached("IsExpanded", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsExpandedChanged));
        #endregion

        #endregion

        #region CheckedProperty

        public static readonly DependencyProperty CheckedShadowColorProperty =
            DependencyProperty.RegisterAttached("CheckedShadowColor", typeof(Color?), typeof(VisualStateHelper), new PropertyMetadata(OnCheckedShadowColorChanged));

        public static readonly DependencyProperty CheckedCornerRadiusProperty =
            DependencyProperty.RegisterAttached("CheckedCornerRadius", typeof(CornerRadius?), typeof(VisualStateHelper));

        #region IsChecked
        public static bool? GetIsChecked(DependencyObject obj)
        {
            return (bool?)obj.GetValue(IsCheckedProperty);
        }

        public static void SetIsChecked(DependencyObject obj, bool? value)
        {
            obj.SetValue(IsCheckedProperty, value);
        }

        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.RegisterAttached("IsChecked", typeof(bool?), typeof(VisualStateHelper), new PropertyMetadata(OnIsCheckedChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnRegistChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;

            FrameworkElementUtil.BindingProperty(element, BackgroundProperty, element, Control.BackgroundProperty);
            if (element is TabItem)
            {
                FrameworkElementUtil.BindingProperty(element, ForegroundProperty, element, TabItemHelper.ForegroundProperty);
            }
            else
            {
                FrameworkElementUtil.BindingProperty(element, ForegroundProperty, element, Control.ForegroundProperty);
            }
            FrameworkElementUtil.BindingProperty(element, BorderBrushProperty, element, Control.BorderBrushProperty);
            FrameworkElementUtil.BindingProperty(element, BorderThicknessProperty, element, Control.BorderThicknessProperty);

            if (element is TagItem)
            {
                FrameworkElementUtil.BindingProperty(element, CornerRadiusProperty, element, TagItem.CornerRadiusProperty);
            }

            if (element is CheckBox)
            {
                FrameworkElementUtil.BindingProperty(element, GlyphBrushProperty, element, CheckBoxHelper.GlyphBrushProperty);
            }
            if (element is RadioButton)
            {
                FrameworkElementUtil.BindingProperty(element, ToggleBrushProperty, element, RadioButtonHelper.ToggleBrushProperty);
            }
            FrameworkElementUtil.BindingProperty(element, BorderBrushProperty, element, Control.BorderBrushProperty);
            var effectBinding = new MultiBinding()
            {
                Converter = new DropShadowEffectWithDepthConverter(),
            };
            effectBinding.Bindings.Add(CreateBinding(ShadowColorProperty));
            effectBinding.Bindings.Add(CreateBinding(ShadowHelper.BlurRadiusProperty));
            effectBinding.Bindings.Add(CreateBinding(ShadowHelper.ShadowDepthProperty));
            effectBinding.Bindings.Add(CreateBinding(ShadowHelper.DirectionProperty));
            effectBinding.Bindings.Add(CreateBinding(ShadowHelper.OpacityProperty));
            effectBinding.Bindings.Add(CreateBinding(ShadowHelper.RenderingBiasProperty));
            element.SetBinding(EffectProperty, effectBinding);

            var toggleEffectBinding = new MultiBinding()
            {
                Converter = new DropShadowEffectWithDepthConverter(),
            };
            toggleEffectBinding.Bindings.Add(CreateBinding(ToggleShadowColorProperty));
            toggleEffectBinding.Bindings.Add(CreateBinding(ShadowHelper.BlurRadiusProperty));
            toggleEffectBinding.Bindings.Add(CreateBinding(ShadowHelper.ShadowDepthProperty));
            toggleEffectBinding.Bindings.Add(CreateBinding(ShadowHelper.DirectionProperty));
            toggleEffectBinding.Bindings.Add(CreateBinding(ShadowHelper.OpacityProperty));
            toggleEffectBinding.Bindings.Add(CreateBinding(ShadowHelper.RenderingBiasProperty));
            element.SetBinding(ToggleEffectProperty, toggleEffectBinding);
        }

        private static void OnHoverLockChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if (!(bool)e.NewValue)
            {
                Element_Unhover(element, null);
            }
        }

        private static void OnFocusedLockChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if (!(bool)e.NewValue)
            {
                Element_LostFocus(element, null);
            }
        }

        private static void OnIsHoverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if ((bool)e.NewValue)
            {
                Element_Hover(element, null);
            }
            else
            {
                Element_Unhover(element, null);
            }
        }

        private static void OnIsSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if ((bool)e.NewValue)
            {
                Element_Selected(element, null);
            }
            else
            {
                Element_Unselected(element, null);
            }
        }

        private static void OnIsExpandedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if ((bool)e.NewValue)
            {
                Element_Expanded(element, null);
            }
            else
            {
                Element_Collapsed(element, null);
            }
        }

        private static void OnIsOpenedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if ((bool)e.NewValue)
            {
                Element_Opened(element, null);
            }
            else
            {
                Element_Closed(element, null);
            }
        }
        

        private static void OnIsFocusedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if ((bool)e.NewValue)
            {
                Element_GotFocus(element, null);
            }
            else
            {
                Element_LostFocus(element, null);
            }
        }

        private static void OnIsCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if (e.NewValue != null && (bool)e.NewValue)
            {
                Element_Checked(element, null);
            }
            else
            {
                Element_Unchecked(element, null);
            }
        }

        private static void OnIsClickEffectPressedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var isPressed = (bool)e.NewValue;
            var element = (FrameworkElement)d;
            var parent = element.TemplatedParent;
            var clickEffect = GetClickEffect(parent);
            
            var storyboard = new Storyboard();
            switch (clickEffect)
            {
                case ClickEffect.Sink:
                    var sinkMarginAnimation = new ThicknessAnimation()
                    {
                        To = isPressed ? new Thickness(0, 1, 0, -1) : new Thickness(),
                        Duration = TimeSpan.Zero,
                    };
                    Storyboard.SetTarget(sinkMarginAnimation, parent);
                    Storyboard.SetTargetProperty(sinkMarginAnimation, new PropertyPath(MarginProperty));
                    storyboard.Children.Add(sinkMarginAnimation);
                    break;
                case ClickEffect.Shake:
                    if (!isPressed)
                    {
                        return;
                    }
                    var thirdPartSeconds = GlobalSettings.Setting.AnimationDuration.TotalSeconds / 3;
                    var shakeMarginAnimation1 = new ThicknessAnimation()
                    {
                        To = new Thickness(3, 0, -3, 0),
                        Duration = TimeSpan.FromSeconds(thirdPartSeconds),
                    };
                    Storyboard.SetTarget(shakeMarginAnimation1, parent);
                    Storyboard.SetTargetProperty(shakeMarginAnimation1, new PropertyPath(MarginProperty));
                    storyboard.Children.Add(shakeMarginAnimation1);

                    var shakeMarginAnimation2 = new ThicknessAnimation()
                    {
                        To = new Thickness(-3, 0, 3, 0),
                        Duration = TimeSpan.FromSeconds(thirdPartSeconds),
                        BeginTime = TimeSpan.FromSeconds(thirdPartSeconds),
                    };
                    Storyboard.SetTarget(shakeMarginAnimation2, parent);
                    Storyboard.SetTargetProperty(shakeMarginAnimation2, new PropertyPath(MarginProperty));
                    storyboard.Children.Add(shakeMarginAnimation2);

                    var shakeMarginAnimation3 = new ThicknessAnimation()
                    {
                        To = new Thickness(),
                        Duration = TimeSpan.FromSeconds(thirdPartSeconds),
                        BeginTime = TimeSpan.FromSeconds(thirdPartSeconds * 2),
                    };
                    Storyboard.SetTarget(shakeMarginAnimation3, parent);
                    Storyboard.SetTargetProperty(shakeMarginAnimation3, new PropertyPath(MarginProperty));
                    storyboard.Children.Add(shakeMarginAnimation3);
                    break;
            }
            storyboard.Begin();
        }
        
        private static void OnSelectedShadowColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if (GetIsSelected(element))
            {
                Element_Selected(element, null);
            }
        }

        private static void OnExpandedShadowColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if (GetIsExpanded(element))
            {
                Element_Expanded(element, null);
            }
        }

        private static void OnCheckedShadowColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if (GetIsChecked(element) == true)
            {
                Element_Checked(element, null);
            }
        }

        private static void Element_Hover(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var element = (FrameworkElement)sender;

            var propertyValues = new Dictionary<DependencyProperty, object>();

            if (!GetHoverBackgroundLock((DependencyObject)sender) 
                && element.GetValue(HoverBackgroundProperty) is Brush hoverBackground)
            {
                propertyValues.Add(BackgroundProperty, hoverBackground);
            }
            if (!GetHoverForegroundLock((DependencyObject)sender) 
                && element.GetValue(HoverForegroundProperty) is Brush hoverForeground)
            {
                if (element is TextBox || element is PasswordBox)
                {
                    propertyValues.Add(Control.ForegroundProperty, hoverForeground);
                }
                else
                {
                    propertyValues.Add(ForegroundProperty, hoverForeground);
                }
            }
            if (!GetHoverBorderBrushLock((DependencyObject)sender) 
                && element.GetValue(HoverBorderBrushProperty) is Brush hoverBorderBrush)
            {
                propertyValues.Add(BorderBrushProperty, hoverBorderBrush);
            }
            if (!GetHoverBorderThicknessLock((DependencyObject)sender)
               && element.GetValue(HoverBorderThicknessProperty) is Thickness hoverBorderThickness)
            {
                propertyValues.Add(BorderThicknessProperty, hoverBorderThickness);
            }
            if (!GetHoverCornerRadiusLock((DependencyObject)sender)
               && element.GetValue(HoverCornerRadiusProperty) is CornerRadius hoverCornerRadius)
            {
                propertyValues.Add(CornerRadiusProperty, hoverCornerRadius);
            }
            if (element.GetValue(HoverGlyphBrushProperty) is Brush hoverGlyphBrush)
            {
                propertyValues.Add(GlyphBrushProperty, hoverGlyphBrush);
            }
            if (element.GetValue(HoverToggleCornerRadiusProperty) is CornerRadius hoverToggleCornerRadius)
            {
                propertyValues.Add(ToggleCornerRadiusProperty, hoverToggleCornerRadius);
            }
            if (element.GetValue(HoverToggleBrushProperty) is Brush hoverToggleBrush)
            {
                propertyValues.Add(ToggleBrushProperty, hoverToggleBrush);
            }
            if (element.GetValue(HoverToggleSizeProperty) is double hoverToggleSize)
            {
                propertyValues.Add(ToggleSizeProperty, hoverToggleSize);
            }
            if (element.GetValue(HoverRibbonLineBrushProperty) is Brush hoverRibbonLineBrush)
            {
                propertyValues.Add(RibbonLineBrushProperty, hoverRibbonLineBrush);
            }
            if (propertyValues.Any())
            {
                AnimationUtil.BeginBrushAnimationStoryboard(element, propertyValues);
            }
            if (!GetHoverShadowColorLock((DependencyObject)sender)
                && element.GetValue(HoverShadowColorProperty) is Color hoverShadowColor)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    effect = new DropShadowEffect()
                    {
                        Color = hoverShadowColor,
                        ShadowDepth = ShadowHelper.GetShadowDepth(element),
                        Direction = ShadowHelper.GetDirection(element),
                        BlurRadius = ShadowHelper.GetBlurRadius(element),
                        Opacity = 0,
                        RenderingBias = ShadowHelper.GetRenderingBias(element),
                    };
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    SetEffect(element, effect);
                }
                else
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, hoverShadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
            if (!GetHoverToggleShadowColorLock((DependencyObject)sender)
                && element.GetValue(HoverToggleShadowColorProperty) is Color hoverToggleShadowColor)
            {
                var effect = GetToggleEffect(element);
                if (effect == null)
                {
                    effect = new DropShadowEffect()
                    {
                        Color = hoverToggleShadowColor,
                        ShadowDepth = ShadowHelper.GetShadowDepth(element),
                        Direction = ShadowHelper.GetDirection(element),
                        BlurRadius = ShadowHelper.GetBlurRadius(element),
                        Opacity = 0,
                        RenderingBias = ShadowHelper.GetRenderingBias(element),
                    };
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    SetToggleEffect(element, effect);
                }
                else
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, hoverToggleShadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
        }

        private static void Element_Unhover(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var element = (FrameworkElement)sender;

            var properties = new List<DependencyProperty>();
            if (!GetHoverBackgroundLock((DependencyObject)sender)
                && element.GetValue(HoverBackgroundProperty) != null)
            {
                properties.Add(BackgroundProperty);
            }
            if (!GetHoverForegroundLock((DependencyObject)sender)
                && element.GetValue(HoverForegroundProperty) != null)
            {
                if (element is TextBox || element is PasswordBox)
                {
                    properties.Add(Control.ForegroundProperty);
                }
                else
                {
                    properties.Add(ForegroundProperty);
                }
            }
            if (!GetHoverBorderBrushLock((DependencyObject)sender)
                && element.GetValue(HoverBorderBrushProperty) != null)
            {
                properties.Add(BorderBrushProperty);
            }
            if (!GetHoverBorderThicknessLock((DependencyObject)sender)
                && element.GetValue(HoverBorderThicknessProperty) != null)
            {
                properties.Add(BorderThicknessProperty);
            }
            if (!GetHoverCornerRadiusLock((DependencyObject)sender)
                && element.GetValue(HoverCornerRadiusProperty) != null)
            {
                properties.Add(CornerRadiusProperty);
            }
            if (element.GetValue(HoverGlyphBrushProperty) != null)
            {
                properties.Add(GlyphBrushProperty);
            }
            if (element.GetValue(HoverToggleSizeProperty) != null)
            {
                properties.Add(ToggleSizeProperty);
            }
            if (element.GetValue(HoverToggleBrushProperty) != null)
            {
                properties.Add(ToggleBrushProperty);
            }
            if (element.GetValue(HoverToggleCornerRadiusProperty) != null)
            {
                properties.Add(ToggleCornerRadiusProperty);
            }
            if (element.GetValue(HoverRibbonLineBrushProperty) != null)
            {
                properties.Add(RibbonLineBrushProperty);
            }
            if (properties.Any())
            {
                AnimationUtil.BeginBrushAnimationStoryboard(element, properties);
            }
            if (!GetHoverShadowColorLock((DependencyObject)sender)
                && element.GetValue(HoverShadowColorProperty) is Color)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }
                var shadowColor = element.GetValue(ShadowColorProperty);
                if (shadowColor == null)
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
                }
                else
                {
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, (Color)shadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
            if (!GetHoverToggleShadowColorLock((DependencyObject)sender)
               && element.GetValue(HoverToggleShadowColorProperty) is Color)
            {
                var effect = GetToggleEffect(element);
                if (effect == null)
                {
                    return;
                }
                var shadowColor = element.GetValue(ToggleShadowColorProperty);
                if (shadowColor == null)
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
                }
                else
                {
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, (Color)shadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
        }
        private static void Element_Opened(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;

            var propertyBrushes = new Dictionary<DependencyProperty, object>();
            if (element.GetValue(OpenedShadowColorProperty) is Color focusedShadowColor)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    effect = new DropShadowEffect()
                    {
                        Color = focusedShadowColor,
                        ShadowDepth = ShadowHelper.GetShadowDepth(element),
                        Direction = ShadowHelper.GetDirection(element),
                        BlurRadius = ShadowHelper.GetBlurRadius(element),
                        Opacity = 0,
                        RenderingBias = ShadowHelper.GetRenderingBias(element),
                    };
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    SetEffect(element, effect);
                }
                else
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, focusedShadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
            else
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }

                AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
            }
        }

        private static void Element_Closed(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;

            var properties = new List<DependencyProperty>();
            if (element.GetValue(OpenedShadowColorProperty) is Color)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }
                var shadowColor = element.GetValue(ShadowColorProperty);
                if (shadowColor == null)
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
                }
                else
                {
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, (Color)shadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
        }

        private static void Element_GotFocus(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;

            var propertyBrushes = new Dictionary<DependencyProperty, object>();
            if (element.GetValue(FocusedBackgroundProperty) is Brush focusedBackground)
            {
                propertyBrushes.Add(BackgroundProperty, focusedBackground);
            }
            if (element.GetValue(FocusedForegroundProperty) is Brush focusedForeground)
            {
                if (element is TextBox || element is PasswordBox)
                {
                    propertyBrushes.Add(Control.ForegroundProperty, focusedForeground);
                }
                propertyBrushes.Add(ForegroundProperty, focusedForeground);
            }
            if (element.GetValue(FocusedBorderBrushProperty) is Brush focusedBorderBrush)
            {
                propertyBrushes.Add(BorderBrushProperty, focusedBorderBrush);
            }
            if (element.GetValue(FocusedBorderThicknessProperty) is Thickness focusedBorderThickness)
            {
                propertyBrushes.Add(BorderThicknessProperty, focusedBorderThickness);
            }
            if (element.GetValue(FocusedCornerRadiusProperty) is CornerRadius focusedCornerRadius)
            {
                propertyBrushes.Add(CornerRadiusProperty, focusedCornerRadius);
            }
            if (element.GetValue(FocusedWatermarkForegroundProperty) is Brush watermarkBrush)
            {
                propertyBrushes.Add(WatermarkForegroundProperty, watermarkBrush);
            }
            if (propertyBrushes.Any())
            {
                AnimationUtil.BeginAnimationStoryboard(element, propertyBrushes);
            }
            if (!GetFocusedShadowColorLock((DependencyObject)sender)
                    && element.GetValue(FocusedShadowColorProperty) is Color focusedShadowColor)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    effect = new DropShadowEffect()
                    {
                        Color = focusedShadowColor,
                        ShadowDepth = ShadowHelper.GetShadowDepth(element),
                        Direction = ShadowHelper.GetDirection(element),
                        BlurRadius = ShadowHelper.GetBlurRadius(element),
                        Opacity = 0,
                        RenderingBias = ShadowHelper.GetRenderingBias(element),
                    };
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    SetEffect(element, effect);
                }
                else
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, focusedShadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
            else
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }

                AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
            }
        }

        private static void Element_LostFocus(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;

            var properties = new List<DependencyProperty>();
            if (element.GetValue(FocusedBackgroundProperty) != null)
            {
                properties.Add(BackgroundProperty);
            }
            if (element.GetValue(FocusedForegroundProperty) != null)
            {
                if (element is TextBox || element is PasswordBox)
                {
                    properties.Add(Control.ForegroundProperty);
                }
                properties.Add(ForegroundProperty);
            }
            if (element.GetValue(FocusedBorderBrushProperty) != null)
            {
                properties.Add(BorderBrushProperty);
            }
            if (element.GetValue(FocusedBorderThicknessProperty) != null)
            {
                properties.Add(BorderThicknessProperty);
            }
            if (element.GetValue(FocusedCornerRadiusProperty) != null)
            {
                properties.Add(CornerRadiusProperty);
            }
            if (element.GetValue(FocusedWatermarkForegroundProperty) != null)
            {
                properties.Add(WatermarkForegroundProperty);
            }
            if (properties.Any())
            {
                AnimationUtil.BeginBrushAnimationStoryboard(element, properties);
            }
            if (element.GetValue(FocusedShadowColorProperty) is Color)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }
                var shadowColor = element.GetValue(ShadowColorProperty);
                if (shadowColor == null)
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
                }
                else
                {
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, (Color)shadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
        }

        private static void Element_Selected(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;

            if (element.GetValue(SelectedShadowColorProperty) is Color selectedShadowColor)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    effect = new DropShadowEffect()
                    {
                        Color = selectedShadowColor,
                        ShadowDepth = ShadowHelper.GetShadowDepth(element),
                        Direction = ShadowHelper.GetDirection(element),
                        BlurRadius = ShadowHelper.GetBlurRadius(element),
                        Opacity = 0,
                        RenderingBias = ShadowHelper.GetRenderingBias(element),
                    };
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    SetEffect(element, effect);
                }
                else
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, selectedShadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
            else
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }

                AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
            }
        }

        private static void Element_Unselected(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;

            if (element.GetValue(SelectedShadowColorProperty) is Color)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }
                var shadowColor = element.GetValue(ShadowColorProperty);
                if (shadowColor == null)
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
                }
                else
                {
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, (Color)shadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
        }

        private static void Element_Expanded(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;

            if (element.GetValue(ExpandedShadowColorProperty) is Color expandedShadowColor)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    effect = new DropShadowEffect()
                    {
                        Color = expandedShadowColor,
                        ShadowDepth = ShadowHelper.GetShadowDepth(element),
                        Direction = ShadowHelper.GetDirection(element),
                        BlurRadius = ShadowHelper.GetBlurRadius(element),
                        Opacity = 0,
                        RenderingBias = ShadowHelper.GetRenderingBias(element),
                    };
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    SetEffect(element, effect);
                }
                else
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, expandedShadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
            else
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }

                AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
            }
        }

        private static void Element_Collapsed(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;

            if (element.GetValue(ExpandedShadowColorProperty) is Color)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }
                var shadowColor = element.GetValue(ShadowColorProperty);
                if (shadowColor == null)
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
                }
                else
                {
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, (Color)shadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
        }

        private static void Element_Checked(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            AnimationUtil.BeginDoubleAnimation(element, PercentProperty, null, 1, TimeSpan.FromMilliseconds(GlobalSettings.Setting.AnimationDuration.TotalMilliseconds), null, AnimationEasing.CubicInOut);

            if (element.GetValue(CheckedShadowColorProperty) is Color checkedShadowColor)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    effect = new DropShadowEffect()
                    {
                        Color = checkedShadowColor,
                        ShadowDepth = ShadowHelper.GetShadowDepth(element),
                        Direction = ShadowHelper.GetDirection(element),
                        BlurRadius = ShadowHelper.GetBlurRadius(element),
                        Opacity = 0,
                        RenderingBias = ShadowHelper.GetRenderingBias(element),
                    };
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    SetEffect(element, effect);
                }
                else
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, checkedShadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
            else
            {
                var effect = GetEffect(element);
                if (effect != null)
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
                }
            }

            var propertyBrushes = new Dictionary<DependencyProperty, object>();
            if (element.GetValue(CheckedCornerRadiusProperty) is CornerRadius checkedCornerRadius)
            {
                propertyBrushes.Add(CornerRadiusProperty, checkedCornerRadius);
            }
            if (propertyBrushes.Any())
            {
                AnimationUtil.BeginAnimationStoryboard(element, propertyBrushes);
            }

            if (element.GetValue(CheckedToggleShadowColorProperty) is Color checkedToggleShadowColor)
            {
                var effect = GetToggleEffect(element);
                if (effect == null)
                {
                    effect = new DropShadowEffect()
                    {
                        Color = checkedToggleShadowColor,
                        ShadowDepth = ShadowHelper.GetShadowDepth(element),
                        Direction = ShadowHelper.GetDirection(element),
                        BlurRadius = ShadowHelper.GetBlurRadius(element),
                        Opacity = 0,
                        RenderingBias = ShadowHelper.GetRenderingBias(element),
                    };
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    SetToggleEffect(element, effect);
                }
                else
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, ShadowHelper.GetOpacity(element), GlobalSettings.Setting.AnimationDuration);
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, checkedToggleShadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }
        }

        private static void Element_Unchecked(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            AnimationUtil.BeginDoubleAnimation(element, PercentProperty, null, 0, TimeSpan.FromMilliseconds(GlobalSettings.Setting.AnimationDuration.TotalMilliseconds), null, AnimationEasing.CubicInOut);

            if (element.GetValue(CheckedShadowColorProperty) is Color)
            {
                var effect = GetEffect(element);
                if (effect == null)
                {
                    return;
                }
                var shadowColor = element.GetValue(ShadowColorProperty);
                if (shadowColor == null)
                {
                    AnimationUtil.BeginDoubleAnimation(effect, DropShadowEffect.OpacityProperty, null, 0, GlobalSettings.Setting.AnimationDuration);
                }
                else
                {
                    AnimationUtil.BeginColorAnimation(effect, DropShadowEffect.ColorProperty, null, (Color)shadowColor, GlobalSettings.Setting.AnimationDuration);
                }
            }

            var properties = new List<DependencyProperty>();
            if (element.GetValue(CheckedCornerRadiusProperty) != null)
            {
                properties.Add(CornerRadiusProperty);
            }
        }

        #endregion

        #region Functions
        private static Binding CreateBinding(object path)
        {
            return new Binding()
            {
                Path = new PropertyPath(path),
                RelativeSource = RelativeSource.Self,
                Mode = BindingMode.OneWay,
            };
        }
        #endregion
    }
}
