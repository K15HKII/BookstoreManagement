using System.Threading.Tasks;
using BookstoreManagement.ViewModels.DialogView;

namespace BookstoreManagement.ViewModels.Lend.LendAdapter;

public interface ILendInfoNavigator : INavigator
{
    Task<object?> OpenInfoLendDialog(LendBillDetailViewModel viewModel);
}