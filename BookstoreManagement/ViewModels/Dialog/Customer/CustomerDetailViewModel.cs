using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
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

        public CustomerDetailViewModel(ICustomerDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _model = model;
            _factory = factory;
        }

        public event Action<object?>? CloseAction;
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public void OpenEdit()
        {
            //TODO: cast to edit request
            object? request = _navigator.OpenEditCustomerDialog(_factory.Create<EditCustomerViewModel>());

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
