using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Suppier
{
    public partial class SupplierViewModel : BaseViewModel<SupplierNavigator>
    {
        // Thiếu mở dialog thêm nhà cung cấp, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsSuppliers;

        [ObservableProperty] public object? selectedSupplier;
    }
}
