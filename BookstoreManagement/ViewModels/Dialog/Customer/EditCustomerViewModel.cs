using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.DialogView.Customer
{
    public partial class EditCustomerViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;

        public EditCustomerViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }


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
        private string? _gender;

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
}
