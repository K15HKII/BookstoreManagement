using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.Manager.EmployeeAdapter;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Supplier
{
    public partial class SupplierDetailViewModel : BaseViewModel<ISupplierDetailNavigator>, IDialog
    {
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;

        public SupplierDetailViewModel(ISupplierDetailNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _model = model;
            _factory = factory;
        }
        
        [ObservableProperty] object? _id;
        [ObservableProperty] object? _image;
        [ObservableProperty] object? _name;
        [ObservableProperty] object? _phone;
        [ObservableProperty] object? _email;
        [ObservableProperty] object? _address;
        [ObservableProperty] object? _bookQuantity;
        [ObservableProperty] object? _bookType;
        [ObservableProperty] object? _coopDate;
        
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
            object? request = Navigator!.OpenEditSupplierDialog(_factory.Create<EditSupplierViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
