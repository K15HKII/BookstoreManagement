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
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Manager.EmployeeAdapter
{
    public partial class EmployeeInfoViewModel : BaseViewModel<IEmployeeInfoNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public EmployeeInfoViewModel(IEmployeeInfoNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        [ObservableProperty] object? _image;
        
        [ObservableProperty] object? _id;

        [ObservableProperty] object? _name;

        [ObservableProperty] object? _status;

        [ObservableProperty] object? _description;

        [ObservableProperty] object? _joinDate;

        [ObservableProperty] object? _dayOffQuantity;
        
        [ICommand]
        public void OpenEdit()
        {
            //TODO: cast to edit request
            object? request = Navigator!.OpenEditEmployeeDialog(_factory.Create<EditEmployeeViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
