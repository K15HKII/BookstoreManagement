using BookstoreManagement.ViewModels.DialogView.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.Dialog.Customer;

namespace BookstoreManagement.ViewModels.Customer
{
    public interface ICustomerNavigator : INavigator
    {

        Task<UserUpdateRequest?> openUpdateCustomerDialog(UpdateCustomerViewModel viewModel);
    }
}
