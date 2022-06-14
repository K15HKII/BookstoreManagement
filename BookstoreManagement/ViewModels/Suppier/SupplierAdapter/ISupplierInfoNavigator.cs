using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter;

public interface ISupplierInfoNavigator : INavigator
{
    Task<object?> OpenDetailSupplierDialog(SupplierDetailViewModel viewModel); //TODO: return edit request
}