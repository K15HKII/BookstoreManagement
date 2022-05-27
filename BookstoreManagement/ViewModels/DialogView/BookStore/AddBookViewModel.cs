using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.DialogView.BookStore
{
    public partial class AddBookViewModel : BaseViewModel
    {
        public void dismissDialog() { }

        [ObservableProperty] object? bookId;
        [ObservableProperty] object? bookName;
        [ObservableProperty] object? bookPrice;
        [ObservableProperty] object? bookQuantity;
        [ObservableProperty] object? bookSupplier;
        [ObservableProperty] object? bookType;
        [ObservableProperty] ObservableCollection<object>? lsBookImage;
        [ObservableProperty] object? bookDescription;
    }
}
