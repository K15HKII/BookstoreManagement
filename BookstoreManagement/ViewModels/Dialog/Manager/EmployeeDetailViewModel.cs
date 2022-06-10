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
    public partial class EmployeeDetailViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;
        private readonly IEmployeeInfoNavigator _navigator;

        public EmployeeDetailViewModel(IEmployeeInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _model = model;
            _factory = factory;
        }
        
        public void SetEmployee(User employee)
        {
            this.Id = employee.Id;
            this.Name = employee.FullName;
            this.Gender = employee.Gender.ToString();
            this.CreateDay = employee.CreateAt.Value.ToString("dd/MM/yyyy");
        }

        [ObservableProperty] object? _id;
        [ObservableProperty] object? _position;
        [ObservableProperty] object? _name;
        [ObservableProperty] object? _image;
        [ObservableProperty] object? _phone;
        [ObservableProperty] object? _birth;
        [ObservableProperty] object? _gender;
        [ObservableProperty] object? _address;
        [ObservableProperty] object? _dayOffs;
        [ObservableProperty] object? _dayOffMax;
        [ObservableProperty] object? _character;
        [ObservableProperty] object? _createDay;

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
            /*object? request = _navigator.OpenEditEmployeeDialog(_factory.Create<EditEmployeeViewModel>());

            if (request == null)
                return;
                */
        }
    }
}
