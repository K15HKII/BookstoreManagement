using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter
{
    public class OrderInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? OrderID;

        [ObservableProperty] object? OrderDate;

        [ObservableProperty] object? OrderOwner;

        [ObservableProperty] object? OrderPrice;
    }
}
