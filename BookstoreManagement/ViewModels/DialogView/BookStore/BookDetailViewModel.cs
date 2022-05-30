using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView.BookStore
{
    public partial class BookDetailViewModel : BaseViewModel<IBookDetailNavigator>, IDialog
    {
        private readonly IModelRemote _model;
        private readonly IViewModelFactory _factory;

        public BookDetailViewModel(IBookDetailNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(navigator, scheluderProvider)
        {
            _model = model;
            _factory = factory;
        }
        
        [ObservableProperty] object? _id;
        [ObservableProperty] object? _name;
        [ObservableProperty] ObservableCollection<object>? _bookimages;
        [ObservableProperty] object? _price;
        [ObservableProperty] object? _discount;
        [ObservableProperty] object? _priceafterdiscount;
        [ObservableProperty] object? _quantity;
        [ObservableProperty] object? _soldquantity;
        [ObservableProperty] object? _supplier;
        [ObservableProperty] object? _type;
        [ObservableProperty] object? _description;
        
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
