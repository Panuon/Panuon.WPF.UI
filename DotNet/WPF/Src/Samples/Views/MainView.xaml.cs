using Panuon.UI.Silver;
using Samples.Views.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Samples.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : WindowX
    {
        #region Ctor
        public MainView()
        {
           
            InitializeComponent();
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Loaded, new Action(() =>
            {
                InitExampleItems();
            }));
            Cdr.SpecialDays = new List<CalendarXSpecialDay>()
            {
                new CalendarXSpecialDay("愚人", new DateTime(2021,4,1)),
                new CalendarXSpecialDay("劳动", new DateTime(2021,5,1)),
            };
            
            //sg.ItemsSource = new List<object>()
            //{
            //    new { Name = "123" },
            //    new { Name = "12345" },
            //    new { Name = "54321" },
            //    new { Name = "321" },
            //};
        }
        #endregion

        #region Event Handlers
        private void BtnExample_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var exampleItem = button.DataContext as ExampleItem;
            var window = (Window)Activator.CreateInstance(exampleItem.ViewType);
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Owner = this;
            window.ShowDialog();
        }

        private void BtnIconFont_Click(object sender, RoutedEventArgs e)
        {
            var window = new IconFontView();
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Owner = this;
            window.ShowDialog();
        }
        #endregion

        #region Functions
        private void InitExampleItems()
        {
            var items = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsPublic && typeof(Window).IsAssignableFrom(x) && x.GetCustomAttribute<ExampleViewAttribute>() != null)
                .OrderBy(x => x.GetCustomAttribute<ExampleViewAttribute>().Index)
                .Select(x =>
                {
                    var viewAttribute = x.GetCustomAttribute<ExampleViewAttribute>();
                    var view = (WindowX)Activator.CreateInstance(x);
                    var content = view.Content;
                    view.Content = null;
                    var previewView = GetPreviewView(view, content);
                    return new ExampleItem()
                    {
                        DisplayName = viewAttribute.DisplayName,
                        ViewType = x,
                        ViewPath = $"Samples/Views/Examples/{x.Name}",
                        PreviewView = previewView,
                    };
                });
            LsbExamples.ItemsSource = items;
        }

        private UIElement GetPreviewView(WindowX view, object content)
        {
            var contentControl = new ContentControl()
            {
                Foreground = view.Foreground,
                Content = content,
            };
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(WindowXCaption.GetHeight(view)) });
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            grid.Children.Add(new Border()
            {
                Background = WindowXCaption.GetBackground(view),
                Child = new ContentControl()
                {
                    Content = view.DataContext is Window ? "" : view.DataContext,
                    ContentTemplate = WindowXCaption.GetHeaderTemplate(view),
                }
            });
            Grid.SetRow(contentControl, 1);
            grid.Children.Add(contentControl);
            var border = new Border()
            {
                Background = view.Background,
                BorderBrush = view.BorderBrush,
                BorderThickness = view.BorderThickness,
                Width = view.Width,
                Height = view.Height,
                Child = grid,
            };
            return border;
        }


        #endregion

        private void Dwr_Closed(object sender, RoutedEventArgs e)
        {
            IsOverlayerVisible = false;
            IsMaskVisible = false;
        }

        private void Dwr_Opened(object sender, RoutedEventArgs e)
        {
            IsOverlayerVisible = true;
            IsMaskVisible = true;
        }
    }
}
