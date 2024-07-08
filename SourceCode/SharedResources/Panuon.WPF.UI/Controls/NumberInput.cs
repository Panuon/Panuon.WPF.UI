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
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(NumberInput));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(NumberInput));
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

        #region UpDownButtonVisibility
        public AuxiliaryButtonVisibility UpDownButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(UpDownButtonVisibilityProperty); }
            set { SetValue(UpDownButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty UpDownButtonVisibilityProperty =
            DependencyProperty.Register("UpDownButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(NumberInput), new PropertyMetadata(AuxiliaryButtonVisibility.Visible));
        #endregion

        #region UpDownButtonStyle
        public static Style GetUpDownButtonStyle(NumberInput numberInput)
        {
            return (Style)numberInput.GetValue(UpDownButtonStyleProperty);
        }

        public static void SetUpDownButtonStyle(NumberInput numberInput, Style value)
        {
            numberInput.SetValue(UpDownButtonStyleProperty, value);
        }

        public static readonly DependencyProperty UpDownButtonStyleProperty =
            DependencyProperty.RegisterAttached("UpDownButtonStyle", typeof(Style), typeof(NumberInput));
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
        public double? Value
        {
            get { return (double?)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double?), typeof(NumberInput), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnValueChanged, OnValueCoerceValue));
        #endregion

        #region DefaultValue
        public double? DefaultValue
        {
            get { return (double?)GetValue(DefaultValueProperty); }
            set { SetValue(DefaultValueProperty, value); }
        }

        public static readonly DependencyProperty DefaultValueProperty =
            DependencyProperty.Register("DefaultValue", typeof(double?), typeof(NumberInput), new PropertyMetadata(0d));
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
            DependencyProperty.Register("IsSnapToIntervalEnabled", typeof(bool), typeof(NumberInput), new PropertyMetadata(true
                ));
        #endregion

        #region IsReadOnly
        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(NumberInput));
        #endregion

        #region SelectAllOnFocus
        public bool SelectAllOnFocus
        {
            get { return (bool)GetValue(SelectAllOnFocusProperty); }
            set { SetValue(SelectAllOnFocusProperty, value); }
        }

        public static readonly DependencyProperty SelectAllOnFocusProperty =
            DependencyProperty.Register("SelectAllOnFocus", typeof(bool), typeof(NumberInput));
        #endregion

        #region ClearButtonStyle
        public static Style GetClearButtonStyle(NumberInput dateTimePicker)
        {
            return (Style)dateTimePicker.GetValue(ClearButtonStyleProperty);
        }

        public static void SetClearButtonStyle(NumberInput dateTimePicker, Style value)
        {
            dateTimePicker.SetValue(ClearButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ClearButtonStyleProperty =
            DependencyProperty.RegisterAttached("ClearButtonStyle", typeof(Style), typeof(NumberInput));
        #endregion

        #region ClearButtonVisibility
        public AuxiliaryButtonVisibility ClearButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(ClearButtonVisibilityProperty); }
            set { SetValue(ClearButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.Register("ClearButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(NumberInput));
        #endregion

        #region ClearCommand
        internal ICommand ClearCommand
        {
            get { return (ICommand)GetValue(ClearCommandProperty); }
        }

        internal static readonly DependencyPropertyKey ClearCommandPropertyKey =
            DependencyProperty.RegisterReadOnly("ClearCommand", typeof(ICommand), typeof(NumberInput), new PropertyMetadata(new RelayCommand<NumberInput>(OnClearCommandExecute)));

        public static readonly DependencyProperty ClearCommandProperty =
            ClearCommandPropertyKey.DependencyProperty;
        #endregion

        #region UpCommand
        public ICommand UpCommand
        {
            get { return (ICommand)GetValue(UpCommandProperty); }
        }

        public static readonly DependencyPropertyKey UpCommandPropertyKey =
            DependencyProperty.RegisterReadOnly("UpCommand", typeof(ICommand), typeof(NumberInput), new PropertyMetadata(new RelayCommand<NumberInput>(OnUpCommandExecute)));

        public static readonly DependencyProperty UpCommandProperty =
            UpCommandPropertyKey.DependencyProperty;
        #endregion

        #region DownCommand
        public ICommand DownCommand
        {
            get { return (ICommand)GetValue(DownCommandProperty); }
        }

        public static readonly DependencyPropertyKey DownCommandPropertyKey =
            DependencyProperty.RegisterReadOnly("DownCommand", typeof(ICommand), typeof(NumberInput), new PropertyMetadata(new RelayCommand<NumberInput>(OnDownCommandExecute)));

        public static readonly DependencyProperty DownCommandProperty =
            DownCommandPropertyKey.DependencyProperty;
        #endregion

        #region StepFactor
        public int StepFactor
        {
            get { return (int)GetValue(StepFactorProperty); }
            set { SetValue(StepFactorProperty, value); }
        }

        public static readonly DependencyProperty StepFactorProperty =
            DependencyProperty.Register("StepFactor", typeof(int), typeof(NumberInput), new PropertyMetadata(1));
        #endregion

        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey UpDownButtonStyleKey { get; }
            = new ComponentResourceKey(typeof(NumberInput), nameof(UpDownButtonStyleKey));

        public static ComponentResourceKey ClearButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(NumberInput), nameof(ClearButtonStyleKey));
        #endregion

        #region Event

        #region ValueChanged
        public event SelectedValueChangedRoutedEventHandler<double?> ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        public static readonly RoutedEvent ValueChangedEvent =
            EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedRoutedEventHandler<double?>), typeof(NumberInput));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _inputTextBox = GetTemplateChild(InputTextBoxTemplateName) as TextBox;
            _inputTextBox.TextChanged += InputTextBox_TextChanged;

            UpdateTextFromValue();
        }

        protected override void OnGotFocus(RoutedEventArgs e)
        {
            if (!e.Handled)
            {
                if (e.OriginalSource == this)
                {
                    _inputTextBox?.Focus();
                    e.Handled = true;
                }
                else if (e.OriginalSource == _inputTextBox)
                {
                    _inputTextBox.SelectAll();
                }
            }
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(RoutedEventArgs e)
        {
            CoerceValue(ValueProperty);
            UpdateTextFromValue();

            base.OnLostFocus(e);
        }
        #endregion

        #region Event Handlers
        private static object OnValueCoerceValue(DependencyObject d, object baseValue)
        {
            var numberInput = (NumberInput)d;
            if (baseValue is double value)
            {
                if (value < numberInput.Minimum)
                {
                    return numberInput.Minimum;
                }
                if (value > numberInput.Maximum)
                {
                    return numberInput.Maximum;
                }
                if (numberInput.IsSnapToIntervalEnabled)
                { 
                    var interval = (decimal)numberInput.Interval;
                    var newValue = (double)(((decimal)Math.Ceiling((decimal)value / interval)) * (decimal)interval);
                    return newValue;
                }
                return value;
            }
            return baseValue;
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var numberInput = (NumberInput)d;
            numberInput.OnValueChanged((double?)e.OldValue, (double?)e.NewValue);
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

        private static void OnClearCommandExecute(NumberInput numberInput)
        {
            numberInput.Reset();
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
        public void Reset()
        {
            SetCurrentValue(ValueProperty, DefaultValue);
        }
        public void Up()
        {
            var value = Value ?? 0;
            SetCurrentValue(ValueProperty, Math.Max(Minimum, Math.Min(Maximum, value + Interval * StepFactor)));
        }

        public void Down()
        {
            var value = Value ?? 0;
            SetCurrentValue(ValueProperty, Math.Max(Minimum, Math.Min(Maximum, value - Interval * StepFactor)));
        }
        #endregion

        #region Functions
        private void OnValueChanged(double? oldValue,
            double? newValue)
        {
            UpdateTextFromValue();
            RaiseEvent(new SelectedValueChangedRoutedEventArgs<double?>(ValueChangedEvent, oldValue, newValue));
        }

        private void UpdateTextFromValue()
        {
            if (_isInternalSet
                || _inputTextBox == null)
            {
                return;
            }

            try
            {
                _isInternalSet = true;
                _inputTextBox.Text = Value == null
                    ? null
                    : FormatValueText();
            }
            finally
            {
                _isInternalSet = false;
            }
        }

        private void UpdateValueFromText()
        {
            if (_inputTextBox == null)
            {
                return;
            }

            if (_isInternalSet)
            {
                return;
            }

            _isInternalSet = true;

            if (string.IsNullOrWhiteSpace(_inputTextBox.Text))
            {
                SetCurrentValue(ValueProperty, DefaultValue);
            }
            else if (decimal.TryParse(_inputTextBox.Text, out decimal decimalValue))
            {
                var doubleValue = (double)decimalValue;
                SetCurrentValue(ValueProperty, doubleValue);
                if (Value != doubleValue)
                {
                    _inputTextBox.Text = Value == null
                        ? null
                        : FormatValueText();
                }
            }
            else if (double.TryParse(_inputTextBox.Text, out double doubleValue))
            {
                SetCurrentValue(ValueProperty, doubleValue);
                if (Value != doubleValue)
                {
                    _inputTextBox.Text = Value == null
                        ? null
                        : FormatValueText();
                }
            }

            _isInternalSet = false;
        }

        private string FormatValueText()
        {
            var stringFormat = "0";
            var digits = GetRoundDigits();
            if(digits > 0)
            {
                stringFormat = stringFormat + '.' + new string('0', digits);
            }
            return ((double)Value).ToString(stringFormat);
        }

        private int GetRoundDigits()
        {
            if (IsSnapToIntervalEnabled
                || Value == null || double.IsNaN((double)Value) || double.IsInfinity((double)Value))
            {
                return GetNumberRoundDigits(Interval);
            }
            else
            {
                return Math.Max(GetNumberRoundDigits(Interval),
                    GetNumberRoundDigits((double)Value));
            }
        }

        private int GetNumberRoundDigits(double number)
        {
            var text = number.ToString();
            var index = text.IndexOf('.');
            return index != -1
                ? text.Length - index - 1
                : 0;
        }
        #endregion
    }
}
