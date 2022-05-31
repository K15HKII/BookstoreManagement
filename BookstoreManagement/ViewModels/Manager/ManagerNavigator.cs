using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Model.Api.Customer;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Manager;

namespace BookstoreManagement.ViewModels.Manager;

public class ManagerNavigator : IManagerNavigator
{
    private readonly IDialogService _dialogService;

    public ManagerNavigator(IDialogService dialogService)
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

    public UserAddRequest? OpenNewEmployeeDialog(AddEmployeeViewModel viewModel)
    {
        Task<object?> task = _dialogService.Show(viewModel);
        task.Wait();
        object? value = task.Result;
        if (value == null)
            return null;
        return value as UserAddRequest;
    }
}