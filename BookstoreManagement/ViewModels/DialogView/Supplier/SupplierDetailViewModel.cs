using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Supplier
{
    public partial class SupplierDetailViewModel : BaseViewModel, IDialog
    {
        public void dismissDialog() { }
        [ObservableProperty] object? supplierId;
        [ObservableProperty] object? supplierName;
        [ObservableProperty] object? supplierPhone;
        [ObservableProperty] object? supplierEmail;
        [ObservableProperty] object? supplierAddress;
        [ObservableProperty] object? supplierBookQuantity;
        [ObservableProperty] object? supplierBookType;
        [ObservableProperty] object? supplierCoopDate;
        
        public event Action<object?>? CloseAction;
    }
}
