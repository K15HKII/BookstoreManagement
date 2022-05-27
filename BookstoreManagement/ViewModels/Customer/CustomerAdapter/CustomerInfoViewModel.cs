using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Customer.CustomerAdapter
{
    public class CustomerInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? CustomerName;

        [ObservableProperty] object? CustomerEmail;

        [ObservableProperty] object? CustomerType;

        [ObservableProperty] object? BillQuantity;

        [ObservableProperty] object? CustomerInCome;

        [ObservableProperty] object? CreateDate;
    }
}
