using Panuon.UI.Silver;
using Samples.Models;
using System;
using System.Collections.Generic;

namespace Samples.Views.Tools
{
    /// <summary>
    /// IconFontView.xaml 的交互逻辑
    /// </summary>
    public partial class IconFontView : WindowX
    {
        public IconFontView()
        {
            InitializeComponent();
            LoadFontItems();
        }

        private void LoadFontItems()
        {
            var fontItems = new List<FontItem>();
            var start = Convert.ToInt32("e900", 16);
            for (int i = 0; i < 235; i++)
            {
                var value = start + i;
                var icon = value.ToString("X4").ToLower();
                fontItems.Add(new FontItem() { Icon = (char)value, Code = icon });
            }

            LsbIcon.ItemsSource = fontItems;
        }
    }
}
