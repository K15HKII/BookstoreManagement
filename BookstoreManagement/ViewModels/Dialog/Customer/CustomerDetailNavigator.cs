using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.Dialog.Customer;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;
using BookstoreManagement.ViewModels.DialogView.Customer.Password;
using BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;

namespace BookstoreManagement.ViewModels.DialogView.Customer;

public class CustomerDetailNavigator : ICustomerDetailNavigator
{
    private readonly IDialogService _dialogService;

    public CustomerDetailNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
    
    public async Task<UserUpdateRequest?> OpenEditCustomerDialog(UpdateCustomerViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel,"edit");
        if (value == null)
            return null;
        return value as UserUpdateRequest;
    }

    public object? OpenChangePassWord(EditPassWordViewModel viewModel)
    {
        throw new System.NotImplementedException();
    }

    public object? OpenSocialLink(SocialLinkViewModel viewModel)
    {
        throw new System.NotImplementedException();
    }

    public object? OpenDeleteCustomer(DeleteAccountViewModel viewModel)
    {
        throw new System.NotImplementedException();
    }
}