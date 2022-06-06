using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.DialogView.BookStore;

public interface IBookDetailNavigator : INavigator
{
    Task<BookUpdateRequest?> OpenEditBookDialog(UpdateBookViewModel viewModel);
}