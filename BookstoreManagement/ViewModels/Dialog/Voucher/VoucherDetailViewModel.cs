using System;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Voucher;

public partial class VoucherDetailViewModel : BaseViewModel, IDialog
{
    private readonly IViewModelFactory _factory;
    private readonly IModelRemote _model;
    private readonly IVoucherDetailNavigator _navigator;

    public VoucherDetailViewModel(IVoucherDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
    {
        _navigator = navigator;
        _factory = factory;
        _model = model;
    }
    
    public void SetVoucher(VoucherProfile voucher)
    {
        current = voucher;
        this.Id = voucher.Id;
        this.Name = voucher.Discount + "% " + voucher.Name;
        this.Discount = voucher.Discount + "%";
        this.Description = voucher.Description;
        this.ApplyType = "Áp dụng cho sách thể loại ";
        for(int i = 0;i< voucher.RequireBookTags.Count;i++)
        {
            if(i==voucher.RequireBookTags.Count-1)
            {
                this.ApplyType += voucher.RequireBookTags[i];
            }
            else
            {
                this.ApplyType += voucher.RequireBookTags[i] + ", ";
            }
        }

        this.RequireMinValue = "Áp dụng cho đơn hàng từ " + voucher.RequireMinValue + "đ";
    }

    private VoucherProfile current;
    
    [ObservableProperty] private string _id;
    
    [ObservableProperty] string? _name;

    [ObservableProperty] string? _description;

    [ObservableProperty] string? _requireMinValue;

    [ObservableProperty] string? _applyType;

    [ObservableProperty] DiscountType? _discountType;

    [ObservableProperty] string? _discount;



    public event Action<object?>? CloseAction;
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(null);
    }
    
    [ICommand]
    public void OpenEdit()
    {
        UpdateVoucherViewModel vm = _factory.Create<UpdateVoucherViewModel>();
        vm.SetVoucher(current);
        object? request = _navigator.OpenEditVoucherDialog(vm);

        if (request == null)
            return;

        //TODO: send request to server
    }
}