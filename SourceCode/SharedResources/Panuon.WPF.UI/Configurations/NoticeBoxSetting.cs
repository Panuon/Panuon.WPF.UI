using System;
using System.Windows;

namespace Panuon.WPF.UI.Configurations
{
    public class NoticeBoxSetting : DependencyObject
    {
        #region Ctor
        public NoticeBoxSetting()
        {
            NoticeBoxItemStyle = (Style)Application.Current.FindResource(NoticeBox.NoticeBoxItemStyleKey);
        }
        #endregion

        #region Properties

        #region Position
        internal NoticeBoxPosition Position
        {
            get { return (NoticeBoxPosition)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }

        internal static readonly DependencyProperty PositionProperty =
            DependencyProperty.Register("Position", typeof(NoticeBoxPosition), typeof(NoticeBoxSetting), new PropertyMetadata(NoticeBoxPosition.BottomRight));
        #endregion

        #region NoticeBoxItemStyle
        public Style NoticeBoxItemStyle
        {
            get { return (Style)GetValue(NoticeBoxItemStyleProperty); }
            set { SetValue(NoticeBoxItemStyleProperty, value); }
        }

        public static readonly DependencyProperty NoticeBoxItemStyleProperty =
            DependencyProperty.Register("NoticeBoxItemStyle", typeof(Style), typeof(NoticeBoxSetting));
        #endregion

        #region CreateOnNewThread
        public bool CreateOnNewThread
        {
            get { return (bool)GetValue(CreateOnNewThreadProperty); }
            set { SetValue(CreateOnNewThreadProperty, value); }
        }

        public static readonly DependencyProperty CreateOnNewThreadProperty =
            DependencyProperty.Register("CreateOnNewThread", typeof(bool), typeof(NoticeBoxSetting), new PropertyMetadata(true));
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get { return (TimeSpan)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(NoticeBoxSetting), new PropertyMetadata(TimeSpan.FromSeconds(0.5)));
        #endregion

        #region AnimationEasing
        public AnimationEasing AnimationEasing
        {
            get { return (AnimationEasing)GetValue(AnimationEasingProperty); }
            set { SetValue(AnimationEasingProperty, value); }
        }

        public static readonly DependencyProperty AnimationEasingProperty =
            DependencyProperty.Register("AnimationEasing", typeof(AnimationEasing), typeof(NoticeBoxSetting), new PropertyMetadata(AnimationEasing.CircleOut));
        #endregion

        #endregion

    }
}