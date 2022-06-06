﻿using BookstoreManagement.Annotations;
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
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Order
{
    public partial class OrderViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IOrderNavigator _navigator;

        public OrderViewModel(IOrderNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }

        //TODO: Thiếu mở dialog xoá đơn và thêm đơn hàng

        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? tabContents;

        [ObservableProperty] public object? selectedContent;

        [ObservableProperty] public object? orderBillQuantity;
        
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
