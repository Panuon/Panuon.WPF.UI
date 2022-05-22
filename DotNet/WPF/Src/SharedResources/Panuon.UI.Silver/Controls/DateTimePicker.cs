using Panuon.UI.Core;
using Panuon.UI.Silver.Internal;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = CalendarXTemplateName, Type = typeof(CalendarX))]
    [TemplatePart(Name = EditableTextBoxTemplateName, Type = typeof(TextBox))]
    public class DateTimePicker : Control
    {
        #region Fields
        private const string CalendarXTemplateName = "PART_CalendarX";
        private const string TimeSelectorCalendarXTemplateName = "PART_TimeSelector";
        private const string EditableTextBoxTemplateName = "PART_EditableTextBox";
        private const string PopupXTemplateName = "PART_PopupX";

        private CalendarX _calendarX;
        private TimeSelector _timeSelector;
        private TextBox _editableTextBox;
        private PopupX _popupX;

        private bool _isInternalUpdateSelectedDate;
        private bool _isInternalUpdateSelectedTime;
        private bool _isInternalUpdateTextBox;
        #endregion

        #region Ctor
        static DateTimePicker()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DateTimePicker), new FrameworkPropertyMetadata(typeof(DateTimePicker)));

            EventManager.RegisterClassHandler(typeof(DateTimePicker), Mouse.LostMouseCaptureEvent, new MouseEventHandler(OnLostMouseCapture));
            EventManager.RegisterClassHandler(typeof(DateTimePicker), Mouse.MouseDownEvent, new MouseButtonEventHandler(OnMouseButtonDown));
            EventManager.RegisterClassHandler(typeof(DateTimePicker), Mouse.PreviewMouseDownEvent, new MouseButtonEventHandler(OnPreviewMouseButtonDown));
            EventManager.RegisterClassHandler(typeof(DateTimePicker), UIElement.GotFocusEvent, new RoutedEventHandler(OnThisGotFocus));
        }
        #endregion

        #region Events

        #region SelectedDateTimeChanged
        public event SelectedValueChangedEventHandler<DateTime?> SelectedDateTimeChanged
        {
            add { AddHandler(SelectedDateTimeChangedEvent, value); }
            remove { RemoveHandler(SelectedDateTimeChangedEvent, value); }
        }

        public static readonly RoutedEvent SelectedDateTimeChangedEvent =
            EventManager.RegisterRoutedEvent("SelectedDateTimeChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedEventHandler<DateTime?>), typeof(DateTimePicker));
        #endregion

        public event EventHandler Closed;

        public event EventHandler Opened;

        #endregion

        #region Properties

        #region Culture
        public CultureInfo Culture
        {
            get { return (CultureInfo)GetValue(CultureProperty); }
            set { SetValue(CultureProperty, value); }
        }

        public static readonly DependencyProperty CultureProperty =
            DependencyProperty.Register("Culture", typeof(CultureInfo), typeof(DateTimePicker));
        #endregion

        #region Icon
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(DateTimePicker));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(DateTimePicker));
        #endregion

        #region FirstDayOfWeek
        public DayOfWeek FirstDayOfWeek
        {
            get { return (DayOfWeek)GetValue(FirstDayOfWeekProperty); }
            set { SetValue(FirstDayOfWeekProperty, value); }
        }

        public static readonly DependencyProperty FirstDayOfWeekProperty =
            DependencyProperty.Register("FirstDayOfWeek", typeof(DayOfWeek), typeof(DateTimePicker), new PropertyMetadata(DayOfWeek.Sunday));
        #endregion

        #region Watermark
        public object Watermark
        {
            get { return (object)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark", typeof(object), typeof(DateTimePicker));
        #endregion

        #region WatermarkForeground
        public Brush WatermarkForeground
        {
            get { return (Brush)GetValue(WatermarkForegroundProperty); }
            set { SetValue(WatermarkForegroundProperty, value); }
        }

        public static readonly DependencyProperty WatermarkForegroundProperty =
            VisualStateHelper.WatermarkForegroundProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region MinDateTime
        public DateTime MinDateTime
        {
            get { return (DateTime)GetValue(MinDateTimeProperty); }
            set { SetValue(MinDateTimeProperty, value); }
        }

        public static readonly DependencyProperty MinDateTimeProperty =
            DependencyProperty.Register("MinDateTime", typeof(DateTime), typeof(DateTimePicker), new PropertyMetadata(DateTime.MinValue, OnDateTimeLimitChanged));
        #endregion

        #region MaxDateTime
        public DateTime MaxDateTime
        {
            get { return (DateTime)GetValue(MaxDateTimeProperty); }
            set { SetValue(MaxDateTimeProperty, value); }
        }

        public static readonly DependencyProperty MaxDateTimeProperty =
            DependencyProperty.Register("MaxDateTime", typeof(DateTime), typeof(DateTimePicker), new PropertyMetadata(DateTime.MaxValue, OnDateTimeLimitChanged));
        #endregion

        #region YearStringFormat
        public string YearStringFormat
        {
            get { return (string)GetValue(YearStringFormatProperty); }
            set { SetValue(YearStringFormatProperty, value); }
        }

        public static readonly DependencyProperty YearStringFormatProperty =
            DependencyProperty.Register("YearStringFormat", typeof(string), typeof(DateTimePicker), new PropertyMetadata("0000"));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region FocusedBackground
        public Brush FocusedBackground
        {
            get { return (Brush)GetValue(FocusedBackgroundProperty); }
            set { SetValue(FocusedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedBackgroundProperty =
            VisualStateHelper.FocusedBackgroundProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region FocusedForeground
        public Brush FocusedForeground
        {
            get { return (Brush)GetValue(FocusedForegroundProperty); }
            set { SetValue(FocusedForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedForegroundProperty =
            VisualStateHelper.FocusedForegroundProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region FocusedBorderBrush
        public Brush FocusedBorderBrush
        {
            get { return (Brush)GetValue(FocusedBorderBrushProperty); }
            set { SetValue(FocusedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            VisualStateHelper.FocusedBorderBrushProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region FocusedShadowColor
        public Color? FocusedShadowColor
        {
            get { return (Color?)GetValue(FocusedShadowColorProperty); }
            set { SetValue(FocusedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty FocusedShadowColorProperty =
            VisualStateHelper.FocusedShadowColorProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region FocusedWatermarkForeground
        public Brush FocusedWatermarkForeground
        {
            get { return (Brush)GetValue(FocusedWatermarkForegroundProperty); }
            set { SetValue(FocusedWatermarkForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedWatermarkForegroundProperty =
            VisualStateHelper.FocusedWatermarkForegroundProperty.AddOwner(typeof(DateTimePicker));
        #endregion

        #region DateTimeSeparatorVisibility
        public Visibility DateTimeSeparatorVisibility
        {
            get { return (Visibility)GetValue(DateTimeSeparatorVisibilityProperty); }
            set { SetValue(DateTimeSeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty DateTimeSeparatorVisibilityProperty =
            DependencyProperty.Register("DateTimeSeparatorVisibility", typeof(Visibility), typeof(DateTimePicker));
        #endregion

        #region DateTimeSeparatorBrush
        public Brush DateTimeSeparatorBrush
        {
            get { return (Brush)GetValue(DateTimeSeparatorBrushProperty); }
            set { SetValue(DateTimeSeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty DateTimeSeparatorBrushProperty =
            DependencyProperty.Register("DateTimeSeparatorBrush", typeof(Brush), typeof(DateTimePicker));
        #endregion

        #region DateTimeSeparatorMargin
        public Thickness DateTimeSeparatorMargin
        {
            get { return (Thickness)GetValue(DateTimeSeparatorMarginProperty); }
            set { SetValue(DateTimeSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty DateTimeSeparatorMarginProperty =
            DependencyProperty.Register("DateTimeSeparatorMargin", typeof(Thickness), typeof(DateTimePicker));
        #endregion

        #region DateTimeSeparatorThickness
        public double DateTimeSeparatorThickness
        {
            get { return (double)GetValue(DateTimeSeparatorThicknessProperty); }
            set { SetValue(DateTimeSeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty DateTimeSeparatorThicknessProperty =
            DependencyProperty.Register("DateTimeSeparatorThickness", typeof(double), typeof(DateTimePicker));
        #endregion

        #region Text
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(DateTimePicker));
        #endregion

        #region TextFormats
        public string TextStringFormat
        {
            get { return (string)GetValue(TextStringFormatProperty); }
            set { SetValue(TextStringFormatProperty, value); }
        }

        public static readonly DependencyProperty TextStringFormatProperty =
            DependencyProperty.Register("TextStringFormat", typeof(string), typeof(DateTimePicker), new PropertyMetadata("dd/MM/yyyy HH:mm:ss", OnTextFormatChanged));
        #endregion

        #region InputTextStringFormat
        public string InputTextStringFormat
        {
            get { return (string)GetValue(InputTextStringFormatProperty); }
            set { SetValue(InputTextStringFormatProperty, value); }
        }

        public static readonly DependencyProperty InputTextStringFormatProperty =
            DependencyProperty.Register("InputTextStringFormat", typeof(string), typeof(DateTimePicker));
        #endregion

        #region IsDropDownOpen
        public bool IsDropDownOpen
        {
            get { return (bool)GetValue(IsDropDownOpenProperty); }
            set { SetValue(IsDropDownOpenProperty, value); }
        }

        public static readonly DependencyProperty IsDropDownOpenProperty =
            DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(DateTimePicker), new PropertyMetadata(OnIsDropDownOpenChanged));
        #endregion

        #region IsEditable
        public bool IsEditable
        {
            get { return (bool)GetValue(IsEditableProperty); }
            set { SetValue(IsEditableProperty, value); }
        }

        public static readonly DependencyProperty IsEditableProperty =
            DependencyProperty.Register("IsEditable", typeof(bool), typeof(DateTimePicker));
        #endregion

        #region StaysOpen
        public bool StaysOpen
        {
            get { return (bool)GetValue(StaysOpenProperty); }
            set { SetValue(StaysOpenProperty, value); }
        }

        public static readonly DependencyProperty StaysOpenProperty =
            DependencyProperty.Register("StaysOpen", typeof(bool), typeof(DateTimePicker));
        #endregion

        #region DateTimePickerMode
        public DateTimePickerMode Mode
        {
            get { return (DateTimePickerMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(DateTimePickerMode), typeof(DateTimePicker), new PropertyMetadata(DateTimePickerMode.Date, OnDateTimePickerModeChanged));
        #endregion

        #region SelectedDateTime
        public DateTime? SelectedDateTime
        {
            get { return (DateTime?)GetValue(SelectedDateTimeProperty); }
            set { SetValue(SelectedDateTimeProperty, value); }
        }

        public static readonly DependencyProperty SelectedDateTimeProperty =
            DependencyProperty.Register("SelectedDateTime", typeof(DateTime?), typeof(DateTimePicker), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSelectedDateTimeChanged));

        #endregion

        #region DefaultDateTime
        public DateTime? DefaultDateTime
        {
            get { return (DateTime?)GetValue(DefaultDateTimeProperty); }
            set { SetValue(DefaultDateTimeProperty, value); }
        }

        public static readonly DependencyProperty DefaultDateTimeProperty =
            DependencyProperty.Register("DefaultDateTime", typeof(DateTime?), typeof(DateTimePicker), new PropertyMetadata(null));
        #endregion

        #region FocusToEditor
        public bool FocusToEditor
        {
            get { return (bool)GetValue(FocusToEditorProperty); }
            set { SetValue(FocusToEditorProperty, value); }
        }

        public static readonly DependencyProperty FocusToEditorProperty =
            DependencyProperty.Register("FocusToEditor", typeof(bool), typeof(DateTimePicker), new PropertyMetadata(OnFocusToEditorChanged));
        #endregion

        #region CalendarXStyle
        public Style CalendarXStyle
        {
            get { return (Style)GetValue(CalendarXStyleProperty); }
            set { SetValue(CalendarXStyleProperty, value); }
        }

        public static readonly DependencyProperty CalendarXStyleProperty =
            DependencyProperty.Register("CalendarXStyle", typeof(Style), typeof(DateTimePicker));
        #endregion

        #region TimeSelectorStyle
        public Style TimeSelectorStyle
        {
            get { return (Style)GetValue(TimeSelectorStyleProperty); }
            set { SetValue(TimeSelectorStyleProperty, value); }
        }

        public static readonly DependencyProperty TimeSelectorStyleProperty =
            DependencyProperty.Register("TimeSelectorStyle", typeof(Style), typeof(DateTimePicker));
        #endregion

        #region ToggleArrowTransformControlStyle
        public Style ToggleArrowTransformControlStyle
        {
            get { return (Style)GetValue(ToggleArrowTransformControlStyleProperty); }
            set { SetValue(ToggleArrowTransformControlStyleProperty, value); }
        }

        public static readonly DependencyProperty ToggleArrowTransformControlStyleProperty =
            DependencyProperty.Register("ToggleArrowTransformControlStyle", typeof(Style), typeof(DateTimePicker));
        #endregion

        #region ClearButtonStyle
        public Style ClearButtonStyle
        {
            get { return (Style)GetValue(ClearButtonStyleProperty); }
            set { SetValue(ClearButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty ClearButtonStyleProperty =
            DependencyProperty.Register("ClearButtonStyle", typeof(Style), typeof(DateTimePicker));
        #endregion

        #region ClearButtonVisibility
        public AuxiliaryButtonVisibility ClearButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(ClearButtonVisibilityProperty); }
            set { SetValue(ClearButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.Register("ClearButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(DateTimePicker));
        #endregion

        #region ClearCommand
        internal ICommand ClearCommand
        {
            get { return (ICommand)GetValue(ClearCommandProperty); }
        }

        internal static readonly DependencyPropertyKey ClearCommandPropertyKey =
            DependencyProperty.RegisterReadOnly("ClearCommand", typeof(ICommand), typeof(DateTimePicker), new PropertyMetadata(new RelayCommand<DateTimePicker>(OnClearCommandExecute)));

        public static readonly DependencyProperty ClearCommandProperty =
            ClearCommandPropertyKey.DependencyProperty;
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _calendarX = GetTemplateChild(CalendarXTemplateName) as CalendarX;
            _calendarX.SelectedDateChanged += CalendarX_SelectedDateTimeChanged;

            _timeSelector = GetTemplateChild(TimeSelectorCalendarXTemplateName) as TimeSelector;
            _timeSelector.SelectedTimeChanged += TimeSelector_SelectedTimeChanged;

            _editableTextBox = GetTemplateChild(EditableTextBoxTemplateName) as TextBox;
            _editableTextBox.TextChanged += EditableTextBox_TextChanged;

            _popupX = GetTemplateChild(PopupXTemplateName) as PopupX;
            _popupX.Opened += PopupX_Opened;
            _popupX.Closed += PopupX_Closed;

            UpdateCalendarXSelectedDate();
            UpdateTimeSelectorSelectedTime();
            UpdateTimeSelectorTimeLimit();
            UpdateText();
        }
        #endregion

        #region Event Handlers
        private static void OnFocusToEditorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)d;
            dateTimePicker.GotFocus -= DateTimePicker_GotFocus;

            if ((bool)e.NewValue)
            {
                dateTimePicker.GotFocus -= DateTimePicker_GotFocus;
                dateTimePicker.GotFocus += DateTimePicker_GotFocus;
            }
        }

        private static void DateTimePicker_GotFocus(object sender, RoutedEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.IsEditable)
            {
                if (dateTimePicker._editableTextBox != null)
                {
                    dateTimePicker._editableTextBox.Focus();
                    dateTimePicker._editableTextBox.SelectionStart = dateTimePicker._editableTextBox.Text.Length;
                }
            }
        }

        private static void OnDateTimeLimitChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)d;
            dateTimePicker.CoerceValue(SelectedDateTimeProperty);
            dateTimePicker.UpdateCalendarXSelectedDate();
            dateTimePicker.UpdateTimeSelectorSelectedTime();
            dateTimePicker.UpdateTimeSelectorTimeLimit();

        }

        private static void OnTextFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)d;
            dateTimePicker.UpdateText();
        }

        private static void OnDateTimePickerModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)d;
            dateTimePicker.UpdateText();
        }

        private static void OnIsDropDownOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)d;
            if ((bool)e.NewValue)
            {
                Mouse.Capture(dateTimePicker, CaptureMode.SubTree);
                if (dateTimePicker.IsEditable
                    && dateTimePicker._editableTextBox != null)
                {
                    dateTimePicker._editableTextBox.Focus();
                }
            }
            else
            {
                if (dateTimePicker.IsKeyboardFocusWithin)
                {
                    if (dateTimePicker.IsEditable)
                    {
                        if (dateTimePicker._editableTextBox != null
                            && !dateTimePicker._editableTextBox.IsKeyboardFocusWithin)
                        {
                            dateTimePicker.Focus();
                        }
                    }
                    else
                    {
                        dateTimePicker.Focus();
                    }
                }
                if (Mouse.Captured == dateTimePicker)
                {
                    Mouse.Capture(null);
                }
            }
        }

        private static void OnThisGotFocus(object sender, RoutedEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (!e.Handled)
            {
                if (dateTimePicker.IsEditable && dateTimePicker._editableTextBox != null)
                {
                    if (e.OriginalSource == dateTimePicker)
                    {
                        dateTimePicker._editableTextBox.Focus();
                        e.Handled = true;
                    }
                    else if (e.OriginalSource == dateTimePicker._editableTextBox)
                    {
                        dateTimePicker._editableTextBox.Focus();
                    }
                }
            }

        }

        private static void OnMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if ((dateTimePicker.ContextMenu == null || !dateTimePicker.ContextMenu.IsOpen)
                      && !dateTimePicker.IsKeyboardFocusWithin)
            {
                dateTimePicker.Focus();
            }

            if (Mouse.Captured == dateTimePicker
                && e.OriginalSource == dateTimePicker)
            {
                dateTimePicker.SetCurrentValue(IsDropDownOpenProperty, false);
            }
        }

        private static void OnPreviewMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.IsEditable)
            {
                var originalSource = e.OriginalSource as Visual;

                if (originalSource != null && dateTimePicker._editableTextBox != null
                    && dateTimePicker.IsAncestorOf(originalSource))
                {
                    if ((dateTimePicker.ContextMenu == null || !dateTimePicker.ContextMenu.IsOpen)
                        && !dateTimePicker.IsKeyboardFocusWithin)
                    {
                        dateTimePicker.Focus();
                    }
                }
            }
        }

        private static void OnLostMouseCapture(object sender ,MouseEventArgs e)
        {
             var dateTimePicker = (DateTimePicker)sender;
            if(e.OriginalSource == dateTimePicker._editableTextBox)
            {
                dateTimePicker.SetCurrentValue(IsDropDownOpenProperty, true);
                dateTimePicker._editableTextBox.Focus();
            }
            Debug.WriteLine(e.OriginalSource);
        }

        private static void OnSelectedDateTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dateTimePicker = (DateTimePicker)d;
            dateTimePicker.UpdateCalendarXSelectedDate();
            dateTimePicker.UpdateTimeSelectorSelectedTime();
            dateTimePicker.UpdateText();
            dateTimePicker.RaiseEvent(new SelectedValueChangedEventArgs<DateTime?>(SelectedDateTimeChangedEvent, (DateTime?)e.OldValue, (DateTime?)e.NewValue));
        }

        private void EditableTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_isInternalUpdateTextBox)
            {
                return;
            }

            _isInternalUpdateTextBox = true;

            SetCurrentValue(TextProperty, _editableTextBox.Text);

            UpdateSelectedDateTimeFromText();

            _isInternalUpdateTextBox = false;
        }

        private void PopupX_Closed(object sender, EventArgs e)
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }

        private void PopupX_Opened(object sender, EventArgs e)
        {
            Opened?.Invoke(this, EventArgs.Empty);
        }

        private static void OnClearCommandExecute(DateTimePicker dateTimePicker)
        {
            dateTimePicker.SetCurrentValue(TextProperty, null);
            dateTimePicker.SetCurrentValue(SelectedDateTimeProperty, dateTimePicker.DefaultDateTime);
        }

        private void CalendarX_SelectedDateTimeChanged(object sender, SelectedValueChangedEventArgs<DateTime> e)
        {
            UpdateSelectedDateTime();
            UpdateTimeSelectorTimeLimit();
        }


        private void TimeSelector_SelectedTimeChanged(object sender, SelectedValueChangedEventArgs<DateTime> e)
        {
            UpdateSelectedDateTime();
        }
        #endregion

        #region Functions
        private void UpdateCalendarXSelectedDate()
        {
            if (_calendarX == null
                || _isInternalUpdateSelectedDate)
            {
                return;
            }

            _isInternalUpdateSelectedDate = true;

            _calendarX.SetCurrentValue(CalendarX.SelectedDateProperty, SelectedDateTime ?? DefaultDateTime ?? DateTime.Now);

            _isInternalUpdateSelectedDate = false;
        }

        private void UpdateTimeSelectorSelectedTime()
        {
            if (_timeSelector == null
                || _isInternalUpdateSelectedTime)
            {
                return;
            }

            _isInternalUpdateSelectedTime = true;

            _timeSelector.SetCurrentValue(TimeSelector.SelectedTimeProperty, (SelectedDateTime ?? DefaultDateTime ?? DateTime.Now).GetTime());

            _isInternalUpdateSelectedTime = false;
        }

        private void UpdateText()
        {
            if(_editableTextBox == null)
            {
                return;
            }

            var nullableSelectedDateTime = SelectedDateTime;
            string text = null;

            if (nullableSelectedDateTime is DateTime selectedDateTime)
            {
                text = selectedDateTime.ToString(TextStringFormat);
            }

            SetCurrentValue(TextProperty, text);

            if (!_isInternalUpdateTextBox)
            {
                _isInternalUpdateTextBox = true;

                _editableTextBox.Text = text;

                _isInternalUpdateTextBox = false;
            }
        }

        private void UpdateSelectedDateTimeFromText()
        {
            if (_editableTextBox == null)
            {
                return; 
            }

            var text = _editableTextBox.Text;
            var selectedDateTime = SelectedDateTime;


            if (DateTime.TryParseExact(text, InputTextStringFormat ?? TextStringFormat, _calendarX.GetCulture(), DateTimeStyles.None, out DateTime newDateTime))
            {
                selectedDateTime = newDateTime;
            }

            SetCurrentValue(SelectedDateTimeProperty, selectedDateTime);
        }

        private void UpdateSelectedDateTime()
        {
            if (_isInternalUpdateSelectedDate)
            {
                return;
            }
            _isInternalUpdateSelectedDate = true;

            switch (Mode)
            {
                case DateTimePickerMode.Date:
                    SetCurrentValue(SelectedDateTimeProperty, _calendarX.SelectedDate);
                    break;
                case DateTimePickerMode.Time:
                    SetCurrentValue(SelectedDateTimeProperty, _timeSelector.SelectedTime);
                    break;
                case DateTimePickerMode.DateTime:
                    SetCurrentValue(SelectedDateTimeProperty, new DateTime(_calendarX.SelectedDate.Year, _calendarX.SelectedDate.Month, _calendarX.SelectedDate.Day, _timeSelector.SelectedTime.Hour, _timeSelector.SelectedTime.Minute, _timeSelector.SelectedTime.Second));
                    break;
            }

            _isInternalUpdateSelectedDate = false;
        }

        private void UpdateTimeSelectorTimeLimit()
        {
            if (_timeSelector == null)
            {
                return;
            }

            var minDateTime = MinDateTime;
            var maxDateTime = MaxDateTime;

            if (_calendarX != null
                && Mode != DateTimePickerMode.Time)
            {
                var selectedDate = _calendarX.SelectedDate;
                if (selectedDate.Date.Equals(minDateTime.Date))
                {
                    _timeSelector.MinTime = minDateTime.GetTime();
                    _timeSelector.MaxTime = new DateTime(1, 1, 1, 23, 59, 59);
                }
                else if (selectedDate.Date.Equals(maxDateTime.Date))
                {
                    _timeSelector.MinTime = new DateTime(1, 1, 1, 0, 0, 0);
                    _timeSelector.MaxTime = maxDateTime.GetTime();
                }
                else
                {
                    _timeSelector.MinTime = new DateTime(1, 1, 1, 0, 0, 0);
                    _timeSelector.MaxTime = new DateTime(1, 1, 1, 23, 59, 59);
                }
            }
            else
            {
                _timeSelector.MinTime = minDateTime.GetTime();
                _timeSelector.MaxTime = maxDateTime.GetTime();
            }
            
        }
        #endregion
    }
}
