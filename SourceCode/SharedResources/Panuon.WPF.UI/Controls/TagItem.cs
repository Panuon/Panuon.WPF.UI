using Panuon.WPF.UI.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = RemoveButtonTemplateName, Type = typeof(Button))]
    public class TagItem
        : ContentControl
    {
        #region Fields
        private const string RemoveButtonTemplateName = "PART_RemoveButton";
        #endregion

        #region Ctor
        static TagItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TagItem), new FrameworkPropertyMetadata(typeof(TagItem)));
        }
        #endregion

        #region Routed Events

        #region RemoveButtonClick
        public event RoutedEventHandler RemoveButtonClick
        {
            add { AddHandler(RemoveButtonClickEvent, value); }
            remove { RemoveHandler(RemoveButtonClickEvent, value); }
        }

        public static readonly RoutedEvent RemoveButtonClickEvent =
            EventManager.RegisterRoutedEvent("RemoveButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TagItem));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            var button = GetTemplateChild(RemoveButtonTemplateName) as Button;
            if (button != null)
            {
                button.Click += Button_Click;
            }
        }
        #endregion

        #region Properties

        #region RemoveCommand
        public ICommand RemoveCommand
        {
            get { return (ICommand)GetValue(RemoveCommandProperty); }
            set { SetValue(RemoveCommandProperty, value); }
        }

        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.Register("RemoveCommand", typeof(ICommand), typeof(TagItem));
        #endregion


        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(TagItem));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(TagItem));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(TagItem));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(TagItem));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(TagItem));
        #endregion

        #region HoverBorderThickness
        public Thickness? HoverBorderThickness
        {
            get { return (Thickness?)GetValue(HoverBorderThicknessProperty); }
            set { SetValue(HoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(TagItem));
        #endregion

        #region HoverCornerRadius
        public CornerRadius? HoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(HoverCornerRadiusProperty); }
            set { SetValue(HoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(TagItem));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(TagItem));
        #endregion

        #region RemoveButtonStyle
        public Style RemoveButtonStyle
        {
            get { return (Style)GetValue(RemoveButtonStyleProperty); }
            set { SetValue(RemoveButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty RemoveButtonStyleProperty =
            DependencyProperty.Register("RemoveButtonStyle", typeof(Style), typeof(TagItem));
        #endregion

        #region RemoveButtonVisibility
        public AuxiliaryButtonVisibility RemoveButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(RemoveButtonVisibilityProperty); }
            set { SetValue(RemoveButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty RemoveButtonVisibilityProperty =
            DependencyProperty.Register("RemoveButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(TagItem));
        #endregion

        #endregion

        #region Event Handlers
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(RemoveButtonClickEvent, this));
        }
        #endregion
    }
}
