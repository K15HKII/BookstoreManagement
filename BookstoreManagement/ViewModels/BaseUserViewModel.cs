using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels;

public abstract partial class BaseUserViewModel : BaseViewModel
{
    
    public BaseUserViewModel([NotNull] ScheluderProvider scheluderProvider) : base(scheluderProvider)
    {
    }

    public void SetUser(User user)
    {
        this.Id = user.Id;
        this.Name = user.FullName;
        this.Email = user.Email;
        //TODO
    }

    [ObservableProperty] string? _id;
        
    [ObservableProperty] string? _image;

    [ObservableProperty] string? _name;

    [ObservableProperty] string? _email;

    [ObservableProperty] object? _type;
    
}