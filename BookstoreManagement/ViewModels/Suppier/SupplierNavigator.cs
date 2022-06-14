using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier;

public class SupplierNavigator : ISupplierNavigator
{
    private readonly IDialogService _dialogService;

    public SupplierNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
    public void openAccountScreen()
    {
        throw new System.NotImplementedException();
    }

    public void openNotificationScreen()
    {
        throw new System.NotImplementedException();
    }

    public async Task< PublisherUpdateRequest?> OpenNewSupplierDialog(UpdateSupplierViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value as PublisherUpdateRequest;
    }
}