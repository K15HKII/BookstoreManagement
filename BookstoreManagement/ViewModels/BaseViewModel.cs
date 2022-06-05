using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels;

public abstract partial class BaseViewModel : ObservableValidator
{

    [ObservableProperty] private bool _isLoading = false;

    protected readonly CompositeDisposable _disposables = new CompositeDisposable();

    public ScheluderProvider ScheluderProvider { get; }

    protected BaseViewModel(ScheluderProvider scheluderProvider) : this()
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
    
    protected void ValidateProperties()
    {
        foreach (var propertyInfo in GetType().GetProperties())
        {
            bool validate = propertyInfo.GetCustomAttributes(typeof(ValidationAttribute), true).Any();
            if (validate)
            {
                ValidateProperty(propertyInfo.GetValue(this), propertyInfo.Name);
            }
        }
    }

}
