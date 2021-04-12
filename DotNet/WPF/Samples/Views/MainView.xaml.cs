using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Samples.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : WindowX
    {
        public MainView()
        {
            InitializeComponent();
            InitExampleItems();
        }

        private void InitExampleItems()
        {
            var items = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsPublic && typeof(Window).IsAssignableFrom(x) && x.GetCustomAttribute<ExampleViewAttribute>() != null)
                .Select(x => 
                {
                    var viewAttribute = x.GetCustomAttribute<ExampleViewAttribute>();
                    return new ExampleItem()
                    {
                        DisplayName = viewAttribute.DisplayName,
                        ViewType = x,
                        ViewPath = $"Samples/Views/Examples/{x.Name}",
                        Screenshot = viewAttribute.Screenshot,
                    };
                })
                .ToList();
            LsbExamples.ItemsSource = items;
        }

        private void BtnExample_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var exampleItem = button.DataContext as ExampleItem;
            var window = (Window)Activator.CreateInstance(exampleItem.ViewType);
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Owner = this;
            window.ShowDialog();
        }
    }
}
