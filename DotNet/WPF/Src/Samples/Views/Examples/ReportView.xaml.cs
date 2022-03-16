using Panuon.UI.Core;
using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Samples.Views.Examples
{
    /// <summary>
    /// ReportView.xaml 的交互逻辑
    /// </summary>
    [ExampleView(Index = 0, DisplayName = "Report")]
    public partial class ReportView : WindowX
    {
        public ReportView()
        {
            InitializeComponent();
            dataGrid.ItemsSource = new List<Machine>()
            {
                new Machine("M000000", "Working", "N/A"),
                new Machine("M000001", "Working", "N/A"),
                new Machine("M000002", "Working", "N/A"),
                new Machine("M000003", "Repairing", "N/A"),
                new Machine("M000004", "Repairing", "N/A"),
            };
        }

        private void RingProgressBar_GeneratingPercentText(object sender, GeneratingPercentTextRoutedEventArgs e)
        {
            e.Text = $"{Math.Floor(e.Value * 0.2)} pcs";
        }

        private void Pagination_CurrentPageChanged(object sender, SelectedValueChangedEventArgs<int> e)
        {
            dataGrid.ItemsSource = new List<Machine>()
            {
                new Machine("M00000" + (e.NewValue - 1) * 5, "Working", "N/A"),
                new Machine("M00000" + ((e.NewValue - 1) * 5 + 1), "Working", "N/A"),
                new Machine("M00000" + ((e.NewValue - 1) * 5 + 2), "Working", "N/A"),
                new Machine("M00000" + ((e.NewValue - 1) * 5 + 3), "Repairing", "N/A"),
                new Machine("M00000" + ((e.NewValue - 1) * 5 + 4), "Repairing", "N/A"),
            };
        }
    }
    public class Machine : NotifyPropertyChangedBase
    {
        #region Ctor
        public Machine(string code, string state, string remark)
        {
            Code = code;
            State = state;
            Remark = remark;
        }
        #endregion

        #region Properties
        [DisplayName("Machine Code")]
        [ColumnWidth(Width = "*")]
        public string Code { get => _name; set => Set(ref _name, value); }
        private string _name;

        [ColumnWidth(Width = "0.5*")]
        public string State { get => _state; set => Set(ref _state, value); }
        private string _state;

        [ColumnWidth(Width = "400")]
        public string Remark { get => _remark; set => Set(ref _remark, value); }
        private string _remark;
        #endregion
    }
}