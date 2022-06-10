using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer;
using BookstoreManagement.ViewModels.DialogView.Manager;
using BookstoreManagement.Data.Model.Api;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Manager.EmployeeAdapter
{
    public partial class EmployeeInfoViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IEmployeeInfoNavigator _navigator;

        public EmployeeInfoViewModel(IEmployeeInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }

        public void SetEmployee(User user)
        {
            this.user = user;
            this.Id = "#" + user.Id;
            this.Name = user.FirstName + user.LastName;
            this.JoinDate = user.CreateAt.Value.ToString("dd/MM/yyyy");
        }
        private User user;

        [ObservableProperty] string? _image;
        
        [ObservableProperty] string? _id;

        [ObservableProperty] string? _name;

        [ObservableProperty] object? _status;

        [ObservableProperty] object? _description;

        [ObservableProperty] string? _joinDate;

        [ObservableProperty] object? _dayOffQuantity;
        
        [ICommand]
        public void OpenInfo()
        {
            //TODO: cast to edit request
            EmployeeDetailViewModel vm = _factory.Create<EmployeeDetailViewModel>();
            vm.SetEmployee(this.user);
            object? request = _navigator.OpenDetailEmployeeDialog(vm);

            if (request == null)
                return;
            
        }
    }
}
