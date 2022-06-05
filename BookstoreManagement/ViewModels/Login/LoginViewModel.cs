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
    public partial class LoginViewModel : BaseViewModel
    {

        private readonly IAuthenticator _authenticator;
        private readonly ILoginNavigator _navigator;

        public LoginViewModel(ScheluderProvider scheluder, IAuthenticator authenticator, ILoginNavigator navigator) : base(scheluder)
        {
            _authenticator = authenticator;
            _navigator = navigator;
            Username = "admin";
            Password = "admin";
            Login();
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
                if (res)
                    _navigator.openApp();
            });
        }

    }
}
