using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Services;

namespace BookstoreManagement.ViewModels.DialogView.Voucher;

public class VoucherDetailNavigator : IVoucherDetailNavigator
{
    private readonly IDialogService _dialogService;

    public VoucherDetailNavigator(IDialogService dialogService)
    {
        _dialogService = dialogService;
    }
    public async Task<VoucherUpdateRequest?> OpenEditVoucherDialog(UpdateVoucherViewModel viewModel)
    {
        object value = await _dialogService.Show(viewModel,"edit");
        if (value == null)
            return null;
        return value as VoucherUpdateRequest;
    }
}