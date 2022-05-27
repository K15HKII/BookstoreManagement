using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.BookStore.BookInfoAdapter
{
    public partial class BookInfoViewModel : BaseViewModel
    {
        [ObservableProperty] object? bookImage;

        [ObservableProperty] object? bookName;

        [ObservableProperty] object? bookRate;

        [ObservableProperty] object? bookPrice;

        [ObservableProperty] object? bookSupplier;
    }
}
