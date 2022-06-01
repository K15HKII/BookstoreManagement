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
    public partial class CustomerPanelViewModel : BaseViewModel<ICustomerNavigator>
    {
       

        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public CustomerPanelViewModel(ICustomerNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }
        
        // Thiếu mở dialog thêm khách hàng và filter và xoá
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? _lscustomers;

        [ObservableProperty] public object? selectedBook;


        [ICommand]
        public void AddNew()
        {
            UserAddRequest? request = Navigator!.openAddCustomerDialog(_factory.Create<AddCustomerViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
