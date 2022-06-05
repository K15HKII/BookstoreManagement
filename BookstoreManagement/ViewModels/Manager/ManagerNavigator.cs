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

    public async Task< UserUpdateRequest?> OpenNewEmployeeDialog(AddEmployeeViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value as UserUpdateRequest;
    }
}