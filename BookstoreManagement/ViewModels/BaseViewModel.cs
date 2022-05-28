using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Media.TextFormatting;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels;

public abstract class BaseViewModel<N> : BaseViewModel where N : INavigator
{

    protected N? Navigator { get; set; }

    protected BaseViewModel(N? navigator, ScheluderProvider scheluderProvider) : base(scheluderProvider)
    {
        Navigator = navigator;
    }

    protected BaseViewModel(ScheluderProvider scheluderProvider) : base(scheluderProvider)
    {
    }

    protected BaseViewModel() : base(null)
    {

    }

}

public abstract partial class BaseViewModel : ObservableValidator
{

    [ObservableProperty] private bool _isLoading = false;

    protected readonly CompositeDisposable _disposables = new CompositeDisposable();

    public ScheluderProvider ScheluderProvider { get; }

    protected BaseViewModel(ScheluderProvider scheluderProvider)
    {
        ScheluderProvider = scheluderProvider;
    }

    protected BaseViewModel()
    {

    }

    public void Dispose(IDisposable disposable)
    {
        _disposables.Add(disposable);
    }

    public void Dispose<T>(IObservable<T> observable, Action<T> action)
    {
        Dispose(observable
            .SubscribeOn(ScheluderProvider.IO())
            .ObserveOn(ScheluderProvider.UI())
            .Subscribe(action));
    }

}
