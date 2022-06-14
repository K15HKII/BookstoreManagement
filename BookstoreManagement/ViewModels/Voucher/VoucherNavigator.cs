using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Voucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Voucher
{
    public class VoucherNavigator : IVoucherNavigator
    {
        private readonly IDialogService _dialogService;

        public VoucherNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public void openAccountScreen()
        {
            throw new NotImplementedException();
        }

        public async Task<VoucherUpdateRequest?> OpenAddVoucherDialog(AddVoucherViewModel viewModel)
        {
            object value = await _dialogService.Show(viewModel);
            if (value == null)
                return null;
            return value as VoucherUpdateRequest;
        }

        public void openNotificationScreen()
        {
            throw new NotImplementedException();
        }
    }
}
