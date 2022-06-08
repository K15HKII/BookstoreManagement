using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.Account;
using BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;
using BookstoreManagement.ViewModels.DialogView.Customer.Password;
using BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;

namespace BookstoreManagement.ViewModels.Account
{
    public interface IAccountNavigator : INavigator
    {
        void BackWard();

        UserEditRequest? OpenEditAccount(EditAccountViewModel viewModel);
        
        object? OpenChangePassWord(EditPassWordViewModel viewModel);

        object? OpenSocialLink(SocialLinkViewModel viewModel);

        object? OpenDeleteAccount(DeleteAccountViewModel viewModel);
    }
}
