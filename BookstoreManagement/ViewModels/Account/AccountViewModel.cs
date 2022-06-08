using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.Account;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;
using BookstoreManagement.ViewModels.DialogView.Customer.Password;
using BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Account
{
    public partial class AccountViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IAccountNavigator _navigator;

        public AccountViewModel(IAccountNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }

        //Thiếu dialog đổi mật khẩu và đổi thông tin cá nhân
        public void BackWard() { }
        
        [ObservableProperty] object? _id;

        [ObservableProperty] object? _name;

        [ObservableProperty] object? _email;

        [ObservableProperty] object? _phoneNum;

        [ObservableProperty] object? _createDate;

        [ObservableProperty] object? _gender;

        [ObservableProperty] object? _address;

        [ObservableProperty] object? _facebook;

        [ObservableProperty] object? _instagram;
        
        [ICommand]
        public void EditAccount()
        {
            UserEditRequest? request = _navigator.OpenEditAccount(_factory.Create<EditAccountViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
        
        [ICommand]
        public void OpenChangePass()
        {
            //TODO: cast to edit request
            object? request = _navigator.OpenChangePassWord(_factory.Create<EditPassWordViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
        
        [ICommand]
        public void OpenSocialLink()
        {
            //TODO: cast to edit request
            object? request = _navigator.OpenSocialLink(_factory.Create<SocialLinkViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
        
        [ICommand]
        public void OpenDeleteAccount()
        {
            //TODO: cast to edit request
            object? request = _navigator.OpenDeleteAccount(_factory.Create<DeleteAccountViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
