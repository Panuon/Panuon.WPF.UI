using Panuon.UI.Core;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = ThumbFenceTemplateName, Type = typeof(ThumbFence))]
    [TemplatePart(Name = DropperThumbTemplateName, Type = typeof(Thumb))]
    [TemplatePart(Name = AccentColorSliderTemplateName, Type = typeof(Slider))]
    [TemplatePart(Name = OpacitySliderTemplateName, Type = typeof(Slider))]
    [TemplatePart(Name = HEXTextBoxTemplateName, Type = typeof(TextBox))]
    [TemplatePart(Name = ATextBoxTemplateName, Type = typeof(TextBox))]
    [TemplatePart(Name = RTextBoxTemplateName, Type = typeof(TextBox))]
    [TemplatePart(Name = GTextBoxTemplateName, Type = typeof(TextBox))]
    [TemplatePart(Name = BTextBoxTemplateName, Type = typeof(TextBox))]
    public class ColorSelector : Control
    {
        #region Fields
        private const string ThumbFenceTemplateName = "PART_ThumbFence";

        private const string DropperThumbTemplateName = "PART_DropperThumb";

        private const string AccentColorSliderTemplateName = "PART_AccentColorSlider";

        private const string OpacitySliderTemplateName = "PART_OpacitySlider";

        private const string HEXTextBoxTemplateName = "PART_HEXTextBox";

        private const string ATextBoxTemplateName = "PART_ATextBox";

        private const string RTextBoxTemplateName = "PART_RTextBox";

        private const string GTextBoxTemplateName = "PART_GTextBox";

        private const string BTextBoxTemplateName = "PART_BTextBox";

        internal ThumbFence _thumbFence;

        private Thumb _dropperThumb;

        private Slider _accentColorSlider;

        private Slider _opacitySlider;

        private TextBox _hexTextBox;

        private TextBox _aTextBox;

        private TextBox _rTextBox;

        private TextBox _gTextBox;

        private TextBox _bTextBox;

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
        public static ComponentResourceKey DropperThumbStyle { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(DropperThumbStyle));

        public static ComponentResourceKey ThumbFenceStyle { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(ThumbFenceStyle));

        public static ComponentResourceKey SliderStyle { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(SliderStyle));

        public static ComponentResourceKey InputTextBoxStyle { get; } =
            new ComponentResourceKey(typeof(ColorSelector), nameof(InputTextBoxStyle));
        #endregion


        #region Events

        #region SelectedColorChanged
        public event SelectedValueChangedEventHandler<Color> SelectedColorChanged
        {
            add { AddHandler(SelectedColorChangedEvent, value); }
            remove { RemoveHandler(SelectedColorChangedEvent, value); }
        }

        public static readonly RoutedEvent SelectedColorChangedEvent =
            EventManager.RegisterRoutedEvent("SelectedColorChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedEventHandler<Color>), typeof(ColorSelector));
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
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ColorSelector));
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
        public static Style GetDropperThumbStyle(Button button)
        {
            return (Style)button.GetValue(DropperThumbStyleProperty);
        }

        public static void SetDropperThumbStyle(Button button, Style value)
        {
            button.SetValue(DropperThumbStyleProperty, value);
        }

        public static readonly DependencyProperty DropperThumbStyleProperty =
            DependencyProperty.RegisterAttached("DropperThumbStyle", typeof(Style), typeof(ColorSelector));
        #endregion

        #region ThumbFenceStyle
        public static Style GetThumbFenceStyle(Button button)
        {
            return (Style)button.GetValue(ThumbFenceStyleProperty);
        }

        public static void SetThumbFenceStyle(Button button, Style value)
        {
            button.SetValue(ThumbFenceStyleProperty, value);
        }

        public static readonly DependencyProperty ThumbFenceStyleProperty =
            DependencyProperty.RegisterAttached("ThumbFenceStyle", typeof(Style), typeof(ColorSelector));
        #endregion

        #region SliderStyle
        public static Style GetSliderStyle(Button button)
        {
            return (Style)button.GetValue(SliderStyleProperty);
        }

        public static void SetSliderStyle(Button button, Style value)
        {
            button.SetValue(SliderStyleProperty, value);
        }

        public static readonly DependencyProperty SliderStyleProperty =
            DependencyProperty.RegisterAttached("SliderStyle", typeof(Style), typeof(ColorSelector));
        #endregion

        #region InputTextBoxStyle
        public static Style GetInputTextBoxStyle(Button button)
        {
            return (Style)button.GetValue(InputTextBoxStyleProperty);
        }

        public static void SetInputTextBoxStyle(Button button, Style value)
        {
            button.SetValue(InputTextBoxStyleProperty, value);
        }

        public static readonly DependencyProperty InputTextBoxStyleProperty =
            DependencyProperty.RegisterAttached("InputTextBoxStyle", typeof(Style), typeof(ColorSelector));
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

            _aTextBox = GetTemplateChild(ATextBoxTemplateName) as TextBox;
            _aTextBox.TextChanged += TextBox_TextChanged;

            _rTextBox = GetTemplateChild(RTextBoxTemplateName) as TextBox;
            _rTextBox.TextChanged += TextBox_TextChanged;

            _gTextBox = GetTemplateChild(GTextBoxTemplateName) as TextBox;
            _gTextBox.TextChanged += TextBox_TextChanged;

            _bTextBox = GetTemplateChild(BTextBoxTemplateName) as TextBox;
            _bTextBox.TextChanged += TextBox_TextChanged;

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
            selector.RaiseEvent(new SelectedValueChangedEventArgs<Color>(SelectedColorChangedEvent, (Color)e.OldValue, (Color)e.NewValue));
        }

        private static void OnColorChannelsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var selector = (ColorSelector)d;
            selector.UpdateHEXTextBoxText();
        }

        private void ThumbFence_ThumbPositionChanging(object sender, PositionChangingEventArgs e)
        {

        }

        private void ThumbFence_PositionChanged(object sender, Core.PositionChangedEventArgs e)
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

            if (textBox.Tag is string tag && tag == "HEX")
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

                    switch (textBox.Tag)
                    {
                        case "HEX":

                            break;
                        case "A":
                            if (!_isInternalSetOpacitySlider)
                            {
                                if (int.TryParse(textBox.Text, out int a))
                                {
                                    var byteA = (byte)Math.Min(255, Math.Max(0, a));
                                    selectedColor.A = byteA;
                                }
                            }
                            break;
                        case "R":
                            if (int.TryParse(textBox.Text, out int r))
                            {
                                var byteR = (byte)Math.Min(255, Math.Max(0, r));
                                selectedColor.R = byteR;
                            }
                            break;
                        case "G":
                            if (int.TryParse(textBox.Text, out int g))
                            {
                                var byteG = (byte)Math.Min(255, Math.Max(0, g));
                                selectedColor.G = byteG;
                            }
                            break;
                        case "B":
                            if (int.TryParse(textBox.Text, out int b))
                            {
                                var byteB = (byte)Math.Min(255, Math.Max(0, b));
                                selectedColor.B = byteB;
                            }
                            break;
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

            var opacity = 1 - (_opacitySlider.Value / 100d);
            selectedColor.A = (byte)(opacity * 255);

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
            if (_aTextBox == null
                || _rTextBox == null
                || _gTextBox == null
                || _bTextBox == null
                || _isInternalSetARGBTextBox)
            {
                return;
            }

            _isInternalSetARGBTextBox = true;

            var selectedColor = SelectedColor;

            _aTextBox.Text = selectedColor.A.ToString();
            _rTextBox.Text = selectedColor.R.ToString();
            _gTextBox.Text = selectedColor.G.ToString();
            _bTextBox.Text = selectedColor.B.ToString();

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
