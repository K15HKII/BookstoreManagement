using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView.BookStore;

namespace BookstoreManagement.ViewModels.BookStore.BookInfoAdapter
{
    public interface IBookInfoNavigator : INavigator
    {
        Task<object?> OpenInfoBookDialog(BookDialogViewModel viewModel); //TODO: return edit request

    }
}
