using BookstoreManagement.ViewModels.DialogView.Voucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Voucher.VoucherAdapter
{
    public interface IVoucherAdapterNavigator : INavigator
    {
        Task<object?> OpenDetailVoucherDialog(VoucherDetailViewModel viewModel);
    }
}
