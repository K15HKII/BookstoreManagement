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
using BookstoreManagement.ViewModels.BookStore.BookInfoAdapter;
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
                BookDetailViewModel vm = _factory.Create<BookDetailViewModel>();
                vm.DialogCRUDEvent += () => Initialize();
                ++Quantity;
                string a = Quantity.ToString();
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


        [ObservableProperty] private ObservableCollection<BookDetailViewModel> _books = new();

        [ObservableProperty] private int _quantity = 0;

        [ObservableProperty] private ObservableCollection<BookDetailViewModel> _selectedBooks = new();

        [ICommand]
        public async void AddNew()
        {
            UpdateBookViewModel vm = _factory.Create<UpdateBookViewModel>();
            BookUpdateRequest? request = await _navigator.OpenUpdateBookDialog(vm);
            if (request == null)
                return;

            Dispose(_model.CreateBook(request!), book =>
            {
                Console.WriteLine("Book created successfully");
                Initialize();
            });
        }

    }
}