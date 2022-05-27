using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView
{
    public partial class AddLendBillViewModel : BaseViewModel
    {
        public void dismissDialog() { }

        [ObservableProperty] object? lendCustomerId;
        [ObservableProperty] object? lendCustomerName;
        [ObservableProperty] object? lendCustomerPhone;
        [ObservableProperty] object? lendCustomerAddress;
        [ObservableProperty] object? lendBookId;
        [ObservableProperty] object? lendBookName;
        [ObservableProperty] object? lendBookQuantity;
        [ObservableProperty] object? lendBookPrice;
        [ObservableProperty] object? lendBookType;
        [ObservableProperty] object? lendDate;
        [ObservableProperty] object? lendExpired;
        [ObservableProperty] object? lendNote;
        
    }
}
