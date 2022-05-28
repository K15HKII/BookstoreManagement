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

        public BookProfileAddRequest? OpenNewBookDialog(AddBookViewModel viewModel)
        {
            Task<object?> task = _dialogService.Show(viewModel);
            task.Wait();
            object? value = task.Result;
            if (value == null)
                return null;
            return value as BookProfileAddRequest;
        }
    }
}
