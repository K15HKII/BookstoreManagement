using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Customer
{
    public partial class CustomerDetailViewModel : BaseViewModel
    {
        public void dismissDialog() { }

        [ObservableProperty] object? customerId;
        [ObservableProperty] object? customerName;
        [ObservableProperty] object? customerPhone;
        [ObservableProperty] object? customerBirth;
        [ObservableProperty] object? customerGender;
        [ObservableProperty] object? customerAddress;
        [ObservableProperty] object? customerFacebook;
        [ObservableProperty] object? customerInstagram;
        [ObservableProperty] object? orderBillQuantity;
        [ObservableProperty] object? boughtBillQuantity;
        [ObservableProperty] object? inComeCustomer;
        [ObservableProperty] object? customerCreateDate;
        
    }
}
