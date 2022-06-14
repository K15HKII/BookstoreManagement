using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Dialog.Customer
{
    public partial class UpdateCustomerViewModel : BaseUserViewModel, IDialog
    {

        private readonly IModelRemote _model;

        public UpdateCustomerViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider, model)
        {
            _model = model;
        }

        public User user;

        public UserUpdateRequest? ToRequest()
        {
            ValidateProperties();

            if (HasErrors)
                return null;

            return new UserUpdateRequest()
            {
                FirstName = Name,
                Email = Email,
                Username = UserName,
                Phone = Phone,
                Gender = (Gender)Gender,
                Birthday = BirthDay,
                Create_at = CreateAt,
            };
        } 

        public event Action<object?> CloseAction;

        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }

        [ICommand]
        public void Accept()
        {
            CloseAction?.Invoke(ToRequest());
        }
    }
}
