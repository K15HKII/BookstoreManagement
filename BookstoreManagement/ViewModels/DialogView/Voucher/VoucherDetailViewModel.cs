﻿using System;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Voucher;

public partial class VoucherDetailViewModel : BaseViewModel<IVoucherDetailNavigator>, IDialog
{
    private readonly IViewModelFactory _factory;
    private readonly IModelRemote _model;

    public VoucherDetailViewModel(IVoucherDetailNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
    {
        _factory = factory;
        _model = model;
    }

    //TODO:thêm thuộc tính voucher
    [ObservableProperty] object? _id;

    [ObservableProperty] string? _name;

    [ObservableProperty] string? _description;

    [ObservableProperty] object? _discountType;

    [ObservableProperty] object? _discount;

    [ObservableProperty] DateTime? _usedAt;

    [ObservableProperty] object? _userId;

    [ObservableProperty] DateTime? _expiredDate;

    [ObservableProperty] DateTime? _releaseDate;

    [ObservableProperty] object? _profileId;

    [ObservableProperty] string? _usedQuantity;


    public event Action<object?>? CloseAction;
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(null);
    }
    
    [ICommand]
    public void OpenEdit()
    {
        //TODO: cast to edit request
        object? request = Navigator!.OpenEditVoucherDialog(_factory.Create<EditVoucherViewModel>());

        if (request == null)
            return;

        //TODO: send request to server
    }
}