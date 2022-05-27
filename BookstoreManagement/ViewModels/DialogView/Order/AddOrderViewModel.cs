using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Order
{
    public partial class AddOrderViewModel : BaseViewModel
    {
        //Còn khúc thêm sách chưa rõ ràng

        [ObservableProperty] object? customerId;
        [ObservableProperty] object? customerName;
        [ObservableProperty] object? customerPhone;
        [ObservableProperty] object? customerAddress;

        [ObservableProperty] object? orderDescription;
    }
}
