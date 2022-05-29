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

    public PublisherAddRequest? OpenNewSupplierDialog(AddSupplierViewModel viewModel)
    {
        Task<object?> task = _dialogService.Show(viewModel);
        task.Wait();
        object? value = task.Result;
        if (value == null)
            return null;
        return value as PublisherAddRequest;
    }
}