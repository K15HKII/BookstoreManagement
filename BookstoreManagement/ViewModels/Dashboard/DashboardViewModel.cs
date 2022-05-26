using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Dashboard
{
    public partial class DashboardViewModel : BaseViewModel<DashboardNavigator>
    {

        //TODO: còn chart
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] object? TotalCollect;
        [ObservableProperty] object? CollectGrowPercent;

        [ObservableProperty] object? TotalPay;
        [ObservableProperty] object? PayGrowPercent;

        [ObservableProperty] object? TotalSoldProducts;
        [ObservableProperty] object? SoldProductsGrowPercent;

        [ObservableProperty] object? WaitingConfirmOrders;

        [ObservableProperty] object? ShippingOrders;

        [ObservableProperty] ObservableCollection<object>? lsUsers;

        [ObservableProperty] ObservableCollection<object>? lsBooks;
    }
}
