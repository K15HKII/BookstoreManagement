using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.DialogView.Manager;
using Microsoft.Toolkit.Mvvm.Input;
using System.Reactive.Linq;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.Manager.EmployeeAdapter;

namespace BookstoreManagement.ViewModels.Manager
{
    public partial class ManagerViewModel : PanelViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IManagerNavigator _navigator;

        public ManagerViewModel(IManagerNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
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
                EmployeeInfoViewModel vm = _factory.Create<EmployeeInfoViewModel>();
                vm.SetEmployee(user);
                Quantity++;
                return vm;
            })), users =>
            {
                LsEmployees.Clear();
                foreach (var vm in users)
                {
                    LsEmployees.Add(vm);
                }
            });
        }
        // Thiếu mở dialog thêm nhân viên, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] private ObservableCollection<EmployeeInfoViewModel>? _lsEmployees = new();

        [ObservableProperty] private ObservableCollection<EmployeeInfoViewModel> _selectedemployee = new();

        [ObservableProperty] private int _quantity = 0;
        
        [ICommand]
        public async void AddNew()
        {
            UserUpdateRequest? request = await _navigator.OpenNewEmployeeDialog(_factory.Create<UpdateEmployeeViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
