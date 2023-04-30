using System.Windows;

namespace Panuon.WPF.UI.Configurations
{
    public class ApplicationTheme
        : DependencyObject
    {
        #region Key
        public string Key
        {
            get { return (string)GetValue(KeyProperty); }
            set { SetValue(KeyProperty, value); }
        }

        public static readonly DependencyProperty KeyProperty =
            DependencyProperty.Register("Key", typeof(string), typeof(ApplicationTheme));
        #endregion

        #region ResourceDictionary
        public string ResourceDictionary
        {
            get { return (string)GetValue(ResourceDictionaryProperty); }
            set { SetValue(ResourceDictionaryProperty, value); }
        }

        public static readonly DependencyProperty ResourceDictionaryProperty =
            DependencyProperty.Register("ResourceDictionary", typeof(string), typeof(ApplicationTheme));
        #endregion
    }
}
