using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Report
{
    public partial class ReportViewModel : BaseViewModel<ReportNavigator>
    {
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
