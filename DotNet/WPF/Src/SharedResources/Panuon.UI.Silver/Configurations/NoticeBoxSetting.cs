using System;
using System.Windows;

namespace Panuon.UI.Silver.Configurations
{
    public class NoticeBoxSetting : DependencyObject
    {
        #region Ctor
        public NoticeBoxSetting()
        {
            NoticeBoxItemStyle = (Style)Application.Current.FindResource(new ComponentResourceKey(typeof(NoticeBox), "NoticeBoxItemStyle"));
        }
        #endregion

        #region Properties

        #region CardStyle
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

        #region AnimationEase
        public AnimationEase AnimationEase
        {
            get { return (AnimationEase)GetValue(AnimationEaseProperty); }
            set { SetValue(AnimationEaseProperty, value); }
        }

        public static readonly DependencyProperty AnimationEaseProperty =
            DependencyProperty.Register("AnimationEase", typeof(AnimationEase), typeof(NoticeBoxSetting), new PropertyMetadata(AnimationEase.CircleInOut));
        #endregion

        #endregion

    }
}