using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;
using BookstoreManagement.ViewModels.Components;
using BookstoreManagement.ViewModels.Customer.CustomerAdapter;
using BookstoreManagement.ViewModels.DialogView.BookStore;

namespace BookstoreManagement.ViewModels.Dashboard
{
    public partial class DashboardViewModel : BaseViewModel<IDashboardNavigator>
    {
        
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public DashboardViewModel(IDashboardNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        //TODO: còn chart
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] private ObservableCollection<StatisticViewModel> _mainStatistics = new();

        [ObservableProperty] int? _waitingOrders;

        [ObservableProperty] int? _shippingOrders;

        [ObservableProperty] ObservableCollection<CustomerViewModel>? _userList;

        [ObservableProperty] ObservableCollection<BookDialogViewModel>? _bookList;
        
    }
}
