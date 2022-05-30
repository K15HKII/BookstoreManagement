namespace BookstoreManagement.ViewModels.DialogView.BookStore;

public interface IBookDetailNavigator : INavigator
{
    object? OpenEditBookDialog(EditBookViewModel viewModel);
}