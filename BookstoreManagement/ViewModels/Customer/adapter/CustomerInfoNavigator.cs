using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer;

namespace BookstoreManagement.ViewModels.Customer.adapter
{
    public class CustomerInfoNavigator : ICustomerInfoNavigator
    {
        private readonly IDialogService _dialogService;

        public CustomerInfoNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public async Task<object?> OpenDetailUserDialog(CustomerDetailViewModel viewModel)
        {
            object? value = await _dialogService.Show(viewModel);
            if (value == null)
                return null;
            return value;
        }
    }
}
