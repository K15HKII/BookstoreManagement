using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Customer.CustomerAdapter
{
    public partial class CustomerInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? customerName;

        [ObservableProperty] object? customerEmail;

        [ObservableProperty] object? customerType;

        [ObservableProperty] object? billQuantity;

        [ObservableProperty] object? customerInCome;

        [ObservableProperty] object? createDate;
    }
}
