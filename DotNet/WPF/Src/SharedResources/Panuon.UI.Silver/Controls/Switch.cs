using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class Switch : ToggleButton
    {
        #region Ctor
        static Switch()
        {
            KeyboardNavigation.AcceptsReturnProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(false));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(typeof(Switch)));
        }

        public Switch()
        {
            SwitchChecked += Switch_SwitchChecked;
            SetBinding(InternalToggleShadowColorProperty, new Binding()
            {
                Path = new PropertyPath(ToggleShadowColorProperty),
                Source = this,
            });
        }
        #endregion

        #region Internal Events
        internal static event EventHandler SwitchChecked;
        #endregion

        #region Overrides

        #region OnChecked
        protected override void OnChecked(RoutedEventArgs e)
        {
            base.OnChecked(e);
            RaiseSwitchChecked();
            if (CheckedToggleShadowColor is Color checkedShadowColor)
            {
                AnimationUtil.BeginColorAnimation(this, InternalToggleShadowColorProperty, null, checkedShadowColor, TimeSpan.FromSeconds(0.2));
            }
        }
        #endregion

        #region OnUnchecked
        protected override void OnUnchecked(RoutedEventArgs e)
        {
            base.OnUnchecked(e);
            if (CheckedToggleShadowColor is Color && ToggleShadowColor is Color shadowColor)
            {
                AnimationUtil.BeginColorAnimation(this, InternalToggleShadowColorProperty, null, shadowColor, TimeSpan.FromSeconds(0.2));
            }
        }
        #endregion

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
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Switch));
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
            DependencyProperty.Register("ToggleBrush", typeof(Brush), typeof(Switch));
        #endregion

        #region ToggleSize
        public double ToggleSize
        {
            get { return (double)GetValue(ToggleSizeProperty); }
            set { SetValue(ToggleSizeProperty, value); }
        }

        public static readonly DependencyProperty ToggleSizeProperty =
            DependencyProperty.Register("ToggleSize", typeof(double), typeof(Switch));
        #endregion

        #region ToggleShadowColor
        public Color? ToggleShadowColor
        {
            get { return (Color?)GetValue(ToggleShadowColorProperty); }
            set { SetValue(ToggleShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ToggleShadowColorProperty =
            DependencyProperty.Register("ToggleShadowColor", typeof(Color?), typeof(Switch));
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

        #region CheckedToggleBrush
        public Brush CheckedToggleBrush
        {
            get { return (Brush)GetValue(CheckedToggleBrushProperty); }
            set { SetValue(CheckedToggleBrushProperty, value); }
        }

        public static readonly DependencyProperty CheckedToggleBrushProperty =
            DependencyProperty.Register("CheckedToggleBrush", typeof(Brush), typeof(Switch));
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
            DependencyProperty.Register("CheckedToggleShadowColor", typeof(Color?), typeof(Switch));
        #endregion

        #endregion

        #region Internal Properties

        #region InternalToggleShadowColor
        public Color? InternalToggleShadowColor
        {
            get { return (Color?)GetValue(InternalToggleShadowColorProperty); }
            set { SetValue(InternalToggleShadowColorProperty, value); }
        }

        public static readonly DependencyProperty InternalToggleShadowColorProperty =
            DependencyProperty.Register("InternalToggleShadowColor", typeof(Color?), typeof(Switch));
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
