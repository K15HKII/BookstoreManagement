using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;

namespace BookstoreManagement.ViewModels.DialogView.Supplier;

public class AuthorDetailNavigator : IAuthorDetailNavigator
{
    private readonly IDialogService _dialogService;

    public AuthorDetailNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }

    
    public async Task<PublisherUpdateRequest> OpenEditAuthorDialog(UpdateSupplierViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel,"edit");
        if (value == null)
            return null;
        return value as PublisherUpdateRequest;
    }
}