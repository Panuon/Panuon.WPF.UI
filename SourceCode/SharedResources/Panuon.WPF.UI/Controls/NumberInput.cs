using Panuon.WPF.UI.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class NumberInput
        : Control
    {
        #region Fields
        private const string InputTextBoxTemplateName = "PART_InputTextBox";

        private TextBox _inputTextBox;

        private bool _isInternalSet;
        #endregion

        #region Ctor
        static NumberInput()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumberInput), new FrameworkPropertyMetadata(typeof(NumberInput)));
        }
        #endregion

        #region Properties

        #region Icon
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(NumberInput));
        #endregion

        #region Watermark
        public object Watermark
        {
            get { return (object)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark", typeof(object), typeof(NumberInput));
        #endregion

        #region WatermarkForeground
        public Brush WatermarkForeground
        {
            get { return (Brush)GetValue(WatermarkForegroundProperty); }
            set { SetValue(WatermarkForegroundProperty, value); }
        }

        public static readonly DependencyProperty WatermarkForegroundProperty =
            VisualStateHelper.WatermarkForegroundProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.Register("ShadowColor", typeof(Color?), typeof(NumberInput));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(NumberInput));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region HoverBorderThickness
        public Thickness? HoverBorderThickness
        {
            get { return (Thickness?)GetValue(HoverBorderThicknessProperty); }
            set { SetValue(HoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region HoverCornerRadius
        public CornerRadius? HoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(HoverCornerRadiusProperty); }
            set { SetValue(HoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region FocusedBackground
        public Brush FocusedBackground
        {
            get { return (Brush)GetValue(FocusedBackgroundProperty); }
            set { SetValue(FocusedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedBackgroundProperty =
            VisualStateHelper.FocusedBackgroundProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region FocusedForeground
        public Brush FocusedForeground
        {
            get { return (Brush)GetValue(FocusedForegroundProperty); }
            set { SetValue(FocusedForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedForegroundProperty =
            VisualStateHelper.FocusedForegroundProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region FocusedBorderBrush
        public Brush FocusedBorderBrush
        {
            get { return (Brush)GetValue(FocusedBorderBrushProperty); }
            set { SetValue(FocusedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            VisualStateHelper.FocusedBorderBrushProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region FocusedBorderThickness
        public Thickness? FocusedBorderThickness
        {
            get { return (Thickness?)GetValue(FocusedBorderThicknessProperty); }
            set { SetValue(FocusedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty FocusedBorderThicknessProperty =
            VisualStateHelper.FocusedBorderThicknessProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region FocusedCornerRadius
        public CornerRadius? FocusedCornerRadius
        {
            get { return (CornerRadius?)GetValue(FocusedCornerRadiusProperty); }
            set { SetValue(FocusedCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty FocusedCornerRadiusProperty =
            VisualStateHelper.FocusedCornerRadiusProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region FocusedShadowColor
        public Color? FocusedShadowColor
        {
            get { return (Color?)GetValue(FocusedShadowColorProperty); }
            set { SetValue(FocusedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty FocusedShadowColorProperty =
            VisualStateHelper.FocusedShadowColorProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region FocusedWatermarkForeground
        public Brush FocusedWatermarkForeground
        {
            get { return (Brush)GetValue(FocusedWatermarkForegroundProperty); }
            set { SetValue(FocusedWatermarkForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedWatermarkForegroundProperty =
            VisualStateHelper.FocusedWatermarkForegroundProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region UpDownButtonStyle
        public Style UpDownButtonStyle
        {
            get { return (Style)GetValue(UpDownButtonStyleProperty); }
            set { SetValue(UpDownButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty UpDownButtonStyleProperty =
            DependencyProperty.Register("UpDownButtonStyle", typeof(Style), typeof(NumberInput));
        #endregion

        #region UpDownButtonsOrientation
        public Orientation UpDownButtonsOrientation
        {
            get { return (Orientation)GetValue(UpDownButtonsOrientationProperty); }
            set { SetValue(UpDownButtonsOrientationProperty, value); }
        }

        public static readonly DependencyProperty UpDownButtonsOrientationProperty =
            DependencyProperty.Register("UpDownButtonsOrientation", typeof(Orientation), typeof(NumberInput));
        #endregion

        #region Value
        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(NumberInput), new PropertyMetadata(0d, OnValueChanged, OnValueCoerceValue));
        #endregion

        #region Maximum
        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(double), typeof(NumberInput), new PropertyMetadata(double.MaxValue, OnMaximumOrMinimumChanged));
        #endregion

        #region Minimum
        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(double), typeof(NumberInput), new PropertyMetadata(double.MinValue));
        #endregion

        #region Interval
        public double Interval
        {
            get { return (double)GetValue(IntervalProperty); }
            set { SetValue(IntervalProperty, value); }
        }

        public static readonly DependencyProperty IntervalProperty =
            DependencyProperty.Register("Interval", typeof(double), typeof(NumberInput), new PropertyMetadata(1d));
        #endregion

        #region IsSnapToIntervalEnabled
        public bool IsSnapToIntervalEnabled
        {
            get { return (bool)GetValue(IsSnapToIntervalEnabledProperty); }
            set { SetValue(IsSnapToIntervalEnabledProperty, value); }
        }

        public static readonly DependencyProperty IsSnapToIntervalEnabledProperty =
            DependencyProperty.Register("IsSnapToIntervalEnabled", typeof(bool), typeof(NumberInput));
        #endregion

        #region UpCommand
        internal ICommand UpCommand
        {
            get { return (ICommand)GetValue(UpCommandProperty); }
        }

        internal static readonly DependencyPropertyKey UpCommandPropertyKey =
            DependencyProperty.RegisterReadOnly("UpCommand", typeof(ICommand), typeof(NumberInput), new PropertyMetadata(new RelayCommand<NumberInput>(OnUpCommandExecute)));

        public static readonly DependencyProperty UpCommandProperty =
            UpCommandPropertyKey.DependencyProperty;
        #endregion

        #region DownCommand
        internal ICommand DownCommand
        {
            get { return (ICommand)GetValue(DownCommandProperty); }
        }

        internal static readonly DependencyPropertyKey DownCommandPropertyKey =
            DependencyProperty.RegisterReadOnly("DownCommand", typeof(ICommand), typeof(NumberInput), new PropertyMetadata(new RelayCommand<NumberInput>(OnDownCommandExecute)));

        public static readonly DependencyProperty DownCommandProperty =
            DownCommandPropertyKey.DependencyProperty;
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _inputTextBox = GetTemplateChild(InputTextBoxTemplateName) as TextBox;
            _inputTextBox.TextChanged += InputTextBox_TextChanged;
            _inputTextBox.LostKeyboardFocus += InputTextBox_LostKeyboardFocus;

            UpdateTextFromValue();
        }
        #endregion

        #region Event Handlers
        private static object OnValueCoerceValue(DependencyObject d, object baseValue)
        {
            var numberInput = (NumberInput)d;
            var value = (double)baseValue;
            if(value < numberInput.Minimum)
            {
                return numberInput.Minimum;
            }
            if(value > numberInput.Maximum)
            {
                return numberInput.Maximum;
            }
            if (numberInput.IsSnapToIntervalEnabled)
            {
                var newValue = (value / numberInput.Interval) * numberInput.Interval;
                return newValue;
            }
            return value;
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var numberInput = (NumberInput)d;
            numberInput.OnValueChanged();
        }

        private static void OnMaximumOrMinimumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var numberInput = (NumberInput)d;
            numberInput.CoerceValue(ValueProperty);
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateValueFromText();
        }

        private void InputTextBox_LostKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            CoerceValue(ValueProperty);
            UpdateTextFromValue();
        }

        private static void OnUpCommandExecute(NumberInput numberInput)
        {
            numberInput.Up();
        }


        private static void OnDownCommandExecute(NumberInput numberInput)
        {
            numberInput.Down();
        }

        #endregion

        #region Methods
        public void Up()
        {
            SetValue(ValueProperty, Value + Interval);
        }

        public void Down()
        {
            SetValue(ValueProperty, Value - Interval);
        }
        #endregion

        #region Functions
        private void OnValueChanged()
        {
            UpdateTextFromValue();
        }

        private void UpdateTextFromValue()
        {
            if (_inputTextBox == null)
            {
                return;
            }

            _inputTextBox.Text = Value.ToString();

        }

        private void UpdateValueFromText()
        {
            if (_inputTextBox == null)
            {
                return;
            }

            if (double.TryParse(_inputTextBox.Text, out double doubleValue))
            {
                SetCurrentValue(ValueProperty, doubleValue);
                if(Value != doubleValue)
                {
                    UpdateTextFromValue();
                }
            }
        }
        #endregion
    }
}
