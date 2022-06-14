using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data;

namespace BookstoreManagement.ViewModels;

public abstract partial class BaseLendBillViewModel : BaseViewModel
{

    private readonly IModelRemote _model;

    public BaseLendBillViewModel([NotNull] ScheluderProvider scheluderProvider, Data.Remote.IModelRemote model) : base(scheluderProvider)
    {
        this._model = model;
    }

    public string? SetLend(Data.Model.Api.Lend lend)
    {
        this.Type = lend.GetType;
        this.LendDate = lend.StartDate;
        this.LendExpired = lend.EndDate;
        this.Price = lend.UnitPrice;
        this.BookId = lend.BookId;
        Dispose(_model.GetBook(lend.BookId), book =>
        {
            LendBookName = book.Title;
        });
        Dispose(_model.GetUser(lend.UserId), user =>
        {
            CustomerName = user.FullName;
        });
        //TODO: getBookImage /*this.BookImage */
        this.UserId = lend.UserId;

        return "";
    }

    [ObservableProperty]
    private string? _voucher;

    [ObservableProperty]
    [Required]
    private double? _price;

    [ObservableProperty]
    private string? _userId;

    [ObservableProperty]
    [Required]
    private object? _type;

    [ObservableProperty]
    [Required]
    private DateTime? _lendDate;

    [ObservableProperty]
    [Required]
    private DateTime? _lendExpired;

    [ObservableProperty]
    private string? _bookImage;

    [ObservableProperty]
    private string? _bookId;

    [ObservableProperty]
    private string? _note;

    [ObservableProperty]
    [Required]
    private string? _lendBookName;

    [ObservableProperty]
    [Required]
    private string? _customerId;

    [ObservableProperty]
    [Required]
    private string? _customerName;

}

