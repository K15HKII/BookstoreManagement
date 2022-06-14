using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier
{
    public interface ITransporterNavigator : INavigator
    {
        Task<PublisherUpdateRequest?> OpenNewTransporterDialog(UpdateSupplierViewModel viewModel);
    }
}
