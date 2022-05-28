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
    public partial class AddBookViewModel : BaseViewModel, IDialog
    {

        private readonly IModelRemote _model;

        public AddBookViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model) : base(scheluderProvider)
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

        [ObservableProperty] private object? _type;
        [ObservableProperty] private ObservableCollection<object>? _bookImages;
        [ObservableProperty] private string? _description;

        public BookProfileAddRequest? ToAddRequest()
        {
            ValidateAllProperties();

            if (HasErrors)
                return null;

            return new BookProfileAddRequest()
            {

            };
        }

        public event Action<object?>? CloseAction;

        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(ToAddRequest());
        }
    }
}
