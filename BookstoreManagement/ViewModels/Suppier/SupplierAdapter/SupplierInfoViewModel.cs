﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;
using BookstoreManagement.ViewModels.DialogView.Supplier;

namespace BookstoreManagement.ViewModels.Suppier.SupplierAdapter
{
    public partial class SupplierInfoViewModel : BaseViewModel, IDialog
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly ISupplierInfoNavigator _navigator;

        public SupplierInfoViewModel(ISupplierInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }
        
        [ObservableProperty] object? _id;

        [ObservableProperty] object? _image;

        [ObservableProperty] object? _name;

        [ObservableProperty] object? _email;

        [ObservableProperty] object? _coopDate;

        [ObservableProperty] object? _type;

        [ObservableProperty] object? _quantity;
        public event Action<object?>? CloseAction;
        public void OpenDetail()
        {
            //TODO: cast to edit request
            object? request = _navigator.OpenDetailSupplierDialog(_factory.Create<SupplierDetailViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }
    }
}
