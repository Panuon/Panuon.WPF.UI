using System.Windows;

namespace Panuon.WPF.UI.Internal.Models
{
    class MessageBoxContent : DependencyObject
    {
        #region Message
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(MessageBoxContent));
        #endregion

        #region Caption
        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(MessageBoxContent));
        #endregion

        #region MessageBoxIcon
        public MessageBoxIcon MessageBoxIcon
        {
            get { return (MessageBoxIcon)GetValue(MessageBoxIconProperty); }
            set { SetValue(MessageBoxIconProperty, value); }
        }

        public static readonly DependencyProperty MessageBoxIconProperty =
            DependencyProperty.Register("MessageBoxIcon", typeof(MessageBoxIcon), typeof(MessageBoxContent));
        #endregion

        #region ButtonStyle
        public Style ButtonStyle
        {
            get { return (Style)GetValue(ButtonStyleProperty); }
            set { SetValue(ButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty ButtonStyleProperty =
            DependencyProperty.Register("ButtonStyle", typeof(Style), typeof(MessageBoxContent));
        #endregion
    }
}
