using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.Supplier
{
    public partial class EditSupplierViewModel : BaseViewModel
    {
        //TODO: thiết kế nhà cung cấp chưa đúng còn thiếu
        public void dismissDialog() { }

        [ObservableProperty] object? supplierImage;
        [ObservableProperty] object? supplierId;
        [ObservableProperty] object? supplierName;
        [ObservableProperty] object? supplierAddress;
        [ObservableProperty] object? supplierCoopDate;
        [ObservableProperty] object? supplierBookType;
        [ObservableProperty] object? supplierPhone;
        [ObservableProperty] object? supplierEmail;
    }
}
