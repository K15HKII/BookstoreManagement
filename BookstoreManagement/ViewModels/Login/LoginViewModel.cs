using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Login
{
    public partial class LoginViewModel : BaseViewModel<ILoginNavigator>
    {

        private readonly IAuthenticator _authenticator;

        public LoginViewModel(ScheluderProvider scheluder, IAuthenticator authenticator, ILoginNavigator navigator) : base(scheluder)
        {
            _authenticator = authenticator;
            Navigator = navigator;
        }

        [ObservableProperty] [Required]
        private string? _username;

        [ObservableProperty] [Required] private string? _password;

        [ICommand]
        public void Login()
        {
            ValidateAllProperties();

            if (HasErrors)
            {
                return;
            }

            IsLoading = true;
            Dispose(_authenticator.Authenticate(Username!, Password!), res =>
            {
                IsLoading = false;
                Navigator!.openApp();
            });
        }

    }
}
