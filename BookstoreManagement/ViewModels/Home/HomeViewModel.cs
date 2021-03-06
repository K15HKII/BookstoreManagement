using System.Collections.ObjectModel;
using BookstoreManagement.Annotations;
using BookstoreManagement.Services;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.Customer;
using BookstoreManagement.ViewModels.Dashboard;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.Home;
using BookstoreManagement.ViewModels.Lend;
using BookstoreManagement.ViewModels.Manager;
using BookstoreManagement.ViewModels.Order;
using BookstoreManagement.ViewModels.Rating;
using BookstoreManagement.ViewModels.Report;
using BookstoreManagement.ViewModels.Suppier;
using BookstoreManagement.ViewModels.Voucher;
using MaterialDesignThemes.Wpf;
using Microsoft.Extensions.Logging;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {

        [ObservableProperty] private ObservableCollection<BaseViewModel> _tabContents;

        [ObservableProperty] private int _selectedIndex = 0;

        private readonly ILogger<HomeViewModel> _logger;
        private readonly IDialogService _dialogService;
        private readonly IViewModelFactory _factory;
        private readonly IHomeNavigator _navigator;

        public HomeViewModel(IHomeNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IDialogService dialogService, ILogger<HomeViewModel> logger) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _dialogService = dialogService;
            _logger = logger;
            _tabContents = new()
            {
                factory.Create<DashBoardPanelViewModel>(),
                factory.Create<ReportPanelViewModel>(),
                factory.Create<BookPanelViewModel>(),
                factory.Create<OrderViewModel>(),
                factory.Create<VoucherPanelViewModel>(),
                factory.Create<AuthorViewModel>(),
                factory.Create<CustomerPanelViewModel>(),
                factory.Create<ManagerViewModel>(),
                factory.Create<SupplierViewModel>(),
                factory.Create<TransporterViewModel>()
            };
        }

        [ICommand]
        public async void TestDialog()
        {
            await DialogHost.Show(_factory.Create<UpdateBookViewModel>());
        }

        [ICommand]
        public void Logout()
        {
            _navigator.Logout();
        }

        [ICommand]
        public void OpenSetting()
        {
            _navigator.OpenSetting();
        }

    }
}
