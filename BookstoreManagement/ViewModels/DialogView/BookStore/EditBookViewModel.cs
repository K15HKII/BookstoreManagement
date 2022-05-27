using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BookstoreManagement.ViewModels.DialogView.BookStore
{
    public partial class EditBookViewModel : BaseViewModel
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
