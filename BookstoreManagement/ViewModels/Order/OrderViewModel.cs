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
            Dispose(_model.GetBills(), bills =>
            {
                UpdateBills(bills.Select(bill =>
                {
                    OrderInfoViewModel vm = _factory.Create<OrderInfoViewModel>();
                    vm.DialogCRUDEvent += Initialize;
                    Quantity++;
                    vm.SetOrder(bill);
                    return vm;
                }));
            });
        }

        private void UpdateBills(IEnumerable<OrderInfoViewModel> vms)
        {
            Bills.Clear();
            foreach (var vm in vms)
            {
                Bills.Add(vm);
            }
            Filter(Bills, WaitingBills, vm => vm.Status == BillStatus.WAITING);
            Filter(Bills, ShippingBills, vm => vm.Status == BillStatus.TRANSPORTING);
            Filter(Bills, RatingBills, vm => vm.Status == BillStatus.PROCESSING);
            Filter(Bills, FinishBills, vm => vm.Status == BillStatus.COMPLETED);
            Filter(Bills, CancelledLends, vm => vm.Status == BillStatus.CANCELED);
        }

        private void Filter(ObservableCollection<OrderInfoViewModel> from, ObservableCollection<OrderInfoViewModel> to,
            Predicate<OrderInfoViewModel> vm)
        {
            to.Clear();
            foreach (var orderInfoViewModel in from)
            {
                if (vm(orderInfoViewModel))
                {
                    to.Add(orderInfoViewModel);
                }
            }
        }

        [ObservableProperty] private ObservableCollection<OrderInfoViewModel> _bills = new();
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel> _waitingBills = new();
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel> _shippingBills = new();
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel> _ratingBills = new();
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel> _finishBills = new();
        [ObservableProperty] private ObservableCollection<OrderInfoViewModel> _cancelledLends = new();
        [ObservableProperty] private int _quantity = 0;

        [ObservableProperty] public ObservableCollection<object>? selectedBills;

        [ObservableProperty] public int? orderBillQuantity;
        
        [ICommand]
        public async void AddNew()
        {
            BillUpdateRequest? request = await _navigator.OpenNewOrderDialog(_factory.Create<UpdateOrderViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
