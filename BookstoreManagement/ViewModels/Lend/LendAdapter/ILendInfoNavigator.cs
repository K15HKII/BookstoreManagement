using BookstoreManagement.ViewModels.DialogView;

namespace BookstoreManagement.ViewModels.Lend.LendAdapter;

public interface ILendInfoNavigator : INavigator
{
    object? OpenInfoLendDialog(LendBillDetailViewModel viewModel);
}