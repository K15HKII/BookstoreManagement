using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Customer
{
    public partial class AddCustomerViewModel : BaseViewModel
    {
        public void dismissDialog() { }

        [ObservableProperty] object? customerId;
        [ObservableProperty] object? customerName;
        [ObservableProperty] object? customerUserName;
        [ObservableProperty] object? customerPassword;
        [ObservableProperty] object? customerConfirmPassword;
        [ObservableProperty] object? customerGender;
        [ObservableProperty] object? customerPhone;
        [ObservableProperty] object? customerBirth;
        [ObservableProperty] object? customerCreateDate;
        [ObservableProperty] object? customerEmail;
    }
}
