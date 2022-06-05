using BookstoreManagement.Data.Model.Api.Customer;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Customer
{
    public class CustomerNavigator : ICustomerNavigator
    {

        private readonly IDialogService _dialogService;

        public CustomerNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public UserAddRequest? openAddCustomerDialog(AddCustomerViewModel viewModel)
        {
            Task<object?> task = _dialogService.Show(viewModel);
            task.Wait();
            object? value = task.Result;
            if (value == null)
                return null;
            return value as UserAddRequest;
        }

        
    }
}
