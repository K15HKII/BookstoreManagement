using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Report
{
    public class ReportViewModel : BaseViewModel<ReportNavigator>
    {
        //TODO: thiếu mở dialog filter và thêm báo cáo, thiếu binding cho chart
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] object? TotalCollect;
        [ObservableProperty] object? CollectGrowPercent;

        [ObservableProperty] object? TotalPay;
        [ObservableProperty] object? PayGrowPercent;

        [ObservableProperty] object? TotalSoldProducts;
        [ObservableProperty] object? SoldProductsGrowPercent;

        [ObservableProperty] object? TotalIncomeProducts;
        [ObservableProperty] object? IncomeProductsGrowPercent;
    }
}
