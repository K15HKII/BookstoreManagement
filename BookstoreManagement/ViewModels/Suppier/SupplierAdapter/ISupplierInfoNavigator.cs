using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter;

public interface ISupplierInfoNavigator : INavigator
{
    object? OpenDetailSupplierDialog(SupplierDetailViewModel viewModel); //TODO: return edit request
}