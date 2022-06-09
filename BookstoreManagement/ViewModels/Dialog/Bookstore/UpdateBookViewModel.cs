using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.BookStore
{
    public partial class UpdateBookViewModel : BaseBookViewModel, IDialog
    {

        private readonly IModelRemote _model;

        public UpdateBookViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider,model)
        {
            _model = model;
        }

        public BookUpdateRequest? ToRequest()
        {
            ValidateProperties();

            if (HasErrors)
                return null;

            return new BookUpdateRequest()
            {
                Title = Title,
                Description = Description,
                Price = Price ?? 1.0,
            };
        }

        public event Action<object?>? CloseAction;

        [ICommand]
        public void Accept()
        {
            CloseAction?.Invoke(ToRequest());
        }

        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
    }
}
