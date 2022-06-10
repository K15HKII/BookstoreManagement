﻿using System;
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
            this.Id = "#" + bill.Id;
            this.Date = bill.CreatedAt.Value.ToString("dd/MM/yyyy");
            this.Status = bill.BillStatus ?? BillStatus.WAITING;
            User user = _model.GetUser(bill.UserId).Wait();
            this.Owner = user.FirstName + user.LastName;
            double temp = 0;
            for (int i = 0; i < bill.ListBillDetail.Capacity; i++)
            {
                temp += bill.ListBillDetail[i].UnitPrice;
            }
            this.Price = temp.ToString("C0") + "đ";
        }
        
        [ObservableProperty] private BillStatus _status;

        [ObservableProperty] string? _id;

        [ObservableProperty] string? _date;

        [ObservableProperty] string? _owner;
            
        [ObservableProperty] string? _price;

        [ObservableProperty] object? _bookId;
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
