﻿using Panuon.WPF;
using Panuon.WPF.UI;
using System.Collections.Generic;
using System.Linq;

namespace Samples.Views.Examples
{
    /// <summary>
    /// NeteaseMusicView.xaml 的交互逻辑
    /// </summary>
    [ExampleView(Index = 1, DisplayName = "Netease Music")]
    public partial class NeteaseMusicView : WindowX
    {
        private readonly List<string> _searchList = new List<string>()
        {
            "Beautiful - Said The Sky",
            "Buzz - Before You Exit",
            "Slience - Before You Exit",
            "Feels - WATTS/Khalid",
            "Shotgun - Us The Duo"
        };

        public NeteaseMusicView()
        {
            InitializeComponent();
        }

        private void SchBox_Opened(object sender, System.EventArgs e)
        {
            var searchBox = sender as SearchBox;
            searchBox.ItemsSource = _searchList.ToList();
        }

        private void SchBox_SearchTextChanged(object sender, SearchTextChangedRoutedEventArgs e)
        {
            var searchBox = sender as SearchBox;
            var searchText = e.Text?.Trim()?.ToLower();

            searchBox.ItemsSource = string.IsNullOrEmpty(searchText)
                ? _searchList
                : _searchList.Where(x => x.ToLower().Contains(searchText)).ToList();
        }

        private void SchBox_ItemClick(object sender, System.Windows.RoutedEventArgs e)
        {
            //do something
        }
    }
}
