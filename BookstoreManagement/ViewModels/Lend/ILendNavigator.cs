using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView;

namespace BookstoreManagement.ViewModels.Lend
{
    public interface ILendNavigator : INavigator
    {

        Task<LendUpdateRequest?> OpenNewLendBillDialog(UpdateLendBillViewModel viewModel);
    }
}
