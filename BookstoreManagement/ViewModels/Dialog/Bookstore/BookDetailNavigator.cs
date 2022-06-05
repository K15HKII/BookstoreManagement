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

    public BookUpdateRequest? OpenEditBookDialog(UpdateBookViewModel viewModel)
    {
        Task<object?> task = _dialogService.Show(viewModel);
        task.Wait();
        object? value = task.Result;
        if (value == null)
            return null;
        return value as BookUpdateRequest;
    }
}