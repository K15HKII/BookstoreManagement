using System;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.Order;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Order.OrderInfoAdapter
{
    public partial class OrderInfoViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IOrderInfoNavigator _navigator;

        public OrderInfoViewModel(IOrderInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }

        public void SetOrder(Bill bill)
        {
            this.Id = bill.Id;
        }

        [ObservableProperty] int? _id;

        [ObservableProperty] DateTime? _date;

        [ObservableProperty] object? _owner;

        [ObservableProperty] object? _price;

        [ObservableProperty] object? _bookId;

        [ObservableProperty] object? _unitPrice;

        [ICommand]
        public void OpenInfo()
        {
            //TODO: cast to edit request
            object? request = _navigator.OpenDetailOrdedrDialog(_factory.Create<OrderBillViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
