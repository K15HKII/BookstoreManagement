using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.DialogView.Voucher;

public interface IVoucherDetailNavigator: INavigator
{
    Task<VoucherUpdateRequest?> OpenEditVoucherDialog(UpdateVoucherViewModel viewModel);
}