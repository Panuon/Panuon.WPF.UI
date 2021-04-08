using Panuon.UI.Core;
using Panuon.UI.Silver;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Samples
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : WindowX
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var items = new ObservableCollection<TestModel>();
            for (int i = 0; i < 100; i++)
            {
                items.Add(new TestModel() { DisplayName = i.ToString(), Value = i });
            }
            dataGrid.ItemsSource = items;
        }

        private void ComboBox_SearchTextChanged(object sender, SearchTextChangedEventArgs e)
        {
             
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pgb.Value = Pgb.Value == 100 ? 0 : 100;
            return;
            var window = new WindowX()
            {
                Width = 200,
                Height = 150,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            window.Owner = this;
            window.Show();
        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
        {

        }
    }

    public class ViewModel 
    {
        public Brush Brush { get; set; } = Brushes.Red;
    }

    public class TestModel : NotifyPropertyChangedBase
    {

        #region Row
        [DisplayName("行号")]
        [ReadOnly(true)]
        public int Row { get => _row; set => Set(ref _row, value); }
        private int _row;
        #endregion 

        #region DisplayName
        [ColumnWidth("*")]
        public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
        private string _displayName;
        #endregion

        #region SelectedValue
        [ColumnCombo(ItemsSourceBindingPath = nameof(Values))]
        public string SelectedValue { get => _selectedValue; set => Set(ref _selectedValue, value); }
        private string _selectedValue = "1";
        #endregion

        #region Values
        [ColumnIgnore]
        public IList<string> Values { get; } = new List<string>() { "1", "2", "3", "4" };
        #endregion 

        #region Value
        public int Value { get => _value; set => Set(ref _value, value); }
        private int _value;
        #endregion

        public AnimationEase Ease { get => _ease; set => Set(ref _ease, value); }
        private AnimationEase _ease;

        #region Value
        public bool IsEnabled { get => _isEnabled; set => Set(ref _isEnabled, value); }
        private bool _isEnabled;
        #endregion

        #region Animation
        public AnimationEase Animation { get => _animation; set => Set(ref _animation, value); }
        private AnimationEase _animation;
        #endregion 
    }

}
