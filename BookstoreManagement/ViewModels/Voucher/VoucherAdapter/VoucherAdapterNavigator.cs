using System.Threading.Tasks;
using BookstoreManagement.Services;
using BookstoreManagement.ViewModels.DialogView.Voucher;

namespace BookstoreManagement.ViewModels.Voucher.VoucherAdapter;

public class VoucherAdapterNavigator : IVoucherAdapterNavigator
{
    private readonly IDialogService _dialogService;

    public VoucherAdapterNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
    public async Task<object?> OpenDetailVoucherDialog(VoucherDetailViewModel viewModel)
    {
        object? value = await _dialogService.Show(viewModel);
        if (value == null)
            return null;
        return value;
    }
}