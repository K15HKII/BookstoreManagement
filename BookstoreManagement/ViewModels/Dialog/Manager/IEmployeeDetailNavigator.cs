using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.DialogView.Manager;

public interface IEmployeeDetailNavigator : INavigator
{
    Task<UserUpdateRequest> OpenEditEmployee(UpdateEmployeeViewModel viewModel);
}