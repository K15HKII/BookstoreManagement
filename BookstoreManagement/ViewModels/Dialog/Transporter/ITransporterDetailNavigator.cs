using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.DialogView.Supplier;

public interface ITransporterDetailNavigator : INavigator
{
    Task<PublisherUpdateRequest> OpenEditTransporterDialog(UpdateSupplierViewModel viewModel);
}