using System;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Customer.DeleteAccount;

public partial class DeleteAccountViewModel : BaseViewModel, IDialog
{
    private readonly IModelRemote _model;

    public DeleteAccountViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
    {
        _model = model;
    }
    
    //TODO: thêm function cho xoá tài khoản
    
    public event Action<object?>? CloseAction;
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(null);
    }
}