using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Home.BookAdapter
{
    public class BookAdapterViewModel : BaseViewModel
    {
        [ObservableProperty] object? BookImage;

        [ObservableProperty] object? BookID;

        [ObservableProperty] object? BookType;

        [ObservableProperty] object? BookPrice;

        [ObservableProperty] object? BookSupplier;

        [ObservableProperty] object? BookStatus;

        [ObservableProperty] object? SoldQuantity;

    }
}
