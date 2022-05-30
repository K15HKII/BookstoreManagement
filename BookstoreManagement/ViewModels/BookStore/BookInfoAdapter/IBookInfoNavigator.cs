using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.BookStore;

namespace BookstoreManagement.ViewModels.BookStore.BookInfoAdapter
{
    public interface IBookInfoNavigator : INavigator
    {

        object? OpenInfoBookDialog(BookDetailViewModel viewModel); //TODO: return edit request

    }
}
