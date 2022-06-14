using System.Threading.Tasks;
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

    public async Task<object?> OpenInfoBookDialog(BookDialogViewModel viewModel)
    {
        object? value = await _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value;
    }

    object? IBookInfoNavigator.OpenInfoBookDialog(BookDialogViewModel viewModel)
    {
        throw new System.NotImplementedException();
    }
}