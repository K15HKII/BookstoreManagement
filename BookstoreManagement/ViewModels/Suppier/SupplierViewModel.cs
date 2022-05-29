using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Supplier;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Suppier
{
    public partial class SupplierViewModel : BaseViewModel<ISupplierNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public SupplierViewModel(ISupplierNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }
        
        // Thiếu mở dialog thêm nhà cung cấp, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsSuppliers;

        [ObservableProperty] public object? selectedSupplier;
        
        [ICommand]
        public void AddNew()
        {
            PublisherAddRequest? request = Navigator!.OpenNewSupplierDialog(_factory.Create<AddSupplierViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
