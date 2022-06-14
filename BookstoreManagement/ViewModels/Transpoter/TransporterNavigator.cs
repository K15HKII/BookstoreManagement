using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier;

public class TransporterNavigator : ITransporterNavigator
{
    private readonly IDialogService _dialogService;

    public TransporterNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
    
    public async Task< PublisherUpdateRequest?> OpenNewTransporterDialog(UpdateSupplierViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value as PublisherUpdateRequest;
    }
}