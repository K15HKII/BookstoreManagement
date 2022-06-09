using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.Components;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels.Dashboard
{
    public partial class DashBoardPanelViewModel : PanelViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IDashboardNavigator _navigator;
        int count = 0;

        public DashBoardPanelViewModel(IDashboardNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,
            IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
            Initialize();
        }

        protected void Initialize()
        {
            Dispose(_model.GetTopCustomers()
                .Select(users => users.Select(user =>
                {
                    CustomerDetailViewModel vm = _factory.Create<CustomerDetailViewModel>();
                    vm.SetUser(user);
                    return vm;
                })), users =>
            {
                UserList.Clear();
                foreach (var vm in users)
                {
                    UserList.Add(vm);
                }
            });

            Dispose(_model.GetBooks()
                .Select(books => books.Select(book =>
                {
                    BookDialogViewModel vm = _factory.Create<BookDialogViewModel>();
                    count++;
                    vm.SetBook(book,count);
                    return vm;
                })), books =>
            {
                BookList.Clear();
                foreach (var vm in books)
                {
                    BookList.Add(vm);
                }
            });
        }

        //TODO: còn chart

        [ObservableProperty] private ObservableCollection<StatisticViewModel> _mainStatistics = new();

        [ObservableProperty] int? _waitingOrders;

        [ObservableProperty] int? _shippingOrders;

        [ObservableProperty] ObservableCollection<CustomerDetailViewModel> _userList = new();

        [ObservableProperty] ObservableCollection<BookDialogViewModel> _bookList = new();
    }
}