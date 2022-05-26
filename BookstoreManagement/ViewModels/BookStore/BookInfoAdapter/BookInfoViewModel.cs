using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.BookStore.BookInfoAdapter
{
    public class BookInfoViewModel
    {
        [ObservableProperty] object? BookImage;

        [ObservableProperty] object? BookName;

        [ObservableProperty] object? BookRate;

        [ObservableProperty] object? BookPrice;

        [ObservableProperty] object? BookSupplier;
    }
}
