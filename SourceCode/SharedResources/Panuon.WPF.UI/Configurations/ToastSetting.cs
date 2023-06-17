using System;
using System.Windows;

namespace Panuon.WPF.UI.Configurations
{
    public class ToastSetting
        : DependencyObject
    {
        #region Ctor
        public ToastSetting()
        {
            LabelStyle = (Style)Application.Current.FindResource(Toast.LabelStyleKey);
        }
        #endregion

        #region Properties

        #region LabelStyle
        public Style LabelStyle
        {
            get { return (Style)GetValue(LabelStyleProperty); }
            set { SetValue(LabelStyleProperty, value); }
        }

        public static readonly DependencyProperty LabelStyleProperty =
            DependencyProperty.Register("LabelStyle", typeof(Style), typeof(ToastSetting));
        #endregion

        #region DefaultPosition
        public ToastPosition DefaultPosition
        {
            get { return (ToastPosition)GetValue(DefaultPositionProperty); }
            set { SetValue(DefaultPositionProperty, value); }
        }

        public static readonly DependencyProperty DefaultPositionProperty =
            DependencyProperty.Register("DefaultPosition", typeof(ToastPosition), typeof(ToastSetting), new PropertyMetadata(ToastPosition.Bottom));
        #endregion

        #region Spacing 
        public double Spacing
        {
            get { return (double)GetValue(SpacingProperty); }
            set { SetValue(SpacingProperty, value); }
        }

        public static readonly DependencyProperty SpacingProperty =
            DependencyProperty.Register("Spacing", typeof(double), typeof(ToastSetting), new PropertyMetadata(20d));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(ToastSetting), new PropertyMetadata(TimeSpan.FromSeconds(0.5)));
        #endregion

        #region AnimationEasing
        public AnimationEasing AnimationEasing
        {
            get { return (AnimationEasing)GetValue(AnimationEasingProperty); }
            set { SetValue(AnimationEasingProperty, value); }
        }

        public static readonly DependencyProperty AnimationEasingProperty =
            DependencyProperty.Register("AnimationEasing", typeof(AnimationEasing), typeof(ToastSetting), new PropertyMetadata(AnimationEasing.CircleOut));
        #endregion

        #endregion

    }
}