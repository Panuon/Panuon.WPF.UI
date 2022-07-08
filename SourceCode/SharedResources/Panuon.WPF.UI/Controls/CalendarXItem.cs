using Panuon.WPF.UI.Internal;
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class CalendarXItem
        : ToggleButton
    {
        #region Ctor
        static CalendarXItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarXItem), new FrameworkPropertyMetadata(typeof(CalendarXItem)));
        }
        #endregion

        #region Routed Events

        #region Selected
        public event RoutedEventHandler Selected
        {
            add { AddHandler(SelectedEvent, value); }
            remove { RemoveHandler(SelectedEvent, value); }
        }

        public static readonly RoutedEvent SelectedEvent =
            EventManager.RegisterRoutedEvent("Selected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CalendarXItem));
        #endregion

        #endregion

        #region Properties

        #region DateTime
        public DateTime? DateTime
        {
            get { return (DateTime?)GetValue(DateTimeProperty); }
            set { SetValue(DateTimeProperty, value); }
        }

        public static readonly DependencyProperty DateTimeProperty =
            DependencyProperty.Register("DateTime", typeof(DateTime?), typeof(CalendarXItem));
        #endregion

        #region CanSelect
        public bool CanSelect
        {
            get { return (bool)GetValue(CanSelectProperty); }
            set { SetValue(CanSelectProperty, value); }
        }

        public static readonly DependencyProperty CanSelectProperty =
            DependencyProperty.Register("CanSelect", typeof(bool), typeof(CalendarXItem));
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

        #region IsSpecialDay
        public bool IsSpecialDay
        {
            get { return (bool)GetValue(IsSpecialDayProperty); }
            set { SetValue(IsSpecialDayProperty, value); }
        }

        public static readonly DependencyProperty IsSpecialDayProperty =
            DependencyProperty.Register("IsSpecialDay", typeof(bool), typeof(CalendarXItem));
        #endregion

        #region IsOutsideThisMonth 
        public bool IsOutsideThisMonth 
        {
            get { return (bool)GetValue(IsOutsideThisMonthProperty); }
            set { SetValue(IsOutsideThisMonthProperty, value); }
        }

        public static readonly DependencyProperty IsOutsideThisMonthProperty =
            DependencyProperty.Register("IsOutsideThisMonth", typeof(bool), typeof(CalendarXItem));
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

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(CalendarXItem));
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

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(CalendarXItem));
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

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(CalendarXItem));
        #endregion

        #region CheckedBackground
        public Brush CheckedBackground
        {
            get { return (Brush)GetValue(CheckedBackgroundProperty); }
            set { SetValue(CheckedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register("CheckedBackground", typeof(Brush), typeof(CalendarXItem));
        #endregion

        #region CheckedForeground
        public Brush CheckedForeground
        {
            get { return (Brush)GetValue(CheckedForegroundProperty); }
            set { SetValue(CheckedForegroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.Register("CheckedForeground", typeof(Brush), typeof(CalendarXItem));
        #endregion

        #region CheckedBorderBrush
        public Brush CheckedBorderBrush
        {
            get { return (Brush)GetValue(CheckedBorderBrushProperty); }
            set { SetValue(CheckedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.Register("CheckedBorderBrush", typeof(Brush), typeof(CalendarXItem));
        #endregion

        #region CheckedBorderThickness
        public Thickness? CheckedBorderThickness
        {
            get { return (Thickness?)GetValue(CheckedBorderThicknessProperty); }
            set { SetValue(CheckedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.Register("CheckedBorderThickness", typeof(Thickness?), typeof(CalendarXItem));
        #endregion

        #region CheckedShadowColor
        public Color? CheckedShadowColor
        {
            get { return (Color?)GetValue(CheckedShadowColorProperty); }
            set { SetValue(CheckedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty CheckedShadowColorProperty =
            VisualStateHelper.CheckedShadowColorProperty.AddOwner(typeof(CalendarXItem));
        #endregion

        #region SpecialDayHighlightTemplate
        public DataTemplate SpecialDayHighlightTemplate
        {
            get { return (DataTemplate)GetValue(SpecialDayHighlightTemplateProperty); }
            set { SetValue(SpecialDayHighlightTemplateProperty, value); }
        }

        public static readonly DependencyProperty SpecialDayHighlightTemplateProperty =
            DependencyProperty.Register("SpecialDayHighlightTemplate", typeof(DataTemplate), typeof(CalendarXItem));
        #endregion

        #endregion

        #region Overrides
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            e.Handled = true;
            base.OnMouseDown(e);
            if (CanSelect)
            {
                RaiseEvent(new RoutedEventArgs(SelectedEvent));
            }
        }
        #endregion

    }
}
