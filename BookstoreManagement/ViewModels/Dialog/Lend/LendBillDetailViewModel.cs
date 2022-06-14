using System;
using System.Linq;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView;

public partial class LendBillDetailViewModel : BaseLendBillViewModel, IDialog
{
    private readonly IModelRemote _model;
    private readonly IViewModelFactory _factory;
    private readonly ILendBillDetailNavigator _navigator;

    public LendBillDetailViewModel(ILendBillDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,
        IViewModelFactory factory, IModelRemote model) : base(scheluderProvider, model)
    {
        _navigator = navigator;
        _model = model;
        _factory = factory;
    }
    
    [ObservableProperty] string? _id;

    [ObservableProperty] string? _userId;
        
    [ObservableProperty] string? _userName;
     
    [ObservableProperty] string? _userPhone;

    [ObservableProperty] private string? _userEmail;

    [ObservableProperty] string? _userImage;

    [ObservableProperty] string? _price;
    
    [ObservableProperty] Payment _payment;

    [ObservableProperty] DateTime? _start;

    [ObservableProperty] DateTime? _end;

    [ObservableProperty] object? _state;

    [ObservableProperty] string? _bookId;

    [ObservableProperty] private string? _bookName;

    [ObservableProperty] private Image _bookImage;

    [ObservableProperty] private string? _bookPrice;

    [ObservableProperty] bool? _selected;

    [ObservableProperty] private LendStatus? _status;

    [ObservableProperty] private string? _totalPrice;

    [ObservableProperty] private string _fee;
    
    public void SetLend(Data.Model.Api.Lend lend)
    {
        this.Id = lend.Id;
        this.UserId = lend.UserId;
        Dispose(_model.GetUser(lend.UserId), user =>
        {
            this.UserName = user.FirstName + user.LastName;
            this.UserPhone = user.Phone;
            this.UserEmail = user.Email;
        });
        this.Price = lend.UnitPrice.ToString("C") + "đ";
        this.BookId = lend.BookId;
        Dispose(_model.GetBook(lend.BookId), book =>
        {
            this.BookName = book.Title;
            this.BookImage = book.Images.FirstOrDefault();
            this.BookPrice = book.Price + "đ";
        });
        this.Start = lend.StartDate;
        this.End = lend.EndDate;
        this.Status = lend.Status;
        this.Payment = lend.Payment;
        this.Fee = lend.UnitPrice + "đ";
        this.TotalPrice = this.Fee;
    }
    
    public event Action<object?>? CloseAction;
    
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(null);
    }
}