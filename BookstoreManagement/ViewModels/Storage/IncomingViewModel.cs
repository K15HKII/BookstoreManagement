using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels.Storage;

public partial class IncomingViewModel : BaseBookViewModel
{
    public IncomingViewModel([NotNull] ScheluderProvider scheluderProvider, [NotNull] IModelRemote model) : base(scheluderProvider, model)
    {
    }

    [ObservableProperty] private int _quantity = 0;

}