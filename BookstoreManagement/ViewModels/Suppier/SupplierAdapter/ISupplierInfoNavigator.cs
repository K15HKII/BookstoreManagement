using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter;

public interface ISupplierInfoNavigator : INavigator
{
    object? OpenEditSupplierDialog(EditSupplierViewModel viewModel); //TODO: return edit request
}