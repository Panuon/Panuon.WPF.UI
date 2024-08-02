using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class Switch 
        : ToggleButton
    {
        #region Ctor
        static Switch()
        {
            KeyboardNavigation.AcceptsReturnProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(false));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(typeof(Switch)));
        }
        #endregion

        #region Internal Events
        internal static event EventHandler SwitchChecked;
        #endregion

        #region Properties

        #region GroupName
        public string GroupName
        {
            get { return (string)GetValue(GroupNameProperty); }
            set { SetValue(GroupNameProperty, value); }
        }

        public static readonly DependencyProperty GroupNameProperty =
            DependencyProperty.Register("GroupName", typeof(string), typeof(Switch), new PropertyMetadata(OnGroupNameChanged));
        #endregion

        #region  ContentPlacement
        public ContentPlacement ContentPlacement
        {
            get { return (ContentPlacement)GetValue(ContentPlacementProperty); }
            set { SetValue(ContentPlacementProperty, value); }
        }

        public static readonly DependencyProperty ContentPlacementProperty =
            DependencyProperty.Register("ContentPlacement", typeof(ContentPlacement), typeof(Switch), new PropertyMetadata(ContentPlacement.Right));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            VisualStateHelper.CornerRadiusProperty.AddOwner(typeof(Switch));
        #endregion

        #region BoxWidth
        public double BoxWidth
        {
            get { return (double)GetValue(BoxWidthProperty); }
            set { SetValue(BoxWidthProperty, value); }
        }

        public static readonly DependencyProperty BoxWidthProperty =
            DependencyProperty.Register("BoxWidth", typeof(double), typeof(Switch));
        #endregion

        #region BoxHeight
        public double BoxHeight
        {
            get { return (double)GetValue(BoxHeightProperty); }
            set { SetValue(BoxHeightProperty, value); }
        }

        public static readonly DependencyProperty BoxHeightProperty =
            DependencyProperty.Register("BoxHeight", typeof(double), typeof(Switch));
        #endregion

        #region ToggleBrush
        public Brush ToggleBrush
        {
            get { return (Brush)GetValue(ToggleBrushProperty); }
            set { SetValue(ToggleBrushProperty, value); }
        }

        public static readonly DependencyProperty ToggleBrushProperty =
            VisualStateHelper.ToggleBrushProperty.AddOwner(typeof(Switch));
        #endregion

        #region ToggleSize
        public double ToggleSize
        {
            get { return (double)GetValue(ToggleSizeProperty); }
            set { SetValue(ToggleSizeProperty, value); }
        }

        public static readonly DependencyProperty ToggleSizeProperty =
            VisualStateHelper.ToggleSizeProperty.AddOwner(typeof(Switch));
        #endregion

        #region ToggleShadowColor
        public Color? ToggleShadowColor
        {
            get { return (Color?)GetValue(ToggleShadowColorProperty); }
            set { SetValue(ToggleShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ToggleShadowColorProperty =
            VisualStateHelper.ToggleShadowColorProperty.AddOwner(typeof(Switch));
        #endregion

        #region ToggleCornerRadius
        public CornerRadius ToggleCornerRadius
        {
            get { return (CornerRadius)GetValue(ToggleCornerRadiusProperty); }
            set { SetValue(ToggleCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ToggleCornerRadiusProperty =
            VisualStateHelper.ToggleCornerRadiusProperty.AddOwner(typeof(Switch));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverBorderThickness
        public Thickness? HoverBorderThickness
        {
            get { return (Thickness?)GetValue(HoverBorderThicknessProperty); }
            set { SetValue(HoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderThicknessProperty =
            VisualStateHelper.HoverBorderThicknessProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverToggleSize
        public double? HoverToggleSize
        {
            get { return (double?)GetValue(HoverToggleSizeProperty); }
            set { SetValue(HoverToggleSizeProperty, value); }
        }

        public static readonly DependencyProperty HoverToggleSizeProperty =
            VisualStateHelper.HoverToggleSizeProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverToggleBrush
        public Brush HoverToggleBrush
        {
            get { return (Brush)GetValue(HoverToggleBrushProperty); }
            set { SetValue(HoverToggleBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverToggleBrushProperty =
            VisualStateHelper.HoverToggleBrushProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverToggleCornerRadius
        public CornerRadius? HoverToggleCornerRadius
        {
            get { return (CornerRadius?)GetValue(HoverToggleCornerRadiusProperty); }
            set { SetValue(HoverToggleCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HoverToggleCornerRadiusProperty =
            VisualStateHelper.HoverToggleCornerRadiusProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverCornerRadius
        public CornerRadius? HoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(HoverCornerRadiusProperty); }
            set { SetValue(HoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty HoverCornerRadiusProperty =
            VisualStateHelper.HoverCornerRadiusProperty.AddOwner(typeof(Switch));
        #endregion

        #region HoverToggleShadowColor
        public Color? HoverToggleShadowColor
        {
            get { return (Color?)GetValue(HoverToggleShadowColorProperty); }
            set { SetValue(HoverToggleShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverToggleShadowColorProperty =
            VisualStateHelper.HoverToggleShadowColorProperty.AddOwner(typeof(Switch));
        #endregion

        #region CheckedBackground
        public Brush CheckedBackground
        {
            get { return (Brush)GetValue(CheckedBackgroundProperty); }
            set { SetValue(CheckedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register("CheckedBackground", typeof(Brush), typeof(Switch));
        #endregion

        #region CheckedForeground
        public Brush CheckedForeground
        {
            get { return (Brush)GetValue(CheckedForegroundProperty); }
            set { SetValue(CheckedForegroundProperty, value); }
        }

        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.Register("CheckedForeground", typeof(Brush), typeof(Switch));
        #endregion

        #region CheckedBorderBrush
        public Brush CheckedBorderBrush
        {
            get { return (Brush)GetValue(CheckedBorderBrushProperty); }
            set { SetValue(CheckedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.Register("CheckedBorderBrush", typeof(Brush), typeof(Switch));
        #endregion

        #region CheckedBorderThickness
        public Thickness? CheckedBorderThickness
        {
            get { return (Thickness?)GetValue(CheckedBorderThicknessProperty); }
            set { SetValue(CheckedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty CheckedBorderThicknessProperty =
            DependencyProperty.Register("CheckedBorderThickness", typeof(Thickness?), typeof(Switch));
        #endregion

        #region CheckedToggleSize
        public double? CheckedToggleSize
        {
            get { return (double?)GetValue(CheckedToggleSizeProperty); }
            set { SetValue(CheckedToggleSizeProperty, value); }
        }

        public static readonly DependencyProperty CheckedToggleSizeProperty =
            DependencyProperty.Register("CheckedToggleSize", typeof(double?), typeof(Switch));
        #endregion

        #region CheckedToggleBrush
        public Brush CheckedToggleBrush
        {
            get { return (Brush)GetValue(CheckedToggleBrushProperty); }
            set { SetValue(CheckedToggleBrushProperty, value); }
        }

        public static readonly DependencyProperty CheckedToggleBrushProperty =
            DependencyProperty.Register("CheckedToggleBrush", typeof(Brush), typeof(Switch));
        #endregion

        #region CheckedToggleCornerRadius
        public CornerRadius? CheckedToggleCornerRadius
        {
            get { return (CornerRadius?)GetValue(CheckedToggleCornerRadiusProperty); }
            set { SetValue(CheckedToggleCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CheckedToggleCornerRadiusProperty =
            DependencyProperty.Register("CheckedToggleCornerRadius", typeof(CornerRadius?), typeof(Switch));
        #endregion

        #region CheckedShadowColor
        public Color? CheckedShadowColor
        {
            get { return (Color?)GetValue(CheckedShadowColorProperty); }
            set { SetValue(CheckedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty CheckedShadowColorProperty =
            VisualStateHelper.CheckedShadowColorProperty.AddOwner(typeof(Switch));
        #endregion

        #region CheckedContent
        public object CheckedContent
        {
            get { return (object)GetValue(CheckedContentProperty); }
            set { SetValue(CheckedContentProperty, value); }
        }

        public static readonly DependencyProperty CheckedContentProperty =
            DependencyProperty.Register("CheckedContent", typeof(object), typeof(Switch));
        #endregion

        #region CheckedToggleShadowColor
        public Color? CheckedToggleShadowColor
        {
            get { return (Color?)GetValue(CheckedToggleShadowColorProperty); }
            set { SetValue(CheckedToggleShadowColorProperty, value); }
        }

        public static readonly DependencyProperty CheckedToggleShadowColorProperty =
            VisualStateHelper.CheckedToggleShadowColorProperty.AddOwner(typeof(Switch));
        #endregion

        #region CheckedCornerRadius
        public CornerRadius? CheckedCornerRadius
        {
            get { return (CornerRadius?)GetValue(CheckedCornerRadiusProperty); }
            set { SetValue(CheckedCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CheckedCornerRadiusProperty =
            DependencyProperty.Register("CheckedCornerRadius", typeof(CornerRadius?), typeof(Switch));
        #endregion

        #region BoxTemplate
        public DataTemplate BoxTemplate
        {
            get { return (DataTemplate)GetValue(BoxTemplateProperty); }
            set { SetValue(BoxTemplateProperty, value); }
        }

        public static readonly DependencyProperty BoxTemplateProperty =
            DependencyProperty.Register("BoxTemplate", typeof(DataTemplate), typeof(Switch));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnGroupNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var @switch = (Switch)d;
            @switch.RaiseSwitchChecked();
        }

        private void Switch_SwitchChecked(object sender, EventArgs e)
        {
            try
            {
                if (sender is Switch @switch && @switch != this && GroupName == @switch.GroupName && Window.GetWindow(@switch) == Window.GetWindow(this))
                {
                    IsChecked = false;
                }
            }
            catch { }
            
        }
        #endregion

        #region Functions
        private void RaiseSwitchChecked()
        {
            if (!string.IsNullOrEmpty(GroupName))
            {
                SwitchChecked?.Invoke(this, new EventArgs());
            }
        }
        #endregion
    }
}
