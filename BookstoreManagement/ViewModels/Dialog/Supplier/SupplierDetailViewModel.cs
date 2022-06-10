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
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.Manager.EmployeeAdapter;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Supplier
{
    public partial class SupplierDetailViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;
        private readonly ISupplierDetailNavigator _navigator;

        public SupplierDetailViewModel(ISupplierDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _model = model;
            _factory = factory;
        }
        
        public void SetPublisher(Publisher publisher)
        {
            this.Id = publisher.Id;
            this.Name = publisher.Name;
            this.Description = publisher.Description;
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
        [ObservableProperty] object? _description;
        
        public event Action<object?>? CloseAction;
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public void OpenEdit()
        {
            /*//TODO: cast to edit request
            object? request = _navigator.OpenEditSupplierDialog(_factory.Create<EditSupplierViewModel>());

            if (request == null)
                return;

            //TODO: send request to server*/
        }
    }
}
