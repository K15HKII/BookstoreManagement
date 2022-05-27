using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.BookStore
{
    public partial class BookStoreViewModel : BaseViewModel<BookStoreNavigator>
    {
        // Thiếu mở dialog thêm sách
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsBooks;

        [ObservableProperty] public object? selectedBook;
    }
}
