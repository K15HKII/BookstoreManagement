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
    public partial class ManagerViewModel : BaseViewModel<IManagerNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public ManagerViewModel(IManagerNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
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
            UserAddRequest? request = Navigator!.OpenNewEmployeeDialog(_factory.Create<AddEmployeeViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
