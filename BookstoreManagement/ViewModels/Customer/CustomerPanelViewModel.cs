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

namespace BookstoreManagement.ViewModels.Customer
{
    public partial class CustomerPanelViewModel : PanelViewModel
    {
        
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ICustomerNavigator _navigator;

        public CustomerPanelViewModel(ICustomerNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
            Initialize();
        }

        private void Initialize()
        {
            Dispose(_model.getListUser().Select(users => users.Select(user =>
            {
                CustomerInfoViewModel vm = _factory.Create<CustomerInfoViewModel>();
                vm.SetUser(user);
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

        [ObservableProperty] string? _name;

        [ObservableProperty] string? _email;


        [ICommand]
        public async void AddNew()
        {
            UserUpdateRequest? request = await _navigator.openAddCustomerDialog(_factory.Create<AddCustomerViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
