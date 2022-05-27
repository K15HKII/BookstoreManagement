using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter
{
    public partial class OrderInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? orderID;

        [ObservableProperty] object? orderDate;

        [ObservableProperty] object? orderOwner;

        [ObservableProperty] object? orderPrice;
    }
}
