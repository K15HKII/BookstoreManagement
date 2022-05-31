using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
    public partial class BookPanelViewModel : BaseViewModel<IBookStoreNavigator>
    {

        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public BookPanelViewModel(IBookStoreNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        // Thiếu mở dialog thêm sách
        public void openAccount() { }

        public void openNotificaiton() { }

        [ObservableProperty] public ObservableCollection<BookDialogViewModel>? _books;

        [ObservableProperty] public ObservableCollection<BookDialogViewModel>? _selectedBooks;

        [ICommand]
        public void AddNew()
        {
            BookProfileAddRequest? request = Navigator!.OpenNewBookDialog(_factory.Create<AddBookViewModel>());
            if (request == null)
                return;

            //TODO: Send request through IModelRemote
        }

    }
}
