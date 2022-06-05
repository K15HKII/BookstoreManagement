using BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;
using BookstoreManagement.ViewModels.DialogView.Customer.Password;
using BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;

namespace BookstoreManagement.ViewModels.DialogView.Customer;

public class CustomerDetailNavigator : ICustomerDetailNavigator
{
    public object? OpenEditCustomerDialog(EditCustomerViewModel viewModel)
    {
        throw new System.NotImplementedException();
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