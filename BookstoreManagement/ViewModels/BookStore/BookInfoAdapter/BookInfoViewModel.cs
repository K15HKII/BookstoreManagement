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

namespace BookstoreManagement.ViewModels.BookStore.BookInfoAdapter
{
    public partial class BookInfoViewModel : BaseViewModel<IBookInfoNavigator>
    {

        private readonly IViewModelFactory _factory;
        private readonly IModelRemote _model;

        public BookInfoViewModel(IBookInfoNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider, IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _factory = factory;
            _model = model;
        }

        [ObservableProperty] private object? bookImage;

        [ObservableProperty] private object? bookName;

        [ObservableProperty] private object? bookRate;

        [ObservableProperty] object? bookPrice;

        [ObservableProperty] object? bookSupplier;

        [ICommand]
        public void OpenEdit()
        {
            //TODO: cast to edit request
            object? request = Navigator!.OpenEditBookDialog(_factory.Create<EditBookViewModel>());

            if (request == null)
                return;

            //TODO: send request to server
        }

    }
}
