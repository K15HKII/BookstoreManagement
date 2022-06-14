using System.Collections.ObjectModel;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using BookstoreManagement.ViewModels.Home.BookAdapter;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels.Storage;

public partial class StorageLogViewModel : BaseViewModel
{

    private readonly IModelRemote _model;
    private readonly IViewModelFactory _factory;

    public StorageLogViewModel([NotNull] ScheluderProvider scheluderProvider, IModelRemote model, IViewModelFactory factory) : base(scheluderProvider)
    {
        _model = model;
        _factory = factory;
    }

    public void adjust(Book book, int quantity)
    {
        
    }

    [ObservableProperty] private ObservableCollection<BookItemViewModel> _books;
    [ObservableProperty] private ObservableCollection<IncomingViewModel> _incomings;

}