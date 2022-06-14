using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.Customer;
using BookstoreManagement.ViewModels.DialogView.Manager;

namespace BookstoreManagement.ViewModels.Manager.EmployeeAdapter;

public interface IEmployeeInfoNavigator : INavigator
{
    Task<object?> OpenDetailEmployeeDialog(EmployeeDetailViewModel viewModel); //TODO: return edit request
}