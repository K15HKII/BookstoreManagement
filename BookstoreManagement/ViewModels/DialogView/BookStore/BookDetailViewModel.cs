using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.BookStore
{
    public partial class BookDetailViewModel
    {
        [ObservableProperty] object? bookId;
        [ObservableProperty] object? bookName;
        [ObservableProperty] ObservableCollection<object>? lsBookImage;
        [ObservableProperty] object? bookPrice;
        [ObservableProperty] object? bookDiscount;
        [ObservableProperty] object? bookPriceAfterDis;
        [ObservableProperty] object? bookQuantity;
        [ObservableProperty] object? bookSoldQuantity;
        [ObservableProperty] object? bookSupplier;
        [ObservableProperty] object? bookType;
        [ObservableProperty] object? bookDiscription;

        public void dismissDialog() { }
    }
}
