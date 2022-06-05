using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api.Customer;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.DialogView.Manager;

namespace BookstoreManagement.ViewModels.Manager
{
    public partial class ManagerViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IManagerNavigator _navigator;

        public ManagerViewModel(IManagerNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }
        // Thiếu mở dialog thêm nhân viên, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? _lsEmployees;

        [ObservableProperty] public object? _selectedemployee;
        
        public void AddNew()
        {
            UserAddRequest? request = _navigator.OpenNewEmployeeDialog(_factory.Create<AddEmployeeViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
