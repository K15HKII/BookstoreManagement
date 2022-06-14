using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Windows.Documents;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.Order;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter
{
    public partial class OrderInfoViewModel : BaseViewModel, ICRUD
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IOrderInfoNavigator _navigator;

        public OrderInfoViewModel(IOrderInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,
            IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }

        public void SetOrder(Bill bill)
        {
            current = bill;
            this.Id = "#" + bill.Id;
            this.Date = bill.CreatedAt.ToString("dd/MM/yyyy");
            this.Status = bill.BillStatus ?? BillStatus.WAITING;
            Dispose(_model.GetUser(bill.UserId), user => { this.Owner = user.FirstName + user.LastName; });
            double temp = 0;
            for (int i = 0; i < bill.ListBillDetail.Count; i++)
            {
                temp += bill.ListBillDetail[i].UnitPrice;
            }
            this.Price = temp.ToString("C") + "đ";
        }

        private Bill current; 

        [ObservableProperty] private BillStatus _status;

        [ObservableProperty] string? _id;

        [ObservableProperty] string? _date;

        [ObservableProperty] string? _owner;

        [ObservableProperty] string? _price;

        [ObservableProperty] object? _bookId;

        [ICommand]
        public async void OpenInfo()
        {
            OrderBillViewModel vm = _factory.Create<OrderBillViewModel>();
            vm.DialogCRUDEvent += DialogCRUDEvent;
            vm.setOrder(current);
            await _navigator.OpenDetailOrdedrDialog(vm);
        }

        public event DialogCRUDEventHandler? DialogCRUDEvent;
    }
}