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
    public partial class BookDialogViewModel : BaseBookViewModel<IBookDetailNavigator>, IDialog
    {
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;

        public BookDialogViewModel(IBookDetailNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
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
