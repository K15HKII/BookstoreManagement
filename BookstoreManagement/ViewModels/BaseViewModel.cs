using System;
using System.Reactive.Disposables;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels;

public abstract class BaseViewModel<N> : BaseViewModel where N : INavigator
{

    protected N Navigator { get; set; }

    protected readonly CompositeDisposable _disposables = new CompositeDisposable();

    public void dispose(IDisposable disposable)
    {
        _disposables.Add(disposable);
    }

}

public abstract class BaseViewModel : ObservableValidator
{
    
}
