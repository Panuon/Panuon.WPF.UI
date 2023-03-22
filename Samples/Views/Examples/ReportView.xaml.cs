using Panuon.WPF;
using Panuon.WPF.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            RefreshList(1);
        }

        private void RingProgressBar_GeneratingPercentText(object sender, GeneratingPercentTextRoutedEventArgs e)
        {
            e.Text = $"{Math.Floor(e.Value * 0.2)} pcs";
        }

        private void Pagination_CurrentPageChanged(object sender, SelectedValueChangedRoutedEventArgs<int> e)
        {
            RefreshList(e.NewValue);
        }

        private void RefreshList(int pageIndex)
        {
            var startNumber = (pageIndex - 1) * 5;
            dataGrid.ItemsSource = new List<MachineItem>()
            {
                new MachineItem("M00000" + startNumber, "Working", "N/A") { Type = MachineType.UX_10 },
                new MachineItem("M00000" + startNumber + 1, "Working", "N/A"),
                new MachineItem("M00000" + startNumber + 2, "Working", "N/A"),
                new MachineItem("M00000" + startNumber * 5 + 3, "Repairing", "N/A"),
                new MachineItem("M00000" + startNumber * 5 + 4, "Repairing", "N/A"),
            };
        }

    }

    public enum MachineType
    {
        UX_01,
        UX_02,
        UX_10,
    }

    public class MachineItem : NotifyPropertyChangedBase
    {
        #region Ctor
        public MachineItem(string code, string state, string remark)
        {
            Code = code;
            State = state;
            Remark = remark;
        }
        #endregion

        #region Properties
        [ColumnWidth(Width = "0.5*")]
        [ColumnDisplayIndex(1)]
        public string State { get => _state; set => Set(ref _state, value); }
        private string _state;


        [ColumnWidth(Width = "400")]
        [ColumnDisplayIndex(2)]
        public string Remark { get => _remark; set => Set(ref _remark, value); }
        private string _remark;

        [DisplayName("Machine Code")]
        [ColumnWidth(Width = "*")]
        [ColumnDisplayIndex(0)]
        public string Code { get => _code; set => Set(ref _code, value); }
        private string _code;

        [DisplayName("Machine Type")]
        [ColumnWidth(Width = "100")]
        [ColumnDisplayIndex(3)]
        public MachineType Type { get => _type; set => Set(ref _type, value); }
        private MachineType _type;
        #endregion
    }
}