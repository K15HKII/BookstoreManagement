using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.Customer
{
    public class CustomerNavigator : ICustomerNavigator
    {

        private readonly IDialogService _dialogService;

        public CustomerNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public async Task<UserUpdateRequest?> openAddCustomerDialog(AddCustomerViewModel viewModel)
        {
            object value = await _dialogService.Show(viewModel);
            if (value == null)
                return null;
            return value as UserUpdateRequest;
        }

        
    }
}
