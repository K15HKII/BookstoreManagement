using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.Input;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Annotations;
using BookstoreManagement.Utils;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagement.ViewModels.DialogView.BookStore
{
    public partial class EditBookViewModel : BaseViewModel, IDialog
    {
        private readonly IModelRemote _model;

        public EditBookViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
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
        private int? _price;


        [ObservableProperty] 
        [Required] 
        private int? _quantity;

        [NotNull]
        [ItemNotNull]
        public List<Publisher> PublisherSource
        {
            get
            {
                List<Publisher>? publisherSource = null;
                Dispose(_model.getListPublisher(), result => publisherSource = result);
                return publisherSource!;
            }
        }
        [ObservableProperty] private Publisher? _publisher;

        [ObservableProperty] object? _type;
        [ObservableProperty] ObservableCollection<object>? _bookImages;
        [ObservableProperty] object? _description;

        public BookProfileEditRequest? ToEditRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new BookProfileEditRequest()
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
