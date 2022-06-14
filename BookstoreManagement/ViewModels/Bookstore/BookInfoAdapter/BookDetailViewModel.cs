using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
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
    public partial class BookDetailViewModel : BaseBookViewModel, ICRUD
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IBookInfoNavigator _navigator;

        public BookDetailViewModel(IBookInfoNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,
            IViewModelFactory factory, IModelRemote model) : base(scheluderProvider, model)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
        }

        public void SetBook(Book book)
        {
            this._book = book;
            this.Id = book.Id;
            this.Title = book.Title;
            this.Price = (double) book.Price + "đ";
            Dispose(_model.GetPublisher(book.PublisherId), publisher =>
            {
                if (publisher == null)
                    return;
                this.Publisher = publisher.Name;
            });
            this.Description = book.Description;
            this.Display = book.Images == null || book.Images.Count == 0 ? null : book.Images![0].Id;
        }

        private Book _book;

        [ObservableProperty] string? _id;

        [ObservableProperty] string? _title;

        [ObservableProperty] string? _description;

        [ObservableProperty] object? _stock;

        [ObservableProperty] object? _price;

        [ObservableProperty] object? _publisherId;

        [ObservableProperty] string? _publisher;

        [ObservableProperty] BookTag? _tag;

        [ObservableProperty] private string? _display;

        [ICommand]
        public async void OpenInfo()
        {
            BookDialogViewModel vm = _factory.Create<BookDialogViewModel>();
            vm.DialogCRUDEvent += DialogCRUDEvent;
            vm.SetBook(this._book, this.Id);
            await _navigator.OpenInfoBookDialog(vm);
        }

        public event DialogCRUDEventHandler? DialogCRUDEvent;
    }
}