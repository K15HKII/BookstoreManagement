using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Login
{
    public partial class LoginViewModel : BaseViewModel<ILoginNavigator>
    {

        private readonly IAuthenticator _authenticator;

        public LoginViewModel(IAuthenticator authenticator)
        {
            _authenticator = authenticator;
        }

        [ObservableProperty]
        [Required]
        [MaxLength(16)]
        private string? _username;

        [ObservableProperty]
        [Required]
        private string? _password;

        [ICommand]
        public void Login()
        {
            ValidateAllProperties();

            if (HasErrors)
            {
                return;
            }

            _authenticator.Authenticate(Username!, Password!).Subscribe();
        }

}
