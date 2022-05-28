using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Order.Adapter
{
    public partial class OrderItemViewModel : BaseViewModel
    {
        [ObservableProperty] object? bookImage;
        [ObservableProperty] object? bookType;
        [ObservableProperty] object? bookQuantity;
        [ObservableProperty] object? bookPrice;
    }
}
