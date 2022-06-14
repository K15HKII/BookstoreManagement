using BookstoreManagement.Data.Remote;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.ViewModels.Dialog.Lend
{
    public partial class UpdateLendBillViewModel : BaseLendBillViewModel, IDialog
    {

        private readonly IModelRemote _model;

        public UpdateLendBillViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider, model)
        {
            this._model = model;
        }

        public LendUpdateRequest? ToRequest()
        {
            ValidateProperties();

            if (HasErrors)
                return null;

            return new LendUpdateRequest()
            {
                Start = (DateTime)LendDate,
                End = (DateTime)LendExpired,
                BookProfileId = BookId,
                UserId = UserId
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
