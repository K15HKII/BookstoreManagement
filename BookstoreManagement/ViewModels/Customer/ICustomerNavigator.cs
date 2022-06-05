using BookstoreManagement.Data.Model.Api.Customer;
using BookstoreManagement.ViewModels.DialogView.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Customer
{
    public interface ICustomerNavigator : INavigator
    {

        UserAddRequest? openAddCustomerDialog(AddCustomerViewModel viewModel);
    }
}
