using System;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Account;

public partial class EditAccountViewModel : BaseViewModel, IDialog
{
    private readonly IModelRemote _model;

    public EditAccountViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
    {
        _model = model;
    }
    
    //TODO: thêm property cho dialog
    
    public UserEditRequest? ToEditRequest()
    {
        ValidateAllProperties();

        if (HasErrors)
            return null;

        return new UserEditRequest()
        {

        };
    }
    
    public event Action<object?>? CloseAction;
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(ToEditRequest());
    }
}