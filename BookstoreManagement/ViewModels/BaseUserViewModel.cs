using System;
using System.ComponentModel.DataAnnotations;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels;

public abstract partial class BaseUserViewModel : BaseViewModel
{
    private readonly IModelRemote _model;   
    public BaseUserViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
    {
        _model = model;
    }
        protected User current;
    public void SetUser(User user)
    {
        current = user;
        this.Id = user.Id;
        this.FirstName = user.FirstName;
        this.LastName = user.LastName;
        this.Email = user.Email;
        this.Image = user.Avatar;
        this.UserName = user.Username;
        this.Gender = user.Gender;
        this.Phone = user.Phone;
        Dispose(_model.GetAddresses(user.Id), list =>
        {
            UserAddress add = list[0];
            this.Address = add.Address + " , " + add.Ward + " , " + add.District + " , " + add.City;
        });
        /*this.Address =*/
        this.BirthDay = user.BirthDay.Value;
        this.CreateAt = user.CreateAt.Value;
    }

    [ObservableProperty] [Required] string? _id;
        
    [ObservableProperty] Image? _image;

    [ObservableProperty] string? _name;

    [ObservableProperty] [Required] string? _firstName;
    [ObservableProperty] [Required] string? _lastName;
    
    [ObservableProperty]
    [Required]
    string? _userName;
    
    [ObservableProperty]
    [Required]
    string? _password;

    [ObservableProperty]
    [Required]
    string? _confirmPassword;

    [ObservableProperty] string? _email;

    [ObservableProperty] object? _type;

    [ObservableProperty] DateTime? _createAt;
    
    [ObservableProperty] string? _phone;
    
    [ObservableProperty] DateTime? _birthDay;
    
    [ObservableProperty] Gender? _gender;
    
    [ObservableProperty] string? _address;

}