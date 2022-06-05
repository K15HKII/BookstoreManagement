using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.BookStore;

namespace BookstoreManagement.ViewModels.BookStore
{
    public class BookStoreNavigator : IBookStoreNavigator
    {

        private readonly IDialogService _dialogService;

        public BookStoreNavigator(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public void openAccountScreen()
        {
            throw new NotImplementedException();
        }

        public void openNotificationScreen()
        {
            throw new NotImplementedException();
        }

        public async Task<BookUpdateRequest?> OpenUpdateBookDialog(UpdateBookViewModel viewModel)
        {
            object? value = await _dialogService.Show(viewModel);
            if (value == null)
                return null;
            return value as BookUpdateRequest;
        }
    }
}
