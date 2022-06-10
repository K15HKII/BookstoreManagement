using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView;

namespace BookstoreManagement.ViewModels.Lend.LendAdapter;

public class LendInfoNavigator : ILendInfoNavigator
{
    private readonly IDialogService _dialogService;

    public LendInfoNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
    public object? OpenInfoLendDialog(LendBillDetailViewModel viewModel)
    {
        object? value = _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value;
    }
}