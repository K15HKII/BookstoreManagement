﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using BookstoreManagement.ViewModels.DialogView.Supplier;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Suppier
{
    public partial class SupplierViewModel : BaseViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ISupplierNavigator _navigator;

        public SupplierViewModel(ISupplierNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }

        // Thiếu mở dialog thêm nhà cung cấp, xoá, filter
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? _lsSuppliers = new();

        [ObservableProperty] public object? _selectedSupplier = new();
        
        [ICommand]
        public async void AddNew()
        {
            PublisherUpdateRequest? request = await _navigator.OpenNewSupplierDialog(_factory.Create<AddSupplierViewModel>());
            if (request == null)
                return;

            Dispose(_model.CreatePublisher(request!), book =>
            {
                Console.WriteLine("Publisher created successfully");
                /*Initialize();*/
                //TODO: Notify
            });
        }
    }
}
