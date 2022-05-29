﻿using BookstoreManagement.Annotations;
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

        [ObservableProperty] object? totalCollect;
        [ObservableProperty] object? collectGrowPercent;

        [ObservableProperty] object? totalPay;
        [ObservableProperty] object? payGrowPercent;

        [ObservableProperty] object? totalSoldProducts;
        [ObservableProperty] object? soldProductsGrowPercent;

        [ObservableProperty] object? waitingConfirmOrders;

        [ObservableProperty] object? shippingOrders;

        [ObservableProperty] ObservableCollection<object>? lsUsers;

        [ObservableProperty] ObservableCollection<object>? lsBooks;
    }
}
