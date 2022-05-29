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
using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter
{
    public partial class SupplierInfoViewModel : BaseViewModel<ISupplierInfoNavigator>, IDialog
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public SupplierInfoViewModel(ISupplierInfoNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }
        
        [ObservableProperty] object? supplierId;

        [ObservableProperty] object? supplierName;

        [ObservableProperty] object? supplierEmail;

        [ObservableProperty] object? supplierCoopDate;

        [ObservableProperty] object? supplierType;

        [ObservableProperty] object? supplierQuantity;
        public event Action<object?>? CloseAction;
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
