using System;
using System.ComponentModel.DataAnnotations;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Customer.SocialLink;

public partial class SocialLinkViewModel : BaseViewModel, IDialog
{
    private readonly IModelRemote _model;

    public SocialLinkViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
    {
        _model = model;
    }
    
    //TODO: Thêm property của mạng xã hội
    
    [ObservableProperty]
    [Required]
    private string? _id;
    
    [ObservableProperty]
    [Required]
    private string? _facebooklink;
    
    [ObservableProperty]
    [Required]
    private string? _instagramlink;
    
    public event Action<object?>? CloseAction;
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(null);
    }
}