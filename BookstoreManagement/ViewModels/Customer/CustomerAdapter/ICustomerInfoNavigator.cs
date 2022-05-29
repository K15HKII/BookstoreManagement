using BookstoreManagement.ViewModels.DialogView.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Customer.CustomerAdapter
{
    public interface ICustomerInfoNavigator : INavigator
    {
        object? OpenEditCustomerDialog(EditCustomerViewModel viewModel);
    }
}
