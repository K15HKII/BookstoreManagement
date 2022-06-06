using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Order;
using BookstoreManagement.ViewModels.Order.OrderInfoAdapter;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Order
{
    public partial class OrderViewModel : PanelViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IOrderNavigator _navigator;

        public OrderViewModel(IOrderNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
            Initialize();
        }

        private void Initialize()
        {
            throw new NotImplementedException();
        }

        //TODO: Thiếu mở dialog xoá đơn và thêm đơn hàng

        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] private ObservableCollection<OrderInfoViewModel>? _waitingBills;
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel>? _shippingBills;
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel>? _ratingBills;
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel>? _finishBills;
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel>? _cancelledLends;

        [ObservableProperty] public ObservableCollection<object>? selectedBills;

        [ObservableProperty] public int? orderBillQuantity;
        
        [ICommand]
        public async void AddNew()
        {
            BillUpdateRequest? request = await _navigator.OpenNewOrderDialog(_factory.Create<AddOrderViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
