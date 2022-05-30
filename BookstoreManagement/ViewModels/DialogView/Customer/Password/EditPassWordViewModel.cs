using System;
using System.ComponentModel.DataAnnotations;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Customer.Password;

public partial class EditPassWordViewModel : BaseViewModel, IDialog
{
    private readonly IModelRemote _model;

    public EditPassWordViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
    {
        _model = model;
    }
    
    //TODO: thêm property của password
    [ObservableProperty]
    [Required]
    private string? _id;
    
    [ObservableProperty]
    [Required]
    private string? _oldpass;
    
    [ObservableProperty]
    [Required]
    private string? _newpass;
    
    [ObservableProperty]
    [Required]
    private string? _confirmpass;
    
    public event Action<object?>? CloseAction;
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(null);
    }
}