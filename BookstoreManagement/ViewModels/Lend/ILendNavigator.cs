using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView;

namespace BookstoreManagement.ViewModels.Lend
{
    public interface ILendNavigator : INavigator
    {
        void openAccountScreen();

        void openNotificationScreen();
        
        Task<LendUpdateRequest?> OpenNewLendBillDialog(UpdateLendBillViewModel viewModel);
    }
}
