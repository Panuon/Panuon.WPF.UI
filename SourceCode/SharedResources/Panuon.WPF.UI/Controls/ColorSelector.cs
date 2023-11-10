using Panuon.WPF;
using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = ThumbFenceTemplateName, Type = typeof(ThumbFence))]
    [TemplatePart(Name = DropperThumbTemplateName, Type = typeof(Thumb))]
    [TemplatePart(Name = AccentColorSliderTemplateName, Type = typeof(Slider))]
    [TemplatePart(Name = OpacitySliderTemplateName, Type = typeof(Slider))]
    [TemplatePart(Name = HEXTextBoxTemplateName, Type = typeof(TextBox))]
    [TemplatePart(Name = ARGBTextBoxTemplateName, Type = typeof(TextBox))]
    public class ColorSelector : Control
    {
        #region Fields
        private const string ThumbFenceTemplateName = "PART_ThumbFence";
        private const string DropperThumbTemplateName = "PART_DropperThumb";
        private const string AccentColorSliderTemplateName = "PART_AccentColorSlider";
        private const string OpacitySliderTemplateName = "PART_OpacitySlider";
        private const string HEXTextBoxTemplateName = "PART_HEXTextBox";
        private const string ARGBTextBoxTemplateName = "PART_ARGBTextBox";

        internal ThumbFence _thumbFence;
        private Thumb _dropperThumb;
        private Slider _accentColorSlider;
        private Slider _opacitySlider;
        private TextBox _hexTextBox;
        private TextBox _argbTextBox;

        private static List<Color> _gradientColors;
        private static GradientStop[] _gradientStops;
        private bool _isInternalSetHEXTextBox;
        private bool _isInternalSetARGBTextBox;
        private bool _isInternalSetOpacitySlider;
        private bool _isInternalUpdateSelector;
        #endregion

        #region Ctor
        static ColorSelector()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorSelector), new FrameworkPropertyMetadata(typeof(ColorSelector)));

            _gradientStops = new GradientStop[]
            {
                new GradientStop(Color.FromRgb(255, 0, 0), 0),
                new GradientStop(Color.FromRgb(255, 255, 0), 0.167),
                new GradientStop(Color.FromRgb(0, 255, 0), 0.334),
                new GradientStop(Color.FromRgb(0, 255, 255), 0.501),
                new GradientStop(Color.FromRgb(0, 0, 255), 0.668),
                new GradientStop(Color.FromRgb(255, 0, 255), 0.835),
                new GradientStop(Color.FromRgb(255, 0, 0), 1),
            };
            _gradientColors = _gradientStops.OrderByDescending(x => x.Offset)
                .Select(x => x.Color)
                .ToList();
        }
        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey DropperThumbStyleKey { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(DropperThumbStyleKey));

        public static ComponentResourceKey ThumbFenceStyleKey { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(ThumbFenceStyleKey));

        public static ComponentResourceKey AccentColorSliderStyleKey { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(AccentColorSliderStyleKey));

        public static ComponentResourceKey OpacitySliderStyleKey { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(OpacitySliderStyleKey));

        public static ComponentResourceKey EditorTextBoxStyleKey { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(EditorTextBoxStyleKey));
        #endregion

        #region Events

        #region SelectedColorChanged
        public event SelectedValueChangedRoutedEventHandler<Color> SelectedColorChanged
        {
            add { AddHandler(SelectedColorChangedEvent, value); }
            remove { RemoveHandler(SelectedColorChangedEvent, value); }
        }

        public static readonly RoutedEvent SelectedColorChangedEvent =
            EventManager.RegisterRoutedEvent("SelectedColorChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedRoutedEventHandler<Color>), typeof(ColorSelector));
        #endregion

        #endregion

        #region Properties

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(ColorSelector));
        #endregion

        #region EditorPanelMargin
        public Thickness EditorPanelMargin
        {
            get { return (Thickness)GetValue(EditorPanelMarginProperty); }
            set { SetValue(EditorPanelMarginProperty, value); }
        }

        public static readonly DependencyProperty EditorPanelMarginProperty =
            DependencyProperty.Register("EditorPanelMargin", typeof(Thickness), typeof(ColorSelector), new PropertyMetadata(new Thickness(0, 15, 0, 0)));
        #endregion

        #region ColorChannels
        public ColorChannels ColorChannels
        {
            get { return (ColorChannels)GetValue(ColorChannelsProperty); }
            set { SetValue(ColorChannelsProperty, value); }
        }

        public static readonly DependencyProperty ColorChannelsProperty =
            DependencyProperty.Register("ColorChannels", typeof(ColorChannels), typeof(ColorSelector), new PropertyMetadata(ColorChannels.ARGB, OnColorChannelsChanged));
        #endregion

        #region ColorEditors
        public ColorEditors ColorEditors
        {
            get { return (ColorEditors)GetValue(ColorEditorsProperty); }
            set { SetValue(ColorEditorsProperty, value); }
        }

        public static readonly DependencyProperty ColorEditorsProperty =
            DependencyProperty.Register("ColorEditors", typeof(ColorEditors), typeof(ColorSelector), new PropertyMetadata(ColorEditors.HEX));
        #endregion

        #region ColorEditorTagVisibility
        public Visibility ColorEditorTagVisibility
        {
            get { return (Visibility)GetValue(ColorEditorTagVisibilityProperty); }
            set { SetValue(ColorEditorTagVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ColorEditorTagVisibilityProperty =
            DependencyProperty.Register("ColorEditorTagVisibility", typeof(Visibility), typeof(ColorSelector));
        #endregion

        #region AccentColor
        internal Color AccentColor
        {
            get { return (Color)GetValue(AccentColorProperty); }
            set { SetValue(AccentColorProperty, value); }
        }

        internal static readonly DependencyPropertyKey AccentColorPropertyKey =
            DependencyProperty.RegisterReadOnly("AccentColor", typeof(Color), typeof(ColorSelector), new PropertyMetadata(Colors.Red));

        public static readonly DependencyProperty AccentColorProperty =
            AccentColorPropertyKey.DependencyProperty;
        #endregion

        #region SelectedColor
        public Color SelectedColor
        {
            get { return (Color)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }

        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorSelector), new FrameworkPropertyMetadata(Colors.White, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSelectedColorChanged));
        #endregion

        #region SelectedOpaqueColor
        internal Color SelectedOpaqueColor
        {
            get { return (Color)GetValue(SelectedOpaqueColorProperty); }
        }

        internal static readonly DependencyPropertyKey SelectedOpaqueColorPropertyKey =
            DependencyProperty.RegisterReadOnly("SelectedOpaqueColor", typeof(Color), typeof(ColorSelector), new PropertyMetadata(Colors.White));

        public static readonly DependencyProperty SelectedOpaqueColorProperty =
            SelectedOpaqueColorPropertyKey.DependencyProperty;
        #endregion

        #region DropperThumbStyle
        public static Style GetDropperThumbStyle(ColorSelector colorSelector)
        {
            return (Style)colorSelector.GetValue(DropperThumbStyleProperty);
        }

        public static void SetDropperThumbStyle(ColorSelector colorSelector, Style value)
        {
            colorSelector.SetValue(DropperThumbStyleProperty, value);
        }

        public static readonly DependencyProperty DropperThumbStyleProperty =
            DependencyProperty.RegisterAttached("DropperThumbStyle", typeof(Style), typeof(ColorSelector));
        #endregion

        #region ThumbFenceStyle
        public static Style GetThumbFenceStyle(ColorSelector colorSelector)
        {
            return (Style)colorSelector.GetValue(ThumbFenceStyleProperty);
        }

        public static void SetThumbFenceStyle(ColorSelector colorSelector, Style value)
        {
            colorSelector.SetValue(ThumbFenceStyleProperty, value);
        }

        public static readonly DependencyProperty ThumbFenceStyleProperty =
            DependencyProperty.RegisterAttached("ThumbFenceStyle", typeof(Style), typeof(ColorSelector));
        #endregion

        #region AccentColorSliderStyle
        public static Style GetAccentColorSliderStyle(ColorSelector colorSelector)
        {
            return (Style)colorSelector.GetValue(AccentColorSliderStyleProperty);
        }

        public static void SetAccentColorSliderStyle(ColorSelector colorSelector, Style value)
        {
            colorSelector.SetValue(AccentColorSliderStyleProperty, value);
        }

        public static readonly DependencyProperty AccentColorSliderStyleProperty =
            DependencyProperty.RegisterAttached("AccentColorSliderStyle", typeof(Style), typeof(ColorSelector));
        #endregion

        #region OpacitySliderStyle
        public static Style GetOpacitySliderStyle(ColorSelector colorSelector)
        {
            return (Style)colorSelector.GetValue(OpacitySliderStyleProperty);
        }

        public static void SetOpacitySliderStyle(ColorSelector colorSelector, Style value)
        {
            colorSelector.SetValue(OpacitySliderStyleProperty, value);
        }

        public static readonly DependencyProperty OpacitySliderStyleProperty =
            DependencyProperty.RegisterAttached("OpacitySliderStyle", typeof(Style), typeof(ColorSelector));
        #endregion

        #region EditorTextBoxStyle
        public static Style GetEditorTextBoxStyle(ColorSelector colorSelector)
        {
            return (Style)colorSelector.GetValue(EditorTextBoxStyleProperty);
        }

        public static void SetEditorTextBoxStyle(ColorSelector colorSelector, Style value)
        {
            colorSelector.SetValue(EditorTextBoxStyleProperty, value);
        }

        public static readonly DependencyProperty EditorTextBoxStyleProperty =
            DependencyProperty.RegisterAttached("EditorTextBoxStyle", typeof(Style), typeof(ColorSelector));
        #endregion

        #endregion

        #region Overrides

        #region OnApplyTemplate
        public override void OnApplyTemplate()
        {
            _thumbFence = GetTemplateChild(ThumbFenceTemplateName) as ThumbFence;
            _thumbFence.ThumbPositionChanging += ThumbFence_ThumbPositionChanging;
            _thumbFence.ThumbPositionChanged += ThumbFence_PositionChanged;

            _dropperThumb = GetTemplateChild(DropperThumbTemplateName) as Thumb;
            _dropperThumb.PreviewMouseDown += DropperThumb_PreviewMouseDown;
            _dropperThumb.PreviewMouseUp += DropperThumb_PreviewMouseUp;
            _dropperThumb.DragDelta += DropperThumb_DragDelta;
            _dropperThumb.DragStarted += DropperThumb_DragStarted;
            _dropperThumb.DragCompleted += _dropperThumb_DragCompleted;

            _accentColorSlider = GetTemplateChild(AccentColorSliderTemplateName) as Slider;
            _accentColorSlider.ValueChanged += AccentColorSlider_ValueChanged;

            _opacitySlider = GetTemplateChild(OpacitySliderTemplateName) as Slider;
            _opacitySlider.ValueChanged += OpacitySlider_ValueChanged;

            _hexTextBox = GetTemplateChild(HEXTextBoxTemplateName) as TextBox;
            _hexTextBox.TextChanged += TextBox_TextChanged;

            _argbTextBox = GetTemplateChild(ARGBTextBoxTemplateName) as TextBox;
            _argbTextBox.TextChanged += TextBox_TextChanged;

            UpdateSelectedOpaqueColor();
            UpdateHEXTextBoxText();
            UpdateARGBTextBoxText();
            UpdateFenchPositionAndAccentColorSliderValue();
            UpdateOpacitySlider();
            UpdateAccentColor();
        }

        private void DropperThumb_DragStarted(object sender, DragStartedEventArgs e)
        {
            Cursor = CursorUtil.DropperCursor;
        }

        private void _dropperThumb_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void DropperThumb_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Cursor = CursorUtil.DropperCursor;
        }

        private void DropperThumb_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
        #endregion

        #endregion

        #region Event Handlers
        private static void OnSelectedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var selector = (ColorSelector)d;
            selector.UpdateSelectedOpaqueColor();
            selector.UpdateHEXTextBoxText();
            selector.UpdateARGBTextBoxText();
            selector.UpdateFenchPositionAndAccentColorSliderValue();
            selector.UpdateOpacitySlider();
            selector.UpdateAccentColor();
            selector.RaiseEvent(new SelectedValueChangedRoutedEventArgs<Color>(SelectedColorChangedEvent, (Color)e.OldValue, (Color)e.NewValue));
        }

        private static void OnColorChannelsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var selector = (ColorSelector)d;
            selector.UpdateHEXTextBoxText();
        }

        private void ThumbFence_ThumbPositionChanging(object sender, PositionChangingRoutedEventArgs e)
        {

        }

        private void ThumbFence_PositionChanged(object sender, PositionChangedRoutedEventArgs e)
        {
            if (_isInternalUpdateSelector)
            {
                return;
            }
            _isInternalUpdateSelector = true;

            UpdateSelectedColor();

            _isInternalUpdateSelector = false;
        }

        private void OpacitySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_isInternalSetOpacitySlider)
            {
                return;
            }
            UpdateSelectedColorOpacity();
        }

        private void AccentColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_isInternalUpdateSelector)
            {
                return;
            }
            _isInternalUpdateSelector = true;

            UpdateAccentColor();
            UpdateSelectedColor();

            _isInternalUpdateSelector = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            var selectedColor = SelectedColor;

            if (textBox == _hexTextBox)
            {
                if (!_isInternalSetHEXTextBox)
                {
                    _isInternalSetHEXTextBox = true;

                    if (ColorUtil.FromHEXString(textBox.Text) is Color newColor)
                    {
                        if (ColorChannels == ColorChannels.RGB)
                        {
                            newColor.A = 255;
                        }
                        selectedColor = newColor;
                    }
                    SetCurrentValue(SelectedColorProperty, selectedColor);

                    _isInternalSetHEXTextBox = false;
                }
            }
            else
            {
                if (!_isInternalSetARGBTextBox)
                {
                    _isInternalSetARGBTextBox = true;

                    if (ColorChannels == ColorChannels.ARGB
                        && ColorUtil.FromARGBString(textBox.Text) is Color argbColor)
                    {
                        selectedColor = argbColor;
                    }
                    else if (ColorChannels == ColorChannels.RGB
                        && ColorUtil.FromARGBString(textBox.Text) is Color rgbColor)
                    {
                        selectedColor = rgbColor;
                    }
                    SetCurrentValue(SelectedColorProperty, selectedColor);

                    _isInternalSetARGBTextBox = false;
                }
            }
        }

        private void DropperThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var point = PointToScreen(Mouse.GetPosition(this));
            var color = ColorUtil.GetScreenColor(point.X, point.Y);
            SetCurrentValue(SelectedColorProperty, color);
        }
        #endregion

        #region Functions
        private void UpdateSelectedColor()
        {
            if (_thumbFence == null)
            {
                return;
            }

            var position = _thumbFence.ThumbPosition;
            var accentColor = AccentColor;

            var colorLeft = Color.FromRgb((byte)(255 * (1 - position.Y))
                , (byte)(255 * (1 - position.Y))
                , (byte)(255 * (1 - position.Y)));

            var colorRight = Color.FromRgb((byte)(accentColor.R * (1 - position.Y))
                , (byte)(accentColor.G * (1 - position.Y))
                , (byte)(accentColor.B * (1 - position.Y)));

            var selectedColor = Color.FromRgb((byte)(colorLeft.R - (colorLeft.R - colorRight.R) * position.X)
                , (byte)(colorLeft.G - (colorLeft.G - colorRight.G) * position.X)
                , (byte)(colorLeft.B - (colorLeft.B - colorRight.B) * position.X));

            var opacityPercent = ColorChannels == ColorChannels.ARGB ? 1 - (_opacitySlider.Value / 100d)
                : 1;
            selectedColor.A = (byte)(opacityPercent * 255);

            SetCurrentValue(SelectedColorProperty, selectedColor);

        }

        private void UpdateSelectedOpaqueColor()
        {
            if (!IsInitialized)
            {
                return;
            }
            var selectedOpaqueColor = new Color()
            {
                A = 255,
                R = SelectedColor.R,
                G = SelectedColor.G,
                B = SelectedColor.B,
            };
            SetValue(SelectedOpaqueColorPropertyKey, selectedOpaqueColor);
        }

        private void UpdateHEXTextBoxText()
        {
            if (_hexTextBox == null
                || _isInternalSetHEXTextBox)
            {
                return;
            }
            _isInternalSetHEXTextBox = true;

            var selectedColor = SelectedColor;

            _hexTextBox.Text = ColorUtil.ToHEXString(selectedColor, ColorChannels == ColorChannels.ARGB, false);

            _isInternalSetHEXTextBox = false;
        }

        private void UpdateARGBTextBoxText()
        {
            if (_argbTextBox == null
                || _isInternalSetARGBTextBox)
            {
                return;
            }

            _isInternalSetARGBTextBox = true;

            var selectedColor = SelectedColor;

            _argbTextBox.Text = ColorChannels == ColorChannels.ARGB
                ? ColorUtil.ToARGBString(selectedColor)
                : ColorUtil.ToRGBString(selectedColor);

            _isInternalSetARGBTextBox = false;
        }
         
        private void UpdateSelectedColorOpacity()
        {
            if (_opacitySlider == null)
            {
                return;
            }

            var opacity = 1 - (_opacitySlider.Value / 100d);
            var color = SelectedColor;
            color.A = (byte)(opacity * 255);
            SetCurrentValue(SelectedColorProperty, color);
        }

        private void UpdateAccentColor()
        {
            if (_accentColorSlider == null)
            {
                return;
            }

            Color accentColor = default;

            var offset = 1 - (_accentColorSlider.Value / 100d);
            if (offset == 0)
            {
                accentColor = _gradientStops.First().Color;
            }
            else if (offset == 1)
            {
                accentColor = _gradientStops.Last().Color;
            }
            else
            {
                var left = _gradientStops.Last(s => s.Offset <= offset);
                var right = _gradientStops.First(s => s.Offset > offset);
                offset = Math.Round((offset - left.Offset) / (right.Offset - left.Offset), 2);
                accentColor = (Color.FromRgb((byte)((right.Color.R - left.Color.R) * offset + left.Color.R)
                    , (byte)((right.Color.G - left.Color.G) * offset + left.Color.G)
                    , (byte)((right.Color.B - left.Color.B) * offset + left.Color.B)));
            }

            SetValue(AccentColorPropertyKey, accentColor);
        }

        private void UpdateFenchPositionAndAccentColorSliderValue()
        {
            if (_isInternalUpdateSelector
                || _thumbFence == null
                || _accentColorSlider == null)
            {
                return;
            }

            _isInternalUpdateSelector = true;

            var rgbList = new List<byte> 
            {
                SelectedColor.R, 
                SelectedColor.G, 
                SelectedColor.B 
            };
            var minValue = rgbList.Min();
            var maxValue = rgbList.Max();
            var minIndex = rgbList.IndexOf(minValue);
            var maxIndex = rgbList.IndexOf(maxValue);

            double sliderValue = 0d;
            if (minIndex == 0 && maxIndex == 0)
            {
                sliderValue = 0;
            }
            else
            {
                var middleIndex = 3 - minIndex - maxIndex;
                var middleValue = rgbList[middleIndex];
                var middleNewValue = (byte)(255 * (minValue - middleValue) / (double)(minValue - maxValue));

                rgbList[maxIndex] = 255;
                rgbList[minIndex] = 0;
                rgbList[middleIndex] = 0;

                var colorIndex = _gradientColors.IndexOf(Color.FromRgb(rgbList[0], rgbList[1], rgbList[2]));

                if (colorIndex < 5 && colorIndex > 0)
                {
                    var nextColor = _gradientColors[colorIndex + 1];
                    var prevColor = _gradientColors[colorIndex - 1];

                    var nextBytes = new List<byte>() { nextColor.R, nextColor.G, nextColor.B };
                    var prevBytes = new List<byte>() { prevColor.R, prevColor.G, prevColor.B };

                    if (nextBytes[minIndex] > 0)
                    {
                        sliderValue = (prevBytes[middleIndex] - middleNewValue) / 255.0 + colorIndex - 1;
                    }
                    else
                    {
                        sliderValue = middleNewValue / 255.0 + colorIndex;
                    }
                }
                else if (colorIndex == 0)
                {
                    if (minIndex == 2)
                    {
                        sliderValue = colorIndex + (255 - middleNewValue) / 255.0 + 5;
                    }
                    else
                    {
                        sliderValue = middleNewValue / 255.0;
                    }
                }
                else
                {
                    sliderValue = (255 - middleNewValue) / 255.0;
                }
            }
            _accentColorSlider.Value = sliderValue * 100 / 6d;

            var pointX = maxValue == 0
                ? 0
                : (1 - minValue / (double)maxValue);
            var pointY = 1 - maxValue / 255d;
            _thumbFence.ThumbPosition = new Point(pointX, pointY);

            _isInternalUpdateSelector = false;
        }

        private void UpdateOpacitySlider()
        {
            if (_opacitySlider == null
                || _isInternalSetOpacitySlider)
            {
                return;
            }
            _isInternalSetOpacitySlider = true;

            var selectorColor = SelectedColor;
            _opacitySlider.Value = 100 - (int)(selectorColor.A * 100 / 255d);

            _isInternalSetOpacitySlider = false;
        }
        #endregion
    }
}
