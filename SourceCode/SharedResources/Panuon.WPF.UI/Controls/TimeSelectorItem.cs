using Panuon.WPF.UI.Internal;
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class TimeSelectorItem
        : ToggleButton
    {
        #region Ctor
        static TimeSelectorItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TimeSelectorItem), new FrameworkPropertyMetadata(typeof(TimeSelectorItem)));
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
            EventManager.RegisterRoutedEvent("Selected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TimeSelectorItem));
        #endregion

        #region Pressed
        public event RoutedEventHandler Pressed
        {
            add { AddHandler(PressedEvent, value); }
            remove { RemoveHandler(PressedEvent, value); }
        }

        public static readonly RoutedEvent PressedEvent =
            EventManager.RegisterRoutedEvent("Pressed", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TimeSelectorItem));
        #endregion

        #endregion

        #region Properties

        #region Time
        public int Time
        {
            get { return (int)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        public static readonly DependencyProperty TimeProperty =
            DependencyProperty.Register("Time", typeof(int), typeof(TimeSelectorItem));
        #endregion

        #region CanSelect
        public bool CanSelect
        {
            get { return (bool)GetValue(CanSelectProperty); }
            set { SetValue(CanSelectProperty, value); }
        }

        public static readonly DependencyProperty CanSelectProperty =
            DependencyProperty.Register("CanSelect", typeof(bool), typeof(TimeSelectorItem));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(TimeSelectorItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(TimeSelectorItem));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(TimeSelectorItem));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(TimeSelectorItem));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(TimeSelectorItem));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(TimeSelectorItem));
        #endregion

        #region CheckedBackground
        public Brush CheckedBackground
        {
            get { return (Brush)GetValue(CheckedBackgroundProperty); }
            set { SetValue(CheckedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register("CheckedBackground", typeof(Brush), typeof(TimeSelectorItem));
        #endregion

        #region CheckedForeground
        public Brush CheckedForeground
        {
            get { return (Brush)GetValue(CheckedForegroundProperty); }
            set { SetValue(CheckedForegroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.Register("CheckedForeground", typeof(Brush), typeof(TimeSelectorItem));
        #endregion

        #region CheckedBorderBrush
        public Brush CheckedBorderBrush
        {
            get { return (Brush)GetValue(CheckedBorderBrushProperty); }
            set { SetValue(CheckedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.Register("CheckedBorderBrush", typeof(Brush), typeof(TimeSelectorItem));
        #endregion

        #region CheckedBorderThickness
        public Thickness? CheckedBorderThickness
        {
            get { return (Thickness?)GetValue(CheckedBorderThicknessProperty); }
            set { SetValue(CheckedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.Register("CheckedBorderThickness", typeof(Thickness?), typeof(TimeSelectorItem));
        #endregion

        #region CheckedShadowColor
        public Color? CheckedShadowColor
        {
            get { return (Color?)GetValue(CheckedShadowColorProperty); }
            set { SetValue(CheckedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty CheckedShadowColorProperty =
            VisualStateHelper.CheckedShadowColorProperty.AddOwner(typeof(TimeSelectorItem));
        #endregion

        #region SpecialDayHighlightTemplate
        public DataTemplate SpecialDayHighlightTemplate
        {
            get { return (DataTemplate)GetValue(SpecialDayHighlightTemplateProperty); }
            set { SetValue(SpecialDayHighlightTemplateProperty, value); }
        }

        public static readonly DependencyProperty SpecialDayHighlightTemplateProperty =
            DependencyProperty.Register("SpecialDayHighlightTemplate", typeof(DataTemplate), typeof(TimeSelectorItem));
        #endregion

        #endregion

        #region Overrides
        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseDown(e);
            RaiseEvent(new RoutedEventArgs(PressedEvent));
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            e.Handled = true;
            base.OnMouseDown(e);
            if (CanSelect)
            {
                RaiseEvent(new RoutedEventArgs(SelectedEvent));
            }
        }

        internal void Select()
        {
            if (CanSelect)
            {
                IsChecked = true;
                RaiseEvent(new RoutedEventArgs(SelectedEvent));
            }
        }
        #endregion

    }
}
