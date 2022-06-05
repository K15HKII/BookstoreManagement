namespace BookstoreManagement.ViewModels.DialogView.Voucher;

public interface IVoucherDetailNavigator: INavigator
{
    object? OpenEditVoucherDialog(EditVoucherViewModel viewModel);
}