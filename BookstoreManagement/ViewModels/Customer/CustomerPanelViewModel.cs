using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api.Customer;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.Customer;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        
        // Thiếu mở dialog thêm khách hàng và filter và xoá

        [ObservableProperty] public ObservableCollection<object>? _lsCustomers = new();

        [ObservableProperty] public object? selectedBook = new();


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
