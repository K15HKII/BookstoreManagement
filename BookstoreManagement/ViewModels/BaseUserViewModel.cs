using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagement.ViewModels;

public abstract partial class BaseUserViewModel : BaseViewModel
{
    private readonly IModelRemote _model;

    public BaseUserViewModel([NotNull] ScheluderProvider scheluderProvider, Data.Remote.IModelRemote model) : base(scheluderProvider)
    {
        this._model = model;
    }

    public void SetUser(User user)
    {
        this.Id = user.Id;
        this.Name = user.FullName;
        this.Email = user.Email;
        this.Username = user.Username;
        this.Gender = user.Gender;
        this.Phone = user.Phone;
        this.Password = user.Password;
        this.Birthday = user.BirthDay;
        this.CreateAt = user.CreateAt;
    }

    [ObservableProperty] string? _id;
        
    [ObservableProperty] string? _image;

    [ObservableProperty] [Required] [MinLength(1)] 
    string? _name;

    [ObservableProperty] string? _email;

    [ObservableProperty] Role? _type;

    [ObservableProperty] [Required] [MinLength(1)] 
    string? _username;

    [ObservableProperty] [Required] [MinLength(1)] 
    string? _password;

    [ObservableProperty] DateTime? _birthday;

    [ObservableProperty] string? _phone;

    [ObservableProperty] [Required] [MinLength(1)]
     Gender? _gender;

    [ObservableProperty] DateTime? _createAt;

}