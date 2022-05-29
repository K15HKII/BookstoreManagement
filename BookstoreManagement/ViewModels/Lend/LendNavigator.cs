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

    public LendAddRequest? OpenNewLendBillDialog(AddLendBillViewModel viewModel)
    {
        Task<object?> task = _dialogService.Show(viewModel);
        task.Wait();
        object? value = task.Result;
        if (value == null)
            return null;
        return value as LendAddRequest;
    }
}