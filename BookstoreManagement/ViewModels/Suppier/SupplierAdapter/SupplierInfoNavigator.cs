using BookstoreManagement.ViewModels.DialogView.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Manager;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter
{
    public class SupplierInfoNavigator : ISupplierInfoNavigator
    {
        private readonly IDialogService _dialogService;

        public SupplierInfoNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }
        public async Task<object?> OpenDetailSupplierDialog(SupplierDetailViewModel viewModel)
        {
            object? value = await _dialogService.Show(viewModel);
            if (value == null)
                return null;
            return value;
        }
    }
}
