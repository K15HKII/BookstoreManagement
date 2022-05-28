using System.Collections.ObjectModel;
using BookstoreManagement.Annotations;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.Customer;
using BookstoreManagement.ViewModels.Dashboard;
using BookstoreManagement.ViewModels.Home;
using BookstoreManagement.ViewModels.Lend;
using BookstoreManagement.ViewModels.Manager;
using BookstoreManagement.ViewModels.Order;
using BookstoreManagement.ViewModels.Rating;
using BookstoreManagement.ViewModels.Report;
using BookstoreManagement.ViewModels.Suppier;
using BookstoreManagement.ViewModels.Voucher;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels
{
    public partial class HomeViewModel : BaseViewModel<IHomeNavigator>
    {

        [ObservableProperty] public ObservableCollection<BaseViewModel> _tabContents;

        [ObservableProperty] public object? _selectedContent;

        public HomeViewModel([NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory) : base(scheluderProvider)
        {
            _tabContents = new()
            {
                factory.Create<DashboardViewModel>(),
                factory.Create<ReportViewModel>(),
                factory.Create<BookStoreViewModel>(),
                factory.Create<OrderViewModel>(),
                factory.Create<VoucherViewModel>(),
                factory.Create<RatingViewModel>(),
                factory.Create<CustomerViewModel>(),
                factory.Create<ManagerViewModel>(),
                factory.Create<SupplierViewModel>(),
                factory.Create<LendViewModel>()
            };

        }

        public void logOut() { }

        public void openSetting() { }

    }
}
