using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Report
{
    public partial class ReportViewModel : BaseViewModel<IReportNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public ReportViewModel(IReportNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        //TODO: thiếu mở dialog filter và thêm báo cáo, thiếu binding cho chart
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public object? totalCollect;
        [ObservableProperty] public object? collectGrowPercent;

        [ObservableProperty] public object? totalPay;
        [ObservableProperty] public object? payGrowPercent;

        [ObservableProperty] public object? totalSoldProducts;
        [ObservableProperty] public object? soldProductsGrowPercent;

        [ObservableProperty] public object? totalIncomeProducts;
        [ObservableProperty] public object? incomeProductsGrowPercent;
    }
}
