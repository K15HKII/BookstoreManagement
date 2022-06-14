using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier
{
    public interface IAuthorNavigator : INavigator
    {
        Task<PublisherUpdateRequest?> OpenNewAuthorDialog(UpdateSupplierViewModel viewModel);
    }
}
