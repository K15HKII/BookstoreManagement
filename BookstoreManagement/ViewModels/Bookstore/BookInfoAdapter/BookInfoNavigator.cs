using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.BookStore;

namespace BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;

public class BookInfoNavigator : IBookInfoNavigator
{
    private readonly IDialogService _dialogService;

    public BookInfoNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }

    public object? OpenInfoBookDialog(BookDialogViewModel viewModel)
    {
        object? value = _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value;
    }
}