using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.Dialog.Customer;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;
using BookstoreManagement.ViewModels.DialogView.Customer.Password;
using BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Customer
{
    public partial class CustomerDetailViewModel : BaseUserViewModel, IDialog
    {
        //TODO: thiếu function cho cập nhật
        
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;
        private readonly ICustomerDetailNavigator _navigator;

        public CustomerDetailViewModel(ICustomerDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider, model)
        {
            _navigator = navigator;
            _model = model;
            _factory = factory;
        }

        [ObservableProperty] private string? _createAt;
        [ObservableProperty] private string? _phone;
        [ObservableProperty] private string? _birthDay;
        [ObservableProperty] private string? _gender;
        [ObservableProperty] private string? _address;
        [ObservableProperty] private Image? _image;

        public event Action<object?>? CloseAction;
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public async void OpenEdit()
        {
            UpdateCustomerViewModel vm = _factory.Create<UpdateCustomerViewModel>();
            vm.SetUser(current);
            object? request = await _navigator.OpenEditCustomerDialog(vm);

            if (request == null)
                return;

            //TODO: send request to server
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
            object? request = _navigator.OpenDeleteCustomer(_factory.Create<DeleteAccountViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
        
    }
}
