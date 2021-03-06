using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.Customer;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Reactive.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.Customer.adapter;
using BookstoreManagement.ViewModels.Dialog.Customer;

namespace BookstoreManagement.ViewModels.Customer
{
    public partial class CustomerPanelViewModel : PanelViewModel
    {
        
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ICustomerNavigator _navigator;
        int count = 0;

        public CustomerPanelViewModel(ICustomerNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
            Initialize();
        }

        private void Initialize()
        {
            Dispose(_model.GetUsers().Select(users => users.Select(user =>
            {
                CustomerInfoViewModel vm = _factory.Create<CustomerInfoViewModel>();
                count++;
                Quantity++;
                vm.SetUser(user,count);
                return vm;
            })), books =>
            {
                Customers.Clear();
                foreach (var vm in books)
                {
                    Customers.Add(vm);
                }
            });
        }

        // Thiếu mở dialog thêm khách hàng và filter và xoá

        [ObservableProperty] public ObservableCollection<CustomerInfoViewModel>? _customers = new();

        [ObservableProperty] private int _quantity = 0;

        [ObservableProperty] string? _name;

        [ObservableProperty] string? _email;


        [ICommand]
        public async void AddNew()
        {
            UserUpdateRequest? request = await _navigator.openUpdateCustomerDialog(_factory.Create<UpdateCustomerViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
