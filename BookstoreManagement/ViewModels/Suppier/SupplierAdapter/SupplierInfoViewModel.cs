using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter
{
    public partial class SupplierInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? supplierId;

        [ObservableProperty] object? supplierName;

        [ObservableProperty] object? supplierEmail;

        [ObservableProperty] object? supplierCoopDate;

        [ObservableProperty] object? supplierType;

        [ObservableProperty] object? supplierQuantity;
    }
}
