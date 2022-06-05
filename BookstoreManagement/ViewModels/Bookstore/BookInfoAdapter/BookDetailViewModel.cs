using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using Microsoft.Toolkit.Mvvm.Input;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.ViewModels.BookStore.BookInfoAdapter
{
    public partial class BookDetailViewModel : BaseBookViewModel
    {

        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public BookDetailViewModel(IBookInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }
        
        public void SetBook(Book book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Description = book.Description;
            //TODO:
        }

        [ObservableProperty] object? _id;

        [ObservableProperty] string? _title;

        [ObservableProperty] string? _description;

        [ObservableProperty] object? _stock;

        [ObservableProperty] object? _authorId;

        [ObservableProperty] double? _price;

        [ObservableProperty] object? _publisherId;

        [ObservableProperty] BookTag? _tag;

        [ICommand]
        public void OpenInfo()
        {
            //TODO: cast to edit request
            /*object? request = _navigator.OpenInfoBookDialog(_factory.Create<DialogView.BookStore.BookDialogViewModel>());

            if (request == null)
                return;*/

            //TODO: send request to server
        }
        
    }
}
