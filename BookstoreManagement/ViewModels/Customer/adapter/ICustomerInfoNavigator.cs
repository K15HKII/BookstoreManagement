using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.Customer;

namespace BookstoreManagement.ViewModels.Customer.adapter
{
    public interface ICustomerInfoNavigator : INavigator
    {
        Task<object?> OpenDetailUserDialog(CustomerDetailViewModel viewModel); //TODO: return edit request
    }
}
