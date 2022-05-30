using BookstoreManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api.Customer;
using BookstoreManagement.ViewModels.DialogView.Account;
using BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;
using BookstoreManagement.ViewModels.DialogView.Customer.Password;
using BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;

namespace BookstoreManagement.ViewModels.Account
{
    public class AccountNavigator : IAccountNavigator
    {
        private readonly IDialogService _dialogService;

        public AccountNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public void BackWard()
        {
            throw new NotImplementedException();
        }

        public UserEditRequest? OpenEditAccount(EditAccountViewModel viewModel)
        {
            Task<object?> task = _dialogService.Show(viewModel);
            task.Wait();
            object? value = task.Result;
            if (value == null)
                return null;
            return value as UserEditRequest;
        }

        public object? OpenChangePassWord(EditPassWordViewModel viewModel)
        {
            Task<object?> task = _dialogService.Show(viewModel);
            task.Wait();
            object? value = task.Result;
            if (value == null)
                return null;
            return value as UserEditRequest;
        }

        public object? OpenSocialLink(SocialLinkViewModel viewModel)
        {
            Task<object?> task = _dialogService.Show(viewModel);
            task.Wait();
            object? value = task.Result;
            if (value == null)
                return null;
            return value as UserEditRequest;
        }

        public object? OpenDeleteAccount(DeleteAccountViewModel viewModel)
        {
            Task<object?> task = _dialogService.Show(viewModel);
            task.Wait();
            object? value = task.Result;
            if (value == null)
                return null;
            return value as UserEditRequest;
        }
    }
}
