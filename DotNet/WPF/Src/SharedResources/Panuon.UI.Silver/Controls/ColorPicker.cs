using Panuon.UI.Core;
using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = ColorSelectorTemplateName, Type = typeof(ColorSelector))]
    [TemplatePart(Name = EditableTextBoxTemplateName, Type = typeof(TextBox))]
    public class ColorPicker : Control
    {
        #region Fields
        private const string ColorSelectorTemplateName = "PART_ColorSelector";

        private const string EditableTextBoxTemplateName = "PART_EditableTextBox";

        private const string PopupTemplateName = "PART_Popup";

        private ColorSelector _colorSelector;

        private TextBox _editableTextBox;

        private bool _isInternalUpdateColorSelector;

        private bool _isInternalUpdateTextBox;
        #endregion

        #region Ctor
        static ColorPicker()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPicker), new FrameworkPropertyMetadata(typeof(ColorPicker)));

            EventManager.RegisterClassHandler(typeof(ColorPicker), Mouse.LostMouseCaptureEvent, new MouseEventHandler(OnLostMouseCapture));
            EventManager.RegisterClassHandler(typeof(ColorPicker), Mouse.MouseDownEvent, new MouseButtonEventHandler(OnMouseButtonDown));
            EventManager.RegisterClassHandler(typeof(ColorPicker), Mouse.PreviewMouseDownEvent, new MouseButtonEventHandler(OnPreviewMouseButtonDown));
            EventManager.RegisterClassHandler(typeof(ColorPicker), UIElement.GotFocusEvent, new RoutedEventHandler(OnThisGotFocus));
        }
        #endregion

        #region Events

        #region SelectedColorChanged
        public event SelectedValueChangedEventHandler<Color?> SelectedColorChanged
        {
            add { AddHandler(SelectedColorChangedEvent, value); }
            remove { RemoveHandler(SelectedColorChangedEvent, value); }
        }

        public static readonly RoutedEvent SelectedColorChangedEvent =
            EventManager.RegisterRoutedEvent("SelectedColorChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedEventHandler<Color?>), typeof(ColorPicker));
        #endregion

        #endregion

        #region Properties

        #region Icon
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(ColorPicker));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ColorPicker));
        #endregion

        #region Watermark
        public string Watermark
        {
            get { return (string)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark", typeof(string), typeof(ColorPicker));
        #endregion

        #region WatermarkBrush
        public Brush WatermarkBrush
        {
            get { return (Brush)GetValue(WatermarkBrushProperty); }
            set { SetValue(WatermarkBrushProperty, value); }
        }

        public static readonly DependencyProperty WatermarkBrushProperty =
            DependencyProperty.Register("WatermarkBrush", typeof(Brush), typeof(ColorPicker));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region FocusedBackground
        public Brush FocusedBackground
        {
            get { return (Brush)GetValue(FocusedBackgroundProperty); }
            set { SetValue(FocusedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedBackgroundProperty =
            VisualStateHelper.FocusedBackgroundProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region FocusedForeground
        public Brush FocusedForeground
        {
            get { return (Brush)GetValue(FocusedForegroundProperty); }
            set { SetValue(FocusedForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedForegroundProperty =
            VisualStateHelper.FocusedForegroundProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region FocusedBorderBrush
        public Brush FocusedBorderBrush
        {
            get { return (Brush)GetValue(FocusedBorderBrushProperty); }
            set { SetValue(FocusedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            VisualStateHelper.FocusedBorderBrushProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region FocusedShadowColor
        public Color? FocusedShadowColor
        {
            get { return (Color?)GetValue(FocusedShadowColorProperty); }
            set { SetValue(FocusedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty FocusedShadowColorProperty =
            VisualStateHelper.FocusedShadowColorProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region FocusedWatermarkBrush
        public Brush FocusedWatermarkBrush
        {
            get { return (Brush)GetValue(FocusedWatermarkBrushProperty); }
            set { SetValue(FocusedWatermarkBrushProperty, value); }
        }

        public static readonly DependencyProperty FocusedWatermarkBrushProperty =
            VisualStateHelper.FocusedWatermarkBrushProperty.AddOwner(typeof(ColorPicker));
        #endregion

        #region Text
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ColorPicker));
        #endregion

        #region TextFormats
        public ColorTextFormats ColorTextFormats
        {
            get { return (ColorTextFormats)GetValue(TextFormatsProperty); }
            set { SetValue(TextFormatsProperty, value); }
        }

        public static readonly DependencyProperty TextFormatsProperty =
            DependencyProperty.Register("TextFormats", typeof(ColorTextFormats), typeof(ColorPicker), new PropertyMetadata(ColorTextFormats.HEX, OnColorTextFormatsChanged));
        #endregion

        #region IsDropDownOpen
        public bool IsDropDownOpen
        {
            get { return (bool)GetValue(IsDropDownOpenProperty); }
            set { SetValue(IsDropDownOpenProperty, value); }
        }

        public static readonly DependencyProperty IsDropDownOpenProperty =
            DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(ColorPicker), new PropertyMetadata(OnIsDropDownOpenChanged));
        #endregion

        #region IsEditable
        public bool IsEditable
        {
            get { return (bool)GetValue(IsEditableProperty); }
            set { SetValue(IsEditableProperty, value); }
        }

        public static readonly DependencyProperty IsEditableProperty =
            DependencyProperty.Register("IsEditable", typeof(bool), typeof(ColorPicker));
        #endregion

        #region StaysOpen
        public bool StaysOpen
        {
            get { return (bool)GetValue(StaysOpenProperty); }
            set { SetValue(StaysOpenProperty, value); }
        }

        public static readonly DependencyProperty StaysOpenProperty =
            DependencyProperty.Register("StaysOpen", typeof(bool), typeof(ColorPicker));
        #endregion

        #region ColorChannels
        public ColorChannels ColorChannels
        {
            get { return (ColorChannels)GetValue(ColorChannelsProperty); }
            set { SetValue(ColorChannelsProperty, value); }
        }

        public static readonly DependencyProperty ColorChannelsProperty =
            DependencyProperty.Register("ColorChannels", typeof(ColorChannels), typeof(ColorPicker), new PropertyMetadata(ColorChannels.ARGB, OnColorChannelsChanged));

        #endregion

        #region SelectedColor
        public Color? SelectedColor
        {
            get { return (Color?)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }

        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Color?), typeof(ColorPicker), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSelectedColorChanged));

        #endregion

        #region DefaultColor
        public Color? DefaultColor
        {
            get { return (Color?)GetValue(DefaultColorProperty); }
            set { SetValue(DefaultColorProperty, value); }
        }

        public static readonly DependencyProperty DefaultColorProperty =
            DependencyProperty.Register("DefaultColor", typeof(Color?), typeof(ColorPicker), new PropertyMetadata(null));
        #endregion

        #region ColorSelectorStyle
        public Style ColorSelectorStyle
        {
            get { return (Style)GetValue(ColorSelectorStyleProperty); }
            set { SetValue(ColorSelectorStyleProperty, value); }
        }

        public static readonly DependencyProperty ColorSelectorStyleProperty =
            DependencyProperty.Register("ColorSelectorStyle", typeof(Style), typeof(ColorPicker));
        #endregion

        #region ToggleArrowTransformControlStyle
        public Style ToggleArrowTransformControlStyle
        {
            get { return (Style)GetValue(ToggleArrowTransformControlStyleProperty); }
            set { SetValue(ToggleArrowTransformControlStyleProperty, value); }
        }

        public static readonly DependencyProperty ToggleArrowTransformControlStyleProperty =
            DependencyProperty.Register("ToggleArrowTransformControlStyle", typeof(Style), typeof(ColorPicker));
        #endregion

        #region PreviewTemplate
        public DataTemplate PreviewTemplate
        {
            get { return (DataTemplate)GetValue(PreviewTemplateProperty); }
            set { SetValue(PreviewTemplateProperty, value); }
        }

        public static readonly DependencyProperty PreviewTemplateProperty =
            DependencyProperty.Register("PreviewTemplate", typeof(DataTemplate), typeof(ColorPicker));
        #endregion

        #region ClearButtonStyle
        public Style ClearButtonStyle
        {
            get { return (Style)GetValue(ClearButtonStyleProperty); }
            set { SetValue(ClearButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty ClearButtonStyleProperty =
            DependencyProperty.Register("ClearButtonStyle", typeof(Style), typeof(ColorPicker));
        #endregion

        #region ClearButtonVisibility
        public AuxiliaryButtonVisibility ClearButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(ClearButtonVisibilityProperty); }
            set { SetValue(ClearButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.Register("ClearButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(ColorPicker));
        #endregion

        #region ClearCommand
        internal ICommand ClearCommand
        {
            get { return (ICommand)GetValue(ClearCommandProperty); }
        }

        internal static readonly DependencyPropertyKey ClearCommandPropertyKey =
            DependencyProperty.RegisterReadOnly("ClearCommand", typeof(ICommand), typeof(ColorPicker), new PropertyMetadata(new RelayCommand<ColorPicker>(OnClearCommandExecute)));

        public static readonly DependencyProperty ClearCommandProperty =
            ClearCommandPropertyKey.DependencyProperty;
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _colorSelector = GetTemplateChild(ColorSelectorTemplateName) as ColorSelector;
            _colorSelector.SelectedColorChanged += ColorSelector_SelectedColorChanged;

            _editableTextBox = GetTemplateChild(EditableTextBoxTemplateName) as TextBox;
            _editableTextBox.TextChanged += EditableTextBox_TextChanged;

            UpdateColorSelectorSelectedColor();
            UpdateText();
        }
        #endregion

        #region Event Handlers
        private static void OnColorTextFormatsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var colorPicker = (ColorPicker)d;
            colorPicker.UpdateText();
        }

        private static void OnColorChannelsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var colorPicker = (ColorPicker)d;
            colorPicker.UpdateText();
        }

        private static void OnIsDropDownOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var colorPicker = (ColorPicker)d;
            if ((bool)e.NewValue)
            {
                Mouse.Capture(colorPicker, CaptureMode.SubTree);
                if (colorPicker.IsEditable
                    && colorPicker._editableTextBox != null)
                {
                    colorPicker._editableTextBox.Focus();
                }
            }
            else
            {
                if (colorPicker.IsKeyboardFocusWithin)
                {
                    if (colorPicker.IsEditable)
                    {
                        if (colorPicker._editableTextBox != null
                            && !colorPicker._editableTextBox.IsKeyboardFocusWithin)
                        {
                            colorPicker.Focus();
                        }
                    }
                    else
                    {
                        colorPicker.Focus();
                    }
                }
                if (Mouse.Captured == colorPicker)
                {
                    Mouse.Capture(null);
                }
            }
        }

        private static void OnThisGotFocus(object sender, RoutedEventArgs e)
        {
            var colorPicker = (ColorPicker)sender;
            if (!e.Handled)
            {
                if (colorPicker.IsEditable && colorPicker._editableTextBox != null)
                {
                    if (e.OriginalSource == colorPicker)
                    {
                        colorPicker._editableTextBox.Focus();
                        e.Handled = true;
                    }
                    else if (e.OriginalSource == colorPicker._editableTextBox)
                    {
                        colorPicker._editableTextBox.Focus();
                    }
                }
            }

        }

        private static void OnMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            var colorPicker = (ColorPicker)sender;
            if ((colorPicker.ContextMenu == null || !colorPicker.ContextMenu.IsOpen)
                      && !colorPicker.IsKeyboardFocusWithin)
            {
                colorPicker.Focus();
            }

            if (Mouse.Captured == colorPicker
                && e.OriginalSource == colorPicker)
            {
                colorPicker.SetCurrentValue(IsDropDownOpenProperty, false);
            }
        }

        private static void OnPreviewMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            var colorPicker = (ColorPicker)sender;
            if (colorPicker.IsEditable)
            {
                var originalSource = e.OriginalSource as Visual;

                if (originalSource != null && colorPicker._editableTextBox != null
                    && colorPicker.IsAncestorOf(originalSource))
                {
                    if ((colorPicker.ContextMenu == null || !colorPicker.ContextMenu.IsOpen)
                        && !colorPicker.IsKeyboardFocusWithin)
                    {
                        colorPicker.Focus();
                    }
                }
            }
        }

        private static void OnLostMouseCapture(object sender ,MouseEventArgs e)
        {
             var colorPicker = (ColorPicker)sender;
            if(e.OriginalSource == colorPicker._editableTextBox)
            {
                colorPicker.SetCurrentValue(IsDropDownOpenProperty, true);
                colorPicker._editableTextBox.Focus();
            }
            Debug.WriteLine(e.OriginalSource);
        }

        private static void OnSelectedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var colorPicker = (ColorPicker)d;
            colorPicker.UpdateColorSelectorSelectedColor();
            colorPicker.UpdateText();
        }

        private void EditableTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_isInternalUpdateTextBox)
            {
                return;
            }

            _isInternalUpdateTextBox = true;

            UpdateSelectedColor();

            _isInternalUpdateTextBox = false;
        }

        private static void OnClearCommandExecute(ColorPicker colorPicker)
        {
            colorPicker.SetCurrentValue(TextProperty, null);
            colorPicker.SetCurrentValue(SelectedColorProperty, colorPicker.DefaultColor);
        }

        private void ColorSelector_SelectedColorChanged(object sender, SelectedValueChangedEventArgs<Color> e)
        {
            if (_isInternalUpdateColorSelector)
            {
                return;
            }
            _isInternalUpdateColorSelector = true;

            SetCurrentValue(SelectedColorProperty, e.NewValue);

            _isInternalUpdateColorSelector = false;
        }
        #endregion

        #region Functions
        private void UpdateColorSelectorSelectedColor()
        {
            if (_colorSelector == null
                || _isInternalUpdateColorSelector)
            {
                return;
            }

            _isInternalUpdateColorSelector = true;

            _colorSelector.SetCurrentValue(ColorSelector.SelectedColorProperty, SelectedColor ?? Colors.White);

            _isInternalUpdateColorSelector = false;
        }

        private void UpdateText()
        {
            if(_editableTextBox == null)
            {
                return;
            }

            var nullableSelectedColor = SelectedColor;
            string text = null;

            if (nullableSelectedColor is Color selectedColor)
            {
                switch (ColorTextFormats)
                {
                    case ColorTextFormats.HEX:
                        text = ColorUtil.ToHEXString(selectedColor, ColorChannels == ColorChannels.ARGB, true);
                        break;
                    case ColorTextFormats.ARGB:
                        text = ColorUtil.ToARGBString(selectedColor, ColorChannels == ColorChannels.ARGB);
                        break;

                }
            }

            SetCurrentValue(TextProperty, text);

            if (!_isInternalUpdateTextBox)
            {
                _isInternalUpdateTextBox = true;

                _editableTextBox.Text = text;

                _isInternalUpdateTextBox = false;
            }
        }

        private void UpdateSelectedColor()
        {
            if (_editableTextBox == null)
            {
                return;
            }

            var text = _editableTextBox.Text;
            var selectedColor = SelectedColor;

            switch (ColorTextFormats)
            {
                case ColorTextFormats.HEX:
                    if (ColorUtil.FromHEXString(text) is Color newHexColor)
                    {
                        if (ColorChannels == ColorChannels.RGB)
                        {
                            newHexColor.A = 255;
                        }
                        selectedColor = newHexColor;
                    }
                    break;
                case ColorTextFormats.ARGB:
                    if (ColorUtil.FromARGBString(text) is Color newARGBColor)
                    {
                        if (ColorChannels == ColorChannels.RGB)
                        {
                            newARGBColor.A = 255;
                        }
                        selectedColor = newARGBColor;
                    }
                    break;
            }

            SetCurrentValue(SelectedColorProperty, selectedColor);
        }

        #endregion
    }
}
