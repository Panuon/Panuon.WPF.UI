using Panuon.UI.Silver.Internal.Converters;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Panuon.UI.Silver.Internal
{
    internal static class VisualStateHelper
    {
        #region Properties

        #region Regist
        internal static bool GetRegist(DependencyObject obj)
        {
            return (bool)obj.GetValue(RegistProperty);
        }

        internal static void SetRegist(DependencyObject obj, bool value)
        {
            obj.SetValue(RegistProperty, value);
        }

        internal static readonly DependencyProperty RegistProperty =
            DependencyProperty.RegisterAttached("Regist", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnRegistChanged));
        #endregion 

        #region Background
        internal static Brush GetBackground(Control control)
        {
            return (Brush)control.GetValue(BackgroundProperty);
        }

        internal static void SetBackground(Control obj, Brush value)
        {
            obj.SetValue(BackgroundProperty, value);
        }

        internal static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region Foreground
        internal static Brush GetForeground(Control control)
        {
            return (Brush)control.GetValue(ForegroundProperty);
        }

        internal static void SetForeground(Control control, Brush value)
        {
            control.SetValue(ForegroundProperty, value);
        }

        internal static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.RegisterAttached("Foreground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region BorderBrush
        internal static Brush GetBorderBrush(Control control)
        {
            return (Brush)control.GetValue(BorderBrushProperty);
        }

        internal static void SetBorderBrush(Control control, Brush value)
        {
            control.SetValue(BorderBrushProperty, value);
        }

        internal static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region WatermarkBrush
        internal static Brush GetWatermarkBrush(Control control)
        {
            return (Brush)control.GetValue(WatermarkBrushProperty);
        }

        internal static void SetWatermarkBrush(Control control, Brush value)
        {
            control.SetValue(WatermarkBrushProperty, value);
        }

        internal static readonly DependencyProperty WatermarkBrushProperty =
            DependencyProperty.RegisterAttached("WatermarkBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region GlyphBrush
        internal static Brush GetGlyphBrush(Control control)
        {
            return (Brush)control.GetValue(GlyphBrushProperty);
        }

        internal static void SetGlyphBrush(Control control, Brush value)
        {
            control.SetValue(GlyphBrushProperty, value);
        }

        internal static readonly DependencyProperty GlyphBrushProperty =
            DependencyProperty.RegisterAttached("GlyphBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region ToggleBrush
        internal static Brush GetToggleBrush(Control control)
        {
            return (Brush)control.GetValue(ToggleBrushProperty);
        }

        internal static void SetToggleBrush(Control control, Brush value)
        {
            control.SetValue(ToggleBrushProperty, value);
        }

        internal static readonly DependencyProperty ToggleBrushProperty =
            DependencyProperty.RegisterAttached("ToggleBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region RibbonLineBrush
        internal static Brush GetRibbonLineBrush(Control control)
        {
            return (Brush)control.GetValue(RibbonLineBrushProperty);
        }

        internal static void SetRibbonLineBrush(Control control, Brush value)
        {
            control.SetValue(RibbonLineBrushProperty, value);
        }

        internal static readonly DependencyProperty RibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("RibbonLineBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region Effect
        internal static DropShadowEffect GetEffect(DependencyObject obj)
        {
            return (DropShadowEffect)obj.GetValue(EffectProperty);
        }

        internal static void SetEffect(DependencyObject obj, DropShadowEffect value)
        {
            obj.SetValue(EffectProperty, value);
        }

        internal static readonly DependencyProperty EffectProperty =
            DependencyProperty.RegisterAttached("Effect", typeof(DropShadowEffect), typeof(VisualStateHelper));
        #endregion

        #region Percent
        internal static double GetPercent(DependencyObject obj)
        {
            return (double)obj.GetValue(PercentProperty);
        }

        internal static void SetPercent(DependencyObject obj, double value)
        {
            obj.SetValue(PercentProperty, value);
        }

        internal static readonly DependencyProperty PercentProperty =
            DependencyProperty.RegisterAttached("Percent", typeof(double), typeof(VisualStateHelper));
        #endregion 

        #endregion

        #region ShadowColor Properties

        #region ShadowColor
        internal static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.RegisterAttached("ShadowColor", typeof(Color?), typeof(VisualStateHelper));
        #endregion

        #endregion

        #region Hover Properties

        #region HoverBorderBrushProperty
        internal static readonly DependencyProperty HoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("HoverBorderBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region HoverBackgroundProperty
        internal static readonly DependencyProperty HoverBackgroundProperty =
            DependencyProperty.RegisterAttached("HoverBackground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region HoverForegroundProperty
        internal static readonly DependencyProperty HoverForegroundProperty =
            DependencyProperty.RegisterAttached("HoverForeground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region HoverGlyphBrushProperty
        internal static readonly DependencyProperty HoverGlyphBrushProperty =
            DependencyProperty.RegisterAttached("HoverGlyphBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region HoverGlyphBrushProperty
        internal static readonly DependencyProperty HoverToggleBrushProperty =
            DependencyProperty.RegisterAttached("HoverToggleBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region HoverGlyphBrushProperty
        internal static readonly DependencyProperty HoverRibbonLineBrushProperty =
            DependencyProperty.RegisterAttached("HoverRibbonLineBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region HoverBorderBrushLock
        internal static bool GetHoverBorderBrushLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverBorderBrushLockProperty);
        }

        internal static void SetHoverBorderBrushLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverBorderBrushLockProperty, value);
        }

        internal static readonly DependencyProperty HoverBorderBrushLockProperty =
            DependencyProperty.RegisterAttached("HoverBorderBrushLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region HoverBackgroundLock
        internal static bool GetHoverBackgroundLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverBackgroundLockProperty);
        }

        internal static void SetHoverBackgroundLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverBackgroundLockProperty, value);
        }

        internal static readonly DependencyProperty HoverBackgroundLockProperty =
            DependencyProperty.RegisterAttached("HoverBackgroundLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));
        #endregion

        #region HoverForegroundLock
        internal static bool GetHoverForegroundLock(DependencyObject obj)
        {
            return (bool)obj.GetValue(HoverForegroundLockProperty);
        }

        internal static void SetHoverForegroundLock(DependencyObject obj, bool value)
        {
            obj.SetValue(HoverForegroundLockProperty, value);
        }

        internal static readonly DependencyProperty HoverForegroundLockProperty =
            DependencyProperty.RegisterAttached("HoverForegroundLock", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnHoverLockChanged));

        #endregion

        #region IsHover
        internal static bool GetIsHover(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsHoverProperty);
        }

        internal static void SetIsHover(DependencyObject obj, bool value)
        {
            obj.SetValue(IsHoverProperty, value);
        }

        internal static readonly DependencyProperty IsHoverProperty =
            DependencyProperty.RegisterAttached("IsHover", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsHoverChanged));
        #endregion

        #region HoverShadowColor
        internal static readonly DependencyProperty HoverShadowColorProperty =
            DependencyProperty.RegisterAttached("HoverShadowColor", typeof(Color?), typeof(VisualStateHelper));
        #endregion

        #endregion

        #region Focused Properties

        #region FocusedBorderBrush
        internal static readonly DependencyProperty FocusedBorderBrushProperty =
            DependencyProperty.RegisterAttached("FocusedBorderBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region FocusedBackground
        internal static readonly DependencyProperty FocusedBackgroundProperty =
            DependencyProperty.RegisterAttached("FocusedBackground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region FocusedForeground
        internal static readonly DependencyProperty FocusedForegroundProperty =
            DependencyProperty.RegisterAttached("FocusedForeground", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region FocusedShadowColor
        internal static readonly DependencyProperty FocusedShadowColorProperty =
            DependencyProperty.RegisterAttached("FocusedShadowColor", typeof(Color?), typeof(VisualStateHelper));
        #endregion

        #region FocusedWatermarkBrush
        internal static readonly DependencyProperty FocusedWatermarkBrushProperty =
            DependencyProperty.RegisterAttached("FocusedWatermarkBrush", typeof(Brush), typeof(VisualStateHelper));
        #endregion

        #region IsFocused
        internal static bool GetIsFocused(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsFocusedProperty);
        }

        internal static void SetIsFocused(DependencyObject obj, bool value)
        {
            obj.SetValue(IsFocusedProperty, value);
        }

        internal static readonly DependencyProperty IsFocusedProperty =
            DependencyProperty.RegisterAttached("IsFocused", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsFocusedChanged));
        #endregion

        #endregion

        #region Selected Properties

        #region SelectedShadowColor
        internal static readonly DependencyProperty SelectedShadowColorProperty =
            DependencyProperty.RegisterAttached("SelectedShadowColor", typeof(Color?), typeof(VisualStateHelper), new PropertyMetadata(OnSelectedShadowColorChanged));
        #endregion

        #region IsSelected
        internal static bool GetIsSelected(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsSelectedProperty);
        }

        internal static void SetIsSelected(DependencyObject obj, bool value)
        {
            obj.SetValue(IsSelectedProperty, value);
        }

        internal static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.RegisterAttached("IsSelected", typeof(bool), typeof(VisualStateHelper), new PropertyMetadata(OnIsSelectedChanged));
        #endregion

        #endregion

        #region CheckedProperty

        #region IsChecked
        internal static bool? GetIsChecked(DependencyObject obj)
        {
            return (bool?)obj.GetValue(IsCheckedProperty);
        }

        internal static void SetIsChecked(DependencyObject obj, bool? value)
        {
            obj.SetValue(IsCheckedProperty, value);
        }

        internal static readonly DependencyProperty IsCheckedProperty =
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
        }

        private static void OnHoverLockChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if (!(bool)e.NewValue)
            {
                Element_MouseLeave(element, null);
            }
        }

        private static void OnIsHoverChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if ((bool)e.NewValue)
            {
                Element_MouseEnter(element, null);
            }
            else
            {
                Element_MouseLeave(element, null);
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

        private static void Element_Unchecked(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            AnimationUtil.BeginDoubleAnimation(element, PercentProperty, null, 0, TimeSpan.FromMilliseconds(GlobalSettings.Setting.AnimationDuration.TotalMilliseconds), null, AnimationEase.CubicInOut);
        }

        private static void Element_Checked(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            AnimationUtil.BeginDoubleAnimation(element, PercentProperty, null, 1, TimeSpan.FromMilliseconds(GlobalSettings.Setting.AnimationDuration.TotalMilliseconds), null, AnimationEase.CubicInOut);
        }

        private static void OnSelectedShadowColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (FrameworkElement)d;
            if (GetIsSelected(element))
            {
                Element_Selected(element, null);
            }
        }

        private static void Element_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var element = (FrameworkElement)sender;

            var propertyBrushes = new Dictionary<DependencyProperty, Brush>();
            if (!GetHoverBackgroundLock((DependencyObject)sender) && element.GetValue(HoverBackgroundProperty) is Brush hoverBackground)
            {
                propertyBrushes.Add(BackgroundProperty, hoverBackground);
            }
            if (!GetHoverForegroundLock((DependencyObject)sender) && element.GetValue(HoverForegroundProperty) is Brush hoverForeground)
            {
                if (element is TextBox || element is PasswordBox)
                {
                    propertyBrushes.Add(Control.ForegroundProperty, hoverForeground);
                }
                else
                {
                    propertyBrushes.Add(ForegroundProperty, hoverForeground);
                }
            }
            if (!GetHoverBorderBrushLock((DependencyObject)sender) && element.GetValue(HoverBorderBrushProperty) is Brush hoverBorderBrush)
            {
                propertyBrushes.Add(BorderBrushProperty, hoverBorderBrush);
            }
            if (element.GetValue(HoverGlyphBrushProperty) is Brush hoverGlyphBrush)
            {
                propertyBrushes.Add(GlyphBrushProperty, hoverGlyphBrush);
            }
            if (element.GetValue(HoverToggleBrushProperty) is Brush hoverToggleBrush)
            {
                propertyBrushes.Add(ToggleBrushProperty, hoverToggleBrush);
            }
            if(element.GetValue(HoverRibbonLineBrushProperty) is Brush hoverRibbonLineBrush)
            {
                propertyBrushes.Add(RibbonLineBrushProperty, hoverRibbonLineBrush);
            }
            if (propertyBrushes.Any())
            {
                AnimationUtil.BeginBrushAnimationStoryboard(element, propertyBrushes);
            }
            if (element.GetValue(HoverShadowColorProperty) is Color hoverShadowColor)
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

        }

        private static void Element_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var element = (FrameworkElement)sender;

            var properties = new List<DependencyProperty>();
            if (!GetHoverBackgroundLock((DependencyObject)sender) && element.GetValue(HoverBackgroundProperty) != null)
            {
                properties.Add(BackgroundProperty);
            }
            if (!GetHoverForegroundLock((DependencyObject)sender) && element.GetValue(HoverForegroundProperty) != null)
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
            if (!GetHoverBorderBrushLock((DependencyObject)sender) && element.GetValue(HoverBorderBrushProperty) != null)
            {
                properties.Add(BorderBrushProperty);
            }
            if (element.GetValue(HoverGlyphBrushProperty) != null)
            {
                properties.Add(GlyphBrushProperty);
            }
            if (element.GetValue(HoverToggleBrushProperty) != null)
            {
                properties.Add(ToggleBrushProperty);
            }
            if (element.GetValue(HoverRibbonLineBrushProperty) != null)
            {
                properties.Add(RibbonLineBrushProperty);
            }
            if (properties.Any())
            {
                AnimationUtil.BeginBrushAnimationStoryboard(element, properties);
            }
            if (element.GetValue(HoverShadowColorProperty) is Color)
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

            var propertyBrushes = new Dictionary<DependencyProperty, Brush>();
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
            if (element.GetValue(FocusedWatermarkBrushProperty) is Brush watermarkBrush)
            {
                propertyBrushes.Add(WatermarkBrushProperty, watermarkBrush);
            }
            if (propertyBrushes.Any())
            {
                AnimationUtil.BeginBrushAnimationStoryboard(element, propertyBrushes);
            }
            if (element.GetValue(FocusedShadowColorProperty) is Color focusedShadowColor)
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
            if (element.GetValue(FocusedWatermarkBrushProperty) != null)
            {
                properties.Add(WatermarkBrushProperty);
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
