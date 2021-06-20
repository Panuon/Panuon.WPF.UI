using Panuon.UI.Silver.Internal;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    class CalendarXItem : ContentControl
    {
        #region Ctor
        static CalendarXItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarXItem), new FrameworkPropertyMetadata(typeof(CalendarXItem)));
        }
        #endregion

        #region Events

        #region Selected
        public event RoutedEventHandler Selected
        {
            add { AddHandler(SelectedEvent, value); }
            remove { RemoveHandler(SelectedEvent, value); }
        }

        public static readonly RoutedEvent SelectedEvent =
            EventManager.RegisterRoutedEvent("Selected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CalendarXItem));
        #endregion

        #region Unselected
        public event RoutedEventHandler Unselected
        {
            add { AddHandler(UnselectedEvent, value); }
            remove { RemoveHandler(UnselectedEvent, value); }
        }

        public static readonly RoutedEvent UnselectedEvent =
            EventManager.RegisterRoutedEvent("Unselected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CalendarXItem));
        #endregion

        #region Click
        public event RoutedEventHandler Click
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        public static readonly RoutedEvent ClickEvent =
            EventManager.RegisterRoutedEvent("Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CalendarXItem));
        #endregion

        #endregion

        #region Properties

        #region Mode
        public CalendarXItemMode Mode
        {
            get { return (CalendarXItemMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(CalendarXItemMode), typeof(CalendarXItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.Register("ShadowColor", typeof(Color?), typeof(CalendarXItem));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CalendarXItem));
        #endregion

        #region IsSelected
        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(CalendarXItem), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnIsSelectedChanged));
        #endregion

        #region IsInSelectionRange
        public bool IsInSelectionRange
        {
            get { return (bool)GetValue(IsInSelectionRangeProperty); }
            set { SetValue(IsInSelectionRangeProperty, value); }
        }

        public static readonly DependencyProperty IsInSelectionRangeProperty =
            DependencyProperty.Register("IsInSelectionRange", typeof(bool), typeof(CalendarXItem));
        #endregion

        #region IsWeakenDisplay
        public bool IsWeakenDisplay
        {
            get { return (bool)GetValue(IsWeakenDisplayProperty); }
            set { SetValue(IsWeakenDisplayProperty, value); }
        }

        public static readonly DependencyProperty IsWeakenDisplayProperty =
            DependencyProperty.Register("IsWeakenDisplay", typeof(bool), typeof(CalendarXItem));
        #endregion

        #region IsSpecialDay
        public bool IsSpecialDay
        {
            get { return (bool)GetValue(IsSpecialDayProperty); }
            set { SetValue(IsSpecialDayProperty, value); }
        }

        public static readonly DependencyProperty IsSpecialDayProperty =
            DependencyProperty.Register("IsSpecialDay", typeof(bool), typeof(CalendarXItem));
        #endregion

        #region IsToday
        public bool IsToday
        {
            get { return (bool)GetValue(IsTodayProperty); }
            set { SetValue(IsTodayProperty, value); }
        }

        public static readonly DependencyProperty IsTodayProperty =
            DependencyProperty.Register("IsToday", typeof(bool), typeof(CalendarXItem));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(CalendarXItem));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(CalendarXItem));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(CalendarXItem));
        #endregion

        #region SelectedBackground
        public Brush SelectedBackground
        {
            get { return (Brush)GetValue(SelectedBackgroundProperty); }
            set { SetValue(SelectedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.Register("SelectedBackground", typeof(Brush), typeof(CalendarXItem));
        #endregion

        #region SelectedBorderBrush
        public Brush SelectedBorderBrush
        {
            get { return (Brush)GetValue(SelectedBorderBrushProperty); }
            set { SetValue(SelectedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.Register("SelectedBorderBrush", typeof(Brush), typeof(CalendarXItem));
        #endregion

        #region SelectedForeground
        public Brush SelectedForeground
        {
            get { return (Brush)GetValue(SelectedForegroundProperty); }
            set { SetValue(SelectedForegroundProperty, value); }
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.Register("SelectedForeground", typeof(Brush), typeof(CalendarXItem));
        #endregion

        #region HighlightGlyphTemplate
        public DataTemplate HighlightGlyphTemplate
        {
            get { return (DataTemplate)GetValue(HighlightGlyphTemplateProperty); }
            set { SetValue(HighlightGlyphTemplateProperty, value); }
        }

        public static readonly DependencyProperty HighlightGlyphTemplateProperty =
            DependencyProperty.Register("HighlightGlyphTemplate", typeof(DataTemplate), typeof(CalendarXItem));
        #endregion

        #endregion

        #region Overrides
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            SetCurrentValue(IsSelectedProperty, !IsSelected);
            base.OnMouseDown(e);
            RaiseEvent(new RoutedEventArgs(ClickEvent));
        }
        #endregion

        #region Event Handlers
        private static void OnIsSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var calendarXItem = (CalendarXItem)d;
            calendarXItem.OnIsSelectedChanged();
        }
        #endregion

        #region Functions
        private void OnIsSelectedChanged()
        {
            if (IsSelected)
            {
                RaiseEvent(new RoutedEventArgs(SelectedEvent, this));
            }
            else
            {
                RaiseEvent(new RoutedEventArgs(UnselectedEvent, this));
            }
        }
        #endregion

    }
}
