using BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;
using BookstoreManagement.ViewModels.DialogView.Customer.Password;
using BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;

namespace BookstoreManagement.ViewModels.DialogView.Customer;

public interface ICustomerDetailNavigator : INavigator
{
    object? OpenEditCustomerDialog(EditCustomerViewModel viewModel);

    object? OpenChangePassWord(EditPassWordViewModel viewModel);

    object? OpenSocialLink(SocialLinkViewModel viewModel);

    object? OpenDeleteCustomer(DeleteAccountViewModel viewModel);
}