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
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.BookStore
{
    public partial class BookDialogViewModel : BaseBookViewModel, IDialog
    {
        
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;
        private readonly IBookDetailNavigator _navigator;

        public BookDialogViewModel(IBookDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider,model)
        {
            _navigator = navigator;
            _model = model;
            _factory = factory;
        }

        [ObservableProperty] object? _sold;

        public event Action<object?>? CloseAction;
        
        [ICommand]
        public void Close()
        {
            CloseAction?.Invoke(null);
        }
        
        [ICommand]
        public async void OpenEdit()
        {
            BookUpdateRequest? request = await _navigator.OpenEditBookDialog(_factory.Create<UpdateBookViewModel>());
            if (request == null)
                return;

            Dispose(_model.CreateBook(request!), book =>
            {
                Console.WriteLine("Book updated successfully");
            });
        }
    }
}
