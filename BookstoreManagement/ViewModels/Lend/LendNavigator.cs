using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView;

namespace BookstoreManagement.ViewModels.Lend;

public class LendNavigator : ILendNavigator
{
    private readonly IDialogService _dialogService;

    public LendNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
    public void openAccountScreen()
    {
        throw new System.NotImplementedException();
    }

    public void openNotificationScreen()
    {
        throw new System.NotImplementedException();
    }

    public async Task<LendUpdateRequest?> OpenNewLendBillDialog(UpdateLendBillViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value as LendUpdateRequest;
    }
}