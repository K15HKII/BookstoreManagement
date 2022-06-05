namespace BookstoreManagement.ViewModels.DialogView.Manager;

public interface EmployeeDetailNavigator : INavigator
{
    object? OpenEditEmployee(EditEmployeeViewModel viewModel);
}