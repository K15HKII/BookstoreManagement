using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BookstoreManagement.ViewModels.Order.Page
{
    public class WaitingConfirmPageViewModel : BaseViewModel
    {
        [ObservableProperty] public ObservableCollection<object>? lsOrders;

        [ObservableProperty] public object? selectedOrder;
    }
}
