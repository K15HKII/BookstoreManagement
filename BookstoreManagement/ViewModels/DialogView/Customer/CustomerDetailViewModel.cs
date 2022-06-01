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
    public partial class CustomerDetailViewModel : BaseViewModel<ICustomerDetailNavigator>, IDialog
    {
        //TODO: thiếu function cho cập nhật
        
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;

        public CustomerDetailViewModel(ICustomerDetailNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _model = model;
            _factory = factory;
        }

        [ObservableProperty] object? _id;
        [ObservableProperty] object? _name;
        [ObservableProperty] object? _image;
        [ObservableProperty] object? _phone;
        [ObservableProperty] object? _birth;
        [ObservableProperty] object? _gender;
        [ObservableProperty] object? _address;
        [ObservableProperty] object? _faceBook;
        [ObservableProperty] object? _instagram;
        [ObservableProperty] object? _orderBillQuantity;
        [ObservableProperty] object? _boughtBillQuantity;
        [ObservableProperty] object? _incomeCustomer;
        [ObservableProperty] object? _customerCreateDate;

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
            object? request = Navigator!.OpenEditCustomerDialog(_factory.Create<EditCustomerViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
        
        [ICommand]
        public void OpenChangePass()
        {
            //TODO: cast to edit request
            object? request = Navigator!.OpenChangePassWord(_factory.Create<EditPassWordViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
        
        [ICommand]
        public void OpenSocialLink()
        {
            //TODO: cast to edit request
            object? request = Navigator!.OpenSocialLink(_factory.Create<SocialLinkViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
        
        [ICommand]
        public void OpenDeleteAccount()
        {
            //TODO: cast to edit request
            object? request = Navigator!.OpenDeleteCustomer(_factory.Create<DeleteAccountViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
        
    }
}
