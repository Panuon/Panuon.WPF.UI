using Panuon.WPF.UI;
using Samples.Views.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Samples.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : WindowX
    {
        #region Fields
        private static readonly List<Type> _viewTypes;
        #endregion

        #region Ctor
        static MainView()
        {
            _viewTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsPublic && typeof(Window).IsAssignableFrom(x) && x.GetCustomAttribute<ExampleViewAttribute>() != null)
                .OrderBy(x => x.GetCustomAttribute<ExampleViewAttribute>().Index)
                .ToList();
        }
        public MainView()
        {
            InitializeComponent();
            Dispatcher.BeginInvoke(DispatcherPriority.Loaded, new Action(() =>
            {
                InitExampleItems();
            }));
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

        private void BtnTestMessageBoxX_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxX.Show(this, "MessageBoxX style configuration is placed in App.xaml. ", "Tips", MessageBoxIcon.Info, DefaultButton.YesOK, 5);
        }

        private void BtnTestNoticeBox_Click(object sender, RoutedEventArgs e)
        {
            var handler = NoticeBox.Show("NoticeBox style configuration is placed in App.xaml. ", "Tips", MessageBoxIcon.Info, true, 3000);
            //handler.Click += ...
        }

        private async void BtnTestPendingBox_Click(object sender, RoutedEventArgs e)
        {
            var handler = PendingBox.Show(this, "PendingBox style configuration is placed in App.xaml.", "Caption", true);
            //handler.Cancelling += ...
            //handler.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var handler = NoticeBox.Show("正在执行...", "提示", MessageBoxIcon.Info, true);
            //handler.Closed += ...
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var handler = NoticeBox.Show("正在执行...", "提示", MessageBoxIcon.Info, true);
            //handler.Closed += ...
        }
        #endregion

        #region Functions
        private void InitExampleItems()
        {
            var items = _viewTypes
                .Select(x =>
                {
                    var viewAttribute = x.GetCustomAttribute<ExampleViewAttribute>();
                    var view = (WindowX)Activator.CreateInstance(x);
                    var content = view.Content;
                    view.Content = null;
                    var previewView = CreatePreviewView(view, content);
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

        private UIElement CreatePreviewView(WindowX view, object content)
        {
            var contentControl = new ContentControl()
            {
                Foreground = view.Foreground,
                Content = content,
            };
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(view.DisableDragMove ? 0 : WindowXCaption.GetHeight(view)) });
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
                BorderBrush = view.BorderBrush ?? Brushes.Gray,
                BorderThickness = view.BorderThickness.Left == 0 ? new Thickness(1) : view.BorderThickness,
                Width = view.Width,
                Height = view.Height,
                Child = grid,
            };
            return border;
        }


        #endregion

    }
}
