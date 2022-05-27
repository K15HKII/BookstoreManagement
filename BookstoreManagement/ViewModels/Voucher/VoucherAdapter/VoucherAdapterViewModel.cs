using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Voucher.VoucherAdapter
{
    public partial class VoucherAdapterViewModel : BaseViewModel
    {
        [ObservableProperty] object? voucherTitle;

        [ObservableProperty] object? voucherDescription;

        [ObservableProperty] object? voucherExpire;

        [ObservableProperty] object? voucherMaxUse;

        [ObservableProperty] object? voucherUsedQuantity;

        [ObservableProperty] object? voucherApplyType;
    }
}
