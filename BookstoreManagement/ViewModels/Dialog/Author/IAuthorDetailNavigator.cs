using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.DialogView.Supplier;

public interface IAuthorDetailNavigator : INavigator
{
    Task<PublisherUpdateRequest> OpenEditAuthorDialog(UpdateSupplierViewModel viewModel);
}