using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Panuon.WPF;

namespace Panuon.WPF.UI.Resources
{
    public class ResourceDictionaries
        : ResourceDictionary
    {
        public static SharedResourceDictionary All { get; }
            = new SharedResourceDictionary()
            {
                Source = 
            };

        public static Uri Button
            = new Uri("pack://application:,,,/Panuon.WPF.UI;component/Styles/Button.xaml");

        public static Uri ButtonKeyOnly
            = new Uri("pack://application:,,,/Panuon.WPF.UI;component/Styles/ButtonStyle.xaml");

    }
}
