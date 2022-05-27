using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Voucher
{
    public partial class AddVoucherViewModel : BaseViewModel
    {
        public void dismissDialog() { }

        [ObservableProperty] object? voucherId;
        [ObservableProperty] object? voucherDiscount;
        [ObservableProperty] object? voucherQuantity;
        [ObservableProperty] object? voucherDateStr;
        [ObservableProperty] object? voucherDateExpr;
        [ObservableProperty] object? voucherMaxUse;
        [ObservableProperty] object? voucherCondition;
        [ObservableProperty] object? voucherMoreCondition;
    }
}
