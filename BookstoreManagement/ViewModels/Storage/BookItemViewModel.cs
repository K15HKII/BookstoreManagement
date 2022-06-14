using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.Storage;

public partial class BookItemViewModel : BaseBookViewModel
{
    
    public StorageLogViewModel Log { get; set; }
    
    public BookItemViewModel([NotNull] ScheluderProvider scheluderProvider, [NotNull] IModelRemote model) : base(scheluderProvider, model)
    {
    }

    [ICommand]
    public void Click()
    {
        Log.adjust(current, 1);
    }
    
}