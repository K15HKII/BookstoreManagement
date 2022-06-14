using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter;

public interface IAuthorInfoNavigator : INavigator
{
    Task<object?> OpenDetailAuthorDialog(SupplierDetailViewModel viewModel); //TODO: return edit request
}