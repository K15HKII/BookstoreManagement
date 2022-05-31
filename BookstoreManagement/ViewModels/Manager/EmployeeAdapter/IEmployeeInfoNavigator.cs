using BookstoreManagement.ViewModels.DialogView.Customer;
using BookstoreManagement.ViewModels.DialogView.Manager;

namespace BookstoreManagement.ViewModels.Manager.EmployeeAdapter;

public interface IEmployeeInfoNavigator : INavigator
{
    object? OpenEditEmployeeDialog(EditEmployeeViewModel viewModel); //TODO: return edit request
}