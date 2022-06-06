using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;

namespace BookstoreManagement.ViewModels.DialogView.BookStore;

public class BookDetailNavigator : IBookDetailNavigator
{

    private readonly IDialogService _dialogService;

    public BookDetailNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }

    public async Task<BookUpdateRequest?> OpenEditBookDialog(UpdateBookViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value as BookUpdateRequest;
    }
}