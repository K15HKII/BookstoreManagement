using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Media;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.Components;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Customer;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
                    ++count;
                    string a = count.ToString();
                    vm.SetBook(book,a);
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

        [ObservableProperty] private SeriesCollection _seriesCollection = new SeriesCollection
        {
            new LineSeries
            {
                Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(3),
                    new ObservableValue(5),
                    new ObservableValue(2),
                    new ObservableValue(7),
                    new ObservableValue(7),
                    new ObservableValue(4)
                },
                PointGeometrySize = 0,
                StrokeThickness = 4,
                Fill = Brushes.Transparent
            },
            new LineSeries
            {
                Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(3),
                    new ObservableValue(4),
                    new ObservableValue(6),
                    new ObservableValue(8),
                    new ObservableValue(7),
                    new ObservableValue(5)
                },
                PointGeometrySize = 0,
                StrokeThickness = 4,
                Fill = Brushes.Transparent
            }
        };
        
        [ObservableProperty] private ObservableCollection<StatisticViewModel> _mainStatistics = new();

        [ObservableProperty] int? _waitingOrders;

        [ObservableProperty] int? _shippingOrders;

        [ObservableProperty] ObservableCollection<CustomerDetailViewModel> _userList = new();

        [ObservableProperty] ObservableCollection<BookDialogViewModel> _bookList = new();
    }
}