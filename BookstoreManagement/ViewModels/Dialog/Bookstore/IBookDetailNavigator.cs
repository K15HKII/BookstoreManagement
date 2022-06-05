using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.DialogView.BookStore;

public interface IBookDetailNavigator : INavigator
{
    BookUpdateRequest? OpenEditBookDialog(UpdateBookViewModel viewModel);
}