namespace BookstoreManagement.ViewModels.DialogView.Supplier;

public interface ISupplierDetailNavigator : INavigator
{
    object? OpenEditSupplierDialog(EditSupplierViewModel viewModel);
}