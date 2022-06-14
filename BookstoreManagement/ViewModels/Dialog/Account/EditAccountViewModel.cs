using System;
using System.ComponentModel.DataAnnotations;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
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
    [ObservableProperty] [Required]
    private string? _firstName;

    [ObservableProperty]
    [Required]
    private string? _lastName;

    [ObservableProperty]
    [Required]
    private string? _email;

    [ObservableProperty]
    [Required]
    private string? _phone;

    [ObservableProperty]
    [Required]
    private DateTime? _birth;

    public UserEditRequest? ToEditRequest()
    {
        ValidateAllProperties();

        if (HasErrors)
            return null;

        return new UserEditRequest()
        {
            FirstName = FirstName,
            LastName = LastName,
            Email = Email,
            Phone = Phone,
        };
    }
    
    public event Action<object?>? CloseAction;
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(ToEditRequest());
    }
}