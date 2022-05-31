using BookstoreManagement.Annotations;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Utils;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BookstoreManagement.ViewModels;

public partial class BaseBookViewModel<TNavigator> : BaseViewModel<TNavigator> where TNavigator : INavigator
{
    public BaseBookViewModel(TNavigator? navigator, [NotNull] ScheluderProvider scheluderProvider) : base(navigator, scheluderProvider)
    {
    }

    public BaseBookViewModel([NotNull] ScheluderProvider scheluderProvider) : base(scheluderProvider)
    {
    }

    [ObservableProperty] private string? _id;
    [ObservableProperty] private string? _name;
    [ObservableProperty] private string? _description;
    [ObservableProperty] private BookTag[] _tags;
    [ObservableProperty] private string? _authorName;
    [ObservableProperty] private string? _publisherName;
    [ObservableProperty] private decimal? _price;
    [ObservableProperty] private int? _quantity;
    
}