using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Order
{
    public partial class OrderBillViewModel : BaseViewModel
    {
        public void dismissDialog() { }

        public void confirmOrder() {  }

        [ObservableProperty] object? customerName;
        [ObservableProperty] object? customerPhone;
        [ObservableProperty] object? customerEmail;
        [ObservableProperty] object? customerAddress;
        [ObservableProperty] object? paymentMethod;

        //Voucher thì đã có adapter binding sẵn trong VoucherWindow
        [ObservableProperty] ObservableCollection<object>? lsVoucherApply;
        [ObservableProperty] ObservableCollection<object>? lsOrderBooks;
        [ObservableProperty] object? bookPrice;
        [ObservableProperty] object? billStatus;
        [ObservableProperty] object? billNote;
        [ObservableProperty] object? allBookPrice;
        [ObservableProperty] object? shippingFee;
        [ObservableProperty] object? discountPrice;
        [ObservableProperty] object? totalMoney;

    }
}
