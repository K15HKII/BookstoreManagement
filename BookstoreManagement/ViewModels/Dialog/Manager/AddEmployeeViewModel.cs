using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api.Customer;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Manager
{
    public partial class AddEmployeeViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;

        public AddEmployeeViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
        {
            _model = model;
        }

        [ObservableProperty]
        [Required]
        private string? _id;
        
        [ObservableProperty] 
        [Required]
        private string? _userName;

        [ObservableProperty] 
        [Required]
        private string? _image;
        
        [ObservableProperty] 
        [Required]
        private string? _name;
        
        [ObservableProperty] 
        private DateTime? _dayCreate;
        
        [ObservableProperty] 
        [Required]
        private string? _gender;
        
        [ObservableProperty] 
        [Required]
        private string? _character;
        
        [ObservableProperty] 
        [Required]
        private DateTime? _birth;
        
        [ObservableProperty]
        [Required]
        private string? _phone;
        
        [ObservableProperty] 
        [Required]
        private string? _email;
        
        public UserUpdateRequest? ToAddRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new UserUpdateRequest()
            {

            };
        }
        public event Action<object?>? CloseAction;
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public void Accept()
        {
            CloseAction?.Invoke(ToAddRequest());
        }
    }
}
