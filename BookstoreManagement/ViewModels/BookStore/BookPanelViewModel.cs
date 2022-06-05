using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.DialogView.BookStore;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.BookStore
{
    public partial class BookPanelViewModel : PanelViewModel
    {
        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;
        private readonly IBookStoreNavigator _navigator;

        public BookPanelViewModel(IBookStoreNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,
            IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
        {
            _navigator = navigator;
            _factory = factory;
            _model = model;
            Initialize();
        }

        private void Initialize()
        {
            Dispose(_model.GetBooks().Select(books => books.Select(book =>
            {
                BookDialogViewModel vm = _factory.Create<BookDialogViewModel>();
                vm.SetBook(book);
                return vm;
            })), books =>
            {
                Books.Clear();
                foreach (var vm in books)
                {
                    Books.Add(vm);
                }
            });
        }


        [ObservableProperty] private ObservableCollection<BookDialogViewModel> _books = new();

        [ObservableProperty] private ObservableCollection<BookDialogViewModel> _selectedBooks = new();

        [ICommand]
        public async void AddNew()
        {
            BookUpdateRequest? request = await _navigator.OpenUpdateBookDialog(_factory.Create<UpdateBookViewModel>());
            if (request == null)
                return;

            Dispose(_model.CreateBook(request!), book =>
            {
                Console.WriteLine("Book created successfully");
                Initialize();
                //TODO: Notify
            });
        }

    }
}