using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels.Components;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Report
{
    public partial class ReportPanelViewModel : BaseViewModel<IReportNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public ReportPanelViewModel(IReportNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        [ICommand]
        public void AddNewStatistic()
        {
            //TODO: 
        }

        [ObservableProperty] private ObservableCollection<StatisticViewModel> _statistic;

        [ObservableProperty] private StatisticViewModel _selected;
    }
}
