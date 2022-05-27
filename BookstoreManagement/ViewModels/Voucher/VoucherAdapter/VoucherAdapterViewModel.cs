using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Voucher.VoucherAdapter
{
    public class VoucherAdapterViewModel : BaseViewModel
    {
        [ObservableProperty] object? VoucherTitle;

        [ObservableProperty] object? VoucherDescription;

        [ObservableProperty] object? VoucherExpire;

        [ObservableProperty] object? VoucherMaxUse;

        [ObservableProperty] object? VoucherUsedQuantity;

        [ObservableProperty] object? VoucherApplyType;
    }
}
