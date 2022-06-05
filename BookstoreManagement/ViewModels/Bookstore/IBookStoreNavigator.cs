using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.BookStore;

namespace BookstoreManagement.ViewModels.BookStore
{
    public interface IBookStoreNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();

        Task<BookUpdateRequest?> OpenUpdateBookDialog(UpdateBookViewModel viewModel);

    }
}
