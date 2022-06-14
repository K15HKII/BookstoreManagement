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
using BookstoreManagement.ViewModels.Manager.EmployeeAdapter;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Manager
{
    public partial class EmployeeDetailViewModel : BaseUserViewModel, IDialog
    {
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;
        private readonly IEmployeeDetailNavigator _navigator;

        public EmployeeDetailViewModel(IEmployeeDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider,model)
        {
            _navigator = navigator;
            _model = model;
            _factory = factory;
        }
        
        [ObservableProperty] object? _position;
        [ObservableProperty] object? _dayOffs;
        [ObservableProperty] object? _dayOffMax;
        [ObservableProperty] object? _character;

        public event Action<object?>? CloseAction;
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public async void OpenEdit()
        {
            UpdateEmployeeViewModel vm = _factory.Create<UpdateEmployeeViewModel>(); 
            vm.SetUser(current);
            object? request = await _navigator.OpenEditEmployee(vm);

            if (request == null)
                return;
        }
    }
}
