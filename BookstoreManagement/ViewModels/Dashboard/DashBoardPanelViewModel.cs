using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Media;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
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
            
            Dispose(_model.GetBills(), bills =>
            {
                chartCalculate(TimeUnit.DAY, bills);
            });
        }

        //TODO: còn chart
        public void chartCalculate(TimeUnit unit, List<Bill> bills)
        {
            DateTime[] dateTimes = bills.Select(bill => bill.CreatedAt).ToArray();
            DateTime min = dateTimes.Min();
            DateTime max = dateTimes.Max();
            chartCalculate(min, max, unit, bills);
        }
        
        public void chartCalculate(DateTime from, DateTime to, TimeUnit unit, List<Bill> bills)
        {
            long fromMilisecond = from.Miliseconds();
            long toMilisecond = to.Miliseconds();
            double per = unit.Miliseconds();

            double start = fromMilisecond;
            double next = fromMilisecond + per;

           List<ObservableValue> values = new();
            while (start < toMilisecond)
            {
                var filter = bills.Where(bill =>
                    {
                        var miliseconds = bill.CreatedAt.Miliseconds();
                        return miliseconds >= start && miliseconds < next;
                    })
                    .SelectMany(bill => bill.ListBillDetail);
                double sum = filter.Sum(x => x.UnitPrice * x.Quantity);
                values.Add(new ObservableValue(sum));
                start = next;
                next += per;
            }
            StatisticData = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservableValue>(values),
                    PointGeometrySize = 0,
                    StrokeThickness = 4,
                    Fill = Brushes.Transparent
                }
            };
        }
        
        [ObservableProperty] private SeriesCollection _statisticData;
        /*public SeriesCollection StatisticData
        {
            get => _statisticData;
            set {
                _statisticData = value;
                OnPropertyChanged(nameof(StatisticData));
            }   
        }*/
        
        [ObservableProperty] private ObservableCollection<StatisticViewModel> _mainStatistics = new();

        [ObservableProperty] int? _waitingOrders;

        [ObservableProperty] int? _shippingOrders;

        [ObservableProperty] ObservableCollection<CustomerDetailViewModel> _userList = new();

        [ObservableProperty] ObservableCollection<BookDialogViewModel> _bookList = new();
    }
}