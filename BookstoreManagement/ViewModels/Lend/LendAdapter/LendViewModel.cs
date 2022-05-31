using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.BookStore;

namespace BookstoreManagement.ViewModels.Lend.LendAdapter
{
    public partial class LendViewModel : BaseViewModel
    {
        [ObservableProperty] string? _id;

        [ObservableProperty] string? _userId;

        [ObservableProperty] object? _start;

        [ObservableProperty] object? _end;

        [ObservableProperty] ObservableCollection<BaseBookViewModel>? _books;

        [ObservableProperty] bool? _selected;
    }
}
