using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Home.BookAdapter
{
    public partial class BookAdapterViewModel : BaseViewModel
    {
        [ObservableProperty] object? bookImage;

        [ObservableProperty] object? bookID;

        [ObservableProperty] object? bookType;

        [ObservableProperty] object? bookPrice;

        [ObservableProperty] object? bookSupplier;

        [ObservableProperty] object? bookStatus;

        [ObservableProperty] object? soldQuantity;

    }
}
