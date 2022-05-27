using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter
{
    public class SupplierInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? SupplierId;

        [ObservableProperty] object? SupplierName;

        [ObservableProperty] object? SupplierEmail;

        [ObservableProperty] object? SupplierCoopDate;

        [ObservableProperty] object? SupplierType;

        [ObservableProperty] object? SupplierQuantity;
    }
}
