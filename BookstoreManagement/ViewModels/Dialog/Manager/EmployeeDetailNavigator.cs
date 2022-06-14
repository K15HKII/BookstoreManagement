using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.Manager.EmployeeAdapter;

namespace BookstoreManagement.ViewModels.DialogView.Manager;

public class EmployeeDetailNavigator : IEmployeeDetailNavigator
{
    private readonly IDialogService _dialogService;

    public EmployeeDetailNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }

    public async Task<UserUpdateRequest> OpenEditEmployee(UpdateEmployeeViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel,"edit");
        if (value == null)
            return null;
        return value as UserUpdateRequest;
    }
}