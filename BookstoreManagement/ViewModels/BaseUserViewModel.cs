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
        current = user;
        this.Id = user.Id;
        this.Name = user.FullName;
        this.Email = user.Email;
        this.UserName = user.Username;
        this.Gender = user.Gender;
        this.Phone = user.Phone;
        this.Password = user.Password;
        this.Birth = user.BirthDay;
        this.CreateDate = user.CreateAt;
    }

    protected User current;

    [ObservableProperty]
    [Required]
    private string? _id;

    [ObservableProperty]
    [Required]
    private string? _name;

    [ObservableProperty]
    [Required]
    private string? _userName;

    [ObservableProperty]
    [Required]
    private string? _password;

    [ObservableProperty]
    [Required]
    private string? _confirmpassword;

    [ObservableProperty]
    [Required]
    private Gender? _gender;

    [ObservableProperty]
    [Required]
    private string? _phone;


    [ObservableProperty]
    [Required]
    private DateTime? _birth;

    [ObservableProperty]
    [Required]
    private DateTime? _createDate;

    [ObservableProperty]
    [Required]
    private string? _email;

    [ObservableProperty]
    [Required]
    private Role? _type;

}