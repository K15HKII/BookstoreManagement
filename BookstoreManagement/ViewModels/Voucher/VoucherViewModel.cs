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
using BookstoreManagement.ViewModels.DialogView.Voucher;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Voucher
{
    public partial class VoucherViewModel : BaseViewModel<IVoucherNavigator>
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public VoucherViewModel(IVoucherNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        //Thiếu dialog thêm voucher
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<object>? lsVouchers;

        [ObservableProperty] public object? selectedVoucher;
        
        [ICommand]
        public void AddNew()
        {
            VoucherAddRequest? request = Navigator!.OpenAddVoucherDialog(_factory.Create<AddVoucherViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }
    }
}
