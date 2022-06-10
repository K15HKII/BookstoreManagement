using System;
using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.Input;

namespace BookstoreManagement.ViewModels.DialogView;

public partial class LendBillDetailViewModel : BaseViewModel, IDialog
{
    private readonly IModelRemote _model;
    private readonly IViewModelFactory _factory;
    private readonly ILendBillDetailNavigator _navigator;

    public LendBillDetailViewModel(ILendBillDetailNavigator navigator, [NotNull] ScheluderProvider scheluderProvider,IViewModelFactory factory, IModelRemote model) : base(scheluderProvider)
    {
        _navigator = navigator;
        _model = model;
        _factory = factory;
    }
    
    public event Action<object?>? CloseAction;
    
    [ICommand]
    public void Close()
    {
        CloseAction?.Invoke(null);
    }
}