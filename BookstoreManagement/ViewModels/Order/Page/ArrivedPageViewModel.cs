using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Order.Page
{
    public partial class ArrivedPageViewModel : BaseViewModel
    {
        [ObservableProperty] public ObservableCollection<object>? lsOrders;

        [ObservableProperty] public object? selectedOrder;
    }
}
