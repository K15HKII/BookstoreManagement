using BookstoreManagement.ViewModels.DialogView.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.Customer
{
    public interface ICustomerNavigator : INavigator
    {

        Task<UserUpdateRequest?> openAddCustomerDialog(AddCustomerViewModel viewModel);
    }
}
