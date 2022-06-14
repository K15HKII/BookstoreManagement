using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.Dialog.Customer;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;
using BookstoreManagement.ViewModels.DialogView.Customer.Password;
using BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;

namespace BookstoreManagement.ViewModels.DialogView.Customer;

public interface ICustomerDetailNavigator : INavigator
{
    Task<UserUpdateRequest?> OpenEditCustomerDialog(UpdateCustomerViewModel viewModel);

    object? OpenChangePassWord(EditPassWordViewModel viewModel);

    object? OpenSocialLink(SocialLinkViewModel viewModel);

    object? OpenDeleteCustomer(DeleteAccountViewModel viewModel);
}