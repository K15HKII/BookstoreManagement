using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.DialogView.Supplier;

public interface ISupplierDetailNavigator : INavigator
{
    Task<PublisherUpdateRequest> OpenEditSupplierDialog(UpdateSupplierViewModel viewModel);
}