using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.Manager
{
    public partial class UpdateEmployeeViewModel : BaseUserViewModel, IDialog
    {
        private readonly IModelRemote _model;

        public UpdateEmployeeViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider, model)
        {
            _model = model;
        }

        [ObservableProperty]
        [Required]
        private string? _character;

        public UserUpdateRequest? ToAddRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new UserUpdateRequest()
            {
                FirstName = FirstName,
                LastName = LastName,
                Gender = (Gender)Gender,
                Phone = Phone,
                Email = Email,
                Create_at = CreateDate,
                Birthday = Birth,
                Password = Password,
                Username = UserName,
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
