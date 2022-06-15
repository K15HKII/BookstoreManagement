using System.Collections.ObjectModel;
using System.Linq;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
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

    public void Adjust(Book book, int quantity)
    {
        IncomingViewModel? vm = Incomings.Where(vm => book.Id.Equals(vm.Id)).FirstOrDefault();
        if (vm == null)
        {
            vm = _factory.Create<IncomingViewModel>();
            Incomings.Add(vm);
        }

        vm.Quantity += quantity;
    }

    [ObservableProperty] private ObservableCollection<BookItemViewModel> _books;
    [ObservableProperty] private ObservableCollection<IncomingViewModel> _incomings;

}