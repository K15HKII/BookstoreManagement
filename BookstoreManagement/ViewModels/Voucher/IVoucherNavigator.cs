using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.Voucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Voucher
{
    public interface IVoucherNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();

        Task<VoucherUpdateRequest?> OpenAddVoucherDialog(UpdateVoucherViewModel viewModel);
    }
}
